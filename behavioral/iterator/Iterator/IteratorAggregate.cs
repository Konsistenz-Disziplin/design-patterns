namespace Iterator;

public abstract class IteratorAggregate : System.Collections.IEnumerable
{
    public abstract System.Collections.IEnumerator GetEnumerator();
}
