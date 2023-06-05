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
using static System.Windows.Forms.MonthCalendar;
using System.Runtime.InteropServices;

namespace RentalSystem.UserForm
{
    public partial class UserHouseForm : Form
    {
        public UserHouseForm()
        {
            InitializeComponent();
        }

        public UserHouseForm(UserEntity user)
        {
            InitializeComponent();
            this.user = user;
            page.PageNum = 1;
            get(page);
        }

        UserEntity user;

        HouseMapper houseMapper = new HouseMapper();

        R r;

        Page page = new Page();

        bool f = true;

        private void get(Page page)
        {
            string h_type = type.Text;
            decimal h_rent = 0;
            decimal h_area = 0;
            if (rent.Text != "")
                h_rent = Convert.ToDecimal(rent.Text);
            if (area.Text != "")
                h_area = Convert.ToDecimal(area.Text);

            r = houseMapper.selectByView(page, 0, h_type, h_rent, h_area);
            if (r.IsOK)
            {
                DataSet ds = (DataSet)r.Obj;
                dataGridView1.DataSource = ds.Tables[0];

                if (f && dataGridView1.Rows.Count>0)
                {
                    DataGridViewButtonColumn column = new DataGridViewButtonColumn();
                    column.Name = "操 作1";
                    column.Text = "预 约";
                    column.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(column);

                    column = new DataGridViewButtonColumn();
                    column.Name = "操 作2";
                    column.Text = "租 赁";
                    column.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(column);
                    f = false;
                }
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
                f = true;
            }
            warn_label.Text = r.Msg;
        }
        //租赁
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0 && e.ColumnIndex!=1)
            {
                return;
            }
            index = e.RowIndex;
            HouseEntity house = new HouseEntity();
            house.H_id = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["房屋ID"].Value);
            house.H_rent = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["租金(元)"].Value);
            house.H_deposit = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["押金(元)"].Value);
            house.H_addr = dataGridView1.Rows[e.RowIndex].Cells["地址"].Value.ToString();
            house.H_introduce = dataGridView1.Rows[e.RowIndex].Cells["简介"].Value.ToString();
            house.H_type = dataGridView1.Rows[e.RowIndex].Cells["房型"].Value.ToString();
            house.H_area = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["面积(m²)"].Value);
            if (e.ColumnIndex == 0)
            {
                UserVIewForm userVIew = new UserVIewForm(house, user, this);
                userVIew.ShowDialog();
            }
            else
            {
                UserShowHouse userShow = new UserShowHouse(house, user, this);
                userShow.ShowDialog();
            }
        }


        int index;
        public void delete()
        {
            dataGridView1.Rows.RemoveAt(index);
        }

        //上一页
        private void pre_Click(object sender, EventArgs e)
        {
            warn_label.Text = "";
            if (page_label.Text == "1") { 
                warn_label.Text ="已到第一页...";
                return;
            }
            
            page_label.Text = (Convert.ToInt32(page_label.Text) - 1).ToString();
            page.PageNum--;
            get(page);
        }


        //下一页
        private void next_Click(object sender, EventArgs e)
        {
            warn_label.Text = "";
            if (dataGridView1.Rows.Count<page.PageSize)
            {
                warn_label.Text = "已到最后一页...";
                return;
            }

            page_label.Text = (Convert.ToInt32(page_label.Text) + 1).ToString();
            page.PageNum++;
            get(page);
        }

        //筛选
        private void submit_Click(object sender, EventArgs e)
        {
            if (type.Text == "" && rent.Text == "" && area.Text == "")
            {
                warn_label.Text = "请先输入筛选条件...";
                return;
            }
            warn_label.Text = "";
            page.PageNum = 1;
            page_label.Text = "1";
            get(page);
        }

        private void type_TextChanged(object sender, EventArgs e)
        {
            warn_label.Text = "";
        }
    }
}
