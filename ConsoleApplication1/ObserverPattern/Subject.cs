using System.Collections.Generic;

namespace ObserverPattern
{
    public class Subject
    {
        private int count = 0;

        public int Set
        {
            get
            {
                return count;
            }
            set
            {
                if (value > 0)
                    Notify();

                count = value;
            }
        }

        List<Observer> obs = new List<Observer>();

        public void Subscribe(Observer o)
        {
            obs.Add(o);
        }

        public void UnSubscribe(Observer o)
        {
            obs.Remove(o);
        }

        public void Notify()
        {
            foreach (var i in obs)
                i.SendNotification();
        }

    }
}
