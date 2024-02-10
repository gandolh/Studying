from tkinter import *


root = Tk()
root.iconbitmap('notepadplusplus.ico')
root.geometry("400x400")

# var = IntVar()
# c = Checkbutton(root, text="Check this box", variable=var)
# c.pack()

var = StringVar()
c = Checkbutton(root, text="Check this box",
                variable=var, onvalue="on", offvalue="off")
c.deselect()
c.pack()

def show():
    myLabel = Label(root, text=var.get())
    myLabel.pack()

myButton = Button(root, text="Show selection", command=show).pack()

root.mainloop()