string=str(input("Enter a string : "))
v=('a','e','i','o','u')
string=string.lower()
count=0
s=set(string)
print("vowels are ", end=' ')
for i in s:
    if i in v :
        count+=1
        print(i, end=' ')
print("\ncount = ", count)