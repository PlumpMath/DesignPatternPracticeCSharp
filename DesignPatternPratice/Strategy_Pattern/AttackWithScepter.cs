using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Strategy_Pattern
{
    public class AttackWithScepter : AttackStrategy
    {
        /// <summary>
        /// Customized way of attacking
        /// </summary>
        public void Attack()
        {
            Console.WriteLine("Attacked with scepter.");
        }
    }
}
