using P4.TinyCell.Language.AbstractSyntaxTree.NumExpr;

namespace P4.TinyCell.Language.AbstractSyntaxTree.BitwiseExpr;

public class BitshiftLExprNode(AstNode left, AstNode right) : BinExprNode(left, right)
{
}
