d={1:"one",2:"two"}
n=int(input("Enter the key for search (int) : "))
if d.get(n):
    print(n ," is a key with value ",d.get(n))
else:
    print("Not a key")