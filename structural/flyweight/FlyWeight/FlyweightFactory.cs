namespace FlyWeight;

public class FlyweightFactory
{
    private List<Tuple<Flyweight,string>> _flyweights = new List<Tuple<Flyweight, string>>();
    public FlyweightFactory(params Car[] args)
    {
        foreach(var elem in args)
        {
            _flyweights.Add(new Tuple<Flyweight,string>(new Flyweight(elem),this.GetKey(elem)));
        }
    }

    public string GetKey(Car car)
    {
        List<string> elements = new List<string>();
        elements.Add(car.Model);
        elements.Add(car.Color);
        elements.Add(car.Company);
        /*(if(car.Owner != null && car.Number != null)
        {
            elements.Add(car.Number);
            elements.Add(car.Owner);
        }*/
        elements.Sort();
        return string.Join("_",elements);
    }

    public void ListFlyweights()
    {
        Console.WriteLine($"FlyweightFactory contains {_flyweights.Count} flyweights");
        foreach(var flyweight in _flyweights)
        {
            Console.WriteLine(flyweight.Item2);
        }
    }

    public Flyweight GetFlyWeight(Car sharedState)
    {
        string key = this.GetKey(sharedState);
        if(this._flyweights.Where(t=> t.Item2 == key).Count() == 0)
        {
            Console.WriteLine("FlyweightFactory creating new Flyweight ");
            this._flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(sharedState), key));
        }
        else
        {
            Console.WriteLine("Reusing existing flyweight");
        }
        return this._flyweights.Where(t=>t.Item2 == key).FirstOrDefault().Item1;
    }

}
