GRBL Depth Probe  
----------  
this is an application to use the new probing feature of GRBL 0.9 edge (G38.2)  
  
So far I never had any issues with it, but you are responsible on your own if this software should cause any damage.  
  
To run the application, just go to /GRBLDepthProbe/bin/Debug and download GRBLDepthProbe.exe, it is a standalone executable, so you won't need any other files.  
  
The UI is very much like a setup wizard, it should guide you through the process.  

When you've entered all the settings, make sure you have set your ZERO position appropriately, then click 'RUN'  
a new window will open and it will show realtime data as it arrives from GRBL.  
if you want to look at the protocol, use cmd to start the executable, all traffic will show up in the command line.  
  
  
feel free to use and improve the code, have fun!