# AARCH64 Assembly

.global _start
.section .text

_start:
	mov x15, #15

loop:
	cmp x15, #0
	beq exit

	#write system call
	mov x8, #64
	mov x0, #1
	ldr x1, =message
	mov x2, #13
	svc 0
	sub x15, x15, #1
	b loop
exit:
	# exit system call
	mov x8, #0x5d
	mov x0, #0x41
	svc 0

.section .data
	message:
	.ascii "Hello, world\n"
