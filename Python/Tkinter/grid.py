from tkinter import *


root = Tk()

# Creating Widgets
myLabel1 = Label(root, text="Hello World!")
myLabel2 = Label(root, text="My name is who?")
myLabel3 = Label(root, text="My name is what?")

# Showing it onto the screen
myLabel1.grid(row=0, column=1)
myLabel2.grid(row=1, column=0)
myLabel3.grid(row=1, column=2)



root.mainloop()

