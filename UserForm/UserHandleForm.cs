﻿using RentalSystem.Entity;
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
using System.Security.Cryptography;

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
        }

        UserEntity user;

        BillMapper billMapper = new BillMapper();

        HouseMapper houseMapper;

        ReservationMapper reservationMapper = new ReservationMapper();

        TransferMapper transferMapper;

        ComplaintsMapper complaintsMapper = new ComplaintsMapper();

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
                column.Text = "取 消";
                column.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(column);

                column = new DataGridViewButtonColumn();
                column.Name = "操作2";
                column.Text = "租 赁";
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
            r = complaintsMapper.selectByTable(user.U_id, 0, -1);
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

        //预约
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name != "操作1" && dataGridView1.Columns[e.ColumnIndex].Name != "操作2")
                return;
            string r_id = dataGridView1.Rows[e.RowIndex].Cells["预约ID"].Value.ToString();
            long h_id = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["房屋ID"].Value);
            if (dataGridView1.Columns[e.ColumnIndex].Name == "操作1" && 
                MessageBox.Show("房主已同意，确定取消预约？", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                r = reservationMapper.updateState(r_id, 1, h_id, 0);
                if (r.IsOK)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
                MessageBox.Show(r.Msg);
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "操作2")
            {
                index1 = e.RowIndex;
                r = reservationMapper.updateState(r_id, 1, h_id, 2);
                if (r.IsOK)
                {
                    houseMapper = new HouseMapper();
                    r = houseMapper.selectByID(h_id);
                    if (r.IsOK)
                    {
                        HouseEntity house = new HouseEntity();
                        house.H_id = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["房屋ID"].Value);
                        UserShowHouse userShow = new UserShowHouse(house, user, this);
                        userShow.ShowDialog();
                    }
                    MessageBox.Show(r.Msg);
                }
            }
        }

        private R rental(decimal amount, decimal b_deposit, long h_id, string b_id)
        {
            houseMapper = new HouseMapper();
            string o_id = houseMapper.selectO_idByH_id(h_id);
            TransferEntity transfer = new TransferEntity();
            TransferEntity transfer2 = new TransferEntity();
            transfer.T_plaintiff_id = user.U_id;
            transfer.T_object_id = o_id;
            transfer.T_state = 1; //表示用户向房主转账
            transfer.T_id = Utils.getTimeTicks();
            transfer.T_time = DateTime.Now;
            transfer.T_amount = amount + b_deposit;

            //获取手续费
            decimal b_premium = billMapper.selectPremiumByView(b_id);
            transfer2.T_id = Utils.getTimeTicks();
            transfer2.T_time = DateTime.Now;
            transfer2.T_plaintiff_id = o_id;
            transfer2.T_object_id = Utils.getAdminId();
            transfer2.T_amount = b_premium;
            transfer2.T_state = 2;
            transferMapper = new TransferMapper();
            return transferMapper.insertUtoOtoA(transfer, transfer2, b_id, h_id);
        }

        //租赁
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView2.Columns[e.ColumnIndex].Name != "操作1" && dataGridView2.Columns[e.ColumnIndex].Name != "操作2")
                return;
            long h_id = Convert.ToInt64(dataGridView2.Rows[e.RowIndex].Cells["房屋ID"].Value);
            string b_id = dataGridView2.Rows[e.RowIndex].Cells["订单ID"].Value.ToString();
            if (dataGridView2.Columns[e.ColumnIndex].Name == "操作1" &&
                MessageBox.Show("房主同意租赁，确定取消租赁？", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                r = billMapper.updateState(b_id, 0, h_id, 0);
                if(r.IsOK)
                {
                    dataGridView2.Rows.RemoveAt(e.RowIndex);
                }
                MessageBox.Show(r.Msg);
            }
            if (dataGridView2.Columns[e.ColumnIndex].Name == "操作2" &&
                MessageBox.Show("房主同意租赁，再次确认，将进行打款操作！", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                decimal amount = Convert.ToDecimal(dataGridView2.Rows[e.RowIndex].Cells["租金(元)"].Value);
                decimal b_deposit = Convert.ToDecimal(dataGridView2.Rows[e.RowIndex].Cells["押金(元)"].Value);
                r = rental(amount, b_deposit, h_id,b_id);
                if (r.IsOK)
                {
                    dataGridView2.Rows.RemoveAt(e.RowIndex);
                }
                MessageBox.Show(r.Msg);
            }
        }
        int index1;
        public void delete1()
        {
            dataGridView1.Rows.RemoveAt(index);
        }

        int index;
        public void delete()
        {
            dataGridView3.Rows.RemoveAt(index);
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

            ComplaintsUpdateForm complaintsUpdate = new ComplaintsUpdateForm(this, complaints, true);
            complaintsUpdate.ShowDialog();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            Console.WriteLine(e.TabPageIndex);
            if(e.TabPageIndex == 0 && dataGridView1.Rows.Count<= 0)
            {
                getReservation();
            }
            else if(e.TabPageIndex == 1 && dataGridView2.Rows.Count<= 0)
            {
                getBill();
            }
            else if( e.TabPageIndex == 2 && dataGridView3.Rows.Count<= 0)
            {
                getComplaints();
            }
        }
    }
}
