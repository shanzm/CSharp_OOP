using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace _001_简单工厂和抽象类_模拟cmd打开文件
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请选择要打开的文件的路径");
            string path = Console.ReadLine();
            Console.WriteLine("请选择要打开的文件");
            string fileName = Console.ReadLine();
            string fullPath=path+fileName;
            //调试时，便于观察，而做的输出 Console.WriteLine(fullPath);
            FileFather ff=GetFile( fullPath);
            ff.OpenFile();
            Console.ReadKey();

        }


        public static FileFather GetFile(string fullPath)
        {

            string extension = Path.GetExtension(fullPath);
           //调试时，便于观察，而做的输出 Console.WriteLine(extension);
            FileFather ff = null;
            switch (extension)
            {
                    //切记Path.GetExtension(fullPath);返回的的文件后缀是带有一个点的
                case ".txt": ff = new TxtFile(fullPath);
                    break;
                case ".jpg": ff = new jpgFile(fullPath);
                    break;
                case ".wav": ff = new wavFile(fullPath);
                    break;
            }
            return ff;
    }

   

}

    public abstract class FileFather
    {
        public FileFather(string fullPath)
        {
            this.FullPath = fullPath;
        }

        public string FullPath
        {
            set;
            get;
        }
        public abstract void OpenFile();


    }

    public class TxtFile : FileFather
    {
        public TxtFile(string fullPath)
            : base(fullPath)
        {
        }
        public override void OpenFile()
        {
            ProcessStartInfo psi = new ProcessStartInfo(this.FullPath);
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
        }
    }

    public class wavFile : FileFather
    {
        
        public wavFile(string fullPath)
            : base(fullPath)
        {
        }
        public override void OpenFile()
        {
            ProcessStartInfo psi = new ProcessStartInfo(this.FullPath);
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
        }
    }

    public class jpgFile : FileFather
    {
        
        public jpgFile(string fullPath)
            : base(fullPath)
        {
        }
        public override void OpenFile()
        {
            ProcessStartInfo psi = new ProcessStartInfo(this.FullPath);
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
        }
    }

}
