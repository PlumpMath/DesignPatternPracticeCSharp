using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Observer_Pattern
{
    public class Commander : Subject
    {
        /// <summary>
        /// Maintain a list of observers
        /// </summary>
        private List<Observer> observers;
        private string mood;

        //Constructor
        public Commander()
        {
            observers = new List<Observer>();
        }

        /// <summary>
        /// Add observer to list
        /// </summary>
        /// <param name="o"></param>
        public void AddObserver(Observer o) { observers.Add(o); }

        /// <summary>
        /// Remove observer from list
        /// </summary>
        /// <param name="o"></param>
        public void RemoveObserver(Observer o) { observers.Remove(o); }

        /// <summary>
        /// Change subject state
        /// </summary>
        /// <param name="mood"></param>
        public void ChangeMood(string mood)
        {
            this.mood = mood;
            NotifyObservers();
        }

        /// <summary>
        /// Notify every observer in the list that the state has changed.
        /// </summary>
        public void NotifyObservers()
        {
            for(int i=0; i<observers.Count;i++)
            {
                Observer o = observers[i] as Observer;
                o.Update(this);
            }
        }

        /// <summary>
        /// Getter method for observers to pull information.
        /// </summary>
        /// <returns></returns>
        public string GetMood() { return mood; }
    }
}
