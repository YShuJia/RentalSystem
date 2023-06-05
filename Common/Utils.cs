using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalSystem.Common
{
    public class Utils
    {

        //时间戳
        public static String getTimeTicks()
        {
            return ((DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000).ToString();
        }

        //管理员id
        public static String getAdminId()
        {
            return "A_789";
        }

        //手续费占比
        public static decimal getPremium()
        {
            // 5%
            return (decimal)0.05;
        }
    }
}
