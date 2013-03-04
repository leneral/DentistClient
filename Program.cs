using System;
using System.Windows.Forms;

namespace DentistryClient
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var loader = new ViewLoader();
            loader.LoadLoginView();

            if (loader.LastLoadedView.ShowDialog() == DialogResult.OK)
            {
                loader.LoadDentistrySupervisorView();
                loader.LastLoadedView.ShowDialog();
            }
        }
    }
}