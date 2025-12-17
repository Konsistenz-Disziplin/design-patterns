// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Facade;
var videoConverter = new VideoConverter();
videoConverter.Convert("cts.ogg", "mp4");