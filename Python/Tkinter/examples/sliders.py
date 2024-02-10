from tkinter import *


root = Tk()
root.title('file dialog')
root.iconbitmap('notepadplusplus.ico')
root.geometry("400x400")
vertical = Scale(root, from_=200, to=0)
vertical.pack()

my_label = Label(root, text = "0")


def change_label(val):
    global my_label
    my_label.pack_forget() 
    my_label = Label(root, text =horizontal.get())
    my_label.pack()


def slide():
    root.geometry(str(horizontal.get()) + "x400")


horizontal = Scale(root, from_=0, to=400, orient=HORIZONTAL, command=change_label)
horizontal.pack()

my_button = Button(root, text="Click Me", command=slide)
my_button.pack()

root.mainloop()