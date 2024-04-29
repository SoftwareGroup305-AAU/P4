using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.TinyCell.AST;
public class ParameterListNode : AstNode
{
    public AstNode[] Parameters { get; }

    public ParameterListNode(AstNode[] parameters)
    {
        Parameters = parameters;

        foreach (AstNode parameter in parameters)
        {
            AddChild(parameter);
        }
    }
}
