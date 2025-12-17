namespace Facade;

public class VideoConverter
{
    public void Convert(string fileName, string format)
    {
        var audioMixer = new AudioMixer();
        var codec = new Codec();
        var bitrate = new BitrateReader();
        var file = new VideoFile();
        codec.Extract(file);
        bitrate.Read(fileName);
     (new AudioMixer()).Fix();
     Console.WriteLine("Converted the video");
    }
}
