// See https://aka.ms/new-console-template for more information
using Singleton;
void TestSingleton(string value){
    Database singleton = Database.GetInstance(value);
    Console.WriteLine(singleton.Value);
}
Thread t1 = new Thread(() =>
{
 TestSingleton("2");
}
);

Thread t2 = new Thread(()=>{
  TestSingleton("1");
});
t1.Start();t2.Start();t1.Join();t2.Join();