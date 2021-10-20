def fun(deviceCapacity, foregroundAppList, backgroundAppList):
    bestCapacity = 0
    options = []
    for fapp in foregroundAppList:
        for bapp in backgroundAppList:
            if fapp[1]+bapp[1] <= deviceCapacity:
                if fapp[1]+bapp[1] >= bestCapacity:
                    bestCapacity = fapp[1]+bapp[1]
                    options.append((fapp, bapp, fapp[1]+bapp[1]))
    return [(option[0][0], option[1][0]) for option in options if option[2]==bestCapacity]

print(fun(7, [[1,2],[2,4],[3,6]], [[1,2]]))