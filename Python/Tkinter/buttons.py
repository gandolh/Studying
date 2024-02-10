from tkinter import *


root = Tk()

def myClick():
    myLabel = Label(root, text="button clicked!")
    myLabel.pack()

# Creating Widgets
myButton = Button(root, text="Click Me!", 
                padx=50, pady=50, command=myClick,
                fg="white", bg="#0d6efd")

# Showing it onto the screen
myButton.pack()

root.mainloop()

