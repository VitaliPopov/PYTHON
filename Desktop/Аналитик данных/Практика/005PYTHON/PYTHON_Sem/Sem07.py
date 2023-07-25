'''По данному целому неотрицательному n вычислите значение n!. N! = 1 * 2 * 3 * … * N (произведение всех чисел от 1 до N) 0! = 1 Решить задачу используя цикл while


Input:       5

Output:    120
'''
N=int(input("Enter number: "))
count=1
while (N!=0):
    count*=N
    N-=1
    print(count)
    '''
    number = int(input('Input number: '))
count = 1
if number > 0:
    while number != 0:
        count *= number
        number -= 1
    print(count)
else:
    print('Incorrect')
    '''