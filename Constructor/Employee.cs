using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Employee
    {
        public string Name { get; set; }
        public string JobName { get; set; }
        public int Age { get; set; }
        public Employee() 
        {
            this.Name = "Jana";
            this.JobName = "Developer";
        }
        public Employee(string name, string job)
        {
            this.Name = name;
            this.JobName = job;
        }
        public Employee(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
