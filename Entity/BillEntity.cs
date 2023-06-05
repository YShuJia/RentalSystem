using System;

namespace RentalSystem.Entity
{
    public class BillEntity
    {
        private string b_id;
        private long h_id;
        private string u_id;
        private int b_day;
        private DateTime b_stop_time;
        private decimal b_rent;
        private decimal b_premium;
        private decimal b_deposit;
        private int b_state;

        public string B_id { get => b_id; set => b_id = value; }
        public long H_id { get => h_id; set => h_id = value; }
        public string U_id { get => u_id; set => u_id = value; }
        public int B_day { get => b_day; set => b_day = value; }
        public DateTime B_stop_time { get => b_stop_time; set => b_stop_time = value; }
        public decimal B_rent { get => b_rent; set => b_rent = value; }
        public decimal B_premium { get => b_premium; set => b_premium = value; }
        public int B_state { get => b_state; set => b_state = value; }
        public decimal B_deposit { get => b_deposit; set => b_deposit = value; }
    }
}
