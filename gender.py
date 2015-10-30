def myself():
   firstname = raw_input("Firstname: ")
   familyname = raw_input("Familyname: ")
   personalnumber = raw_input("Personalnumber: ")
   age = raw_input("age: ")
   
   gender = personalnumber[len(personalnumber) - 2]
   if int(gender) % 2 == 0:
       gender = "women"
   else:
       gender = "man"
   #print gender
   return gender
print myself()
