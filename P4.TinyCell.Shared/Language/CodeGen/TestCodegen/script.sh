#!/bin/sh

GCC_PATH="/Users/emilpriv/Library/Arduino15/packages/arduino/tools/arm-none-eabi-gcc/7-2017q4/bin"
CORE_PATH="/private/var/folders/nd/95n05jsj20g63nqfm1vz_vkm0000gn/T/arduino/cores/arduino_samd_mkrwifi1010_51b685d58ac095114e1a263ef8786823"
CMSIS_LIB_PATH="/Users/emilpriv/Library/Arduino15/packages/arduino/tools/CMSIS/4.5.0/CMSIS/Lib/GCC"
VARIANT_PATH="/Users/emilpriv/Library/Arduino15/packages/arduino/hardware/samd/1.8.14/variants/mkrwifi1010"

echo "Assembling the assembly file..."
$GCC_PATH/arm-none-eabi-as -mcpu=cortex-m0plus -mthumb -o test.o test.s

echo "Compiling and linking..."
$GCC_PATH/arm-none-eabi-gcc -Os --specs=nano.specs --specs=nosys.specs -mcpu=cortex-m0plus -mthumb -T"$VARIANT_PATH/linker_scripts/gcc/flash_with_bootloader.ld" "-Wl,--gc-sections,-Map,output.map" -o test.elf test.o -L"$CMSIS_LIB_PATH" -larm_cortexM0l_math -lm "$CORE_PATH/core.a"

echo "Generating binary and hex files..."
$GCC_PATH/arm-none-eabi-objcopy -O binary test.elf test.bin
$GCC_PATH/arm-none-eabi-objcopy -O ihex test.elf test.hex

echo "Done."