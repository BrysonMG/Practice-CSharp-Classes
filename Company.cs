using System;
using System.Collections.Generic;

namespace practice_classes
{
    public class Company
    {
        public Company(string CompanyName, DateTime CreateDate)
        {
            Name = CompanyName;
            CreatedOn = CreateDate;
        }
        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees = new List<Employee>();
        public void ListEmployees()
        {
            foreach (Employee x in Employees)
            {
                Console.WriteLine($"{x.FirstName} {x.LastName} works for {Name} as {x.Title}");
            }
        }
        public void AddEmployee(Employee EmployeeObj)
        {
            Employees.Add(EmployeeObj);
        }
    }
}