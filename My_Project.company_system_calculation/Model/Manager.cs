using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Project.company_system_calculation.Model
{
    public class Manager : Employee
    {
        private const decimal AllowanceRate = 0.05m;

        protected Manager(int id, string name, decimal loggedHours, decimal wage) : base(id, name, loggedHours, wage)
        {
            
        }

        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateAllowance();                
        }
        private decimal CalculateAllowance()
        {
            return base.Calculate() * AllowanceRate;
        }
        
        public override string ToString()
        {
            return base.ToString() + 
                $"\nAllowance: {Math.Round(CalculateAllowance(), 2):N0}" + 
                $"\nNet Salary: {Math.Round(this.Calculate(), 2):N0}";
        }
        
    }
}
