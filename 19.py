n=input("Enter string: ")
''' l=len(n)
s=n.split(" ")
l=len(s)
d={}
for i in range (l):
    d.update({i:s[i]})
print("dict= ", d)
dl=len(d)
for j in range (dl):
    count=0
    if(j== dl ''' 
a=set(n.split())
dic={x:n.split().count(x) for x in a }
print(dic)
