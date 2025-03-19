using DesignPatterns.Structural.Composite.Interfaces;

namespace DesignPatterns.Structural.Composite;

public class CompositeOperand : IArithmeticExpression
{
    private readonly OperatorType _operatorType;
    private readonly IArithmeticExpression _left;
    private readonly IArithmeticExpression _right;


    public CompositeOperand(OperatorType operatorTypeType, IArithmeticExpression left, IArithmeticExpression right)
    {
        this._operatorType = operatorTypeType;
        this._left = left;
        this._right = right;
    }
    
    public long Calculate()
    {
        var result = _operatorType switch
        {
            OperatorType.Add => _left.Calculate() + _right.Calculate(),
            OperatorType.Subtract => _left.Calculate() - _right.Calculate(),
            OperatorType.Multiply => _left.Calculate() * _right.Calculate(),
            OperatorType.Divide => _left.Calculate() / _right.Calculate(),
            _ => throw new ArithmeticException()
        };

        return result;
    }
}