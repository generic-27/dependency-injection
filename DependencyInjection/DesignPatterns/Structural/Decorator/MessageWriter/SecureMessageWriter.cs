using System.Security.Principal;
using DesignPatterns.Structural.Decorator.MessageWriter.Interfaces;

namespace DesignPatterns.Structural.Decorator.MessageWriter;

public class SecureMessageWriter: IMessageWriter
{
    private readonly IMessageWriter _messageWriter;
    private readonly IIdentity _identity;

    public SecureMessageWriter(IIdentity identity, IMessageWriter messageWriter)
    {
        _identity = identity;
        _messageWriter = messageWriter;
    }
    
    public void Write(string message)
    {
        if (_identity.IsAuthenticated)
        {
            this._messageWriter.Write(message);
        }
    }
}