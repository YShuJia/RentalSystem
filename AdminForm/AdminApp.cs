using RentalSystem.Common;
using RentalSystem.Entity;
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
    public partial class AdminApp : Form
    {
        public AdminApp()
        {
            InitializeComponent();
        }

        public AdminApp(App app,AdminEntity admin)
        {
            InitializeComponent();
            this.app = app;
            this.admin = admin;
        }

        App app;

        AdminEntity admin;
    }
}
