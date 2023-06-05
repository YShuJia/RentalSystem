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

namespace RentalSystem.UserForm
{
    public partial class UserNowForm : Form
    {
        public UserNowForm()
        {
            InitializeComponent();
        }
        public UserNowForm(UserEntity user)
        {
            InitializeComponent();
            this.user = user;
            get();
        }

        UserEntity user;

        BillMapper billMapper = new BillMapper();

        TransferMapper transferMapper;

        R r;

        private void get()
        {
            r = billMapper.selectByView(1, user.U_id);
            if (r.IsOK)
            {
                DataSet ds = (DataSet) r.Obj;
                dataGridView1.DataSource = ds.Tables[0].DefaultView;

                DataGridViewButtonColumn column = new DataGridViewButtonColumn();
                column.Name = "操 作1";
                column.Text = "退 房";
                column.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(column);

                column = new DataGridViewButtonColumn();
                column.Name = "操 作2";
                column.Text = "投 诉";
                column.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(column);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex!=0 && e.ColumnIndex!=1)
                return;
            string b_id = dataGridView1.Rows[e.RowIndex].Cells["订单ID"].Value.ToString();
            long h_id = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["房屋ID"].Value);
            if (e.ColumnIndex == 0)
            {
                if (MessageBox.Show("注：租金不退还，押金返回账户(需要房主同意...)", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    r = billMapper.updateState(b_id,-3,h_id);
                    if (r.IsOK)
                    {
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }
                    MessageBox.Show(r.Msg);
                }
            }
            else
            {
                HouseMapper houseMapper = new HouseMapper();
                string o_id = houseMapper.selectO_idByH_id(h_id);
                ComplaintsEntity complaints = new ComplaintsEntity();
                complaints.C_plaintiff = user.U_id;
                complaints.C_something = o_id;
                complaints.C_time = DateTime.Now;
                complaints.C_type = "用户";
                complaints.C_schedule = 1;
                complaints.C_id = Utils.getTimeTicks();

                ComplaintsForm form = new ComplaintsForm(complaints);
                form.ShowDialog();
            }
        }
    }
}
