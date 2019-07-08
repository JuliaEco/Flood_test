using Configurator;
using System;
using System.Windows.Forms;

namespace Flood_test
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppConfigurator.Run();
            //var presenter = new BaseFloodComputePresenter(new Form1(), new ComputerModel());
            //Presenter.Run();
            //Application.Run(new Form1());
        }

    }
}
