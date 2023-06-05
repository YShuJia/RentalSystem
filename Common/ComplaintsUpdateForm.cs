using MySqlX.XDevAPI.Common;
using RentalSystem.Entity;
using RentalSystem.Mapper;
using RentalSystem.OwnerForm;
using RentalSystem.UserForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalSystem.Common
{
    public partial class ComplaintsUpdateForm : Form
    {
        public ComplaintsUpdateForm()
        {
            InitializeComponent();
        }
        public ComplaintsUpdateForm(Form form, ComplaintsEntity complaints, bool isUser)
        {
            InitializeComponent();
            this.complaints = complaints;
            this.isUser = isUser;
            this.form = form;
        }
        bool isUser;

        Form form;

        ComplaintsEntity complaints;

        ComplaintsMapper complaintsMapper = new ComplaintsMapper();

        R r;

        string n_result;

        private void submit_Click(object sender, EventArgs e)
        {
            if ((n_result != "" && point.Text!="")||(n_result != "" && money.Text != "")) {
                if (MessageBox.Show("确定要修改协商结果？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    complaints.C_schedule = 1;
                    if (!isUser)
                    {
                        complaints.C_schedule = -1;
                    }
                    complaints.C_result = n_result;
                    r = complaintsMapper.updateR_S_S(complaints);
                    MessageBox.Show(r.Msg);
                    if (r.IsOK)
                    {
                        if (isUser)
                        {
                            ((UserHandleForm)form).delete();
                        }
                        else
                        {
                            ((OwnerHandleForm)form).deleteD3();
                        }
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("请输入协商内容...");
            }
        }

        private void UserComplaintsForm_Load(object sender, EventArgs e)
        {
            content.Text = complaints.C_content;
            string[] s = complaints.C_result.Split('‘', '’');
            n_result = complaints.C_result;
            if (complaints.C_result.IndexOf("积") >= 0)
            {
                point.Text = s[1];
            }
            else if(complaints.C_result.IndexOf("金") >= 0)
            {
                money.Text = s[1];
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //同意
        private void agree_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定同意协商结果？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string[] s = complaints.C_result.Split('‘', '’');
                OwnerMapper ownerMapper = new OwnerMapper();
                UserMapper userMapper = new UserMapper();
                TransferMapper transferMapper = new TransferMapper();
                int x = Convert.ToInt32(s[1]);

                TransferEntity transfer = new TransferEntity();
                transfer.T_id = Utils.getTimeTicks();
                transfer.T_time = DateTime.Now;
                transfer.T_plaintiff_id = complaints.C_something;
                transfer.T_object_id = complaints.C_plaintiff;
                transfer.T_amount = x;

                complaints.C_state = 1;
                if (complaints.C_result.IndexOf("积") >= 0 && complaintsMapper.updateComplaints(complaints).IsOK)
                {
                    if (complaints.C_type == "用户")
                    {
                        r = ownerMapper.updatePointById(complaints.C_something, x, false);
                    }
                    else if (complaints.C_type == "房主")
                    {
                        r = userMapper.updatePointById(complaints.C_something, x, false);
                    }
                }
                else if (complaints.C_result.IndexOf("金") >= 0 && complaintsMapper.updateComplaints(complaints).IsOK)
                {

                    if (complaints.C_type == "用户")
                    {
                        transfer.T_state = -1;
                    }
                    else if (complaints.C_type == "房主")
                    {
                        transfer.T_state = 1;
                    }
                    r = transferMapper.insertUandO(transfer);
                }

                MessageBox.Show(r.Msg);
                if (r.IsOK)
                {
                    this.Close();
                    if (isUser)
                    {
                        ((UserHandleForm)form).delete();
                    }
                    else
                    {
                        ((OwnerHandleForm)form).deleteD3();
                    }
                }
            }
        }

        private void money_TextChanged(object sender, EventArgs e)
        {
            point.Text = "";
            if (money.Text != "" && !Regex.IsMatch(money.Text, "^([0-9]{1,})$"))
            {
                money.Text = "";
                MessageBox.Show("请输入整数...");
            }
            n_result = "金额赔偿‘" + money.Text + "’元";
        }

        private void point_TextChanged(object sender, EventArgs e)
        {
            money.Text = "";
            if (point.Text != "" && !Regex.IsMatch(point.Text, "^([0-9]{1,})$"))
            {
                point.Text = "";
                MessageBox.Show("请输入整数...");
            }
            n_result = "积分扣除‘" + point.Text + "’点";
        }

        private void admin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要请管理员介入？", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                complaints.C_schedule = 0;
                r = complaintsMapper.updateR_S_S(this.complaints);
                MessageBox.Show(r.Msg);
                if (r.IsOK)
                {
                    this.Close();
                    if (isUser)
                    {
                        ((UserHandleForm)form).delete();
                    }
                    else
                    {
                        ((OwnerHandleForm)form).deleteD3();
                    }
                }
            }
        }
    }
}
