using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class EmployeeDAO : IEmployeeDAO
    {
        public void Create(string client, EmployeeDo employeeDo)
        {
            Console.WriteLine("Employee has been created");
        }

        public void Delete(string client, int employeeId)
        {
            Console.WriteLine("Employee has been deleted");
        }

        public void Get(string client, int employeeId)
        {
            Console.WriteLine("Employee Details");
        }
    }
}
