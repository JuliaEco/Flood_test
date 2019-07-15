using Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flood_test
{
    public partial class Form1 : Form, IView
    {
        public Form1()
        {
            InitializeComponent();
        }

        public event Action Compute;

        public new void Show()
        {
            Application.Run(this);
        }

        public void ShowResult(string result)
        {
            ShowMessage(result, "Result");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ShowMessage(string text, string caption)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            MessageBox.Show(text, caption, buttons);
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            Invoke(Compute);
        }

        private void Invoke(Action action)
        {
            if (action != null) action();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (bciFileOpen.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = bciFileOpen.FileName;
            BciPath.Text = filename;
        }

        private void BcFile_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void BdiOpen_Click(object sender, EventArgs e)
        {
            if (bdyFileOpen.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = bdyFileOpen.FileName;
            BdyPath.Text = filename;
        }

        private void bdyFileOpen_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void BciPath_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {

            if (DEMfileOpen.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = DEMfileOpen.FileName;
            DEMpath.Text = filename;
        }
        private void DEMFileOpen_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void DEMpath_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
