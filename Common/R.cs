using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalSystem.Common
{
    public class R
    {
        private bool isOK = false;

        private string msg;

        private Object obj;

        public bool IsOK { get => isOK; set => isOK = value; }
        public string Msg { get => msg; set => msg = value; }
        public object Obj { get => obj; set => obj = value; }
    }
}
