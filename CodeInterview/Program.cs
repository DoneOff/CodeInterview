using System;
namespace CodeInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("测试开始");
            Chapter1_1();
            Console.ReadLine();

        }

        private static void Chapter1_1() {
            Console.WriteLine("请输入校验字符串");
            string str = Console.ReadLine();
            Chapter1.Chapter1.isUniqueChar(str);
        }
    }
}
