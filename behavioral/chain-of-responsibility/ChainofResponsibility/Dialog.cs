namespace ChainofResponsibility;

public class Dialog : Container
{
    private string url;
    public Dialog(string tooltipText , string url){
        TooltipText =tooltipText;
        url = url;
    }
    public override void ShowHelp(){
        if(string.IsNullOrEmpty(url)){
            base.ShowHelp();
        }
        else{
            Console.WriteLine("Opening the URL");
        }
    }
}
