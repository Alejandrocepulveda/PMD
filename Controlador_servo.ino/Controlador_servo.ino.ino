#include <Servo.h>

Servo myservo1; // Crea el objeto servo para el pulgar
Servo myservo2; // Crea el objeto servo para el índice
Servo myservo3; // Crea el objeto servo para el medio
Servo myservo4; // Crea el objeto servo para el anular
Servo myservo5; // Crea el objeto servo para el meñique
//Servo myservo6; // Crea el objeto servo para la muñeca 

void setup() 
{
    Serial.begin(9600);  //Inicia la comunicacion seria a 9600 baudios 
    myservo1.attach(2);  // Conecta el servo del pulgar al pin 2
    myservo2.attach(3);  // Conecta el servo del indice al pin 3
    myservo3.attach(4);  // Conecta el servo del medio al pin 4
    myservo4.attach(5);  // Conecta el servo del anular al pin 5
    myservo5.attach(6);  // Conecta el servo del meñique al pin 6
   // myservo6.attach(7);  // Conecta el servo de la muñeca al pin 7

    myservo1.write(129);       // Posicion del pulgar 
    myservo2.write(150);       // Pocicion del indice 
    myservo3.write(150);       // Pocicon del medio 
    myservo4.write(150);       // Pocion del anular 
    myservo5.write(150);       // Pocion del meñique 
    //myservo6.write(150);       // Pocion de la muñeca 
    delay(2000);               // Espera dos segundos para estabilizar 
}

void loop() 
{
  myservo1.write(129);
    myservo2.write(150);
    myservo3.write(150);
    myservo4.write(150);
    myservo5.write(150);
    // myservo6.write(100); // Si quieres usarlo, descomenta
    delay(1000);
  
    myservo1.write(50);
    myservo2.write(10);
    myservo3.write(10);
    myservo4.write(10);
    myservo5.write(10);
    // myservo6.write(50); // Si quieres usarlo, descomenta
    delay(1000);

    myservo1.write(129);
    myservo2.write(150);
    myservo3.write(150);
    myservo4.write(150);
    myservo5.write(150);
    // myservo6.write(100); // Si quieres usarlo, descomenta
    delay(1000);

    myservo1.write(50);
    delay(300);
    myservo1.write(129);
    delay(300);

    myservo2.write(10);
    delay(500);
    myservo2.write(150);
    delay(300);

    myservo3.write(10);
    delay(500);
    myservo3.write(150);
    delay(300);

    myservo4.write(10);
    delay(500);
    myservo4.write(150);
    delay(300);

    myservo5.write(10);
    delay(500);
    myservo5.write(150);
    delay(300);

    //myservo6.write(150);
    //delay(700);
    //myservo1.write(100);
    delay(700);
}
