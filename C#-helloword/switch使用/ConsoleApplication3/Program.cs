 #region 代码折叠
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion


namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            const string myName = "karli";
            const string niceName = "angeline";
            const string sillyname = "ploppy";
            string name;
            Console.WriteLine("what is your name?");
            name = Console.ReadLine();
            switch (name .ToLower ())//switch()中的语句要是结果和case一样就执行该case
            {
                case myName ://其实，case语句就是c#中的定义的标签
                   Console .WriteLine ("your have the same name as me!");
                   break ;
                case  niceName:
                    Console .WriteLine ("what a nice name you have");
                    break ;
                case  sillyname :
                    Console .WriteLine ("that's a very sillyname");
                    break ;
                //default  :
                //    Console .WriteLine ("enter error!");
                //    break ;
                    
            }
            Console.WriteLine("hello {0}!", name);

          

        }
    }
}
