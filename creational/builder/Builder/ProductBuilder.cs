namespace Builder;

public class ProductBuilder : IBuilder
{
    private Product _product = new Product();
    public void Reset(){
        this._product = new Product();
    }
    public void BuildPartA(){
        this._product.Add("Part A");
    }
    public void BuildPartB(){
        this._product.Add("Part B");
    }
    public void BuildPartC(){
        this._product.Add("Part C");
    }
        public Product GetProduct(){
        Product result = this._product;
        this.Reset();
        return result;
    }
}
