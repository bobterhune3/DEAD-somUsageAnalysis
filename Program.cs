using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
..using somReporter.util.somUsageAnalysis;
using somReporter.team;

namespace somReporter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting...");

            try
            {
                Program program = new Program();
                program.initialize();
            }
            catch( FileNotFoundException fnfex)
            {
                Console.Out.WriteLine(fnfex.Message);
            }

        }

        public void initialize() 
        {


        }
    }
}
