using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace RxNet
{
    class RX0
    {
        //static void Main(string[] args)
        //{
        //    var subject = new Subject<string>();
        //    subject.OnNext("a");
        //    WriteSequenceToConsole(subject);
        //    subject.OnNext("b");
        //    subject.OnNext("c");
        //    Console.ReadKey();
        //}
        static void Main(string[] args)
        {

            var subject = new ReplaySubject<string>();
            subject.OnNext("a");
            WriteSequenceToConsole(subject);
            subject.OnNext("b");
            subject.OnNext("c");
            Console.ReadKey();
        }
        static void WriteSequenceToConsole(IObservable<string> sequence)
        {
            sequence.Subscribe(value => Console.WriteLine(value));
        }


    }
}
