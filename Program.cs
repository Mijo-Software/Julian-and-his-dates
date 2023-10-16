using JulianAndHisDates;

namespace Julian_and_his_dates
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
			Application.Run(mainForm: new JulianandhisdatesForm());
		}
	}
}