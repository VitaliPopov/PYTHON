'''Задача №55. Решение в группах
Создать телефонный справочник с возможностью импорта и экспорта данных в формате .txt. Фамилия, имя, отчество, номер телефона - данные, которые должны находиться в файле.
Программа должна выводить данные
Программа должна сохранять данные в текстовом файле
Пользователь может ввести одну из характеристик для поиска определенной записи(Например имя или фамилию человека)
Использование функций. Ваша программа не должна быть линейной
'''
def create_data (recs):
    with open ('file.txt', 'a', encoding = 'utf-8') as data:
        for i, item in enumerate (recs):
            data.write (item + '\n')
    message = "запись создана"
    return message


def find_data (key_str):
    string1 = []
    flag = False
    with open ('file.txt', 'r', encoding = 'utf-8') as data:
        for line in data:
            string1 = line.split()
            for i, item in enumerate (string1):
                if item == key_str:
                    print (string1)
                    flag = True
        if not flag:
            print ("Данные по Вашим параметрам не найдены")
    

def print_data ():
    with open ('file.txt', 'r', encoding = 'utf-8') as data:
        for line in data:
            print(line)

    message = "Данные выведены на экран"
    return message

print ("Добро пожаловать в телефонный справочник")

while True:
    print ()
    print ("Чтобы добавить запись - нажмите 1")
    print ("чтобы найти запись - нажмите 2")
    print ("чтобы вывести все данные на экран - нажмите 3")
    string = int (input ("чтобы окончить работу с программой - нажмите 4: "))
    print ()
    if string == 1:
        flag = True
        string1 = 0
        line = " "
        rec = []
        while flag == True:
            line = input ("Ведите Фамилию Имя Отчество и Телефон абонента через пробел: ")
            rec.append (line)
            print (rec)      
            string1 = int (input("Если желаете добавить еще запись нажмите 1, иначе 0:"))
            if string1 == 0:
                flag = False
        print (create_data (rec))
        
    elif string == 2:
        print ("ищем")
        string1 = (input("Введите данные для поиска:"))
        find_data (string1)

    elif string == 3:
        print ("")
        print ("Выводим все данные")
        print ("")
        print_data()
    elif string == 4:
        break
    else:
        print ("Такой команды не существует")