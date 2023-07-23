'''В некоторой школе решили набрать три новых математических класса и оборудовать кабинеты для них новыми партами. За каждой партой может сидеть два учащихся. Известно количество учащихся в каждом из трех классов. Выведите наименьшее число парт, которое нужно приобрести для них.
Input: 20 21 22(ввод чисел НЕ в одну строку)
Output: 32'''

Students1= int(input("Enter Students1: "))
Students2= int(input("Enter Students2: "))
Students3= int(input("Enter Students3: "))
print(Students1 // 2 + Students2 // 2 + Students3 // 2 + Students1 % 2 + Students2 % 2 + Students3 % 2)
