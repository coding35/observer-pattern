// See https://aka.ms/new-console-template for more information

using ObserverPattern;

// initialize the subject
Subject subject = new Subject();

// add observers
subject.AddObserver(new Observer(1));
subject.AddObserver(new Observer(2));
subject.AddObserver(new Observer(3));

// change state on the subject, which will notify all observers
subject.DoSomething("Good Morning!");
subject.DoSomething("Good Day!");
subject.DoSomething("Good Afternoon!");
subject.DoSomething("Good Evening!");