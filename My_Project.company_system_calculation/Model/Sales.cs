using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Project.company_system_calculation.Model
{
    public class Sales : Employee
    {
        protected Sales(int id, string name, decimal loggedHours, decimal wage, decimal salesVolume, decimal commission) : base(id, name, loggedHours, wage)
        {
            Commission = commission;
            SalesVolume = salesVolume;
        }

        protected decimal SalesVolume {  get; set; }
        protected decimal Commission { get; set; }

        public override string ToString()
        {
            return base.ToString() + 
                   $"\nCommission: {Math.Round(Commission, 2):N0}" +
                   $"\nBonus: {Math.Round(CalculateBonus(), 2):N0}" +
                   $"\nNet Salary: {Math.Round(this.Calculate(), 2):N0}";
        }
        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateBonus();
        }
        public decimal CalculateBonus()
        {
            return SalesVolume * Commission;
        }

        }
}
