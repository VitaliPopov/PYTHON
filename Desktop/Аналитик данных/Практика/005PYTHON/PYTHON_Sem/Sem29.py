'''
Напишите функцию same_by(characteristic, objects), которая проверяет, все ли объекты имеют одинаковое значение некоторой характеристики, и возвращают True, если это так. Если значение характеристики для разных объектов отличается - то False. Для пустого набора объектов, функция должна возвращать True. Аргумент characteristic - это функция, которая принимает объект и вычисляет его характеристику.
Ввод:							Вывод:
values = [0, 2, 10, 6]				same
if same_by(lambda x: x % 2, values):
	print(‘same’)
else:
	print(‘different’)
'''
def same_by(characteristic, objects):
    return list(filter(characteristic, objects))


values = [0, 2, 10, 6, 7]
temp_list = same_by(lambda x: x % 2 == 0, values)

if not values:
    print('same')
elif temp_list and len(temp_list) == len(values):
    print('same')
else:
    print('different')