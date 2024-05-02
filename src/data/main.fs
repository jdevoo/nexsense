\ *********************************************************************
\ Filename:      main.fs
\ MCU:           ESP32 all models
\ Forth:         ESP32forth 7.0.7.19
\ *********************************************************************

DEFINED? --sense [if] forget --sense [then]
create --sense

s" /spiffs/sense.fs"    included
s" /spiffs/config.fs"   included
s" /spiffs/tests.fs"    included

