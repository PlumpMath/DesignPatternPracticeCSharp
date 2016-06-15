using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Observer_Pattern
{
    /// <summary>
    /// This is the "Subject" of the whole Pattern.
    /// It has functionality to add and remove observers,
    /// and notifies the observers when its state is changed.
    /// </summary>
    public interface Subject
    {
        void AddObserver(Observer o);
        void RemoveObserver(Observer o);
        void NotifyObservers();
    }
}
