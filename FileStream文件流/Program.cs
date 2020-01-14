using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileStream文件流
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 使用文件流来读取文件数据
            ///使用文件流来读取文件数据
            FileStream fsRead = new FileStream(@"C:\Users\shanzm\Desktop\1.txt", FileMode.OpenOrCreate, FileAccess.Read);

            byte[] butter = new byte[1024 * 1024 * 5];//这是5m,  1mb=1024kb,1kb=1024字节
            int r = fsRead.Read(butter, 0, butter.Length);//返回的是本次读取数据的实际有效字节数
            //比如说，你定义的字节数组butter是5m,但是文件中只有3.8m,返回的就是3.8

            //z注意此句代码就是把字节数据转化为一个字符串
            string s = Encoding.Default.GetString(butter, 0, r);//编码字节类型数组的第0到第r的元素
            /////////////////注意区分将字符串转化为字符数组 char[] charArray= s.ToCharArray();
            /////////////////将字符数组转化为字符串  string myStr = String.Concat(charArray);

            ///关闭流
            fsRead.Close();
            ///释放流占用的资源
            fsRead.Dispose();
            ///我们并不习惯，要写关闭流和释放流资源的
            ///故有其他的语法，可以省略，见下面的使用文件流写入数据的代码
            ///我们把创建文件流对象的代码写在using（。。。）中，在
            ///大括号中写读取和写入数据的代码
            Console.WriteLine(s);
            #endregion


            #region 使用文件流写入数据
            ///使用文件流写入数据

            ///如果该路径已经存在该文件，则在该文件继续添加内容，使用参数FileMode.Append
            if (File.Exists(@"C:\Users\shanzm\Desktop\1.txt"))
            {
                using (FileStream fsWrite = new FileStream(@"C:\Users\shanzm\Desktop\1.txt", FileMode.Append, FileAccess.Write))
                {
                    string str = "覆盖测试";
                    byte[] butter2 = Encoding.Default.GetBytes(str);
                    fsWrite.Write(butter2, 0, butter2.Length);

                }
                Console.WriteLine("写入ok");
            }
            else
            {


                using (FileStream fsWrite = new FileStream(@"C:\Users\shanzm\Desktop\1.txt", FileMode.OpenOrCreate, FileAccess.Write))
                {
                    string str = "覆盖测试";
                    byte[] butter2 = Encoding.Default.GetBytes(str);
                    fsWrite.Write(butter2, 0, butter2.Length);

                }
                Console.WriteLine("写入ok");
            }
            Console.ReadKey();
        }
            #endregion
    }
}
