from tkinter import *

root = Tk()
root.title('frames')
root.iconbitmap('notepadplusplus.ico')
r = IntVar()

Modes = [
    ("Option 1", "Option 1"),
    ("Option 2", "Option 2"),
    ("Option 3", "Option 3"),
    ("Option 4", "Option 4")
]

SelectedOption = StringVar()
SelectedOption.set("Option 1")

def radio_changed():
    global myLabel
    myLabel.pack_forget()
    # myLabel = Label(root, text=r.get())
    myLabel = Label(root, text=SelectedOption.get())
    myLabel.pack()


for text, mode in Modes:
    Radiobutton(root, text=text, variable=SelectedOption,
                 value=mode, command=radio_changed).pack()


# Radiobutton(root, text="Option 1", value=1, variable=r, command=radio_changed).pack()
# Radiobutton(root, text="Option 2", value=2, variable=r, command=radio_changed).pack()


myLabel = Label(root, text=r.get())
myLabel.pack()

myButton = Button(root, text="confirm", command=radio_changed)
myButton.pack()
root.mainloop()