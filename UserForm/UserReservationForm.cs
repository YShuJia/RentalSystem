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
    public partial class UserReservationForm : Form
    {
        public UserReservationForm()
        {
            InitializeComponent();
        }
        public UserReservationForm(UserEntity user)
        {
            InitializeComponent();
            this.user = user;
            get();
        }


        UserEntity user;
        R r;

        ReservationMapper reservationMapper = new ReservationMapper();
        public void get()
        {
            r = reservationMapper.selectByView(1, 0, user.U_id);
            if (r.IsOK)
            {
                DataSet ds = (DataSet)r.Obj;
                dataGridView1.DataSource = ds.Tables[0].DefaultView;

                /*DataGridViewButtonColumn column = new DataGridViewButtonColumn();
                column.Name = "操 作";
                column.Text = "删 除";
                column.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(column);*/
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "操 作" &&
                MessageBox.Show("确定要删除该记录？", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string b_id = dataGridView1.Rows[e.RowIndex].Cells["预约ID"].Value.ToString();
                r = reservationMapper.updateState(b_id, -1, user.U_id);
                if (r.IsOK)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
                MessageBox.Show(r.Msg);
            }
        }
    }
}
