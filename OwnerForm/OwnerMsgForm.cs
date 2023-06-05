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

namespace RentalSystem.OwnerForm
{
    public partial class OwnerMsgForm : Form
    {
        public OwnerMsgForm()
        {
            InitializeComponent();
        }
        public OwnerMsgForm(OwnerEntity owner)
        {
            InitializeComponent();
            this.owner = owner;
        }

        OwnerEntity owner;

        R r;

        OwnerMapper ownerMapper = new OwnerMapper();

        //编辑
        private void edit_Click(object sender, EventArgs e)
        {
            change(false);
        }

        //保存
        private void save_Click(object sender, EventArgs e)
        {
            if (name_text.Text == "" || sex_text.Text == "" || tel_text.Text == "")
            {
                warn_label.Text = "请将信息填写完整...";
                return;
            }
            if (pass.Text == "" || pass.Text != owner.O_pass)
            {
                warn_label.Text = "密码不正确，不能验证身份...";
                return;
            }
            owner.O_tel = tel_text.Text;
            owner.O_name = name_text.Text;
            owner.O_sex = sex_text.Text;
            r = ownerMapper.updateOwnerById(owner);
            warn_label.Text = r.Msg;
            if (r.IsOK)
            {
                change(true);
            }
        }

        private void change(bool key)
        {
            name_text.ReadOnly = key;
            sex_text.ReadOnly = key;
            tel_text.ReadOnly = key;
            pass.ReadOnly = key;
        }

        private void OwnerMsgForm_Load(object sender, EventArgs e)
        {
            name_text.Text = owner.O_name;
            sex_text.Text = owner.O_sex;
            tel_text.Text = owner.O_tel;
            id_text.Text = owner.O_id;
            point_text.Text = owner.O_point.ToString();
            account_text.Text = owner.O_account.ToString();
        }

        private void name_text_TextChanged(object sender, EventArgs e)
        {
            warn_label.Text = "";
        }
    }
}
