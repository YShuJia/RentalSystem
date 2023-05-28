using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalSystem.Entity
{
    public class TransferEntity
    {
        private string t_id;
        private string t_plaintiff_id;
        private string t_object_id;
        private decimal t_amount;
        private DateTime t_time;
        private int t_state;

        public string T_id { get => t_id; set => t_id = value; }
        public string T_plaintiff_id { get => t_plaintiff_id; set => t_plaintiff_id = value; }
        public string T_object_id { get => t_object_id; set => t_object_id = value; }
        public decimal T_amount { get => t_amount; set => t_amount = value; }
        public DateTime T_time { get => t_time; set => t_time = value; }
        public int T_state { get => t_state; set => t_state = value; }
    }
}
