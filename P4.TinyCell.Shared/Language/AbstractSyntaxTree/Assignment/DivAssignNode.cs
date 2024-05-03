﻿using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Primitive;

namespace P4.TinyCell.Shared.Language.AbstractSyntaxTree.Assignment;
public class DivAssignNode(IdentifierNode identifier, AstNode expression) : AssignmentBaseNode(identifier, expression)
{
    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitDivAssignNode(this);
    }
}
