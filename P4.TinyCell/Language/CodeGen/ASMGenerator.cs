using System.Net.Quic;
using System.Numerics;
using Antlr4.Runtime;
using P4.TinyCell.Language.AbstractSyntaxTree;
using P4.TinyCell.Language.AbstractSyntaxTree.Expression;
using P4.TinyCell.Language.AbstractSyntaxTree.Primitive;

namespace P4.TinyCell.Languages.TinyCell.CodeGen;

public class ASMGenerator
{
       private int labelCount = 0;
       private int ifLabelCount = 0;
       private int WhileLabelCount = 0;
       private int ForLabelCount = 0;
       private int DivLabelCount = 0;
       private int ModLabelCount = 0;
       /// <summary>
       /// A dictonary to keep track of digital and analog pins
       /// </summary>
       /// <returns>true if digital, false if analog</returns>
       Dictionary<string, bool> IsDigitalPinMap = new Dictionary<string, bool>();
       private string CurrentFunction = "";
       public ASMGenerator()
       {
              Console.WriteLine("Running code generation");
       }

       //private AstNode UnParsedTokens = AstNode();
       private Dictionary<string, Dictionary<string, string>> RegisterDictionary = null;

       public string RegisterLookup(string variable)
       {
              return RegisterDictionary[CurrentFunction][variable];
       }
       public string GenerateCode(AstNode tokens, Dictionary<string, Dictionary<string, string>> Registers)
       {
              string GeneratedText = "";
              RegisterDictionary = Registers;
              //UnParsedTokens.AddRange(tokens);

              // Console.WriteLine(tokens.GetChild(1));
              // if (tokens.GetChild(1) is DeclarationNode)
              // {
              //        Console.WriteLine(((IdentifierNode)tokens.GetChild(0).GetChild(0)).Value);
              // }
              //
              // while (UnParsedTokens.Count != 0)
              // {
              //     switch (UnParsedTokens[0].Text)
              //     {
              //         case IfStatementNode:
              //             GeneratedText = GeneratedText + IfAsm();
              //             break;
              //         case WhileStatementNode:
              //
              //             break;
              //         case ForStatementNode:
              //
              //             break;
              //         case DeclarationNode:
              //             //GeneratedText = GeneratedText + Declaration(((IdentifierNode)tokens.GetChild(0).GetChild(1).Value);
              //             break;
              //         case PinWriteExprNode:
              //             //GeneratedText = GeneratedText + WritePin(UnParsedTokens[6].Text, UnParsedTokens[2].Text);
              //             break;
              //         case PinReadExprNode:
              //             //GeneratedText = GeneratedText + ReadPin(UnParsedTokens[2].Text, UnParsedTokens[6].Text);
              //             break;
              //         case PinModeExprNode:
              //             //GeneratedText = GeneratedText +
              //              //               PinMode(UnParsedTokens[2].Text, UnParsedTokens[6].Text);
              //             break;
              //         case FunctionDefinitionNode:
              //             GeneratedText = GeneratedText + "void setup()\n{\n";
              //             break;
              //         case "printf":
              //             //GeneratedText = GeneratedText + ConsoleArduino(UnParsedTokens[2].Text);
              //             break;
              //         default:
              //             //GeneratedText = GeneratedText + UnParsedTokens[0].Text;
              //             Console.WriteLine("OOOO:");
              //             break;
              //
              //     }
              //
              // }
              return ""; //GeneratedText;
       }
       public string DoDecleration(AstNode FinalDeclarationType, string x, string y)
       {
              string FinalDeclaration = "";

              // switch (FinalDeclarationType)
              // {
              //        case (PinNode):
              //               FinalDeclaration = "const int";
              //               break;
              //        case (BoolNode):
              //               FinalDeclaration = "bool";
              //               break;
              //        case (FloatNode):
              //               FinalDeclaration = "float";
              //               break;
              //        case (IntNode):
              //               FinalDeclaration = "int";
              //               break;
              //        case (StringNode):
              //               FinalDeclaration = "string";
              //               break;
              //        case (VoidNode):
              //               FinalDeclaration = "void";
              //               break;
              // }

              FinalDeclaration = $"{FinalDeclaration} {x} =  {y};";
              return FinalDeclaration;
       }
       /// <summary>
       /// <c>AdditionASM</c> converts an addition operation to their ARM equivalant.
       /// </summary>
       /// <param name="addTo">Result register</param>
       /// <param name="variable">First source</param>
       /// <param name="addVariable">Second source</param>
       /// <returns>ARM instruction for addition</returns>
       public string AdditionAsm(string addTo, string variable, string addVariable)
       {
              return $"ADD {RegisterLookup(addTo)}, {RegisterLookup(variable)}, {RegisterLookup(addVariable)}\n";
       }

       /// <summary>
       /// <c>SubtractAsm</c> converts an subtraction operation to their ARM equivalant.
       /// </summary>
       /// <param name="addTo">Result register</param>
       /// <param name="variable">First source</param>
       /// <param name="addVariable">Second source</param>
       /// <returns>ARM instruction for subtraction</returns>
       public string SubtractAsm(string addTo, string variable, string addVariable)
       {
              return $"SUB {RegisterLookup(addTo)}, {RegisterLookup(variable)}, {RegisterLookup(addVariable)}\n";
       }

       /// <summary>
       /// <c>MultiplyAsm</c> converts a multiplication operation to their ARM equivalant.
       /// </summary>
       /// <param name="addTo">Result register</param>
       /// <param name="variable">First source</param>
       /// <param name="addVariable">Second source</param>
       /// <returns>ARM instruction for multiplication</returns>
       public string MultiplyAsm(string addTo, string variable, string addVariable)
       {
              return $"MULS {RegisterLookup(addTo)}, {RegisterLookup(variable)}, {RegisterLookup(addVariable)}\n";
       }

       /// <summary>
       /// <c>DivideAsm<\c> converts a division operation to an ARM equivalent algorithm
       /// </summary>
       /// <param name="addTo">Result register</param>
       /// <param name="variable">First source</param>
       /// <param name="addVariable">Second source</param>
       /// <returns>ARM instruction for division algorithm</returns>
       public string DivideAsm(string addTo, string variable, string addVariable)
       {
              string loopStart = ".LBLDiv_" + DivLabelCount;
              string loopCode = ".LBLDiv_" + DivLabelCount + ".1";
              string loopEnd = ".LBLDiv_" + DivLabelCount + ".2";
              string quotient = RegisterLookup(addTo);
              string remainder = RegisterLookup(variable);
              string loopAction1 = AdditionAsm(quotient, quotient, "#1");
              string loopAction2 = SubtractAsm(remainder, remainder, addVariable);
              DivLabelCount = DivLabelCount + 1;
              return $"b {loopStart}\n" + //Go to loop label
                     $"{loopCode}:\n" +//Declare loop code
                     $"{loopAction1}\n" + //Declare increment of quotient 
                     $"{loopAction2}\n" + //Declare decrement of dividend
                     $"{loopStart}:\n //" +//Declare loop label 
                     $"{IfAsm(">=", remainder, addVariable, loopCode, loopEnd)}\n" +
                     $"{loopEnd}:";//Declare end of loop
       }

       /// <summary>
       /// <c>ModuloAsm<\c> converts a modulo operation to an ARM equivalent algorithm
       /// </summary>
       /// <param name="addTo">Result register</param>
       /// <param name="variable">First source</param>
       /// <param name="addVariable">Second source</param>
       /// <returns>ARM instruction for modulo algorithm</returns>
       public string ModuloAsm(string addTo, string variable, string addVariable)
       {
              string loopStart = ".LBLMod_" + ModLabelCount;
              string loopCode = ".LBLMod_" + ModLabelCount + ".1";
              string loopEnd = ".LBLMod_" + ModLabelCount + ".2";
              string zeroCheckSet = ".LBLMod_" + ModLabelCount + ".3";
              string zeroCheckEnd = ".LBLMod_" + ModLabelCount + ".4";
              string remainder = RegisterLookup(variable);
              string loopAction = SubtractAsm(remainder, remainder, addVariable);
              ModLabelCount = ModLabelCount + 1;
              return $"b {loopStart}\n" + //Go to loop label
                     $"{loopCode}:\n" +//Declare loop code
                     $"{loopAction}\n" + //Declare decrement of dividend
                     $"{loopStart}:\n //" +//Declare loop label 
                     $"{IfAsm(">=", remainder, addVariable, loopCode, loopEnd)}\n" +
                     $"{loopEnd}\n" + //Declare end of loop
                     $"{IfAsm("<", remainder, "#0", zeroCheckSet, zeroCheckEnd)}\n" +
                     $"{zeroCheckSet}:\n" + //Declare zero check label
                     $"MOV {remainder}, #0\n" + //Set correct remainder value
                     $"{zeroCheckEnd}:\n" + //Declare exit label
                     $"MOV {addTo}, {remainder}\n"; //Move remainder to result register
       }

       /// <summary>
       /// <c>OperatorASM</c> converts operators to their ARM equivalant.
       /// </summary>
       /// <returns>a string representation of the comparison</returns>
       /// <remarks>THIS MIGHT BE WRONG DO NOT USE</remarks>
       public string OperatorAsm(string operatorASM)
       {
              switch (operatorASM)
              {
                     case ("=="):
                            return "bne.n";
                     case ("!="):
                            return "beq.n";
                     case ("<"):
                            return "bge.n";
                     case (">"):
                            return "ble.n";
                     case ("<="):
                            return "bgt.n";
                     case (">="):
                            return "blt.n,";
                     case ("&&")://Fix this one
                            string label = ".LBL_" + labelCount;//Generate a label
                            labelCount = labelCount + 1;
                            return label;
                     case ("||")://Fix this one
                            string label1 = ".LBL_" + labelCount;//Generate a label
                            labelCount = labelCount + 1;
                            string label2 = ".LBL_" + labelCount;//Generate a label
                            labelCount = labelCount + 1;
                            return "bne " + label1 + "\n" + "b " + label2 + "\n";
              }

              return "";
       }

       public string setupCompare(string compType, string varOne, string varTwo)
       {
              //remember to:
              //" ldr     r0, [sp, #4]"
              //" ldr     r1, [sp]"
              string finalComp = $"cmp {RegisterLookup(varOne)}, {RegisterLookup(varTwo)}\n{OperatorAsm(compType)}";
              return finalComp;

       }

       /// <summary>
       /// <c>ifAsm</c> generates an if statement in ARM.
       /// </summary>
       /// <returns>initialises the if statement</returns>
       /// <remarks>Not done. Requires liveness analysis to be done, should also take in a register</remarks>
       public string IfAsm(string ComparisonOperator, string leftHand, string rightHand, string? trueLabel = null, string? falseLabel = null)
       {
              string label1, label2;
              string comparison = setupCompare(ComparisonOperator, leftHand, rightHand);
              label1 = trueLabel ?? $"{ifLabelCount}";
              label2 = falseLabel ?? $"{ifLabelCount}.1"; //label2 = falseLabel if notNull, else ifLabelCount.1

              ifLabelCount += 1;
              return comparison + $"{label1}\n bl {label2}";
       }

       public string WhileAsm()
       {
              string loopStart = ".LBLWhile_" + WhileLabelCount;
              string loopCode = ".LBLWhile_" + WhileLabelCount + ".1";
              string loopEnd = ".LBLWhile_" + WhileLabelCount + ".2";
              string loopAction = AuxiliaryCodeGen(null);//This should NOT be null, Pass tokens
              WhileLabelCount = WhileLabelCount + 1;
              return $"b {loopStart}\n" + //Go to loop label
                     $"{loopStart}:\n //" +//Declare loop label 
                     $"{IfAsm("", "", "", loopCode, loopEnd)}\n" +
                     $"{loopCode}\n" +//Declare loop code
                     $"{loopAction}\n" + //Declare code to execute  (Remember the action that can help the code end like incrementing i if the condition is i < 10) 
                     $"{loopStart}" +
                     $"{loopEnd}";//Define end of loop
       }

       public string FroreAsm()
       {
              string loopStart = ".LBLFor_" + ForLabelCount;
              string loopCode = ".LBLFor_" + ForLabelCount + ".1";
              string loopEnd = ".LBLFor_" + ForLabelCount + ".2";
              string loopAction = AuxiliaryCodeGen(null);//This should NOT be null, Pass tokens
              WhileLabelCount = WhileLabelCount + 1;
              return $"b {loopStart}\n" + //Go to loop label
                     $"{loopStart}:\n //" +//Declare loop label 
                     $"{ForLabelCount}\n" +//Switch out with variable init
                     $"{IfAsm("", "", "", loopCode, loopEnd)}\n" +
                     $"{loopCode}\n" +//Declare loop code
                     $"{loopAction}\n" + //Declare code to execute  (Remember the action that can help the code end like incrementing i if the condition is i < 10) 
                     $"{loopStart}" +
                     $"{loopEnd}";//Define end of loop
       }

       public string AuxiliaryCodeGen(AstNode tokens)
       {
              // while (UnParsedTokens.Count != 0)
              // {
              //     switch (UnParsedTokens[0].Text)
              //     {
              //         case IfStatementNode:
              //             GeneratedText = GeneratedText + IfAsm();
              //             break;
              //         case WhileStatementNode:
              //
              //             break;
              //         case ForStatementNode:
              //
              //             break;
              //         case DeclarationNode:
              //             //GeneratedText = GeneratedText + Declaration(((IdentifierNode)tokens.GetChild(0).GetChild(1).Value);
              //             break;
              //         case PinWriteExprNode:
              //             //GeneratedText = GeneratedText + WritePin(UnParsedTokens[6].Text, UnParsedTokens[2].Text);
              //             break;
              //         case PinReadExprNode:
              //             //GeneratedText = GeneratedText + ReadPin(UnParsedTokens[2].Text, UnParsedTokens[6].Text);
              //             break;
              //         case PinModeExprNode:
              //             //GeneratedText = GeneratedText +
              //              //               PinMode(UnParsedTokens[2].Text, UnParsedTokens[6].Text);
              //             break;
              //         case FunctionDefinitionNode:
              //             GeneratedText = GeneratedText + "void setup()\n{\n";
              //             break;
              //         case "printf":
              //             //GeneratedText = GeneratedText + ConsoleArduino(UnParsedTokens[2].Text);
              //             break;
              //         default:
              //             //GeneratedText = GeneratedText + UnParsedTokens[0].Text;
              //             Console.WriteLine("OOOO:");
              //             break;
              //
              //     }
              //
              // }
              return ""; //GeneratedText;
       }

}
//  R0-R12	RW	Unknown	General-purpose registers.
//     MSP	RW	See description	Stack Pointer.
//     PSP	RW	Unknown	Stack Pointer.
//     LR	RW	Unknown	Link Register.
//     PC	RW	See description	Program Counter.
//     PSR	RW	Unknown[b]	Program Status Register.
//     APSR	RW	Unknown	Application Program Status Register.
//     IPSR	RO	0x00000000	Interrupt Program Status Register.
//     EPSR	RO	Unknown [b]	Execution Program Status Register.
//     PRIMASK	RW	0x00000000	Priority Mask Register.
//     CONTROL	RW	0x00000000	CONTROL register.


// ADCS	{Rd,} Rn, Rm	Add with Carry	N,Z,C,V	ADC, ADD, RSB, SBC, and SUB
// ADD{S}	{Rd,} Rn, <Rm|#imm>	Add	N,Z,C,V	ADC, ADD, RSB, SBC, and SUB
// ADR	Rd, label	PC-relative Address to Register	-	ADR
// ANDS	{Rd,} Rn, Rm	Bitwise AND	N,Z	ADC, ADD, RSB, SBC, and SUB
// ASRS	{Rd,} Rm, <Rs|#imm>	Arithmetic Shift Right	N,Z,C	ASR, LSL, LSR, and ROR
// B{cc}	label	Branch {conditionally}	-	B, BL, BX, and BLX
// BICS	{Rd,} Rn, Rm	Bit Clear	N,Z	AND, ORR, EOR, and BIC
// BKPT	#imm	Breakpoint	-	BKPT
// BL	label	Branch with Link	-	B, BL, BX, and BLX
// BLX	Rm	Branch indirect with Link	-	B, BL, BX, and BLX
// BX	Rm	Branch indirect	-	B, BL, BX, and BLX
// CMN	Rn, Rm	Compare Negative	N,Z,C,V	CMP and CMN
// CMP	Rn, <Rm|#imm>	Compare	N,Z,C,V	CMP and CMN
// CPSID	i	Change Processor State, Disable Interrupts	-	CPS
// CPSIE	i	Change Processor State, Enable Interrupts	-	CPS
// DMB	-	Data Memory Barrier	-	DMB
// DSB	-	Data Synchronization Barrier	-	DSB
// EORS	{Rd,} Rn, Rm	Exclusive OR	N,Z	AND, ORR, EOR, and BIC
// ISB	-	Instruction Synchronization Barrier	-	ISB
// LDM	Rn{!}, reglist	Load Multiple registers, increment after	-	LDM and STM
// LDR	Rt, label	Load Register from PC-relative address	-	Memory access instructions
// LDR	Rt, [Rn, <Rm|#imm>]	Load Register with word	-	Memory access instructions
// LDRB	Rt, [Rn, <Rm|#imm>]	Load Register with byte	-	Memory access instructions
// LDRH	Rt, [Rn, <Rm|#imm>]	Load Register with halfword	-	Memory access instructions
// LDRSB	Rt, [Rn, <Rm|#imm>]	Load Register with signed byte	-	Memory access instructions
// LDRSH	Rt, [Rn, <Rm|#imm>]	Load Register with signed halfword	-	Memory access instructions
// LSLS	{Rd,} Rn, <Rs|#imm>	Logical Shift Left	N,Z,C	ASR, LSL, LSR, and ROR
// LSRS	{Rd,} Rn, <Rs|#imm>	Logical Shift Right	N,Z,C	ASR, LSL, LSR, and ROR
// MOV{S}	Rd, Rm	Move	N,Z	MOV and MVN
// MRS	Rd, spec_reg	Move to general register from special register	-	MRS
// MSR	spec_reg, Rm	Move to special register from general register	N,Z,C,V	MSR
// MULS	Rd, Rn, Rm	Multiply, 32-bit result	N,Z	MULS
// MVNS	Rd, Rm	Bitwise NOT	N,Z	MOV and MVN
// NOP	-	No Operation	-	NOP
// ORRS	{Rd,} Rn, Rm	Logical OR	N,Z	AND, ORR, EOR, and BIC
// POP	reglist	Pop registers from stack	-	PUSH and POP
// PUSH	reglist	Push registers onto stack	-	PUSH and POP
// REV	Rd, Rm	Byte-Reverse word	-	REV, REV16, and REVSH
// REV16	Rd, Rm	Byte-Reverse packed halfwords	-	REV, REV16, and REVSH
// REVSH	Rd, Rm	Byte-Reverse signed halfword	-	REV, REV16, and REVSH
// RORS	{Rd,} Rn, Rs	Rotate Right	N,Z,C	ASR, LSL, LSR, and ROR
// RSBS	{Rd,} Rn, #0	Reverse Subtract	N,Z,C,V	ADC, ADD, RSB, SBC, and SUB
// SBCS	{Rd,} Rn, Rm	Subtract with Carry	N,Z,C,V	ADC, ADD, RSB, SBC, and SUB
// SEV	-	Send Event	-	SEV
// STM	Rn!, reglist	Store Multiple registers, increment after	-	LDM and STM
// STR	Rt, [Rn, <Rm|#imm>]	Store Register as word	-	Memory access instructions
// STRB	Rt, [Rn, <Rm|#imm>]	Store Register as byte	-	Memory access instructions
// STRH	Rt, [Rn, <Rm|#imm>]	Store Register as halfword	-	Memory access instructions
// SUB{S}	{Rd,} Rn, <Rm|#imm>	Subtract	N,Z,C,V	ADC, ADD, RSB, SBC, and SUB
// SVC	#imm	Supervisor Call	-	SVC
// SXTB	Rd, Rm	Sign extend byte	-	SXT and UXT
// SXTH	Rd, Rm	Sign extend halfword	-	SXT and UXT
// TST	Rn, Rm	Logical AND based test	N,Z	TST
// UXTB	Rd, Rm	Zero extend a byte	-	SXT and UXT
// UXTH	Rd, Rm	Zero extend a halfword	-	SXT and UXT
// WFE	-	Wait For Event	-	WFE

// WFI	-	Wait For Interrupt	-	WFI