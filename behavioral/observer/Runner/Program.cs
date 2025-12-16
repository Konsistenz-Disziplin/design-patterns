// See https://aka.ms/new-console-template for more information
using Observer;

var  subject = new Subject();
subject.Attach(new ConcreteObserverA());
var observerB = new ConcreteObserverB();
subject.Attach(observerB);
subject.Do();
//subject.Detach(observerB);
subject.Do();