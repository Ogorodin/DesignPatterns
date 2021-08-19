namespace _041_ObserverPattern_WeatherApp_ActionEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherConditions weather = new WeatherConditions();

            TownHall townHall = new TownHall();
            TrainStation trainStation = new TrainStation();

            weather.WeatherChanged += townHall.OnWeatherChange;
            weather.WeatherChanged += trainStation.OnWeatherChange;

            weather.GenerateWeatherChangess();

            weather.WeatherChanged -= townHall.OnWeatherChange;

            weather.GenerateWeatherChangess();
        }
    }
}
