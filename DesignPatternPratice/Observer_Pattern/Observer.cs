using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Observer_Pattern
{
    public interface Observer
    {
        /// <summary>
        /// This is the pull model of Observer pattern,
        /// taking the subject as an arguement.
        /// </summary>
        /// <param name="s"></param>
        void Update(Subject s);
    }
}
