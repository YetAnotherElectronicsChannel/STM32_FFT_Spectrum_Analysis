# STM32_FFT_Spectrum_Analysis

I realized an 10-band audio spectrum analyzer on the STM32 with an externally connected I2S audio ADC. 
The spectrum data is sent via a UART connection to a computer, where the spectrum can be monitored with a C# based windows tool. With a little bit of reworking the code, the spectrum data can be also shown on small LCD screens like ILI9341 or even on WS2812 LEDs.

Watch my YouTube video where I have explained everything in detail including some tests with tone generator and music: https://youtu.be/3WF4CGKoMas
