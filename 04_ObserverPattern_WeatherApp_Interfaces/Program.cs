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
}
