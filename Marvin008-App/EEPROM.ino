
void SaveValues(){
  EEPROM.writeDouble(30,Prop);
  EEPROM.writeDouble(40,Dif);
  EEPROM.writeDouble(50,Int);
  Serial.println ("Values Stored!");  
}

void GetValues(){
  Prop = EEPROM.readDouble(30);
  Dif = EEPROM.readDouble(40);
  Int = EEPROM.readDouble(50);
  }
  
