namespace Factory;

public class WindowsDialog:Dialog
{
public override IButton CreateButton(){
    return new WindowsButton();
}
}
