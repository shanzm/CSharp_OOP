using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _003_抽象类_U盘移动硬盘
{
    class Program
    {
        static void Main(string[] args)
        {
            MoblieDisk md = new MoblieDisk();
            Mp3 mp3 = new Mp3();
            UDisk u = new UDisk();


            Computer cpu = new Computer();
            cpu.MS = md;
            cpu.CPURead();
            cpu.CPUWrite();
            Console.ReadKey();
        }
    }


    public abstract class MoblieStorage
    {
        public abstract void Read();
        public abstract void Write();
    }

    public class MoblieDisk : MoblieStorage
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘在读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("移动硬盘在写入数据");
        }
    }

    public class UDisk : MoblieStorage
    {
        public override void Read()
        {
            Console.WriteLine("u盘在读取数据") ;
        }

        public override void Write()
        {
            Console.WriteLine ("u盘再写入数据");
        }
    }

    public class Mp3 : MoblieStorage
    {
        public override void Read()
        {
            Console.WriteLine("Mp3真在读取数据");
           
        }

        public override void Write()
        {
            Console.WriteLine("Mp3真在写入数据");
        }

        public void PlayMusic()
        {
            Console.WriteLine("Mp3自己可以播放音乐");
        }
    }

    public class Computer
    {
        public MoblieStorage MS
        {
            set;
            get;
        }

        public void CPURead()
        {
            this.MS.Read();
        }

        public void CPUWrite()
        {
            this.MS.Write();
        }
    }

}
