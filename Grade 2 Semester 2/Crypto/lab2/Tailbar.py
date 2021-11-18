#key-iig garaas avna. Herew hooson zaitai baiwal hasna. Key--iig tom useg bolgono
key = input("Enter key:")
key = key.replace(" ", "")
key = key.upper()

#matrix--g uusgej ogno
def matrix(x,y,initial):
    return [[initial for i in range(x)] for j in range(y)]

#key--iig hadgalah list uusgej baina.
result = list()

#key-iig result list-rii huulj baina. Herew J useg baival tuunii orond I usgiig huulna.
for c in key: #storing key
    if c not in result:
        if c=='J':
            result.append('I')
        else:
            result.append(c)

flag = 0

#65-91 --iin hoorond davtana(A-Z ASCII). Herew result-d hadgalagdaagui useg baiwal nemne. 
# I, J 2 useg 2 uulaa nemegdeegui baiwal I -g nemee flag = 1 bolgono
#f flag == 0 bas i ni 73 ymuu 74 baiwal algasna
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

#matrix() function-iig ashiglah 5, 5 hemjeetei 0-eer duurgesen matrix uusgej baina
my_matrix=matrix(5,5,0) #initialize matrix

#matrix aa result-iin utguudaar duurgej baina
for i in range(0,5): #making matrix
    for j in range(0,5):
        my_matrix[i][j]=result[k]
        k+=1

# neg usgiin index-iig awc baina mor, baganii
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

#Herew 2 ijil useg baiwal dund ni X-iig oruulj ogc baina
#Text-iin urt sondgoi baiwal X-iig zalgaj tegsh urttai bolgoj baina
# msg-iin usegiig 2, 2oor ni salgaad tus buriinh ni mor, baganii indexiig locindex function iig ashiglaj olj baina
#Herew 2 moriin dugaar ijil baiwal baganii dugaar deer 1, 1 --ig nmed 5 uldegteltei huwaagaad moriin dugaariig heweer uldeene matrix aas awna
#Herew Baganiin dugaar ijil baiwal moriin dugaar deer 1, 1-iig nemeed 5 uldegteltei huwaagaad baganiin dugaariig heweer uldeene matrix aas awna
#deerh 2 nohtsol bielehgui baiwal 2 usgiin uusgej baigaa tegsh ontsogtiin nogoo dioganaliin 2 uzuuriin usgiig matrix aas awc hewlene
def encrypt(): #Encryption
    msg=str(input("ENTER MSG:"))
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
    while i<len(msg):
        loc=list()
        loc=locindex(msg[i])
        loc1=list()
        loc1=locindex(msg[i+1])
        if loc[1]==loc1[1]:
            print("{}{}".format(my_matrix[(loc[0]+1)%5][loc[1]],my_matrix[(loc1[0]+1)%5][loc1[1]]),end=' ')
        elif loc[0]==loc1[0]:
            print("{}{}".format(my_matrix[loc[0]][(loc[1]+1)%5],my_matrix[loc1[0]][(loc1[1]+1)%5]),end=' ')
        else:
            print("{}{}".format(my_matrix[loc[0]][loc1[1]],my_matrix[loc1[0]][loc[1]]),end=' ')
        i=i+2

#msg zaitai baiwal zaig ustgana
#Herew 2 moriin dugaar ijil baiwal baganii dugaar deer -1, -1 --ig nmed 5 uldegteltei huwaagaad moriin dugaariig heweer uldeene matrix aas awna
#Herew Baganiin dugaar ijil baiwal moriin dugaar deer -1, -1-iig nemeed 5 uldegteltei huwaagaad baganiin dugaariig heweer uldeene matrix aas awna
#deerh 2 nohtsol bielehgui baiwal 2 usgiin uusgej baigaa tegsh ontsogtiin nogoo dioganaliin 2 uzuuriin usgiig matrix aas awc hewlene
def decrypt(): #decryption
    msg=str(input("ENTER CIPHER TEXT:"))
    msg=msg.upper()
    msg=msg.replace(" ", "")
    print("PLAIN TEXT:",end=' ')
    i=0
    while i<len(msg):
        loc=list()
        loc=locindex(msg[i])
        loc1=list()
        loc1=locindex(msg[i+1])
        if loc[1]==loc1[1]:
            print("{}{}".format(my_matrix[(loc[0]-1)%5][loc[1]],my_matrix[(loc1[0]-1)%5][loc1[1]]),end=' ')
        elif loc[0]==loc1[0]:
            print("{}{}".format(my_matrix[loc[0]][(loc[1]-1)%5],my_matrix[loc1[0]][(loc1[1]-1)%5]),end=' ')
        else:
            print("{}{}".format(my_matrix[loc[0]][loc1[1]],my_matrix[loc1[0]][loc[1]]),end=' ')
        i=i+2

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