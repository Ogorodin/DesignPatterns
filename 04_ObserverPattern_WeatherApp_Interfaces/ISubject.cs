namespace _04_ObserverPattern_WeatherApp_Interfaces
{
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
