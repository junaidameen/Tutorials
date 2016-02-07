using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seasharpconcepts
{

    class DelegateExample
    {
        public delegate void myMethodPointer();


        static void Main(string[] args)
        {
            myMethodPointer myObj = new myMethodPointer(DisplayNote);
            //myObj.Invoke();
            myObj();
            
            myClass myclss = new myClass();
            myclss.LongRunningProcess(CallBack);

            Console.ReadLine();
        }

        static void DisplayNote()
        {
            Console.WriteLine("This is an example for delegate");
        }

        static void CallBack(int i)
        {
            Console.WriteLine(i.ToString());
            
        }

    }

    class myClass
    {
        public delegate void Callbck(int i);

        public void LongRunningProcess(Callbck cb)
        {
            for (int i = 0; i < 10000; ++i)
            {
                cb(i);
            }
        }

    }

    
}
