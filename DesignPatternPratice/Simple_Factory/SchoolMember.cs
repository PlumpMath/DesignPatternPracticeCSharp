using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Simple_Factory
{
    public abstract class SchoolMember
    {
        /// <summary>
        /// Student Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Student Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Go to school
        /// Describes how this school member goes to school.
        /// </summary>
        public abstract void GoToSchool();

        /// <summary>
        /// Go home
        /// Describes how this school member goes home.
        /// </summary>
        public abstract void GoHome();
    }
}
