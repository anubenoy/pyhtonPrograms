lst=[1,1,2,3,3,3,1]
for i in range(len(lst)-1):
    count=0
    num=lst[i]
    for j in range(len(lst)-1):
        if num==lst[j]:
            count+=1
            lst.remove(lst[j])
print(num, count)
