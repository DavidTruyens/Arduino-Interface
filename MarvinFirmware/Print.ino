void PrintPIDValues(){
  Serial2.print("I");
  Serial2.println(Int,4);
  delay(100);
  Serial2.print("P");
  Serial2.println(Prop,4);
  delay(100);
  Serial2.print("D");
  Serial2.println(Dif,4);
  delay(100);
  Serial2.print("K");
  Serial2.println(Kalman,4);
  delay(100);
  Serial2.print("T");
  Serial2.println(PosProp,4);
  delay(100);
  Serial2.print("U");
  Serial2.println(PosDif,4);
  delay(100);
  Serial.print("P");
  Serial.println(Prop,4);
  Serial.print("D");
  Serial.println(Dif,4);
  Serial.print("I");
  Serial.println(Int,4);
  Serial.print("K");
  Serial.println(Kalman,4);
  Serial.print("T");
  Serial.println(PosProp,4);
  Serial.print("U");
  Serial.println(PosDif,4);
  }
    
void PrintApp(){
  Serial2.print(angleXJoy);
  Serial2.print(";");
  Serial2.print(angleYJoy);
  Serial2.print(";");
  Serial2.print(angle_y);
  Serial2.print(";");
  Serial2.print(angleSum);
  Serial2.print(";");
  Serial2.print(positionLeft);
  Serial2.print(";");
  Serial2.println(positionRight);
  Serial.println("Data printed");
}

void PrintData(){
       // Accelero
/*
Serial2.print(F("DEL:"));              //Delta T
Serial2.print(dt, DEC);
Serial2.print(F("#ACC:"));              //Accelerometer angle
Serial2.print(accel_angle_x, 2);
Serial2.print(F(","));
Serial2.print(accel_angle_y, 2);
Serial2.print(F(","));
Serial2.print(accel_angle_z, 2);
*/

      //Gyro

/*
Serial2.print(" Unfiltered Gyro Angles : ");  //Gyroscope angle
//  Serial2.print(F("#GYR:"));
Serial2.print(unfiltered_gyro_angle_x, 2);        
Serial2.print(F(","));
Serial2.print(unfiltered_gyro_angle_y, 2);
Serial2.print(F(","));
Serial2.print(unfiltered_gyro_angle_z, 2);
*/

Serial2.print(" Y Angle : ");  //Filtered angle
//Serial2.print(F("#FIL:"));             
    // Serial2.print(angle_x, 2);
    // Serial2.print(F(","));
Serial2.print(angle_y, 2);
    // Serial2.print(F(","));
    // Serial2.print(angle_z, 2);

      //Motor
//*
Serial2.print(F(" MotorValues: "));
Serial2.print(F(""));
Serial2.print("M1: ");
Serial2.print(Motor1Speed);
Serial2.print("M2: ");
Serial2.print(Motor2Speed);
Serial2.print(" M1 current: ");
Serial2.print(md.getM1CurrentMilliamps());
Serial2.print(" M2 current: ");
Serial2.print(md.getM2CurrentMilliamps());
//*/

//  Serial2.print(" Steer ");
//  Serial2.print(Steering);
  Serial2.print(" X Joy: ");
  Serial2.print(angleXJoy);
  Serial2.print(" Y Joy: ");
  Serial2.println(angleYJoy);
  }
