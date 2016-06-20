using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.FactoryMethod_Pattern
{
    public class FishBento:Bento
    {

        public override void PrepareRice()
        {
            Console.WriteLine("Add some black rice.");
        }

        public override void PrepareMainCourse()
        {
            Console.WriteLine("Add one big slice of fish");
        }

        public override void PrepareSubCourses()
        {
            Console.WriteLine("Add some celery, cucumbers, and corn");
        }

        public override void PrepareSoup()
        {
            Console.WriteLine("We don't serve soup or drinks");
        }
    }
}
