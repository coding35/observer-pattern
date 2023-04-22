// See https://aka.ms/new-console-template for more information

using ObserverPattern;

// initialize the subject
Subject subject = new Subject();

// add observers
subject.AddObserver(new Observer(1, subject));
subject.AddObserver(new Observer(2, subject));
subject.AddObserver(new Observer(3, subject));

// change state on the subject, which will notify all observers
subject.Say("Good Morning!");
subject.Say("Good Day!");
subject.Say("Good Afternoon!");
subject.Say("Good Evening!");