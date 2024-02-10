from tkinter import *
from PIL import ImageTk, Image


root = Tk()
root.title("image viewer")
root.iconbitmap('Notepadplusplus.ico')
image_number = 0


my_img1 = ImageTk.PhotoImage(Image.open("images/fox1.jpg"))
my_img2 = ImageTk.PhotoImage(Image.open("images/fox2.jpg"))
my_img3 = ImageTk.PhotoImage(Image.open("images/fox3.jpg"))
image_list = [my_img1, my_img2, my_img3]

status = Label(root, text="Image " + str(image_number + 1) + " of "
               + str(len(image_list)), bd=1, relief=SUNKEN,
               anchor=E)


my_label = Label(image=my_img1)
my_label.grid(row=0, column=0, columnspan=3)


def redraw_status():
    global status
    status.grid_forget()
    status = Label(root, text="Image " + str(image_number + 1) + " of "
                   + str(len(image_list)), bd=1, relief=SUNKEN,
                   anchor=E)
    status.grid(row=2, column=0, columnspan=3, sticky=W+E)


def forward():
    global my_label
    global image_number
    my_label.grid_forget()
    image_number = (image_number + 1) % len(image_list)
    my_label = Label(image=image_list[image_number])
    my_label.grid(row=0, column=0, columnspan=3)
    redraw_status()


def back():
    global my_label
    global image_number
    my_label.grid_forget()
    image_number = (image_number - 1 + len(image_list)) % len(image_list)
    my_label = Label(image=image_list[image_number])
    my_label.grid(row=0, column=0, columnspan=3)
    redraw_status()


button_back = Button(root, text="<<", command=back)
button_exit = Button(root, text="Exit Program", command=root.quit)
button_forward = Button(root, text=">>", command=forward)


button_back.grid(row=1, column=0)
button_exit.grid(row=1, column=1)
button_forward.grid(row=1, column=2, pady=10)

status.grid(row=2, column=0, columnspan=3, sticky=W+E)
root.mainloop()
