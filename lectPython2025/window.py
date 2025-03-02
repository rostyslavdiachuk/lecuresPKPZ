from tkinter import *


def print_smt():
    print(strVar.get())


def set_all_checkboxes(should_change: bool):
    if should_change:
        b1Var.set(True)
        b2Var.set(True)
        b3Var.set(True)
        b4Var.set(True)


def remove_all_checkboxes(should_change: bool):
    if should_change:
        b1Var.set(False)
        b2Var.set(False)
        b3Var.set(False)
        b4Var.set(False)


if __name__ == '__main__':
    window = Tk()
    window.geometry("500x500")
    window.config(bg="white")
    window.title("Tkinter program")
    btn0 = Button(window, text="deselect all", command=lambda: remove_all_checkboxes(mainVar.get()))
    label = Label(window, text="This text")
    btn3 = Button(window, text="select all", command=lambda: set_all_checkboxes(mainVar.get()))
    btn_show = Button(window, text="show all", command=print_smt)
    mainVar = BooleanVar()
    b1Var = BooleanVar()
    b2Var = BooleanVar()
    b3Var = BooleanVar()
    b4Var = BooleanVar()

    main_cb = Checkbutton(window, variable=mainVar, text="should checkbox work")
    cb = Checkbutton(window, variable=b1Var, text="I want all labs1")
    cb1 = Checkbutton(window, variable=b2Var, text="I want all labs2")
    cb2 = Checkbutton(window, variable=b3Var, text="I want all labs3")
    cb3 = Checkbutton(window, variable=b4Var, text="I want all labs4")
    strVar = StringVar()
    strVar.set("C#")
    entry = Entry(window, textvariable= strVar, fg="yellow", bg="blue")
    # entry.insert(0, "hello")
    entry.pack()

    if a := 10:
        print("helloWOrld")
    # e2 = Entry(window, width=10)
    # e2.pack()
    c_sharp_rb = Radiobutton(window, variable=strVar, value="C#", text="C#", command=print_smt)
    java_rb = Radiobutton(window, variable=strVar, value="Java", text="Java", command=print_smt)
    python_rb = Radiobutton(window, variable=strVar, value="Python", text="Python", command=print_smt)


    python_rb.pack()
    java_rb.pack()
    c_sharp_rb.pack()
    main_cb.pack()
    label.pack()
    # entry.pack()
    # btn0.pack()
    # btn3.pack()
    btn_show.pack()
    # cb.pack()
    # cb1.pack()
    # cb2.pack()
    # cb3.pack()
    # btn2.grid(column=0, row=1)
    window.mainloop()
