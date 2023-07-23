'''Вводим с клавиатуры размер 3 сторон треугольника. 

И говорим какой он - обычный, равнобедренный или равносторонний'''

Side1= int(input("Enter Side1: "))
Side2= int(input("Enter Side2: "))
Side3= int(input("Enter Side3: "))
if (Side1==Side2 and Side2==Side3):
    print('Равнобедренный')
elif (Side1==Side2 or Side1==Side3 or Side2==Side3):
    print("Равносторонний")
else:
    print("обычный")

'''if(input_side1 + input_side2 < input_side3
   or input_side2 + input_side3 < input_side1
   or input_side1 + input_side3 < input_side2):
    print("Не существует")
elif (input_side1 == input_side3 and input_side2 == input_side3):
    print("Равносторонний")
elif (input_side1 == input_side3 or input_side2 == input_side3
         or input_side1 == input_side2):
    print("Равнобедренный")
else:
    print("Обычный")'''