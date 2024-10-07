using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Project.company_system_calculation.Model
{
    public class Developer : Employee
    {
        protected bool TaskCompleted {  get; set; }
        private const decimal Commission = 0.03m;

        protected Developer(int id, string name, decimal loggedHours, decimal wage, bool taskCompleted) : base(id, name, loggedHours, wage)
        {
            TaskCompleted = taskCompleted;
        }

        public decimal CalculateBonus()
        {
            if (TaskCompleted)
                return base.Calculate() + Commission;
            return 0;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nTaskCompleted: {(TaskCompleted ? "Yes": "NO")}" +
                $"\nCommission: {Math.Round(Commission, 2):N0}" +
                $"\nNet Salary: {Math.Round(this.Calculate(), 2):N0}";
        }
    }
}
