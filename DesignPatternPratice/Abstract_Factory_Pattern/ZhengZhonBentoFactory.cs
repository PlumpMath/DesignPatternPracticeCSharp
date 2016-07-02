using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Abstract_Factory_Pattern
{
    public class ZhengZhonBentoFactory : BentoFactory
    {
        private BentoIngredientFactory bentoIngredientFactory = new KaohsiungBentoIngredientFactory();
        protected override Bento CreateBento(string type)
        {
            switch (type)
            {
                case "beef":
                    return new BeefBento(bentoIngredientFactory);
                case "chicken":
                    return new ChickenBento(bentoIngredientFactory);
                default:
                    Console.WriteLine("Wrong type");
                    break;
            }
            return null;
        }
    }
}
