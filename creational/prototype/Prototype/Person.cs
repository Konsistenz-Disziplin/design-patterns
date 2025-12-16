namespace Prototype;

public class Person
{
    public string Name;
    public int Age;
    public IdInfo Id;
    public DateTime DateOfBirth;

    public Person ShallowCopy(){
        return (Person)this.MemberwiseClone();
    }
    public Person DeepCopy(){
        Person clone = ShallowCopy();
        clone.Id = new IdInfo(this.Id.Id);
        return clone;
    }
    public void DisplayValues(){
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Id: {Id.Id}");
        Console.WriteLine($"DateOfBirth: {DateOfBirth}");
    }
}
