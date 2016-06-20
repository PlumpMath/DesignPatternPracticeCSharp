using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.FactoryMethod_Pattern
{
    public class VeggieBentoShop : BentoShop
    {
        protected override Bento CreateBento(string type)
        {
            switch (type)
            {
                case "Pure":
                    return new PureVeggieBento();
                case "EggMilk":
                    break;
            }
            return null;
        }
    }
}
