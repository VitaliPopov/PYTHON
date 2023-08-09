'''
Два различных натуральных числа n и m называются 
дружественными, если сумма делителей числа n (включая
 1, но исключая само n) равна числу m и наоборот.
   Например, 220 и 284 – дружественные числа. 
   По данному числу k выведите все пары дружественных
     чисел, каждое из которых не превосходит k. 
     Программа получает на вход одно натуральное 
     число k, не превосходящее 105. Программа 
     должна вывести  все пары дружественных чисел, 
     каждое из которых не превосходит k. Пары 
     необходимо выводить по одной в строке, 
     разделяя пробелами. Каждая пара должна быть 
     выведена только один раз (перестановка чисел 
     новую пару не дает).
Ввод:			Вывод:
300			220 284
'''
def find_friendly_numbers(number):
    summ_numbers = 0
    for divisor in range(1, number):
        if number % divisor == 0:
            summ_numbers += divisor
    return summ_numbers


temp_list = []
user_number = int(input('Input number: '))
first_summ = find_friendly_numbers(user_number)


for i in range(1, user_number):
    second_summ = find_friendly_numbers(i)
    if second_summ <= user_number and find_friendly_numbers(user_number) == find_friendly_numbers(second_summ):
        third_summ = find_friendly_numbers(second_summ)
        temp_list.append((i, second_summ, third_summ))

print(temp_list)