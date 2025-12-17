namespace Composite;

public class Client
{
    public void DoTree(Component tree)
    {
        Console.WriteLine($"Result: {tree.Operation()}");
    }
    public void Do2Composite(Component comp1 , Component comp2)
    {
        if (comp1.IsComposite())
        {
            comp1.Add(comp2);
        }
        
        Console.WriteLine($"Result: {comp1.Operation()}");
    }
}
