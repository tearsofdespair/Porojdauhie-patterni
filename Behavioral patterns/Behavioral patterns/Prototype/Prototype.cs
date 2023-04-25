namespace Bahvioral_patterns.Prototype;

public class Prototype
{
    public int Id;

    public Prototype(int id)
    {
        Id = id;
    }
    
    public Prototype Clone()
    {
        return this;
    }
}