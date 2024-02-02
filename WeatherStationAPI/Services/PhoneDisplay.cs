namespace WeatherStationAPI.Services
{
    public class PhoneDisplay : IObserver
    {
        private readonly WeatherStation _station;

        public PhoneDisplay(WeatherStation station)
        {
            _station = station;
        }
        public int Update()
        {
           int temp =  _station.Tempreatuer;

            return temp;
        }
    }
}
