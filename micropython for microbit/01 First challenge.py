# Imports go at the top
from microbit import *


# Code in a 'while True:' loop repeats forever
while True:
    display.show(Image.HEART)
    sleep(1000)
    display.scroll('Hello')

# Challenges:
# 1) Replace 'Hello' with your own positive, inspiring quote
# 2) Change the heart image to anything else
# 3) Make the text scroll more quickly