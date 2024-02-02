namespace WeatherStationAPI.Services
{
    public class WeatherStation : IObservable
    {
        public List<IObserver> Observers { get; set; }
        public int Tempreatuer { get; set; }
        public void Add(IObserver observer)
        {
            Observers.Add(observer);
        }
        public void Remove(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in Observers)
            {
                observer.Update();
            }
        }

      

       
    }
}
