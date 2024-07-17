using HeadFirstDesignPatterns.ObserverPattern;

namespace HeadFirstDesignPatterns.Chapter2.DisplayElements
{
    public class StatisticsDisplay : IObserver<WeatherProperties>
    {
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }

        private IDisposable? _cancellation;

        public virtual void Subscribe(WeatherData provider) =>
            _cancellation = provider.Subscribe(this);

        public virtual void Unsubscribe()
        {
            _cancellation?.Dispose();
        }

        public void Display()
        {
            Console.WriteLine($"StatisticsDisplay: \n Humidity: {Humidity} Temp: {Temperature} Pressure: {Pressure}");
        }

        public void OnNext(WeatherProperties prop) 
        {
            this.Humidity = prop.Humidity;
            this.Pressure = prop.Pressure;
            this.Temperature = prop.Temperature;
            Display();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }
    }
}
