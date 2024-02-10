from tkinter import *
from tkinter import filedialog


root = Tk()
root.title('file dialog')
root.iconbitmap('notepadplusplus.ico')



def open():
    root.filename = filedialog.askopenfilename(
    initialdir="/",
      title="Select a file",
        filetypes=(("txt files", "*.txt"),
                    ("all files", "*.*")))
    lbl = Label(root, text=root.filename)
    lbl.pack()
button = Button(root, text="Enter file", command=open).pack()
root.mainloop()