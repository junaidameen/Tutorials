using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seasharpconcepts
{
    class GenericExample
    {
        static void Main(string[] args)
        {
            //bool Equal = Calculator.AreEqual(3, 5);
            bool Equal = Calculator<int>.AreEqual(5, 8);
            
            if(Equal)
                Console.WriteLine("Equal");
            else
                Console.WriteLine("No Equal");

            Console.ReadLine();
        }
       
    }

    class Calculator<T>
    {
        public static bool AreEqual(T Value1, T Value2)
        {
            //return Value1 == Value2;
            return Value1.Equals(Value2);
        }
    }
}
