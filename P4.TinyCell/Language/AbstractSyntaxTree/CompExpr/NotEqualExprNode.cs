﻿using P4.TinyCell.Language.AbstractSyntaxTree.NumExpr;

namespace P4.TinyCell.Language.AbstractSyntaxTree.CompExpr;

public class NotEqualExprNode(AstNode left, AstNode right) : BinExprNode(left, right)
{
}
