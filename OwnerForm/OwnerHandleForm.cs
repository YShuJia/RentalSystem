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
    public partial class OwnerHandleForm : Form
    {
        public OwnerHandleForm()
        {
            InitializeComponent();
        }

        public OwnerHandleForm(OwnerEntity owner)
        {
            InitializeComponent();
            this.owner = owner;
            getReservation();
            getBill();
        }

        OwnerEntity owner;

        BillMapper billMapper = new BillMapper();

        HouseMapper houseMapper;

        ReservationMapper reservationMapper = new ReservationMapper();

        TransferMapper transferMapper = new TransferMapper();

        R r;

        private void getReservation()
        {
            r = reservationMapper.selectByTable(2, owner.O_id);
            if (r.IsOK)
            {
                DataSet ds = (DataSet)r.Obj;
                dataGridView1.DataSource = ds.Tables[0].DefaultView;

                DataGridViewButtonColumn column = new DataGridViewButtonColumn();
                column.Name = "操作1";
                column.Text = "取 消";
                column.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(column);

                column = new DataGridViewButtonColumn();
                column.Name = "操作2";
                column.Text = "确 定";
                column.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(column);
            }
        }

        private void getBill()
        {
            r = billMapper.selectByTable(2, owner.O_id);
            if (r.IsOK)
            {
                DataSet ds = (DataSet)r.Obj;
                dataGridView2.DataSource = ds.Tables[0].DefaultView;

                DataGridViewButtonColumn column = new DataGridViewButtonColumn();
                column.Name = "操作1";
                column.Text = "取 消";
                column.UseColumnTextForButtonValue = true;
                dataGridView2.Columns.Add(column);

                column = new DataGridViewButtonColumn();
                column.Name = "操作2";
                column.Text = "确 定";
                column.UseColumnTextForButtonValue = true;
                dataGridView2.Columns.Add(column);
            }
        }

        //预约
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name != "操作1" && dataGridView1.Columns[e.ColumnIndex].Name != "操作2")
                return;
            string r_id = dataGridView1.Rows[e.RowIndex].Cells["预约ID"].Value.ToString();
            long h_id = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["房屋ID"].Value);
            if (dataGridView1.Columns[e.ColumnIndex].Name == "操作1" &&
                MessageBox.Show("不同意该预约？", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                r = reservationMapper.updateState(r_id, 0, h_id, 0);
                if (r.IsOK)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
                MessageBox.Show(r.Msg);
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "操作2" &&
                MessageBox.Show("同意该预约？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                r = reservationMapper.updateState(r_id, -2, h_id);
                if (r.IsOK)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
                MessageBox.Show(r.Msg);
            }

        }

        //租赁
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView2.Columns[e.ColumnIndex].Name != "操作1" && dataGridView2.Columns[e.ColumnIndex].Name != "操作2")
                return;
            long h_id = Convert.ToInt64(dataGridView2.Rows[e.RowIndex].Cells["房屋ID"].Value);
            string b_id = dataGridView2.Rows[e.RowIndex].Cells["订单ID"].Value.ToString();
            if (dataGridView2.Columns[e.ColumnIndex].Name == "操作1" &&
                MessageBox.Show("不同意该租赁？", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                r = billMapper.updateState(b_id, 0, h_id, 0);
                if (r.IsOK)
                {
                    dataGridView2.Rows.RemoveAt(e.RowIndex);
                }
                MessageBox.Show(r.Msg);
            }
            if (dataGridView2.Columns[e.ColumnIndex].Name == "操作2" &&
                MessageBox.Show("同意该租赁？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                r = billMapper.updateState(b_id, -2, h_id);
                if (r.IsOK)
                {
                    dataGridView2.Rows.RemoveAt(e.RowIndex);
                }
                MessageBox.Show(r.Msg);
            }
        }
    }
}
