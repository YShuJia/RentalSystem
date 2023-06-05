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
                column.Name = "操 作";
                column.Text = "退 房";
                column.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(column);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name != "操 作")
                return;
            string b_id = dataGridView1.Rows[e.RowIndex].Cells["订单ID"].Value.ToString();
            long h_id = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["房屋ID"].Value);
            if (MessageBox.Show("租金不退还，押金将返回账户...确定要退房？", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                decimal deposit = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["押金(元)"].Value);

                HouseMapper houseMapper = new HouseMapper();
                string o_id = houseMapper.selectO_idByH_id(h_id);

                //封装转账信息
                TransferEntity transfer = new TransferEntity();
                transfer.T_plaintiff_id = o_id;
                transfer.T_object_id = user.U_id;
                transfer.T_state = -1;
                transfer.T_id = Utils.getTimeTicks();
                transfer.T_amount = deposit;
                transfer.T_time = DateTime.Now;

                transferMapper = new TransferMapper();
                r = transferMapper.insertUtoO(transfer, b_id, h_id);
                if (r.IsOK)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
                MessageBox.Show(r.Msg);
            }
        }
    }
}
