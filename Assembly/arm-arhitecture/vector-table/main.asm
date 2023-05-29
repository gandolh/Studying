.section .vectors
sp:
    .word 0x0
reset:
    .word main+1  @ to be in thumb mode

.section .text
.thumb
main:
    b main