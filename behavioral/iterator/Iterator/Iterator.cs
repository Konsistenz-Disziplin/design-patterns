namespace Iterator;

public abstract class IteratorClass : System.Collections.IEnumerator
{
    // var it = new Iterator(); var x = it.Current; ----> this won't work
    // var x = ((IEnumerator)it).Current;  ----> this will work
    object System.Collections.IEnumerator.Current => Current();
    public abstract object Current();
    public abstract void Reset();
    public abstract int Key();
    public abstract bool MoveNext();

}
