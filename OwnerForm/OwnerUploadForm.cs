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
namespace RentalSystem.OwnerForm
{
    public partial class OwnerUploadForm : Form
    {
        public OwnerUploadForm()
        {
            InitializeComponent();
        }


        public OwnerUploadForm(HouseEntity house)
        {
            InitializeComponent();
            this.house = house;
        }

        HouseEntity house;

        HouseMapper houseMapper;

        R r;

        private void area_TextChanged(object sender, EventArgs e)
        {
            warn_label.Text = "";
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if(area.Text ==""||addr.Text==""||rent.Text==""||
                deposit.Text == "" || intro.Text == "" || type.Text == "")
            {
                warn_label.Text = "请将表格填写完整...";
                return;
            }
            houseMapper = new HouseMapper();
            house.H_area = Convert.ToDecimal(area.Text);
            house.H_rent = Convert.ToDecimal(rent.Text);
            house.H_addr = addr.Text;
            house.H_type = type.Text;
            house.H_deposit = Convert.ToDecimal(deposit.Text);
            house.H_introduce = intro.Text;
            r = houseMapper.insert(house);
            MessageBox.Show(r.Msg);
            if(r.IsOK)
            {
                this.Close();
            }
        }
    }
}
