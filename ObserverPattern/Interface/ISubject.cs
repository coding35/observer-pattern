namespace ObserverPattern.Interface;

public interface ISubject
{
    void AddObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
    Subject.SubjectState GetState();
}