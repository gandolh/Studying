# first you should install:
# libc6-i386 
# commands:
as 001.asm --32 -o 001.o
gcc -o 001.elf -m32 001.o -nostdlib
./001.elf
