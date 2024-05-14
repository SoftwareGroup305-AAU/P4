.section .text
.global main

.equ RCCAHBENR, 0x40000800

main:
    push {r4, lr}
    
    bl setup
    
    b loop

setup:
    bx lr

loop:
    bl loop                

.extern SystemInit

SystemInit:
    bx lr