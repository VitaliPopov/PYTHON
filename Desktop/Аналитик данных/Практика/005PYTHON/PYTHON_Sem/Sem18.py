'''
Последовательностью Фибоначчи называется последовательность чисел a0, a1, ..., an, ..., где
a0 = 0, a1 = 1, ak = ak-1 + ak-2 (k > 1).
Требуется найти N-е число Фибоначчи
Input: 7
Output: 13
'''

def number_fib(number):
    if number in [1, 2]:
        return 1
    return number_fib(number - 1) + number_fib(number - 2)


user_number = int(input('Input number: '))
print(number_fib(user_number))

