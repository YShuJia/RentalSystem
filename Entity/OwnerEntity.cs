using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalSystem.Entity
{
    public class OwnerEntity
    {
        private string o_id;
        private string o_name;
        private string o_pass;
        private string o_tel;
        private string o_sex;
        private int o_point;
        private int o_state;
        private decimal o_account;

        public string O_id { get => o_id; set => o_id = value; }
        public string O_name { get => o_name; set => o_name = value; }
        public string O_pass { get => o_pass; set => o_pass = value; }
        public string O_tel { get => o_tel; set => o_tel = value; }
        public string O_sex { get => o_sex; set => o_sex = value; }
        public int O_point { get => o_point; set => o_point = value; }
        public int O_state { get => o_state; set => o_state = value; }
        public decimal O_account { get => o_account; set => o_account = value; }
    }
}
