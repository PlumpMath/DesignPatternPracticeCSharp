using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.FactoryMethod_Pattern
{
    public class MeatBentoShop: BentoShop
    {

        protected override Bento CreateBento(string type)
        {
            switch(type)
            {
                case "Pork":
                    return new PorkBento();
                case "Chicken":
                    return new ChickenBento();
                case "Fish":
                    return new FishBento();
            }
            return null;
        }
    }
}
