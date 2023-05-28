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

        private void loginButton_Click(object sender, EventArgs e)
        {
            app.openForm(new Login(app));
        }

        private void change(object sender, EventArgs e)
        {
            warn_label.Text = "";
        }

        //注册
        private void submit_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || pass.Text == "" || tel.Text==""||sure_pass.Text=="")
            {
                warn_label.Text = "请将信息填写完整...";
                return;
            }
        }
    }
}
