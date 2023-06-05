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
    public partial class AdminUserForm : Form
    {
        public AdminUserForm()
        {
            InitializeComponent();
        }
        public AdminUserForm(AdminEntity admin)
        {
            InitializeComponent();
            this.admin = admin;
            page.PageNum = 1;
            get(page);
        }

        AdminEntity admin;
        R r;

        Page page = new Page();

        UserMapper userMapper = new UserMapper();

        bool f = true;

        private void get(Page page)
        {
            string o_sex = sex.Text;
            string o_tel = tel.Text;
            int o_point = -1000;
            if (score.Text != "")
                o_point = Convert.ToInt32(score.Text);

            r = userMapper.selectByTable(page, o_sex, o_tel, o_point);
            if (r.IsOK)
            {
                DataSet ds = (DataSet)r.Obj;
                dataGridView1.DataSource = ds.Tables[0];

                if (f && dataGridView1.Rows.Count > 0)
                {
                    DataGridViewButtonColumn column = new DataGridViewButtonColumn();
                    column.Name = "操 作1";
                    column.Text = "冻 结";
                    column.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(column);

                    column = new DataGridViewButtonColumn();
                    column.Name = "操 作2";
                    column.Text = "积 分";
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


        int index;
        public void update(int point)
        {
            dataGridView1.Rows[index].Cells["积分"].Value = point;
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0 && e.ColumnIndex != 1)
            {
                return;
            }
            index = e.RowIndex;
            string o_id = dataGridView1.Rows[e.RowIndex].Cells["用户ID"].Value.ToString();
            int state = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["0在线 1冻结 -1注销"].Value);
            //冻结
            if (e.ColumnIndex == 0)
            {
                if (state == 0 &&
                    MessageBox.Show("确定要冻结该用户？", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    r = userMapper.updateStateById(o_id, 1);
                    warn_label.Text = r.Msg;
                    if (r.IsOK)
                        dataGridView1.Rows[e.RowIndex].Cells["0在线 1冻结 -1注销"].Value = 1;
                }
                else if (MessageBox.Show("该用户已冻结，要解冻吗？", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    r = userMapper.updateStateById(o_id, 0);
                    warn_label.Text = r.Msg;
                    if (r.IsOK)
                        dataGridView1.Rows[e.RowIndex].Cells["0在线 1冻结 -1注销"].Value = 0;
                }
            }
            else
            {
                UserEntity user = new UserEntity();
                user.U_id = o_id;
                user.U_state = state;
                user.U_sex = dataGridView1.Rows[e.RowIndex].Cells["性别"].Value.ToString();
                user.U_tel = dataGridView1.Rows[e.RowIndex].Cells["电话"].Value.ToString();
                user.U_name = dataGridView1.Rows[e.RowIndex].Cells["姓名"].Value.ToString();
                user.U_point = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["积分"].Value);
                AdminPointForm adminPoint = new AdminPointForm(this, user, null);
                adminPoint.ShowDialog();
            }
        }
    }
}
