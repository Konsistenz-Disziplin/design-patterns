namespace Bridge;

public class RemoteControl
{
    protected IDevice _device;
    public RemoteControl(IDevice device)
    {
        this._device = device;
    }
    public void VolumeUp()
    {
        Console.WriteLine("Remote Control : Increasing Volume");
        this._device.SetVolume(this._device.GetVolume()+1);
    }

    public void VolumeDown()
    {
        Console.WriteLine("Remote Control : Decreasing Volume");
        this._device.SetVolume(this._device.GetVolume()-1);
    }
}
