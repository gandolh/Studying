from tkinter import *


root = Tk()
root.title("Simple Calculator")

e = Entry(root, width=35, borderwidth=5)
e.grid(row=0, column=0, columnspan=3, padx=10, pady=10)
f_num = 0
operation = '='


def button_click(number):
    current = e.get()
    e.delete(0, END)
    e.insert(0, str(current) + str(number))


def button_clear():
    e.delete(0, END)


def button_add():
    saveNumber()
    global operation
    operation = '+'
    e.delete(0, END)


def button_substract():
    saveNumber()
    global operation
    operation = '-'
    e.delete(0, END)


def button_divide():
    saveNumber()
    global operation
    operation = '/'
    e.delete(0, END)


def button_multiply():
    saveNumber()
    global operation
    operation = '*'
    e.delete(0, END)


def button_equal():
    second_number = e.get()
    e.delete(0, END)
    result = 0
    print(operation)
    if operation == '+':
        result = f_num + int(second_number)
    elif operation == '-':
        result = f_num - int(second_number)
    elif operation == '*':
        result = f_num * int(second_number)
    elif operation == '/':
        result = f_num / int(second_number)
    e.insert(0, str(result))


def saveNumber():
    first_number = e.get()
    global f_num
    f_num = int(first_number)


for i in range(3):
    for j in range(3):
        number = i*3+j+1
        Button(root, text=str(number), padx=40,
               pady=20, command=lambda num=number: button_click(num)).grid(row=i+1, column=j)

Button(root, text='+', padx=40,
       pady=20, command=button_add).grid(row=1, column=3)
Button(root, text='-', padx=40,
       pady=20, command=button_substract).grid(row=2, column=3)
Button(root, text='/', padx=40, pady=20, command=button_divide
       ).grid(row=3, column=3)
Button(root, text='=', padx=40,
       pady=20, command=button_equal).grid(row=4, column=3)

Button(root, text='0', padx=40,
       pady=20, command=button_click).grid(row=4, column=0)
Button(root, text='Clear', padx=79,
       pady=20, command=button_clear).grid(row=4, column=1, columnspan=2)

root.mainloop()
