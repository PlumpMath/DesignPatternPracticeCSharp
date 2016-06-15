using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Strategy_Pattern
{
    public class Guardian : Role
    {
        /// <summary>
        /// Detailed version of Constructor
        /// </summary>
        /// <param name="charType"></param>
        /// <param name="name"></param>
        /// <param name="hitPoints"></param>
        /// <param name="attackStrategy"></param>
        /// <param name="defenseStrategy"></param>
        public Guardian(string charType, string name, double hitPoints, AttackStrategy attackStrategy, DefenseStrategy defenseStrategy)
            : base(charType,name,hitPoints,attackStrategy,defenseStrategy){}

        /// <summary>
        /// Overloaded version
        /// </summary>
        /// <param name="charType"></param>
        /// <param name="name"></param>
        /// <param name="hitPoints"></param>
        public Guardian(string charType, string name, double hitPoints) : base(charType, name, hitPoints) { }
    }
}
