#include "DHT.h"
#define DHTPIN 2
#define DHTTYPE DHT22
DHT dht(DHTPIN, DHTTYPE);

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);

  dht.begin();
}

byte senddata[4];
void loop() {
  // put your main code here, to run repeatedly:
  delay(2000);

  float h = dht.readHumidity(); // 습도
  float t = dht.readTemperature(); // 온도
  
  if (isnan(h) || isnan(t)) {
    Serial.println(F("Failed to read from DHT sensor!"));
    return;
  }

  senddata[0] = (byte)((t*100)/256); // 온도
  senddata[1] = (byte)(((int)t*100)%256);
  senddata[2] = (byte)((h*100)/256); // 습도
  senddata[3] = (byte)(((int)h*100)%256);
  Serial.write(senddata, 4);


}
