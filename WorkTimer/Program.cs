using System.Diagnostics.Tracing;
using WorkTimer.Forms;

namespace WorkTimer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            bool AcikUygulamaVar = false;
            Mutex m = new Mutex(true, "WorkTimer", out AcikUygulamaVar);
            if (AcikUygulamaVar)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMiniScreen());
            }
        }
    }
}