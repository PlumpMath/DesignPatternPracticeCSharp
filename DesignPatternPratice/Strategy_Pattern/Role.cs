using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Strategy_Pattern
{
    /// <summary>
    /// The base class for all types of characters.
    /// We roughly define three types, which are "Thieves", "Guardian", and "Elementalist".
    /// </summary>
    public abstract class Role
    {
        //Character Type
        protected string charType;
        protected string name;
        protected double hitPoints;

        //Strategy for attacking
        protected AttackStrategy attackStrategy;
        //Strategy for defending
        protected DefenseStrategy defenseStrategy;

        //Constructor
        public Role(string charType,string name, double hitPoints, AttackStrategy attackStrategy, DefenseStrategy defenseStrategy)
        {
            this.charType = charType;
            this.name = name;
            this.hitPoints = hitPoints;
            this.attackStrategy=attackStrategy;
            this.defenseStrategy = defenseStrategy;
        }

        //Overload constructor with default attack and defenses strategy.
        public Role(string charType, string name, double hitPoints) : this(charType, name, hitPoints, new AttackWithSword(), new DefendWithShield()) { }

        //Attacks with current attack strategy.
        public void Attack(){
            Console.Write("{0} {1} ", charType, name);
            attackStrategy.Attack();
        }

        //Attacks with current defend strategy.
        public void Defend()
        {
            Console.Write("{0} {1} ", charType, name);
            defenseStrategy.Defend();
        }

        //Setter to dynamically change attack strategy
        public void SetStrategy(AttackStrategy attackStrategy)
        {
            Console.WriteLine("{0} {1} has changed attack strategy.", charType, name);
            this.attackStrategy=attackStrategy;
        }

        //Setter to dynamically change defense strategy
        public void SetStrategy(DefenseStrategy defenseStrategy)
        {
            Console.WriteLine("{0} {1} has changed defense strategy.", charType, name);
            this.defenseStrategy = defenseStrategy;
        }
    }
}
