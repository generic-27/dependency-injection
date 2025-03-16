using DesignPatterns.Structural.Decorator.Interfaces;

namespace DesignPatterns.Structural.Decorator;

public class BasicCar : ICar
{
    public decimal GetPrice()
    {
        return 20000m;
    }

    public string GetDescription()
    {
        return "Basic car model";
    }

    public int GetRange()
    {
        return 400;
    }
}