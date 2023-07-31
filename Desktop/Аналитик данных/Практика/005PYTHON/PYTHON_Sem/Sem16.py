'''
Пользователь вводит текст(строка). Словом считается последовательность непробельных символов идущих подряд, слова разделены одним пробелом. Определите, сколько различных слов содержится в этом тексте.
Input: She sells sea shells on the sea shore The shells that she sells are sea shells I'm sure So if she sells sea shells on the sea shore I'm sure that the shells are sea shore shells
'''

string = input('Enter text: ')
list_1 = string.split()
plenty_1 = set(list_1)
print(len("Количество уникальных слов в предложении: ", plenty_1))
print(len("Количество слов в предложении: ", list_1))