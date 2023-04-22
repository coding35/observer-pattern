using ObserverPattern.Interface;

namespace ObserverPattern;


public class Subject : ISubject
{
    private List<IObserver> Observers { get; set; }
    private SubjectState State { get; set; }
    
    public Subject()
    {
        State = new SubjectState();
        Observers = new List<IObserver>();
    }
    
    public void AddObserver(IObserver observer)
    {
        Observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        Observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        Observers.ForEach(observer => observer.Update(this));
    }

    public SubjectState GetState()
    {
        return State;
    }

    public void DoSomething(string message)
    {
        State.Message = message;
        Console.WriteLine("Subject: Salutation changed to: " + State.Message + "");
        NotifyObservers();
    }
    
    // inner state class
    public class SubjectState
    {
        public string Message { get; set; }
    }
}




