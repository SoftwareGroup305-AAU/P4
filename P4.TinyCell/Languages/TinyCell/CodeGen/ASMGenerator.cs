using System.Numerics;

namespace P4.TinyCell.Languages.TinyCell.CodeGen;

public class ASMGenerator
{
       /// <summary>
       /// <c>AdditionASM</c> converts an addition operation to their ARM equivalant.
       /// </summary>
       /// <remarks>Currently uses hardcoded registers</remarks>
       /// <returns>a string representation of the comparison</returns>
       public string AdditionASM()
       {
              return "ADD{S} R0, R1, R2 \n R15{R0}";
       }
       /// <summary>
       /// <c>OperatorASM</c> converts operators to their ARM equivalant.
       /// </summary>
       /// <returns>a string representation of the comparison</returns>
       public string OperatorASM(String operatorASM)
       {
              switch (operatorASM)
              {
                     case("=="):
                            return "EQ";
                     case("!="):
                            return "NE";
                     case("<"):
                            return "LT";
                     case(">"):
                            return "GT";
                     case("<="):
                            return "LE";
                     case(">="):
                            return "GE";
                     case("&&"):
                            return ""
                            
              }

              return "";
       }

       public string ifASM()
       {
              return "";
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