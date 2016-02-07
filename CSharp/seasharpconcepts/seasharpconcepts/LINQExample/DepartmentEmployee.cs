using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace seasharpconcepts.LINQExample
{
    
    class DepartmentEmployee
    {
        static void Main(string[] args)
        {

            #region Create Tables

            DataTable department = new DataTable("Department");
            
            department.Columns.Add("dept_id", typeof(Int32));
            department.Columns.Add("dept_name", typeof(string));

            department.Rows.Add(1, "ACCOUNTING");
            department.Rows.Add(2, "RESEARCH");
            department.Rows.Add(3, "SALES");
            department.Rows.Add(4, "OPERATIONS");

            DataTable employee = new DataTable("Employee");
            employee.Columns.Add("emp_id", typeof(Int32));
            employee.Columns.Add("emp_fname", typeof(string));
            employee.Columns.Add("dept_id", typeof(Int32));

            employee.Rows.Add(1, "Junaid",1);
            employee.Rows.Add(1, "Zehra",2);
            employee.Rows.Add(1, "Manha", 1);
            employee.Rows.Add(1, "Nuha",2);

            #endregion


            //Matching Employees with department
            Console.WriteLine("Matching Employees with department");
            Console.WriteLine("-----------------------------------");
            var query = from d in department.AsEnumerable()
                        join e in employee.AsEnumerable()
                        on d.Field<int>("dept_id") equals
                        e.Field<int>("dept_id")
                        group d by d.Field<string>("dept_name");
                        //select new
                        //{
                        //    Name = e.Field<string>("emp_fname"),
                        //    DepartmentName = d.Field<string>("dept_name")
                        //};

            foreach (var q in query.AsEnumerable())
            {
               Console.WriteLine("Department Name = {0}", q.First().Field<string>("dept_name"));
            }

            Console.WriteLine("\n");

            //Department for which no employee exists in employee table
            Console.WriteLine("Department for which no employee exists in employee table");
            Console.WriteLine("---------------------------------------------------------");
            var result = from d in department.AsEnumerable()
                         let employeeIds = (from e in employee.AsEnumerable()
                                                     select e.Field<int>("dept_id"))
                         where !employeeIds.Contains(d.Field<int>("dept_id"))
                         select d;

            foreach (var q in result)
            {
                Console.WriteLine("Department Name = {0}", q.Field<string>(1).ToString());
            }


            Console.WriteLine("\nPress any key to continue.");


            Console.ReadLine();
        }
    }
}
