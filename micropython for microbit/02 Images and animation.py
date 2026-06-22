# Imports go at the top
from microbit import *

# Code in a 'while True:' loop repeats forever
while True:
    display.show(Image.HEART)
    
    # show a play icon if you press button A
    if button_a.was_pressed():
        display.show(Image("09000:09900:09090:09900:09000"))
    
    sleep(500)


# Challenges
# 1) Fill in the dot in the middle of the play icon
# 2) Make a different image appear when you press the B button
# 3) Animate the play icon so it moves across the screen