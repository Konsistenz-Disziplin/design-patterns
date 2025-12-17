namespace Decorator;

public class EncryptionDecorator : DataSourceDecorator 
{
    public EncryptionDecorator(IDataSource dataSource): base(dataSource)
    {
        
    }
    public override void WriteData(string data)
    {
        Console.WriteLine("Encrypting data");
        this._wrappee.WriteData(data+"Encrypted");
    }

}
