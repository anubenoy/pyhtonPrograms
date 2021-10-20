string=input("Enter a string : ")
if len(string)>3:
    if string[-3 : ]=='ing':
        string=string[ : -3]
        string=string+'ly'
    else:
        string=string+'ing'
else:
    print(string)
