using System;
using System.Threading;

namespace _041_ObserverPattern_WeatherApp_ActionEvent
{
    /*  SUBJECT CLASS
     *  
     *  Implementing the observer pattern this way does not require additional interfaces for
     *  implementing the needed method. A simple event Action has all the needed functionality
     *  built in for us. All that is needed is that the classes which intend subscribing to
     *  the event MUST HAVE appropriate methods.
     */
    public class WeatherConditions
    {
        // event object
        public event Action<int, int> WeatherChanged;

        private int _temperature;
        private int _humidity;

        public void GenerateWeatherChangess()
        {
            Random random = new Random();
            int milis;

            int counter = 10; // number of weather changes
            while (counter > 0)
            {
                milis = random.Next(750, 1750);
                Thread.Sleep(milis);

                _temperature = random.Next(-50, 25);
                _humidity = random.Next(20, 100);

                // triggeering the event
                WeatherChanged(_temperature, _humidity);
                Console.WriteLine($"\n-----------------------------{ counter }\n");
                counter--;
            }
        }
    }
}
