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
    public partial class AdminMsgForm : Form
    {
        public AdminMsgForm()
        {
            InitializeComponent();
        }
        public AdminMsgForm(AdminEntity admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        AdminEntity admin;
        R r;

        AdminMapper adminMapper = new AdminMapper();

        //编辑
        private void edit_Click(object sender, EventArgs e)
        {
            change(false);
        }

        //保存
        private void save_Click(object sender, EventArgs e)
        {
            if (tel_text.Text == "")
            {
                warn_label.Text = "请将信息填写完整...";
                return;
            }
            if (pass.Text == "" || pass.Text != admin.A_pass)
            {
                warn_label.Text = "密码不正确，不能验证身份...";
                return;
            }
            admin.A_tel = tel_text.Text;
            r = adminMapper.updateAdmin(admin);
            warn_label.Text = r.Msg;
            if (r.IsOK)
            {
                change(true);
            }
        }

        private void change(bool key)
        {
            tel_text.ReadOnly = key;
            pass.ReadOnly = key;
        }

        private void name_text_TextChanged(object sender, EventArgs e)
        {
            warn_label.Text = "";
        }

        private void AdminMsgForm_Load(object sender, EventArgs e)
        {
            id_text.Text = admin.A_id;
            tel_text.Text = admin.A_tel;
            account_text.Text = admin.A_account.ToString();

        }
    }
}
