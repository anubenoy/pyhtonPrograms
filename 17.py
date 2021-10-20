d={1:2 , 2:3 , 3:4 , 4:5 }
p=1
for i in d:
    p*=d.get(i)
print("product is ", p)