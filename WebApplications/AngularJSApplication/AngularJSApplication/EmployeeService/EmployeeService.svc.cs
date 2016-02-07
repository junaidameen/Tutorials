using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AngularJSApplication.EmployeeService
{

    public class EmployeeService : IEmployeeService
    {
        public IEnumerable<Employee> GetEmployees()
        {
            List<Employee> emp = new List<Employee>()
                {
                    new Employee { EmployeeId = 1,Name = "Junaid", Gender = "Male", Salary = 25000},
                    new Employee { EmployeeId = 2,Name = "Zehra", Gender = "Female", Salary = 23000},
                    new Employee { EmployeeId = 3,Name = "Manha", Gender = "Female", Salary = 27000},
                };

           return emp;
        }
    }
}
