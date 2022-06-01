using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ReactiveExamples
{
    public class ReactiveSamples
    {

        public static void RunFirstReactive()
        {

            Observable.Interval(TimeSpan.FromSeconds(1))
                        .Timestamp()
                        .Where(x => x.Value % 2 == 0)
                        .Select(x => x.Timestamp)
                        .Subscribe(x =>  Trace.WriteLine(x));


        }
    }
}
