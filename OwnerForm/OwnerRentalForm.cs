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
    public partial class OwnerRentalForm : Form
    {
        public OwnerRentalForm()
        {
            InitializeComponent();
        }
        public OwnerRentalForm(OwnerEntity owner)
        {
            InitializeComponent();
            this.owner = owner;
            get();
        }

        OwnerEntity owner;

        BillMapper billMapper = new BillMapper();

        R r;


        public void get()
        {
            r = billMapper.selectByTable(3, owner.O_id);
            if (r.IsOK)
            {
                DataSet ds = (DataSet)r.Obj;
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else
            {
                MessageBox.Show("暂无数据...");
            }
        }
    }
}
