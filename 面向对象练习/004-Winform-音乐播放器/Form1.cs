using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _004_Winform_音乐播放器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 窗口加载时的默认属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //把默认一加载Form就会把自动播放关闭
            musicPlayer.settings.autoStart = false;
            //加载form窗口后给一个默认的播放歌曲地址
            musicPlayer.URL = @"F:\KuGou\雨过天晴.mp3";
           // label1.Image = Image.FromFile(@"C:\Users\shanzm\Desktop\静音.jpg");//global::_004_Winform_音乐播放器.Properties.Resources.非静音;
        }


        /// <summary>
        /// 播放按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.play();
        }



        /// <summary>
        /// 暂停按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.pause();
        }



        /// <summary>
        /// 停止按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.stop();
        }



        /// <summary>
        /// 实现 btnStartOrPause按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        bool b = true;

        private void btnStartOrPuase_Click(object sender, EventArgs e)
        {

            if (btnStartOrPuase.Text == "播放")
            {
                while (b)
                {
                    //单击选中listBox中的文件名，按播放（/暂停）按钮,实现播放
                    //为了实现暂停后在播放不从头开始，使用了一个布尔变量，来控制
                    musicPlayer.URL = listPath[listBox1.SelectedIndex];
                }

                musicPlayer.Ctlcontrols.play();
                btnStartOrPuase.Text = "暂停";
            }
            else
            {
                musicPlayer.Ctlcontrols.pause();
                btnStartOrPuase.Text = "播放";
                b = false;
            }
        }


        /// <summary>
        /// 实现停止按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.stop();
        }


        //将音乐文件路径存储在方法外，便于其他方法使用
        List<string> listPath = new List<string>();

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"F:\KuGou";//打开文件窗口默认目录
            ofd.Title = "选择音乐";
            ofd.Filter = "MP3|*.mp3|MKv|*.mkv|所有文件|*.*";
            ofd.Multiselect = true;//允许多选
            ofd.ShowDialog();

            //获得选择的文件全路径
            string[] path = ofd.FileNames;
            ///☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆
            ///注意此方法是获得选中的文件的全路径
            ///☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆

            for (int i = 0; i < path.Length; i++)
            {
                //把所有全路径添加到本方法外声明的集合listPath中
                listPath.Add(path[i]);
                //使用Path类中的方法GetFileName，从全路径中获得文件名，添加到ListBox
                listBox1.Items.Add(Path.GetFileName(path[i]));

            }

        }


        /// <summary>
        /// 实现双击ListBox列表中文件名，播放选中的音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("请先选择文件");
                return;
            }

            try//但在列表中有文件了，但你双击列表的空白处时，会抛异常，所以使用try
            {
                //按选中的文件的下标ListBox1.SelectrdIndex,索引列表ListPath中的路径
                musicPlayer.URL = listPath[listBox1.SelectedIndex];
                musicPlayer.Ctlcontrols.play();

                btnStartOrPuase.Text = "暂停";
            }
            catch { }
        }


        /// <summary>
        /// 实现上一曲功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            //因为listbox的selectMode我们设置为MulitSample可以多选，所以我们不把蓝色选中光标清空的话就会显示是成一片蓝色（看上去就像多选了）
            listBox1.SelectedIndices.Clear();

            index--;
            //让当前选中下标上移（表现在winform窗口中就是选中的蓝条随着上一曲按钮的点击而上移
            listBox1.SelectedIndex = index;

            if (index == 0)
            {
                index = listBox1.Items.Count;
            }
            musicPlayer.URL = listPath[index];
            musicPlayer.Ctlcontrols.play();

        }


        /// <summary>
        /// 实现下一曲功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            //因为listbox的selectMode我们设置为MultiExtended可以(按住shift)多选，所以我们不把蓝色选中光标清空的话就会显示是成一片蓝色（看上去就像多选了）
            listBox1.SelectedIndices.Clear();

            index++;

            //让当前选中下标下移（表现在winform窗口中就是选中的蓝条随着下一曲按钮的点击而下移
            listBox1.SelectedIndex = index;
            if (index == listBox1.Items.Count)
            {
                index = 0;
            }
            musicPlayer.URL = listPath[index];
            musicPlayer.Ctlcontrols.play();
        }

        /// <summary>
        /// 这是来自ContentMenuStrip控件中添加的按钮
        /// ContentMenuStrip控件实现的功能就是当右击它所关联的控件时，弹出快捷次菜单
        /// 这里他的关联控件是ListBox，我们在ListBox的属性中的ContentMenuStrip，选择你要关联的ContentMenuStrip控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = listBox1.SelectedItems.Count;

            for (int i = 0; i < count; i++)
            {
                // 先删除集合ListPath中的的路径
                listPath.RemoveAt(listBox1.SelectedIndex);

                //在删除listBox中的文件
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }


        }

        /// <summary>
        /// 静音功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.Tag.ToString() == "非静音")
            {
                label1.Image = Image.FromFile(@"C:\Users\shanzm\Desktop\静音.jpg");
                musicPlayer.settings.mute = true;
                label1.Tag = "静音";
            }
            else
            {
                label1.Image = Image.FromFile(@"C:\Users\shanzm\Desktop\非静音.jpg");
                musicPlayer.settings.mute = false;
                label1.Tag = "非静音";
            }

        }



    }
}
