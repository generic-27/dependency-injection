using DesignPatterns.Structural.Decorator.Interfaces;

namespace DesignPatterns.Structural.Decorator;

public class RedPaintDecorator : CarDecorator
{
    public RedPaintDecorator(ICar teslaModel3) : base(teslaModel3)
    {
    }

    public override decimal GetPrice()
    {
        return base.GetPrice() + 2000;
    }

    public override string GetDescription()
    {
        return $"{base.GetDescription()}, Red Paint";
    }
}