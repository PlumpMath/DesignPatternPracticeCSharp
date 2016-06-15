using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Strategy_Pattern
{
    public class DefendWithShield : DefenseStrategy
    {
        /// <summary>
        /// Customized way of defending.
        /// </summary>
        public void Defend()
        {
            Console.WriteLine("Defended with shield");
        }
    }
}
