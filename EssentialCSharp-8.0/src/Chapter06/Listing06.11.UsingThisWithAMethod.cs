// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_11
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Employee employee = new Employee();

            employee.SetName("Inigo", "Montoya");
        }
    }

    class Employee
    {
        public string FirstName;
        public string LastName;
        public string? Salary = "Not enough";

        public string GetName()
        {
            return $"{ FirstName } { LastName }";
        }

        public void SetName(string newFirstName, string newLastName)
        {
            this.FirstName = newFirstName;
            this.LastName = newLastName;
            Console.WriteLine(
                $"Name changed to '{ this.GetName() }'");
        }
    }
}
// public, private, protected 상속 받는 값만 갖고올 수 있음, internal