lst=[1,2,3,4,5]
lst2=[3,2,5,7]
print("common items are ")
i=0
while i<len(lst):
    j=0
    while j<len(lst2):
        if(lst[i]==lst2[j]):
            print(lst[i])
        j+=1
    i+=1