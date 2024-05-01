namespace P4.TinyCell.Language.AbstractSyntaxTree.PinExpr;
public class PinOutNode : PinModeNode
{
    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitPinOutNode(this);
    }
}
