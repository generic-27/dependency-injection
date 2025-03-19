using DesignPatterns.Structural.Composite.Interfaces;

namespace DesignPatterns.Structural.Composite;

public class NumericOperand : IArithmeticExpression
{
    private long value;

    public NumericOperand(long value)
    {
        this.value = value;
    }
    
    public long Calculate()
    {
        return this.value;
    }
}