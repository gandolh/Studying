from tkinter import *
from tkinter import messagebox

root = Tk()
root.iconbitmap('notepadplusplus.ico')

def showinfo(title, message):
    # alternatives: showinfo, showwarning, showerror, askquestion,
    # askokcancel, askyesno
    # messagebox.showinfo(title, message)
    response = messagebox.askyesno(title, message)
    if response == 1:
        Label(root, text="You clicked yes").pack()
    else:
        Label(root, text="You clicked no").pack()

Button(root, text="showinfo",
        command=lambda: showinfo("showinfo", "showinfo message")).pack()

root.mainloop()