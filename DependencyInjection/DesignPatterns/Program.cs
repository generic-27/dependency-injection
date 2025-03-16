using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Decorator.Interfaces;

ICar car = new RedPaintDecorator(new BasicCar());

Console.WriteLine($"Description: {car.GetDescription()}");
Console.WriteLine($"Price: {car.GetPrice()}");
Console.WriteLine($"Range: {car.GetRange()}");

