using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Practice.Services
{
    public class DisealEngine : IEngine
    {
        public void overtake()
        {
            Console.WriteLine("You overtaken All DisealEngine Cars in race");
        }

        public void start()
        {
            Console.WriteLine("DisealEngine  Started............");
        }

        public void stop()
        {
            Console.WriteLine("DisealEngine Stopped");
        }

    }
}
