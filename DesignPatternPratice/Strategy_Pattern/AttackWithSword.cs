using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Strategy_Pattern
{
    public class AttackWithSword : AttackStrategy
    {
        /// <summary>
        /// Customized way of attacking
        /// </summary>
        public void Attack()
        {
            Console.WriteLine("Attacked with sword");
        }
    }
}
