using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.TinyCell.AST.Function;
public class ArgumentNode(AstNode identifier) : AstNode
{
    public AstNode Identifier { get; set; } = identifier;
}
