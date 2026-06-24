# MidiMicrobitOrchestra

<img width="848" height="477" alt="image" src="https://github.com/user-attachments/assets/9c481e43-9168-4423-86d0-742928da4117" />


This repository contains all the code and resources for the Hack-a-Tune workshop for the Festival of Computing 2026 exploring the links between music, code, networking and cyber security.

The idea is for a class full of students to each code a micro:bit which sends radio messages to collaboratively play a song on a MIDI keyboard.

I've tried it with UK Y7 (age 11) to Y13 (age 17) with differing levels of depth and pace but it's mostly aimed at Y9 students as part of a topic on physical computing.

## Hardware:

- Required: At least 2 micro:bits (one for the teacher and idealy one each for everyone else)
- Optional: A musical keyboard with MIDI over USB is really useful but you can use the software synth built into Windows


## Folder structure:

| Folder | Description |
| --- | --- |
| C#  | WinForms app to connect a teacher micro:bit to a MIDI keyboard |
| micropython for microbit | Example code for micro:bits |

## Instructions

- Plug in one micro:bit to the teacher computer.
- Open this code: [04 Receiving radio messages.py](https://github.com/pddring/MicroBitOrchestra/blob/master/micropython%20for%20microbit/04%20Receiving%20radio%20messages.py) in the [python microbit editor](https://python.microbit.org/v/3) and flash it to the teacher micro:bit
- (Optional) Plug in your MIDI keyboard
- Open the Midi Microbit Orchestra App:

<img width="1379" height="469" alt="image" src="https://github.com/user-attachments/assets/71ba3b51-abe0-4130-8c7c-05f5354e051c" />

- Select your MIDI keyboard (or the software synth) and press Connect
- Pressing the Test button should now play a key on your keyboard (or software synth)
- Switch to the Microbit Settings tab. If a micro:bit is connected you should see a COM port listed:

<img width="1379" height="469" alt="image" src="https://github.com/user-attachments/assets/97e120d0-e07c-47e8-8a50-fc47dfee622f" />

- Select the COM port and press Connect in order to start listening to radio messages that the microbit receives
- Get students to send radio messages using their own micro:bits [example code with challenges here](https://github.com/pddring/MicroBitOrchestra/tree/master/micropython%20for%20microbit)
- Any messages they send should appear in the Messages tab

## Message filter rules
The rules tab lets you define rules to allow or block radio messages based on the message contents:
<img width="1379" height="469" alt="image" src="https://github.com/user-attachments/assets/534c9af5-5aae-4301-b6aa-4623e60687cf" />
The rule editor on the left lets you write your own rules using regular expressions. 
Any valid rule will be shown on the right. Any invalid rule will just be ignored
Rules are implemented from top to bottom (lower rules override higher rules)
By default all messages are allowed (nothing is blocked)

### Rule syntax
Rules which start with `allow` or `+` will allow any message that matches the regular expression on the rest of that line
Rules which start with `block` or `-` will block any message that matches the regular expression on the rest of that line

### Examples:
#### 1: Blocking everything
```
block .
```
This blocks every message because the `.` character in a regex matches any character


#### 2: Blocking a message containing a banned phrase
```
block DoS
```
This will block any message that contains the string DoS (Denial of Service), including "This is not a DoS, honest!"

#### 3: Blocking an exact message
```
block ^DoS$
```
This will only block messages that contain "DoS" and nothing else (`^` matches the beginning of a string and `$` matches the end)

#### 4: Only allowing messages containing a number
```
block .
allow \d
```
This will block any message (line 1) unless it contains a numerical digit (line 2: `\d` represents any character between `0` and `9`)
Note - this will allow any message that contains a number anywhere in that message: e.g. `Hello 32!`

#### 5: Only allowing exactly two numbers
```
block .
allow ^\d+\s+\d+$
```
This will block all messages unless they contain exactly two numbers separated by one or more character of whitespace

Find out more about [regular expressions here](https://regex101.com/)
