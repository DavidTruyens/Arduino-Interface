void PID (double angle_y, double AngleSpeed_y, int angleXJoy){
  
 if (angle_y < -25 || angle_y > 25) // Stops robot when angles are too big
  {
    start=false;
    Serial1.print ("Marvin Stopped due to angle error");
  }
  else  // PID and engine Controler
  { 
    // Balance Angle Correction
      angleSum = angleSum + angle_y;
      balanceAngle = NAngle + angle_y + (angleYJoy -50)*AngleJoyProp; //- angleSum * Int;
    // PID Output 
      MainSpeed = balanceAngle*Prop - AngleSpeed_y*Dif;
    // Drive Motors
      Motor1Speed = MainSpeed - PropSteering*(angleXJoy-50);
      Motor2Speed = MainSpeed + PropSteering*(angleXJoy-50);
      md.setM1Speed (Motor1Speed);
      md.setM2Speed (Motor2Speed);
      stopIfFault();
  }
}

// Error Stop for motor
void stopIfFault()
{
  if (md.getM1Fault())
  {
    Serial1.println("M1 fault");
    while(1);
  }
  if (md.getM2Fault())
  {
    Serial1.println("M2 fault");
    while(1);
  }
}

