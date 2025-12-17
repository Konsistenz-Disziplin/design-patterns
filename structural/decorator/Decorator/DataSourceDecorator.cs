namespace Decorator;

public abstract class DataSourceDecorator : IDataSource
{
    protected IDataSource _wrappee;
    
    public DataSourceDecorator(IDataSource dataSource)
    {
        this._wrappee = dataSource;
    }
    public abstract void WriteData(string data);
    /*{
        this._wrappee.WriteData(data);
    }*/
}
