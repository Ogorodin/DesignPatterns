using System;
using System.Collections.Generic;
using System.Threading;

namespace _04_ObserverPattern_WeatherApp_Interfaces
{
    /*
     *      This is the Subject class. This class we want to be observed. It holds a list of
     *      observers than are notified about the changes.
     */
    public class CurrentWeather : ISubject
    {
        private int _temperature;
        private int _humidity;

        private List<IObserver> _observers;

        public CurrentWeather()
        {
            _observers = new List<IObserver>();
        }

        public void NotifyObservers()
        {
            if (_observers.Count > 0)
            {
                foreach (IObserver observer in _observers)
                {
                    observer.Notify(_temperature, _humidity);
                }
            }
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            if (_observers.Count > 0)
            {
                _observers.Remove(o);
            }
        }

        public void WeatherChange()
        {
            // setting up random values to make app more realistic
            Random random = new Random();
            int milis;

            int counter = 10; // number of weather changes

            while (counter > 0)
            {
                milis = random.Next(650, 1750);
                Thread.Sleep(milis);

                _temperature = random.Next(-20, 40);
                _humidity = random.Next(0, 120);

                // notify observers after each change
                NotifyObservers();
                Console.Write($"\n--------------------------- { counter }\n");
                
                counter--;
            }
        }
    }
}
