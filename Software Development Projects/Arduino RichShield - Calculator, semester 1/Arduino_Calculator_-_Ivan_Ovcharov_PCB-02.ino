#include <DHT11.h>
#include <Display.h>
#include <TM1637Display.h>

const int BTN = 8;
const int RED = 4;
const int GREEN = 5;
const int BLUE = 6;
const int YELLOW = 7;
const int POT = A0;
int modeCalc = -1;
int FirstNumber = 0; //First value from the user
float SecondNumber = 0.0; //Float for the second number
String operatorInput; //Used to show a,s,t,d

int firstBtnState;
int lastBtnState = HIGH;
void setup() {
pinMode(BTN, INPUT_PULLUP);
pinMode(POT, INPUT);
pinMode(RED, OUTPUT);
pinMode(GREEN, OUTPUT);
pinMode(BLUE, OUTPUT);
Serial.begin(9600);
Display.off();
}

void loop() {
int valuePot = analogRead(POT);
int numberMap = map(valuePot, 0, 1023, -10, 10); //The display has imperfections when the value shown on it is 10.
int operatorMap = map(valuePot, 0, 1023, 0, 100);
  firstBtnState = digitalRead(BTN);
  if(lastBtnState != firstBtnState){
    if(firstBtnState == LOW){
      modeCalc++;
      delay(100);
    }
    else{

      Serial.println("Disabled");
    }
    lastBtnState = firstBtnState;
  }
  if(modeCalc == 0){
    digitalWrite(RED, HIGH);
    digitalWrite(GREEN, HIGH);
    digitalWrite(BLUE, HIGH);
    digitalWrite(YELLOW, HIGH);
    Display.on();
    Display.show("----");
    delay(2000);
    digitalWrite(RED, LOW);
    digitalWrite(GREEN, LOW);
    digitalWrite(BLUE, LOW);
    digitalWrite(YELLOW, LOW);
    Display.off();
    modeCalc++;
  }
  if(modeCalc == 1){
    digitalWrite(BLUE, HIGH);
    Display.on();
    Display.show(numberMap);
    FirstNumber = numberMap;
  }
  else if (modeCalc == 2){
    if(operatorMap <= 25){
      Display.show("a");
      operatorInput = "+";
     }
  else if(operatorMap > 25 && operatorMap <= 50){
    Display.show("s");
    operatorInput = "-";
  }
  else if(operatorMap > 50 && operatorMap <=75){
    Display.show("t");
    operatorInput = "*";
  }
  else if(operatorMap > 75 && operatorMap <=100){
    Display.show("d");
    operatorInput = "/";
  }
 }
if(modeCalc == 3){
    Display.show(numberMap);
    SecondNumber = numberMap;
}

if(modeCalc == 4){//Result mode
  digitalWrite(BLUE,LOW);
  digitalWrite(GREEN,HIGH);
  float resultCalculation = 0;
  if(operatorInput == "+"){
    resultCalculation = FirstNumber + SecondNumber;
    Display.show(resultCalculation);   
  }
  else if(operatorInput == "-"){
    resultCalculation = FirstNumber - SecondNumber;
    Display.show(resultCalculation);
  }
  else if(operatorInput == "*"){
    resultCalculation = FirstNumber * SecondNumber;
    Display.show(resultCalculation);
  }
  else if(operatorInput == "/"){
    resultCalculation = FirstNumber / SecondNumber;
    Display.show(resultCalculation);
    
  }
 
}
}
