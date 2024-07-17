namespace HeadFirstDesignPatterns.Chapter2.DisplayElements
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }

        public ISubject subject;

        public StatisticsDisplay(ISubject s)
        {
            subject = s;
            subject.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"StatisticsDisplay: \n Humidity: {Humidity} Temp: {Temperature} Pressure: {Pressure}");
        }

        public void update(float temp, float humudity, float pressure)
        {
            this.Humidity = humudity;
            this.Pressure = pressure;
            this.Temperature = temp;
            Display();
        }
    }
}
