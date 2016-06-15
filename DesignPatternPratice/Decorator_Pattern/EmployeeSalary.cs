using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Decorator_Pattern
{
    public class EmployeeSalary : Salary
    {
        /// <summary>
        /// returns basic salary for each employee
        /// </summary>
        /// <returns></returns>
        public override decimal CalculateSalary()
        {
            return 30000.0m;
        }
    }
}
