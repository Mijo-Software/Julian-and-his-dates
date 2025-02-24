using System.Diagnostics;
using System.Globalization;
using System.Media;
using Julian_and_his_dates.Properties;
using NLog;

namespace Julian_and_his_dates
{
	/// <summary>
	/// Initialize the form
	/// </summary>
	[DebuggerDisplay(value: $"{{{nameof(GetDebuggerDisplay)}(),nq}}")]

	public partial class JulianandhisdatesForm : Form
	{
		/// <summary>
		/// Stores the old Julian Date value.
		/// </summary>
		private double doubleOldJD = 0.999999999999999999999999;

		/// <summary>
		/// Stores the new Julian Date value.
		/// </summary>
		private double doubleNewJD;

		/// <summary>
		/// Indicates whether it is the first run of the application.
		/// </summary>
		private bool boolFirstRun = true;

		/// <summary>
		/// Indicates whether the alarm is enabled.
		/// </summary>
		private bool boolIsAlarmEnabled = true;

		/// <summary>
		/// The default tick interval for the timer.
		/// </summary>
		private readonly int intDefaultTick = 20;

		/// <summary>
		/// The color used for white font.
		/// </summary>
		private readonly Color colorWhiteFont = Color.WhiteSmoke;

		/// <summary>
		/// The color used for the dark background.
		/// </summary>
		private readonly Color colorDarkBackground = Color.FromArgb(red: 29, green: 32, blue: 41);

		/// <summary>
		/// culture info for the date
		/// </summary>
		private readonly CultureInfo culture = CultureInfo.CurrentUICulture;

		/// <summary>
		/// Logger instance for logging messages and exceptions.
		/// </summary>
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

		/// <summary>
		/// Returns a string that represents the current object for debugging purposes.
		/// </summary>
		/// <returns>A string that represents the current object.</returns>
		private string GetDebuggerDisplay() => ToString();

		#region Helpers

		/// <summary>
		/// Get the default settings
		/// </summary>
		private static Settings GetDefault() => Settings.Default;

		/// <summary>
		/// Show an error message
		/// </summary>
		private static void ShowAndLogErrorMessage(Exception ex, string messageLogger, string messageBox)
		{
			Debug.WriteLine(value: ex);
			Logger.Error(exception: ex, message: messageLogger);
			_ = MessageBox.Show(text: messageBox, caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}

		/// <summary>
		///  Update the date informations
		/// </summary>
		private void UpdateDateInformations()
		{
			labelLocalTime.Text = DateTime.Now.ToString(provider: culture);
			labelUtcTime.Text = DateTime.UtcNow.ToString(provider: culture);
			labelJulianDate.Text = JulianDates.CalculateJulianDate().ToString(provider: culture);
			labelModifiedJulianDate.Text = JulianDates.CalculateModifiedJulianDate().ToString(provider: culture);
			labelReducedJulianDate.Text = JulianDates.CalculateReducedJulianDate().ToString(provider: culture);
			labelTruncatedJulianDate.Text = JulianDates.CalculateTruncatedJulianDate().ToString(provider: culture);
			labelDublinJulianDate.Text = JulianDates.CalculateDublinJulianDate().ToString(provider: culture);
			labelCnesJulianDate.Text = JulianDates.CalculateCnesJulianDate().ToString(provider: culture);
			labelCcsdsJulianDate.Text = JulianDates.CalculateCcsdsJulianDate().ToString(provider: culture);
			labelLopJulianDate.Text = JulianDates.CalculateLopJulianDate().ToString(provider: culture);
			labelMillenniumJulianDate.Text = JulianDates.CalculateMillenniumJulianDate().ToString(provider: culture);
			labelChronologicalJulianDate.Text = JulianDates.CalculateChronologicalJulianDate().ToString(provider: culture);
			labelChronologicalModifiedJulianDate.Text = JulianDates.CalculateChronologicalModifiedJulianDate().ToString(provider: culture);
			labelLilianDate.Text = JulianDates.CalculateLilianDate().ToString(provider: culture);
			labelRataDie.Text = JulianDates.CalculateRataDie().ToString(provider: culture);
			labelMarsSolDate.Text = JulianDates.CalculateMarsSolDate().ToString(provider: culture);
			labelUnixtime.Text = JulianDates.CalculateUnixTime().ToString(provider: culture);
		}

		/// <summary>
		/// Saves an image of the screen to the specified path.
		/// </summary>
		/// <param name="location">Path where the output file will be saved.</param>
		/// <returns>Path of the successfully saved image or an error message.</returns>
		public string ScreenToPicture(string location)
		{
			try
			{
				using Bitmap screenToBitmap = new(width: Size.Width, height: Size.Height);
				using Graphics gGraphics = Graphics.FromImage(image: screenToBitmap);
				Size currentScreenSize = new(width: Size.Width, height: Size.Height);
				gGraphics.CopyFromScreen(
					upperLeftSource: Location,
					upperLeftDestination: new Point(x: 0, y: 0),
					blockRegionSize: currentScreenSize);
				screenToBitmap.Save(filename: location);
				return location;
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}

		/// <summary>
		/// Copies the specified text to the clipboard and shows a message box.
		/// </summary>
		/// <param name="strText">The text to copy to the clipboard.</param>
		private static void CopyToClipboard(string strText)
		{
			Clipboard.SetText(text: strText);
			_ = MessageBox.Show(
				text: Resources.strCopiedToClipboard,
				caption: Resources.strInformation,
				buttons: MessageBoxButtons.OK,
				icon: MessageBoxIcon.Information);
		}

		/// <summary>
		/// Sets the status bar text.
		/// </summary>
		/// <param name="text">The text to display in the status bar.</param>
		private void SetStatusbar(string text)
		{
			toolStripStatusLabelInformation.Visible = true;
			toolStripStatusLabelInformation.Text = text;
			toolStripStatusLabelAlarm.Visible = false;
			toolStripStatusLabelTakeScreenshot.Visible = false;
		}

		/// <summary>
		/// Resets the status bar to its default state.
		/// </summary>
		private void ResetStatusbar()
		{
			toolStripStatusLabelInformation.Visible = false;
			toolStripStatusLabelInformation.Text = string.Empty;
			toolStripStatusLabelAlarm.Visible = true;
			toolStripStatusLabelTakeScreenshot.Visible = true;
		}

		/// <summary>
		/// Updates the label's cursor, font style, and status bar text on Enter event.
		/// </summary>
		/// <param name="label">The label to update.</param>
		private void UpdateLabelOnEnter(Label label)
		{
			label.Cursor = Cursors.Hand;
			label.Font = new Font(prototype: label.Font, newStyle: FontStyle.Underline);
			SetStatusbar(text: label.AccessibleDescription ?? string.Empty);
		}

		/// <summary>
		/// Resets the state of the label when it is left.
		/// </summary>
		/// <param name="label">The label to reset the state for.</param>
		private void ResetLabelState(Label label)
		{
			label.Cursor = Cursors.Default;
			label.Font = new Font(prototype: label.Font, newStyle: FontStyle.Regular);
			ResetStatusbar();
		}

		/// <summary>
		/// Called when the mouse pointer moves over a control
		/// </summary>
		/// <param name="sender">The event source</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data</param>
		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
			try
			{
				if (sender is Control { AccessibleDescription: { } } control)
				{
					SetStatusbar(text: control.AccessibleDescription);
				}
				else if (sender is ToolStripMenuItem { AccessibleDescription: { } } control2)
				{
					SetStatusbar(text: control2.AccessibleDescription);
				}
				else if (sender is ToolStripStatusLabel { AccessibleDescription: { } } control3)
				{
					SetStatusbar(text: control3.AccessibleDescription);
				}
				else if (sender is ToolStripButton { AccessibleDescription: { } } control4)
				{
					SetStatusbar(text: control4.AccessibleDescription);
				}
				else if (sender is ToolStripDropDownButton { AccessibleDescription: { } } control5)
				{
					SetStatusbar(text: control5.AccessibleDescription);
				}
				else if (sender is ToolStripSplitButton { AccessibleDescription: { } } control6)
				{
					SetStatusbar(text: control6.AccessibleDescription);
				}
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error setting status bar text on enter.", messageBox: "An error occurred while setting the status bar text on enter.");
			}
		}

		#endregion

		#region Constructor

		/// <summary>
		/// Initialize the form.
		/// </summary>
		public JulianandhisdatesForm()
		{
			InitializeComponent();
			Logger.Info(message: "JulianandhisdatesForm initialized.");
			this.KeyDown += new KeyEventHandler(JulianandhisdatesForm_KeyDown);
			this.KeyPreview = true; // Ensures the form receives key events before the controls
		}

		#endregion

		#region Form event handlers

		/// <summary>
		/// Handles the Load event of the form.
		/// Initializes the form's settings and updates the date information.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void JulianandhisdatesForm_Load(object sender, EventArgs e)
		{
			Settings settings = GetDefault();
			BackColor = settings.BackgroundColor;
			ForeColor = settings.ForegroundColor;
			foreach (Label? label in new[]
			{
				labelUtcTimeText, labelLocalTimeText, labelJulianDateText, labelModifiedJulianDateText,
				labelReducedJulianDateText, labelTruncatedJulianDateText, labelDublinJulianDateText,
				labelCnesJulianDateText, labelCcsdsJulianDateText, labelLopJulianDateText,
				labelMillenniumJulianDateText, labelChronologicalJulianDateText, labelChronologicalModifiedJulianDateText,
				labelLilianDateText, labelRataDieText, labelMarsSolDateText, labelUnixtimeText,
				labelUtcTime, labelLocalTime, labelJulianDate, labelModifiedJulianDate,
				labelReducedJulianDate, labelTruncatedJulianDate, labelDublinJulianDate,
				labelCnesJulianDate, labelCcsdsJulianDate, labelLopJulianDate,
				labelMillenniumJulianDate, labelChronologicalJulianDate, labelChronologicalModifiedJulianDate,
				labelLilianDate, labelRataDie, labelMarsSolDate, labelUnixtime, labelRefreshRateText
			})
			{
				label.ForeColor = settings.ForegroundColor;
			}
			timer.Interval = settings.userTicks;
			checkBoxDarkLightMode.Checked = settings.isDarkmodeEnabled;
			checkBoxAutomaticRefresh.Checked = settings.isAutomaticRefreshing;
			checkBoxStayOnTop.Checked = settings.isStayOnTop;
			checkBoxStayOnTop.Text = settings.isStayOnTop ? Resources.strApplicationNotOnTop : Resources.strApplicationOnTop;
			TopMost = settings.isStayOnTop;
			numericUpDownRefreshRate.Value = timer.Interval;
			boolIsAlarmEnabled = settings.isAlarmEnabled;
			toolStripStatusLabelAlarm.Image = boolIsAlarmEnabled ? Resources.sound : Resources.sound_mute;
			toolStripStatusLabelAlarm.Text = boolIsAlarmEnabled ? Resources.strAlarmOn : Resources.strAlarmOff;
			UpdateDateInformations();
		}

		/// <summary>
		/// Handles the FormClosing event of the form.
		/// Saves the current settings before the form is closed.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void JulianandhisdatesForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Settings.Default.BackgroundColor = BackColor;
			Settings.Default.ForegroundColor = labelUtcTimeText.ForeColor;
			Settings.Default.userTicks = timer.Interval;
			Settings.Default.isDarkmodeEnabled = checkBoxDarkLightMode.Checked;
			Settings.Default.isAlarmEnabled = boolIsAlarmEnabled;
			Settings.Default.isAutomaticRefreshing = checkBoxAutomaticRefresh.Checked;
			Settings.Default.isStayOnTop = checkBoxStayOnTop.Checked;
			Settings.Default.Save();
		}

		#endregion

		#region Timer event handlers

		/// <summary>
		/// Handles the Tick event of the timer.
		/// Updates the date information and plays an alarm sound if the Julian Date changes.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void Timer_Tick(object sender, EventArgs e)
		{
			UpdateDateInformations();
			doubleNewJD = JulianDates.CalculateJulianDate();
			doubleNewJD -= Math.Truncate(d: doubleNewJD);
			if (doubleNewJD < doubleOldJD)
			{
				doubleOldJD = doubleNewJD;
				if (boolFirstRun)
				{
					boolFirstRun = false;
				}
				else
				{
					using SoundPlayer sound = new(stream: Resources.wavBleep);
					sound.Play();
					notifyIcon.BalloonTipText = JulianDates.CalculateJulianDate().ToString(provider: culture);
					notifyIcon.BalloonTipTitle = Resources.strJdSwitched;
					notifyIcon.ShowBalloonTip(timeout: 500);
				}
			}
		}

		#endregion

		#region Click event handlers

		/// <summary>
		/// Handles the Click event of the Refresh button.
		/// Updates the date information.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void ButtonRefresh_Click(object sender, EventArgs e) => UpdateDateInformations();

		/// <summary>
		/// Handles the Click event of the Info button.
		/// Shows the About dialog.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void ButtonInfo_Click(object sender, EventArgs e)
		{
			bool wasOnTop = TopMost;
			TopMost = false;
			using (AboutBoxForm about = new())
			{
				if (checkBoxDarkLightMode.Checked)
				{
					about.BackColor = colorDarkBackground;
					about.ForeColor = colorWhiteFont;
					about.SetDarkMode();
				}
				_ = about.ShowDialog();
			}
			TopMost = wasOnTop;
		}

		/// <summary>
		/// Handles the Click event of the Minimize to Tray button.
		/// Minimizes the application to the system tray and shows a notification.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void ButtonMinimizeToTray_Click(object sender, EventArgs e)
		{
			Hide();
			notifyIcon.Visible = true;
			notifyIcon.BalloonTipText = Resources.strApplicationMinimizedText;
			notifyIcon.BalloonTipTitle = Resources.strApplicationMinimizedTitle;
			notifyIcon.ShowBalloonTip(timeout: 500);
		}

		/// <summary>
		/// Handles the Click event for the UTC time label text.
		/// Shows a message box with information about UTC time.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUtcTimeText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strUtcTimeText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		/// Handles the Click event for the local time label text.
		/// Shows a message box with information about local time.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLocalTimeText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strLocalTimeText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		/// Handles the Click event for the Julian date label text.
		/// Shows a message box with information about Julian date.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		/// Handles the Click event for the modified Julian date label text.
		/// Shows a message box with information about modified Julian date.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelModifiedJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strModifiedJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		/// Handles the Click event for the reduced Julian date label text.
		/// Shows a message box with information about reduced Julian date.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelReducedJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strReducedJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		/// Handles the Click event for the truncated Julian date label text.
		/// Shows a message box with information about truncated Julian date.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelTruncatedJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strTruncatedJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		/// Handles the Click event for the Dublin Julian date label text.
		/// Shows a message box with information about Dublin Julian date.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelDublinJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strDublinJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		/// Handles the Click event for the CNES Julian date label text.
		/// Shows a message box with information about CNES Julian date.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCnesJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strCnesJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		/// Handles the Click event for the CCSDS Julian date label text.
		/// Shows a message box with information about CCSDS Julian date.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCcsdsJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strCcsdsJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		/// Handles the Click event for the LOP Julian date label text.
		/// Shows a message box with information about LOP Julian date.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLopJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strLopJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		/// Handles the Click event for the Millennium Julian date label text.
		/// Shows a message box with information about Millennium Julian date.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMillenniumJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strMillenniumJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		/// Handles the Click event for the chronological Julian date label text.
		/// Shows a message box with information about chronological Julian date.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strChronologicalJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		/// Handles the Click event for the chronological modified Julian date label text.
		/// Shows a message box with information about chronological modified Julian date.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalModifiedJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strChronologicalModifiedJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		/// Handles the Click event for the Lilian date label text.
		/// Shows a message box with information about Lilian date.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLilianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strLilianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		/// Handles the Click event for the Rata Die label text.
		/// Shows a message box with information about Rata Die.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelRataDieText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strRataDieText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		/// Handles the Click event for the Mars Sol date label text.
		/// Shows a message box with information about Mars Sol date.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMarsSolDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strMarsSolDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		/// Handles the Click event for the Unix time label text.
		/// Shows a message box with information about Unix time.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUnixtimeText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strUnixtimeText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		/// Handles the Click event of the Open Julian Date Calculator button.
		/// Opens the Julian Date Calculator form.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void ButtonOpenJulianDateCalculator_Click(object sender, EventArgs e)
		{
			bool wasOnTop = TopMost;
			TopMost = false;
			using (JulianDateCalculatorForm form = new())
			{
				if (checkBoxDarkLightMode.Checked)
				{
					form.BackColor = colorDarkBackground;
					form.ForeColor = colorWhiteFont;
				}
				_ = form.ShowDialog();
			}
			TopMost = wasOnTop;
		}

		/// <summary>
		/// Handles the Click event of the Open Julian Date Converter button.
		/// Opens the Julian Date Converter form.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void ButtonOpenJulianDateConverter_Click(object sender, EventArgs e)
		{
			bool wasOnTop = TopMost;
			TopMost = false;
			using (JulianDateConverterForm form = new())
			{
				if (checkBoxDarkLightMode.Checked)
				{
					form.BackColor = colorDarkBackground;
					form.ForeColor = colorWhiteFont;
					form.SetDarkMode();
				}
				_ = form.ShowDialog();
			}
			TopMost = wasOnTop;
		}

		/// <summary>
		/// Handles the Click event of the Alarm status label.
		/// Toggles the alarm state and updates the status label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void ToolStripStatusLabelAlarm_Click(object sender, EventArgs e)
		{
			if (boolIsAlarmEnabled)
			{
				boolIsAlarmEnabled = false;
				toolStripStatusLabelAlarm.Image = Resources.sound_mute;
				toolStripStatusLabelAlarm.Text = Resources.strAlarmOff;
			}
			else
			{
				boolIsAlarmEnabled = true;
				toolStripStatusLabelAlarm.Image = Resources.sound;
				toolStripStatusLabelAlarm.Text = Resources.strAlarmOn;
				using SoundPlayer sound = new(stream: Resources.wavBleep);
				sound.Play();
			}
		}

		/// <summary>
		/// Handles the Click event of the Take Screenshot status label.
		/// Takes a screenshot of the current form and saves it to the user's Pictures folder.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void ToolStripStatusLabelTakeScreenshot_Click(object sender, EventArgs e)
		{
			using SoundPlayer sound = new(stream: Resources.wavCameraFlashing);
			sound.Play();
			string
				strPathToMyPictures = Environment.GetFolderPath(folder: Environment.SpecialFolder.MyPictures) + "\\",
				strFilenameWithExtension = JulianDates.CalculateJulianDate().ToString(provider: culture) + ".png",
				strInfotext = Resources.strScreenshotSavedTo;
			_ = MessageBox.Show(
				text: strInfotext + "\n\n" + ScreenToPicture(location: strPathToMyPictures + strFilenameWithExtension));
		}

		#endregion

		#region DoubleClick event handlers

		/// <summary>
		/// Handles the DoubleClick event for the Refresh Rate text label.
		/// Resets the refresh rate to the default value.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelRefreshRateText_DoubleClick(object sender, EventArgs e) => numericUpDownRefreshRate.Value =
			intDefaultTick;

		/// <summary>
		/// Handles the DoubleClick event for the UTC time label.
		/// Copies the UTC time to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUtcTime_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelUtcTime.Text);

		/// <summary>
		/// Handles the DoubleClick event for the local time label.
		/// Copies the local time to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLocalTime_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelLocalTime.Text);

		/// <summary>
		/// Handles the DoubleClick event for the Julian date label.
		/// Copies the Julian date to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelJulianDate.Text);

		/// <summary>
		/// Handles the DoubleClick event for the modified Julian date label.
		/// Copies the modified Julian date to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelModifiedJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelModifiedJulianDate.Text);

		/// <summary>
		/// Handles the DoubleClick event for the reduced Julian date label.
		/// Copies the reduced Julian date to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelReducedJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelReducedJulianDate.Text);

		/// <summary>
		/// Handles the DoubleClick event for the truncated Julian date label.
		/// Copies the truncated Julian date to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelTruncatedJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelTruncatedJulianDate.Text);

		/// <summary>
		/// Handles the DoubleClick event for the Dublin Julian date label.
		/// Copies the Dublin Julian date to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelDublinJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelDublinJulianDate.Text);

		/// <summary>
		/// Handles the DoubleClick event for the CNES Julian date label.
		/// Copies the CNES Julian date to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCnesJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelCnesJulianDate.Text);

		/// <summary>
		/// Handles the DoubleClick event for the CCSDS Julian date label.
		/// Copies the CCSDS Julian date to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCcsdsJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelCcsdsJulianDate.Text);

		/// <summary>
		/// Handles the DoubleClick event for the LOP Julian date label.
		/// Copies the LOP Julian date to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLopJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelLopJulianDate.Text);

		/// <summary>
		/// Handles the DoubleClick event for the Millennium Julian date label.
		/// Copies the Millennium Julian date to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMillenniumJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelMillenniumJulianDate.Text);

		/// <summary>
		/// Handles the DoubleClick event for the chronological Julian date label.
		/// Copies the chronological Julian date to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelChronologicalJulianDate.Text);

		/// <summary>
		/// Handles the DoubleClick event for the chronological modified Julian date label.
		/// Copies the chronological modified Julian date to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalModifiedJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelChronologicalModifiedJulianDate.Text);

		/// <summary>
		/// Handles the DoubleClick event for the Lilian date label.
		/// Copies the Lilian date to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLilianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelLilianDate.Text);

		/// <summary>
		/// Handles the DoubleClick event for the Rata Die label.
		/// Copies the Rata Die to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelRataDie_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelRataDie.Text);

		/// <summary>
		/// Handles the DoubleClick event for the Mars Sol date label.
		/// Copies the Mars Sol date to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMarsSolDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelMarsSolDate.Text);

		/// <summary>
		/// Handles the DoubleClick event for the Unix time label.
		/// Copies the Unix time to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUnixtime_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelUnixtime.Text);

		/// <summary>
		/// Handles the MouseDoubleClick event for the notify icon.
		/// Restores the application from the system tray and shows a notification.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Show();
			notifyIcon.BalloonTipText = Resources.strApplicationMaximizedText;
			notifyIcon.BalloonTipTitle = Resources.strApplicationMaximizedTitle;
			notifyIcon.ShowBalloonTip(timeout: 500);
			notifyIcon.Visible = false;
		}

		#endregion

		#region CheckedChanged event handlers

		/// <summary>
		/// Handles the CheckedChanged event for the automatic refresh checkbox.
		/// Enables or disables the timer based on the checkbox state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void CheckBoxAutomaticRefresh_CheckedChanged(object sender, EventArgs e)
		{
			timer.Enabled = checkBoxAutomaticRefresh.Checked;
			buttonRefresh.Enabled = !checkBoxAutomaticRefresh.Checked;
		}

		/// <summary>
		/// Handles the CheckedChanged event for the stay on top checkbox.
		/// Sets the form's TopMost property based on the checkbox state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void CheckBoxStayOnTop_CheckedChanged(object sender, EventArgs e)
		{
			TopMost = checkBoxStayOnTop.Checked;
			checkBoxStayOnTop.Text = checkBoxStayOnTop.Checked ? Resources.strApplicationNotOnTop : Resources.strApplicationOnTop;
		}

		/// <summary>
		/// Handles the CheckedChanged event for the dark/light mode checkbox.
		/// Toggles between dark mode and light mode based on the checkbox state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void CheckBoxDarkLightMode_CheckedChanged(object sender, EventArgs e)
		{
			bool isDarkMode = checkBoxDarkLightMode.Checked;
			checkBoxDarkLightMode.Text = isDarkMode ? "&Light Mode" : "&Dark Mode";
			Color backColor = isDarkMode ? colorDarkBackground : SystemColors.Control;
			Color foreColor = isDarkMode ? colorWhiteFont : SystemColors.ControlText;

			BackColor = backColor;
			ForeColor = foreColor;
			statusStrip.BackColor = backColor;
			statusStrip.ForeColor = foreColor;

			foreach (Control control in Controls)
			{
				control.BackColor = backColor;
				control.ForeColor = foreColor;
			}

			numericUpDownRefreshRate.BackColor = backColor;
			numericUpDownRefreshRate.ForeColor = foreColor;

			if (!boolFirstRun)
			{
				using SoundPlayer sound = new(stream: Resources.wavBlop);
				sound.Play();
			}
		}

		#endregion

		#region ValueChanged event handlers

		/// <summary>
		/// Handles the ValueChanged event of the Refresh Rate numeric up-down control.
		/// Updates the timer interval based on the selected value.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void NumericUpDownRefreshRate_ValueChanged(object sender, EventArgs e) => timer.Interval =
			(int)numericUpDownRefreshRate.Value;

		#endregion

		#region Leave event handlers

		/// <summary>
		/// Clears the information text of the status bar
		/// </summary>
		/// <param name="sender">The source of the event</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data</param>
		private void ClearStatusBar_Leave(object sender, EventArgs e)
		{
			try
			{
				SetStatusbar(text: string.Empty);
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error clearing status bar text on leave.", messageBox: "An error occurred while clearing the status bar text on leave.");
			}
		}

		#endregion

		#region Enter event handlers

		/// <summary>
		/// Handles the Enter event for the UTC time label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUtcTimeText_Enter(object sender, EventArgs e) =>
			UpdateLabelOnEnter(label: labelUtcTimeText);

		/// <summary>
		/// Handles the Enter event for the local time label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLocalTimeText_Enter(object sender, EventArgs e) =>
			UpdateLabelOnEnter(label: labelLocalTimeText);

		/// <summary>
		/// Handles the Enter event for the Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelJulianDateText_Enter(object sender, EventArgs e) =>
			UpdateLabelOnEnter(label: labelJulianDateText);

		/// <summary>
		/// Handles the Enter event for the modified Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelModifiedJulianDateText_Enter(object sender, EventArgs e) =>
			UpdateLabelOnEnter(label: labelModifiedJulianDateText);

		/// <summary>
		/// Handles the Enter event for the reduced Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelReducedJulianDateText_Enter(object sender, EventArgs e) =>
			UpdateLabelOnEnter(label: labelReducedJulianDateText);

		/// <summary>
		/// Handles the Enter event for the truncated Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelTruncatedJulianDateText_Enter(object sender, EventArgs e) =>
			UpdateLabelOnEnter(label: labelTruncatedJulianDateText);

		/// <summary>
		/// Handles the Enter event for the Dublin Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelDublinJulianDateText_Enter(object sender, EventArgs e) =>
			UpdateLabelOnEnter(label: labelDublinJulianDateText);

		/// <summary>
		/// Handles the Enter event for the CNES Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCnesJulianDateText_Enter(object sender, EventArgs e) =>
			UpdateLabelOnEnter(label: labelCnesJulianDateText);

		/// <summary>
		/// Handles the Enter event for the CCSDS Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCcsdsJulianDateText_Enter(object sender, EventArgs e) =>
			UpdateLabelOnEnter(label: labelCcsdsJulianDateText);

		/// <summary>
		/// Handles the Enter event for the LOP Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLopJulianDateText_Enter(object sender, EventArgs e) =>
			UpdateLabelOnEnter(label: labelLopJulianDateText);

		/// <summary>
		/// Handles the Enter event for the Millennium Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMillenniumJulianDateText_Enter(object sender, EventArgs e) =>
			UpdateLabelOnEnter(label: labelMillenniumJulianDateText);

		/// <summary>
		/// Handles the Enter event for the chronological Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalJulianDateText_Enter(object sender, EventArgs e) =>
			UpdateLabelOnEnter(label: labelChronologicalJulianDateText);

		/// <summary>
		/// Handles the Enter event for the chronological modified Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalModifiedJulianDateText_Enter(object sender, EventArgs e) =>
			UpdateLabelOnEnter(label: labelChronologicalModifiedJulianDateText);

		/// <summary>
		/// Handles the Enter event for the Lilian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLilianDateText_Enter(object sender, EventArgs e) =>
			UpdateLabelOnEnter(label: labelLilianDateText);

		/// <summary>
		/// Handles the Enter event for the Rata Die label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelRataDieText_Enter(object sender, EventArgs e) =>
			UpdateLabelOnEnter(label: labelRataDieText);

		/// <summary>
		/// Handles the Enter event for the Mars Sol date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMarsSolDateText_Enter(object sender, EventArgs e) =>
			UpdateLabelOnEnter(label: labelMarsSolDateText);

		/// <summary>
		/// Handles the Enter event for the Unix time label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUnixtimeText_Enter(object sender, EventArgs e) =>
			UpdateLabelOnEnter(label: labelUnixtimeText);

		#endregion

		#region Leave event handlers

		/// <summary>
		/// Handles the Leave event for the UTC time label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUtcTimeText_Leave(object sender, EventArgs e) => ResetLabelState(label: labelUtcTimeText);

		/// <summary>
		/// Handles the Leave event for the local time label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLocalTimeText_Leave(object sender, EventArgs e) => ResetLabelState(label: labelLocalTimeText);

		/// <summary>
		/// Handles the Leave event for the Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelJulianDateText_Leave(object sender, EventArgs e) => ResetLabelState(label: labelJulianDateText);

		/// <summary>
		/// Handles the Leave event for the modified Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelModifiedJulianDateText_Leave(object sender, EventArgs e) => ResetLabelState(label: labelModifiedJulianDateText);

		/// <summary>
		/// Handles the Leave event for the reduced Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelReducedJulianDateText_Leave(object sender, EventArgs e) => ResetLabelState(label: labelReducedJulianDateText);

		/// <summary>
		/// Handles the Leave event for the truncated Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelTruncatedJulianDateText_Leave(object sender, EventArgs e) => ResetLabelState(label: labelTruncatedJulianDateText);

		/// <summary>
		/// Handles the Leave event for the Dublin Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelDublinJulianDateText_Leave(object sender, EventArgs e) => ResetLabelState(label: labelDublinJulianDateText);

		/// <summary>
		/// Handles the Leave event for the CNES Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCnesJulianDateText_Leave(object sender, EventArgs e) => ResetLabelState(label: labelCnesJulianDateText);

		/// <summary>
		/// Handles the Leave event for the CCSDS Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCcsdsJulianDateText_Leave(object sender, EventArgs e) => ResetLabelState(label: labelCcsdsJulianDateText);

		/// <summary>
		/// Handles the Leave event for the LOP Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLopJulianDateText_Leave(object sender, EventArgs e) => ResetLabelState(label: labelLopJulianDateText);

		/// <summary>
		/// Handles the Leave event for the Millennium Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMillenniumJulianDateText_Leave(object sender, EventArgs e) => ResetLabelState(label: labelMillenniumJulianDateText);

		/// <summary>
		/// Handles the Leave event for the chronological Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalJulianDateText_Leave(object sender, EventArgs e) => ResetLabelState(label: labelChronologicalJulianDateText);

		/// <summary>
		/// Handles the Leave event for the chronological modified Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalModifiedJulianDateText_Leave(object sender, EventArgs e) => ResetLabelState(label: labelChronologicalModifiedJulianDateText);

		/// <summary>
		/// Handles the Leave event for the Lilian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLilianDateText_Leave(object sender, EventArgs e) => ResetLabelState(label: labelLilianDateText);

		/// <summary>
		/// Handles the Leave event for the Rata Die label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelRataDieText_Leave(object sender, EventArgs e) => ResetLabelState(label: labelRataDieText);

		/// <summary>
		/// Handles the Leave event for the Mars Sol date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMarsSolDateText_Leave(object sender, EventArgs e) => ResetLabelState(label: labelMarsSolDateText);

		/// <summary>
		/// Handles the Leave event for the Unix time label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUnixtimeText_Leave(object sender, EventArgs e) => ResetLabelState(label: labelUnixtimeText);

		#endregion

		#region MouseEnter event handlers

		/// <summary>
		/// Handles the MouseEnter event for the UTC time label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUtcTimeText_MouseEnter(object sender, EventArgs e) => LabelUtcTimeText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the local time label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLocalTimeText_MouseEnter(object sender, EventArgs e) => LabelLocalTimeText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelJulianDateText_MouseEnter(object sender, EventArgs e) => LabelJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the modified Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelModifiedJulianDateText_MouseEnter(object sender, EventArgs e) => LabelModifiedJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the reduced Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelReducedJulianDateText_MouseEnter(object sender, EventArgs e) => LabelReducedJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the truncated Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelTruncatedJulianDateText_MouseEnter(object sender, EventArgs e) => LabelTruncatedJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the Dublin Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelDublinJulianDateText_MouseEnter(object sender, EventArgs e) => LabelDublinJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the CNES Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCnesJulianDateText_MouseEnter(object sender, EventArgs e) => LabelCnesJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the CCSDS Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCcsdsJulianDateText_MouseEnter(object sender, EventArgs e) => LabelCcsdsJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the LOP Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLopJulianDateText_MouseEnter(object sender, EventArgs e) => LabelLopJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the Millennium Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMillenniumJulianDateText_MouseEnter(object sender, EventArgs e) => LabelMillenniumJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the chronological Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalJulianDateText_MouseEnter(object sender, EventArgs e) => LabelChronologicalJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the chronological modified Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalModifiedJulianDateText_MouseEnter(object sender, EventArgs e) => LabelChronologicalModifiedJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the Lilian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLilianDateText_MouseEnter(object sender, EventArgs e) => LabelLilianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the Rata Die label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelRataDieText_MouseEnter(object sender, EventArgs e) => LabelRataDieText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the Mars Sol date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMarsSolDateText_MouseEnter(object sender, EventArgs e) => LabelMarsSolDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the Unix time label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUnixtimeText_MouseEnter(object sender, EventArgs e) => LabelUnixtimeText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the UTC time label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUtcTime_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelUtcTime.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the local time label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLocalTime_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelLocalTime.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the modified Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelModifiedJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelModifiedJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the reduced Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelReducedJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelReducedJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the truncated Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelTruncatedJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelTruncatedJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the Dublin Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelDublinJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelDublinJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the CNES Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCnesJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelCnesJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the CCSDS Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCcsdsJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelCcsdsJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the LOP Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLopJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelLopJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the Millennium Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMillenniumJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelMillenniumJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the chronological Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelChronologicalJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the chronological modified Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalModifiedJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelChronologicalModifiedJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the Lilian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLilianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelLilianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the Rata Die label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelRataDie_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelRataDie.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the Mars Sol date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMarsSolDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelMarsSolDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the Unix time label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUnixtime_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelUnixtime.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the automatic refresh checkbox.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void CheckBoxAutomaticRefresh_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: checkBoxAutomaticRefresh.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the stay on top checkbox.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void CheckBoxStayOnTop_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: checkBoxStayOnTop.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the dark/light mode checkbox.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void CheckBoxDarkLightMode_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: checkBoxDarkLightMode.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the refresh rate text label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelRefreshRateText_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelRefreshRateText.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the minimize to tray button.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void ButtonMinimizeToTray_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: buttonMinimizeToTray.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the info button.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void ButtonInfo_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: buttonInfo.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the refresh button.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void ButtonRefresh_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: buttonRefresh.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the open Julian date calculator button.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void ButtonOpenJulianDateCalculator_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: buttonOpenJulianDateCalculator.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the open Julian date converter button.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void ButtonOpenJulianDateConverter_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: buttonOpenJulianDateConverter.AccessibleDescription ?? string.Empty);

		#endregion

		#region MouseLeave event handlers

		/// <summary>
		/// Handles the MouseLeave event for the UTC time label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUtcTimeText_MouseLeave(object sender, EventArgs e) => LabelUtcTimeText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the local time label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLocalTimeText_MouseLeave(object sender, EventArgs e) => LabelLocalTimeText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelJulianDateText_MouseLeave(object sender, EventArgs e) => LabelJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the modified Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelModifiedJulianDateText_MouseLeave(object sender, EventArgs e) => LabelModifiedJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the reduced Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelReducedJulianDateText_MouseLeave(object sender, EventArgs e) => LabelReducedJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the truncated Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelTruncatedJulianDateText_MouseLeave(object sender, EventArgs e) => LabelTruncatedJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the Dublin Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelDublinJulianDateText_MouseLeave(object sender, EventArgs e) => LabelDublinJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the CNES Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCnesJulianDateText_MouseLeave(object sender, EventArgs e) => LabelCnesJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the CCSDS Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCcsdsJulianDateText_MouseLeave(object sender, EventArgs e) => LabelCcsdsJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the LOP Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLopJulianDateText_MouseLeave(object sender, EventArgs e) => LabelLopJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the Millennium Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMillenniumJulianDateText_MouseLeave(object sender, EventArgs e) => LabelMillenniumJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the chronological Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalJulianDateText_MouseLeave(object sender, EventArgs e) => LabelChronologicalJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the chronological modified Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalModifiedJulianDateText_MouseLeave(object sender, EventArgs e) => LabelChronologicalModifiedJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the Lilian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLilianDateText_MouseLeave(object sender, EventArgs e) => LabelLilianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the Rata Die label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelRataDieText_MouseLeave(object sender, EventArgs e) => LabelRataDieText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the Mars Sol date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMarsSolDateText_MouseLeave(object sender, EventArgs e) => LabelMarsSolDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the Unix time label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUnixtimeText_MouseLeave(object sender, EventArgs e) => LabelUnixtimeText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the UTC time label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUtcTime_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the MouseLeave event for the local time label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLocalTime_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the MouseLeave event for the Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the MouseLeave event for the modified Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelModifiedJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the MouseLeave event for the reduced Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelReducedJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the MouseLeave event for the truncated Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelTruncatedJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the MouseLeave event for the Dublin Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelDublinJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the MouseLeave event for the CNES Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCnesJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the MouseLeave event for the CCSDS Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCcsdsJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the MouseLeave event for the LOP Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLopJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the MouseLeave event for the Millennium Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMillenniumJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the MouseLeave event for the chronological Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the MouseLeave event for the chronological modified Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalModifiedJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the MouseLeave event for the Lilian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLilianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the MouseLeave event for the Rata Die label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelRataDie_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the MouseLeave event for the Mars Sol date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMarsSolDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the MouseLeave event for the Unix time label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUnixtime_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		#endregion

		#region KeyDown event handlers

		/// <summary>
		/// Handles the KeyDown event of the ExportDataSheetForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void JulianandhisdatesForm_KeyDown(object? sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		#endregion
	}
}