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

namespace RentalSystem.UserForm
{
    public partial class UserHouseForm : Form
    {
        public UserHouseForm()
        {
            InitializeComponent();
        }

        public UserHouseForm(UserEntity user)
        {
            InitializeComponent();
            this.user = user;
        }

        UserEntity user;
    }
}
