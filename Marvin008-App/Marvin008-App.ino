// 26 November
#include <EEPROMex.h>
#include <Wire.h>
#include <DualVNH5019MotorShield.h>

DualVNH5019MotorShield md;

// PID and Motorspeed Parameters
  double Prop = 30;
  double Dif = 0.5;
  double Int = 0.1;
  double MainSpeed;
  double Motor1Speed;
  double Motor2Speed;
  double angleSum = 0;
  double balanceAngle;
  int Steering = 53;
  double PropSteering = 0.5;
  double AngleJoyProp = 0.05;
  
  int PinX = A0;
  int PinY = A3;
  int potValueX;
  int potValueY;
  int angleXJoy;
  int angleYJoy;
  
  float angle_x;
  float angle_y;
  float angle_z;
  double AngleSpeed_y;
   
  boolean start = false;
  boolean joystick = false;
   
void setup()
{      
  Serial1.begin(115200);
  Serial.begin(115200);
  
  MPUSetup();
  GetValues();
  Serial.println ("Welcome to Marvin!");
  Serial.println ("Press m for Menu");
}

void loop()
{
  MPU();
  
  potValueX = analogRead(PinX);
  potValueY = analogRead(PinY);
  angleXJoy = map(potValueX,0,676,0,100);
  angleYJoy = map(potValueY,0,676,0,100);
  
  if (start && joystick){
    PID (angle_y, AngleSpeed_y,angleXJoy);
  }
  else if (start && joystick == false){
    PID (angle_y, AngleSpeed_y, 50);
  }
  else {
     Motor1Speed = 0;
     Motor2Speed = 0;
     md.setM1Speed (Motor1Speed);
     md.setM2Speed (Motor2Speed);
     stopIfFault();
  }
  
  Serial1com();
 
}

