#include <Adafruit_BME680.h>

Adafruit_BME680 bme; // I2C

#define USER_WORDS \
  Y(bme688_begin, n0 = bme.begin(n1, n0); NIP) \
  X("bme688_temperature_oversampling!", bme688_temperature_oversampling_bang, n0 = bme.setTemperatureOversampling(n0); NIP) \
  X("bme688_humidity_oversampling!", bme688_humidity_oversampling_bang, n0 = bme.setHumidityOversampling(n0); NIP) \
  X("bme688_pressure_oversampling!", bme688_pressure_oversampling_bang, n0 = bme.setPressureOversampling(n0); NIP) \
  X("bme688_iir_filter_size!", bme688_iir_filter_size_bang, n0 = bme.setIIRFilterSize(n0); NIP) \
  X("bme688_gas_heater!", bme688_gas_heater_bang, n0 = bme.setGasHeater(n1, n0); NIP) \
  Y(bme688_temperature, PUSH bme.readTemperature()) \
  Y(bme688_pressure, PUSH bme.readPressure()) \
  Y(bme688_humidity, PUSH bme.readHumidity()) \
  Y(bme688_gas, PUSH bme.readGas()) \
