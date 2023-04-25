namespace Bahvioral_patterns.Builder;

public class ConcreteBuilder : Builder
{
    private Product _product = new Product();
    public override void BuildPartA()
    {
        _product.Add("Hello");
    }

    public override void BuildPartB()
    {
        _product.Add("Gerasimov");
    }

    public override void BuildPartC()
    {
        _product.Add("Kirill");
    }

    public override Product GetResult()
    {
        return _product;
    }
}