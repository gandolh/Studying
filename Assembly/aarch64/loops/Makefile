default:
	aarch64-linux-gnu-as loops.asm -o loops.o
	aarch64-linux-gnu-gcc loops.o -o loops.elf -nostdlib -static
	./loops.elf
