int trigPin1 = 10;
int echoPin1 = 11;
int trigPin2 = 12;
int echoPin2 = 13;

int num=0;
int first=3;
int check1=0,check2=0;

//변수를 설정합니다.
long duration1, distance1=0, bfodistance1 =326;
long duration2, distance2=0, bfodistance2=326;

void setup() {
pinMode(trigPin1, OUTPUT); // trigPin을 출력으로
pinMode(echoPin1, INPUT); // echoPin을 입력이다.
pinMode(trigPin2, OUTPUT); // trigPin을 출력으로
pinMode(echoPin2, INPUT); // echoPin을 입력이다.

Serial.begin(9600); // 시리얼 포트를 시작합니다.
}

void loop() {
digitalWrite(trigPin1, LOW); //초음파 센서를 초기화 하는 과정입니다.
delayMicroseconds(2);
digitalWrite(trigPin1, HIGH);
delayMicroseconds(10);
digitalWrite(trigPin1, LOW);
duration1 = pulseIn(echoPin1, HIGH); // 트리거 핀에서 나온 펄스를 받아서
distance1= duration1*0.034/2; // 거리를 측정합니다.

//2초마다 , 그리고 아래의 과정은 모두 동일합니다.

digitalWrite(trigPin2, LOW);
delayMicroseconds(2);
digitalWrite(trigPin2, HIGH);
delayMicroseconds(10);
digitalWrite(trigPin2, LOW);
duration2 = pulseIn(echoPin2, HIGH);
distance2= duration2*0.034/2;

if (distance1 < 323){
check1=1;
}

if (distance2 < 323){
check2=1;
}

if (check1==1 && check2==0){
first=1;
}

if (check2==1 && check1==0){
first=2;
}

if (check1==1 && first==1){
if (check2==1){
delay(1000);
num = num+1;
check1=0;
check2=0;
first=3;
}
}

if (check2==1 && first==2){
if (check1==1){
delay(1000);
num = num-1;
check1=0;
check2=0;
first=3;
}
}

Serial.print ( "Sensor1 : "); //센서 1에
Serial.print ( distance1);// 거리 값
Serial.print("cm  "); // cm를 출력합니다.

Serial.print("Sensor2 : ");
Serial.print(distance2);
Serial.print("cm  ");

Serial.print("num:");
Serial.print(num);
Serial.print("check1:");
Serial.print(check1);
Serial.print("check2:");
Serial.println(check2);

}
