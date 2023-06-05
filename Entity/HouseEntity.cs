using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalSystem.Entity
{
    public class HouseEntity
    {
        private long h_id;
        private string o_id;
        private string h_type;
        private string h_addr;
        private decimal h_area;
        private decimal h_rent;
        private decimal h_deposit;
        private string h_introduce;
        private int h_state;

        public long H_id { get => h_id; set => h_id = value; }
        public string O_id { get => o_id; set => o_id = value; }
        public string H_type { get => h_type; set => h_type = value; }
        public string H_addr { get => h_addr; set => h_addr = value; }
        public decimal H_area { get => h_area; set => h_area = value; }
        public decimal H_rent { get => h_rent; set => h_rent = value; }
        public string H_introduce { get => h_introduce; set => h_introduce = value; }
        public int H_state { get => h_state; set => h_state = value; }
        public decimal H_deposit { get => h_deposit; set => h_deposit = value; }
    }
}
