
while True:    
    try:    
        score = float(input('Ta GPA oruulna uu(zogsooh: -1): '))

        if score == -1:
            break

        if 0 <= score and score <= 4.0:
            if 4 == score:
                print('A')
            elif 3.7 <= score:
                print('A-')
            elif 3.4 <= score:
                print('B+')
            elif 3.0 <= score:
                print('B')
            elif 2.7 <= score:
                print('B-')
            elif 2.4 <= score:
                print('C+')
            elif 2.0 <= score:
                print('C')
            elif 1.7 <= score:
                print('C-')
            elif 1.3 <= score:
                print('D+')
            elif 1.0 <= score:
                print('D')
            elif 0.7 <= score:
                print('D-')
            else:
                print('F')
        else:
            print('0 <= score <= 4')
    except:
        print('Buruu utga oruulsan baina')
