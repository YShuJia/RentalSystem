using RentalSystem.Common;
using RentalSystem.Entity;
using RentalSystem.Mapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalSystem.AdminForm
{
    public partial class AdminComplaintForm : Form
    {
        public AdminComplaintForm()
        {
            InitializeComponent();
        }

        public AdminComplaintForm(AdminHandleForm adminHandle, ComplaintsEntity complaints)
        {
            InitializeComponent();
            this.complaints = complaints;
            this.adminHandle = adminHandle;
        }

        ComplaintsEntity complaints;
        AdminHandleForm adminHandle;

        R r;

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (money.Text == "" && point.Text == ""
                && MessageBox.Show("您该没有选择处理方式!!确定要执行?", "提示", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                MessageBox.Show("操作成功...");
                this.Close();
            }
            else if(MessageBox.Show("确定要执行?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if ((money.Text == "" && point.Text != "") || (point.Text != "" && money.Text != ""))
                {
                    complaints.C_result = "积分扣除" + point.Text + "点 ";
                    if (complaints.C_type == "房主")
                    {
                        UserMapper userMapper = new UserMapper();
                        r = userMapper.updatePointById(complaints.C_something, Convert.ToInt32(point.Text), false);
                    }
                    else
                    {
                        OwnerMapper ownerMapper = new OwnerMapper();
                        r = ownerMapper.updatePointById(complaints.C_something, Convert.ToInt32(point.Text), false);
                    }
                }
                else if (money.Text != "" && point.Text=="")
                {
                    complaints.C_result = "赔偿" + money.Text + "元 ";
                    TransferEntity transfer = new TransferEntity();
                    TransferMapper transferMapper = new TransferMapper();
                    //投诉者为用户，转账给他
                    if (complaints.C_type == "用户")
                        transfer.T_state = -1;
                    else
                        transfer.T_state = 1;

                    transfer.T_plaintiff_id = complaints.C_something;
                    transfer.T_object_id = complaints.C_plaintiff;
                    transfer.T_id = Utils.getTimeTicks();
                    transfer.T_time = DateTime.Now;
                    transfer.T_amount = Convert.ToDecimal(money.Text);
                    r = transferMapper.insertUandO(transfer);
                }

                if (r.IsOK)
                {
                    ComplaintsMapper comp = new ComplaintsMapper();
                    complaints.C_state = 1;
                    r = comp.updateComplaints(complaints);
                    MessageBox.Show(r.Msg);
                    if (r.IsOK)
                    {
                        adminHandle.delete();
                        this.Close();
                    }
                }
            }
        }

        private void AdminComplaintForm_Load(object sender, EventArgs e)
        {
            plaintiff_id.Text = complaints.C_plaintiff;
            object_id.Text = complaints.C_something;
            time.Text = complaints.C_time.ToString();
            result.Text = complaints.C_result.ToString();   
            content.Text = complaints.C_content;
        }
    }
}
