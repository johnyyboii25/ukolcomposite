public class NegationExp : UnaryExpression
{
    public NegationExp(IExpression operand) : base(operand)
    {}

    public override double Evaluate()
    { 
        return -Operand.Evaluate();
    }
    public override string GetString()
    {
        return $"-{Operand.GetString()}";
    }
}