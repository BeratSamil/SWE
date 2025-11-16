'''

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

'''

import random
import math
ctr=0
n=10000000
for i in range (n):
    x = random.random()
    y = random.random()
    #print(x,y)
    if (x>=0 and x<=1 and y>=0 and y<= math.sqrt(1-x*x)):
        ctr+=1

print(ctr)
pi=4*ctr/n
print(pi)











