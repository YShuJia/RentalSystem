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
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            openForm(new Login(this));
        }

        public void openForm(Form form)
        {
            //关闭上一个
            foreach (Control item in panel1.Controls)
            {
                if (item is Form)
                {
                    ((Form)item).Close();
                }
            }
            form.TopLevel = false;// 将子窗体设置为非顶级控件
            form.FormBorderStyle = FormBorderStyle.None;//设置无边框
            form.Parent = panel1;//设置窗体容器
            form.Dock = DockStyle.Fill; //容器大小随着调整窗体大小自动变化
            form.Show();
        }
    }
}
