namespace Factory;

public class WindowsButton : IButton 
{
    public void OnClick(){
        Console.WriteLine("Windows OnClick");
    }
    public void Render(){
        Console.WriteLine("Windows Render");
    }
}
