using System;

namespace Open_Lab_03._3
{
    class Program
    {
        public static bool CompareCharactersCount(string str1, string str2)
        {
            return (str1.Length == str2.Length);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("First word");
            string str1 = Console.ReadLine();
            Console.WriteLine("Second word");
            string str2 = Console.ReadLine();
            Console.WriteLine(CompareCharactersCount(str1, str2));
        }
    }
}
