
using HeadFirstDesignPatterns.Chapter1;
using HeadFirstDesignPatterns.Chapter2;
using HeadFirstDesignPatterns.Chapter2.DisplayElements;

class Program
{
    // The Main method is the entry point of a C# application
    public static void Main(string[] args)
    {
        // Chapter 1
        var mallardDuck = new MallardDuck();
        mallardDuck.PerformFly();
        mallardDuck.PerformQuack();

        //Chapter 2
        var pub = new WeatherData();
        var sub1 = new StatisticsDisplay();
        sub1.Subscribe(pub);
        pub.SetMeasurements(40, 50, 39);
    }
}
