using System;
using ObserverPattern.Interface;

namespace ObserverPattern;

public class Observer : IObserver
{ 
    private Subject _subject { get; set; }
    public Observer(int id, Subject subject)
    {
        Id = id;
        _subject = subject;
    }

    private int Id  { get; set; }
    public void Update()
    {
        Console.WriteLine($"Observer {Id}: Subject says: {_subject.GetState().Message}");
    }
}
