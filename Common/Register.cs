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

namespace RentalSystem.Common
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        public Register(App app)
        {
            InitializeComponent();
            this.app = app; 
        }

        App app;

        UserEntity user;

        OwnerEntity owner;

        UserMapper userMapper;

        OwnerMapper ownerMapper;

        R r;

        private void loginButton_Click(object sender, EventArgs e)
        {
            app.openForm(new Login(app));
        }

        //注册
        private void submit_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || pass.Text == "" || tel.Text==""||sure_pass.Text=="" ||name.Text=="")
            {
                warn_label.Text = "请将信息填写完整...";
            }
            else if(pass.Text!=sure_pass.Text)
            {
                warn_label.Text = "密码不一致...";
            }
            else if(u_check.Checked)
            {
                user = new UserEntity();
                user.U_id = "U_"+id.Text;
                user.U_name = name.Text;
                user.U_pass = pass.Text;
                user.U_tel = tel.Text;
                
                userMapper = new UserMapper();
                r = userMapper.register(user);
                warn_label.Text = r.Msg;
            }
            else if(o_check.Checked)
            {
                owner = new OwnerEntity();
                owner.O_id = "O_"+id.Text;
                owner.O_name = name.Text;
                owner.O_pass = pass.Text;   
                owner.O_tel = tel.Text;
                ownerMapper = new OwnerMapper();
                r = ownerMapper.register(owner);
                warn_label.Text = r.Msg;
            }
        }

        private void change(object sender, EventArgs e)
        {
            warn_label.Text = "";
        }
    }
}
