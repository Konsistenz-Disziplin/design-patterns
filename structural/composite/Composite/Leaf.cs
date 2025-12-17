namespace Composite;

public class Leaf : Component
{
    public override bool IsComposite()
    {
        return false;
    }
    public override string Operation()
    {
        return "Leaf";
    }
}
