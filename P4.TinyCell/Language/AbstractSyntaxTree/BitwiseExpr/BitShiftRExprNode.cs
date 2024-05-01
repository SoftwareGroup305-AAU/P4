using P4.TinyCell.Language.AbstractSyntaxTree.NumExpr;

namespace P4.TinyCell.Language.AbstractSyntaxTree.BitwiseExpr;

public class BitshiftRExprNode(AstNode left, AstNode right) : BinExprNode(left, right)
{
}
