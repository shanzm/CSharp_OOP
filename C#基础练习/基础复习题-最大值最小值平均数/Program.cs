using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace 基础复习题_最大值最小值平均数
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Salary = File.ReadAllLines("工资.txt",Encoding.Default );

            ///注意这种使用方法，你若按照通把Max设为0，没问题，但是min你没法办
            int min = int.MaxValue;
            int max = int.MinValue;


            int sum = 0;
            for (int i = 0; i < Salary.Length; i++)
            {
                string[] strs = Salary[i].Split ('，');
                ///出问题，调试代码的时候，发现split这一步没有实现，但是不报错。
                ///最终查出原因是工资.txt中使用的是中文逗号分隔，而我的split参数写的是英文参数
                int salary = int.Parse(strs[1]);//int.Parse和Conver.ToInt32一样
                if (salary > max)
                {
                    max = salary;
                }
                if (salary < min)
                {
                    min = salary;
                }
                sum += salary;
            }
            Console.WriteLine("min={0},max={1},avg={2}", min, max, sum / Salary.Length);
            Console.ReadKey();
        }
    }
}
