using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.FactoryMethod_Pattern
{
    public class ChickenBento:Bento
    {
        public override void PrepareRice()
        {
            Console.WriteLine("Add some white rice.");
        }

        public override void PrepareMainCourse()
        {
            Console.WriteLine("Add one fried chicken");
        }

        public override void PrepareSubCourses()
        {
            Console.WriteLine("Add some lettuce, eggplants, and eggs");
        }

        public override void PrepareSoup()
        {
            Console.WriteLine("Add misoshiru");
        }
    }
}
