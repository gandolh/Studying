# steps to work
- build solution: make
- insert ldd into kernel: sudo insmod ldd.ko
- watch logs: sudo dmesg -c
- check if module loaded: lsmod
- check module info: modinfo ldd.ko
- remove inserted ldd: sudo rmmod ldd.ko
- clean solution: make clean


# TODO: 
proc_write example so it write in a global buffer in driver.