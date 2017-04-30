
#include <VirtualWire.h>

#define TX 4
#define RX 11
#define TXen 10


void setup()
{
    delay(1000);
    //ServoDir.attach(PinServo);
    vw_set_tx_pin(TX);
    vw_set_rx_pin(RX);
    vw_set_ptt_pin(TXen);
    vw_set_ptt_inverted(true); 
    Serial.begin(9600);
    vw_setup(2000);       
    vw_rx_start();

}
void loop()
{
  
    uint8_t buf[VW_MAX_MESSAGE_LEN];
    uint8_t buflen = VW_MAX_MESSAGE_LEN;
    if (vw_get_message(buf, &buflen)) 
    {
      //Serial.print("Hola\n");
      String datos = buf;
     // Serial.print (String(datos));

      for(int i=0;i<buflen;i++) Serial.println((char)buf[i]);
    }

}
    


/*String getValue(String data, char separator, int index)
{
  int found = 0;
  int strIndex[] = {0, -1 };
  int maxIndex = data.length()-1;
  for(int i=0; i<=maxIndex && found<=index; i++){
  if(data.charAt(i)==separator || i==maxIndex){
  found++;
  strIndex[0] = strIndex[1]+1;
  strIndex[1] = (i == maxIndex) ? i+1 : i;
  }
 }
  return found>index ? data.substring(strIndex[0], strIndex[1]) : "";
}*/
