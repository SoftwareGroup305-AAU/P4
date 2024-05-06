.section .text
.global main

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