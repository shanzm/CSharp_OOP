using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;

namespace _01程序集的引用
{
    internal class Program
    {
        /// 03新建类库-生成程序集dll文件即Common.dll
        /// 当我们想要使用Common项目的类时，我们一般是在这个项目添加引用，在添加那个项目的命名空间即可
        /// 这样我们就可以使用引用项目的公共成员
        ///
        /// 但是注意我在项目完成后，对项目扩展时写了dll文件，没有在原来项目中添加引用，哪怎么才能直接使用dll文件呢
        ///
        /// 我们怎么引用dll文件呢，注意我们生成的Common.dll文件在项目Common中
        /// 我们只能把Common.dll文件复制到本项目的Debug文件夹，才可以使用
        /// 当然你可以修改项目Common的生成位置：在Common项目的属性中选择生成。即可修改，生成的位置
        /// 你可以把它修改为生成在这个项目的Debug文件夹中
        ///
        /// 现在我把Commond.dll 文件已经复制复制到了本项目的Debug文件夹中，
        /// 但是我们也是不能直接去使用dll中的数据
        /// 我们从这个dll文件中取元数据的过程就是反射（reflect)
        private static void Main(string[] args)
        {
            #region 加载程序集

            //首先为了使用Assembly类，添加命名空间：using System.Reflection;
            //获取当前Debug文件夹的绝对路径
            string debugPath = AppDomain.CurrentDomain.BaseDirectory;
            //取得Debug中的dll文件的据对路径
            string dllPath = Path.Combine(debugPath, "Common.dll");//把debugPath和Common.dll连接起来就是Common.dll的绝对路径
            //使用Assembly类，加载程序集文件---------------这些步骤就有点类似读取Xml文件了
            Assembly ass = Assembly.LoadFile(dllPath);//注意LoadFile的参数只能是绝对路径

            #endregion

            #region 获得程序集dll文件中数据类型的方式

            //获取所有程序集dll文件中所有定义的类的类型,包括私有和公共的
            //获得公共类Person的类型和内部类（internal）Student的类型
            //注意此处，你如果只是引用某个项目然后添加命名空间，只能使用其中的公共类
            //而通过反射则可以获得所有的类，不论私有和公共
            Console.WriteLine("------------------1:获取指定的dll中的所有类型---------------");
            Type[] allTypes = ass.GetTypes();
            foreach (Type item in allTypes)
            {
                //Console.WriteLine($"common.dll中的所有的类型:" + item);
            }

            Console.WriteLine("\n------------------2:通过指定类型名称获取指定的dll中的类型---------------");
            //获取所有程序集dll文件中某个特定的类的类型,不论私有和公共的
            Type typePerson = ass.GetType("Common.Person");           //获取Person类型
            Type typeStudent = ass.GetType("Common.Student");         //获取Student类型
            Console.WriteLine("获取指定的类:" + typePerson.Name);
            Console.WriteLine("获取指定的类:" + typeStudent.Name);

            Console.WriteLine("\n------------------3:获取指定程序中的所有公共类型-------------------");
            //获取所有程序集dll文件中定义的公共类型的类型（公共类）
            Type[] publicTypes = ass.GetExportedTypes();     //仅获得公共类Person的类型
            foreach (Type item in publicTypes)
            {
                Console.WriteLine($"命名空间：{item.Namespace}");       //类的命名空间
                //Console.WriteLine($"类名：{item.Name}");                //类名
            }

            #endregion

            #region 查看类型Type

            //有对象的查看方式
            string str = "shanzm";
            Type typeString1 = str.GetType();
            Console.WriteLine(typeString1);

            //没有对象的查看方式
            //使用 C# typeof 运算符。
            Type typeString2 = typeof(string);
            Console.WriteLine(typeString2);

            //还可以调用Type类的静态方法GetType()。
            Type typeString3 = Type.GetType("System.String");
            Console.WriteLine(typeString3);

            //上面这三类代码都是获取string类型的Type，
            //在取出string类型的Type引用typeString后，我们就可以通过typeString来探测string类型的结构了。即查看内部所有属性、字段和方法
            Type typeString = str.GetType();
            foreach (MemberInfo mi in typeString.GetMembers())
            {
                //Console.WriteLine("{0}：{1}", mi.MemberType, mi.Name);
            }

            #endregion

            ///在知道了获得dll文件中的数据类型后，我们可以创建对象了，
            ///注意啊，上面我们只是获得了各个类的类型（类名），并没有真正的获得这个类名这个变量
            ///所以我们无法使用类名这个变量去new一个对象

            #region 创建对象

            ////根据Common.dll文件中的Person类新建一个对象
            ////但是这种方法本质是调用了Person类的无参构造函数，你若是在类中写了有参的构造函数
            ////这里就会报错
            ////object person = ass.CreateInstance("Common.Person");

            Type t = ass.GetType("Common.Person");
            object person = Activator.CreateInstance(t, "张三", '男', 13);//注意这里使用的是第六个重载
            ////新建了一个对象person,但是你此时直接用person点Person类中的属性和字段是不可以的
            ////要通过GetType获得类型
            ////通过GetProperties()获得类中的所有属性，返回一个 PropertyInfo类型的数组
            PropertyInfo[] pros = person.GetType().GetProperties();
            foreach (PropertyInfo item in pros)
            {
                //Console.WriteLine(item.Name);
            }

            //获得指定名称的属性
            PropertyInfo pro = t.GetProperty("Name");
            //获得对象person的指定的属性的值
            string name = (string)pro.GetValue(person, null);
            Console.WriteLine(name);

            //获得所有方法
            MethodInfo[] md = person.GetType().GetMethods();
            foreach (MethodInfo item in md)
            {
                //Console.WriteLine(item);
            }

            ////获得指定的方法
            MethodInfo mdi = person.GetType().GetMethod("Do");
            mdi.Invoke(person, null);

            #endregion

            Console.ReadKey();
        }
    }
}
