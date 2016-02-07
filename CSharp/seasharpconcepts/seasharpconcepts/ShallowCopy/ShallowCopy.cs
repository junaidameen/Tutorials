using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seasharpconcepts
{
    class ShallowCopy
    {
        static void Main(string[] args)
        {
            object[] array = { "dot", "net", "perls" };
            //string[] cloned = array.Clone() as string[];

            object[] cloned = new object[array.Length];

           
            array.CopyTo(cloned, 0);

            cloned[0] = "test";

            Console.WriteLine(string.Join(",", array));
            Console.WriteLine(string.Join(",", cloned));
            Console.WriteLine();

            // Change the first element in the cloned array.
            //cloned[0] = "element";

            Console.WriteLine(string.Join(",", array));
            Console.WriteLine(string.Join(",", cloned));

            Console.ReadLine();
        }

    }

 
}
