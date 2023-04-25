namespace Bahvioral_patterns.Creator;

public class Creator
{
    public Creator(){}
    
    public virtual Product FactoryMethod()
    {
        return new Product();
    }
}