#include <PololuLedStrip.h>

PololuLedStrip<12> ledStrip;
#define LED_COUNT 317
rgb_color colors[LED_COUNT];
const byte numChars = 8;
char SerialData[numChars];   // an array to store the received data

boolean newData = false;
void setup() {
  Serial.begin(9600);
  // put your setup code here, to run once:
  
}
//count is a temp marker to test drive digits eventually replace with time and score 
int count[9]; 
int z = 0;
//int count = 9;
//char SerialData = "12345678";


void lightLED(int digit, int num, int SegLEDs){
  //marker A
  if (num == 9 || num == 8 || num == 6 || num == 5 || num == 4 || num == 3 || num == 2){
    //turn on segLEDs leds starting at (digit*42+1)
     for (int i = digit*42; i < digit*42+SegLEDs; i++){
      if (digit < 2){
        colors[i] = rgb_color(0, 0, 255);
      }
      else if (digit == 5 || digit == 6){
        colors[i] = rgb_color(200, 200, 200);
      }
      else{
        colors[i] = rgb_color(255, 0, 0);
      }
     }   
  }
  else{
    for (int i = digit*42; i < digit*42+SegLEDs; i++){
        colors[i] = rgb_color(0, 0, 0);
    }
  }
  
  //marker B
  if (num != 2){
    //turn on segLEDs leds starting at (digit*42+7)
    for (int i = digit*42+6; i < digit*42+6+SegLEDs; i++){
      if (digit < 2){
        colors[i] = rgb_color(0, 0, 255);
      }
      else if (digit == 6 || digit == 5){
        colors[i] = rgb_color(200, 200, 200);
      }
      else{
        colors[i] = rgb_color(255, 0, 0);
      }
     }
  }
  else{
      for (int i = digit*42+6; i < digit*42+6+SegLEDs; i++){
        colors[i] = rgb_color(0, 0, 0);
     }
  }

  //marker C
  if (num == 0 or num == 2 or num == 3 or num == 5 or num == 6 or num == 8 or num == 9){
    //turn on segLEDs leds starting at (digit*42+13)
     for (int i = digit*42+12; i < digit*42+12+SegLEDs; i++){
      if (digit < 2){
        colors[i] = rgb_color(0, 0, 255);
      }
      else if (digit == 6 || digit == 5){
        colors[i] = rgb_color(200, 200, 200);
      }
      else{
        colors[i] = rgb_color(255, 0, 0);
      }
     }
  }
  else{
      for (int i = digit*42+12; i < digit*42+12+SegLEDs; i++){
        colors[i] = rgb_color(0, 0, 0);
     }
  }

  //marker D
  if (num == 0 or num == 2 or num == 6 or num == 8){
    //turn on segLEDs leds starting at (digit*42+19)
     for (int i = digit*42+18; i < digit*42+18+SegLEDs; i++){
      if (digit < 2){
        colors[i] = rgb_color(0, 0, 255);
      }
      else if (digit == 6 || digit == 5){
        colors[i] = rgb_color(200, 200, 200);
      }
      else{
        colors[i] = rgb_color(255, 0, 0);
      }
     }
  }
  else{
      for (int i = digit*42+18; i < digit*42+18+SegLEDs; i++){
        colors[i] = rgb_color(0, 0, 0);
     }
  }

  //marker E
  if (num == 0 or num == 4 or num == 5 or num == 6 or num == 8 or num == 9){
    //turn on segLEDs leds starting at (digit*42+25)
     for (int i = digit*42+24; i < digit*42+24+SegLEDs; i++){
      if (digit < 2){
        colors[i] = rgb_color(0, 0, 255);
      }
      else if (digit == 6 || digit == 5){
        colors[i] = rgb_color(200, 200, 200);
      }
      else{
        colors[i] = rgb_color(255, 0, 0);
      }
     }
  }
  else{
      for (int i = digit*42+24; i < digit*42+24+SegLEDs; i++){
        colors[i] = rgb_color(0, 0, 0);
     }
  }

  //marker F
  if (num != 1 and num != 4){
    //turn on segLEDs leds starting at (digit*42+31)
     for (int i = digit*42+30; i < digit*42+30+SegLEDs; i++){
      if (digit < 2){
        colors[i] = rgb_color(0, 0, 255);
      }
      else if (digit == 6 || digit == 5){
        colors[i] = rgb_color(200, 200, 200);
      }
      else{
        colors[i] = rgb_color(255, 0, 0);
      }
     }
  }
  else{
      for (int i = digit*42+30; i < digit*42+30+SegLEDs; i++){
        colors[i] = rgb_color(0, 0, 0);
     }
  }

  //marker G
  if (num != 5 and num != 6){
    //turn on segLEDs leds starting at (digit*42+37)
     for (int i = digit*42+36; i < digit*42+36+SegLEDs; i++){
      if (digit < 2){
        colors[i] = rgb_color(0, 0, 255);
      }
      else if (digit == 6 || digit == 5){
        colors[i] = rgb_color(200, 200, 200);
      }
      else{
        colors[i] = rgb_color(255, 0, 0);
      }
     }
  }
  else{
      for (int i = digit*42+36; i < digit*42+36+SegLEDs; i++){
        colors[i] = rgb_color(0, 0, 0);
     }
  }
}

//For Period Light (3 lights per segment)
void lightLEDperiod(int digit, int num, int SegLEDs){
  //marker A
  if (num == 9 || num == 8 || num == 6 || num == 5 || num == 4 || num == 3 || num == 2){
    //turn on segLEDs leds starting at (digit*42+1)
     for (int i = digit*42; i < digit*42+SegLEDs; i++){
         colors[i] = rgb_color(255, 0, 0);
     }
  }
  else{
    for (int i = digit*42; i < digit*42+SegLEDs; i++){
        colors[i] = rgb_color(0, 0, 0);
    }
  }
  
  //marker B
  if (num != 2){
    //turn on segLEDs leds starting at (digit*42+7)
    for (int i = digit*42+3; i < digit*42+3+SegLEDs; i++){
        colors[i] = rgb_color(255, 0, 0);
     }
  }
  else{
      for (int i = digit*42+3; i < digit*42+3+SegLEDs; i++){
        colors[i] = rgb_color(0, 0, 0);
     }
  }

  //marker C
  if (num == 0 or num == 2 or num == 3 or num == 5 or num == 6 or num == 8 or num == 9){
    //turn on segLEDs leds starting at (digit*42+13)
     for (int i = digit*42+6; i < digit*42+6+SegLEDs; i++){
        colors[i] = rgb_color(255, 0, 0);
     }
  }
  else{
      for (int i = digit*42+6; i < digit*42+6+SegLEDs; i++){
        colors[i] = rgb_color(0, 0, 0);
     }
  }

  //marker D
  if (num == 0 or num == 2 or num == 6 or num == 8){
    //turn on segLEDs leds starting at (digit*42+19)
     for (int i = digit*42+9; i < digit*42+9+SegLEDs; i++){
        colors[i] = rgb_color(255, 0, 0);
     }
  }
  else{
      for (int i = digit*42+9; i < digit*42+9+SegLEDs; i++){
        colors[i] = rgb_color(0, 0, 0);
     }
  }

  //marker E
  if (num == 0 or num == 4 or num == 5 or num == 6 or num == 8 or num == 9){
    //turn on segLEDs leds starting at (digit*42+25)
     for (int i = digit*42+12; i < digit*42+12+SegLEDs; i++){
        colors[i] = rgb_color(255, 0, 0);
     }
  }
  else{
      for (int i = digit*42+12; i < digit*42+12+SegLEDs; i++){
        colors[i] = rgb_color(0, 0, 0);
     }
  }

  //marker F
  if (num != 1 and num != 4){
    //turn on segLEDs leds starting at (digit*42+31)
     for (int i = digit*42+15; i < digit*42+15+SegLEDs; i++){
        colors[i] = rgb_color(255, 0, 0);
     }
  }
  else{
      for (int i = digit*42+15; i < digit*42+15+SegLEDs; i++){
        colors[i] = rgb_color(0, 0, 0);
     }
  }

  //marker G
  if (num != 5 and num != 6){
    //turn on segLEDs leds starting at (digit*42+37)
     for (int i = digit*42+18; i < digit*42+18+SegLEDs; i++){
        colors[i] = rgb_color(255, 0, 0);
     }
  }
  else{
      for (int i = digit*42+18; i < digit*42+18+SegLEDs; i++){
        colors[i] = rgb_color(0, 0, 0);
     }
  }
}

//LOOP
void loop() {
  //colon in red
  colors[315] = rgb_color(255, 0, 0);
  colors[316] = rgb_color(255, 0, 0);

  while (Serial.available() > 0) {
    if (z < 8){
      char temp = Serial.read();
      count[z] = (int)temp - 48;
      z++;
    }
    else{
      z = 0;
      char temp = Serial.read();
      count[z] = (int)temp - 48;
    }
  }

  //finish conversion to int array
  //determine which leds to light
  for (int j=0; j < 7; j++){
    lightLED (j, count[j], 6);      
  }
  lightLEDperiod (7, count[7], 3);
  
  //write to leds
  ledStrip.write(colors, LED_COUNT);

}

