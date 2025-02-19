using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class EmployeeDAOProxy : IEmployeeDAO
    {
        private readonly EmployeeDAO employeeDAO;
        public EmployeeDAOProxy(EmployeeDAO employeeDAO)
        {

            this.employeeDAO = employeeDAO;
        }
        public void Create(string client, EmployeeDo employeeDo)
        {
            if(client.Equals("ADMIN"))
            {
                employeeDAO.Create(client, employeeDo);
            }
            else
                throw new Exception("Unathorized User");
        }

        public void Delete(string client, int employeeId)
        {
            if (client.Equals("ADMIN"))
            {
                employeeDAO.Delete(client, employeeId);
            }
            else
                throw new Exception("Unathorized User");
        }

        public void Get(string client, int employeeId)
        {
            if (client.Equals("ADMIN"))
            {
                employeeDAO.Delete(client, employeeId);
            }
            else
                throw new Exception("Unathorized User");
        }
    }
}
