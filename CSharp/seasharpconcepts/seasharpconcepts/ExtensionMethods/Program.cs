using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seasharpconcepts.ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo dm = new Demo();
            dm.Title = "Hello, World";
            dm.Print();
            Console.ReadLine();
        }

    }

    static class DemoExtension
    {
        public static void Print(this Demo d)
        {
            Console.WriteLine(d.Title);
        }
    }
   
}
