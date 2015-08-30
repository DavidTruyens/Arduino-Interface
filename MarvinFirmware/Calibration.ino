void calibrateMotor() {
  
  Serial.println(F("Put the robot so the wheels can move freely and then send any character to start the motor calibration routine"));
  while (Serial.read() == -1);

  Serial.println(F("Estimating minimum starting value. When the first two values do not change anymore, then send any character to continue\r\n"));
  delay(2000);
  double leftSpeed = 10, rightSpeed = 10;
  testMotorSpeed(&leftSpeed, &rightSpeed, 1, 1);

  Serial.print(F("\r\nThe speed values are (L/R): "));
  Serial.print(leftSpeed);
  Serial.print(F(","));
  Serial.println(rightSpeed);

  if (leftSpeed > rightSpeed) { // This means that the left motor needed a higher PWM signal before it rotated at the same speed
    leftMotorScalerFwd = 1;
    rightMotorScalerFwd = rightSpeed / leftSpeed; // Therefore we will scale the right motor a bit down, so they match
  } else { // And the same goes for the right motor
    leftMotorScalerFwd = leftSpeed / rightSpeed;
    rightMotorScalerFwd = 1;
  }

  Serial.print(F("The motor scalars are now (L/R): "));
  Serial.print(leftMotorScalerFwd);
  Serial.print(F(","));
  Serial.println(rightMotorScalerFwd);

  Serial.println(F("Now the motors will spin up again. Now the speed values should be almost equal. Send any character to exit\r\n"));
  delay(2000);
  leftSpeed = rightSpeed = 10; // Reset speed values
  testMotorSpeed(&leftSpeed, &rightSpeed, leftMotorScalerFwd, rightMotorScalerFwd);

  double maxSpeed = max(leftSpeed, rightSpeed);
  double minSpeed = min(leftSpeed, rightSpeed);

  Serial.print(F("The difference is now: "));
  Serial.print((maxSpeed - minSpeed) / maxSpeed * 100);
  Serial.println("%");

  SaveCalibrationValues();
  calibrateMotors = false;
  Serial.println(F("Calibration of the motors is done"));
}

void testMotorSpeed(double *leftSpeed, double *rightSpeed, double leftScaler, double rightScaler) {
  EncoderReading();
  int32_t lastLeftPosition = positionLeft;
  int32_t lastRightPosition = positionRight;

  Serial.println(F("Velocity (L), Velocity (R), Speed value (L), Speed value (R)"));

  while (Serial.read() == -1) {
    EncoderReading();
    double LeftSpeedScaled = (*leftSpeed) * leftScaler;
    double RightSpeedScaled = (*rightSpeed) * rightScaler;
    md.setM1Speed (RightSpeedScaled);
    md.setM2Speed (LeftSpeedScaled);
    
    int32_t leftPosition = positionLeft;
    int32_t leftVelocity = leftPosition - lastLeftPosition;
    lastLeftPosition = leftPosition;

    int32_t rightPosition = positionRight;
    int32_t rightVelocity = rightPosition - lastRightPosition;
    lastRightPosition = rightPosition;

    Serial.print(leftVelocity);
    Serial.print(F(","));
    Serial.print(rightVelocity);
    Serial.print(F(","));
    Serial.print(*leftSpeed);
    Serial.print(F(","));
    Serial.println(*rightSpeed);

    if (abs(leftVelocity) < 200)
      (*leftSpeed) += 0.1;
    else if (abs(leftVelocity) > 203)
      (*leftSpeed) -= 0.1;

    if (abs(rightVelocity) < 200)
      (*rightSpeed) += 0.1;
    else if (abs(rightVelocity) > 203)
      (*rightSpeed) -= 0.1;

    delay(100);
  }
  for (double i = *leftSpeed; i > 0; i--) { // Stop motors gently
    md.setM1Speed(i);
    md.setM2Speed(i);
    delay(50);
  }
  md.setM1Speed(0);
  md.setM2Speed(0);
}

