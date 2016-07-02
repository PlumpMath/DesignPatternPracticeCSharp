using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Abstract_Factory_Pattern
{
    /// <summary>
    /// Abstract Factory that makes ingredients for bento
    /// </summary>
    public abstract class BentoIngredientFactory
    {
        public abstract Rice CreateRice();
        public abstract Vegetable CreateVegetable();
        public abstract Meat CreateMeat();
        public abstract Soup CreateSoup();
    }
}
