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

namespace RentalSystem.UserForm
{
    public partial class UserTransferForm : Form
    {
        public UserTransferForm()
        {
            InitializeComponent();
        }
        public UserTransferForm(UserEntity user)
        {
            InitializeComponent();
            this.user = user;
            get();
        }

        UserEntity user;

        R r;

        TransferMapper transferMapper = new TransferMapper();
        public void get()
        {
            r = transferMapper.selectByTable(1, 3, user.U_id);
            if (r.IsOK)
            {
                DataSet ds = (DataSet)r.Obj;
                dataGridView1.DataSource = ds.Tables[0].DefaultView;

              /*  DataGridViewButtonColumn column = new DataGridViewButtonColumn();
                column.Name = "操 作";
                column.Text = "删 除";
                column.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(column);*/
            }

            r = transferMapper.selectByTable(-1, -3, user.U_id);
            if (r.IsOK)
            {
                DataSet ds = (DataSet)r.Obj;
                dataGridView2.DataSource = ds.Tables[0].DefaultView;

               /* DataGridViewButtonColumn column = new DataGridViewButtonColumn();
                column.Name = "操 作";
                column.Text = "删 除";
                column.UseColumnTextForButtonValue = true;
                dataGridView2.Columns.Add(column);*/
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "操 作" &&
                MessageBox.Show("确定要删除该记录？", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string t_id = dataGridView1.Rows[e.RowIndex].Cells["帐单ID"].Value.ToString();
                string id = dataGridView1.Rows[e.RowIndex].Cells["对象"].Value.ToString();
                r = transferMapper.updateState(t_id, 0, id, user.U_id);
                if (r.IsOK)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
                MessageBox.Show(r.Msg);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "操 作" &&
                MessageBox.Show("确定要删除该记录？", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string t_id = dataGridView2.Rows[e.RowIndex].Cells["帐单ID"].Value.ToString();
                string id = dataGridView2.Rows[e.RowIndex].Cells["对象"].Value.ToString();
                r = transferMapper.updateState(t_id, 0, user.U_id, id);
                if (r.IsOK)
                {
                    dataGridView2.Rows.RemoveAt(e.RowIndex);
                }
                MessageBox.Show(r.Msg);
            }
        }
    }
}
