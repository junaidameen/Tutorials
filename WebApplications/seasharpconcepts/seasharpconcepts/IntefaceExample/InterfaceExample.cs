using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seasharpconcepts.IntefaceExample
{
    interface ICustomer1
    {
        int ID { get; set; }
        void Print1();
    }

    interface ICustomer2 
    {
        int ID { get; set; }
        void Print1();
    }
}
