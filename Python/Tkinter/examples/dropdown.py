from tkinter import *

root = Tk()
root.iconbitmap('notepadplusplus.ico')
root.geometry("400x400")

clicked = StringVar()

options = ["Select", "Python", "Java", "C++", "C#"]
clicked.set(options[0])
drop = OptionMenu(root, clicked, *options)
drop.pack()


def show():
    myLabel = Label(root, text=clicked.get())
    myLabel.pack()

myButton = Button(root, text="Show selection", command=show).pack()


root.mainloop()