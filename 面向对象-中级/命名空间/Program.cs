using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using 新建类;

namespace 命名空间
{
    class Program
    {
        static void Main(string[] args)
        {

            /*这个项目（命名空间）中没有Person类，但是
             * 通过对项目右键添加引用项目”新建类“，
             * 之后再，直接使用，vs会自动出现提示下拉框，选择添加”using 新建类“（快捷键是shift+alt+f10），就可以使用Person类了*/
            Person szm = new Person();
            szm.Name = "志铭";
            szm.Age = 24;
            szm.Gender = "男";

            szm.Introduct();
            Console.ReadKey();


           
            
            
             

           

            //创建一个计时器，用来记录程序使用的时间
            Stopwatch st = new Stopwatch();
            st.Start();
            int sum=0;
            for (int i = 0; i < 10000; i++)
            {
               
                sum += i;
            }
            st.Stop();
            Console.WriteLine("{0},{1}",sum,st.Elapsed );
            Console.ReadKey();



        }
    }
}
