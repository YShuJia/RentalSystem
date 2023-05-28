using System;

namespace RentalSystem.Entity
{
    public class BillEntity
    {
        private string b_id;
        private long h_id;
        private string u_id;
        private DateTime b_start_time;
        private DateTime b_stop_time;
        private decimal b_rent;
        private decimal b_premium;
        private string b_user_signature;
        private string b_owner_signature;
        private decimal b_remark;
        private int b_state;

        public string B_id { get => b_id; set => b_id = value; }
        public long H_id { get => h_id; set => h_id = value; }
        public string U_id { get => u_id; set => u_id = value; }
        public DateTime B_start_time { get => b_start_time; set => b_start_time = value; }
        public DateTime B_stop_time { get => b_stop_time; set => b_stop_time = value; }
        public decimal B_rent { get => b_rent; set => b_rent = value; }
        public decimal B_premium { get => b_premium; set => b_premium = value; }
        public string B_user_signature { get => b_user_signature; set => b_user_signature = value; }
        public string B_owner_signature { get => b_owner_signature; set => b_owner_signature = value; }
        public decimal B_remark { get => b_remark; set => b_remark = value; }
        public int B_state { get => b_state; set => b_state = value; }
    }
}
