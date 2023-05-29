.global _start

_start:
    mov $0x39, %rax
    syscall
    jmp _start