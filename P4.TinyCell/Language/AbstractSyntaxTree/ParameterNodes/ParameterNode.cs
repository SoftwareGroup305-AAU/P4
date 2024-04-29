using P4.TinyCell.AST.Primitive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.TinyCell.AST;
public class ParameterNode(AstNode type, AstNode identifier) : AstNode
{
    public Type Type { get; set; }
    public IdentifierNode Identifier { get; set; }
}
