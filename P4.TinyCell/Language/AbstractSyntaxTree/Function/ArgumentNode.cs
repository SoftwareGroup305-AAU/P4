using P4.TinyCell.AST.Primitive;

namespace P4.TinyCell.AST.Function;
public class ArgumentNode : AstNode
{
    public IdentifierNode? Identifier { get; set; }
    public FunctionCallNode? FunctionCall { get; set; }
    public AstNode? Numeral { get; set; }
    public StringNode? String { get; set; }
    public BoolNode? Bool { get; set; }

    public ArgumentNode(IdentifierNode identifier)
    {
        Identifier = identifier;
        AddChild(Identifier);
    }

    public ArgumentNode(FunctionCallNode functionCall)
    {
        FunctionCall = functionCall;
        AddChild(FunctionCall);
    }
    
    public ArgumentNode(StringNode stringNode)
    {
        String = stringNode;
        AddChild(String);
    }

    public ArgumentNode(AstNode numeral)
    {
        Numeral = numeral;
        AddChild(Numeral);
    }
}
