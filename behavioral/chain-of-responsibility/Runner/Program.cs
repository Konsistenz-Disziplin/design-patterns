// See https://aka.ms/new-console-template for more information
using ChainofResponsibility;

Button cancelButton ;
 Panel panel ;
void CreateUI(){
    Dialog dialog = new Dialog("Dialog Help","http://");
    Button ok = new Button();
    cancelButton = new Button();
    cancelButton.TooltipText = "Are you sure you want to cancel";
    panel = new Panel();
    panel.Add(ok);
    panel.Add(cancelButton);
    dialog.Add(panel);

}

void OnCancelButtonClick(){
    cancelButton.ShowHelp();
}
void OnPanelClick(){
    panel.ShowHelp();
}
CreateUI();
OnCancelButtonClick();
OnPanelClick();
