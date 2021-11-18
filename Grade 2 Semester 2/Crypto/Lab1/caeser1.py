# Caesar Cipher 1

MAX_KEY_SIZE = 26

# encrypt || decrypt hiihiin garaas avah function
def getMode():
    while True:
        print('Do you wish to encrypt or decrypt a message?')
        mode = input().lower()
        # 'encrypt e decrypt d' endeees oruulj bj duusna
        if mode in 'encrypt e decrypt d'.split():
            return mode
        else:
            print('Enter either "encrypt" or "e" or "decrypt" or "d".')

# garaas e || d hiih message iig avna
def getMessage():
    print('Enter your message:')
    return input()

# e || d hiih key iig garaas avna
def getKey():
    key = 0
    while True:
        print('Enter the key number (1-%s)' % (MAX_KEY_SIZE))
        key = int(input())
        if (key >= 1 and key <= MAX_KEY_SIZE):
            return key

def getTranslatedMessage(mode, message, key):
    # mode 'd' bwal key sorog utgatai bolgono encrypt hiigdsen message-iin
    # useg bolgonii ascii code oos hasaj decrypt hiisne message garna
    # herev e bwal ascii code deer key iin utgiig nemj encrypt hiine
    if mode[0] == 'd':
        key = -key

    translated = ''

    for symbol in message:
        num = chr(ord(symbol) + key)
        translated += num

    return translated

#mode = getMode()'qnuux?#$#4'
#message = getMessage()
#key = getKey()
#print('Your translated text is:')
#print(getTranslatedMessage(mode, message, key))