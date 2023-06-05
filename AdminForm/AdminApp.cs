using RentalSystem.Common;
using RentalSystem.Entity;
using RentalSystem.OwnerForm;
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
    public partial class AdminApp : Form
    {
        public AdminApp()
        {
            InitializeComponent();
        }

        public AdminApp(App app,AdminEntity admin)
        {
            InitializeComponent();
            this.app = app;
            this.admin = admin;
            link = now;
            openForm(new AdminHandleForm(admin));
        }

        App app;

        AdminEntity admin;

        LinkLabel link;

        public void openForm(Form form)
        {
            //关闭上一个
            foreach (Control item in splitContainer1.Panel2.Controls)
            {
                if (item is Form)
                {
                    ((Form)item).Close();
                }
            }
            form.TopLevel = false;// 将子窗体设置为非顶级控件
            form.FormBorderStyle = FormBorderStyle.None;//设置无边框
            form.Parent = splitContainer1.Panel2;//设置窗体容器
            form.Dock = DockStyle.Fill; //容器大小随着调整窗体大小自动变化
            form.Show();
        }

        private void color(LinkLabel linkLabel)
        {
            linkLabel.BackColor = SystemColors.ActiveCaption;
            link.BackColor = SystemColors.Control;
            link = linkLabel;
        }

        private void now_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (link == now)
                return;
            color(now);
            openForm(new AdminHandleForm(admin));
        }

        private void owner_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (link == owner)
                return;
            color(owner);
            openForm(new AdminOwnerForm(admin));
        }

        private void user_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (link == user)
                return;
            color(user);
            openForm(new AdminUserForm(admin));
        }

        private void tranfer_log_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (link == tranfer_log)
                return;
            color(tranfer_log);
            openForm(new AdminTransferForm(admin));
        }

        private void msg_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (link == msg_link)
                return;
            color(msg_link);
            openForm(new AdminMsgForm(admin));
        }

        private void pass_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (link == pass_link)
                return;
            color(pass_link);
            openForm(new UpdatePassForm(app, admin));
        }

        private void exit_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("确定要退出登录?", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                app.openForm(new Login(app));
            }
        } 
    }
}
