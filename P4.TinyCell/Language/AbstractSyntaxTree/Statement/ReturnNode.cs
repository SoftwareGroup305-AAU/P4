using System.Net.NetworkInformation;

namespace P4.TinyCell.AST.Statement;
public class ReturnNode : AstNode
{
    public ReturnNode(AstNode returnExpression)
    {
        AddChild(returnExpression);
    }
}
