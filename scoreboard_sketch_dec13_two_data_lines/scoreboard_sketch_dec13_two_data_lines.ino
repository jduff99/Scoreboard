#include <PololuLedStrip.h>

PololuLedStrip<12> ledStripTime;
PololuLedStrip<11> ledStripScore;
#define LED_COUNTscore 168
#define LED_COUNTtime 148
rgb_color colorsScore[LED_COUNTscore];
rgb_color colorsTime[LED_COUNTtime];

void setup() {
  // put your setup code here, to run once:
  
}
//count is a temp marker to test drive digits eventually replace with time and score 
//int count[6]; 
int count = 9;



void lightLED(int digit, int num, int SegLEDs, int DataStrip){
  //marker A
  if (num == 9 || num == 8 || num == 6 || num == 5 || num == 4 || num == 3 || num == 2){
    //turn on segLEDs leds starting at (digit*42+1)
     for (int i = digit*42; i < digit*42+SegLEDs; i++){
      if (digit < 2 and DataStrip == 1){
        colorsScore[i] = rgb_color(0, 0, 255);
      }
      else if (digit > 1 and DataStrip == 1){
        colorsScore[i] = rgb_color(200, 200, 200);
      }
      else{
        colorsTime[i] = rgb_color(255, 0, 0);
      }
     }   
  }
  else if (DataStrip == 1){
    for (int i = digit*42; i < digit*42+SegLEDs; i++){
        colorsScore[i] = rgb_color(0, 0, 0);
    }
  }
  else{
    for (int i = digit*42; i < digit*42+SegLEDs; i++){
        colorsTime[i] = rgb_color(0, 0, 0);
    }
  }
  
  //marker B
  if (num != 2){
    //turn on segLEDs leds starting at (digit*42+7)
    for (int i = digit*42+6; i < digit*42+6+SegLEDs; i++){
      if (digit < 2 and DataStrip== 1){
        colorsScore[i] = rgb_color(0, 0, 255);
      }
      else if (digit > 1 and DataStrip == 1){
        colorsScore[i] = rgb_color(200, 200, 200);
      }
      else{
        colorsTime[i] = rgb_color(255, 0, 0);
      }
     }
  }
  else if (DataStrip == 1){
    for (int i = digit*42; i < digit*42+SegLEDs; i++){
        colorsScore[i] = rgb_color(0, 0, 0);
    }
  }
  else{
    for (int i = digit*42; i < digit*42+SegLEDs; i++){
        colorsTime[i] = rgb_color(0, 0, 0);
    }
  }
  
  //marker C
  if (num == 0 or num == 2 or num == 3 or num == 5 or num == 6 or num == 8 or num == 9){
    //turn on segLEDs leds starting at (digit*42+13)
     for (int i = digit*42+12; i < digit*42+12+SegLEDs; i++){
      if (digit < 2 and DataStrip == 1){
        colorsScore[i] = rgb_color(0, 0, 255);
      }
      else if (digit > 1 and DataStrip == 1){
        colorsScore[i] = rgb_color(200, 200, 200);
      }
      else{
        colorsTime[i] = rgb_color(255, 0, 0);
      }
     }
  }
  else if (DataStrip == 1){
    for (int i = digit*42; i < digit*42+SegLEDs; i++){
        colorsScore[i] = rgb_color(0, 0, 0);
    }
  }
  else{
    for (int i = digit*42; i < digit*42+SegLEDs; i++){
        colorsTime[i] = rgb_color(0, 0, 0);
    }
  }

  //marker D
  if (num == 0 or num == 2 or num == 6 or num == 8){
    //turn on segLEDs leds starting at (digit*42+19)
     for (int i = digit*42+18; i < digit*42+18+SegLEDs; i++){
      if (digit < 2 and DataStrip == 1){
        colorsScore[i] = rgb_color(0, 0, 255);
      }
      else if (digit > 1 and DataStrip == 1){
        colorsScore[i] = rgb_color(200, 200, 200);
      }
      else{
        colorsTime[i] = rgb_color(255, 0, 0);
      }
     }
  }
  else if (DataStrip == 1){
    for (int i = digit*42; i < digit*42+SegLEDs; i++){
        colorsScore[i] = rgb_color(0, 0, 0);
    }
  }
  else{
    for (int i = digit*42; i < digit*42+SegLEDs; i++){
        colorsTime[i] = rgb_color(0, 0, 0);
    }
  }

  //marker E
  if (num == 0 or num == 4 or num == 5 or num == 6 or num == 8 or num == 9){
    //turn on segLEDs leds starting at (digit*42+25)
     for (int i = digit*42+24; i < digit*42+24+SegLEDs; i++){
      if (digit < 2 and DataStrip == 1){
        colorsScore[i] = rgb_color(0, 0, 255);
      }
      else if (digit > 1 and DataStrip == 1){
        colorsScore[i] = rgb_color(200, 200, 200);
      }
      else{
        colorsTime[i] = rgb_color(255, 0, 0);
      }
     }
  }
  else if (DataStrip == 1){
    for (int i = digit*42; i < digit*42+SegLEDs; i++){
        colorsScore[i] = rgb_color(0, 0, 0);
    }
  }
  else{
    for (int i = digit*42; i < digit*42+SegLEDs; i++){
        colorsTime[i] = rgb_color(0, 0, 0);
    }
  }

  //marker F
  if (num != 1 and num != 4){
    //turn on segLEDs leds starting at (digit*42+31)
     for (int i = digit*42+30; i < digit*42+30+SegLEDs; i++){
      if (digit < 2 and DataStrip == 1){
        colorsScore[i] = rgb_color(0, 0, 255);
      }
      else if (digit > 1 and DataStrip == 1){
        colorsScore[i] = rgb_color(200, 200, 200);
      }
      else{
        colorsTime[i] = rgb_color(255, 0, 0);
      }
     }
  }
  else if (DataStrip == 1){
    for (int i = digit*42; i < digit*42+SegLEDs; i++){
        colorsScore[i] = rgb_color(0, 0, 0);
    }
  }
  else{
    for (int i = digit*42; i < digit*42+SegLEDs; i++){
        colorsTime[i] = rgb_color(0, 0, 0);
    }
  }

  //marker G
  if (num != 5 and num != 6){
    //turn on segLEDs leds starting at (digit*42+37)
     for (int i = digit*42+36; i < digit*42+36+SegLEDs; i++){
      if (digit < 2 and DataStrip == 1){
        colorsScore[i] = rgb_color(0, 0, 255);
      }
      else if (digit > 1 and DataStrip == 1){
        colorsScore[i] = rgb_color(200, 200, 200);
      }
      else{
        colorsTime[i] = rgb_color(255, 0, 0);
      }
     }
  }
  else if (DataStrip == 1){
    for (int i = digit*42; i < digit*42+SegLEDs; i++){
        colorsScore[i] = rgb_color(0, 0, 0);
    }
  }
  else{
    for (int i = digit*42; i < digit*42+SegLEDs; i++){
        colorsTime[i] = rgb_color(0, 0, 0);
    }
  }
}


//LOOP

void loop() {
  // put your main code here, to run repeatedly:
  //colon in red
  colorsTime[148] = rgb_color(255, 0, 0);
  //colorsTime[147] = rgb_color(255, 0, 0); Not needed?

  //determine which leds to light
  for (int j=0; j < 4; j++){
    lightLED (j, count, 6, 1);   
  }
  for (int k=0; k < 3; k++){
    lightLED (k, count, 6, 2);    
  }
  lightLED (3, count, 3, 2);
  
  //write to leds
  ledStripScore.write(colorsScore, LED_COUNTscore);
  ledStripTime.write(colorsTime, LED_COUNTtime);
  

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

