namespace Bahvioral_patterns.Creator;

public class ConcreteCratorB : Creator
{
    public override Product FactoryMethod()
    {
        return new ConcreteProductB();
    }
}