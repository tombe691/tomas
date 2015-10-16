firstName = raw_input("vad heter du i fornamn? ")
lastName = raw_input("vad heter du i efternamn? ")
personalNumber = raw_input("vad har du for personnummer? (10 siffror utan nagra skiljetecken)")
print "Hej ", firstName, " ", lastName
gender = personalNumber[len(personalNumber)-2]

birthYear = personalNumber[0]
birthYear += personalNumber[1]

age = 115-int(birthYear)

if int(gender) % 2:
    print "Du ar en man som i ar fyller", age
else:
    print "Du ar en kvinna som i ar fyller", age
