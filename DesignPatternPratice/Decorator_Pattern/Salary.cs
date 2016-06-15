using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Decorator_Pattern
{
    /// <summary>
    /// Base component, represents an abstract concept of Salary
    /// </summary>
    public abstract class Salary
    {
        public abstract decimal CalculateSalary();
    }
}
