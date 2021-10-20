fp=open("5.txt",'r')
lst=list(fp.read().split())
fp.close()
fp=open("6.txt",'w+')
for i in lst:
    fp.write(i)
fp.close()
print("created")
