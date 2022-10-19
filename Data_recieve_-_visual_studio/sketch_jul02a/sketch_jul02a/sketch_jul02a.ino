int ledPin = 13;
void setup()
{
  pinMode(ledPin, OUTPUT);
  Serial.begin(9600);
}
void loop()
{
  char ch;
  while(Serial.available() > 0) 
  {
    ch = Serial.read();
    if (ch == '1')
    {
      digitalWrite(ledPin, HIGH);
    }
    else if (ch == '0')
    {
      digitalWrite(ledPin, LOW);
    }
  }
}
