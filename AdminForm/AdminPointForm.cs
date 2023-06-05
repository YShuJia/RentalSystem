using MySqlX.XDevAPI.Common;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using RentalSystem.Common;

namespace RentalSystem.AdminForm
{
    public partial class AdminPointForm : Form
    {
        public AdminPointForm()
        {
            InitializeComponent();
        }

        public AdminPointForm(Form form, UserEntity user, OwnerEntity owner)
        {
            InitializeComponent();
            this.user = user;
            this.owner = owner;
            this.form = form;
        }

        UserEntity user;

        OwnerEntity owner;

        Form form;

        R r;

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (n_point.Text == "" && type.Text == ""
                && MessageBox.Show("您还没有选择处理方式!", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                return;
            }
            if(MessageBox.Show("确定要执行该操作?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                UserMapper userMapper = new UserMapper();
                OwnerMapper ownerMapper = new OwnerMapper();

                int point;
                if (user != null)
                {
                    if (type.Text == "扣除")
                        point = user.U_point - Convert.ToInt32(n_point.Text);
                    else
                        point = user.U_point + Convert.ToInt32(n_point.Text);

                    r = userMapper.updatePointById(user.U_id, point);
                    if (r.IsOK)
                        ((AdminUserForm)form).update(point);
                }
                else
                {
                    if (type.Text == "扣除")
                        point = owner.O_point - Convert.ToInt32(n_point.Text);
                    else
                        point = owner.O_point + Convert.ToInt32(n_point.Text);
                    r = ownerMapper.updatePointById(owner.O_id, point);
                    if (r.IsOK)
                        ((AdminOwnerForm)form).update(point);
                }
                MessageBox.Show(r.Msg);
                if (r.IsOK)
                    this.Close();
            }
        }

        private void AdminComplaintForm_Load(object sender, EventArgs e)
        {
            if(user!=null)
            {
                id.Text = user.U_id;
                name.Text = user.U_name;
                tel.Text = user.U_tel;
                sex.Text = user.U_sex;  
                point.Text = user.U_point.ToString();
            }
            else
            {
                id.Text = owner.O_id;
                name.Text = owner.O_name;   
                tel.Text = owner.O_tel;
                sex.Text = owner.O_sex;
                point.Text = owner.O_point.ToString();
            }
        }
    }
}
