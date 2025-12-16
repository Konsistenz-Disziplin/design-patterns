namespace Memento;

public class Editor
{
    private string _state;

    public Editor(string text){
        this._state = text;
        Console.WriteLine($"Initial State = {_state}");
    }
    public void SetText(string text){
        this._state = text;
    }
    public void AddRand(){
        // this is to mimic actions
        this._state = Guid.NewGuid().ToString("N");
        Console.WriteLine($"State changed to: {_state}");
    }
    public IMemento Save(){
        return new EditorMemento(this._state);
    }   
    public void Restore(IMemento memento){
        this._state = memento.GetState();
         Console.WriteLine($"State restored to: {_state}");
   
    }
}
