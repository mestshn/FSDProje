using FSDProje.Abstract;
using FSDProje.Interfaces;
using System.Collections.Generic;

namespace FSDProje
{
    public class MarsRover : Rover, ISubject, IObserver
    {
        private List<IObserver> observers;

        public MarsRover(int x, int y, char direction, List<char> commands,string name)
        : base(x, y, direction, commands,name)
        {
            observers = new List<IObserver>();
        }

        public override void StartRover()
        {
            if (Move())
            {
                NotifyObserver();
            }
        }

        #region ISubject Implemets

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void UnregisterObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObserver()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }

        #endregion

        #region IObserver Implements
        public void Update()
        {
            StartRover();
        }
        #endregion


    }
}
