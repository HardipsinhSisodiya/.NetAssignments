string1="Hgfdgff"
string2="Si"
for item1 in range(len(string1)):
    print(string1[item1],end="")
    for item2 in range(len(string2)):
        if(item1==item2 and item1<len(string2)):
            print(string2[item1],end="")
        elif(item2>item1 and item1==len(string1)-1):
            print(string2[item2],end="")
        
        
            
        