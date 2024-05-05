#include <Adafruit_BME680.h>

Adafruit_BME680 bme; // I2C

#define USER_WORDS \
  Y(bme688_begin, n0 = bme.begin(n1, n0); NIP) \
  Y(bme688_temperature, PUSH bme.readTemperature()) \
  Y(bme688_pressure, PUSH bme.readPressure()) \
  Y(bme688_humidity, PUSH bme.readHumidity()) \
  Y(bme688_gas, PUSH bme.readGas()) \
