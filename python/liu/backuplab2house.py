#lab2 by Tomas Berggren
import math

def getLayerSize(x, y):
    return x*y

def myStair(x, y):
    stairDepth = min(width, depth)
    stairWidth = max(width, depth)
    global x1
    global y1
    x1 = 1
    y1 = 1
    sum = 0;
    for i in range (0, stairDepth):
        #print(i)
        #print('\n sum for line ', x1*y1)
        sum += getLayerSize(x1, y1)

        while (x1<stairDepth or y1<stairWidth):
        x1 += 2
        y1 += 1
                   
    print('leaving stair with sum ', sum)
    return sum

    return sum


def myWall(height, width, depth):
    return height*((width-1+depth-1)*2)

def myFloor(width, depth):
    print(width, ' floor space ', depth)
    floorSize = (width-2)*(depth-2)
    print('floor size ', floorSize)

    return floorSize

def myHouse(choice):
    print('hej')
    height = int(input('\nMata in höjd: '))
    if choice==1:
        width = int(input('\nMata in bredd: '))
        depth = int(input('\nMata in djup: '))
        #print('Antal byggstenar som behövs: detta gör vi i del B')
        wallStones = myWall(height, width, depth)
        print('nr of wallStones ', wallStones)
        return wallStones
    elif choice==2:
        #print('Antal byggstenar som behövs: detta gör vi i del C')
        return myStair(height)
    else:
        width = int(input('\nMata in bredd: '))
        depth = int(input('\nMata in djup: '))
        print('Antal byggstenar som behövs: detta gör vi i del B')
        sum = 0
        sum +=myWall(height, width, depth)
        print('sum after wall ', sum)
        sum +=myStair(height, height)
        print('sum after stair ', sum)
        sum +=myFloor(width, depth)
        print('sum after floor ', sum)
#        roofHeight = min(width, depth)
#        roofHeight2 = max(width, depth)
#        wallDepth = min(y1-1, x1-2)
#        wallWidth = max(y1-1, x1-2)

#        print('width = ', width)
#        print('x = ', wallDepth)
#        print('depth = ', depth)
#        print('y = ', wallWidth)

#        #while (wallWidth)<roofHeight2 or (wallDepth)<roofHeight:
#            #wallDepth+=1
#            #wallWidth+=1

        #x2 = 1
        #y2 = 1
        sum +=myStair(width, depth)
#        print('width = ', width)
#        print('x = ', wallDepth)
#        print('depth = ', depth)
#        print('y = ', wallWidth)
        return sum

def myPrintNrOfStones(nr):
    print('Antal byggstenar som behövs:', nr)

print('Välkommen till husbyggarprogrammet! (Lab 2)\n')



run = 1
nr = 0

#add while to loop and allow exit from loop

while run:
    print('\n')
    print('Vilken funktionalitet vill du använda?')
    print('1. Bygga rektangulär inhägnad')
    print('2. Bygga triangulär trappa')
    print('3. Bygga hus')
    print('4. Avsluta')
    menuChoice = int(input('Gör ditt val:'))
    if menuChoice == 1:
        nr = myHouse(menuChoice)
        myPrintNrOfStones(nr)
        print("1")
    elif menuChoice == 2:
        nr = myHouse(menuChoice)
        myPrintNrOfStones(nr)
        print("2")
    elif menuChoice == 3:
        nr = myHouse(menuChoice)
        myPrintNrOfStones(nr)
        print("3")
    elif menuChoice == 4:
        print("4")
        run = 0
    #    nr = myHouse(menuChoice)
    else:
        print("fel")
        run = 0

