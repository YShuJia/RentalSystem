using RentalSystem.Common;
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

namespace RentalSystem.UserForm
{
    public partial class UserApp : Form
    {
        public UserApp()
        {
            InitializeComponent();
        }

        public UserApp(App app, UserEntity user)
        {
            InitializeComponent();
            this.app = app;
            this.user = user;
            link = now;
            openForm(new UserHandleForm(user));
        }

        App app;

        UserEntity user;

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
            openForm(new UserHandleForm(user));
            Console.WriteLine("123");
        }

        private void now_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (link == now_link)
                return;
            color(now_link);
            openForm(new UserNowForm(user));
        }

        private void rental_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (link == rental_link)
                return;
            color(rental_link);
            openForm(new UserHouseForm(user));
        }

        private void rental_log_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (link == rental_log)
                return;
            color(rental_log);
            openForm(new UserRentalForm(user));
        }

        private void view_log_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (link == view_log)
                return;
            color(view_log);
            openForm(new UserReservationForm(user));
        }

        private void tranfer_log_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (link == tranfer_log)
                return;
            color(tranfer_log);
            openForm(new UserTransferForm(user));
        }

        private void pass_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (link == pass_link)
                return;
            color(pass_link);
            openForm(new UserPassForm(user));
        }

        private void msg_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (link == msg_link)
                return;
            color(msg_link);
            openForm(new UserMsgForm(user));
        }

        //退出登录
        private void exit_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            app.openForm(new Login(app));
        }
    }
}
