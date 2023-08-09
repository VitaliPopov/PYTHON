#Факториал
def fact(number):
    if number == 1:
        return 1
    return number * fact(number-1)

N= int(input('Enter num: '))
print(fact(N))