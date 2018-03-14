using System;
using System.Collections.Generic;
using System.Text;

namespace CodeInterview.Chapter1
{
    public static class Chapter1
    {
        /// <summary>
        /// 判断字符串中是否出现重复字符
        /// </summary>
        /// <param name="str">需要判断的字符串，不区分中文</param>
        /// <returns>是否包含重复字符</returns>
        public static bool isUniqueChar(string str)
        {
            //用于存储key，可优化使用其他数据结构存储
            Dictionary<char, bool> dic = new Dictionary<char, bool>();
            string msg = "在“{0}”中，'{1}'重复出现！ ";
            for (int i = 0; i < str.Length; i++)

            {
                char c = char.Parse(str.Substring(i, 1));
                if (dic.ContainsKey(c))
                {
                    Console.WriteLine(string.Format(msg,str,c));
                    return true;
                }
                else
                {
                    dic[c] = true;
                }
            }
            return false;
        }

        /// <summary>
        /// 反转字符串
        /// </summary>
        /// <param name="str">需要反转的字符串</param>
        /// <returns>反转的结果</returns>
        public static string StringReserve(string str){
            char[] chars = new char[str.Length];
            for(int i = str.Length;i>0;i--){
                chars[str.Length-i]=char.Parse(str.Substring(i-1,1));
            }
            string revesedStr =new string(chars);
            Console.WriteLine("反转结果为："+revesedStr);
           return revesedStr;
        }
    }
}
