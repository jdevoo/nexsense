\ *********************************************************************
\ Filename:      autoexec.fs
\ MCU:           ESP32 all models
\ Forth:         ESP32forth 7.0.7.19
\ *********************************************************************

: MAIN
    s" /spiffs/main.fs" included
  ;
