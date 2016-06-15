using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Decorator_Pattern
{
    /// <summary>
    /// Class that represents bonus for managers
    /// </summary>
    public class ManagerBonus : Bonus
    {
        //Constructor
        public ManagerBonus(Salary salary) : base(salary) { }

        //Override method
        public override decimal CalculateSalary()
        {
            decimal original = salary.CalculateSalary();
            return original + 6000m;
        }
    }
}
