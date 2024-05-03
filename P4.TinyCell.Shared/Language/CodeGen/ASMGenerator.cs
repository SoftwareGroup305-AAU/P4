using Antlr4.Runtime;

namespace P4.TinyCell.Shared.Language.CodeGen;

public class ASMGenerator
{
    private int labelCount = 0;
    private int ifLabelCount = 0;
    private int WhileLabelCount = 0;
    /// <summary>
    /// A dictonary to keep track of digital and analog pins
    /// </summary>
    /// <returns>true if digital, false if analog</returns>
    Dictionary<string, bool> IsDigitalPinMap = new Dictionary<string, bool>();

    public ASMGenerator()
    {
        Console.WriteLine("CODEGEN GO NYOOOM");
    }

    private List<IToken> UnParsedTokens = new List<IToken>();
    public string GeneratedCode(IList<IToken> tokens)
    {
        string GeneratedText = "";
        UnParsedTokens.AddRange(tokens);
        while (UnParsedTokens.Count != 0)
        {
            switch (UnParsedTokens[0].Text)
            {
                case "if":
                    GeneratedText = GeneratedText + IfAsm();
                    UnParsedTokens.RemoveAt(0);
                    break;
                case "while":
                    UnParsedTokens.RemoveAt(0);
                    break;
                case "for":
                    UnParsedTokens.RemoveAt(0);
                    break;
                case "pin":
                    //GeneratedText = GeneratedText + PinArduino(UnParsedTokens[2].Text, UnParsedTokens[6].Text);
                    UnParsedTokens.RemoveRange(0, 6);
                    break;
                case "write":
                    //GeneratedText = GeneratedText + WritePin(UnParsedTokens[6].Text, UnParsedTokens[2].Text);
                    UnParsedTokens.RemoveRange(0, 6);
                    break;
                case "read":
                    //GeneratedText = GeneratedText + ReadPin(UnParsedTokens[2].Text, UnParsedTokens[6].Text);
                    UnParsedTokens.RemoveRange(0, 6);
                    break;
                case "set":
                    //GeneratedText = GeneratedText +
                    //               PinMode(UnParsedTokens[2].Text, UnParsedTokens[6].Text);
                    UnParsedTokens.RemoveRange(0, 6);
                    break;
                case "setup":
                    GeneratedText = GeneratedText + "void setup()\n{\n";
                    UnParsedTokens.RemoveAt(0);
                    break;
                case "printf":
                    //GeneratedText = GeneratedText + ConsoleArduino(UnParsedTokens[2].Text);
                    UnParsedTokens.RemoveRange(0, 1);
                    break;
                case "}":
                    GeneratedText = GeneratedText + "\n}\n";
                    UnParsedTokens.RemoveAt(0);
                    break;
                case "update":
                    GeneratedText = GeneratedText + "void loop()\n{\n";
                    UnParsedTokens.RemoveAt(0);
                    break;
                default:
                    //GeneratedText = GeneratedText + UnParsedTokens[0].Text;
                    UnParsedTokens.RemoveAt(0);
                    break;

            }

        }
        return GeneratedText;
    }

    /// <summary>
    /// <c>AdditionASM</c> converts an addition operation to their ARM equivalant.
    /// </summary>
    /// <remarks>Currently uses hardcoded registers</remarks>
    /// <returns>a string representation of the comparison</returns>
    public string AdditionAsm()
    {
        return "ADD{S} R0, R1, R2 \n R15{R0}";
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
            case "==":
                return "bne.n";
            case "!=":
                return "beq.n";
            case "<":
                return "bge.n";
            case ">":
                return "ble.n";
            case "<=":
                return "bgt.n";
            case ">=":
                return "blt.n,";
            case "&&":
                string label = ".LBL_" + labelCount;//Generate a label
                labelCount = labelCount + 1;
                return label;
            case "||":
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
        string finalComp = $"cmp {varOne}, {varTwo}\n{OperatorAsm(compType)}";
        return finalComp;

    }

    /// <summary>
    /// <c>ifASM</c> generates an if statement in ARM.
    /// </summary>
    /// <returns>initialises the if statement</returns>
    /// <remarks>Not done. Requires liveness analysis to be done, should also take in a register</remarks>
    public string IfAsm()
    {
        string label1, label2;
        string comparison = setupCompare("", "", "");
        return comparison; //+ $"{label1}\n bl {label2]}";
    }

    public string WhileAsm()
    {
        string loopLabel = ".LBLWhile_" + WhileLabelCount;

        WhileLabelCount = WhileLabelCount + 1;
        return "b " + loopLabel + "\n" + loopLabel + ":\n" + IfAsm() + "OperatorAsm";
        // b       .LBB0_15 //jump to loop
        //        .LBB0_15: //loop label
        // ldr     r0, [sp, #4]
        // ldr     r1, [sp]
        // cmp     r0, r1 //compare i and p
        // bge     .LBB0_17 //jump out of loop
        // b       .LBB0_16
        //        .LBB0_16:
        // ldr     r0, .LCPI0_5 //print
        //        .LPC0_5:
        // add     r0, pc, r0
        // bl      printf
        // ldr     r0, [sp, #4] //increment i
        // add     r0, r0, #1 //increment i
        // str     r0, [sp, #4] //increment i
        // b       .LBB0_15
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