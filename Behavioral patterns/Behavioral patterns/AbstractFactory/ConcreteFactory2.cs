namespace Bahvioral_patterns.AbstractFactory;

public class ConcreteFactory2 : AbsractFactory
{
    public override AbstractProductA CreateProductA()
    {
        return new ProductA2();
    }

    public override AbstractProductB CreateProductB()
    {
        return new ProductB2();
    }
}