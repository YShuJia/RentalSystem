using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalSystem.Entity
{
    //投诉
    public class ComplaintsEntity
    {
        private string c_id;
        private string c_content;
        private string c_plaintiff;
        private DateTime c_time;
        private string c_something;
        private string c_result;
        private string c_type;
        private int c_state;
        private int c_schedule;


        public string C_id { get => c_id; set => c_id = value; }
        public string C_content { get => c_content; set => c_content = value; }
        public string C_plaintiff { get => c_plaintiff; set => c_plaintiff = value; }
        public DateTime C_time { get => c_time; set => c_time = value; }
        public string C_something { get => c_something; set => c_something = value; }
        public string C_result { get => c_result; set => c_result = value; }
        public string C_type { get => c_type; set => c_type = value; }
        public int C_state { get => c_state; set => c_state = value; }
        public int C_schedule { get => c_schedule; set => c_schedule = value; }
    }
}
