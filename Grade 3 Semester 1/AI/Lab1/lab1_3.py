listOne = [3, 6, 9, 12, 15, 18, 21]
listTwo = [4, 8, 12, 16, 20, 24, 28, 13, 1, 2, 3]

# print([listOne[i] if i % 2 == 1 else listTwo[i] for i in range(len(listOne))])


newList = []

for i in range(max(len(listOne), len(listTwo))):
	if i < len(listOne) and i % 2 != 0:
		newList.append(listOne[i])
	
	if(i < len(listTwo)) and i % 2 == 0:
		newList.append(listTwo[i])

print(newList)