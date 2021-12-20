using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ParallelExamples
{
    public class ParallelSamples
    {

        public static void InvokeMultipleExceptions()
        {
            Console.WriteLine("InvokeMultipleExceptions");
            try
            {
                Parallel.Invoke(() => { throw new Exception("P1"); },
                () => { throw new Exception("P2"); });
            }
            catch (AggregateException ex)
            {
                ex.Handle(exception =>
                {
                    Trace.WriteLine(exception);
                    return true; // "handled"
                });
            }
        }
    }
}
