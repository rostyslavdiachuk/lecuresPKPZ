from tkinter import *

if __name__ == '__main__':
    window = Tk()
    window.geometry("500x500")

    entry = Entry(window, width=100)

    entry.pack()
    window.mainloop()