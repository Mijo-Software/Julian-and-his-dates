using MijoSoftware.AssemblyInformation;

using System;
using System.Windows.Forms;

namespace JulianAndHisDates
{
	internal partial class AboutBoxForm : Form
	{
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
			using (System.Media.SoundPlayer sound = new System.Media.SoundPlayer(stream: Properties.Resources.wavBleep))
			{
				sound.Play();
			}
		}

		private void AboutBoxForm_Load(object sender, EventArgs e)
		{
		}
	}
}
