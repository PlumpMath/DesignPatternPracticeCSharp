using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace DesignPatternPratice.Simple_Factory
{
    public static class SchoolFactory
    {
        /// <summary>
        /// Method that creates a student instance,
        /// class name loaded from App.Config, and created by reflection.
        /// </summary>
        /// <returns></returns>
        public static SchoolMember CreateSchoolMember()
        {
            //Get full name of class, make sure System.Configuration is added to reference and using statement.
            string fullname = ConfigurationManager.AppSettings.Get("Student");
            //Get instance by reflection, creates a student in this case.
            SchoolMember student = (SchoolMember)Activator.CreateInstance(null, fullname).Unwrap();
            //return the instance
            return student;
        }
    }
}
