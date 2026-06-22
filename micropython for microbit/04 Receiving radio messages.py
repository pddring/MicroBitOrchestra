# Imports go at the top
from microbit import *
import radio
radio.on()

# Code in a 'while True:' loop repeats forever
while True:
    # Show a line at the bottom of the screen to show it's listening
    display.show(Image("00000:00000:00000:00000:99999"))

    # message will be None if nothing has been received
    message = radio.receive()

    # display any received data on the REPL
    if message != None:
        print(message)
        display.show(Image("00900:99999:09990:00900:99999"))
    sleep(50)


# Teacher instructions
# 1) Flash this on a microbit connected to the teacher PC
# 2) Show the REPL (using WebUSB or in Mu/Thonny)
# 3) Get students to send messages and see them appear