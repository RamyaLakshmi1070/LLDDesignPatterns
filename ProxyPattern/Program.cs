namespace ProxyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployeeDAO employeeDAO = new EmployeeDAOProxy(new EmployeeDAO());
            try
            {
                employeeDAO.Create("ADMIN", new EmployeeDo());
                Console.WriteLine("Processed Successfully");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
