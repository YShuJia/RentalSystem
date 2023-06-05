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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalSystem.UserForm
{
    public partial class UserShowHouse : Form
    {
        public UserShowHouse()
        {
            InitializeComponent();
        }

        public UserShowHouse(HouseEntity house, UserEntity user, UserHouseForm userHouse)
        {
            InitializeComponent();
            this.house = house;
            this.user = user;
            this.userHouseForm = userHouse;
        }

        UserHouseForm userHouseForm;

        HouseEntity house;

        UserEntity user;

        BillMapper billMapper = new BillMapper();

        R r;

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (time.Text == "")
            {
                warn_label.Text = "请输入租赁时长...";
                return;
            }
            BillEntity bill = new BillEntity();
            bill.B_id = Utils.getTimeTicks();
            bill.B_day = Convert.ToInt32(time.Text);
            bill.B_rent = Convert.ToDecimal(total_rent.Text);
            bill.B_premium = Convert.ToDecimal((bill.B_rent * Utils.getPremium()).ToString("0.00"));
            bill.B_deposit = house.H_deposit;
            bill.B_state = 2;
            bill.H_id = house.H_id;
            bill.U_id = user.U_id;
            r = billMapper.insert(bill);
            MessageBox.Show(r.Msg);
            if (r.IsOK)
            {
                userHouseForm.delete();
                this.Close();
            }
        }

        private void UserShowHouse_Load(object sender, EventArgs e)
        {
            type.Text = house.H_type.ToString();
            rent.Text = house.H_rent.ToString();
            deposit.Text = house.H_deposit.ToString();
            addr.Text = house.H_addr.ToString();    
            intro.Text = house.H_introduce.ToString();
            area.Text = house.H_area.ToString();
        }

        private void time_TextChanged(object sender, EventArgs e)
        {
            warn_label.Text = "";
            if (Regex.IsMatch(time.Text, "^([0-9]{1,})$"))
            {
                total_rent.Text = (Convert.ToInt64(time.Text)* house.H_rent+ house.H_deposit).ToString();
            }
            else
            {
                warn_label.Text = "输入格式不正确...";
                total_rent.Text = (house.H_rent+house.H_deposit).ToString();
            }
        }
    }
}
