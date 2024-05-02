\ *********************************************************************
\ Filename:      tests.fs
\ MCU:           ESP32 all models
\ Forth:         ESP32forth 7.0.7.19
\ *********************************************************************

\ UNIT TESTS
s" /spiffs/assert.fs" included

\ test SENSE I2C pins correctly initialized
assert( SENSE_SDA 21 = )
assert( SENSE_SCL 22 = )
\ END OF UNIT TESTS


