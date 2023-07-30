'''
Дан список чисел. Определите, сколько в нем встречается различных чисел.

Input: [1, 1, 2, 0, -1, 3, 4, 4]

Output: 6



Примечание: Пользователь может вводить значения списка или список задан изначально.
'''
list_1 = [1, 1, 2, 0, -1, 3, 4, 4]
unique_set = set(list_1)
print(len(unique_set))

list_2 =[]
count = 0
for item in list_1:
    if item not in list_2:
        list_2.append(item)
print(len(list_2))