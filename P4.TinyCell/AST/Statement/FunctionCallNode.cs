using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.TinyCell.AST.Statement;
public class FunctionCallNode(string identifier) : AstNode
{
    public string Identifier { get; set; } = identifier;

}
