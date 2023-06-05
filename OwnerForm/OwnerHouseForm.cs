using RentalSystem.Common;
using RentalSystem.Entity;
using RentalSystem.Mapper;
using RentalSystem.UserForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace RentalSystem.OwnerForm
{
    public partial class OwnerHouseForm : Form
    {
        public OwnerHouseForm()
        {
            InitializeComponent();
        }

        public OwnerHouseForm(HouseEntity house)
        {
            InitializeComponent();
            this.house = house;
        }

        HouseMapper houseMapper = new HouseMapper();

        HouseEntity house;

        R r;

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (rent.Text == ""||addr.Text==""||type.Text==""||
                deposit.Text==""||intro.Text==""||area.Text=="")
            {
                warn_label.Text = "请将表格填写完成...";
                return;
            }
            
            house.H_rent = Convert.ToDecimal(rent.Text);
            house.H_deposit = Convert.ToDecimal(deposit.Text);
            house.H_area = Convert.ToDecimal(area.Text);
            house.H_type = type.Text;
            house.H_addr = addr.Text;
            house.H_introduce = intro.Text;
            
            r = houseMapper.updateHouse(house);
            MessageBox.Show(r.Msg);
            if (r.IsOK)
            {
                this.Close();
            }
        }

        private void OwnerHouseForm_Load(object sender, EventArgs e)
        {
            id.Text = house.H_id.ToString();
            type.Text = house.H_type.ToString();
            rent.Text = house.H_rent.ToString();
            deposit.Text = house.H_deposit.ToString();
            addr.Text = house.H_addr.ToString();
            intro.Text = house.H_introduce.ToString();
            area.Text = house.H_area.ToString();
        }
    }
}
