namespace Bridge;

public class TV : IDevice
{
    public int GetVolume()
    {
        Console.WriteLine("TV : Getting volume");
        return 20;
    }

    public void SetVolume(int volume)
    {
         Console.WriteLine($"TV : Setting volume to {volume}");
    }
}
