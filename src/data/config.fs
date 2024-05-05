\ *********************************************************************
\ Filename:      config.fs
\ MCU:           ESP32 all models
\ Forth:         ESP32forth 7.0.6.19
\ *********************************************************************

\ set SDA and SCL pins for Wire
21 constant SENSE_SDA
22 constant SENSE_SCL

\ I2C addresses
$77 constant BME688_I2C_ADDRESS
$39 constant APDS9960_I2C_ADDRESS
$68 constant PCF8523_I2C_ADDRESS

