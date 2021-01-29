using System;

namespace PrintUserName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFullName("Foo", "Bar", "FooBar"));
            Console.WriteLine(GetFullName("John", "Appleseed", "Michael"));
            Console.WriteLine(GetFullName("Jack", "Jackson", "James"));

            Console.ReadLine();
        }

        static string GetFullName(String firstName, String lastName, String patronymic)
        {
            return $"{firstName} {lastName} {patronymic}";
        }
    }
}
