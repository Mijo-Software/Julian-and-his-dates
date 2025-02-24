using System.Diagnostics;
using Julian_and_his_dates.Properties;
using NLog;

namespace Julian_and_his_dates
{
	/// <summary>
	/// Represents the About Box form of the application.
	/// </summary>
	[DebuggerDisplay(value: $"{{{nameof(GetDebuggerDisplay)}(),nq}}")]

	internal partial class AboutBoxForm : Form
	{
		/// <summary>
		/// Logger instance for logging messages and exceptions.
		/// </summary>
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

		/// <summary>
		/// The color used for white font.
		/// </summary>
		private readonly Color colorWhiteFont = Color.WhiteSmoke;

		/// <summary>
		/// The color used for the dark background.
		/// </summary>
		private readonly Color colorDarkBackground = Color.FromArgb(red: 29, green: 32, blue: 41);

		/// <summary>
		/// Returns a string that represents the current object for debugging purposes.
		/// </summary>
		/// <returns>A string that represents the current object.</returns>
		private string GetDebuggerDisplay() => ToString();

		/// <summary>
		/// Sets a specific text to the status bar.
		/// </summary>
		/// <param name="text">The text with some information to display in the status bar.</param>
		private void SetStatusbarText(string text)
		{
			labelInformation.Enabled = !string.IsNullOrWhiteSpace(value: text);
			labelInformation.Text = text;
		}

		/// <summary>
		/// Handles exceptions by logging the error and showing a message box
		/// </summary>
		/// <param name="ex">The exception that occurred</param>
		/// <param name="message">The message to log and display</param>
		/// <param name="sender">The source of the event that caused the exception</param>
		/// <param name="e">The event data associated with the exception</param>
		private static void HandleException(Exception ex, string message, object? sender = null, EventArgs? e = null)
		{
			string msg = $"Error: {ex}\nMessage: {ex.Message}\nStackTrace: {ex.StackTrace}\nSender: {sender}, EventArgs: {e}";
			Debug.WriteLine(value: msg);
			Console.WriteLine(value: msg);
			Logger.Error(exception: ex, message: msg);
			_ = MessageBox.Show(text: message, caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}

		/// <summary>
		/// Sets the dark mode
		/// </summary>
		public void SetDarkMode()
		{
			statusStrip.BackColor = colorDarkBackground;
			labelInformation.BackColor = colorDarkBackground;
			labelInformation.ForeColor = colorWhiteFont;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="AboutBoxForm"/> class.
		/// Sets the text of the labels to the corresponding assembly information.
		/// </summary>
		public AboutBoxForm()
		{
			InitializeComponent();
			Logger.Info(message: "AboutBoxForm initialized.");
			Text = $"Info about {AssemblyInfo.AssemblyTitle}";
			labelProductName.Text = AssemblyInfo.AssemblyProduct;
			labelVersion.Text = $"Version {AssemblyInfo.AssemblyVersion}";
			labelCopyright.Text = AssemblyInfo.AssemblyCopyright;
			labelCompanyName.Text = AssemblyInfo.AssemblyCompany;
			textBoxDescription.Text = AssemblyInfo.AssemblyDescription;
			this.KeyDown += new KeyEventHandler(AboutBoxForm_KeyDown);
			this.KeyPreview = true; // Ensures the form receives key events before the controls
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LogoPictureBox_Click(object sender, EventArgs e)
		{
			using System.Media.SoundPlayer sound = new(stream: Resources.wavBleep);
			sound.Play();
		}

		/// <summary>
		/// Handles the Load event of the AboutBoxForm control.
		/// Initializes the status bar text to an empty string.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void AboutBoxForm_Load(object sender, EventArgs e) => SetStatusbarText(text: string.Empty);

		/// <summary>
		/// Detect the accessibility description to set as information text in the status bar
		/// </summary>
		/// <param name="sender">The event source</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data</param>
		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
			try
			{
				if (sender is Control { AccessibleDescription: { } } control)
				{
					SetStatusbarText(text: control.AccessibleDescription);
				}
				else if (sender is ToolStripMenuItem { AccessibleDescription: { } } control2)
				{
					SetStatusbarText(text: control2.AccessibleDescription);
				}
				else if (sender is ToolStripStatusLabel { AccessibleDescription: { } } control3)
				{
					SetStatusbarText(text: control3.AccessibleDescription);
				}
				else if (sender is ToolStripButton { AccessibleDescription: { } } control4)
				{
					SetStatusbarText(text: control4.AccessibleDescription);
				}
				else if (sender is ToolStripDropDownButton { AccessibleDescription: { } } control5)
				{
					SetStatusbarText(text: control5.AccessibleDescription);
				}
				else if (sender is ToolStripSplitButton { AccessibleDescription: { } } control6)
				{
					SetStatusbarText(text: control6.AccessibleDescription);
				}
			}
			catch (Exception ex)
			{
				HandleException(ex: ex, message: "An error occurred while setting the status bar text.", sender: sender, e: e);
			}
		}

		/// <summary>
		/// Clears the information text of the status bar.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => SetStatusbarText(text: string.Empty);

		/// <summary>
		/// Handles the KeyDown event of the ExportDataSheetForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void AboutBoxForm_KeyDown(object? sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}
	}
}
