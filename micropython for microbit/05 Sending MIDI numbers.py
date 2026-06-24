# Imports go at the top
from microbit import *
import radio
radio.on()

# Code in a 'while True:' loop repeats forever
while True:
    display.clear()
    
    # Send the number 76 if you press the A button
    if button_a.was_pressed():
        display.show(Image("09000:09900:09090:09900:09000"))
        radio.send("76")

    # Send the number 75 if you press the B button
    if button_b.was_pressed():
        display.show(Image("00090:00990:09090:00990:00090"))
        radio.send("75")
    sleep(500)


# Challenges:
# 1) Add your name before the numbers
# 2) Replace the numbers with your own MIDI note numbers
# 3) Explore the MIDI note numbers for Fur Elise: https://mayerwin.github.io/MIDI-Notes-Player/
