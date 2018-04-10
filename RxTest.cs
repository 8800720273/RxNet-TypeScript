using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RxNet
{
    class RxTest<T> : IObserver<T>
    {
        public void OnNext(T value)
        {
            Console.WriteLine("Hi TeamLead");

        }
        public void OnError(Exception error)
        {
            Console.WriteLine("Error {0}", error);
        }
        public void OnCompleted()
        {
           
        }
    }
    public class MySequenceOfNumbers : IObservable<int>
    {
        public IDisposable Subscribe(IObserver<int> observer)
        {
            observer.OnNext( 'M');
            Thread.Sleep(2000);
            observer.OnNext('N');
            observer.OnCompleted();
            return Disposable.Empty;
        }
    }
    public class RxMain
    {
        static void Main(string[] args)
        {
            var numbers = new MySequenceOfNumbers();
            var observer = new RxTest<int>();
            for (int i = 0; i < 100; i++)
            {
                numbers.Subscribe(observer);
            }
            Console.ReadLine();
        }
    }
}
 
    
