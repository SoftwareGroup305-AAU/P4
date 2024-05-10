using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Function;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Primitive;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Types;

namespace P4.TinyCell.Shared.Language.AbstractSyntaxTree.Array;
public class ArrayDeclarationNode : AstNode
{
    public TypeNode TypeNode { get; set; }
    public AstNode Size { get; set; }
    public ArrayElementsNode? Elements { get; set; }
    public FunctionCallNode? FunctionCall { get; set; }

    public ArrayDeclarationNode(TypeNode typeNode, AstNode size)
    {
        TypeNode = typeNode;
        Size = size;

        AddChild(TypeNode);
        AddChild(size);
    }

    public ArrayDeclarationNode(TypeNode typeNode, AstNode size, ArrayElementsNode arrayElements)
    {
        TypeNode = typeNode;
        Size = size;
        Elements = arrayElements;
        
        AddChild(TypeNode);
        AddChild(size);
        AddChild(Elements);
    }

    public ArrayDeclarationNode(TypeNode typeNode, AstNode size, FunctionCallNode functionCall)
    {
        TypeNode = typeNode;
        Size = size;
        FunctionCall = functionCall;

        AddChild(TypeNode);
        AddChild(size);
        AddChild(functionCall);
    }

    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitArrayDeclarationNode(this);
    }
}
