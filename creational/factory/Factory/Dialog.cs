namespace Factory;

public abstract class Dialog
{
    public abstract IButton CreateButton();
    public void Render(){
        IButton button = CreateButton();
        button.OnClick();
        button.Render();
    }
}
