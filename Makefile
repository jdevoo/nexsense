ARDUINO_CLI = /home/jdevoo/Downloads/arduino-ide_2.3.2_Linux_64bit/resources/app/lib/backend/resources/arduino-cli
MKSPIFFS = /home/jdevoo/.arduino15/packages/esp32/tools/mkspiffs/0.2.3/mkspiffs
ESPTOOL = /home/jdevoo/.arduino15/packages/esp32/tools/esptool_py/4.5.1/esptool.py
LIBS = /home/jdevoo/playground/arduino/libraries
SKETCH_HOME = /home/jdevoo/playground/arduino/ESP32forth
BUILD_HOME = $(SKETCH_HOME)/build/$(subst :,.,$(FQBN))
FQBN = esp32:esp32:esp32wroverkit
SKETCH_INO = $(SKETCH_HOME)/ESP32forth.ino
FORTH_SRC = $(shell find src/data -name '*.fs')
SPIFFS_BIN = $(BUILD_HOME)/ESP32forth.ino.spiffs.bin
SKETCH_BIN = $(BUILD_HOME)/ESP32forth.ino.bin

.PHONY: clean

$(SPIFFS_BIN): $(FORTH_SRC)
	$(MKSPIFFS) -c src/data -s 0x160000 $(SPIFFS_BIN)
	python3 $(ESPTOOL) --chip esp32 --before default_reset --after hard_reset \
		write_flash -z 0x290000 $(SPIFFS_BIN)
	touch $@
 
$(SKETCH_BIN): $(SKETCH_INO) $(SPIFFS_BIN) src/userwords.h
	$(ARDUINO_CLI) compile --fqbn $(FQBN) $(SKETCH_INO) \
	 	--board-options PartitionScheme=default,PSRAM=disabled \
		--libraries $(LIBS) \
		--export-binaries
	python3 $(ESPTOOL) --chip esp32 --before default_reset --after hard_reset \
	 	write_flash -z \
	 	0x1000 $(BUILD_HOME)/ESP32forth.ino.bootloader.bin \
	 	0x8000 $(BUILD_HOME)/ESP32forth.ino.partitions.bin \
	 	0x10000 $(SKETCH_BIN)
	touch $@

clean:
	rm -rf ${SKETCH_HOME}/build

all: $(SKETCH_BIN)
