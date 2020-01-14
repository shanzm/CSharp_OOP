using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileStream文件流练习_复制多媒体文件
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"F:\英语口语\赖世雄美语从头学1美式音标\p.002-p.003.mp3";
            string target = @"C:\Users\shanzm\Desktop\new.mp3";
            CopyFile(source, target);
            Console.ReadKey();
        }

        public static void CopyFile(string source, string target)
        {

            //创建一个读取数据的文件流对象
            using (FileStream fsRead = new FileStream(source, FileMode.OpenOrCreate, FileAccess.Read))
            {
                //创建一个写入数据的文件流对象
                using (FileStream fsWrite = new FileStream(target, FileMode.Create, FileAccess.Write))
                {
                    //数据缓冲区
                    byte[] butter = new byte[1024 * 1024 * 5];

                    //因为文件内容不知道大小，所以要使用一个循环来不断的读取和写入到目标路径target，其中每次读取都是5m大小的字节类型的数据
                    
                    while (true)
                    {

                        //r是每次读取数据的真实大小，前面每次都是5m，但最后文件的最后一场的读取，大小不一定还满足5m，一定是一个小于等于5的
                        int r = fsRead.Read(butter, 0, butter.Length);
                        
                        if (r == 0)
                        {
                            break;
                        }

                        fsWrite.Write(butter, 0, r);

                    }



                }

            }
        }

    }
}
