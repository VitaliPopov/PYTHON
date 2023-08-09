'''
Даны два массива чисел. Требуется вывести те элементы первого массива (в том порядке, в каком они идут в первом массиве), которых нет во втором массиве. Пользователь вводит  число N - количество элементов в первом массиве, затем N чисел - элементы массива. Затем число M - количество элементов во втором массиве. Затем элементы второго массива
Ввод: 					Вывод:
7					3 3 2 12
3 1 3 4 2 4 12
6
4 15 43 1 15 1
'''
first_list = list(map(int, input('Input numbers for first list: ').split()))
second_list = list(map(int, input('Input numbers for second list: ').split()))
print(first_list, second_list)


def find_difference(list1, list2):
    list3 = []
    for item in list1:
        if item not in list2:
            list3.append(item)
    return list3


print(find_difference(first_list, second_list))