namespace Builder;

public class Product
{
    private List<string> _parts = new List<string>();
    public void Add(string part){
        _parts.Add(part);
    }
    public void ListParts(){
        for(int i = 0; i<this._parts.Count;i++){
            Console.WriteLine(_parts[i]);
        }
    }

}
