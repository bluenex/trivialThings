import sys
sys.path.insert(0, 'D:/tulfolder/LocalProjects/gyropygame/src')

import motorControlClass as mc

# connection
port = 5
baudrate = 34
# position
center = 2048
# speed
slow = 100
medium = 250
fast = 400

# connect to motor
dxl1 = mc.DynamixelMotor(1, port, baudrate, center)
# dxl2 = DynamixelMotor(2, port, baudrate, center)
# dxl3 = DynamixelMotor(3, port, baudrate, center)


a = 0.5
while (a != 0):
    a = input("0 to stop, position: ")
    if(a > 0):
        dxl1.DrivePosition(a, slow)

# print dynamixelScan(port, baudrate, 5)
