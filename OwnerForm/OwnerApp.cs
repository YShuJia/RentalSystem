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

namespace RentalSystem.OwnerForm
{
    public partial class OwnerApp : Form
    {
        public OwnerApp()
        {
            InitializeComponent();
        }

        public OwnerApp(App app, OwnerEntity owner)
        {
            InitializeComponent();
            this.App = app;
            this.owner = owner;
        }

        App App;

        OwnerEntity owner;
    }
}
