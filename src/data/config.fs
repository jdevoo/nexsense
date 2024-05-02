\ *********************************************************************
\ Filename:      config.fs
\ MCU:           ESP32 all models
\ Forth:         ESP32forth 7.0.6.19
\ *********************************************************************

\ I2C addresses
$77 constant BME688_I2C_ADDRESS
$39 constant APDS9960_I2C_ADDRESS
$68 constant PCF8523_I2C_ADDRESS

\ BME688 variant ID macros
2 constant BME680_OS_2X
3 constant BME680_OS_4X
4 constant BME680_OS_8X
2 constant BME680_FILTER_SIZE_3
