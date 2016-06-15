using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Simple_Factory
{
    public class Teacher : SchoolMember
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
