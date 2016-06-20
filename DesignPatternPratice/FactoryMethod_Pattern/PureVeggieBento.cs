using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.FactoryMethod_Pattern
{
    public class PureVeggieBento:Bento
    {

        public override void PrepareRice()
        {
            Console.WriteLine("Add brown rice");
        }

        public override void PrepareMainCourse()
        {
            Console.WriteLine("Add meat made of vegetables");
        }

        public override void PrepareSubCourses()
        {
            Console.WriteLine("Add a lot of vegetables");
        }

        public override void PrepareSoup()
        {
            Console.WriteLine("Add water");
        }
    }
}
