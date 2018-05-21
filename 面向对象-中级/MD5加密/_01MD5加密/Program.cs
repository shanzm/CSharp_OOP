using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace _01MD5加密
{
    class Program
    {
        static void Main(string[] args)
        {
           string strs= Console.ReadLine();
           string MD5strs=GetMD5(strs);
           Console.WriteLine(MD5strs);
           Console.ReadKey();
        }

        public static string GetMD5(string strs)
        {
            //创建MD5对象
            MD5 md5 = MD5.Create();

            //因为md5 .ComputeHash ()的参数是一个字节数组，所以要将你要加密的字符串转化为一个字节数组
            byte[] buffer = Encoding.Default.GetBytes(strs);
            //将一个字节数组加密，返回也是一个字节数组
            byte[] MD5buffer = md5.ComputeHash(buffer);
            //将字节数组转化为一个字符创，打印出来
            ///字节数组转化为字符串有三种方式
            ///1.将字节数组中的每一个元素按照指定的编码格式解析为字符串---string MD5strs = Encoding.Default.GetString(MD5buffer);
            ///2.直接将字符数组.ToString();
            ///3.将字符数组中的每一个元素.ToString();
            
            //我们采用第三种方式
            string MD5strs=null ;
            for (int i = 0; i < MD5buffer.Length; i++)
            {
                MD5strs += MD5buffer[i].ToString ("X2");//参数X2,意味着将字符串转化为16进制
            }
            
            return MD5strs;
            
        }
    }
}
