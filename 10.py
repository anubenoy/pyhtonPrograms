lst=[1,2,3]
lst2=[]
n=int(input("how many times ? "))
for i in range(n):
    lst2.extend(lst)
print(lst2)