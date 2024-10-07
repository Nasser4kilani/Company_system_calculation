using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Project.company_system_calculation.Model
{
    public class Maintenance : Employee
    {
        private const decimal HardShip = 100m;

        public Maintenance(int id, string name, decimal loggedHours, decimal wage) : base(id, name, loggedHours, wage)
        {
        }

        protected override decimal Calculate()
        {
            return base.Calculate() + HardShip;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nAllowance: {Math.Round(HardShip, 2):N0}" +
                $"\nNet Salary: {Math.Round(this.Calculate(), 2):N0}";
        }
    }
    
}
