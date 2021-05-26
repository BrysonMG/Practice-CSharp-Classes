using System;

namespace practice_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company Doe = new Company("Doe Family LLC", DateTime.Now);
            // Create three employees
            Employee John = new Employee("John", "Doe", "CEO", DateTime.Now);
            Employee Jim = new Employee("Jim", "Doe", "CTO", DateTime.Now);
            Employee James = new Employee("James", "Doe", "CFO", DateTime.Now);
            // Assign the employees to the company
            Doe.AddEmployee(John);
            Doe.AddEmployee(Jim);
            Doe.AddEmployee(James);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            Doe.ListEmployees();
        }
    }
}
