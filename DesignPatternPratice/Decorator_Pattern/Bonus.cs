using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Decorator_Pattern
{
    //Base bonus decorator for salary
    public class Bonus : Salary
    {
        //Uses salary as component
        protected Salary salary;

        //Constructor
        public Bonus(Salary salary)
        {
            this.salary = salary;
        }

        /// <summary>
        /// Default return 0;
        /// </summary>
        /// <returns></returns>
        public override decimal CalculateSalary()
        {
            return 0.0m;
        } 
    }
}
