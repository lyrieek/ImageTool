using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageTool
{
    public partial class ListForm : Form
    {
        MainForm mf;
        public ListForm(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
            nud_page.Value = mf.page;
            nud_num.Value = mf.number;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            mf.page = (int)nud_page.Value;
            mf.number = (int)nud_num.Value - 1;
            mf.SetPage(true);
            this.Hide();
        }

        private void ListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            btn_ok.PerformClick();
        }

        private void ListForm_Deactivate(object sender, EventArgs e)
        {
            btn_ok.PerformClick();
        }

        private void ListForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                btn_ok.PerformClick();
            }
        }
    }
}
