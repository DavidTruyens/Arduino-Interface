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

void Serial1com(){  
  if (Serial1.available() > 0) {
      inByte = Serial1.read();
      //PrintDataValue = 0;
          switch (inByte) {
            case 'm':
              Serial.println (" ");
              Serial.println ("===== Welcome to the Menu! =========");
              Serial.println (" ");
              Serial.println ("Press s to start or stop Marvin");
              Serial.println ("Press p to change P-value");
              Serial.println ("Press d to change D-value");
              Serial.println ("Press i to change the I-value");
              Serial.println ("Press a to view all PID values");
              Serial.println ("Press x to view motor values");
              Serial.println ("Press y to enable or disable JoyStick control");
              Serial.println ("Press z to store PID values");
              inByte=0;
              break;
              
            case 's':
              if (start){
                start = false;
                //Serial1.println ("Marvin Stopped");
                }
              else {
                start = true;
                //Serial1.println ("Marvin Started!");
                }              
              break;
            case 'y':
              if (joystick){
              joystick = false;
                //Serial1.println ("JoyStick Disabled");
                }
              else {
                joystick = true;
                //Serial1.println ("JoyStick Enabled!");
                }  
              break;
            
            case 'z':
              SaveValues();
              
            case 'p':
              //Serial1.print("Current P-Value is: ");
              //Serial1.println (Prop);
              //Serial1.println("Enter a new P-Value between ()");
              Menu=1;
              inByte=0;
              break;
            
            case 'd':
              //Serial1.print("Current D-Value is: ");
              //Serial1.println (Dif);
              //Serial1.println("Enter a new D-Value between ()");
              Menu=2;
              inByte=0;
              break;          
              
            case 'i':
              //Serial1.print("Current I-Value is: ");
              //Serial1.println (Int);
              //Serial1.println("Enter a new I-Value between ()");
              Menu=3;
              inByte=0;
              break;
              
            case 'a':
              PrintPIDValues();
              break;
              
            case 'x':
               PrintApp();
               break;
              
            case startDelimiter:
              recievedNumber = 0;
              decPos = 0;
              negative = false;
              decimal = false;
              break;
            
            case '0' ... '9':
              recievedNumber *= 10;
              recievedNumber += inByte- '0';
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
              if (decimal){
                DecDiv=pow(10.00,(float)decPos);
                processNumber = recievedNumber / DecDiv;
                }
              else
                processNumber = recievedNumber;
              if (negative)
                processNumber = -processNumber;
              else
                processNumber = processNumber;
               
              if (Menu == 1){
                Prop=processNumber;
                Menu = 0;
                Serial.print ("New P Value = ");
                Serial.println (Prop,4);
                }
               else if (Menu == 2){
                 Dif=processNumber;
                 Menu = 0;
                 Serial.print ("New D Value = ");
                 Serial.println (Dif,4);
                 }
               else if (Menu == 3){
                 Int=processNumber;
                 Menu = 0;
                 Serial.print ("New I Value = ");
                 Serial.println (Int,4);
                 }
               break;
           }
  }
}
