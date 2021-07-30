using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace MD5加密
{
    class Program
    {
        static void Main(string[] args)
        {
            //string strs = "1";//Console.ReadLine();
            //string MD5strs = GetMD5(strs);//C4CA4238A0B923820DCC509A6F75849B
            //Console.WriteLine(MD5strs);


            #region 密码加密
            //用户注册逻辑：
            //用户提供密码，以及其他的注册信息
            //程序中的随机生成一个字符串（这个字符串作为加密的Salt）
            //将用户密码和Salt拼接在一起
            //将拼接后的字符串按照Md5算法加密
            //将加密后的字符串和Slat保存在数据库

            string userPwd = Console.ReadLine();//用户提供的密码
            string salt = GetRandomString(8);
            string signInInfo = salt + userPwd;//拼接一个Salt值
            string password = GetMD5(signInInfo);//Md5加密

            //todo:将salt和password保存在数据库中
            Console.WriteLine($"salt+userPwd:{signInInfo}");
            Console.WriteLine($"加密后存储到数据库的密码:{password}");

            //登陆时通过用户输入的密码和该用户注册时在数据库中保存在Salt,加密后与数据库中加密的密码匹配
            Console.WriteLine($"用户登陆时后再次加密得到的结果:{GetMD5(signInInfo)}");
            #endregion



            Console.ReadKey();
        }


        /// <summary>
        /// 将字符串加密为Md5
        /// </summary>
        /// <param name="strs">字符串</param>
        /// <returns></returns>
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
            string MD5strs = null;
            for (int i = 0; i < MD5buffer.Length; i++)
            {
                MD5strs += MD5buffer[i].ToString("X2");//参数X2,意味着将字符串转化为16进制
            }

            return MD5strs;

        }



        /// <summary>
        /// 生成指定长度的随机数
        /// </summary>
        /// <param name="iLength">期望长度</param>
        /// <returns></returns>
        public static string GetRandomString(int iLength)
        {
            string buffer = "0123456789";// 随机字符中也可以为汉字（任何）
            StringBuilder sb = new StringBuilder();
            Random r = new Random();
            int range = buffer.Length;
            for (int i = 0; i < iLength; i++)
            {
                sb.Append(buffer.Substring(r.Next(range), 1));
            }
            return sb.ToString();
        }
    }
}
