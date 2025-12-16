namespace Memento;

public class Caretaker
{
    private Editor _editor = null;

    private List<IMemento> _mementos =  new List<IMemento>();

    public Caretaker(Editor editor){
        this._editor = editor;
    }

    public void Backup(){
        _mementos.Add(_editor.Save());
        Console.WriteLine("Saved State");
    }
    public void Undo(){
        if(_mementos.Count == 0)
            return;
        var lastMemento = _mementos.Last();
        _editor.Restore(lastMemento);
        Console.WriteLine("Restored State");
        _mementos.Remove(lastMemento);


    }
}
