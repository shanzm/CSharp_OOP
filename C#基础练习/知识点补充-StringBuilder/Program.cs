using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 基础练习题_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            ///string类型具有不可变性，在重新赋值会重新去分配内存空间，
            ///所以为了解决这个问题，微软推出了一个StringBuilder的类。
            ///对于需要经常拼接的字符串，使用StringBuilder
            //StringBuilder sb = new StringBuilder("abc");
            //sb.Append(1);
            //sb.Append('2');
            //sb.Append("3");
            //sb.Append(3.14);
            //sb.Append(true);

            //Console.WriteLine(sb.ToString());
            //Console.ReadKey();




            StringBuilder sb = new StringBuilder();
            sb.Append("<html>");
            sb.Append("<head>");
            sb.Append("<title>");
            sb.Append("</title>");
            sb.Append("<body>");
            sb.Append("<table>");
            sb.Append("<td>");
            sb.Append("<tr>星期一</td>");
            sb.Append("<tr>星期一</td>"); 
            sb.Append("<tr>星期一</td>");
            sb.Append("<tr>星期一</td>");
            sb.Append("<tr>星期一</td>");
            sb.Append("</td>");
            sb.Append("<td>");
            sb.Append("<tr>星期一</td>");
            sb.Append("<tr>星期一</td>");
            sb.Append("<tr>星期一</td>");
            sb.Append("<tr>星期一</td>");
            sb.Append("<tr>星期一</td>");
            sb.Append("</td>");
            sb.Append("</table>");
            sb.Append("</body>");
            sb.Append("</html>");
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
