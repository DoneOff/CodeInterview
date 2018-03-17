using System;
using System.Collections.Generic;
using System.Text;

namespace CodeInterview.Chapter1
{
    public static class Chapter1
    {
        /// <summary>
        /// 1.1 判断字符串中是否出现重复字符
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
                    Console.WriteLine(string.Format(msg, str, c));
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
        /// 1.2 反转字符串
        /// </summary>
        /// <param name="str">需要反转的字符串</param>
        /// <returns>反转的结果</returns>
        public static string StringReserve(string str)
        {
            char[] chars = new char[str.Length];
            for (int i = str.Length; i > 0; i--)
            {
                chars[str.Length - i] = char.Parse(str.Substring(i - 1, 1));
            }
            string revesedStr = new string(chars);
            Console.WriteLine("反转结果为：" + revesedStr);
            return revesedStr;
        }

        /// <summary>
        /// 1.3 比较两个字符串通过排列组合后是否一致
        /// 思路：比较长度，再比较相同字符出现的次数
        /// </summary>
        /// <param name="s">第一个字符串</param>
        /// <param name="t">第二个字符串</param>
        /// <returns>是否成功</returns>
        public static bool Permutation(string s, string t)
        {
            bool result = false;
            if (s.Length != t.Length) return result;

            //用于存储某字符的出现次数
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c] = dic[c]++;
                }
                else
                {
                    dic[c] = 0;
                }
            }

            foreach (char c in t)
            {
                if (!dic.ContainsKey(c))
                {
                    Console.WriteLine(string.Format("'{0}'中字符‘{1}’并没有出现再‘{2}’中", t, c, s));
                    break;
                }
                else
                {
                    dic[c] = dic[c]--;
                    if (dic[c] < 0) result = true;
                    else result = false;
                }
            }
            return result;

        }

        /// <summary>
        /// 替换字符串数组中的空白数组
        /// </summary>
        /// <param name="chars">字符串数组</param>
        /// <param name="length">字符串长度</param>
        public static void ReplaceSpace(char[] chars, int length)
        {
            //疑问，chars的长度和length难道不是相等的吗？所谓字符串真实长度到底指的什么？
            int newLength, spaceCount = 0;
            for (int i = 0; i < length; i++)
            {
                if (chars[i] == ' ')
                {
                    spaceCount++;
                }
            }
            newLength = spaceCount * 2 + length;

            char[] newChars = new char[newLength];
            for (int i = length - 1; i >= 0; i--)
            {
                if (chars[i] == ' ')
                {
                    newChars[newLength - 1] = '0';
                    newChars[newLength - 2] = '2';
                    newChars[newLength - 3] = '%';
                    newLength = newLength - 3;
                }
                else
                {
                    newChars[newLength - 1] = chars[i];
                    newLength = newLength - 1;
                }
            }

            Console.WriteLine(string.Format("转换过后的字符串为：{0}", new string(newChars)));
        }

        /// <summary>
        /// 压缩字符串  aabbbbccaaa--》a2b4c2a3
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string CompressBad(string str)
        {
            string result = string.Empty;
            int index = 0;
            Char[] chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (i >= chars.Length - 1)
                {
                    result += chars[i] + "";
                    if (index != 0) result += index+1;
                    break;

                }
                if (chars[i] == chars[i + 1])
                {
                    index++;
                }
                else
                {
                    result += chars[i] + "";
                    if (index != 0) { result += index + 1; }
                    index = 0;
                }

            }
            Console.WriteLine(string.Format("压缩结果为：{0}", result));
            return result;

        }
    }
}
