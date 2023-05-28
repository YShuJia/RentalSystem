using RentalSystem.Entity;
using RentalSystem.Mapper;
using RentalSystem.UserForm;
using System;
using System.Windows.Forms;

namespace RentalSystem.Common
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public Login(App app)
        {
            InitializeComponent();
            this.app = app; 
        }

        App app;

        UserMapper userMapper;

        AdminMapper adminMapper;

        OwnerMapper ownerMapper;
        R r;

        //登录
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || pass.Text == "")
            {
                warn_label.Text = "请输入账号和密码...";
                return;
            }
            else
            {
                if (u.Checked)
                {
                    userMapper = new UserMapper();
                    r = userMapper.login(id.Text,pass.Text);
                    if (r.IsOK)
                    {
                        UserEntity user = (UserEntity) r.Obj;
                        app.openForm(new UserApp(app,user));
                    }
                    warn_label.Text = r.Msg;
                }
                else if(o.Checked)
                {
                    Console.WriteLine("房主");
                }
                else
                {
                    Console.WriteLine("管理员");
                }
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            app.openForm(new Register(app));
        }

        private void change(object sender, EventArgs e)
        {
            warn_label.Text = "";
        }
    }
}
