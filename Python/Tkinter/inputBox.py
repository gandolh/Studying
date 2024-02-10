from tkinter import *


root = Tk()

e = Entry(root, width=50, borderwidth=5)
e.pack()
e.insert(0, "Enter Your Name: ")

def myClick():
    myLabel = Label(root, text="You entered the text: " + e.get())
    myLabel.pack()

# Creating Widgets
myButton = Button(root, text="Click Me!", 
                padx=50, pady=20, command=myClick,
                fg="white", bg="#0d6efd")

# Showing it onto the screen
myButton.pack()

root.mainloop()

