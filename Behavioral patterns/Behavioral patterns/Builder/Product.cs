﻿namespace Bahvioral_patterns.Builder;

public class Product
{
    private List<object> _parts;

    public Product()
    {
        _parts = new List<object>();
    }
    
    public void Add(string part)
    {
        _parts.Add(part);
    }
}