# x86 assembly stack

.global _start
.intel_syntax
.section .text

_start:

#	push 0x0a434241

	mov dword ptr [%esp], 0x0a434241
	mov %eax, 4
	mov %ebx, 1
	mov %ecx, %esp
	mov %edx, 4
	int 0x80
	#exit syscall
	mov %eax, 1
	mov %ebx, 65
	int 0x80

.section .data
	message:

