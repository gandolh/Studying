#compile
aarch64-linux-gnu-as AARCH.asm -o AARCH.o
aarch64-linux-gnu-gcc AARCH.o -o AARCH.elf -nostdlib -static
./AARCH.elf
