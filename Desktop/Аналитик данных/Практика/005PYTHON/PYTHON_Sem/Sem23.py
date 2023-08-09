'''
Дан массив, состоящий из целых чисел. 
Напишите программу, которая в данном массиве 
выведет количество элементов, у которых два 
соседних и, при этом, оба соседних элемента 
меньше данного. Сначала вводится число N — 
количество элементов в массиве  Далее записаны 
N чисел — элементы массива. Массив состоит из 
целых чисел. 

Ввод: 			Ввод:
5				5
1 2 3 4 5			1 5 1 5 1

Вывод:			Вывод:
0				2
'''


# n_array1 = int (input ("Введите количество элементов N: "))
# array_1 = [ random.randint (1,n_array1) for item in range (n_array1)]
# print (array_1)
# res = 0

# for index in range (1,n_array1 - 1):
#     if array_1 [index] > array_1 [index-1] and array_1 [index] > array_1 [index+1]:
#         res += 1
#         print (array_1 [index], ">", array_1 [index-1], " and", array_1 [index+1]) # чтобы увидеть какие именно элементы выбраны

# print ("Результат: ", res)

def find_more_for_element(some_list):
    count = 0
    for i, item in enumerate(some_list[1:-1], 1):
        if some_list[i-1] < some_list[i] and some_list[i] > some_list[i+1]:
            count += 1
    return count


my_list = [1, 5, 3, 5, 2]

print(find_more_for_element(my_list))

'''
import random

def max_index (array_1):
    res = 0
    for index in range (1, len (array_1)- 1):
        if array_1 [index] > array_1 [index-1] and array_1 [index] > array_1 [index+1]:
            res += 1
            print (array_1 [index], ">", array_1 [index-1], " and", array_1 [index+1]) # чтобы увидеть какие именно элементы выбраны
    return (res)

n_array1 = int (input ("Введите количество элементов N: "))
array_1 = [ random.randint (1,n_array1) for item in range (n_array1)]
print (array_1)

print ("Результат: ", max_index (array_1))
'''