// See https://aka.ms/new-console-template for more information
using Iterator;
var collection = new WordsCollection();
collection.Add("s1");
collection.Add("s2");
collection.Add("s3");
foreach(var item in collection)
{
    Console.WriteLine(item);
}
collection.ReverseDirection();
foreach(var item in collection)
{
    Console.WriteLine(item);
}