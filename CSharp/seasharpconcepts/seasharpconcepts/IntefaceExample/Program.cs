using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seasharpconcepts.IntefaceExample
{

    class IntefaceExample
    {
        static void Main(string[] args)
        {

            //MyCustomer c1 = new MyCustomer()
            //{
            //     ID = 12345
            //};
            //c1.Print1();
            
            //Console.WriteLine(c1.ID);

            //var i = null;
            //var j;
            //j = 10;
            

            ICustomer1 IC1 = new MyCustomer();
            IC1.Print1();
            ICustomer2 IC2 = new MyCustomer();
            IC2.Print1();
            Console.WriteLine(IC1.ID);
            
            Console.ReadLine();
        }

    }

    class MyCustomer : ICustomer2, ICustomer1
    {
        public int ID { get; set; }

        void ICustomer1.Print1()
        {
            Console.WriteLine("Inherited from ICustomer1");
        }

        void ICustomer2.Print1()
        {
            Console.WriteLine("Inherited from ICustomer2");
        }
        
    }

}
