OpenTK for Raspberry Pi
=======================

This fork is speficially to get OpenTK working on the raspberry pi device. The Pi is a linux based system which 
supports OpenGLES 2.0. Modifications need to be made to OpenTK to get it to work correctly. 

Examples
--------

In the Source\Examples\OpenGLES folder a new project has been added called RaspberryPi, this is the test project.
There is a solution in it which already references the OpenTK project. It also has an implementation for an
OpenGLES 2.0 window. This project will work on windows if you download an OpenGlES 2.0 emulator such as 

[opengl-es-20-emulator](http://www.malideveloper.com/opengl-es-20-emulator.php)

Place the libEGL.dll and libGLESv2.dll in the bin\Debug directory and run the app, it should create a windows with a Red 
background. 

Contributing
------------

If you want to help out just message me and I will grant you access to this repo, or fork the repo yourself.