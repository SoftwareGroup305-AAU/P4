using P4.TinyCell.AST.Primitive;

namespace P4.TinyCell.AST.Assignment;
public class ModAssignNode(IdentifierNode identifier, AstNode expression) : AssignmentBaseNode(identifier, expression)
{
}
