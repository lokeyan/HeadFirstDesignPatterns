using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.Chapter2
{
    public interface IObserver
    {
        void update(float temp, float humudity, float pressure);
    }
}
