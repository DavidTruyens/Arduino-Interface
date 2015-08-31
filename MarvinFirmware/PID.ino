double IntegerAction;
double previousSum;
double posSpeed;
long GlobalPos = 0;
double GlobalVel = 0;
long TargetPos = 0;
double TargetAngle;


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
  PreviousGlobalPos = GlobalPos;
  TargetAngle = (TargetPos - GlobalPos) * PosProp - GlobalVel * PosDif;

  if (TargetAngle > MaxTargetAngle) {
    TargetAngle = MaxTargetAngle;
    }
  else if (TargetAngle < -MaxTargetAngle) {
    TargetAngle = -MaxTargetAngle;
  }

  //Slave PID 
  if (abs(TargetAngle) <= MaxTargetAngle) {   
	  MainSpeed = (TargetAngle + angle_y)*Prop - AngleSpeed_y * Dif;
  }
  else if (abs(TargetAngle) > MaxTargetAngle && abs(TargetAngle) <= (MaxTargetAngle + FuzzyTransition)) {
	  double FuzzyFactor = (abs(TargetAngle) - MaxTargetAngle) / FuzzyTransition;
	  MainSpeed = (TargetAngle + angle_y)*(Prop+(AggProp-Prop)*FuzzyFactor) - AngleSpeed_y * (Dif + (AggDif-Dif)*FuzzyFactor);
  }
  else {
	  MainSpeed = (TargetAngle + angle_y)*AggProp - AngleSpeed_y * AggDif;
  }
  
  if (angle_y < -25 || angle_y > 25) // Stops robot when angles are too big
  {
    start = false;
    Serial2.print ("Marvin Stopped due to angle error");
  }
  else  // Motor Controler
  {
	Motor1Speed = (MainSpeed - PropSteering * (XJoy - 50))*rightMotorScalerFwd;
    Motor2Speed = (MainSpeed + PropSteering * (XJoy - 50))*leftMotorScalerFwd;

	if (Motor1Speed > 0) {
		Motor1Speed = Motor1Speed + minSpeedRight;
	}
	else if (Motor1Speed < 0) {
		Motor1Speed = Motor1Speed - minSpeedRight;
	}
	else {
		Motor1Speed = 0;
	}
	
	if (Motor2Speed > 0) {
		Motor2Speed = Motor2Speed + minSpeedLeft;
	}
	else if (Motor2Speed < 0) {
		Motor2Speed = Motor2Speed - minSpeedLeft;
	}
	else {
		Motor2Speed = 0;
	}

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

// AutoStart
void flatStart() {
	if (angle_y > 70 || angle_y < -70) {
		flat = true;
	}
	if (flat) {
		if (angle_y > -5 || angle_y < 5) {
			flat = false;
			start = true;
		}
	}
}

