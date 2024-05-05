\ *********************************************************************
\ Filename:      tests.fs
\ MCU:           ESP32 all models
\ Forth:         ESP32forth 7.0.7.19
\ *********************************************************************

\ UNIT TESTS
s" /spiffs/assert.fs" included

\ test SENSE initialized
assert( sense.init 0 <> )


\ END OF UNIT TESTS

