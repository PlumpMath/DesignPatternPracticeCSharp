using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestStrategyPattern();
            //TestObserverPattern();
            //TestDecoratorPattern();
            //TestSimpleFactory();
            TestFactoryMethodPattern();
            
            Console.Read();
        }

        public static void TestStrategyPattern()
        {
            //Create Attack Strategy
            Strategy_Pattern.AttackStrategy attackStrategy = new Strategy_Pattern.AttackWithSword();
            //Create Defense Strategy
            Strategy_Pattern.DefenseStrategy defenseStrategy = new Strategy_Pattern.DefendWithShield();

            //Create a guardian
            Strategy_Pattern.Role guardian = new Strategy_Pattern.Guardian("Guardian", "Johnson", 1500, attackStrategy, defenseStrategy);
            //Attack with guardian
            guardian.Attack();
            //Defend with guardian
            guardian.Defend();

            //Create another attack strategy
            Strategy_Pattern.AttackStrategy newAttackStrategy = new Strategy_Pattern.AttackWithScepter();
            //Dynamically change attack strategy, in MMORPGs this can be caused by swapping weapons.
            guardian.SetStrategy(newAttackStrategy);
            //Attack again.
            guardian.Attack();
        }

        public static void TestObserverPattern()
        {
            //The subject
            Observer_Pattern.Commander commander = new Observer_Pattern.Commander();

            //The observers
            Observer_Pattern.Private observer1 = new Observer_Pattern.Private();
            Observer_Pattern.General observer2 = new Observer_Pattern.General();

            //Register observers
            commander.AddObserver(observer1);
            commander.AddObserver(observer2);

            //Subject state change.
            commander.ChangeMood("Mad");
        }

        public static void TestDecoratorPattern()
        {
            //two kinds of pay
            Decorator_Pattern.Salary ordinary=new Decorator_Pattern.ProjectBonus(new Decorator_Pattern.EmployeeSalary());
            Decorator_Pattern.Salary supervisor=new Decorator_Pattern.ManagerBonus(new Decorator_Pattern.ProjectBonus(new Decorator_Pattern.EmployeeSalary()));

            decimal ordinaryPay = ordinary.CalculateSalary();
            decimal managerPay = supervisor.CalculateSalary();

            Console.WriteLine("Pay for ordinary employee is {0}", ordinaryPay.ToString());
            Console.WriteLine("Pay for supervisor is {0}", managerPay.ToString());
        }

        public static void TestSimpleFactory()
        {
            //Use factory to create a student instance
            Simple_Factory.SchoolMember s = Simple_Factory.SchoolFactory.CreateSchoolMember();
            //Set properties
            s.Id = 50;
            s.Name = "Jack";
            //Print them out.
            Console.WriteLine("Id:{0} Name:{1}", s.Id, s.Name);
        }

        public static void TestFactoryMethodPattern()
        {
            DesignPatternPratice.FactoryMethod_Pattern.MeatBentoShop meatBentoShop = new FactoryMethod_Pattern.MeatBentoShop();
            DesignPatternPratice.FactoryMethod_Pattern.VeggieBentoShop veggieBentoShop = new FactoryMethod_Pattern.VeggieBentoShop();

            meatBentoShop.OrderBento("Fish");
            meatBentoShop.OrderBento("Chicken");
            veggieBentoShop.OrderBento("Pure");
        }
    }
}
