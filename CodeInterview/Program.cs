using System;
namespace CodeInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("测试开始");
            // Chapter1_1();
            //Chapter1_2();
            //Chapter1_3();
            //Chapter1_4();
            //Chapter1_5();
            Chapter1_6();
        }

        private static void Chapter1_1()
        {
            while (true)
            {
                Console.WriteLine("请输入校验字符串，输入 exit 退出。");
                string str = Console.ReadLine();
                if (str.Equals("exit")) break;
                Chapter1.Chapter1.isUniqueChar(str);
            }
        }

        private static void Chapter1_2()
        {

            while (true)
            {
                Console.WriteLine("请输入需要反转的字符串，输入 exit 退出。");
                string str = Console.ReadLine();
                if (str.Equals("exit")) break;
                Chapter1.Chapter1.StringReserve(str);
            }
        }

        private static void Chapter1_3()
        {

            while (true)
            {
                Console.WriteLine("请输入需要比较的第一个字符串，输入 exit 退出。");
                string s = Console.ReadLine();
                if (s.Equals("exit")) break;

                Console.WriteLine("请输入需要比较的第一二个字符串：");

                string t = Console.ReadLine();
                if (t.Equals("exit")) break;

                if (Chapter1.Chapter1.Permutation(s, t))
                {
                    Console.WriteLine("排列后相等");
                }
                else
                {
                    Console.WriteLine("排列后不相等");

                }
            }
        }

        private static void Chapter1_4()
        {

            while (true)
            {
                Console.WriteLine("请输入需要替换的字符串，输入 exit 退出。");
                string str = Console.ReadLine();
                if (str.Equals("exit")) break;
                Chapter1.Chapter1.ReplaceSpace(str.ToCharArray(),str.Length);
            }

        }

        private static void Chapter1_5()
        {

            while (true)
            {
                Console.WriteLine("请输入需要压缩的字符串，输入 exit 退出。");
                string str = Console.ReadLine();
                if (str.Equals("exit")) break;
                string result =Chapter1.Chapter1.CompressBad(str);

            }

        }

        private static void Chapter1_6() {
            while (true)
            {
                IUtility utility = new Utility();
                string[,] matrix = utility.ReadMatrix();
                Console.WriteLine("输入的二维数组为：");
                utility.WriteMatrix(matrix);
                var result = Chapter1.Chapter1.rotate(matrix, matrix.GetLength(0));
                Console.WriteLine("旋转后的二维数组为：");
                utility.WriteMatrix(result);
            }
        }
    }
}
