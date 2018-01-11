#include <PololuLedStrip.h>

PololuLedStrip<12> ledStrip;
#define LED_COUNT 21
rgb_color colors[LED_COUNT];

void setup() {
  // put your setup code here, to run once:
  
}
//count is a temp marker to test drive digits eventually replace with time and score 
//int count[6]; 
int count = 9;



void lightLEDperiod(int digit, int num, int SegLEDs){
  //marker A
  if (num == 9 || num == 8 || num == 6 || num == 5 || num == 4 || num == 3 || num == 2){
    //turn on segLEDs leds starting at (digit*42+1)
     for (int i = digit*42; i < digit*42+SegLEDs; i++){
         colors[i] = rgb_color(0, 0, 255);
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
        colors[i] = rgb_color(0, 0, 255);
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
        colors[i] = rgb_color(0, 0, 255);
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
        colors[i] = rgb_color(0, 0, 255);
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
        colors[i] = rgb_color(0, 0, 255);
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
        colors[i] = rgb_color(0, 0, 255);
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
        colors[i] = rgb_color(0, 0, 255);
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
  lightLED (0, count, 3);
  
  //write to leds

  ledStrip.write(colors, LED_COUNT);
  

  //temp code
  delay(1000); //1 second delay
  if (count==0){
    count = 9;
  }
  else{
    count = count - 1;
  }
  //temp code end
}

