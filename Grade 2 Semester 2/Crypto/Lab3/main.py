import Lab2

file = open('plainText.txt')
plainText = file.read()

file.close()

key = '1010010101'

encText = Lab2.encrypt(plainText, key)

file = open('encryptedText.txt', 'w', encoding="utf-8")
file.write(encText)
file.close()

decText = Lab2.decrypt(encText, key)

file = open('decText.txt', 'w', encoding='utf-8')
file.write(decText)
file.close()