'''
Хакер Василий получил доступ к классному журналу и хочет заменить все свои минимальные оценки на максимальные. Напишите программу, которая заменяет оценки Василия, но наоборот: все максимальные – на минимальные.
Input: 5 -> 1 3 3 3 4

Output: 1 3 3 3 1
'''
marks = (1, 3, 4, 3, 4)


def find_max(list_exp):
    max_mark = list_exp[0]
    for n in range(len(list_exp)):
        if marks[n] > max_mark:
            max_mark = list_exp[n]
    return max_mark


def find_min(list_exp):
    max_mark = list_exp[0]
    for n in range(len(list_exp)):
        if marks[n] < max_mark:
            max_mark = list_exp[n]
    return max_mark


def changeElemToAnother(list_exp, elem_old, elem_new):
    new_list = list(list_exp)
    for n in range(len(list_exp)):
        if marks[n] == elem_old:
            new_list[n] = elem_new
    return new_list


max_mark = find_max(marks)
min_mark = find_min(marks)

print(marks)
print(changeElemToAnother(marks, max_mark, min_mark))