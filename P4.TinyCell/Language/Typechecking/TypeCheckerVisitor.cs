using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Antlr4.Runtime.Misc;
using P4.TinyCell.AST;
using P4.TinyCell.AST.Function;

namespace P4.TinyCell.Languages.TinyCell
{
    class TypeCheckerVisitor : AstBuilderVisitor
    {
        private List<Function> fTable;

        private Stack<KeyValuePair> vTable;

        private class Function
        {
            public string? Type { get; set; }
            public string? Id { get; set; }
            public List<string> Parameters = [];
        }


        public override AstNode VisitDocument([NotNull] TinyCellParser.DocumentContext context)
        {

            return base.VisitDocument(context);
        }

        public static void BuildFunctionTable()
        {

        }
    }
}