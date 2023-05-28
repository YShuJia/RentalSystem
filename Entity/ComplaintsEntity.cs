using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalSystem.Entity
{
    public class ComplaintsEntity
    {
        private string c_id;
        private string c_content;
        private DateTime c_time;
        private string c_something;
        private string c_result;
        private int c_state;

        public string C_id { get => c_id; set => c_id = value; }
        public string C_content { get => c_content; set => c_content = value; }
        public DateTime C_time { get => c_time; set => c_time = value; }
        public string C_something { get => c_something; set => c_something = value; }
        public string C_result { get => c_result; set => c_result = value; }
        public int C_state { get => c_state; set => c_state = value; }
    }
}
