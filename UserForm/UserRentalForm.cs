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
    public partial class UserRentalForm : Form
    {
        public UserRentalForm()
        {
            InitializeComponent();
        }

        public UserRentalForm(UserEntity user)
        {
            InitializeComponent();
            this.user = user;
        }

        UserEntity user;
    }
}
