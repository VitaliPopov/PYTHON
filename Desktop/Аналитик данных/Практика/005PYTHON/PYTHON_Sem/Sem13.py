'''
Напишите программу для печати всех уникальных значений в словаре. 

Input:  [{"V": "S001"}, {"V": "S002"}, {"VI": "S001"}, {"VI": "S005"}, {"VII": "S005"}, {"V":"S009"}, {"VIII":"S007"}] 

Output: {'S005', 'S002', 'S007', 'S001', 'S009'}


Примечание: Список словарей задан изначально. Пользователь его не вводит
'''
from pprint import pprint
dictionary = [{"V": "S001"}, {"V": "S002"}, {"VI": "S001"}, {"VI": "S005"}, {"VII": "S005"}, {"V":"S009"}, {"VIII":"S007"}] 
my_set = set()
for list_1 in dictionary:
    for item in list_1.values():
        my_set.add(item)

print(my_set)
   
'''from pprint import pprint

my_list = [{"V": "S001"}, {"V": "S002"}, {"VI": "S001"}, {"VI": "S005"}, {"VII": "S005"}, {"V":"S009"}, {"VIII":"S007"}]
my_set = set()

for dict_list in my_list:
    for item in dict_list.values():
        my_set.add(item)

print(my_set)
# pprint(my_list)'''

