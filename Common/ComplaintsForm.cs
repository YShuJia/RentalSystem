using RentalSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentalSystem.Common;
using RentalSystem.Mapper;
using System.Text.RegularExpressions;
using RentalSystem.OwnerForm;

namespace RentalSystem.UserForm
{
    public partial class ComplaintsForm : Form
    {
        public ComplaintsForm()
        {
            InitializeComponent();
        }

        public ComplaintsForm(ComplaintsEntity complaints)
        {
            InitializeComponent();
            this.complaints = complaints;
        }

        public ComplaintsForm(OwnerHandleForm ownerHandle, ComplaintsEntity complaints)
        {
            InitializeComponent();
            this.complaints = complaints;
            this.ownerHandle = ownerHandle;
        }

        ComplaintsEntity complaints; 

        ComplaintsMapper complaintsMapper = new ComplaintsMapper();

        R r;

        OwnerHandleForm ownerHandle;

        string result = "";

        private void submit_Click(object sender, EventArgs e)
        {
            if(content.Text != "" &&
                MessageBox.Show("确定要投诉吗？","警告",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                complaints.C_content = content.Text;
                complaints.C_result = result;
                r = complaintsMapper.insert(complaints);
                MessageBox.Show(r.Msg);
                if (r.IsOK && ownerHandle!=null)
                {
                    this.Close();
                    ownerHandle.deleteD4();
                }
                else if(r.IsOK)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("请输入投诉内容...");
            }
        }

        private void UserComplaintsForm_Load(object sender, EventArgs e)
        {
            object_id.Text = complaints.C_something.ToString();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void money_TextChanged(object sender, EventArgs e)
        {
            point.Text = "";
            if(money.Text!="" && !Regex.IsMatch(money.Text, "^([0-9]{1,})$"))
            {
                money.Text = "";
                MessageBox.Show("请输入整数...");
            }
            result = "金额赔偿‘" + money.Text + "’元";
        }

        private void point_TextChanged(object sender, EventArgs e)
        {
            money.Text = "";
            if (point.Text!="" && !Regex.IsMatch(point.Text, "^([0-9]{1,})$"))
            {
                point.Text = "";
                MessageBox.Show("请输入整数...");
            }
            result = "积分扣除‘" + point.Text + "’点";
        }
    }
}
