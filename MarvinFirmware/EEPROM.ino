
void SaveValues() {
  EEPROM.writeDouble(30, Prop);
  EEPROM.writeDouble(40, Dif);
  EEPROM.writeDouble(50, Int);
  EEPROM.writeDouble(60, Kalman);
  EEPROM.writeDouble(70, PosDif);
  EEPROM.writeDouble(80, PosProp);
  Serial.println ("Values Stored!");
}

void GetValues() {
  Prop = EEPROM.readDouble(30);
  Dif = EEPROM.readDouble(40);
  Int = EEPROM.readDouble(50);
  Kalman = EEPROM.readDouble(60);
  PosDif = EEPROM.readDouble(70);
  PosProp = EEPROM.readDouble(80);
}

void SaveCalibrationValues() {
  EEPROM.writeDouble(90, leftMotorScalerFwd);
  EEPROM.writeDouble(100, rightMotorScalerFwd);
  EEPROM.writeDouble(110, minSpeedRight);
  EEPROM.writeDouble(120, minSpeedLeft);
}

void GetCalibrationValues(){
  leftMotorScalerFwd = EEPROM.readDouble(90);
  rightMotorScalerFwd = EEPROM.readDouble(100);
  minSpeedRight = EEPROM.readDouble(110);
  minSpeedLeft = EEPROM.readDouble(120);

}
