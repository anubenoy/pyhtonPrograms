d={}
dc={}
for i in range(int(input("Enter a range: "))+1):
    val=i*i
    dc={i:val}
    d.update(dc)
print(d)