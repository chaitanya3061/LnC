using System;
using System.Collections.Generic;

namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Department { get; private set; }
        public bool IsWorking { get; private set; }

        public Employee(int id, string name, string department)
        {
            Id = id;
            Name = name;
            Department = department;
            IsWorking = true; 
        }

        public void Terminate()
        {
            IsWorking = false;
        }
    }

}
