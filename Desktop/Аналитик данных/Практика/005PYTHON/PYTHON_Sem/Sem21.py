'''
Напишите функцию, которая принимает одно число и проверяет, является ли оно простым

Напоминание: Простое число - это число, которое имеет 2 делителя: 1  и n(само число)


Input: 5

Output: yes
'''
# N = int(input('Enter number: '))
# flag = True
# def easy_number(n):
#     i = 2
#     while i <= n:
#         del1 = n // i
#         i +=1
#         if del1==1:
#             return True
#     return False
# print('Yes')
def prime(number):
    for i in range(3, number):
        if not number % i:
            return False
    return True


print(prime(8))