using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.TinyCell.AST;

public abstract class NumericExprNode : AstNode
{
    public NumericExprNode(AstNode left, AstNode right)
    {
        ArgumentNullException.ThrowIfNull(left);
        ArgumentNullException.ThrowIfNull(right);

        Children.Add(left);
        Children.Add(right);
    }
}
