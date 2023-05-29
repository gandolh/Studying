#to compile and run the .asm file, you can run those comands:
# compile asm
arm-linux-gnueabi-as arm.asm -o arm.o
# make it runnable by machine
arm-linux-gnueabi-gcc arm.o -o arm.elf -nostdlib
#run with qemu
qemu-arm arm.elf
# output
#Hello, World

