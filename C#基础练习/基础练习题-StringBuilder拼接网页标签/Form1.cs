using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 基础练习题_StringBuilder拼接网页标签
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<html>");
            sb.Append("<head>");
            sb.Append("<title>");
            sb.Append("</title>");
            sb.Append("<body>");


            sb.Append("<table border='1px' cellpadding='0px' cellsplace='0px'>");
            sb.Append("<tr>");
            sb.Append("<td>星期一</td>");
            sb.Append("<td>星期一</td>");
            sb.Append("<td>星期一</td>");
            sb.Append("<td>星期一</td>");
            sb.Append("<td>星期一</td>");
            sb.Append("</tr>");
            sb.Append("<tr>");
            sb.Append("<td>星期一</td>");
            sb.Append("<td>星期一</td>");
            sb.Append("<td>星期一</td>");
            sb.Append("<td>星期一</td>");
            sb.Append("<td>星期一</td>");
            sb.Append("</tr>");
            sb.Append("</table>");


            sb.Append("</body>");
            sb.Append("</html>");
            webBrowser1.DocumentText = sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uri url = new Uri("http://www.baidu.com");
            webBrowser1.Url  = url;
        }
    }
}
