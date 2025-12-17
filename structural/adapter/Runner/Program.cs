// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Adapter;

ITarget target = new AdapterConcrete(new Adaptee());
Console.WriteLine(target.Do());
