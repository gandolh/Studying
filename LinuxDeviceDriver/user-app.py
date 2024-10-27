#! /usr/bin/python3
def main():
    driver_handle = open("/proc/pyjama_driver")
    message_from_kernel_space = driver_handle.readline()
    print(message_from_kernel_space)
    return

main()