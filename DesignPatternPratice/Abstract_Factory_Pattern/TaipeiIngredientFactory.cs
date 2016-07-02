using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Abstract_Factory_Pattern
{
    public class TaipeiIngredientFactory : BentoIngredientFactory
    {

        public override Rice CreateRice()
        {
            Console.WriteLine("Added some black rice");
            return new BlackRice();
        }

        public override Vegetable CreateVegetable()
        {
            Console.WriteLine("Added some Celery");
            return new Celery();
        }

        public override Meat CreateMeat()
        {
            Console.WriteLine("Added some Chicken");
            return new ChickenMeat();
        }

        public override Soup CreateSoup()
        {
            Console.WriteLine("Added some ChickenSoup");
            return new ChickenSoup();
        }
    }
}
