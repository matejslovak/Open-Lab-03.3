using System;

namespace Open_Lab_03._3
{
    class Program
    {
        public static bool CompareCharactersCount(string str1, string str2)
        {
            if (str1.Length == str2.Length)
            {
                return true; 
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("First string");
            string str1 = Console.ReadLine();
            Console.WriteLine("Second string");
            string str2 = Console.ReadLine();
            Console.WriteLine(CompareCharactersCount(str1, str2));
        }
    }
}
