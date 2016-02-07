using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seasharpconcepts
{

    /*
     * A private constructor is a special instance constructor. 
     * It is generally used in classes that contain static members only. 
     * If a class has one or more private constructors and no public constructors, other classes (except nested classes) cannot create instances of this class.
     */
    class Program
    {
        static void Main(string[] args)
        {
            //myPrivate myp = new myPrivate();
            string myData = myPrivate.getDate();
            Console.WriteLine(myData);
            Console.ReadLine();
        }

    }

    public class myPrivate
    {
        private myPrivate()
        {

        }
        myPrivate(string s)
        {

        }

        public static string getDate()
        {
            return "Hello, World";
        }
    }

    //public class class2 : myPrivate
    //{

    //}
}
