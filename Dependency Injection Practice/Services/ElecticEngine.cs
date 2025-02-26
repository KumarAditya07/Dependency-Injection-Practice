using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Practice.Services
{
    public class ElectricEngine : IEngine
    {
        public void overtake()
        {
            Console.WriteLine("You overtaken All Electric Cars in race");
        }

        public void start()
        {
            Console.WriteLine("Electric Engine Started............");
        }

        public void stop()
        {
            Console.WriteLine("Electric Engine Stopped");
        }

    }
}
