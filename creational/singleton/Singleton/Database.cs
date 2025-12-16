namespace Singleton;

public class Database
{
    private Database(){
    }
    private static Database _instance;
    private static readonly object _lock = new object();
    public string Value {get;set;}
    public static Database GetInstance(string value){
        if(_instance == null){ // once instance is created , don't use the lock again
            lock(_lock){
                if(_instance == null){ // when lock is realeased , the other waiting threads won't recreate the instance
                    _instance = new Database();
                    _instance.Value = value;
                }
            }
        }
        return _instance;
    }
}
