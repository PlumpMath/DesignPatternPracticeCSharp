using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Abstract_Factory_Pattern
{
    public class KaohsiungBentoIngredientFactory : BentoIngredientFactory
    {
        public override Rice CreateRice()
        {
            Console.WriteLine("Added some white rice");
            return new WhiteRice();
        }

        public override Vegetable CreateVegetable()
        {
            Console.WriteLine("Added some Spinach");
            return new Spinach();
        }

        public override Meat CreateMeat()
        {
            Console.WriteLine("Added some Pork");
            return new Pork();
        }

        public override Soup CreateSoup()
        {
            Console.WriteLine("Added some Beef Soup");
            return new BeefSoup();
        }
    }
}
