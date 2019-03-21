using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class ManagerPerson : Employee
    {
        private double Bonus { get; set; }
        public ManagerPerson(string firstName,string lastName) : base(firstName, lastName)
        {
            Role = Role.Manager;
            Salary = 1500;
        }
        public void AddBonus(double number)
        {
            Bonus += number;
        }
        public override double GetSalary()
        {
            return base.GetSalary() + Bonus;
        }
    }
}
