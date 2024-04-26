using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.TinyCell.AST;
public class ParameterListNode(List<AstNode> parameters) : AstNode
{
    public List<AstNode> Parameters { get; } = parameters;
}
