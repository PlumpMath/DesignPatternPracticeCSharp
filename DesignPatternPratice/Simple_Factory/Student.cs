using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Simple_Factory
{
    /// <summary>
    /// Just a POCO representing a student
    /// </summary>
    public class Student : SchoolMember
    {
        public override void GoToSchool()
        {
            throw new NotImplementedException();
        }

        public override void GoHome()
        {
            throw new NotImplementedException();
        }
    }
}
