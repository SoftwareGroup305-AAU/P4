@echo off
setlocal

set GCC_PATH=c:\Users\Emil\AppData\Local\Arduino15\packages\arduino\tools\arm-none-eabi-gcc\7-2017q4\bin
set CORE_PATH=C:\Users\Emil\AppData\Local\Temp\arduino\cores\arduino_samd_mkrwifi1010_ec4dc2770817a483d95ed3f1b705ee79
set CMSIS_LIB_PATH=C:\Users\Emil\AppData\Local\Arduino15\packages\arduino\tools\CMSIS\4.5.0\CMSIS\Lib\GCC
set VARIANT_PATH=C:\Users\Emil\AppData\Local\Arduino15\packages\arduino\hardware\samd\1.8.14\variants\mkrwifi1010

echo Assembling the assembly file...
%GCC_PATH%\arm-none-eabi-as.exe -mcpu=cortex-m0plus -mthumb -o test.o test.s

echo Compiling and linking...
%GCC_PATH%\arm-none-eabi-gcc.exe -Os --specs=nano.specs --specs=nosys.specs -mcpu=cortex-m0plus -mthumb -T"%VARIANT_PATH%\linker_scripts\gcc\flash_with_bootloader.ld" "-Wl,--gc-sections,-Map,output.map" -o test.elf test.o -L"%CMSIS_LIB_PATH%" -larm_cortexM0l_math -lm "%CORE_PATH%\core.a"

echo Generating binary and hex files...
%GCC_PATH%\arm-none-eabi-objcopy -O binary test.elf test.bin
%GCC_PATH%\arm-none-eabi-objcopy -O ihex test.elf test.hex

echo Done.
pause
endlocal
