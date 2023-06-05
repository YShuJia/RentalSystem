using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalSystem.Entity
{
    public class ReservationEntity
    {
        private string r_id;
        private long h_id;
        private string u_id;
        private DateTime r_time;
        private int r_state;

        public string R_id { get => r_id; set => r_id = value; }
        public long H_id { get => h_id; set => h_id = value; }
        public DateTime R_time { get => r_time; set => r_time = value; }
        public int R_state { get => r_state; set => r_state = value; }
        public string U_id { get => u_id; set => u_id = value; }
    }
}
