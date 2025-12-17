namespace Decorator;

public class CompressionDecorator: DataSourceDecorator
{
    public CompressionDecorator(IDataSource dataSource) : base(dataSource)
    {
        
    }
    public override void WriteData(string data)
    {
        Console.WriteLine("Compressing data");
        this._wrappee.WriteData(data+"compressed");
    }
}
