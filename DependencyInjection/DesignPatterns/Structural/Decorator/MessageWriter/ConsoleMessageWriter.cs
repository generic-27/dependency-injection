using DesignPatterns.Structural.Decorator.MessageWriter.Interfaces;

namespace DesignPatterns.Structural.Decorator.MessageWriter;

public class ConsoleMessageWriter : IMessageWriter
{
    public void Write(string message)
    { 
        Console.WriteLine(message);
    }
}