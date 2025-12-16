namespace Iterator;

public class WordsCollection : IteratorAggregate
{
    private List<string> _collection = new List<string>();
    private bool _reverse = false;
    public override System.Collections.IEnumerator GetEnumerator()
    {
        return new AlphabeticalOrderIterator(this,_reverse);
    }

    public void ReverseDirection()
    {
        this._reverse = !_reverse;
    }
    public List<string> GetItems()
    {
        return this._collection;
    }
    public void Add(string item)
    {
        this._collection.Add(item);
    }

}
