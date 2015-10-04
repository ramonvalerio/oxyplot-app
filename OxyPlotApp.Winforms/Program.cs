using OxyPlotApp.Infrastructure;
using System;
using System.Windows.Forms;

namespace OxyPlotApp.Winforms
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

            var kernel = new OxyPlotKernel();
            var formMain = kernel.Get<FormOxyPlot>();

            Application.Run(formMain);
        }
    }
}
