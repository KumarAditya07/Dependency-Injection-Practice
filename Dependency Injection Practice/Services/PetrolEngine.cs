using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Practice.Services
{
    public class PetrolEngine : IEngine
    {
        public void overtake()
        {
            Console.WriteLine("You overtaken All Petrol Cars in race");
        }

        public void start()
        {
            Console.WriteLine("Petol Engine Started............");
        }

        public void stop()
        {
            Console.WriteLine("Petrol Engine Stopped");
        }

    }
}
