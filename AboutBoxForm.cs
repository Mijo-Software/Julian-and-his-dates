using Julian_and_his_dates.Properties;
using MijoSoftware.AssemblyInformation;


namespace JulianAndHisDates
{
	internal partial class AboutBoxForm : Form
	{
		/// <summary>
		/// 
		/// </summary>
		public AboutBoxForm()
		{
			InitializeComponent();
			Text = $"Info about {AssemblyInfo.AssemblyTitle}";
			labelProductName.Text = AssemblyInfo.AssemblyProduct;
			labelVersion.Text = $"Version {AssemblyInfo.AssemblyVersion}";
			labelCopyright.Text = AssemblyInfo.AssemblyCopyright;
			labelCompanyName.Text = AssemblyInfo.AssemblyCompany;
			textBoxDescription.Text = AssemblyInfo.AssemblyDescription;
		}

		private void LogoPictureBox_Click(object sender, EventArgs e)
		{
			using System.Media.SoundPlayer sound = new(stream: Resources.wavBleep);
			sound.Play();
		}

		private void AboutBoxForm_Load(object sender, EventArgs e)
		{
		}
	}
}
