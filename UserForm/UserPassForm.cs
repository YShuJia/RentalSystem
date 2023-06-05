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
using RentalSystem.Common;

namespace RentalSystem.UserForm
{
    public partial class UserPassForm : Form
    {
        public UserPassForm()
        {
            InitializeComponent();
        }
        public UserPassForm(UserEntity user, App app)
        {
            InitializeComponent();
            this.user = user;
            this.app = app; 
        }

        UserEntity user;

        App app;

        R r;

        UserMapper userMapper = new UserMapper();

        private void submit_Click(object sender, EventArgs e)
        {
            if (o_pass.Text == "" || n_pass.Text == "" || n_s_pass.Text == "")
            {
                warn_label.Text = "密码不能为空...";
            }
            else if(n_pass.Text!=n_s_pass.Text)
            {
                warn_label.Text = "两次密码不一致...";
            }
            else if(o_pass.Text!=user.U_pass)
            {
                warn_label.Text = "旧密码不正确...";
            }
            else
            {
                r = userMapper.updatePassById(user.U_id, n_pass.Text);
                warn_label.Text = r.Msg;
                if (r.IsOK)
                {
                    MessageBox.Show(r.Msg + "即将退出重新登录...");
                    app.openForm(new Login(app));
                }
            }
        }

        private void o_pass_TextChanged(object sender, EventArgs e)
        {
            warn_label.Text = "";
        }
    }
}
