namespace Bridge;

public class Radio : IDevice
{   
    public int GetVolume()
    {
        Console.WriteLine("Radio : Getting volume");
        return 10;
    }

    public void SetVolume(int volume)
    {
         Console.WriteLine($"Radio : Setting volume to {volume}");
    }

}
