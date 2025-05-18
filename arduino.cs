int led = 12;
char* state;

// the setup routine runs once when you press reset:
void setup() {
  Serial.begin(9600);
  pinMode(led, OUTPUT);
}

// the loop routine runs over and over again forever:
void loop() {
  if (Serial.available()) {
    Serial.readBytes(state, 1);
    
    if (state == "1")
      digitalWrite(led, HIGH);
    if (state == "0")
      digitalWrite(led, LOW);
    else {
      Serial.println(state);
    }
  }
}