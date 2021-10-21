string="a5b2c1d3"
a=len(string)
for item in range(a):
    if(item%2==0):
        print(string[item]*int(string[item+1]),end="")
    