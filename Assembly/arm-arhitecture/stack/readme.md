arm-none-eabi-as -o stack.o stack.asm
arm-none-eabi-gcc -o stack.elf stack.o -nostdlib -static
./stack.elf