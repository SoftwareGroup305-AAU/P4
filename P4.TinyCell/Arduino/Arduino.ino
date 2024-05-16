#include <Arduino.h>

byte led = 6;
void setup()
{
	Serial.begin(9600);
	pinMode(led, OUTPUT);
}
void loop()
{
	Serial.println("nydelig dame");
	digitalWrite(led, HIGH);
	delay(500);
	digitalWrite(led, LOW);
	delay(500);
}
