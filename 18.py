d={1:"one",2:"two"}
n=int(input("Enter the key to be deleted (int) : "))
if d.get(n):
    print(n ," is a key with value ",d.get(n)," is deleted !!")
    d.pop(n)
    print("new dictnory is ", d)
else:
    print("Not a key")