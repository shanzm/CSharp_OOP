using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 字典Dictionary练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入一个字符串，判读其中的每一个字符出现的次数，（不区分大小写）；
            Console.WriteLine("Please enter a string");
            string myString = Console.ReadLine();
            Dictionary<char, int> myDic = new Dictionary<char, int>();
            for (int i = 0; i < myString.Length; i++)
            {
                //当用户输入的字符串中存在空格时，跳出循环，不把空格计数
                if (myString[i] == ' ')
                {
                    continue;
                }

                if (myDic.ContainsKey(myString[i]))
                {
                    myDic[myString[i]]++;
                }
                else
                {
                    myDic[myString[i]] = 1;///你开始声明了一个字典对象，其中是什么都没有的
                    ///在读取你输入的字符串，一开始的时候，几乎都是这个
                    ///情况，myDic[myString[i]] = 1，不仅仅是在计数
                    ///而且把myString[i]存入key中,见下面代码
                    /// myDic['无'] = 10000000;
                }
            }

            myDic['无'] = 10000000;

            foreach (KeyValuePair<char, int> item in myDic)///注意此处的KeyValuePair类型
            {
                Console.WriteLine("字母{0}出现了{1}次", item.Key, item.Value);
            }
            Console.ReadKey();
        }
    }
}
