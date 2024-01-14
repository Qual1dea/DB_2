using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Order
    {
        public uint IdOrder { get; set; }
        public uint IdClient { get; set;}
        public int Weight { get; set; }
        public string ProductName { get; set; }
        public bool IsDelivered { get; set; }
        public decimal[] amount { get; set; }
    }
}
