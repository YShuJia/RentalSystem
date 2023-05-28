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
    public partial class UserPassForm : Form
    {
        public UserPassForm()
        {
            InitializeComponent();
        }
        public UserPassForm(UserEntity user)
        {
            InitializeComponent();
            this.user = user;
        }

        UserEntity user;
    }
}
