using HeadFirstDesignPatterns.Chapter1.Fly;
using HeadFirstDesignPatterns.Chapter1.QuackBehavior;

namespace HeadFirstDesignPatterns.Chapter1
{
    public class Duck
    {
        public IFlyBehavior flyBehavior { get; set; }
        public IQuackBehavior quackBehavior { get; set; }

        public Duck()
        {

        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void PerformFly()
        {
            flyBehavior.Fly();
        }
    }
}
