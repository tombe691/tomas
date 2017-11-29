import traceback
print('test')
a = input()
if (a == 'e'):
    try:
        raise Exception('This is the error message.')
    except:
        errorFile = open('errorinfo.txt', 'w')
        errorFile.write('error on line')
        errorFile.close()
        print('The traceback info was written to errorinfo.txt')
