#include <LiquidCrystal.h>
LiquidCrystal lcd(9, 8, 4, 5, 6, 7);
#include <SoftwareSerial.h>
#include <Servo.h>

Servo servo01;
Servo servo02;
Servo servo03;
Servo servo04;
Servo servo05;
Servo servo06;
#define fanPin 8
#define enable5V 9

//------------------setting things up------------------//

#define J1stepPin 25
#define J1dirPin 27
#define J1_ENABLE_PIN 29
#define J1limitSwitch 45

#define J2stepPin 54
#define J2dirPin 55
#define J2_ENABLE_PIN 38
#define J2limitSwitch 31

#define J3stepPin 60
#define J3dirPin 61
#define J3_ENABLE_PIN 56
#define J3limitSwitch 39

#define J4stepPin 26
#define J4dirPin 28
#define J4_ENABLE_PIN 24

#define J5stepPin 36
#define J5dirPin 34
#define J5_ENABLE_PIN 30

#define J6stepPin 46
#define J6dirPin 48
#define J6_ENABLE_PIN 62

String checkText;     //First part of the incoming string, used as a keyword to sort out different functions

int ind1;             //Indexes for storing positions of incoming drive data, used to parse the data to smaller strings
int ind2;
int ind3;
int ind4;
int ind5;
int ind6;
int ind7;
int ind8;
int ind9;
int ind10;
int ind11;
int ind12;
int ind13;
int ind14;

int ind21;
int ind22;
int ind23;
int ind24;
int ind25;
int ind26;

int indJ1;

//float J1steps = 0;
float J1newSteps = 0;
float J1prevSteps = 0;
float J1stepsToGo = 0;
int J1currentSteps = 0;
String J1printSteps;
int J1dir;
int J1minSteps = -4000;       //10000 täyteen kierrokseen
int J1maxSteps = 4000;
int J1calibrationSpeed = 2000;
int J1calibrationReturnSpeed = 1000;
int J1calibrationReturn = 4300;
bool J1isCalibrated;
int J1driveSpeed = 500;
bool J1jogging;
int J1calibration = 0;
int J1maxJogSpeed = 500;
int J1jogSpeedMultiplier;
int J1jogSpeed;

//float J2steps = 0;
float J2newSteps = 0;
float J2prevSteps = 0;
float J2stepsToGo = 0;
int J2currentSteps = 0;
int J2dir;
int J2minSteps = -1500;       //40000 täyteen kierrokseen
int J2maxSteps = 10000;
int J2calibrationSpeed = 1000;
int J2calibrationReturnSpeed = 500;
int J2calibrationReturn = 1650;
bool J2isCalibrated;
int J2driveSpeed = 250;
bool J2jogging;
int J2calibration = 0;

//float J3steps = 0;
float J3newSteps = 0;
float J3prevSteps = 0;
float J3stepsToGo = 0;
int J3currentSteps = 0;
int J3dir;
int J3minSteps = -1500;       //10000 täyteen kierrokseen
int J3maxSteps = 1900;
int J3calibrationSpeed = 2000;
int J3calibrationReturnSpeed = 1000;
int J3calibrationReturn = 1620;
bool J3isCalibrated;
int J3driveSpeed = 500;
bool J3jogging;
int J3calibration = 0;

//float J4steps = 0;
float J4newSteps = 0;
float J4prevSteps = 0;
float J4stepsToGo = 0;
int J4currentSteps = 0;
int J4dir;
int J4minSteps = -1500;       //80000 täyteen kierrokseen
int J4maxSteps = 10000;
int J4calibrationSpeed = 1000;
int J4calibrationReturnSpeed = 500;
int J4calibrationReturn = 2300;
bool J4isCalibrated;
int J4driveSpeed = 250;
bool J4jogging;
int J4calibration = 0;

//float J5steps = 0;
float J5newSteps = 0;
float J5prevSteps = 0;
float J5stepsToGo = 0;
int J5currentSteps = 0;
int J5dir;
int J5minSteps = -1500;       //80000 täyteen kierrokseen
int J5maxSteps = 10000;
int J5calibrationSpeed = 1000;
int J5calibrationReturnSpeed = 500;
int J5calibrationReturn = 2300;
bool J5isCalibrated;
int J5driveSpeed = 250;
bool J5jogging;
int J5calibration = 0;

//float J6steps = 0;
float J6newSteps = 0;
float J6prevSteps = 0;
float J6stepsToGo = 0;
int J6currentSteps = 0;
int J6dir;
int J6minSteps = -1500;       //80000 täyteen kierrokseen
int J6maxSteps = 10000;
int J6calibrationSpeed = 1000;
int J6calibrationReturnSpeed = 500;
int J6calibrationReturn = 2300;
bool J6isCalibrated;
int J6driveSpeed = 250;
bool J6jogging;
int J6calibration = 0;

bool driveProgram = false;

bool move1 = false;
float J1WP1;
float J2WP1;
float J3WP1;
float J4WP1;
float J5WP1;
float J6WP1;

bool move2 = false;
float J1WP2;
float J2WP2;
float J3WP2;
float J4WP2;
float J5WP2;
float J6WP2;

bool move3 = false;
float J1WP3;
float J2WP3;
float J3WP3;
float J4WP3;
float J5WP3;
float J6WP3;

int speedMultiplier; //lue tämä sliderista ja jaa kymmenellä
int accelMultiplier; //lue tämä sliderista ja jaa kymmenellä

long commonCurrentStep = 0;
long highestStepInt = 0;

long timerTime = 0;

bool driveToAngle = false;
bool jointsCalibrating = false;

long testSteps = 0;
bool isMoving = false;

void setup()
{
  //------------------setting pinmodes for steppers------------------//
  
  pinMode(J1stepPin,OUTPUT);
  pinMode(J1dirPin,OUTPUT);
  pinMode(J1_ENABLE_PIN, OUTPUT);
  pinMode(J1limitSwitch, INPUT);
  digitalWrite(J1dirPin, HIGH);
  digitalWrite(J1_ENABLE_PIN, HIGH);
  
  pinMode(J2stepPin,OUTPUT);
  pinMode(J2dirPin,OUTPUT);
  pinMode(J2_ENABLE_PIN, OUTPUT);
  pinMode(J2limitSwitch, INPUT);
  digitalWrite(J2dirPin, HIGH);
  digitalWrite(J2_ENABLE_PIN, HIGH);

  pinMode(J3stepPin,OUTPUT);
  pinMode(J3dirPin,OUTPUT);
  pinMode(J3_ENABLE_PIN, OUTPUT);
  pinMode(J3limitSwitch, INPUT);
  digitalWrite(J3dirPin, HIGH);
  digitalWrite(J3_ENABLE_PIN, HIGH);

  pinMode(J4stepPin,OUTPUT);
  pinMode(J4dirPin,OUTPUT);
  pinMode(J4_ENABLE_PIN, OUTPUT);
  digitalWrite(J4dirPin, HIGH);
  digitalWrite(J4_ENABLE_PIN, HIGH);

  pinMode(J5stepPin,OUTPUT);
  pinMode(J5dirPin,OUTPUT);
  pinMode(J5_ENABLE_PIN, OUTPUT);
  digitalWrite(J5dirPin, HIGH);
  digitalWrite(J5_ENABLE_PIN, HIGH);

  pinMode(J6stepPin,OUTPUT);
  pinMode(J6dirPin,OUTPUT);
  pinMode(J6_ENABLE_PIN, OUTPUT);
  digitalWrite(J6dirPin, HIGH);
  digitalWrite(J6_ENABLE_PIN, HIGH);

  //------------------setting other stuff needed------------------//
  
  Serial.begin(115200);
  lcd.begin(16, 2);

  J1isCalibrated = false;
  J2isCalibrated = false;
  J3isCalibrated = false;
  J4isCalibrated = false;
  J5isCalibrated = false;
  J6isCalibrated = false;
  J1jogging = false;
  J2jogging = false;
  J3jogging = false;
  J4jogging = false;
  J5jogging = false;
  J6jogging = false;

  digitalWrite(enable5V, HIGH);
  digitalWrite(fanPin, LOW);
}

void loop()
{ 
  String readString;
  String data;
  char c;

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
      isMoving == true;
    }   
  }
  data = readString;

  if(data.startsWith("drive"))
  {
    //driving
    
    ind1 = data.indexOf(',');
    ind2 = data.indexOf(',', ind1+1 );
    J1newSteps = data.substring(ind1+1, ind2).toFloat();
    ind3 = data.indexOf(',', ind2+1 );
    J2newSteps = data.substring(ind2+1, ind3).toFloat();
    ind4 = data.indexOf(',', ind3+1 );
    J3newSteps = data.substring(ind3+1, ind4).toFloat();
    ind5 = data.indexOf(',', ind4+1);
    J4newSteps = data.substring(ind4+1, ind5).toFloat();
    ind6 = data.indexOf(',', ind5+1);
    J5newSteps = data.substring(ind5+1, ind6).toFloat();
    ind7 = data.indexOf(',', ind6+1);
    J6newSteps = data.substring(ind6+1, ind7).toFloat();
    ind8 = data.indexOf(',', ind7+1 );
    speedMultiplier = data.substring(ind7+1, ind8).toInt();
    ind9 = data.indexOf(',', ind8+1 );
    accelMultiplier = data.substring(ind8+1, ind9).toInt();

    data = "";
    driveToAngle = true;
  }
  
  if(data.startsWith("calibration"))
  {
    //calibrating
    
    ind21 = data.indexOf(',');
    ind22 = data.indexOf(',', ind21+1 );
    J1calibration = data.substring(ind21+1, ind22).toInt();
    ind23 = data.indexOf(',', ind22+1 );
    J2calibration = data.substring(ind22+1, ind23).toInt();
    ind24 = data.indexOf(',', ind23+1 );
    J3calibration = data.substring(ind23+1, ind24).toInt();
    ind25 = data.indexOf(',', ind24+1 );
    J4calibration = data.substring(ind24+1, ind25).toInt();
    ind26 = data.indexOf(',', ind25+1 );
    J5calibration = data.substring(ind25+1, ind26).toInt();
    J6calibration = data.substring(ind26+1).toInt();

    data = "";

    J1isCalibrated = J1calibration;
    J2isCalibrated = J2calibration;
    J3isCalibrated = J3calibration;
    J4isCalibrated = J4calibration;
    J5isCalibrated = J5calibration;
    J6isCalibrated = J6calibration;

    driveToAngle = false;
    jointsCalibrating = true;
  }

//-----------------------------Jogging the axis-----------------------------//

  if(data.startsWith("jogJ1-"))
  {
    indJ1 = data.indexOf(',');
    J1jogSpeedMultiplier = data.substring(indJ1+1).toInt();
    J1jogSpeed = J1maxJogSpeed + (100 * J1jogSpeedMultiplier^2) - 100;
    
    digitalWrite(13, HIGH);
    J1jogging = true;
    J1dir = 0;
    digitalWrite(J1dirPin, J1dir);
    driveToAngle = false;
  }
  if(data.startsWith("jogJ1+"))
  {
    indJ1 = data.indexOf(',');
    J1jogSpeedMultiplier = data.substring(indJ1+1).toInt();
    J1jogSpeed = J1maxJogSpeed + (100 * J1jogSpeedMultiplier^2) - 100;
    
    digitalWrite(13, HIGH);
    J1jogging = true;
    J1dir = 1;
    digitalWrite(J1dirPin, J1dir);
    driveToAngle = false;
  }
  if(data.startsWith("jogJ2-"))
  {
    digitalWrite(13, HIGH);
    J2jogging = true;
    J2dir = 1;
    digitalWrite(J2dirPin, J2dir);
    driveToAngle = false;
  }
  if(data.startsWith("jogJ2+"))
  {
    digitalWrite(13, HIGH);
    J2jogging = true;
    J2dir = 0;
    digitalWrite(J2dirPin, J2dir);
    driveToAngle = false;
  }
  if(data.startsWith("jogJ3-"))
  {
    digitalWrite(13, HIGH);
    J3jogging = true;
    J3dir = 0;
    digitalWrite(J3dirPin, J3dir);
    driveToAngle = false;
  }
  if(data.startsWith("jogJ3+"))
  {
    digitalWrite(13, HIGH);
    J3jogging = true;
    J3dir = 1;
    digitalWrite(J3dirPin, J3dir);
    driveToAngle = false;
  }
  if(data.startsWith("jogJ4-"))
  {
    digitalWrite(13, HIGH);
    J4jogging = true;
    J4dir = 0;
    digitalWrite(J4dirPin, J4dir);
    driveToAngle = false;
  }
  if(data.startsWith("jogJ4+"))
  {
    digitalWrite(13, HIGH);
    J4jogging = true;
    J4dir = 1;
    digitalWrite(J4dirPin, J4dir);
    driveToAngle = false;
  }
  if(data.startsWith("jogJ5-"))
  {
    digitalWrite(13, HIGH);
    J5jogging = true;
    J5dir = 0;
    digitalWrite(J5dirPin, J5dir);
    driveToAngle = false;
  }
  if(data.startsWith("jogJ5+"))
  {
    digitalWrite(13, HIGH);
    J5jogging = true;
    J5dir = 1;
    digitalWrite(J5dirPin, J5dir);
    driveToAngle = false;
  }
  if(data.startsWith("jogJ6-"))
  {
    digitalWrite(13, HIGH);
    J6jogging = true;
    J6dir = 0;
    digitalWrite(J6dirPin, J6dir);
    driveToAngle = false;
  }
  if(data.startsWith("jogJ6+"))
  {
    digitalWrite(13, HIGH);
    J6jogging = true;
    J6dir = 1;
    digitalWrite(J6dirPin, J6dir);
    driveToAngle = false;
  }

  if(data == "stop")
  {
    if(J1jogging = true)
    {
      J1jogging = false;
      Serial.println(J1prevSteps);
    }
    if(J2jogging = true)
    {
      J2jogging = false;
      Serial.println(J2prevSteps);
    }
    if(J3jogging = true)
    {
      J3jogging = false;
      Serial.println(J3prevSteps);
    }
    if(J4jogging = true)
    {
      J4jogging = false;
      Serial.println(J4prevSteps);
    }
    if(J5jogging = true)
    {
      J5jogging = false;
      Serial.println(J5prevSteps);
    }
    if(J6jogging = true)
    {
      J6jogging = false;
      Serial.println(J6prevSteps);
    }
    
    data = "";
    digitalWrite(13, LOW);
    isMoving = false;
  }

  if(J1jogging == true)
  {
      if(J1dir == 0 && J1minSteps < J1prevSteps)
      {
        J1prevSteps--;

        digitalWrite(J1stepPin,HIGH);
        delayMicroseconds(J1jogSpeed);
        digitalWrite(J1stepPin, LOW);
      }
      if(J1dir == 1 && J1prevSteps < J1maxSteps)
      {
        J1prevSteps++;

        digitalWrite(J1stepPin,HIGH);
        delayMicroseconds(J1jogSpeed);
        digitalWrite(J1stepPin, LOW);
      }
  }

  if(J2jogging == true)
  {
      if(J2dir == 0 && J2prevSteps < J2maxSteps)
      {
        J2prevSteps++;

        digitalWrite(J2stepPin,HIGH);
        delayMicroseconds(750);
        digitalWrite(J2stepPin, LOW);
      }
      if(J2dir == 1 && J2minSteps < J2prevSteps)
      {
        J2prevSteps--;

        digitalWrite(J2stepPin,HIGH);
        delayMicroseconds(750);
        digitalWrite(J2stepPin, LOW);
      }
  }

  if(J3jogging == true)
  {
      if(J3dir == 0 && J3minSteps < J3prevSteps)
      {
        J3prevSteps--;

        digitalWrite(J3stepPin,HIGH);
        delayMicroseconds(1250);
        digitalWrite(J3stepPin, LOW);
      }
      if(J3dir == 1 && J3prevSteps < J3maxSteps)
      {
        J3prevSteps++;

        digitalWrite(J3stepPin,HIGH);
        delayMicroseconds(1250);
        digitalWrite(J3stepPin, LOW);
      }
  }

  if(J4jogging == true)
  {
      if(J4dir == 0 && J4minSteps < J4prevSteps)
      {
        J4prevSteps--;

        digitalWrite(J4stepPin,HIGH);
        delayMicroseconds(1500);
        digitalWrite(J4stepPin, LOW);
      }
      if(J4dir == 1 && J4prevSteps < J4maxSteps)
      {
        J4prevSteps++;

        digitalWrite(J4stepPin,HIGH);
        delayMicroseconds(1500);
        digitalWrite(J4stepPin, LOW);
      }
  }

  if(J5jogging == true)
  {
      if(J5dir == 0 && J5minSteps < J5prevSteps)
      {
        J5prevSteps--;

        digitalWrite(J5stepPin,HIGH);
        delayMicroseconds(1500);
        digitalWrite(J5stepPin, LOW);
      }
      if(J5dir == 1 && J5prevSteps < J5maxSteps)
      {
        J5prevSteps++;

        digitalWrite(J5stepPin,HIGH);
        delayMicroseconds(1500);
        digitalWrite(J5stepPin, LOW);
      }
  }

  if(J6jogging == true)
  {
      if(J6dir == 0 && J6minSteps < J6prevSteps)
      {
        J6prevSteps--;

        digitalWrite(J6stepPin,HIGH);
        delayMicroseconds(1500);
        digitalWrite(J6stepPin, LOW);
      }
      if(J6dir == 1 && J6prevSteps < J6maxSteps)
      {
        J6prevSteps++;

        digitalWrite(J6stepPin,HIGH);
        delayMicroseconds(1250);
        digitalWrite(J6stepPin, LOW);
      }
  }

//-----------------------------Enabling/Disabling joints-----------------------------//

if(data == "J1enable")
{
  digitalWrite(J1_ENABLE_PIN, LOW);
}
if(data == "J1disable")
{
  digitalWrite(J1_ENABLE_PIN, HIGH);
}
if(data == "J2enable")
{
  digitalWrite(J2_ENABLE_PIN, LOW);
}
if(data == "J2disable")
{
  digitalWrite(J2_ENABLE_PIN, HIGH);
}
if(data == "J3enable")
{
  digitalWrite(J3_ENABLE_PIN, LOW);
}
if(data == "J3disable")
{
  digitalWrite(J3_ENABLE_PIN, HIGH);
}
if(data == "J4enable")
{
  digitalWrite(J4_ENABLE_PIN, LOW);
}
if(data == "J4disable")
{
  digitalWrite(J4_ENABLE_PIN, HIGH);
}
if(data == "J5enable")
{
  digitalWrite(J5_ENABLE_PIN, LOW);
}
if(data == "J5disable")
{
  digitalWrite(J5_ENABLE_PIN, HIGH);
}
if(data == "J6enable")
{
  digitalWrite(J6_ENABLE_PIN, LOW);
}
if(data == "J6disable")
{
  digitalWrite(J6_ENABLE_PIN, HIGH);
}
if(data == "enableAll")
{
  digitalWrite(J1_ENABLE_PIN, LOW);
  digitalWrite(J2_ENABLE_PIN, LOW);
  digitalWrite(J3_ENABLE_PIN, LOW);
  digitalWrite(J4_ENABLE_PIN, LOW);
  digitalWrite(J5_ENABLE_PIN, LOW);
  digitalWrite(J6_ENABLE_PIN, LOW);
}
if(data == "disableAll")
{
  digitalWrite(J1_ENABLE_PIN, HIGH);
  digitalWrite(J2_ENABLE_PIN, HIGH);
  digitalWrite(J3_ENABLE_PIN, HIGH);
  digitalWrite(J4_ENABLE_PIN, HIGH);
  digitalWrite(J5_ENABLE_PIN, HIGH);
  digitalWrite(J6_ENABLE_PIN, HIGH);
}

if(data == "saveWP1")
{
  J1WP1 = J1prevSteps;
  J2WP1 = J2prevSteps;
  J3WP1 = J3prevSteps;
  J4WP1 = J4prevSteps;
  J5WP1 = J5prevSteps;
  J6WP1 = J6prevSteps;

  digitalWrite(13, HIGH);
  delay(200);
  digitalWrite(13, LOW);

  move1 = true;
}

if(data == "saveWP2")
{
  J1WP2 = J1prevSteps;
  J2WP2 = J2prevSteps;
  J3WP2 = J3prevSteps;
  J4WP2 = J4prevSteps;
  J5WP2 = J5prevSteps;
  J6WP2 = J6prevSteps;

  digitalWrite(13, HIGH);
  delay(200);
  digitalWrite(13, LOW);
  delay(200);
  digitalWrite(13, HIGH);
  delay(200);
  digitalWrite(13, LOW);
}

if(data == "saveWP3")
{
  J1WP3 = J1prevSteps;
  J2WP3 = J2prevSteps;
  J3WP3 = J3prevSteps;
  J4WP3 = J4prevSteps;
  J5WP3 = J5prevSteps;
  J6WP3 = J6prevSteps;

  digitalWrite(13, HIGH);
  delay(200);
  digitalWrite(13, LOW);
  delay(200);
  digitalWrite(13, HIGH);
  delay(200);
  digitalWrite(13, LOW);
  delay(200);
  digitalWrite(13, HIGH);
  delay(200);
  digitalWrite(13, LOW);
}

if(data == "PLAY")
{
  driveProgram = true;
}

if(driveProgram == true)
{
  digitalWrite(13, HIGH);
  
  if(move1 == true)
  {
    J1newSteps = J1WP1;
    J2newSteps = J2WP1;
    J3newSteps = J3WP1;
    J4newSteps = J4WP1;
    J5newSteps = J5WP1;
    J6newSteps = J6WP1;

    driveToAngle = true;
  }
  
  if(move2 == true)
  {
    J1newSteps = J1WP2;
    J2newSteps = J2WP2;
    J3newSteps = J3WP2;
    J4newSteps = J4WP2;
    J5newSteps = J5WP2;
    J6newSteps = J6WP2;

    driveToAngle = true;
  }

  if(move3 == true)
  {
    J1newSteps = J1WP3;
    J2newSteps = J2WP3;
    J3newSteps = J3WP3;
    J4newSteps = J4WP3;
    J5newSteps = J5WP3;
    J6newSteps = J6WP3;

    driveToAngle = true;
  }
}
if(driveProgram == false)
{
  digitalWrite(13, LOW);
  move1 = true;
}

//-----------------------------Driving the axis to specific angles-----------------------------//

  if(driveToAngle == true)
  {
    //calculate directions and step amounts
    
    if (J1newSteps < J1prevSteps)
    {
      J1dir = 0;
      J1stepsToGo = J1prevSteps - J1newSteps;
    }
    if (J1newSteps >= J1prevSteps)
    {
      J1dir = 1;
      J1stepsToGo = J1newSteps - J1prevSteps;
    }
    if (J2newSteps < J2prevSteps)
    {
      J2dir = 1;
      J2stepsToGo = J2prevSteps - J2newSteps;
    }
    if (J2newSteps >= J2prevSteps)
    {
      J2dir = 0;
      J2stepsToGo = J2newSteps - J2prevSteps;
    }
    if (J3newSteps < J3prevSteps)
    {
      J3dir = 0;
      J3stepsToGo = J3prevSteps - J3newSteps;
    }
    if (J3newSteps >= J3prevSteps)
    {
      J3dir = 1;
      J3stepsToGo = J3newSteps - J3prevSteps;
    }
    if (J4newSteps < J4prevSteps)
    {
      J4dir = 0;
      J4stepsToGo = J4prevSteps - J4newSteps;
    }
    if (J4newSteps >= J4prevSteps)
    {
      J4dir = 1;
      J4stepsToGo = J4newSteps - J4prevSteps;
    }
    if (J5newSteps < J5prevSteps)
    {
      J5dir = 0;
      J5stepsToGo = J5prevSteps - J5newSteps;
    }
    if (J5newSteps >= J5prevSteps)
    {
      J5dir = 1;
      J5stepsToGo = J5newSteps - J5prevSteps;
    }
    if (J6newSteps < J6prevSteps)
    {
      J6dir = 0;
      J6stepsToGo = J6prevSteps - J6newSteps;
    }
    if (J6newSteps >= J6prevSteps)
    {
      J6dir = 1;
      J6stepsToGo = J6newSteps - J6prevSteps;
    }
    
    float highestStep = J1stepsToGo;      //finds which stepper needs to move the most steps and assigns the value of highest steps to a variable highestStep
  
    if(J2stepsToGo > highestStep)
    {
      highestStep = J2stepsToGo;
    }
    if(J3stepsToGo > highestStep)
    {
      highestStep = J3stepsToGo;
    }
    if(J4stepsToGo > highestStep)
    {
      highestStep = J4stepsToGo;
    }
    if(J5stepsToGo > highestStep)
    {
      highestStep = J5stepsToGo;
    }
    if(J6stepsToGo > highestStep)
    {
      highestStep = J6stepsToGo;
    }

    float resolutionMultiplier = 10;

    float J1stepSkipF = highestStep / J1stepsToGo * resolutionMultiplier;       //Finding the numbers of steps that each stepper has to skip in order for the moves to be started and stopped simultaneously
    float J2stepSkipF = highestStep / J2stepsToGo * resolutionMultiplier;       //for example stepper 1 is taking a step every J1stepSkip step. IE if J1stepSkip is 4, then stepper 1 takes a step every fourth program loop
    float J3stepSkipF = highestStep / J3stepsToGo * resolutionMultiplier;
    float J4stepSkipF = highestStep / J4stepsToGo * resolutionMultiplier;
    float J5stepSkipF = highestStep / J5stepsToGo * resolutionMultiplier;
    float J6stepSkipF = highestStep / J6stepsToGo * resolutionMultiplier;

    int J1stepSkip = (int)J1stepSkipF;
    int J2stepSkip = (int)J2stepSkipF;
    int J3stepSkip = (int)J3stepSkipF;
    int J4stepSkip = (int)J4stepSkipF;
    int J5stepSkip = (int)J5stepSkipF;
    int J6stepSkip = (int)J6stepSkipF;

    digitalWrite(J1dirPin, J1dir);
    digitalWrite(J2dirPin, J2dir);
    digitalWrite(J3dirPin, J3dir);
    digitalWrite(J4dirPin, J4dir);
    digitalWrite(J5dirPin, J5dir);
    digitalWrite(J6dirPin, J6dir);

    if(highestStep == 0)
    {
      highestStepInt = 0;
    }
    else
    {
      highestStepInt = (long)highestStep * resolutionMultiplier;
    }
  
    while(commonCurrentStep < highestStepInt)
    {
      if(commonCurrentStep%J1stepSkip==0)
      {
        if(J1currentSteps < J1stepsToGo)
        {
          digitalWrite(J1stepPin,HIGH);
          delayMicroseconds(2);
          digitalWrite(J1stepPin, LOW);
          J1currentSteps++;
        }
      }

      if(commonCurrentStep%J2stepSkip==0)
      {
        if(J2currentSteps < J2stepsToGo)
        {
          digitalWrite(J2stepPin,HIGH);
          delayMicroseconds(2);
          digitalWrite(J2stepPin, LOW);
          J2currentSteps++;
        }
      }

      if(commonCurrentStep%J3stepSkip==0)
      {
        if(J3currentSteps < J3stepsToGo)
        {
          digitalWrite(J3stepPin,HIGH);
          delayMicroseconds(2);
          digitalWrite(J3stepPin, LOW);
          J3currentSteps++;
        }
      }

      if(commonCurrentStep%J4stepSkip==0)
      {
        if(J4currentSteps < J4stepsToGo)
        {
          digitalWrite(J4stepPin,HIGH);
          delayMicroseconds(2);
          digitalWrite(J4stepPin, LOW);
          J4currentSteps++;
        }
      }

      if(commonCurrentStep%J5stepSkip==0)
      {
        if(J5currentSteps < J5stepsToGo)
        {
          digitalWrite(J5stepPin,HIGH);
          delayMicroseconds(2);
          digitalWrite(J5stepPin, LOW);
          J5currentSteps++;
        }
      }
      if(commonCurrentStep%J6stepSkip==0)
      {
        if(J6currentSteps < J6stepsToGo)
        {
          digitalWrite(J6stepPin,HIGH);
          delayMicroseconds(2);
          digitalWrite(J6stepPin, LOW);
          J6currentSteps++;
        }
      }
      delayMicroseconds(10);
      commonCurrentStep++;
    }

    if(move3 == true)
    {
      move3 = false;
      driveProgram = false;
    }
    if(move2 == true)
    {
      move3 = true;
      move2 = false;
    }
    if(move1 == true)
    {
      move2 = true;
      move1 = false;
    }
    
    J1stepsToGo = 0;
    J1currentSteps = 0;
    J1prevSteps = J1newSteps;
    J2stepsToGo = 0;
    J2currentSteps = 0;
    J2prevSteps = J2newSteps;
    J3stepsToGo = 0;
    J3currentSteps = 0;
    J3prevSteps = J3newSteps;
    J4stepsToGo = 0;
    J4currentSteps = 0;
    J4prevSteps = J4newSteps;
    J5stepsToGo = 0;
    J5currentSteps = 0;
    J5prevSteps = J5newSteps;
    J6stepsToGo = 0;
    J6currentSteps = 0;
    J6prevSteps = J6newSteps;
    commonCurrentStep = 0;
    highestStepInt = 0;

    driveToAngle = false;
    isMoving = false;
  }

  //Serial.println(J1prevSteps);

  if(jointsCalibrating == true)
  {
    if(J1isCalibrated == false)
    {
      for(int x = 0; x < 20000; x++)
      {
        if(!digitalRead(J1limitSwitch))
        {
          break;
        }
        
        digitalWrite(J1_ENABLE_PIN, LOW);
        digitalWrite(J1dirPin, LOW);
            
        digitalWrite(J1stepPin,HIGH); 
        delayMicroseconds(J1calibrationSpeed); 
        digitalWrite(J1stepPin,LOW); 
        delayMicroseconds(J1calibrationSpeed);
      }
      for(int x = 0; x < J1calibrationReturn; x++)
      {
        digitalWrite(J1_ENABLE_PIN, LOW);
        digitalWrite(J1dirPin, HIGH);
        
        digitalWrite(J1stepPin,HIGH); 
        delayMicroseconds(J1calibrationReturnSpeed); 
        digitalWrite(J1stepPin,LOW); 
        delayMicroseconds(J1calibrationReturnSpeed);
      }
      
      J1isCalibrated = true;
      J1prevSteps = 0;
    }
    if(J2isCalibrated == false)
    {
      for(int x = 0; x < 40000; x++)
      {
        if(!digitalRead(J2limitSwitch))
        {
          break;
        }
        
        digitalWrite(J2_ENABLE_PIN, LOW);
        digitalWrite(J2dirPin, HIGH);
            
        digitalWrite(J2stepPin,HIGH); 
        delayMicroseconds(J2calibrationSpeed); 
        digitalWrite(J2stepPin,LOW); 
        delayMicroseconds(J2calibrationSpeed);
      }
      for(int x = 0; x < J2calibrationReturn; x++)
      {
        digitalWrite(J2_ENABLE_PIN, LOW);
        digitalWrite(J2dirPin, LOW);
        
        digitalWrite(J2stepPin,HIGH); 
        delayMicroseconds(J2calibrationReturnSpeed); 
        digitalWrite(J2stepPin,LOW); 
        delayMicroseconds(J2calibrationReturnSpeed);
      }
      
      J2isCalibrated = true;
      J2prevSteps = 0;
    }
    if(J3isCalibrated == false)
    {
      for(int x = 0; x < 10000; x++)
      {
        if(!digitalRead(J3limitSwitch))
        {
          break;
        }
        
        digitalWrite(J3_ENABLE_PIN, LOW);
        digitalWrite(J3dirPin, LOW);
            
        digitalWrite(J3stepPin,HIGH); 
        delayMicroseconds(J3calibrationSpeed); 
        digitalWrite(J3stepPin,LOW); 
        delayMicroseconds(J3calibrationSpeed);
      }
      for(int x = 0; x < J3calibrationReturn; x++)
      {
        digitalWrite(J3_ENABLE_PIN, LOW);
        digitalWrite(J3dirPin, HIGH);
        
        digitalWrite(J3stepPin,HIGH); 
        delayMicroseconds(J3calibrationReturnSpeed); 
        digitalWrite(J3stepPin,LOW); 
        delayMicroseconds(J3calibrationReturnSpeed);
      }
      
      J3isCalibrated = true;
      J3prevSteps = 0;
    }
    if(J4isCalibrated == false)
    {
      //kalibroi 4
      J4isCalibrated = true;
    }
    if(J5isCalibrated == false)
    {
      //kalibroi 5
      J5isCalibrated = true;
    }
    if(J6isCalibrated == false)
    {
      //kalibroi 6
      J6isCalibrated = true;
    }
    
    jointsCalibrating = false;
  }
}












  if(dataIn.startsWith("drive"))
  {
    
    ind1 = data.indexOf(',');
    ind2 = data.indexOf(',', ind1+1 );
    servo1PPos = data.substring(ind1+1, ind2).toInt();
    servo01.write(servo1PPos);
    ind3 = data.indexOf(',', ind2+1 );
    servo2PPos = data.substring(ind2+1, ind3).toInt();
    servo02.write(servo2PPos);
    ind4 = data.indexOf(',', ind3+1 );
    servo3PPos = data.substring(ind3+1, ind4).toInt();
    servo03.write(servo3PPos);
    ind5 = data.indexOf(',', ind4+1);
    servo4PPos = data.substring(ind4+1, ind5).toInt();
    servo04.write(servo4PPos);
    ind6 = data.indexOf(',', ind5+1);
    servo5PPos = data.substring(ind5+1, ind6).toInt();
    servo05.write(servo5PPos);
    ind7 = data.indexOf(',', ind6+1);
    servo6PPos = data.substring(ind6+1, ind7).toInt();
    servo06.write(servo6PPos);
    ind8 = data.indexOf(',', ind7+1 );
    speedDelay  = data.substring(ind7+1, ind8).toInt();
    dataIn = "";
  }
