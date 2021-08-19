using System;

namespace _041_ObserverPattern_WeatherApp_ActionEvent
{
    /*
     *      This is the observer class. Note the OnWeatherChange(int, int) that corresponds
     *      to the event from the WeatherConditions class => public event Action<int, int> WeatherChanged;
     */
    public class TownHall : IDisplay
    {
        private int _temperature;
        private int _humidity;

        public void OnWeatherChange(int temp, int humidity)
        {
            this._temperature = temp;
            this._humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("TOWN HALL");
            Console.WriteLine($"Temperature: { _temperature }\nHumidity: { _humidity }");
        }
    }
}
