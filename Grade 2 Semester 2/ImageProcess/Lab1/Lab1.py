#random-oor too ogohod hereglegdene
import random
#arr--iin niilberiin olood urt huwaaj urtiig ni olno
def average(arr):
    return sum(arr) / len(arr)
#arr-iig osohoor erembeleed urt ni tegsh bol goliin 2 elementiin niilberiin dundajiig butsaana
#songoi bol goliin elementiig butsaana
def median(arr1):
    arr1 = sorted(arr)
    n = len(arr1)
    if n % 2:
        return int(arr1[n // 2] + arr1[n // 2]) // 2
    else:
        return int(arr1[n // 2])
#endees program ehelne
#garaas x, y 2 buhel too awna
x = int(input())
y = int(input())
#arr-iig list eer uusgene
arr = list()
#garaas oruulsan x-iin urtaar arr-d randomoor 0-ees 10-iin hoorond buhel too olgono

for i in range(x):
    arr.insert(i, random.randint(0, 10))

print(arr)
#garaas neg too awna
temp = int(input())
#tooluuraa noillono
cnt = 0
#arr listed garaas oruulsan too taaraldah ym bol tooluuriig negeer nemne
for i in arr:
    if i == temp:
        cnt += 1

print(cnt)