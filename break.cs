void readState() {
		char iState[2];

		while (SP->IsConnected()) {
			SP->ReadData(iState, 1);
			printf("%s", iState[0]);
		}
	}

 if (state[0] == '1') {
      digitalWrite(led, HIGH);
      Serial.println(state[0]);
    }
    if (state[0] == '0') {
      digitalWrite(led, LOW);
      Serial.println(state[0]);
    }

nt led = 12;
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


/// DO NOT USE ON SNARE