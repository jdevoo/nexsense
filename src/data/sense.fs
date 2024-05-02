\ *********************************************************************
\ Filename:      sense.fs
\ MCU:           ESP32 all models
\ Forth:         ESP32forth 7.0.7.19
\ *********************************************************************

\ set SDA and SCL pins for Wire
21 constant SENSE_SDA
22 constant SENSE_SCL

: sense.init ( -- )
    [ wire ]
    SENSE_SDA SENSE_SCL wire.begin
    [ forth ]
    0= if
        ." SENSE Wire initialisation error"
    then
  ;

: sense.test ( addr n -- )
    [ wire ]
    -1 wire.requestFrom 0 > 
    if 
        wire.available 
        0 do 
            wire.Read .
        loop 
    then 
    [ forth ]
  ;

