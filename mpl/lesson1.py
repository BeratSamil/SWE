import random

def the_biggest(a,b,c):
    if a>=b:
        m=a
    else:
        m=b
    if m<=c:
        m=c
    return m


# print(the_biggest(120,50,600))

def the_smallest(a,b,c):
    if a<=b:
        m=a
    else:
        m=b
    if m>=c:
        m=c
    return m


#print(the_smallest(120,1,600))


a=random.randint(1,1000)
b=random.randint(1,1000)
c=random.randint(1,1000)
print(the_smallest(a,b,c))
print(x)