using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
    public class Subject
    {
        private List<Monthly> observers = new List<Monthly>();

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.NotifyObservers();
            }
        }

        // Method to add an observer
        public void AddObserver(Monthly observer)
        {
            observers.Add(observer);
        }

        // Method to remove an observer based on its ID
        public void RemoveObserver(Monthly observer)
        {
            observers.Remove(observer);
        }
    }
}
