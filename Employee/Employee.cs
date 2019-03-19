﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }
        public Employee(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string PrintInfo()
        {
            return $"{FirstName} {LastName} {Salary}"; 
        }
        public virtual double GetSalary()
        {
            return Salary;
        }

    }
}
