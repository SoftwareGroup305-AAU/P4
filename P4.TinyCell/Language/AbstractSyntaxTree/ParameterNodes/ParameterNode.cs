using P4.TinyCell.Language.AbstractSyntaxTree.Primitive;

namespace P4.TinyCell.Language.AbstractSyntaxTree.ParameterNodes;
public class ParameterNode(AstNode type, AstNode identifier) : AstNode
{
    public Type Type { get; set; }
    public IdentifierNode Identifier { get; set; }
}
