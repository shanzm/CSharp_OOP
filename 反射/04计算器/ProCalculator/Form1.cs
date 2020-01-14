using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ProFactory;
using ProOperation;

namespace ProCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 在加载Form1窗口时读取配置文件Config.txt,生成配置文档中的运算符按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("Config.txt", Encoding.Default);

            int x = 111;
            int y = 145;
            foreach (string item in lines)
            {
                //Config.txt有几条数据就建几个按钮
                Button btn = new Button();

                btn.Location = new Point(x, y);
                btn.Size = new Size(75, 23);
                x += 80;//水平相隔80新建下一个按钮
                btn.Text = item;

                btn.Click += btn_Click;    
                   
                this.Controls.Add(btn);//按钮添加到窗体
            }
        }

      
        void btn_Click(object sender, EventArgs e)
        {
            
                //参数sender就是触发事件，而这里的就是button
                Button btn = (Button)sender;//sender as Button;
                int num1 = Convert.ToInt32(textBox1.Text.Trim());
                int num2 = Convert.ToInt32(textBox2.Text.Trim());
                //获得简单工厂提供的父类对象
                Operation op = Factory.GetOperator(btn.Text, num1, num2);
               
                if (op!=null )
                {
                     label1.Text = op.GetResult().ToString();
                }
                else
                {
                    MessageBox.Show("没有该运算符");
                }
            
        }

    }
}
