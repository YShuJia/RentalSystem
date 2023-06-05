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

namespace RentalSystem.OwnerForm
{
    public partial class OwnerNowForm : Form
    {
        public OwnerNowForm()
        {
            InitializeComponent();
        }
        public OwnerNowForm(OwnerEntity owner)
        {
            InitializeComponent();
            this.owner = owner;
            page.PageNum = 1;
            get(page);
        }

        OwnerEntity owner;

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

            r = houseMapper.selectByView(page, owner.O_id, h_type, h_rent, h_area);
            if (r.IsOK)
            {
                DataSet ds = (DataSet)r.Obj;
                dataGridView1.DataSource = ds.Tables[0];

                if (f && dataGridView1.Rows.Count > 0)
                {
                    DataGridViewButtonColumn column = new DataGridViewButtonColumn();
                    column.Name = "操 作1";
                    column.Text = "下 架";
                    column.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(column);

                    column = new DataGridViewButtonColumn();
                    column.Name = "操 作2";
                    column.Text = "上 架";
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
            warn_label.Text = "";
            if (e.ColumnIndex != 0 && e.ColumnIndex != 1)
            {
                return;
            }
            long h_id = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["房屋ID"].Value);
            int state = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["1预约 2租赁 -1下架"].Value);

            if (e.ColumnIndex == 0)
            {
                if(state==0&&MessageBox.Show("确定要下架该房屋?", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    r = houseMapper.updateStateToRental(-1, h_id);
                    warn_label.Text=r.Msg;
                    if (r.IsOK)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells["1预约 2租赁 -1下架"].Value = -1;
                    }
                }
                else
                {
                    warn_label.Text = "该房屋在使用中不能下架...";
                }
            }
            else 
            {
                if (state==-1&&MessageBox.Show("确定要上架该房屋?", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    r = houseMapper.updateStateToRental(0, h_id);
                    warn_label.Text = r.Msg;
                    if (r.IsOK)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells["1预约 2租赁 -1下架"].Value = 0;
                    }
                }
                else
                {
                    warn_label.Text = "该房屋已在使用中...";
                }
            }
        }

        //上一页
        private void pre_Click(object sender, EventArgs e)
        {
            warn_label.Text = "";
            if (page_label.Text == "1")
            {
                warn_label.Text = "已到第一页...";
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
            if (dataGridView1.Rows.Count < page.PageSize)
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
