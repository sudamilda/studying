// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618
// Disabled pending introductin to object initializers
#pragma warning disable IDE0017 

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_17
{
    public class Program
    {
        public static void Main()
        {
            Employee employee = new Employee();

            // Call the FirstName property's setter
            employee.FirstName = "Inigo";

            // Call the FirstName property's getter
            System.Console.WriteLine(employee.FirstName); // 값을 가져올 때 get 호출

            tree myTree = new tree();
            myTree.name = "소나무"; // 함수는 전역변수 느낌, class는 지역변수 느낌
        }
    }

    class Employee
    {
        // FirstName property(자산)
        public string FirstName
        {
            get // 반환되는 값을 지정
            {
                return _FirstName;
            }
            set // 저장하는 것 위치가 바뀐 순간 내부에서 함수 호출
            {
                _FirstName = value;
            }
        }
        // get, set, value 고정

        private string _FirstName; // 값은 여기에 저장됨

    }

    class tree
    {
        public string name;  
    }
}
