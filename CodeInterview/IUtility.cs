using System;
using System.Collections.Generic;
using System.Text;

namespace CodeInterview
{
    interface IUtility
    {
        /// <summary>
        /// 读取二维数组
        /// </summary>
        /// <returns></returns>
        string[,] ReadMatrix();


        /// <summary>
        /// 输出二维数组
        /// </summary>
        /// <returns></returns>
        void WriteMatrix(string[,] matrix);
    }
}
