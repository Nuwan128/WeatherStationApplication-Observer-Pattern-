namespace WeatherStationAPI.Services
{
    public interface IObservable
    {
        void Add(IObserver observer);
        void Remove(IObserver observer);

        void Notify();
    }
}
