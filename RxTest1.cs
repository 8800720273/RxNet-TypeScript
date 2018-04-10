using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RxNet
{
    class RxTest1
    {
        static void WriteSequenceToConsole(IObservable<string> sequence)
        {
            //The next two lines are equivalent.
            //sequence.Subscribe(value=>Console.WriteLine(value));
            sequence.Subscribe(Console.WriteLine);
        }
        static void Main(string[] args)
        {
            var subject = new Subject<string>();
            for (int i = 0; i < 100; i++)
            {
                subject.OnNext("Message 1");
                WriteSequenceToConsole(subject);
                Thread.Sleep(2000);
                subject.OnNext("Message 2");
                Thread.Sleep(2000);
            }
        }
    }
}
