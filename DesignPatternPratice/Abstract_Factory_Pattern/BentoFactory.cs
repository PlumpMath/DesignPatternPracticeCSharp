using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Abstract_Factory_Pattern
{
    public abstract class BentoFactory
    {
        public Bento OrderBento(string type)
        {
            Bento bento = CreateBento(type);
            bento.Prepare();
            bento.Wrap();

            Console.WriteLine("Finished {0} bento", type);
            return bento;
        }
        protected abstract Bento CreateBento(string type);
    }
}
