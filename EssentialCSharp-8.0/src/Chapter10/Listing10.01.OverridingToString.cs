namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_01
{
    public struct Coordinate
    {
        public Coordinate(Longitude longitude, Latitude latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }

        public Longitude Longitude { get; }
        public Latitude Latitude { get; }


        public override string ToString()
        {
            return $"{ Longitude } { Latitude }";
        }

        // ...
    }

    public struct Longitude { }
    public struct Latitude { }
}

/*
 1. 콘솔 앱 Hello World
using system
using unity engine
라이브러리 읽어오기 위한 단어 
namespace script 한 장을 하나의 기능 단위로 묶음(C#)

2. 변수
int 정수형 int = 2;
float 실수형 float = 2.f;
string 문장 string s1 = "";
bool 참 거짓 bool b1 = True;
var C# 알아서 변수 정해줌

3. int[] iarray = new int[]; 숫자나 {} 직접 구현
한 번 할당하면 바꿀 수 없음

== < > <= >= != and&& or||

4. int i = 3
if(i==5 || i<3)
{
    // 조건 참이면 실행됨
}
else if(((조건1)&&(조건2))||(조건3)) // 갯수 제한 없음
{
    
}
else
{
    // 조건들이 아닌 경우에 실행됨
}
for(초기;조건;증가) for(;;) for (초기;;) for(;데이터 모든 값; Data++)
{
    
}
void 메소드
{
    while(조건)
    {
       return; 메소드 끝으로 감
       continue while 맨 첨으로 감
       break; while문 끝
    }
}

Do
{
    // 최소 한 번은 실행
}
while(조건)
{
}

int i = 3;
switch(i)
{
    case 1:
        break;
    case 2:
        break;
    case 3:
        break;
    Default:
        break;
}

int[] iArray = new int[4];
{1,2,3,4}
foreach(var element in iArray)
{
    i = 1씩 증가; // {2,3,4,5}
}

5. 메소드
void //공허 그냥 실행됨
object // return 값 필요 
int
float
string
class

void 메소드명()
{
    
}
메소드명();

void M(int i1, int i2)
{
    내 나이 = i1 + 12
}
main
{
    M(11,12)
    M(20,7)
}

stirng GetBundle(string Objectname)
{
    // Objectname에 해당하는 에셋이 있는가?
    if(있다)
    {
        return Objectname 에셋
    }
    else
    {
        return error!
    }
}
main
{
string robot = GetBundle("Irobot")
//로봇
string robot2 = GetBundle("GG")
//error!
}

6. class 
private 캡슐화 나만 접근 가능
public 모두 접근 가능
protected 상속자만 접근 가능
private  적지 않아도 기본적으로 C# int i = 3;은 private

class
{
    void GetData();
}

class name = new class();
name.GetData();

생명체 본다, 도망친다
사람 카메라
몬스터 공포누적(0->100이 되면 도망감)
생명체-사람-주인공
생명체-몬스터-유령
생명체-몬스터-좀비
사람이 유령을 보면 공포가 누적
주인공이 생명체를 보면 유령이 도망감

class 생명체
{
    본다()
    도망간다()
}
void 본다()
{
    // 두 눈으로 본다. 사람 입장
}
virtual 맞음()
{
    // 수정 가능
}
override void 맞음()
{
    // 내가 정의한 값으로 받음(수정) 보스 몬스터 입장
}
virtual void 
class 사람:생명체

 */