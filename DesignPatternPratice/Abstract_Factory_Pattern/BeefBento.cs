using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Abstract_Factory_Pattern
{
    public class BeefBento : Bento
    {
        private BentoIngredientFactory factory;
        public BeefBento(BentoIngredientFactory factory)
        {
            this.factory = factory;
        }

        public override void Prepare()
        {
            rice = factory.CreateRice();
            meat = factory.CreateMeat();
            soup = factory.CreateSoup();
            vegetable = factory.CreateVegetable();
        }
    }
}
