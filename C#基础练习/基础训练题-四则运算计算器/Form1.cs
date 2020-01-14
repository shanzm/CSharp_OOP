using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 基础训练题_四则运算计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //使用try catch，是为了判断输入的是否是数字
            try
            {
                ///若是用户输入的数字之间有空，则去除
                ///☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆注意去除空格的方法
                if (textBox1.Text.Contains(" ") || textBox2.Text.Contains(" "))
                {
                    textBox1.Text = textBox1.Text.Replace(" ", "");
                    textBox2.Text = textBox2.Text.Replace(" ", "");
                }
                   
                

                int num1 = Convert.ToInt32(textBox1.Text.Trim());//注意使用Trim只能去除字符串结尾和开头的空格
                int num2 = Convert.ToInt32(textBox2.Text.Trim());
                string opera = comboBox1.SelectedItem.ToString();//注意SelectedItem和SelectedIndex

                int num3 = 0;
                switch (opera)
                {
                    case "+": num3 = num1 + num2;
                        break;
                    case "-": num3 = num1 - num2;
                        break;
                    case "*": num3 = num1 * num2;
                        break;
                    case "/": num3 = num1 / num2;
                        break;
                    default: MessageBox.Show("请选择运算符");
                        break;
                }
                label1.Text = num3.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("请输入正确的数字"); ;
            }
            
        }
    }
}
