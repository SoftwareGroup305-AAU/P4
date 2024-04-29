using P4.TinyCell.AST.Primitive;

namespace P4.TinyCell.AST.Assignment;
public class DivAssignNode(IdentifierNode identifier, AstNode expression) : AssignmentBaseNode(identifier, expression)
{
}
