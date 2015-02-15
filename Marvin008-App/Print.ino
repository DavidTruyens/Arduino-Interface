void PrintPIDValues(){
  Serial1.print("I");
  Serial1.println(Int);
  delay(100);
  Serial1.print("P");
  Serial1.println(Prop);
  delay(100);
  Serial1.print("D");
  Serial1.println(Dif);
  delay(100);
  Serial.print("P");
  Serial.println(Prop);
  Serial.print("D");
  Serial.println(Dif);
  Serial.print("I");
  Serial.println(Int);
  }
void PrintApp(){
  Serial1.print(angleXJoy);
  Serial1.print(";");
  Serial1.print(angleYJoy);
  Serial1.print(";");
  Serial1.println(angle_y);
  Serial.println("Data printed");
}
void PrintData(){
       // Accelero
/*
Serial1.print(F("DEL:"));              //Delta T
Serial1.print(dt, DEC);
Serial1.print(F("#ACC:"));              //Accelerometer angle
Serial1.print(accel_angle_x, 2);
Serial1.print(F(","));
Serial1.print(accel_angle_y, 2);
Serial1.print(F(","));
Serial1.print(accel_angle_z, 2);
*/

      //Gyro

/*
Serial1.print(" Unfiltered Gyro Angles : ");  //Gyroscope angle
//  Serial1.print(F("#GYR:"));
Serial1.print(unfiltered_gyro_angle_x, 2);        
Serial1.print(F(","));
Serial1.print(unfiltered_gyro_angle_y, 2);
Serial1.print(F(","));
Serial1.print(unfiltered_gyro_angle_z, 2);
*/

Serial1.print(" Y Angle : ");  //Filtered angle
//Serial1.print(F("#FIL:"));             
    // Serial1.print(angle_x, 2);
    // Serial1.print(F(","));
Serial1.print(angle_y, 2);
    // Serial1.print(F(","));
    // Serial1.print(angle_z, 2);

      //Motor
//*
Serial1.print(F(" MotorValues: "));
Serial1.print(F(""));
Serial1.print("M1: ");
Serial1.print(Motor1Speed);
Serial1.print("M2: ");
Serial1.print(Motor2Speed);
Serial1.print(" M1 current: ");
Serial1.print(md.getM1CurrentMilliamps());
Serial1.print(" M2 current: ");
Serial1.print(md.getM2CurrentMilliamps());
//*/

//  Serial1.print(" Steer ");
//  Serial1.print(Steering);
  Serial1.print(" X Joy: ");
  Serial1.print(angleXJoy);
  Serial1.print(" Y Joy: ");
  Serial1.println(angleYJoy);
  }
