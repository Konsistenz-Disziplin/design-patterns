namespace Factory;

public class HTMLButton : IButton
{
    public void Render(){
        Console.WriteLine("HTML Render");
    }
    public void OnClick(){
        Console.WriteLine("HTML OnClick");
    }

}
