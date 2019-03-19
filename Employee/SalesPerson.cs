using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue { get; set; }
        public SalesPerson(string firstName,string lastName) : base(firstName,lastName)
        {
            Role = Role.Sales;
            Salary = 500;
        }
        public double AddSuccessRevenue(double number)
        {
           return  SuccessSaleRevenue = number;
        }
        public override double GetSalary()
        {
            return base.GetSalary() + CalculateBonus();
        } public double CalculateBonus()
        {
            if (SuccessSaleRevenue <= 2000)
            {
                return 500;
            }else if(SuccessSaleRevenue>2000 && SuccessSaleRevenue<=5000) {
                return 1000;
            }
            return 1500;
        }
    }
}
