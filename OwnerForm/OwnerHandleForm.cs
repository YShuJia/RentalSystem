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
        }

        OwnerEntity owner;

        BillMapper billMapper = new BillMapper();

        HouseMapper houseMapper;

        ReservationMapper reservationMapper;

        TransferMapper transferMapper;

        ComplaintsMapper complaintsMapper;

        R r;

        private void getReservation()
        {
            reservationMapper = new ReservationMapper();
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
                column.Text = "同 意";
                column.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(column);
            }
        }

        private void getBill()
        {
            billMapper = new BillMapper();
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
                column.Text = "同 意";
                column.UseColumnTextForButtonValue = true;
                dataGridView2.Columns.Add(column);
            }
        }

        private void getComplaints()
        {
            complaintsMapper = new ComplaintsMapper(); 
            r = complaintsMapper.selectByTable(owner.O_id, 0, 1);
            if (r.IsOK)
            {
                DataSet ds = (DataSet)r.Obj;
                dataGridView3.DataSource = ds.Tables[0].DefaultView;

                DataGridViewButtonColumn column = new DataGridViewButtonColumn();
                column.Name = "操 作";
                column.Text = "处 理";
                column.UseColumnTextForButtonValue = true;
                dataGridView3.Columns.Add(column);
            }
        }

        private void getBillOFExit()
        {
            r = billMapper.selectByTable(-3, owner.O_id);
            if (r.IsOK)
            {
                DataSet ds = (DataSet)r.Obj;
                dataGridView4.DataSource = ds.Tables[0].DefaultView;

                DataGridViewButtonColumn column = new DataGridViewButtonColumn();
                column.Name = "操 作1";
                column.Text = "退 房";
                column.UseColumnTextForButtonValue = true;
                dataGridView4.Columns.Add(column);

                column = new DataGridViewButtonColumn();
                column.Name = "操 作2";
                column.Text = "投 诉";
                column.UseColumnTextForButtonValue = true;
                dataGridView4.Columns.Add(column);
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


        int index;
        public void deleteD3()
        {
            dataGridView3.Rows.RemoveAt(index);
        }

        int index3;
        public void deleteD4()
        {
            dataGridView4.Rows.RemoveAt(index);
        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView3.Columns[e.ColumnIndex].Name != "操 作")
                return;

            index = e.RowIndex;
            ComplaintsEntity complaints = new ComplaintsEntity();
            string id = dataGridView3.Rows[e.RowIndex].Cells["投诉人"].Value.ToString();
            complaints.C_type = dataGridView3.Rows[e.RowIndex].Cells["投诉人身份"].Value.ToString();
            complaints.C_id = dataGridView3.Rows[e.RowIndex].Cells["投诉ID"].Value.ToString();
            complaints.C_plaintiff = id;
            complaints.C_something = dataGridView3.Rows[e.RowIndex].Cells["被投诉人"].Value.ToString();
            complaints.C_content = dataGridView3.Rows[e.RowIndex].Cells["投诉内容"].Value.ToString();
            complaints.C_result = dataGridView3.Rows[e.RowIndex].Cells["协商结果"].Value.ToString();
            complaints.C_time = Convert.ToDateTime(dataGridView3.Rows[e.RowIndex].Cells["时间"].Value);

            ComplaintsUpdateForm complaintsUpdate = new ComplaintsUpdateForm(this, complaints, false);
            complaintsUpdate.ShowDialog();
        }


        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            Console.WriteLine(e.TabPageIndex);
            if (e.TabPageIndex == 0 && dataGridView1.Rows.Count <= 0)
            {
                getReservation();
            }
            else if (e.TabPageIndex == 1 && dataGridView2.Rows.Count <= 0)
            {
                getBill();
            }
            else if (e.TabPageIndex == 2 && dataGridView3.Rows.Count <= 0)
            {
                getComplaints();
            }
            else if(e.TabPageIndex == 3 && dataGridView4.Rows.Count <= 0)
            {
                getBillOFExit();
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0 && e.ColumnIndex != 1)
                return;
            string b_id = dataGridView4.Rows[e.RowIndex].Cells["订单ID"].Value.ToString();
            long h_id = Convert.ToInt64(dataGridView4.Rows[e.RowIndex].Cells["房屋ID"].Value);
            string u_id = dataGridView4.Rows[e.RowIndex].Cells["用户ID"].Value.ToString();
            index3 = e.RowIndex;
            if (e.ColumnIndex == 0)
            {
                if (MessageBox.Show("押金将返回用户账户?", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    decimal deposit = Convert.ToDecimal(dataGridView4.Rows[e.RowIndex].Cells["押金(元)"].Value);
                    //封装转账信息
                    TransferEntity transfer = new TransferEntity();
                    transfer.T_plaintiff_id = owner.O_id;
                    transfer.T_object_id = u_id;
                    transfer.T_state = -1;
                    transfer.T_id = Utils.getTimeTicks();
                    transfer.T_amount = deposit;
                    transfer.T_time = DateTime.Now;

                    transferMapper = new TransferMapper();
                    r = transferMapper.insertUtoO(transfer, b_id, h_id);
                    if (r.IsOK)
                    {
                        dataGridView4.Rows.RemoveAt(e.RowIndex);
                    }
                    MessageBox.Show(r.Msg);
                }
            }
            else
            {
                ComplaintsEntity complaints = new ComplaintsEntity();
                complaints.C_plaintiff = owner.O_id;
                complaints.C_something = u_id;
                complaints.C_time = DateTime.Now;
                complaints.C_type = "房主";
                complaints.C_schedule = -1;
                complaints.C_id = Utils.getTimeTicks();
                ComplaintsForm form = new ComplaintsForm(this, complaints);
                form.ShowDialog();
            }
        }
    }
}
