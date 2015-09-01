int Menu = 0;
int inByte = 0;
int PrintDataValue = 0;

const char startDelimiter = '(';
const char endDelimiter   = ')';
float recievedNumber = 0;
float processNumber = 0;
float decNumber = 0;
int decPos = 0;
float DecDiv = 0;
boolean negative = false;
boolean decimal = false;

void SerialCom() {
  if (Serial2.available() > 0 || Serial.available() > 0) {
    if (Serial2.available() > 0) {
      inByte = Serial2.read();
    }
    else {
      inByte = Serial.read();
    }
    //PrintDataValue = 0;
    switch (inByte) {
      case 'm':
        Serial.println (" ");
        Serial.println ("===== Welcome to the Menu! =========");
        Serial.println (" ");
        Serial.println ("Press s to start or stop Marvin");
        Serial.println ("Press p to change the P-value");
        Serial.println ("Press d to change the D-value");
        Serial.println ("Press i to change the I-value");
		Serial.println ("Press l to change the Agg-P value");
		Serial.println ("Perss o to change the Agg-D value");
        Serial.println ("Press k to change the Kalman-value");
        Serial.println ("Press t to change the PosProp-value");
        Serial.println ("Press u to change the PosDif-value");
        Serial.println ("Press a to view all PID values");
        Serial.println ("Press n to set the neutural angle");
        Serial.println ("Press b to reset the position");
        Serial.println ("Press x to view motor values");
        Serial.println ("Press j to change max Target angle");
        Serial.println ("Press y to enable or disable JoyStick control");
        Serial.println ("Press z to store PID values");
        Serial.println ("Press c to calibrate motors");
		Serial.println ("Press w to change Fuzzystart");
		Serial.println ("Press r to change the fuzzy zone");
		// e, f, g and h are used to print the calibration values. Not yet used: q v 
        inByte = 0;
        break;

      case 's':
        if (start) {
          start = false;
          Serial.println ("Marvin Stopped");
        }
        else {
          start = true;
          Serial.println ("Marvin Started!");
        }
        break;
      case 'y':
        if (joystick) {
          joystick = false;
          Serial.println ("JoyStick Disabled");
        }
        else {
          joystick = true;
          Serial.println ("JoyStick Enabled!");
        }
        break;

      case 'z':
        SaveValues();
        break;

      case 'p':
        Serial.print("Current P-Value is: ");
        Serial.println (Prop);
        Serial.println("Enter a new P-Value between ()");
        Menu = 1;
        inByte = 0;
        break;

      case 'd':
        Serial.print("Current D-Value is: ");
        Serial.println (Dif);
        Serial.println("Enter a new D-Value between ()");
        Menu = 2;
        inByte = 0;
        break;

      case 'i':
        Serial.print("Current I-Value is: ");
        Serial.println (Int);
        Serial.println("Enter a new I-Value between ()");
        Menu = 3;
        inByte = 0;
        break;

      case 'k':
        Serial.print("Current Kalman-Value is: ");
        Serial.println (Kalman);
        Serial.println("Enter a new Kalman-Value between ()");
        Menu = 4;
        inByte = 0;
        break;

      case 'n':
        Serial.print("Current Neutral Angle is: ");
        Serial.println (NValue);
        Serial.println("Enter a new neutral angle between ()");
        Menu = 5;
        inByte = 0;
        break;

      case 't':
        Serial.print("Current PosProp-Value is : ");
        Serial.println (PosProp);
        Serial.println("Enter a new PosProp-Value between ()");
        Menu = 6;
        inByte = 0;
        break;

      case 'u':
        Serial.print("Current PosDif-Value is : ");
        Serial.println (PosDif);
        Serial.println("Enter a new PosDif-Value between ()");
        Menu = 7;
        inByte = 0;
        break;

	  case 'j':
		  Serial.print("Current Max Target Angle is: ");
		  Serial.println(MaxTargetAngle);
		  Serial.println("Enter a new Max Target Angle between ()");
		  Menu = 8;
		  inByte = 0;
		  break;

	  case 'l':
		  Serial.print("Current Agg Prop value is: ");
		  Serial.println(AggProp);
		  Serial.println("Enter a new Agg Prop value between ()");
		  Menu = 9;
		  inByte = 0;
		  break;

	  case 'o':
		  Serial.print("Current Agg Dif value is: ");
		  Serial.println(AggDif);
		  Serial.println("Enter a new Agg Dif value between ()");
		  Menu = 10;
		  inByte = 0;
		  break;

	  case 'r':
		  Serial.print("Current Fuzzy zone is: ");
		  Serial.println(FuzzyTransition);
		  Serial.println("Enter a new value between ()");
		  Menu = 11;
		  inByte = 0;
		  break;

	  case 'w':
		  Serial.print("Current Fuzzy start is: ");
		  Serial.println(FuzzyTransition);
		  Serial.println("Enter a new value between ()");
		  Menu = 12;
		  inByte = 0;
		  break;

      case 'a':
        PrintPIDValues();
        break;

      case 'b':
        knobLeft.write(0);
        knobRight.write(0);
        Serial.println("Position Reset");
        break;

      case 'x':
        PrintApp();
        break;

      case 'c':
        calibrateMotors = true;
        break;

      case startDelimiter:
        recievedNumber = 0;
        decPos = 0;
        negative = false;
        decimal = false;
        break;

      case '0' ... '9':
        recievedNumber *= 10;
        recievedNumber += inByte - '0';
        decPos += 1;
        break;

      case '-':
        negative = true;
        break;

      case '.':
        decimal = true;
        decPos = 0;
        break;

      case endDelimiter:
        if (decimal) {
          DecDiv = pow(10.00, (float)decPos);
          processNumber = recievedNumber / DecDiv;
        }
        else
          processNumber = recievedNumber;
        if (negative)
          processNumber = -processNumber;
        else
          processNumber = processNumber;

        if (Menu == 1) {
          Prop = processNumber;
          Menu = 0;
          Serial.print ("New P Value = ");
          Serial.println (Prop, 4);
        }
        else if (Menu == 2) {
          Dif = processNumber;
          Menu = 0;
          Serial.print ("New D Value = ");
          Serial.println (Dif, 4);
        }
        else if (Menu == 3) {
          Int = processNumber;
          Menu = 0;
          Serial.print ("New I Value = ");
          Serial.println (Int, 4);
        }
        else if (Menu == 4) {
          Kalman = processNumber;
          Menu = 0;
          Serial.print ("New Kalman Value = ");
          Serial.println (Kalman, 4);
        }
        else if (Menu == 5) {
          NValue = processNumber;
          Menu = 0;
          Serial.print("New Neutral Angle = ");
          Serial.println(NValue, 4);
        }
        else if (Menu == 6) {
          PosProp = processNumber;
          Menu = 0;
          Serial.print("New PosProp Value = ");
          Serial.println(PosProp, 4);
        }
        else if (Menu == 7) {
          PosDif = processNumber;
          Menu = 0;
          Serial.print("New PosDif Value = ");
          Serial.println(PosDif, 4);
        }
		else if (Menu == 8) {
			MaxTargetAngle = processNumber;
			Menu = 0;
			Serial.print("New Max Target Angle Value = ");
			Serial.println(MaxTargetAngle, 4);
		}
		else if (Menu == 9) {
			AggProp = processNumber;
			Menu = 0;
			Serial.print("New Agg Prop Value = ");
			Serial.println(AggProp, 4);
		}
		else if (Menu == 10) {
			AggDif = processNumber;
			Menu = 0;
			Serial.print("New Agg Dif Value = ");
			Serial.println(AggDif, 4);
		}
		else if (Menu == 11) {
			FuzzyTransition = processNumber;
			Menu = 0;
			Serial.print("New Fuzzy Transition Value = ");
			Serial.println(FuzzyTransition, 4);
		}
		else if (Menu == 12) {
			FuzzyStart = processNumber;
			Menu = 0;
			Serial.print("New Fuzzy Start Value = ");
			Serial.println(FuzzyStart, 4);
		}
        break;
    }
  }
}
