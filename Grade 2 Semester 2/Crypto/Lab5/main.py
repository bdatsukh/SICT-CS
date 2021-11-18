import aes

file = open('plainText.txt')
plainText = file.read()
file.close()

key = "That's my kung fu"

encText = aes.encrypt(key, plainText)
decText = aes.decrypt(key, encText)

print(encText)
print(decText)