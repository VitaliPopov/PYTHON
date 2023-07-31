'''
Напишите программу, которая принимает на вход строку, и отслеживает, сколько раз каждый символ уже встречался. Количество повторов добавляется к символам с помощью постфикса формата _n.

Input: a a a b c a a d c d d
Output: a a_1 a_2 b c a_3 a_4 d c_1 d_1 d_2

Для решения данной задачи используйте функцию .split()
'''
letter_list = input("Enter letters from a to d: ").split()

new_dict = {}
new_string = ''

for item in  letter_list:
    if item not in new_dict:
        new_dict[item] = 0
        new_string += f'{item} '

    else:
        new_dict[item] += 1
        new_string += f'{item}_{new_dict.get(item) }'
        
print(new_string)