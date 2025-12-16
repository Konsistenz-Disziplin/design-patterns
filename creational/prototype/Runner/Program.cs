// See https://aka.ms/new-console-template for more information
using Prototype;

Person p1 = new Person();
p1.Name = "S1";
p1.Age = 1;
p1.DateOfBirth = Convert.ToDateTime("2001-01-01");
p1.Id = new IdInfo(1);
p1.DisplayValues();
Console.WriteLine("p1 displayed");
Person p2 = p1.ShallowCopy();
p2.DisplayValues();
Console.WriteLine("p2 displayed");
Person p3 = p1.DeepCopy();
p3.DisplayValues();
Console.WriteLine("p3 displayed");
p1.Age = 2;
p1.DateOfBirth = Convert.ToDateTime("2002-02-02");
p1.Name = "S2";
p1.Id.Id = 2;
p1.DisplayValues();
Console.WriteLine("p1 displayed");
p2.DisplayValues();
Console.WriteLine("p2 displayed");
p3.DisplayValues();
Console.WriteLine("p3 displayed");