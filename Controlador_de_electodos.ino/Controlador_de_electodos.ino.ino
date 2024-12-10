#include <Servo.h>

Servo myservo1; // Pulgar
Servo myservo2; // Índice
Servo myservo3; // Medio
Servo myservo4; // Anular
Servo myservo5; // Meñique
const int electrodePin1 = A0; // Pin analógico para el electrodo del pulgar
const int electrodePin2 = A1; // Pin analógico para el electrodo del índice
const int electrodePin3 = A2; // Pin analógico para el electrodo del medio
const int electrodePin4 = A3; // Pin analógico para el electrodo del anular
const int electrodePin5 = A4; // Pin analógico para el electrodo del meñique

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
    myservo1.attach(2); // Conectar servo del pulgar al pin 2
    myservo2.attach(3); // Conectar servo del índice al pin 3
    myservo3.attach(4); // Conectar servo del medio al pin 4
    myservo4.attach(5); // Conectar servo del anular al pin 5
    myservo5.attach(6); // Conectar servo del meñique al pin 6

    // Inicializar los servos en posición extendida
    myservo1.write(0);
    myservo2.write(0);
    myservo3.write(0);
    myservo4.write(0);
    myservo5.write(0);


}

void loop() {
  // put your main code here, to run repeatedly:
  // Leer los valores de los electrodos
    int value1 = analogRead(electrodePin1);
    int value2 = analogRead(electrodePin2);
    int value3 = analogRead(electrodePin3);
    int value4 = analogRead(electrodePin4);
    int value5 = analogRead(electrodePin5);

    Serial.print("Electrodo 1: ");
    Serial.println(value1);
    Serial.print("Electrodo 2: ");
    Serial.println(value2);
    Serial.print("Electrodo 3: ");
    Serial.println(value3);
    Serial.print("Electrodo 4: ");
    Serial.println(value4);
    Serial.print("Electrodo 5: ");
    Serial.println(value5);
  
    // Convertir la lectura del electrodo en un ángulo de servo
    // Ajusta los umbrales y los ángulos según sea necesario
    if (value1 > 100) {
        myservo1.write(90); // Pulgar flexionado
    } else {
        myservo1.write(0);  // Pulgar extendido
    }

    if (value2 > 100) {
        myservo2.write(90); // Índice flexionado
    } else {
        myservo2.write(0);  // Índice extendido
    }

    if (value3 > 100) {
        myservo3.write(90); // Medio flexionado
    } else {
        myservo3.write(0);  // Medio extendido
    }

    if (value4 > 100) {
        myservo4.write(90); // Anular flexionado
    } else {
        myservo4.write(0);  // Anular extendido
    }

    if (value5 > 100) {
        myservo5.write(90); // Meñique flexionado
    } else {
        myservo5.write(0);  // Meñique extendido
    }

    delay(100); // Pequeña espera para estabilizar lecturas
}
