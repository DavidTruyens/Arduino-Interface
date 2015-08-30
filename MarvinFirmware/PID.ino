double IntegerAction;
double previousSum;
double posSpeed;
long GlobalPos = 0;
double GlobalVel = 0;
long TargetPos = 0;
double TargetAngle;
double MaxTargetAngle=2;

long PreviousGlobalPos;

void PID(int XJoy, int YJoy) {
  if (YJoy > 55 || YJoy < 45) {
    knobLeft.write(0);
    knobRight.write(0);
    angleSum = 0;
  }

  //Master PID
  GlobalPos = (positionLeft + positionRight) / 2;
  GlobalVel = GlobalPos - PreviousGlobalPos;
  TargetAngle = (TargetPos - GlobalPos) * PosProp - GlobalVel * PosDif;

  if (TargetAngle > MaxTargetAngle) {
    TargetAngle = MaxTargetAngle;
    }
  else if (TargetAngle < -MaxTargetAngle) {
    TargetAngle = -MaxTargetAngle;
  }

  //Slave PID
  MainSpeed = (TargetAngle+angle_y)*Prop - AngleSpeed_y * Dif;


/*
  // Balance Angle Correction
  angleSum = angleSum + angle_y;
  IntegerAction = angleSum * Int;
  balanceAngle = NValue + angle_y + (YJoy - 50) * AngleJoyProp ;
  // PID Output
  MainSpeed = balanceAngle * Prop - AngleSpeed_y * Dif + IntegerAction;
  // Drive Motors
*/

  PreviousGlobalPos = GlobalPos;

  if (angle_y < -25 || angle_y > 25) // Stops robot when angles are too big
  {
    start = false;
    Serial2.print ("Marvin Stopped due to angle error");
  }
  else  // PID and engine Controler
  {
    Motor1Speed = (MainSpeed - PropSteering * (angleXJoy - 50))*rightMotorScalerFwd;
    Motor2Speed = (MainSpeed + PropSteering * (angleXJoy - 50))*leftMotorScalerFwd;
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
    Serial2.println("M1 fault");
    while (1);
  }
  if (md.getM2Fault())
  {
    Serial2.println("M2 fault");
    while (1);
  }
}

