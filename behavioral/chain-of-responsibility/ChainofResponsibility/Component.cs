namespace ChainofResponsibility;

public abstract class Component : IComponentWithContextualHelp
{
    protected Container MyContainer;
    public string TooltipText;

    public void SetContainer(Container container){
        MyContainer = container;
    }



    public virtual void ShowHelp(){
        if(!string.IsNullOrEmpty(TooltipText))
            Console.WriteLine($"Component Tooltip is not Null : {TooltipText}");
        
        else{
            Console.WriteLine("Component Tooltip is Null, Showing that of the Container :");
            MyContainer.ShowHelp();
        }
        
    }

}
