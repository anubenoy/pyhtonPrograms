# def process(paragraph):
#     ans = ""
#     ls = paragraph.split(".")[:-1]
#     for xy in ls:
#         temp = xy.split()
#         temp = temp[::-1]
#         tempans = []
#         for y in temp:
#             word = y
#             flag = False
#             for x in word:
#                 if x == "#":
#                     temp1 = word[::-1]
#                     ltemp=list(word)
#                     reword = ""
#                     ltemp[word.find("#")] = word[temp1.find("#")]
#                     palandrome_word = "".join(ltemp)
#                     if palandrome_word == palandrome_word[::-1]: reword = palandrome_word
#                     else:
#                         lstemp = []
#                         for x in range(len(palandrome_word)): lstemp.append("@")
#                         reword = "".join(lstemp)
#                     tempans.append(reword)
#                     flag=True
#             if flag == False: tempans.append(word)
#         ans += " ".join(tempans) + ". "
#         tempans.clear()
#     return ans

# paragraph = "mal#yalam is our mother tong#e. It is a langua#e spo#en in the Indian state of kerala. m#dam ha#nah teaches Malayalam. neve# is a #tudent of hannah."
# new_paragraph = process(paragraph)
# print(new_paragraph)



# def is_leap(year):
#     leap = False
#     if year % 4 ==0 :
#         leap = True
#         if year % 100 == 0 :
#             leap = False
#             if year % 400 == 0:
#                 leap = True    
#     return leap

# # year = int(input())
# year = 1900
# print(is_leap(year))


# s,n= [20,20,19,19,21],["harsh","beria","verun","kakunami","vikas"]
# for x in sorted(set([n[x] for x in range(len(s)) if s[x] == min([x for x in s if x!=min(s)])])):print(x)



# def clean_the_string(input_string):
#     # complete this function
#     output_string1=[]
#     output_string=""
#     data=input_string.split(" ")
#     for x in data :
#         x = list(x.lower())
#         if len(x)>0:
#             f,e=0,len(x)-1
#             d1=x.copy()
#             while f!=e and f<=len(x)/2:
#                 if x[f] != x[e]:
#                     break
#                 else:
#                     d1[f]="_"
#                     d1[e]="_"
#                 f+=1
#                 e-=1
#             if d1 == ["_" for x in d1]:
#                 d1=""
#             if len(d1)>0 and "".join(d1) not in output_string1:
#                 output_string1.append("".join(d1))
#         output_string = " ".join(output_string1)
#     return output_string

# input_string = "Did Hannah see    bees Hannah   did"
# print(clean_the_string(input_string))


# from urllib import parse
# def split_qp(filepath='Data/urls.json'):
#     f=open(filepath,"r")
#     fw=open('Data/query.json',"a")
#     for x in f.readlines() :
#         print(dict(parse.parse_qsl(parse.urlsplit(x).query)))
#         d=dict(parse.parse_qsl(parse.urlsplit(x).query))
#         fw.write(str(list(d)))
#         #print(str(d))
#     #fr=open('Data/query.json',"r") 
#     #for x in fr.readlines() :
#        # print(x)
# split_qp()

# ls = [x for x in range(1,9)]
# n=int(input("Enter a number : "))
# print(ls[n:]+ls[:n])

# for x in range(0,5):
#     space=0
#     for y in range(0,5-x-1):
#         print(" ",end="")
#         space = y+1
#     for z in range(space,5): print("*",end="")
#     print("")

# for x in range(5):
#     for y in range(5,x,-1):print(" ",end="")
#     for z in range(x+1):print("*",end="")
#     print("")



# in first test case -8 isnt calculated, but in 4rth test case every number in the list is calculated !!
# assuming first test case is wrong
# def maxScore(points):
#     points.sort()
#     max = sum([points[x-1] * x for x in range(1,len(points)+1)])
#     return max if max > 0 else 0

# points = [4,3,2]
# # points = [-2,5,-1,0,3,-3]
# # points = [-1,-4,-5]
# maximum_score = maxScore(points)
# print(maximum_score)


# def find_pattern(input_string):
#     return len(set(input_string)) >= len(input_string)-1

# print(find_pattern("hola"))
# print(find_pattern("hello"))
# print(find_pattern("coronavirus"))


# n = 10
# for x in range(n):
#     for y in range(n):
#         if y == y/2-1:
#             print(" ",end="")
#         else:
#             print(" *",end="")

#     print("")

# for a in range(n):
#     if a < n/2:
#         for b in range(n//2-a):
#             print(" *",end="")
#         if a > 0:
#             for ab in range(a*2):
#                 print("  ",end="")
#         for abc in range(n//2-a):
#             print(" *",end="")
#     else:
#         for c in range(a-n//2+1):
#             print(" *",end="")
#         for ab in range(a-n//2+1,n-(a-n//2+1)):
#                 print("  ",end="")
#         for abc in range(a-n//2+1):
#             print(" *",end="")
#     print("")

# ls = [x for x in range(1,11)]
# for x in ls:
#     print(x)

# x=int(input("enter number of rows: "))
# for i in range(x):
#     val=i+1
#     dec=x-1
#     for j in range(i+1):
#         print(val,end=" ")
#         val=val+dec
#         dec=dec-1
#     print()

# def finding_pattern(a,b,z):
#     temp = ""
#     if a[0] == z[0]:
#         for x in range(len(a)) :
#             if a[x] == z[x]: temp+=a[x]
#             else:break
#     else:
#         for x in range(len(b)) :
#             if b[x] == z[x]: temp+=b[x]
#             else:break
#     return temp

# def is_perfect_shuffled(a, b, z):
#     if(len(z)==(len(a)+len(b))):
#         while(len(z)>0):
#             r = finding_pattern(a,b,z)
#             length = len(r)  # to find pattern length
#             if length > 0 :
#                 if a.find(r) > -1: 
#                     a = a[length:]
#                     z = z[length:] 
#                     if z[:length] == b[:length]:
#                         b = b[length:]
#                         z = z[length:]
#                     else:
#                         return "False"
#                 elif b.find(r) > -1:
#                     b = b[length:]
#                     z = z[length:]
#                     if z[:length] == a[:length]:
#                         a = a[length:]
#                         z = z[length:]
#                     else:
#                         return "False"
#             else:
#                 return "False"
#         return "True"
#     else:
#         return "False"

# a="aabcc"
# b="dbbca"
# z="aadbbbaccc"

# # a="eefgg"
# # b="hffge"
# # z="eehffgfgeg"
# result = is_perfect_shuffled(a,b,z)
# print(result) 



# maxTravelDist = 7000
# forwardRouteList = [[1,2000],[2,4000],[3,6000]]
# returnRouteList = [[1,2000]]

maxTravelDist = 10000
forwardRouteList = [[1,3000],[2,5000],[3,7000],[4,10000]]
returnRouteList = [[1,2000],[2,3000],[3,4000],[4,5000]]

# sumTempList,ordersIdentifierList,returnData  = [],[],[]

# for x in forwardRouteList:
#     for y in returnRouteList:
#         if x[1]+y[1] <= maxTravelDist:
#             sumTempList.append(x[1]+y[1])
#             ordersIdentifierList.append([x[0],y[0]])

# for z in range(0,len(sumTempList)):
#     if sumTempList[z] == max(sumTempList):
#         returnData.append(ordersIdentifierList[z])

# return returnData



options = []
max = 0

for f in forwardRouteList:
    for r in returnRouteList:
        d = f[1]+r[1]
        if (d<=maxTravelDist):
            if d >= max:
                max = d
                options.append((f, r))

print( [[f[0], r[0]] for f, r in options if f[1]+r[1]==max])