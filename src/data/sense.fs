\ *********************************************************************
\ Filename:      sense.fs
\ MCU:           ESP32 all models
\ Forth:         ESP32forth 7.0.7.19
\ *********************************************************************

: sense.init ( -- ? )
    [ wire ]
    SENSE_SDA SENSE_SCL wire.begin
    [ forth ]
    dup 0 <> if drop else exit then
    BME688_I2C_ADDRESS 1 bme688_begin
  ;

