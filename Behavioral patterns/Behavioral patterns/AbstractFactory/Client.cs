namespace Bahvioral_patterns.AbstractFactory;

public class Client
{
    private AbstractProductA _productA;
    private AbstractProductB _productB;

    public Client(AbsractFactory factory)
    {
        _productA = factory.CreateProductA();
        _productB = factory.CreateProductB();
    }
    
    public void Run(){}
}