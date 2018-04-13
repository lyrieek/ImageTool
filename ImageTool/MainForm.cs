using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageTool
{
    public partial class MainForm : Form
    {
        public int page = 1, number = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetPage(true);
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                SetPage(true);
            }
            else if (e.Button == MouseButtons.Right)
            {
                SetPage(false);
            }
        }

        /// <summary>
        /// true是翻页
        /// false是回页
        /// </summary>
        /// <param name="f"></param>
        public void SetPage(bool f)
        {
            string s = @"\";
            if (f)
            {
                number++;
            }
            else
            {
                number--;
            }
            if (!File.Exists(@"F:\DownLoad\乌龙院大长篇 全集\" + page + "\\" + number + ".jpg"))
            {
                if (f)
                {
                    number = 1;
                    page++;
                }
                else
                {
                    page--;
                    for (int i = 40; i > 20; i--)
                    {
                        if (File.Exists(@"F:\DownLoad\乌龙院大长篇 全集\" + page + "\\" + i + ".jpg"))
                        {
                            number = i;
                            break;
                        }
                    }
                }
            }
            BackgroundImage = Image.FromFile(@"F:\DownLoad\乌龙院大长篇 全集\"
                + page + s + number + ".jpg");
            lbl_page.Text = "第" + page + "章 / 第" + number + "页";
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control || e.KeyCode == Keys.Space)
            {
                new ListForm(this).ShowDialog();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Environment.Exit(0);
            }
        }
    }
}

#region ks
/*
             //DirectoryInfo dis = new DirectoryInfo(@"F:\DownLoad\乌龙院大长篇 全集");
            //DirectoryInfo[] di = dis.GetDirectories();
            //string a = "";
            //foreach (DirectoryInfo ditem in di)
            //{
            //    FileInfo[] fi = ditem.GetFiles();
            //    foreach (FileInfo item in fi)
            //    {
            //        string fn = item.FullName;
            //        int s = fn.LastIndexOf('\\');
            //        string path = fn.Substring(0, s + 1);
            //        string name = fn.Substring(s + 1);
            //        name = name.Substring(0, name.LastIndexOf('.'));
            //        name = int.Parse(name).ToString();
            //        item.MoveTo(path + name + ".jpg");
            //        a += " " + name;
            //    }
            //}
            //MessageBox.Show(a);
 */
#endregion
