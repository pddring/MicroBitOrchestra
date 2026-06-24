# Imports go at the top
from microbit import *
import radio
radio.on()

# Code in a 'while True:' loop repeats forever
while True:
    display.clear()
    
    # Play the hi hat if you press the A button
    if button_a.was_pressed():
        display.show("H")
        radio.send("42 10")

    # Play the snare if you press the B button
    if button_b.was_pressed():
        display.show("S")
        radio.send("40 10")
    sleep(100)


# Challenges:
# 1) Replace the numbers with your own percussive instruments: 
# https://musescore.org/sites/musescore.org/files/General%20MIDI%20Standard%20Percussion%20Set%20Key%20Map.pdf
