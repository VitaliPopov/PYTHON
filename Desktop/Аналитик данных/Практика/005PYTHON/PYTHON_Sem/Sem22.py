'''
Дано натуральное число N и последовательность из N элементов. Требуется вывести эту последовательность в обратном порядке.
Примечание. В программе запрещается объявлять массивы и использовать циклы (даже для ввода и вывода).

Input:    2 -> 3 4
Output: 4 3
'''
def input_number(number):
    if number == 0:
        return ""
    last_number = input("Введите цифру: ")
    return  input_number(number - 1) + last_number


print(input_number(5))