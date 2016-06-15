using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Decorator_Pattern
{
    public class ProjectBonus : Bonus
    {
        //Constructor
        public ProjectBonus(Salary salary) : base(salary) { }

        //Override base class and provide bonus for participating in a project.
        public override decimal CalculateSalary()
        {
            decimal original = salary.CalculateSalary();
            return original+original * 0.05m;
        }
    }
}
