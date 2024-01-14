using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace WindowsFormsApp2
    {
        public class Client
        {
            public uint  IdClient { get; set; }
            public string Name { get; set; }
            public string Adress { get; set; }
            public string Number { get; set; }
            public bool isActived { get; set; }
            public List<int> Orders { get; set; } 
        }



    }
