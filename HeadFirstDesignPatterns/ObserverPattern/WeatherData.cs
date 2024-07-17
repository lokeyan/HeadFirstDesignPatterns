using HeadFirstDesignPatterns.ObserverPattern;

namespace HeadFirstDesignPatterns.Chapter2
{
    public class WeatherData : IObservable<WeatherProperties>, IDisposable
    {
        private readonly HashSet<IObserver<WeatherProperties>> observers;
        private WeatherProperties WeatherProperties { get; set; }

        public WeatherData()
        {
            observers = new HashSet<IObserver<WeatherProperties>>();
            WeatherProperties = new WeatherProperties();
        }

        public void NotifyObserver()
        {
            foreach (var item in observers)
            {
                item.OnNext(WeatherProperties);
            }
        }

        public void SetMeasurements(float temp, float humudity, float pressure)
        {
            WeatherProperties.Temperature = temp;
            WeatherProperties.Humidity = humudity;
            WeatherProperties.Pressure = pressure;

            NotifyObserver();
        }

        public IDisposable Subscribe(IObserver<WeatherProperties> observer)
        {
            observers.Add(observer);
            return this;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
