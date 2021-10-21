print("Enter a string")
string=input()
SortedString=sorted(string)
S1=""
NewSortedString="".join(SortedString)
for item in NewSortedString:
    if(item=="1"or item=="2"or item=="3"or item=="4"or item=="5"or item=="6"or item=="7"or item=="8"or item=="9"or item=="0"):
        S1=S1+item
    else:
        print(item,end="")
print(S1,end="")