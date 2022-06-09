using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class StopwatchProgram
    {
        public void Stopwatch()
        {
            Console.WriteLine("Press Enter to start.");
            Console.ReadLine();
            DateTime start = DateTime.Now;

            Console.WriteLine("Press Enter to stop.");
            Console.ReadLine();
            DateTime stop = DateTime.Now;

            Console.WriteLine("Elapsed Time = " + (stop - start));
        }
    }
}
