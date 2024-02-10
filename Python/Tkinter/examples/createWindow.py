from tkinter import *

root = Tk()
root.iconbitmap('notepadplusplus.ico')
lbl2 = Label(root, text="root Hello")
lbl2.pack()
top = None

def open():
    global top
    top = Toplevel()
    top.title('top window')
    btn1 = Button(top, text="Close", command=close)
    lbl1 = Label(top, text="top Hello")
    lbl1.pack()
    btn1.pack()

def close():
    global top
    if top:
        top.destroy()

btn2 = Button(root, text="Open", command=open)

btn2.pack()

root.mainloop()