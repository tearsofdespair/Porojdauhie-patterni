namespace Bahvioral_patterns.Singleton;

public class Singleton
{
    private Singleton _singletonInstance;
    public Singleton GetInstance
    {
        get => _singletonInstance == null ? _singletonInstance = new Singleton() : _singletonInstance;
    }
    
    private Singleton(){}
}