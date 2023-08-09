'''
Дан список чисел. Посчитайте, сколько в нем пар 
элементов, равных друг другу. Считается, что любые 
два элемента, равные друг другу образуют одну пару,
 которую необходимо посчитать. Вводится список чисел.
 Все числа списка находятся на разных строках.
Ввод:			Вывод:
1 2 3 2 3			2
'''
def find_couple(numbers):
    count = 0
    temp_dict = {}
    for i, item in enumerate(numbers, 1):
        if item not in temp_dict:
            temp_dict[item] = count
        else:
            temp_dict[item] = count + 1
    for keys, values in temp_dict.items():
        if values > 0:
            count += 1
    return count


'''print(find_couple([1, 2, 3, 2, 3, 4, 5, 3, 4, 5]))

def count_double(my_list):
    count = 0

    for i, item1 in enumerate(my_list, start=0):
        for item2 in my_list[i + 1:]:
            if item1 == item2:
                count += 1
                my_list.remove(item2)
                my_list.pop(i)

    return count


print(count_double(list1))'''