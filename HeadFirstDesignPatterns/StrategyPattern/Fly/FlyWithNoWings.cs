using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.Chapter1.Fly
{
    public class FlyWithNoWings : IFlyBehavior
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
