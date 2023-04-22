using ObserverPattern.Interface;

namespace ObserverPattern;

public class Observer : IObserver
{
    public Observer(int id)
    {
        Id = id;
    }
    
    public int Id  { get; set; }
    public void Update(ISubject subject)
    {
        Console.WriteLine($"Observer {Id}: Subject says: {subject.GetState().Message}");
    }
}
