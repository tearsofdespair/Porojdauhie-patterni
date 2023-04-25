namespace Bahvioral_patterns.AbstractFactory;

public class ConcreteFactory1 : AbsractFactory
{
    public override AbstractProductA CreateProductA()
    {
        return new ProductA1();
    }

    public override AbstractProductB CreateProductB()
    {
        return new ProductB1();
    }
}