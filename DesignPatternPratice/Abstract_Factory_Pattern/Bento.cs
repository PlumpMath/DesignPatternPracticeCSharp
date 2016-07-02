using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Abstract_Factory_Pattern
{
    public abstract class Bento
    {
        /// <summary>
        /// Base class for meat
        /// </summary>
        protected Meat meat;

        /// <summary>
        /// Base class for rice
        /// </summary>
        protected Rice rice;

        /// <summary>
        /// Base class for soup
        /// </summary>
        protected Soup soup;

        /// <summary>
        /// Base class for vegetable
        /// </summary>
        protected Vegetable vegetable;

        /// <summary>
        /// Method that prepares the ingredients
        /// </summary>
        public abstract void Prepare();       

        /// <summary>
        /// Wrap up the bento!
        /// </summary>
        public void Wrap()
        {
            Console.WriteLine("Wrap this bento.");
        }
    }
}
