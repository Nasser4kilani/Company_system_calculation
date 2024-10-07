using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Project.company_system_calculation.Model
{
    public class Employee
    {
        public const int MinimumHours = 176;
        public const decimal OverTimeRate = 1.25m;

        protected Employee(int id, string name, decimal loggedHours, decimal wage)
        {
            Id = id;
            Name = name;
            LoggedHours = loggedHours;
            Wage = wage;
        }

        protected int Id { get; set; }
        protected string Name { get; set; }
        protected decimal LoggedHours { get; set; }
        protected decimal Wage { get; set; }

        protected virtual decimal Calculate()
        {
           return CalculateBasicSalary() + CalculateOverTime();
        }
        private decimal CalculateBasicSalary()
        {
            return LoggedHours * Wage;
        }
        private decimal CalculateOverTime()
        {
            var additionalhours = ((LoggedHours - MinimumHours) > 0 ? LoggedHours - MinimumHours : 0);
            return additionalhours * Wage * OverTimeRate;
        }
        public override string ToString()
        {
            return $"\nId: {Id}" + 
                   $"\nName: {Name}" + 
                   $"\nLoggedHours: {LoggedHours} hrs" + 
                   $"\nWage: {Wage} $/hr" + 
                   $"\nBase Salary: {Math.Round(CalculateBasicSalary(), 2):N0}" + 
                   $"\nOverTime: {Math.Round(CalculateOverTime(), 2):N0}";
        }
    }
}
