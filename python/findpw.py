from random import randint
import sys

counter = 0

def findThePassword(counter):
    while True:
        print('The computer is looking for the correct password.')

        response = randint(0, 1000)
        counter = counter + 1
        print(response)
        print(" is the password number, try number {0}".format(counter))
        if response == 348:
            sys.exit()


def findThePassword2(counter):
    while True:
        print('The computer is looking for the correct password.')

        for i in range(0, 1000):
            response = i
            counter = counter + 1
            print(response)
            print(" is the password number, try number {0}".format(counter))
            if response == 348:
                sys.exit()


def findThePassword3(counter, type):
    while True:
        print('The computer is looking for the correct password.')

        if (type == 'rand'):
            response = randint(0, 1000)
            counter = counter + 1
            loopForThePassword(counter, response)
        else:
            for i in range(0, 1000):
                response = i
                counter = counter + 1
                loopForThePassword(counter, response)

def loopForThePassword(counter, response):
    print(response)
    print(" is the password number, try number {0}".format(counter))
    if response == 348:
        sys.exit()

type = 'randig'
findThePassword3(counter, type)
