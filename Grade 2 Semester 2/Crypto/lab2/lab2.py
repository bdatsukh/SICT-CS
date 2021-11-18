import playfair

def getMsg():
    msg=str(input("ENTER MSG:"))
    

    return msg

def char_frequency(str1):
    dict = {}
    for n in str1:
        keys = dict.keys()
        if n in keys:
            dict[n] += 1
        else:
            dict[n] = 1
    return dict

playfair.getKey()

while(1):
    choice=int(input("\n1.Encryption: \n2.Decryption: \n3.EXIT\n"))
    s = ''

    if choice==1:
        msg = getMsg()
        s = playfair.encrypt(msg)
        print(s)
        print(char_frequency(s))
    elif choice==2:
        msg = getMsg()
        s = playfair.decrypt(msg)
        print(s)
        print(char_frequency(s))
    elif choice==3:
        exit()
    else:
        print("Choose correct choice")