namespace Bridge;

public class AdvancedRemoteControl : RemoteControl
{
    public AdvancedRemoteControl(IDevice device) : base(device)
    {
      
    }
    public void Mute()
    {
        this._device.SetVolume(0);
    }
}
