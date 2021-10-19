ls = ["mobile", "mouse","moneypot","monitor","mousepad"]
query = "mouse"

ans,ret = [],[]
if len(query) >= 2 :
    for x in range(2,len(query)+1):
        temp = []
        data = query[:x]
        for y in ls:
            if y[:x] == data[:x]:
                temp.append(y)
        ans.append(temp)
for x in ans:
    value = sorted(x)
    if len(value) > 3 :
        ret.append(value[:3])
    else:
        ret.append(value)

print(ret)