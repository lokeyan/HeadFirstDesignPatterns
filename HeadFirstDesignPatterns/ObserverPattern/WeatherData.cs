using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.Chapter2
{
    public class WeatherData : ISubject
    {
        public List<IObserver> observers;
        private float Temperature { get; set; }
        private float Humidity { get; set; }
        private float Pressure { get; set; }

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void NotifyObserver()
        {
            foreach (var obs in observers)
            {
                obs.update(Temperature, Humidity, Pressure);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            if (observers.Contains(o))
            {
                observers.Remove(o);
            }
        }

        public void SetMeasurements(float temp, float humudity, float pressure)
        {
            this.Temperature = temp;
            this.Humidity = humudity;
            this.Pressure = pressure;

            NotifyObserver();
        }
    }
}
