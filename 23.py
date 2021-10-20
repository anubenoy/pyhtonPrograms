s1=input(" Enter 1st string: ")
s2=input(" Enter 2nd string: ")
s3=s1.split()
s4=s2.split()
l1=len(s3)
l2=len(s4)
print(" not in 2nd string  : " ,end=" " )
i=0
while i < l1:
    j=0
    if s3[i] not in s4:
        print(s3[i], end=" ")
    i+=1
print("\n",s3,s4)
