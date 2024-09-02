// LCD
#include <Wire.h> 
#include <LiquidCrystal_I2C.h>
//주소,//가로폭//라인갯수
LiquidCrystal_I2C lcd(0x27,16,2); 

// 온습도
#include "DHT.h"
#define DHTPIN 2
#define DHTTYPE DHT22
DHT dht(DHTPIN, DHTTYPE);

// 글자 정의
byte On[8] = { // 5*8 패턴
        B00000,
        B01110,
        B10001,
        B01110,
        B00100,
        B11111,
        B10000,
        B11111
};
byte Do[8] = {
        B00000,
        B11111,
        B10000,
        B10000,
        B11111,
        B00000,
        B00100,
        B11111
};
byte s[8] = {
        B00100,
        B01010,
        B10001,
        B00000,
        B11111,
        B00000,
        B10101,
        B11111
};

void setup()
{
  Serial.begin(9600);
  lcd.init();
  lcd.backlight();

  // 정의 문자 생성
  // 총 8개의 정의 문자를 생상하여 사용이 가능하다.
  // 매개변수 : 정의문자 위치, 배열
  lcd.createChar(0,On);  
  lcd.createChar(1,Do);  
  lcd.createChar(2,s);


  dht.begin();
}


byte senddata[4];
byte recv[4];
void loop()
{

   delay(2000);
  float h = dht.readHumidity();
  float t = dht.readTemperature();

  if (isnan(h) || isnan(t)) {
  Serial.println(F("온습도 체크 실패"));
  return;
  }

  
  senddata[0] = (byte)((t*100)/256); // 온도
  senddata[1] = (byte)(((int)t*100)%256);
  senddata[2] = (byte)((h*100)/256); // 습도
  senddata[3] = (byte)(((int)h*100)%256);
  Serial.write(senddata, 4);


  
  if(Serial.available() >= 4){

      Serial.readBytes(recv, 4);

      //float
      float t = ((recv[0]*256) + recv[1]) / 100.0f;
      float h = ((recv[2]*256) + recv[3]) / 100.0f;
      // int t = recv[0]*256 + recv[1];
      // int h = recv[2]*256 + recv[3];

      lcd.clear();    // 화면 지우기
      lcd.setCursor(0,0);   // 커서 이동
      
      // write vs print
      // wrtie : 주로 한 문자 출력 또는 lcd에 문자를 표시할 때 사용
      // print : 문자열, 정수, 부동 소수점 등
      lcd.write(0); // 생성된 문자 패턴 중 0번째 문자를 사용한다.
      lcd.write(1);
      lcd.print(" : ");
      lcd.print(t);
      lcd.print("'C");
      
      


      lcd.setCursor(0,1);   // 열, 행 설정
      lcd.write(2);
      lcd.write(1);
      lcd.print(" : ");
      lcd.print(h);
      lcd.print("%");

  }
    
}
  
