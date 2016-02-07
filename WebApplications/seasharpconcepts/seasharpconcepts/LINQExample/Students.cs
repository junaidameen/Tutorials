using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seasharpconcepts.LINQExample
{
    class Students
    {
        public int RollNumber { get; set; }
        public string StudentName { get; set; }
    }


    class StudentExample
    {
        static void Main(string[] args)
        {
            List<Students> lstudents = new List<Students>();
            lstudents.Add(new Students() { RollNumber = 139435, StudentName = "Junaid" });
            lstudents.Add(new Students() { RollNumber = 139435, StudentName = "John" });
            lstudents.Add(new Students() { RollNumber = 1567, StudentName = "Joshna" });

            IEnumerable<Students> studentNames = from ls in lstudents
                                   where ls.RollNumber == 139435
                                   select ls;

            foreach (Students i in studentNames)
            {
                Console.WriteLine(i.StudentName);
            }


            var studentReport = lstudents.Where(p => p.RollNumber == 139435)
                       .OrderByDescending(p => p.RollNumber)
                       .Select(p => new { p.RollNumber, p.StudentName });



            foreach (var stu in studentReport)
            {
                Console.WriteLine(stu.StudentName);
            }

            int[] numbers = { 1, 2, 3, 4 ,5, 6, 7 ,8 , 9, 10};

            IEnumerable<int> evenNumbers = from number in numbers
                                where (number % 2) == 0
                                select number;

            foreach(int i in evenNumbers)
            {
                Console.WriteLine(i.ToString());
            }

            int value = 2;
            int x = value << 2;

            
            Console.ReadLine();
        }
    }
}
