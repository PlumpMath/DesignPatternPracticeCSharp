using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.FactoryMethod_Pattern
{
    /// <summary>
    /// An abstract class for bento(便當)
    /// </summary>
    public abstract class Bento
    {
        /// <summary>
        /// Add some rice to bento, different kind of rice may be used.
        /// </summary>
        public abstract void PrepareRice();

        /// <summary>
        /// Adds the main course to bento, e.g. fish, pork, chicken...etc.
        /// </summary>
        public abstract void PrepareMainCourse();

        /// <summary>
        /// Add courses to bento, number depends on subclass
        /// </summary>
        public abstract void PrepareSubCourses();

        /// <summary>
        /// Add soup or drinks to bento, not all bento has it.
        /// </summary>
        public abstract void PrepareSoup();
    }
}
