using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Employees
    {
        // Private constructor
        private Employees()
        {
            Console.WriteLine("Private constructor called");
        }

        public static void DisplayMessage()
        {
            Console.WriteLine("Static method accessing private constructor");
        }
    }

    class Programs
    {
        static void Main()
        {

            Employees.DisplayMessage();
        }
    }
    }
