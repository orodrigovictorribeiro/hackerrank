#!/usr/bin/python3

import sys
print ("Type a number")
n = int(input().strip())
isEven = n%2==0

if isEven and (n in range(2,6) or n > 20 ):
    print ("Not ", end="")

print ("Weird")