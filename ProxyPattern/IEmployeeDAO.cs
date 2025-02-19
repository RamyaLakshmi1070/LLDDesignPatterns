using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    interface IEmployeeDAO
    {
        public void Create(String client, EmployeeDo employeeDo);

        public void Get(String client, int employeeId);

        public void Delete(String client, int employeeId);
        
    }
}
