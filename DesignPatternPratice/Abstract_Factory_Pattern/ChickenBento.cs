using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Abstract_Factory_Pattern
{
    public class ChickenBento : Bento
    {
        private BentoIngredientFactory factory;
        public ChickenBento(BentoIngredientFactory factory)
        {
            this.factory = factory;
        }

        /// <summary>
        /// Use ingredients made from factory
        /// </summary>
        public override void Prepare()
        {
            rice = factory.CreateRice();
            meat = factory.CreateMeat();
            soup = factory.CreateSoup();
            vegetable = factory.CreateVegetable();
        }
    }
}
