import aes.py

file = open('plainText.txt')
plainText = file.read()
file.close()

key = "That's my kung fu"
iv = '89JIlkj3$%0lkjdg'

plainText

encText = aes.encrypt(key, plainText)
decText = aes.decrypt(key, encText)