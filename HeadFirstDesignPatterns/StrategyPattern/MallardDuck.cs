using HeadFirstDesignPatterns.Chapter1.Fly;
using HeadFirstDesignPatterns.Chapter1.QuackBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.Chapter1
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }
    }
}
