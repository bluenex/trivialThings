import serial.tools.list_ports
import numpy as np

portall=(list(serial.tools.list_ports.comports()))
port=0
portser='COM0'

for i in range(0,np.size(portall,0)):
   print portall[i]
   if portall[i][1][:15]=='USB Serial Port':
       print "USB2dy",portall[i][0]
       port= int(portall[i][0][3:])
   if portall[i][1][:7]=='Arduino':
       comardui=portall[i][0]
       print "arduino",portall[i][0]
       portser=portall[i][0]
