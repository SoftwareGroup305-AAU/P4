using P4.TinyCell.Shared.Language.AbstractSyntaxTree;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree.Expression;

namespace CodeGen
{
    public class ASMGenVisitor : AstBaseVisitor<string>
    {
        private int labelCount = 0;
       private int ifLabelCount = 0;
       private int WhileLabelCount = 0;
       private int ForLabelCount = 0;
       /// <summary>
       /// A dictonary to keep track of digital and analog pins
       /// </summary>
       /// <returns>true if digital, false if analog</returns>
       Dictionary<string, bool> IsDigitalPinMap = new Dictionary<string, bool>();
       private string CurrentFunction = "";
        public override string VisitRootNode(RootNode rootNode)
        {
            return base.VisitRootNode(rootNode);
        }

        public override string VisitDeclarationNode(DeclarationNode declarationNode)
        {
            
            return base.VisitDeclarationNode(declarationNode);
        }




    }
}