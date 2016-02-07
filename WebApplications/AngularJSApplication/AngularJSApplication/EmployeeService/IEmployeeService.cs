using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Web;
using System.Text;

namespace AngularJSApplication.EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeService" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeService
    {
        [WebInvoke(Method = "GET", UriTemplate = "GetEmployees", ResponseFormat=WebMessageFormat.Json)]
        [OperationContract]
        IEnumerable<Employee> GetEmployees();
    }
}
