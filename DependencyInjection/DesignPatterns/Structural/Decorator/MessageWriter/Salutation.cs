using DesignPatterns.Structural.Decorator.MessageWriter.Interfaces;

namespace DesignPatterns.Structural.Decorator.MessageWriter;

public class Salutation
{
    private readonly IMessageWriter _messageWriter;

    public Salutation(IMessageWriter messageWriter)
    {
        _messageWriter = messageWriter;
    }

    public void Exclaim()
    {
        this._messageWriter.Write("Hello DI!");
    }
}