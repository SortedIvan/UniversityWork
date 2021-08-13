//Arduino safe - Ivan Ovcharov PCB-02, STUDENT NUMBER: 4090993;
#include <DHT11.h>
#include <Display.h>
#include <TM1637Display.h>

const int RED_LED = 4;
const int GREEN_LED = 5;
const int BLUE_LED = 6;
const int YELLOW_LED = 7;
const int BTN1 = 9;
const int BTN2 = 8;
const int LDR = 16;
const int BUZZ = 3;
const int POT = A0;
const int password = 4242; //Password to open the safe;
const int upThreshhold = 60;
const int lowThreshhold = 57;


int errorCount = 0; //Counts how many error attempts the user makes;
int buttonState1 = HIGH; // All of the button states used for the mechanism; 
int buttonState2 = HIGH;
int lastButtonState1 = HIGH;
int lastButtonState2 = HIGH;
int number = 1; //1,2,3,4;
int digitPos = 0; //Position of the digit/cell;
int passwordTemp = 0; //Temporary password that is compared to the actual one later on
int num1, num2, num3, num4; // The 4 Password numbers;
int potSafe = analogRead(POT);

void setup() {
  Serial.begin(9600);
  pinMode(RED_LED, OUTPUT);
  pinMode(GREEN_LED, OUTPUT);
  pinMode(BLUE_LED, OUTPUT);
  pinMode(YELLOW_LED, OUTPUT);
  pinMode(BTN1, INPUT_PULLUP);
  pinMode(BTN2, INPUT_PULLUP);
  pinMode(LDR, INPUT);
  pinMode(POT, INPUT);
  Display.clear();

}

void loop() {
  buttonState1 = digitalRead(BTN1);
  buttonState2 = digitalRead(BTN2);
  int passwordChange = map(potSafe, 0, 1023, 0, 100);
  int brightnessCheck = analogRead(LDR); // 300 is bright, 50 is dark; 

  if(brightnessCheck > upThreshhold){                  //To initiate the safe, the user must cover the LDR sensor (must be below 60);
    Serial.println("The safe isn't working - cover the LDR switch!");   
    digitalWrite(YELLOW_LED, HIGH);
  }
  else if(brightnessCheck < 80){
    digitalWrite(YELLOW_LED, LOW);
    Serial.println("The safe is locked! Type in the password");
  if(buttonState2 !=lastButtonState2){
    if(buttonState2 == LOW){
      delay(100);
      digitPos++;
    }
    lastButtonState2 = buttonState2;
  }
  if(buttonState1 != lastButtonState1){ //This can be done using the modulo operator//
    if(buttonState1 == LOW){            //if(buttonState1 == LOW){
      delay(100);                       //{ if(number % 4 !=0){
      number++;                         //  number++;
    }                                   //}
    lastButtonState1 = buttonState1;
  }
  if(number > 4){
    number = 1;
  }
  if(digitPos == 0){
    Display.showCharAt(digitPos, '0' + number);
    
    num1 = number * 1000;
    
    
    
  }
  if(digitPos == 1){
    Display.showCharAt(digitPos, '0' + number);
    
     num2 = number * 100;
    
  }
  if(digitPos == 2){
    Display.showCharAt(digitPos, '0' + number);
    
     num3 = number * 10;
    
  }
  if(digitPos == 3){
    Display.showCharAt(digitPos, '0' + number);
   
     num4 = number;
    
    passwordTemp = num1+num2+num3+num4;
  }
  if(passwordTemp == password && digitPos == 4){ // The user enters the password correctly, the safe opens and automatically closes after 2 seconds. 
    Serial.println("The safe has been opened!"); // The user now must hold the switch again to begin the sequence once more.
    digitalWrite(GREEN_LED, HIGH);
    delay(5000);
    tone(BUZZ, 800, 200);
    delay(100);
    noTone(BUZZ);
    Display.show("OPEN");
    digitalWrite(GREEN_LED, LOW);
    digitalWrite(YELLOW_LED, HIGH);
    delay(2000);
    Display.show("5");
    delay(1000);
     Display.show("4");
    delay(1000);
     Display.show("3");
    delay(1000);
     Display.show("2");
    delay(1000);
     Display.show("1");
    delay(1000);
    Display.show("CLSd");
    delay(1000);
    digitalWrite(YELLOW_LED, LOW);
    Display.clear();
    digitPos = 0;
  }else if(passwordTemp != password && digitPos == 4){ //The user gets the password wrong, display shows "Errr", resets after 2 seconds.
    digitalWrite(RED_LED, HIGH);
    Display.show("Errr");
    delay(2000);
    digitalWrite(RED_LED, LOW);
    Display.clear();
    digitPos = 0;
    errorCount++;
  }
if(errorCount >= 3){          //User entered the wrong password 3 times;
  digitalWrite(RED_LED, HIGH);
  Display.show("UHOH");          
  tone(BUZZ, 100, 200);
  delay(200);       
  noTone(BUZZ);     
  delay(5000);
  digitalWrite(RED_LED, LOW);
  errorCount = 0;
  digitPos = 0;
  Display.clear();
}
  }  
}
