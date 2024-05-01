using P4.TinyCell.Language.AbstractSyntaxTree.Primitive;

namespace P4.TinyCell.Language.AbstractSyntaxTree.Assignment;
public class PlusAssignNode(IdentifierNode identifier, AstNode expression) : AssignmentBaseNode(identifier, expression)
{
}
