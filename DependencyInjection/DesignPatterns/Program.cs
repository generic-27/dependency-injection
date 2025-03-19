using DesignPatterns.Structural.Decorator.MessageWriter;
using DesignPatterns.Structural.Decorator.MessageWriter.Interfaces;

IMessageWriter messageWriter = new ConsoleMessageWriter();
var salutation = new Salutation(messageWriter);
salutation.Exclaim();