using System;
using System.Collections.Generic;
using System.Threading;

namespace _04_ObserverPattern_WeatherApp_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrentWeather weather = new CurrentWeather();

            TownHall th = new TownHall();
            TownSquare ts = new TownSquare();

            weather.RegisterObserver(th);
            weather.RegisterObserver(ts);

            weather.WeatherChange();

            weather.RemoveObserver(th);

            weather.WeatherChange();
        }
    }

    public class TownHall : IObserver, IDisplay
    {
        private int _temperature;
        private int _humidity;

        public void Notify(int temp, int humidity)
        {
            _temperature = temp;
            _humidity = humidity;
            DisplayData();

        }
        public void DisplayData()
        {
            Console.WriteLine("TOWN HALL");
            Console.WriteLine($"Temperature: { _temperature } \nHumidity: { _humidity }");
        }
    }

    public class TownSquare : IObserver, IDisplay
    {
        private int _temperature;
        private int _humidity;
        public void Notify(int temp, int humidity)
        {
            _temperature = temp;
            _humidity = humidity;
            DisplayData();
        }

        public void DisplayData()
        {
            Console.WriteLine("TOWN SQUARE");
            Console.WriteLine($"Temperature: { _temperature } \nHumidity: { _humidity }");
        }
    }

    public interface IDisplay
    {
        public void DisplayData();
    }

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

    /*
     *      The observer interface is implemented by all the observers.
     */
    public interface IObserver
    {
        public void Notify(int temp, int humidity);
    }

    /*
     *      The subject interface is implemented by all the classes that
     *      need to share some data with other classes
     */
    public interface ISubject
    {
        public void RegisterObserver(IObserver o);
        public void RemoveObserver(IObserver o);
        public void NotifyObservers();
    }
}
