// 26 November
#include <EEPROMex.h>
#include <Wire.h>
#include <DualVNH5019MotorShield.h>

DualVNH5019MotorShield md;


// PID and Motorspeed Parameters
double Prop = 30;
double Dif = 0.5;
double Int = 0.1;
double PosProp = 0.01;
double PosDif = 0.01;
double Kalman = 0.96;
double MainSpeed;
double Motor1Speed;
double Motor2Speed;
double angleSum = 0;
double NValue = 0;
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
boolean calibrateMotors = false;

long positionLeft  = -999;
long positionRight = -999;

double leftMotorScalerFwd;
double rightMotorScalerFwd;
double leftMotorScalerRwd;
double rightMotorScalerRwd;

void setup()
{
  Serial2.begin(115200);
  Serial.begin(115200);

  MPUSetup();
  GetValues();
  SetCalibrationValues();

  Serial.println ("Welcome to Marvin!");
  Serial.println ("Press m for Menu");
}

void loop()
{
  MPU();
  potValueX = analogRead(PinX);
  potValueY = analogRead(PinY);
  angleXJoy = map(potValueX, 0, 676, 0, 100);
  angleYJoy = map(potValueY, 0, 676, 0, 100);
  angleSum = angleSum + angle_y;

  EncoderReading();



  if (start && joystick) {
    PID (angleXJoy, angleYJoy);
  }
  else if (start && joystick == false) {
    PID (50, 50);
  }
  else if (calibrateMotors){
  calibrateMotor();
  }
  else {
    Motor1Speed = 0;
    Motor2Speed = 0;
    md.setM1Speed (Motor1Speed);
    md.setM2Speed (Motor2Speed);
    stopIfFault();
  }
  SerialCom();
}

