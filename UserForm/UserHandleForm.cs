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
using System.Runtime.ConstrainedExecution;

namespace RentalSystem.UserForm
{
    public partial class UserHandleForm : Form
    {
        public UserHandleForm()
        {
            InitializeComponent();
        }

        public UserHandleForm(UserEntity user)
        {
            InitializeComponent();
            this.user = user;
            getReservation();
            getBill();
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;
        }

        UserEntity user;

        BillMapper billMapper = new BillMapper();

        HouseMapper houseMapper;

        ReservationMapper reservationMapper = new ReservationMapper();

        R r;

        private void getReservation()
        {
            r = reservationMapper.selectByView(-2,user.U_id);
            if(r.IsOK )
            {
                DataSet ds = (DataSet)r.Obj;
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
          
                DataGridViewButtonColumn column = new DataGridViewButtonColumn();
                column.Name = "操作1";
                column.Text = "取消";
                column.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(column);

                column = new DataGridViewButtonColumn();
                column.Name = "操作2";
                column.Text = "确定";
                column.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(column);
            }
        }

        private void getBill()
        {
            r = billMapper.selectByView(-2,user.U_id);
            if (r.IsOK)
            {
                DataSet ds = (DataSet)r.Obj;
                dataGridView2.DataSource = ds.Tables[0].DefaultView;

                DataGridViewButtonColumn column = new DataGridViewButtonColumn();
                column.Name = "操作1";
                column.Text = "取消";
                column.UseColumnTextForButtonValue = true;
                dataGridView2.Columns.Add(column);

                column = new DataGridViewButtonColumn();
                column.Name = "操作2";
                column.Text = "确定";
                column.UseColumnTextForButtonValue = true;
                dataGridView2.Columns.Add(column);
            }
        }

        //预约
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "操作1" && 
                MessageBox.Show("房主已同意预约，确定要取消预约？", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               string id = dataGridView1.Rows[e.RowIndex].Cells["预约ID"].Value.ToString();
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "操作2" &&
                MessageBox.Show("房主已同意预约，再次确认预约？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Console.WriteLine(e.ColumnIndex.ToString());
            }

        }

        //租赁
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long h_id = Convert.ToInt64(dataGridView2.Rows[e.RowIndex].Cells["房屋ID"].Value);
            string b_id = dataGridView2.Rows[e.RowIndex].Cells["订单ID"].Value.ToString();

            if (dataGridView2.Columns[e.ColumnIndex].Name == "操作1" &&
                MessageBox.Show("房主已同意租赁，确定要取消租赁？", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                r = billMapper.updateState(0,b_id,h_id);
                if(r.IsOK)
                {
                    dataGridView2.Rows.RemoveAt(e.RowIndex);
                }
                MessageBox.Show(r.Msg);
            }
            if (dataGridView2.Columns[e.ColumnIndex].Name == "操作2" &&
                MessageBox.Show("房主已同意租赁，再次确认租赁？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                houseMapper = new HouseMapper();
                string o_id = houseMapper.selectO_idByH_id(h_id);
                if (o_id != "")
                {
                    decimal amount = Convert.ToDecimal(dataGridView2.Rows[e.RowIndex].Cells["租金(元)"].Value);
                    TransferEntity transfer = new TransferEntity();
                    transfer.T_plaintiff_id = user.U_id;
                    transfer.T_object_id = o_id;
                    transfer.T_state = 1; //表示用户向房主转账
                    transfer.T_id = Utils.getTimeTicks();
                    transfer.T_time = DateTime.Now;
                    transfer.T_amount = amount;
                    Console.WriteLine(amount);
                }
            }
        }
    }
}
