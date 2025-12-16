// See https://aka.ms/new-console-template for more information
using Strategy;

Context context = new Context(new ConcreteStrategyA());
context.Do();
context.SetStrategy(new ConcreteStrategyB());
context.Do();
