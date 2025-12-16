namespace Memento;

public class EditorMemento : IMemento
{
    private string _state;
    public EditorMemento(string state){
        _state = state;
    }
    public string GetState(){
        return this._state;
    }
}
