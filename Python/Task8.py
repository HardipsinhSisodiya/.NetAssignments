print("Enter string value")
string=input()
a=string.split(' ')
number=len(a)
for item in range(number-1,-1,-1):
    print(a[item]+" ",end="")
    