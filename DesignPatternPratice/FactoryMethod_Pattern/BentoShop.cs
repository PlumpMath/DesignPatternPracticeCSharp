using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.FactoryMethod_Pattern
{
    /// <summary>
    /// This class is the creator for bento.
    /// </summary>
    public abstract class BentoShop
    {
        /// <summary>
        /// Allows the client to order a bento
        /// </summary>
        /// <returns></returns>
        public Bento OrderBento(string type)
        {
            Bento bento = CreateBento(type);
            bento.PrepareRice();
            bento.PrepareMainCourse();
            bento.PrepareSubCourses();
            bento.PrepareSoup();
            return bento;
        }

        /// <summary>
        /// Factory method
        /// </summary>
        /// <returns></returns>
        protected abstract Bento CreateBento(string type);
    }
}
