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
    public partial class UpdatePassForm : Form
    {
        public UpdatePassForm()
        {
            InitializeComponent();
        }
        public UpdatePassForm(App app, AdminEntity admin)
        {
            InitializeComponent();
            this.admin = admin;
            this.app = app;
        }

        public UpdatePassForm(App app, UserEntity user)
        {
            InitializeComponent();
            this.user = user;
            this.app = app;
        }

        public UpdatePassForm(App app, OwnerEntity owner)
        {
            InitializeComponent();
            this.owner = owner;
            this.app = app;
        }

        AdminEntity admin;

        UserEntity user;

        OwnerEntity owner;

        App app;

        R r;

        private void submit_Click(object sender, EventArgs e)
        {
            if (o_pass.Text == "" || n_pass.Text == "" || n_s_pass.Text == "")
            {
                warn_label.Text = "密码不能为空...";
            }
            else if (n_pass.Text != n_s_pass.Text)
            {
                warn_label.Text = "两次密码不一致...";
            }
            else
            {
                if (admin!=null && o_pass.Text == admin.A_pass)
                {
                    AdminMapper adminMapper = new AdminMapper();
                    r = adminMapper.updatePassById(admin.A_id, n_pass.Text);
                }
                else if (user != null && o_pass.Text == user.U_pass)
                {
                    UserMapper userMapper = new UserMapper();
                    r = userMapper.updatePassById(user.U_id, n_pass.Text);
                }
                else if (owner != null && o_pass.Text == owner.O_pass)
                {
                    OwnerMapper ownerMapper = new OwnerMapper();
                    r = ownerMapper.updatePassById(owner.O_id, n_pass.Text);
                }
                else
                {
                    warn_label.Text = "旧密码不正确...";
                    return;
                }
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
