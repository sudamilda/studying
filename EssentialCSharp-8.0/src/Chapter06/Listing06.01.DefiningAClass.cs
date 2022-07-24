namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_01
{
    public class Program
    {
        public static void Main()
        {
            System.Console.WriteLine("No output in this example");
            zombie ss = new zombie();
        }
    }

    class Employee
    {
    }
    class zombie
    {
        string name;
        int power;

        public void Attackfunc()

        {

        }

        public void Defensefunc()
        {

        }
    }


}

// class: 좀비의 체력, 공격력, 이름 등을 모두 관장함
/*
 같은 클래스를 사용하더라도 어떤 값을 넣는지, 누가 만드는지, 어디서 만드는 지에 따라서 다른 녀석이 된다.
물론 같은 값이라고도 할 수 있다.
 
 */