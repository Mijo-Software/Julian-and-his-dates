using System;
using System.Windows.Forms;

namespace JulianAndHisDates
{
    internal static class Program
    {
        /// <summary>
        /// main entrance point
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(defaultValue: false);
            using (JulianandhisdatesForm mainForm = new JulianandhisdatesForm())
            {
                Application.Run(mainForm: mainForm);
            }
        }
    }
}