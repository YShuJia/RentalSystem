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
    public partial class UserMsgForm : Form
    {
        public UserMsgForm()
        {
            InitializeComponent();
        }

        public UserMsgForm(UserEntity user)
        {
            InitializeComponent();
            this.user = user;
        }

        UserEntity user;

        R r;

        UserMapper userMapper = new UserMapper();   

        //编辑
        private void edit_Click(object sender, EventArgs e)
        {
            change(false);
        }

        //保存
        private void save_Click(object sender, EventArgs e)
        {
            if (name_text.Text == "" || sex_text.Text == "" || tel_text.Text == "" || addr_text.Text == "")
            {
                warn_label.Text = "请将信息填写完整...";
                return;
            }
            if (pass.Text == ""||pass.Text!=user.U_pass)
            {
                warn_label.Text = "密码不正确，不能验证身份...";
                return;
            }
            user.U_tel = tel_text.Text;
            user.U_addr = addr_text.Text;
            user.U_name = name_text.Text;
            user.U_sex = sex_text.Text;
            r = userMapper.updateUser(user);
            warn_label.Text = r.Msg;
            if(r.IsOK)
            {
                change(true);
            }
        }

        private void change(bool key)
        {
            name_text.ReadOnly = key;
            sex_text.ReadOnly = key;
            tel_text.ReadOnly = key;
            addr_text.ReadOnly = key;
            pass.ReadOnly = key;
        }

        private void UserMsgForm_Load(object sender, EventArgs e)
        {
            name_text.Text = user.U_name;
            sex_text.Text = user.U_sex;
            tel_text.Text = user.U_tel;
            addr_text.Text = user.U_addr;
            id_text.Text = user.U_id;
            point_text.Text = user.U_point.ToString();
            account_text.Text= user.U_account.ToString();
        }

        private void name_text_TextChanged(object sender, EventArgs e)
        {
            warn_label.Text = "";
        }
    }
}
