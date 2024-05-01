using P4.TinyCell.Language.AbstractSyntaxTree.Primitive;

namespace P4.TinyCell.Language.AbstractSyntaxTree.Assignment;
public class MinusAssignNode(IdentifierNode identifier, AstNode expression) : AssignmentBaseNode(identifier, expression)
{
}
