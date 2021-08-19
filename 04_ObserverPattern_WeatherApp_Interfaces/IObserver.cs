namespace _04_ObserverPattern_WeatherApp_Interfaces
{
    /*
     *      The observer interface is implemented by all the observers.
     */
    public interface IObserver
    {
        public void Notify(int temp, int humidity);
    }
}
