#include <VirtualWire.h>

#define TX 4
#define RX 11
#define TXen 10


void setup()
{
    delay(1000);
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

      for(int i=0;i<buflen;i++) Serial.print((char)buf[i]);
      Serial.print ("\n");
    }

}

