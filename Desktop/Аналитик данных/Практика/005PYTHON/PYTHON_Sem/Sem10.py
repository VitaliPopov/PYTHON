'''
Вводим многозначное число. 
Необходимо узнать и сказать  последовательность цифр этого числа при просмотре слева направо упорядочена по возрастанию или нет. 
Например 1579 - да, 1427 - нет
'''
N=int(input("Enter number: "))
flag = True
while N >= 10:
    last_N = N%10
    N //= 10
    if last_N< N%10:
        flag = False
if flag:
    print("yes")
else:
    print("no")

'''
user_number = abs(int(input('Input number: ')))
flag = True
if user_number < 10:
    print('Incorrect')
else:
    while user_number >= 10:
        last_digit = user_number % 10
        user_number //= 10
        if last_digit < user_number % 10:
            flag = False
    if flag:
        print('Yes')
    else:
        print('No')

15:28
user_number = abs(int(input('Input number: ')))
flag = True
if user_number < 10:
    print('Incorrect')
else:
    while user_number >= 10:
        last_digit = user_number % 10
        user_number //= 10
        if last_digit < user_number % 10:
            print('No')
            break
    else:
        print('Yes')
        '''