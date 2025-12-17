namespace FlyWeight;
using System.Text.Json;

public class Flyweight
{
    private Car _sharedState;

    public Flyweight(Car car)
    {
        this._sharedState = car;
    }
    public void Operation(Car uniqueState)
    {
        string s = JsonSerializer.Serialize(this._sharedState);
        string u = JsonSerializer.Serialize(uniqueState);
        Console.WriteLine($"Flyweight : shared {s} , unique {u}");

    }
}
