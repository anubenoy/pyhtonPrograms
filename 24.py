s1=input(" Enter 1st string: ")
s2=input(" Enter 2nd string: ")
s3=s1.split()
s4=s2.split()
l1=len(s3)
l2=len(s4)
print(" common items are : " ,end=" " )
i=0
while i<l1:
    j=0
    while j<l2:
        if s3[i]==s4[j]:
            print(s3[i], end=" ")
        j+=1
    i+=1
