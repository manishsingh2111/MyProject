using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_concepts1
{
    class Program
    {
        static void Main(string[] args)
        {
            MobilePhone samsung = new MobilePhone();
            samsung.IMEI = "123fghyuio7890";
            samsung.NoOfSimCards = 2;
            samsung.Color = "Orange";


        }
    }

    class MobilePhone
    {
        public string IMEI { get; set; }
        public int NoOfSimCards { get; set; }
        public string Color { get; set; }

        public void ConnectCall()
        {

        }
    }
}
