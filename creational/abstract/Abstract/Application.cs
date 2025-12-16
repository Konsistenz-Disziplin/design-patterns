namespace Abstract;

public class Application
{
    private IGUIFactory _factory;

    public Application(IGUIFactory GUIFactory){
        _factory = GUIFactory;
    } 
    
    public void AppMethod(){
        _factory.CreateButton().Paint();
        _factory.CreateCheckbox().Paint();
    }
}
