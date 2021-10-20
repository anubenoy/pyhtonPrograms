lst1=[1,2,3]
lst2=[3,4,5]
for i in lst1:
    if i in lst2:
        lst1.remove(i)
print(lst1)
    
'''n=len(lst)-1
for i in range(len(lst)-1):
        num=lst[i]
        for j in range(len(lst)-1):
                       if num==lst[j]:
                               lst.remove(lst[j])
print(lst)
j=i+1
        for j in range(len(lst)-1):
                if num == lst[j]:
                        print(num)'''
