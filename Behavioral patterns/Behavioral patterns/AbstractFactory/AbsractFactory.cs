namespace Bahvioral_patterns.AbstractFactory;

public class AbsractFactory
{
    public AbsractFactory(){}

    public virtual AbstractProductA CreateProductA()
    {
        return new AbstractProductA();
    }

    public virtual AbstractProductB CreateProductB()
    {
        return new AbstractProductB();
    }
}