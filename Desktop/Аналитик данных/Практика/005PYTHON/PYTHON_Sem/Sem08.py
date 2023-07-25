'''
Дано натуральное число A > 1. Определите, каким по счету числом Фибоначчи оно является, то есть выведите такое число n, что φ(n)=A. Если А не является числом Фибоначчи, выведите число -1.

Input:     5

Output:  6
'''
A = int(input("Enter number: "))
i = 0
n=0
m=1
count=0
flag = False
while n <= A:
    count = count + 1
    print("Fibbonacci number: ", n, "range number:", count)
    if n==A:
        flag = True
    i = n + m
    n = m
    m = i
if flag:
    print("Range number: ",count)
else:
    print("Don't number")
'''
мой вариант таким получился: user_number = int(input('Input number: '))
count = 2
first_fib = 0
second_fib = 1
fib_number = first_fib
flag = True
while fib_number < 100000000000000:
    if user_number == fib_number:
        print(count)
        flag = False
    count += 1
    fib_number = first_fib + second_fib
    first_fib, second_fib = second_fib, fib_number
if flag:
    print(-1)'''