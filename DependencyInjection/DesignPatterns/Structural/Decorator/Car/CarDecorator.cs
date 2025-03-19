using DesignPatterns.Structural.Decorator.Interfaces;

namespace DesignPatterns.Structural.Decorator;

public abstract class CarDecorator : ICar
{
    protected ICar _teslaModel3;
    
    protected CarDecorator(ICar teslaModel3)
    {
        _teslaModel3 = teslaModel3;    
    }
    
    public virtual decimal GetPrice()
    {
        return _teslaModel3.GetPrice();
    }

    public virtual string GetDescription()
    {
        return _teslaModel3.GetDescription();
    }

    public virtual int GetRange()
    {
        return _teslaModel3.GetRange();
    }
}