month = raw_input("vilken manad vill du veta hur manga dagar den har?")
monthLC = month.lower()
showDays = True
#dagar = 31
if monthLC == "februari":
    dagar = 28
elif monthLC == "november" or monthLC == "april" or monthLC == "juni" or monthLC == "september":
    dagar = 30
elif monthLC == "januari" or monthLC == "mars" or monthLC == "maj" or monthLC == "juli" or monthLC == "augusti" or monthLC == "oktober" or monthLC == "december" :
    dagar = 31
else:
    print "finns ingen manad som heter ", month
    showDays = False

if showDays:
    print month.lower(), " har", dagar, "dagar"
