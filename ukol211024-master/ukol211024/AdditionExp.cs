public class AdditionExp : BinaryExpression
{
    public AdditionExp(IExpression left, IExpression right) : base(left, right) {}
    public override double Evaluate()
    {
        return Left.Evaluate() + Right.Evaluate();
    }
    public override string GetString()
    {
        return $"({Left.GetString()} + {Right.GetString()})";
    }
}