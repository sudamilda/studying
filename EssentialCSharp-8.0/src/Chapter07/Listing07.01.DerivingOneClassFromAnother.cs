namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_01
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    /*
    public class PdaItem
    {
        [DisallowNull]
        public string? Name { get; set; }
        public DateTime LastUpdated { get; set; }
    }

    // Define the Contact class as inheriting the PdaItem class
    public class Contact : PdaItem
    {
        public string? Address { get; set; }
        public string? Phone { get; set; }
    }
    */
    class Program
    {
        static void Main()
        {
            food myfood = new food();
            myfood.HowMuchIsIt();

            hansik myKoreanfood = new hansik();

        }
    }
    public class food
    {
        public string name = "";
        protected int price = 0;
        private string from = "";

        public void HowMuchIsIt()
        {
            System.Console.WriteLine(price);
        }
        public void ThisFoodNameIs()
        {
            System.Console.WriteLine(name);
        }
    }

    public class hansik:food
    {
        public void Guest()
        {
            System.Console.WriteLine(name);
            System.Console.WriteLine(price);

            HowMuchIsIt();

            name = "Kimchi";

            ThisFoodNameIs();

            
            
        }
    }
    

    public class illsik : food
    {

    }

    public class jooksik:food
    {

    }


}
/*
 class 음식
{
    public int price;
    private int 바코드; -> private는 안줌
protected int my; -> class 내부에서만 사용 가능
}
class 햄버거 : 음식
{

}
햄버거 버거킹 = new햄버거();
버거킹.price = 3;
버거킹.my = x; xxxxx안됨xxxxx

음식을 부모클래스, 햄버거를 자식 클래스
 */

// namespace가 일치하면 같이 본다

/*
 virtual 다시 정의할 수 있는 여지를 줌
 overide 수정 재정의
 abstract: 나는 안쓰지만 자식이 슨다
 
 */