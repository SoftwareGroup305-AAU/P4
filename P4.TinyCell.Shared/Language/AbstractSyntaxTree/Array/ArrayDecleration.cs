using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Types;

namespace P4.TinyCell.Shared.Language.AbstractSyntaxTree.Array;
public class ArrayDecleration : AstNode
{
    public TypeNode TypeNode { get; set; }

    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitArrayDeclarationNode(this);
    }
}
