namespace WeatherStation.Interfaces
{
    public interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }

    public interface ISubject
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }

    public interface IDisplayElement
    {
        void Display();
    }
}
