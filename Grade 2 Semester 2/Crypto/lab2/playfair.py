result = list()

def matrix(x,y,initial):
    return [[initial for i in range(x)] for j in range(y)]

my_matrix=matrix(5,5,0) #initialize matrix

def getKey():
    key = input("Enter key:")
    key = key.replace(" ", "")
    key = key.upper()


    for c in key: #storing key
        if c not in result:
            if c=='J':
                result.append('I')
            else:
                result.append(c)

    flag = 0

    for i in range(65,91): #storing other character
        if chr(i) not in result:
            if i == 73 and chr(74) not in result:
                result.append("I")
                flag = 1
            elif flag == 0 and i == 73 or i == 74:
                pass
            else:
                result.append(chr(i))

    k=0

    for i in range(0,5): #making matrix
        for j in range(0,5):
            my_matrix[i][j]=result[k]
            k+=1

def locindex(c): #get location of each character
    loc=list()
    if c=='J':
        c='I'
    for i ,j in enumerate(my_matrix):
        for k,l in enumerate(j):
            if c==l:
                loc.append(i)
                loc.append(k)
                return loc

def encrypt(msg): #Encryption
    
    msg=msg.upper()
    msg=msg.replace(" ", "")
    i=0
    for s in range(0,len(msg)+1,2):
        if s<len(msg)-1:
            if msg[s]==msg[s+1]:
                msg=msg[:s+1]+'X'+msg[s+1:]
    if len(msg)%2!=0:
        msg=msg[:]+'X'
    print("CIPHER TEXT:",end=' ')
    result = "" 
    while i<len(msg):
        loc=list()
        loc=locindex(msg[i])
        loc1=list()
        loc1=locindex(msg[i+1])
        
        if loc[1]==loc1[1]:
            result = result + "{}{}".format(my_matrix[(loc[0]+1)%5][loc[1]],my_matrix[(loc1[0]+1)%5][loc1[1]])
        elif loc[0]==loc1[0]:
            result = result + "{}{}".format(my_matrix[loc[0]][(loc[1]+1)%5],my_matrix[loc1[0]][(loc1[1]+1)%5])
        else:
            result = result + "{}{}".format(my_matrix[loc[0]][loc1[1]],my_matrix[loc1[0]][loc[1]])
        i=i+2
    return result

def decrypt(msg): #decryption
    msg=msg.upper()
    msg=msg.replace(" ", "")
    print("PLAIN TEXT:",end=' ')
    i=0
    result = ""
    while i<len(msg):
        loc=list()
        loc=locindex(msg[i])
        loc1=list()
        loc1=locindex(msg[i+1])
        if loc[1]==loc1[1]:
            result = result + "{}{}".format(my_matrix[(loc[0]-1)%5][loc[1]],my_matrix[(loc1[0]-1)%5][loc1[1]])
        elif loc[0]==loc1[0]:
            result = result + "{}{}".format(my_matrix[loc[0]][(loc[1]-1)%5],my_matrix[loc1[0]][(loc1[1]-1)%5])
        else:
            result = result + "{}{}".format(my_matrix[loc[0]][loc1[1]],my_matrix[loc1[0]][loc[1]])
        i=i+2
    
    return result
    
"""
while(1):
    choice=int(input("\n 1.Encryption \n 2.Decryption: \n 3.EXIT"))
    if choice==1:
        encrypt()
    elif choice==2:
        decrypt()
    elif choice==3:
        exit()
    else:
        print("Choose correct choice")
        """