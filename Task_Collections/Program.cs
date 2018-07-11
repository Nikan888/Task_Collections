using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Crew crew = new Crew
            {
                new Worker { FirstName = "Groznyi", Age = 25, WorkPosition = "Mechanic" },
                new Worker { FirstName = "Korablov", Age = 34, WorkPosition = "Technician-technologist" },
                new Worker { FirstName = "Vasnetsov", Age = 25, WorkPosition = "Technician-designer" },
                new Worker { FirstName = "Dyatlov", Age = 45, WorkPosition = "Technician-metrologist" },
                new Worker { FirstName = "Kotov", Age = 49, WorkPosition = "Chief of the workshop of experimental production" }
            };

            crew.Sort();
            foreach (var w in crew)
            {
                Console.WriteLine(w);
            }
            Console.ReadKey();
        }
    }
}
