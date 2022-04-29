namespace FSDProje.Interfaces
{
    public interface ISubject
    {
        void RegisterObserver(IObserver o);
        void UnregisterObserver(IObserver o);
        void NotifyObserver();
    }
}
