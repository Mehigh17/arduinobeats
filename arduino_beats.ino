float incValue = 0;

void setup() {
  pinMode(2,OUTPUT);
  
  Serial.begin(9600);
}

/*
 * we're doing a 4.2.1.2.4 division to make a triangle like lighting, but you can handle this 
 * however you want, just use incValue then multiply by 255 in order to control voltage
 * 
 * incValue range is between the threshold set inside the ArduinoBeats software and 1. (threshold, 1)
 * The software automatically send 0 float when the ports are closed.
 */
void loop() {
  if (Serial.available() > 0) {
    incValue = Serial.parseFloat();
    analogWrite(2, incValue * 255 / 4);
    analogWrite(3, incValue * 255 / 2);
    analogWrite(4, incValue * 255);
    analogWrite(5, incValue * 255 / 2);
    analogWrite(6, incValue * 255 / 4);
  }
}
