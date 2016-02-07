using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seasharpconcepts
{

    class RunTimePoly
    {
        static void Main(string[] args)
        {
            RunTimePoly runtime2 = new RunTimePoly2();
            runtime2.Display();
            runtime2.DisplayNumber();

            Console.ReadLine();
        }

        public virtual void Display()
        {
            Console.WriteLine("Displaying from Base Class...");
        }

        public virtual void DisplayNumber()
        {
            Console.WriteLine("Displaying from Base Class Number...");
        }

    }

    class RunTimePoly2 : RunTimePoly
    {
        public override  void Display()
        {
            Console.WriteLine("Displaying from Derived Class...");
        }

        public new void DisplayNumber()
        {
            Console.WriteLine("Displaying from Derived Class Number...");
        }

    }

   
}
