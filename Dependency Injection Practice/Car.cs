using Dependency_Injection_Practice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Practice
{
    public class Car
    {
        private readonly IEngine _engine;

        public Car(IEngine engine) 
        {
            _engine = engine;
        
        }

        public void Run()
        {
            _engine.start();
            _engine.overtake();
            _engine.stop();
        }
    }
}
