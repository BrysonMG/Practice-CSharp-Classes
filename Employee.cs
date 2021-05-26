using System;

namespace practice_classes
{
    public class Employee
    {
        public Employee(string First, string Last, string Position, DateTime Start)
        {
            FirstName = First;
            LastName = Last;
            Title = Position;
            StartDate = Start;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

    }
}