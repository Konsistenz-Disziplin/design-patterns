// See https://aka.ms/new-console-template for more information
using Visitor;

List<IComponent> comps = new List<IComponent>();
comps.Add(new ConcreteComponent1());
comps.Add(new ConcreteComponent2());
Client.Do(comps,new ConcreteVisitor1());
Client.Do(comps,new ConcreteVisitor2());
