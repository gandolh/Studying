mips-linux-gnu-as mips.asm  -o mips.o
mips-linux-gnu-gcc mips.o -o mips -nostdlib -static
qemu-mips ./mips