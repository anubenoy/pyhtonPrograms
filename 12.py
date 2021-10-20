lst=[[1,2,3],[4,5],[4,5],[1,3]]
i=0
while i < len(lst):
        j=i+1
        while j < len(lst):
                if (lst[i] == lst[j]):
                        lst.remove(lst[i])
                else:
                        j+=1
        i+=1
print(lst)