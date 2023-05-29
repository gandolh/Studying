.global _start
.section .data

_start:
    bl hello_world
    bl exit

hello_world:
    push {r4-r11, lr}
    mov fp, sp
    sub sp, sp, #0x40
    ldr r1, =#0x1337
    str r1, [fp, #-0x10]
    mov r7, #0x4
    mov r0, #1
    ldr r1, =message
    mov r2, #13
    swi 0
    mov sp, fp
    pop {r4-r11, pc}

exit:
    push {fp, lr}
    mov r7, #0x1
    mov r0, #0
    swi 0
    pop {fp, pc}

.section .data
    message:
        .ascii "Hello World!\n"