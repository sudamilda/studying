// Justificaiton: only partial implementation provided for elucidation.
#pragma warning disable IDE0060 // Remove unused parameter

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_03
{
    using Listing06_01;

    class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee(); // 인스턴스가 있어야 쓸 수 있음 new를 사용해서 개체를 인스턴스화 한다. 
            Employee employee2;
            employee2 = new Employee();

            IncreaseSalary(employee1);
            IncreaseSalary(employee2);
        }

        static void IncreaseSalary(Employee employee)
        {
            // ...
        }
    }
}

//gc 가비지 컬렉터 남아있는 정보값을 삭제함 c# 유니티 // C++은 안됨