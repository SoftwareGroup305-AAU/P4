namespace P4.TinyCell.Language.AbstractSyntaxTree.Function;
public class FunctionDefinitionNode : AstNode
{
    public AstNode Type { get; set; }
    public AstNode Identifier { get; set; }
    public AstNode ParameterList { get; set; }
    public AstNode CompoundStatement { get; set; }
    public FunctionDefinitionNode(AstNode type, AstNode identifier, AstNode parameterList, AstNode compoundStatement)
    {
        Type = type;
        Identifier = identifier;
        ParameterList = parameterList;
        CompoundStatement = compoundStatement;

        AddChild(type);
        AddChild(identifier);
        AddChild(parameterList);
        AddChild(compoundStatement);
    }
}
