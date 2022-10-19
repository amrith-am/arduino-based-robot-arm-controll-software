/*        
       DIY Arduino Robot Arm Smartphone Control  
        by Dejan, www.HowToMechatronics.com  
*/

#include <SoftwareSerial.h>
#include <Servo.h>
#define degtorad 0.0174533
#define radtodeg 57.2958
#define l1  5 //length arms in cm
#define l2  5
#define b  5 //height first rotational joint in cm
#define g 5 //gripper radius adjustment
#define gz 5 // gripper z direction adjustment
#define pi 3.14159265359
int g_s;
float i;
int pulse_length;
int Speed = 5 ;                     // Speed of servo
int precession = 200;
float omega,a1,a2;
float x,y,z,r,z_p,x_a,y_a,z_a;
float x0,y0,z0,dx,dy,dz;
float angles[5];                    // All the angles of the servos
float anglexy;
int servo[6][3]={                   // Presets for servo values
  {135,325,530},
  {110,335,560},
  {110,340,555},
  {110,335,560},
  {150,370,600},
  {170,290,370}
};
Servo servo01;
Servo servo02;
Servo servo03;
Servo servo04;
Servo servo05;
Servo servo06;
int ind1;             //Indexes for storing positions of incoming drive data, used to parse the data to smaller strings
int ind2;
int ind3;
int ind4;
int ind5;
int ind6;
int ind7;
int ind8;
int xval;
int yval;
int zval;
int xcordinate;
int ycordinate;
int zcordinate;
SoftwareSerial Bluetooth(3, 4); // Arduino(RX, TX) - HC-05 Bluetooth (TX, RX)

int servo1Pos, servo2Pos, servo3Pos, servo4Pos, servo5Pos, servo6Pos; // current position
int servo1PPos, servo2PPos, servo3PPos, servo4PPos, servo5PPos, servo6PPos; // previous position
int servo01SP[50], servo02SP[50], servo03SP[50], servo04SP[50], servo05SP[50], servo06SP[50]; // for storing positions/steps
int speedDelay = 20;
int index = 0;
String dataIn = "";

void setup() {

 // pinMode(12, OUTPUT);
  servo01.attach(5);
  servo02.attach(6);
  servo03.attach(7);
  servo04.attach(8);
  servo05.attach(9);
  servo06.attach(10);
  Serial.begin(9600);
  Bluetooth.begin(9600); // Default baud rate of the Bluetooth module
  Bluetooth.setTimeout(1);
  delay(20);
  // Robot arm initial position
  servo1PPos = 100;
  servo01.write(servo1PPos);
  servo2PPos = 150;
  servo02.write(servo2PPos);
  servo3PPos = 35;
  servo03.write(servo3PPos);
  servo4PPos = 140;
  servo04.write(servo4PPos);
  servo5PPos = 85;
  servo05.write(servo5PPos);
  servo6PPos = 100;
  servo06.write(servo6PPos);

}

void loop() {
  String readString;
  String dataIn;
  char c;
  //if (Bluetooth.available() > 0) {
   // dataIn = Bluetooth.readString(); 
    
  while(Bluetooth.available())
  {
    delay(1);
    if(Bluetooth.available()>0)
    {
      c = Bluetooth.read();
      if (isControl(c))
      {
        break;
      }
      readString += c;
      //isMoving == true;
    }   
  }

    while(Serial.available())
  {
    delay(1);
    if(Serial.available()>0)
    {
      c = Serial.read();
      if (isControl(c))
      {
        break;
      }
      readString += c;
      //isMoving == true;
    }   
  }
  dataIn = readString;
   if(dataIn.startsWith("drive"))
  {
       //digitalWrite(12, HIGH);
    ind1 = dataIn.indexOf(',');
    ind2 = dataIn.indexOf(',', ind1+1 );
    servo1PPos = dataIn.substring(ind1+1, ind2).toInt();
    servo01.write(servo1PPos);
    ind3 = dataIn.indexOf(',', ind2+1 );
    servo2PPos = dataIn.substring(ind2+1, ind3).toInt();
    servo02.write(servo2PPos);
    ind4 = dataIn.indexOf(',', ind3+1 );
    servo3PPos = dataIn.substring(ind3+1, ind4).toInt();
    servo03.write(servo3PPos);
    ind5 = dataIn.indexOf(',', ind4+1);
    servo4PPos = dataIn.substring(ind4+1, ind5).toInt();
    servo04.write(servo4PPos);
    ind6 = dataIn.indexOf(',', ind5+1);
    servo5PPos = dataIn.substring(ind5+1, ind6).toInt();
    servo05.write(servo5PPos);
    ind7 = dataIn.indexOf(',', ind6+1);
    servo6PPos = dataIn.substring(ind6+1, ind7).toInt();
    servo06.write(servo6PPos);
    ind8 = dataIn.indexOf(',', ind7+1 );
    speedDelay  = dataIn.substring(ind7+1, ind8).toInt();
    dataIn = "";
  }
 if(dataIn.startsWith("xyz"))
  {
       //digitalWrite(12, HIGH);
    ind1 = dataIn.indexOf(',');
    ind2 = dataIn.indexOf(',', ind1+1 );
    xcordinate = dataIn.substring(ind1+1, ind2).toInt();
   // servo01.write(servo1PPos);
    ind3 = dataIn.indexOf(',', ind2+1 );
    ycordinate = dataIn.substring(ind2+1, ind3).toInt();
    //servo02.write(servo2PPos);
    ind4 = dataIn.indexOf(',', ind3+1 );
    zcordinate = dataIn.substring(ind3+1, ind4).toInt();
    //servo03.write(servo3PPos);
    inversekinematics(xcordinate,ycordinate,zcordinate);

  }
  if(dataIn.startsWith("xval"))
    {
      digitalWrite(12, HIGH);
    ind1 = dataIn.indexOf(',');
    xval = dataIn.substring(ind1+1).toInt();
    inversekinematics(xval,yval,zval);
    }
  if(dataIn.startsWith("yval"))
    {
      digitalWrite(12, LOW);
    ind1 = dataIn.indexOf(',');
    yval = dataIn.substring(ind1+1).toInt();
    inversekinematics(xval,yval,zval);
    }
  if(dataIn.startsWith("zval"))
    {
    ind1 = dataIn.indexOf(',');
    zval = dataIn.substring(ind1+1).toInt();
    inversekinematics(xval,yval,zval);
    }
  if(dataIn.startsWith("calibration1"))
    {
      servo01.write(0);
    }

    
     if (dataIn.startsWith("s1")) {
      String dataInS = dataIn.substring(2, dataIn.length()); // Extract only the number. E.g. from "s1120" to "120"
      servo1Pos = dataInS.toInt();  // Convert the string into integer
      // We use for loops so we can control the speed of the servo
      // If previous position is bigger then current position
      if (servo1PPos > servo1Pos) {
        for ( int j = servo1PPos; j >= servo1Pos; j--) {   // Run servo down
          servo01.write(j);
          delay(20);    // defines the speed at which the servo rotates
        }
      }
      // If previous position is smaller then current position
      if (servo1PPos < servo1Pos) {
        for ( int j = servo1PPos; j <= servo1Pos; j++) {   // Run servo up
          servo01.write(j);
          delay(20);
        }
      }
      servo1PPos = servo1Pos;   // set current position as previous position
    }
    
    // Move Servo 2
    if (dataIn.startsWith("s2")) {
      String dataInS = dataIn.substring(2, dataIn.length());
      servo2Pos = dataInS.toInt();

      if (servo2PPos > servo2Pos) {
        for ( int j = servo2PPos; j >= servo2Pos; j--) {
          servo02.write(j);
          delay(50);
        }
      }
      if (servo2PPos < servo2Pos) {
        for ( int j = servo2PPos; j <= servo2Pos; j++) {
          servo02.write(j);
          delay(50);
        }
      }
      servo2PPos = servo2Pos;
    }
    // Move Servo 3
    if (dataIn.startsWith("s3")) {
      String dataInS = dataIn.substring(2, dataIn.length());
      servo3Pos = dataInS.toInt();
      if (servo3PPos > servo3Pos) {
        for ( int j = servo3PPos; j >= servo3Pos; j--) {
          servo03.write(j);
          delay(30);
        }
      }
      if (servo3PPos < servo3Pos) {
        for ( int j = servo3PPos; j <= servo3Pos; j++) {
          servo03.write(j);
          delay(30);
        }
      }
      servo3PPos = servo3Pos;
    }
    // Move Servo 4
    if (dataIn.startsWith("s4")) {
      String dataInS = dataIn.substring(2, dataIn.length());
      servo4Pos = dataInS.toInt();
      if (servo4PPos > servo4Pos) {
        for ( int j = servo4PPos; j >= servo4Pos; j--) {
          servo04.write(j);
          delay(30);
        }
      }
      if (servo4PPos < servo4Pos) {
        for ( int j = servo4PPos; j <= servo4Pos; j++) {
          servo04.write(j);
          delay(30);
        }
      }
      servo4PPos = servo4Pos;
    }
    // Move Servo 5
    if (dataIn.startsWith("s5")) {
      String dataInS = dataIn.substring(2, dataIn.length());
      servo5Pos = dataInS.toInt();
      if (servo5PPos > servo5Pos) {
        for ( int j = servo5PPos; j >= servo5Pos; j--) {
          servo05.write(j);
          delay(30);
        }
      }
      if (servo5PPos < servo5Pos) {
        for ( int j = servo5PPos; j <= servo5Pos; j++) {
          servo05.write(j);
          delay(30);
        }
      }
      servo5PPos = servo5Pos;
    }
    // Move Servo 6
    if (dataIn.startsWith("s6")) {
      String dataInS = dataIn.substring(2, dataIn.length());
      servo6Pos = dataInS.toInt();
      if (servo6PPos > servo6Pos) {
        for ( int j = servo6PPos; j >= servo6Pos; j--) {
          servo06.write(j);
          delay(30);
        }
      }
      if (servo6PPos < servo6Pos) {
        for ( int j = servo6PPos; j <= servo6Pos; j++) {
          servo06.write(j);
          delay(30);
        }
      }
      servo6PPos = servo6Pos; 
    }

 
    // If button "SAVE" is pressed
    if (dataIn.startsWith("SAVE")) {
      servo01SP[index] = servo1PPos;  // save position into the array
      servo02SP[index] = servo2PPos;
      servo03SP[index] = servo3PPos;
      servo04SP[index] = servo4PPos;
      servo05SP[index] = servo5PPos;
      servo06SP[index] = servo6PPos;
      index++;                        // Increase the array index
    }
    // If button "RUN" is pressed
    if (dataIn.startsWith("RUN")) {
    //  runservo();  // Automatic mode - run the saved steps 
    }
    // If button "RESET" is pressed
    if ( dataIn == "RESET") {
      memset(servo01SP, 0, sizeof(servo01SP)); // Clear the array data to 0
      memset(servo02SP, 0, sizeof(servo02SP));
      memset(servo03SP, 0, sizeof(servo03SP));
      memset(servo04SP, 0, sizeof(servo04SP));
      memset(servo05SP, 0, sizeof(servo05SP));
      memset(servo06SP, 0, sizeof(servo06SP));
      index = 0;  // Index to 0
    }

}

void inversekinematics (float x, float y, float z)
{
  z_p = z-b;
  r = sqrt(x*x+y*y); 
  angles[0] = radtodeg*atan2(y,x);
  a1 =  sqrt( 1 - sq( (r*r+z_p*z_p-l1*l1-l2*l2)/(2*l1*l2) ) );
  a2 = (r*r+z_p*z_p-l1*l1-l2*l2)/(2*l1*l2);
  float res = atan2(-a1,a2);
  angles[2] = -radtodeg*res;
  float k1 = l1+l2*cos(res);
  float k2 = l2*sin(res);
  angles[1] = radtodeg*(atan2(z_p,r) - atan2(k2,k1));
  angles[3] = 45 - angles[1] + angles[2];
  servo01.write(angles[0]);
  delay(100);
  servo02.write(angles[1]);
  delay(100);
  servo03.write(angles[2]);
  delay(100);
  servo04.write(angles[3]);
  delay(100);
}

// Automatic mode custom function - run the saved steps
void runservo() {
  while (dataIn != "RESET") {   // Run the steps over and over again until "RESET" button is pressed
    for (int i = 0; i <= index - 2; i++) {  // Run through all steps(index)
      if (Bluetooth.available() > 0) {      // Check for incomding data
        dataIn = Bluetooth.readString();
        if ( dataIn == "PAUSE") {           // If button "PAUSE" is pressed
          while (dataIn != "RUN") {         // Wait until "RUN" is pressed again
            if (Bluetooth.available() > 0) {
              dataIn = Bluetooth.readString();
              if ( dataIn == "RESET") {     
                break;
              }
            }
          }
        }
        // If speed slider is changed
        if (dataIn.startsWith("ss")) {
          String dataInS = dataIn.substring(2, dataIn.length());
          speedDelay = dataInS.toInt(); // Change servo speed (delay time)
        }
      }
      // Servo 1
      if (servo01SP[i] == servo01SP[i + 1]) {
      }
      if (servo01SP[i] > servo01SP[i + 1]) {
        for ( int j = servo01SP[i]; j >= servo01SP[i + 1]; j--) {
          servo01.write(j);
          delay(speedDelay);
        }
      }
      if (servo01SP[i] < servo01SP[i + 1]) {
        for ( int j = servo01SP[i]; j <= servo01SP[i + 1]; j++) {
          servo01.write(j);
          delay(speedDelay);
        }
      }

      // Servo 2
      if (servo02SP[i] == servo02SP[i + 1]) {
      }
      if (servo02SP[i] > servo02SP[i + 1]) {
        for ( int j = servo02SP[i]; j >= servo02SP[i + 1]; j--) {
          servo02.write(j);
          delay(speedDelay);
        }
      }
      if (servo02SP[i] < servo02SP[i + 1]) {
        for ( int j = servo02SP[i]; j <= servo02SP[i + 1]; j++) {
          servo02.write(j);
          delay(speedDelay);
        }
      }

      // Servo 3
      if (servo03SP[i] == servo03SP[i + 1]) {
      }
      if (servo03SP[i] > servo03SP[i + 1]) {
        for ( int j = servo03SP[i]; j >= servo03SP[i + 1]; j--) {
          servo03.write(j);
          delay(speedDelay);
        }
      }
      if (servo03SP[i] < servo03SP[i + 1]) {
        for ( int j = servo03SP[i]; j <= servo03SP[i + 1]; j++) {
          servo03.write(j);
          delay(speedDelay);
        }
      }

      // Servo 4
      if (servo04SP[i] == servo04SP[i + 1]) {
      }
      if (servo04SP[i] > servo04SP[i + 1]) {
        for ( int j = servo04SP[i]; j >= servo04SP[i + 1]; j--) {
          servo04.write(j);
          delay(speedDelay);
        }
      }
      if (servo04SP[i] < servo04SP[i + 1]) {
        for ( int j = servo04SP[i]; j <= servo04SP[i + 1]; j++) {
          servo04.write(j);
          delay(speedDelay);
        }
      }

      // Servo 5
      if (servo05SP[i] == servo05SP[i + 1]) {
      }
      if (servo05SP[i] > servo05SP[i + 1]) {
        for ( int j = servo05SP[i]; j >= servo05SP[i + 1]; j--) {
          servo05.write(j);
          delay(speedDelay);
        }
      }
      if (servo05SP[i] < servo05SP[i + 1]) {
        for ( int j = servo05SP[i]; j <= servo05SP[i + 1]; j++) {
          servo05.write(j);
          delay(speedDelay);
        }
      }

      // Servo 6
      if (servo06SP[i] == servo06SP[i + 1]) {
      }
      if (servo06SP[i] > servo06SP[i + 1]) {
        for ( int j = servo06SP[i]; j >= servo06SP[i + 1]; j--) {
          servo06.write(j);
          delay(speedDelay);
        }
      }
      if (servo06SP[i] < servo06SP[i + 1]) {
        for ( int j = servo06SP[i]; j <= servo06SP[i + 1]; j++) {
          servo06.write(j);
          delay(speedDelay);
        }
      }
    }
  }
}
