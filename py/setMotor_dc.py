import sys
sys.path.insert(0, 'D:/tulfolder/LocalProjects/dllForUnity/dcPythonLib')

import dcAction as dc
import time

# connection
port = 'COM21'
baudrate = 115200
# define variables
stepping = 1 # sec
initPWM = 70
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
            initPWM += stepPWM
            dcMotor.WritePWM(initPWM)
            time.sleep(stepping)
            print "speed now: " + str(initPWM)
            start = time.time()

    initPWM = 70
    incomingPWM = 0

dcMotor.Close()
