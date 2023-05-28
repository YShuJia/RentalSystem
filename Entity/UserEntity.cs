using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalSystem.Entity
{
    public class UserEntity
    {
        private string u_id;
        private string u_name;
        private string u_pass;
        private string u_tel;
        private string u_sex;
        private string u_addr;
        private int u_point;
        private decimal u_account;
        private int u_state;

        public string U_id { get => u_id; set => u_id = value; }
        public string U_name { get => u_name; set => u_name = value; }
        public string U_pass { get => u_pass; set => u_pass = value; }
        public string U_tel { get => u_tel; set => u_tel = value; }
        public string U_sex { get => u_sex; set => u_sex = value; }
        public string U_addr { get => u_addr; set => u_addr = value; }
        public int U_point { get => u_point; set => u_point = value; }
        public decimal U_account { get => u_account; set => u_account = value; }
        public int U_state { get => u_state; set => u_state = value; }
    }
}
