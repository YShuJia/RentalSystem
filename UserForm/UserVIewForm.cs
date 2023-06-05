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
    public partial class UserVIewForm : Form
    {
        public UserVIewForm()
        {
            InitializeComponent();
        }

        public UserVIewForm(HouseEntity house, UserEntity user, UserHouseForm userHouse)
        {
            InitializeComponent();
            this.house = house;
            this.user = user;
            this.userHouseForm = userHouse;
        }
        UserHouseForm userHouseForm;

        HouseEntity house;

        UserEntity user;

        ReservationMapper reservationMapper = new ReservationMapper();

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

            Console.WriteLine(Convert.ToDateTime(time.Text));

            ReservationEntity reservation = new ReservationEntity();
            reservation.R_id = Utils.getTimeTicks();
            reservation.R_state = 2;
            reservation.R_time = Convert.ToDateTime(time.Text);
            reservation.H_id = house.H_id;
            reservation.U_id = user.U_id;
            r = reservationMapper.insert(reservation);
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
    }
}
