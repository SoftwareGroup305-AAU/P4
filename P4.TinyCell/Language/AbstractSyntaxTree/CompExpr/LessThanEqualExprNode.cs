﻿using P4.TinyCell.Language.AbstractSyntaxTree.NumExpr;

namespace P4.TinyCell.Language.AbstractSyntaxTree.CompExpr;

public class LessThanEqualExprNode(AstNode left, AstNode right) : BinExprNode(left, right)
{
    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitLessThanEqualExprNode(this);
    }
}
