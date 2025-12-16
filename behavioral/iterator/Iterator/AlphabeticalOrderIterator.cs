namespace Iterator;

public class AlphabeticalOrderIterator : IteratorClass
{
    private bool _reverse =false;
    private WordsCollection _collection;
    int _position = -1;
    public AlphabeticalOrderIterator(WordsCollection collection , bool reverse)
    {
        this._collection = collection;
        this._reverse = reverse;
        if (reverse)
        {
            this._position = collection.GetItems().Count;
        }
    }
    public override object Current()
    {
        return this._collection.GetItems()[_position];
    }
    public override void Reset()
    {
        this._position = this._reverse ? this._collection.GetItems().Count -1 : 0;
    }
    public override int Key()
    {
        return this._position;
    }
    public override bool MoveNext()
    {
        int nextPos = this._position + (this._reverse ? -1:1);
        if(nextPos >= 0 && nextPos < this._collection.GetItems().Count)
        {
            this._position = nextPos;
            return true;
        }
        return false;
    }
}
