year = int(input("Which year: ")) 
if year % 4 == 0 and year %100 != 0 or year % 400 == 0:
    print year, "is a leapyear"
else:
    print year, "is not a leapyear"
