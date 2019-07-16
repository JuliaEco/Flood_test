using Presenter;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Flood_test
{
    public partial class Form1 : Form, IView
    {
        public Form1()
        {
            InitializeComponent();
        }

        public event Action<FloodDataParameters> Compute;

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

        private void Invoke(Action<FloodDataParameters> action)
        {
            var parameters = new FloodDataParameters(); // you need to replace this constructor
                                                        //to another in this class and set params from your form
            action?.Invoke(parameters);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
        private void button1_Click_1(object sender, EventArgs e)
        {

            if (DEMfileOpen.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = DEMfileOpen.FileName;
            DEMpath.Text = filename;
        }

        private void SelectRootFolderBtn_Click(object sender, EventArgs e)
        {

            if (RootFolderOpen.ShowDialog() == DialogResult.Cancel)
                return;
            string path = RootFolderOpen.SelectedPath;
            rootFolderText.Text = path;
        }
    }
}
