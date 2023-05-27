default:
	aarch64-linux-gnu-as functions.asm -o functions.o
	aarch64-linux-gnu-gcc functions.o -o functions.elf -nostdlib -static
	./functions.elf
