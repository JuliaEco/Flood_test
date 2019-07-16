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
            var parameters = new FloodDataParameters(DEMpath.Text, resroot.Text, rootFolder.Text,
            sim_time.Text, init_tstep.Text, massint.Text, saveint.Text,
             fpfric.Text, BciPath.Text, BdyPath.Text, adaptoff.Checked,
             sgc_enable.Checked, drycheckon.Checked, elevoff.Checked, max_Froude.Text); 
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
            rootFolder.Text = path;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void resroot_TextChanged(object sender, EventArgs e)
        {

        }

        private void elevoff_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sgc_enable_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
