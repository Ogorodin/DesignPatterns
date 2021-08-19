using System;

namespace _041_ObserverPattern_WeatherApp_ActionEvent
{
    /*
     *      This is the observer class. Note the OnWeatherChange(int, int) that corresponds
     *      to the event from the WeatherConditions class => public event Action<int, int> WeatherChanged;
     */
    public class TrainStation : IDisplay
    {
        private int _temperature;
        private int _humidity;

        public void OnWeatherChange(int temp, int hum)
        {
            _temperature = temp;
            _humidity = hum;
            Display();
        }
        public void Display()
        {
            Console.WriteLine("TRAIN STATION");
            Console.WriteLine($"Temperature: { _temperature }\nHumidity: { _humidity }");
        }
    }
}
