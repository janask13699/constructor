using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("selva","Senior Developer");
            Console.WriteLine(employee.Name);
            Console.Write(employee.JobName);
            Console.ReadLine();
            Employees.DisplayMessage();
        }
    }
}
