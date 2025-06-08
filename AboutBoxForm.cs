using System.Diagnostics;
using System.Media;
using Julian_and_his_dates.Properties;
using NLog;

namespace Julian_and_his_dates
{
	/// <summary>
	/// Represents the About Box form of the application.
	/// </summary>
	[DebuggerDisplay(value: $"{{{nameof(GetDebuggerDisplay)}(),nq}}")]

	internal sealed partial class AboutBoxForm : Form
	{
		/// <summary>
		/// Logger instance for logging messages and exceptions.
		/// </summary>
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

		/// <summary>
		/// The color used for white font.
		/// </summary>
		private readonly Color _colorWhiteFont = Color.WhiteSmoke;

		/// <summary>
		/// The color used for the dark background.
		/// </summary>
		private readonly Color _colorDarkBackground = Color.FromArgb(red: 29, green: 32, blue: 41);

		/// <summary>
		/// Returns a string that represents the current object for debugging purposes.
		/// </summary>
		/// <returns>A string that represents the current object.</returns>
		private string GetDebuggerDisplay() => ToString();

		/// <summary>
		/// Sets a specific text to the status bar.
		/// </summary>
		/// <param name="text">The text with some information to display in the status bar.</param>
		private void SetStatusBarText(string text)
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
			_ = MessageBox.Show(text: message, caption: @"Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}

		/// <summary>
		/// Sets the dark mode
		/// </summary>
		public void SetDarkMode()
		{
			statusStrip.BackColor = _colorDarkBackground;
			labelInformation.BackColor = _colorDarkBackground;
			labelInformation.ForeColor = _colorWhiteFont;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="AboutBoxForm"/> class.
		/// Sets the text of the labels to the corresponding assembly information.
		/// </summary>
		public AboutBoxForm()
		{
			InitializeComponent();
			Logger.Info(message: "AboutBoxForm initialized.");
			Text = $@"Info about {AssemblyInfo.AssemblyTitle}";
			labelProductName.Text = AssemblyInfo.AssemblyProduct;
			labelVersion.Text = $@"Version {AssemblyInfo.AssemblyVersion}";
			labelCopyright.Text = AssemblyInfo.AssemblyCopyright;
			labelCompanyName.Text = AssemblyInfo.AssemblyCompany;
			textBoxDescription.Text = AssemblyInfo.AssemblyDescription;
			KeyDown += AboutBoxForm_KeyDown;
			KeyPreview = true; // Ensures the form receives key events before the controls
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LogoPictureBox_Click(object sender, EventArgs e)
		{
			using SoundPlayer sound = new(stream: Resources.wavBleep);
			sound.Play();
		}

		/// <summary>
		/// Handles the Load event of the AboutBoxForm control.
		/// Initializes the status bar text to an empty string.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void AboutBoxForm_Load(object sender, EventArgs e) => SetStatusBarText(text: string.Empty);

		/// <summary>
		/// Detect the accessibility description to set as information text in the status bar
		/// </summary>
		/// <param name="sender">The event source</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data</param>
		private void SetStatusBar_Enter(object sender, EventArgs e)
		{
			// Set the status bar text based on the sender's accessible description
			switch (sender)
			{
				// If the sender is a control with an accessible description, set the status bar text
				// If the sender is a ToolStripItem with an accessible description, set the status bar text
				case Control { AccessibleDescription: not null } control:
					SetStatusBarText(text: control.AccessibleDescription);
					break;
				case ToolStripItem { AccessibleDescription: not null } item:
					SetStatusBarText(text: item.AccessibleDescription);
					break;
			}
		}

		/// <summary>
		/// Clears the information text of the status bar.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ClearStatusBar_Leave(object sender, EventArgs e) => SetStatusBarText(text: string.Empty);

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
				Close();
			}
		}
	}
}
