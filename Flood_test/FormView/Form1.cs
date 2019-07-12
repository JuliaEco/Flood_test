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

    }
}
