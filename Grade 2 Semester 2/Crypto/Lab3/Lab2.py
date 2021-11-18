p10 = [3, 5, 2, 7, 4, 10, 1, 9, 8, 6]
p8 = [6, 3, 7, 4, 8, 5, 10, 9]
ip8 = [2, 6, 3, 1, 4, 8, 5, 7]
ep = [4, 1, 2, 3, 2, 3, 4, 1]
s0=[['01','00','11','10'],['11','10','01','00'],['00','10','01','11'],['11','01','11','10']]
s1=[['00','01','10','11'],['10','00','01','11'],['11','00','01','00'],['10','01','00','11']]
p4 = [2, 4, 3, 1]
ip = [4, 1, 3, 5, 7, 2, 8, 6]

def XOR(key, msg):
    result = ''
    for i in range(len(msg)):
        if msg[i] == key[i]:
            result += '0'
        else:
            result += '1'
    return result

def permutate(key, p):
    np = ""
    for i in p:
        np += key[i - 1]
    return np

def roundShift(key, r):
    first_half = key[r:5] + key[0:r]
    second_half = key[5+r:10] + key[5:5+r]
    return first_half + second_half

def CK4(key):
    new_key = permutate(key, p10)
    return new_key

def keyRet(key):
    new_key = roundShift(CK4(key), 1)
    K1 = permutate(new_key, p8)
    K2 = permutate(roundShift(new_key, 2), p8)
    return K1, K2

def repeat4(L, R, key):
    exR = permutate(R, ep)
    exR = XOR(key, exR)

    new_L = exR[0:4]
    new_R = exR[4:8]

    row_L = int(new_L[0] + new_L[3], 2)
    column_L = int(new_L[1:3], 2)
    row_R = int(new_R[0] + new_R[3], 2)
    column_R = int(new_R[1:3], 2)
    
    new_R = s0[row_L][column_L] + s1[row_R][column_R]
    new_R = permutate(new_R, p4)
    new_R = XOR(new_R, L)

    return new_R + R

def translate(text, K1, K2):
    text = permutate(text, ip8)
    new_text = repeat4(text[0:4], text[4:8], K1)
    new_text = repeat4(new_text[4:8], new_text[0:4], K2)
    new_text = permutate(new_text, ip)
    return new_text

def decTranslate(text, K1, K2):
    return translate(text, K2, K1)

def toBinary(message):
    result = []

    for c in message:
        tmp = ''
        if c != ' ':
            tmp = bin(ord(c)).replace("0b","")
            x = tmp[::-1] 
            while len(x) < 8:
                x += '0'
            tmp = x[::-1]
        result.append(tmp)

    return result

def decrypt(message, key):
    K1, K2 = keyRet(key)
    textResult = ""
    message = toBinary(message)
    for text in message:
        if text != '':
            textResult += chr(int(decTranslate(text, K1, K2), 2))
        else:
            textResult += " "
    return textResult

def encrypt(message, key):
    K1, K2 = keyRet(key)
    textResult = ""
    message = toBinary(message)
    for text in message:
        if text != '':
            textResult += chr(int(translate(text, K1, K2), 2))
        else:
            textResult += " "
    return textResult

