const int BUZZ = 3;
const int BTN = 8;
void setup(){
  pinMode(BUZZ, OUTPUT);
  pinMode(BTN, INPUT_PULLUP);
  
}
void loop(){
int buttonState = digitalRead(BTN);
  if(buttonState == LOW){
  tone(BUZZ, 440, 1000);
  delay(999);
  tone(BUZZ, 500, 1000);
  delay(999);
  }
  else{
    digitalWrite(BUZZ, LOW);
  }
}
