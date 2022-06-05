using System;

namespace ObserverPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Observer o1 = new Observer("Observer 1");
            Observer o2 = new Observer("Observer 2");
            Subject s = new Subject();
            s.Subscribe(o1);
            s.Subscribe(o2);
            s.UnSubscribe(o2);
            s.Set++;
            Console.ReadLine();
            int i = 10;
            Console.WriteLine(i.GetType() + "+++" + typeof(Int32));
            Console.ReadLine();

        }
    }
}
