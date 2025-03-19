using DesignPatterns.Structural.Decorator.Interfaces;

namespace DesignPatterns.Structural.Decorator;

public class BluePaintDecorator : CarDecorator
{
    public BluePaintDecorator(ICar teslaModel3) : base(teslaModel3)
    {
    }

    public override decimal GetPrice()
    {
        return base.GetPrice() + 1000;
    }

    public override string GetDescription()
    {
        return $"{base.GetDescription()}, Blue Paint";
    }
}