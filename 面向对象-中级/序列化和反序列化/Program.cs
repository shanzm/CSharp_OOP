using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace 序列化和反序列化
{
    /// <summary>
    /// 序列化就是将  对象  转化为二进制
    /// 反序列化顾名思义就是将二进制转化为对象
    /// 为什么要进行序列化，是为了对数据进行传输，数据的传输就是传输二进制，接受再将二进制反序列化
    /// </summary>
    class Program
    {
       
        static void Main(string[] args)
        {
            ////我们将p这个对象进行传输，所以对他进行序列化
            ////序列化第一步，先将这个对象的类标记为可以序列化的，使用关键字[Serializable]
            //Person p = new Person("张三", '男', 25);
            //using (FileStream fsWrite=new FileStream (@"C:\Users\shanzm\Desktop\1.txt",FileMode.OpenOrCreate,FileAccess .Write ))
            //{
            //    BinaryFormatter bf=new BinaryFormatter ();
            //    bf.Serialize(fsWrite, p);

            //}
            //Console.Write("序列化成功");
            //Console.ReadKey();

            //反序列化
            Person p;
            using (FileStream fsRead = new FileStream(@"C:\Users\shanzm\Desktop\1.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                p=(Person)bf.Deserialize(fsRead);
                Console.WriteLine("{0}{1}{2}",p.Name,p.Age ,p.Gender );

            }
            Console.ReadKey();
        }
    }

    [Serializable]            ///将Person类标记为可以序列化的类
    public class Person
    {
        public Person(string name, char gender, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private char _gender;

        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

    }
}
