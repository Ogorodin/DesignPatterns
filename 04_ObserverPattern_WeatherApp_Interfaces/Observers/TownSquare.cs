using System;

namespace _04_ObserverPattern_WeatherApp_Interfaces
{
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
}
