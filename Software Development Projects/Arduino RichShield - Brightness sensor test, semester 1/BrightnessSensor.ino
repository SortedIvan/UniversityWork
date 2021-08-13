const int LDR = 16;
const int darkValue = 300;
const int brightValue = 700;
void setup() {
 Serial.begin(9600);
 pinMode(LDR, INPUT);
}

void loop() {
 int valueLight = analogRead(LDR);
 if(valueLight < darkValue){
  Serial.println("It's dark");
 }
else if(valueLight > brightValue){
  Serial.println("It's bright");
}




 
}
