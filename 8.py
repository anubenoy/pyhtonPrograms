lst=[1,1,2]
n=len(lst)-1
for i in range(len(lst)-1):
        num=lst[i]
        for j in range(len(lst)-1):
                       if num==lst[j]:
                               lst.remove(lst[j])
print(lst)
