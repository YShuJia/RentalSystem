using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalSystem.Entity
{
    public class AdminEntity
    {
        private string a_id;

        private string a_pass;

        private string a_tel;

        private decimal a_account;


        public string A_id { get => a_id; set => a_id = value; }
        public string A_pass { get => a_pass; set => a_pass = value; }
        public decimal A_account { get => a_account; set => a_account = value; }
        public string A_tel { get => a_tel; set => a_tel = value; }
    }
}
