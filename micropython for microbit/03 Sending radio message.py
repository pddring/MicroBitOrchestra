# Imports go at the top
from microbit import *
import radio
radio.on()

# Code in a 'while True:' loop repeats forever
while True:
    display.clear()
    
    # show a play icon if you press button A
    if button_a.was_pressed():
        display.show(Image("09000:09900:09090:09900:09000"))
        radio.send("You are worth infinitely more than your exam results")
    sleep(500)


# Challenges
# 1) Send a different message when you press the B button
# 2) Change the play icon to a radio icon
# 3) Animate the radio icon so it looks like it's sending