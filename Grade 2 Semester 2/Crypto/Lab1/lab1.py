import caeser1 as c1

file = open('plainText.txt')
plainText = file.read()

file.close()

mode = 'e'
key = 14

encText = c1.getTranslatedMessage(mode, plainText, key)

file = open('chiperText.txt', 'w', encoding="utf-8")
file.write(encText)
file.close()

mode = 'd'
decText = c1.getTranslatedMessage(mode, encText, key)

file = open('decText.txt', 'w')
file.write(decText)
file.close()