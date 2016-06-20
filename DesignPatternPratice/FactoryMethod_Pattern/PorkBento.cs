using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.FactoryMethod_Pattern
{
    public class PorkBento:Bento
    {
        public override void PrepareRice()
        {
            Console.WriteLine("Add some black rice.");
        }

        public override void PrepareMainCourse()
        {
            Console.WriteLine("Add one big slice of pork");
        }

        public override void PrepareSubCourses()
        {
            Console.WriteLine("Add some spinach, winter melons, and bitter gourd");
        }

        public override void PrepareSoup()
        {
            Console.WriteLine("Add sprite.");
        }
    }
}
