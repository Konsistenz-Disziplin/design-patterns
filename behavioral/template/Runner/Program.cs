// See https://aka.ms/new-console-template for more information
using Template;

Client client = new Client();
Console.WriteLine("Doing 1");
client.Do(new ConcreteClass1());
Console.WriteLine("Doing 2");
client.Do(new ConcreteClass2());
