#define trigPin 6
#define echoPin 7

void setup() {
 Serial.begin (9600);
 pinMode(trigPin, OUTPUT); //Pin, do którego podłączymy trig jako wyjście
 pinMode(echoPin, INPUT); //a echo, jako wejście
}

void loop() {
 long czas, dystans;
 digitalWrite(trigPin, LOW);
 delayMicroseconds(2);
 digitalWrite(trigPin, HIGH);
 delayMicroseconds(10);
 digitalWrite(trigPin, LOW);
 czas = pulseIn(echoPin, HIGH);
 dystans = czas / 58;
 Serial.print(dystans);
 delay(200);
 } 
