''' За день машина проезжает n километров. Сколько дней нужно, чтобы проехать маршрут длиной m километров? При решении этой задачи нельзя пользоваться условной инструкцией if и циклами.
Input:
n = 700
m = 750
Output:
2 '''
import math
a= int(input("Enter distance: "))
b= int(input("Enter trip:"))
print(math.ceil(b/a))
s= (b+a-1)//a
print(s)