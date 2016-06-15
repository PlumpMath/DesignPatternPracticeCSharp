using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Observer_Pattern
{
    public class Private : Observer
    {
        /// <summary>
        /// Reaction to Subject's state change.
        /// Of course the observer can do more, but we're only showing the concept of Observer pattern.
        /// </summary>
        /// <param name="s"></param>
        public void Update(Subject s)
        {
            if(string.Equals(((Commander)s).GetMood(),"Mad"))
                Console.WriteLine("Oh my, it's time to run!");
        }
    }
}
