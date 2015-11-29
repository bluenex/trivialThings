import sys
sys.path.insert(0, 'D:/tulfolder/LocalProjects/dllForUnity/dcPythonLib')

import dcAction as dc
import time

import threading

# connection
port = 'COM21'
baudrate = 115200
# define variables
stepping = 1 # sec
initPWM = 80
stepPWM = 10
targetPWM = 140
incomingPWM = 0

# connect to motor
dcMotor = dc.dcAction(port)

# start loop
while True:
    # get target speed
    while (incomingPWM < 80 or incomingPWM > 250):
        incomingPWM = input("enter target speed (80-250) or 0 to exit: ")
        #  check to break loop
        if (incomingPWM == 0):
            break
        print "Target Speed: " + str(incomingPWM)

    #  check to break loop
    if (incomingPWM == 0):
        break

    # start stepping
    start = time.time()
    while (initPWM != incomingPWM):
        if (time.time() - start > stepping):
            if (initPWM <= incomingPWM):
                dcMotor.WritePWM(initPWM)
                print "speed now: " + str(initPWM)
            else:
                dcMotor.WritePWM(incomingPWM)
                print "speed now: " + str(incomingPWM)
                break
            initPWM += stepPWM
            start = time.time()
    initPWM = 80
    incomingPWM = 0

dcMotor.Close()
