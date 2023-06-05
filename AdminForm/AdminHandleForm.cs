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

namespace RentalSystem.AdminForm
{
    public partial class AdminHandleForm : Form
    {
        public AdminHandleForm()
        {
            InitializeComponent();
        }

        public AdminHandleForm(AdminEntity admin)
        {
            InitializeComponent();
            this.admin = admin;
            get();
        }

        AdminEntity admin;

        R r;

        ComplaintsMapper complaintsMapper = new ComplaintsMapper();

        int index;

        public void delete()
        {
            dataGridView1.Rows.RemoveAt(index);
        }

        private void get()
        {
            r = complaintsMapper.selectByTable(0);
            if (r.IsOK)
            {
                DataSet ds = (DataSet)r.Obj;
                dataGridView1.DataSource = ds.Tables[0].DefaultView;

                DataGridViewButtonColumn column = new DataGridViewButtonColumn();
                column.Name = "操作";
                column.Text = "解 决";
                column.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(column);
            }
        }

        //预约
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "操作")
            {
                index = e.RowIndex;
                string c_id = dataGridView1.Rows[e.RowIndex].Cells["投诉ID"].Value.ToString();
                ComplaintsEntity complaints = new ComplaintsEntity();
                complaints.C_id = c_id;
                complaints.C_plaintiff = dataGridView1.Rows[e.RowIndex].Cells["投诉人"].Value.ToString();
                complaints.C_something = dataGridView1.Rows[e.RowIndex].Cells["被投诉人"].Value.ToString();
                complaints.C_time = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["时间"].Value);
                complaints.C_result = dataGridView1.Rows[e.RowIndex].Cells["协商结果"].Value.ToString();
                complaints.C_content = dataGridView1.Rows[e.RowIndex].Cells["投诉内容"].Value.ToString();
                complaints.C_type = dataGridView1.Rows[e.RowIndex].Cells["投诉人身份"].Value.ToString();


                AdminComplaintForm adminComplaintForm = new AdminComplaintForm(this,complaints);
                adminComplaintForm.ShowDialog();
            }
        }
    }
}
