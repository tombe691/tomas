from Tkinter import *

listOptions = [
    "January", "February", "Mars",
    "April", "May", "June", "July",
    "August", "September", "Oktober",
    "November", "December"
]

listValues = {
    "January": "31", "February": "28", "Mars": "31",
    "April": "30", "May": "31", "June": "30",
    "July": "31", "August": "31", "September": "30",
    "Oktober": "31", "November": "30", "December": "31"
}

root = Tk()
frame = Frame(root)
frame.grid(column = 0, row = 0, sticky = W+E+N+S)
frame.pack()

variable = StringVar(frame)
variable.set("Months")

option = OptionMenu(frame, variable, *listOptions)
option.grid(row = 1, column = 2, sticky = E+W+S+N)
option.config(width = 10)

t1 = Label(frame, text = "Select month: ").grid(row = 1, column = 1, sticky = W)

outputText = StringVar()
t2 = Entry(frame, text = outputText)
t2.pack()
t2.grid(row = 2, column = 1, columnspan = 2, sticky = W+E+N+S)
t2.config(state = DISABLED, disabledforeground = 'black')

def change_text(*args):
    newOutput = "%s consists of %s days." % (variable.get(), listValues[variable.get()])
    outputText.set(newOutput)

variable.trace('w', change_text)

root.wm_title('Days per month.')
mainloop()
