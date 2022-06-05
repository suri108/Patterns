using System;

namespace ObserverPattern
{
    public class Observer
    {
        string ObserverName;

        public Observer(string name)
        {
            this.ObserverName = name;
        }

        public void SendNotification()
        {
            Console.WriteLine("Notification sent to observer: " + ObserverName);
        }

    }
}
