using P4.TinyCell.Language.AbstractSyntaxTree.Primitive;

namespace P4.TinyCell.Language.AbstractSyntaxTree.Assignment;
public class ModAssignNode(IdentifierNode identifier, AstNode expression) : AssignmentBaseNode(identifier, expression)
{
}
