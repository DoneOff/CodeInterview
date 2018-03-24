using System;
using System.Collections.Generic;
using System.Text;

namespace CodeInterview
{
    public class Utility : IUtility
    {
        public string[,] ReadMatrix()
        {
            int n = 0;
            while (true)
            {
                Console.WriteLine("请输入你要输入的二维数组N*N的N的大小：");
                string str = Console.ReadLine();
                if (int.TryParse(str, out n))
                {
                    if (n < 2)
                        Console.WriteLine("希望您心里有点B树，N再怎么也得小于2：");
                    else
                        break;
                }
            }
            string[,] matrix =new string[n,n];
            for (int i = 0; i < n; i++)
            {
                while (true)
                {
                    Console.WriteLine("请输入二维数组的第" + i+1 + "行，中间以‘,’作为分隔：");
                    string arrayStr = Console.ReadLine();
                    string[] array = arrayStr.Split(",");
                    if (array.Length != n)
                    {
                        Console.WriteLine("希望你清醒一点，输入的数组长度和"+n+"不一致。");
                    }
                    else
                    {
                        for(int j = 0; j < array.Length; j++)
                        {
                            matrix[i, j] = array[j];
                        }
                        break;
                    }
                }

            }
            return matrix;
        }

        /// <summary>
        /// 输出二维数组
        /// </summary>
        /// <param name="matrix">二维数组</param>
        public void WriteMatrix(string[,] matrix)
        {
            int index = 0;
            foreach (var s in matrix) {
                index++;
                if (index % matrix.GetLength(0) == 0) {
                    Console.WriteLine(s);
                }
                else
                {
                    Console.Write(s + ",");
                }
            }
        }
    }
}
