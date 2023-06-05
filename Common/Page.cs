using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalSystem.Common
{
    public class Page
    {
        private int pageSize = 300;

        private int pageNum;

        public int PageSize { get => pageSize; set => pageSize = value; }
        public int PageNum { get => pageNum; set => pageNum = value; }
    }
}
