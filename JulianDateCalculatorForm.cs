using System.Diagnostics;
using System.Globalization;
using System.Media;
using Julian_and_his_dates.Properties;
using NLog;

namespace Julian_and_his_dates
{
	/// <summary>
	/// Initialize the form.
	/// </summary>
	[DebuggerDisplay(value: $"{{{nameof(GetDebuggerDisplay)}(),nq}}")]

	public partial class JulianDateCalculatorForm : Form
	{
		/// <summary>
		/// JD dates
		/// </summary>
		private double
			doubleJulianDate,
			doubleModifiedJulianDate,
			doubleReducedJulianDate,
			doubleTruncatedJulianDate,
			doubleDublinJulianDate,
			doubleCnesJulianDate,
			doubleCcsdsJulianDate,
			doubleLopJulianDate,
			doubleMillenniumJulianDate,
			doubleLilianDate,
			doubleChronologicalJulianDate,
			doubleChronologicalModifiedJulianDate,
			doubleRataDie,
			doubleMarsSolDate,
			doubleUnixtime;

		/// <summary>
		/// culture info for the date
		/// </summary>
		private readonly CultureInfo culture = CultureInfo.CurrentUICulture;

		/// <summary>
		/// Logger instance for logging messages and exceptions.
		/// </summary>
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

		#region Helper Methods

		/// <summary>
		/// Returns a string that represents the current object for debugging purposes.
		/// </summary>
		/// <returns>A string that represents the current object.</returns>
		private string GetDebuggerDisplay() => ToString();

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
		/// Resets the label's cursor and font style, and resets the status bar text on Leave event.
		/// </summary>
		/// <param name="label">The label to update.</param>
		private void UpdateLabelOnLeave(Label label)
		{
			label.Cursor = Cursors.Default;
			label.Font = new Font(prototype: label.Font, newStyle: FontStyle.Regular);
			ResetStatusbar();
		}

		/// <summary>
		/// Shows a message box with the specified information text.
		/// </summary>
		/// <param name="text">The information text to display.</param>
		private static void ShowInfoMessage(string text)
		{
			_ = MessageBox.Show(
				text: text,
				caption: Resources.strInformation,
				buttons: MessageBoxButtons.OK,
				icon: MessageBoxIcon.Information,
				defaultButton: MessageBoxDefaultButton.Button1,
				options: MessageBoxOptions.DefaultDesktopOnly);
		}

		/// <summary>
		/// Copies the specified text to the clipboard and shows a message box.
		/// </summary>
		/// <param name="text">The text to copy to the clipboard.</param>
		private static void CopyToClipboard(string text)
		{
			Clipboard.SetText(text: text);
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
			toolStripStatusLabelTakeScreenshot.Visible = false;
		}

		/// <summary>
		/// Resets the status bar to its default state.
		/// </summary>
		private void ResetStatusbar()
		{
			toolStripStatusLabelInformation.Visible = false;
			toolStripStatusLabelInformation.Text = string.Empty;
			toolStripStatusLabelTakeScreenshot.Visible = true;
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
		/// Truncate Decimals
		/// </summary>
		private void CheckToTruncateDecimals()
		{
			bool truncate = checkBoxIgnoreDecimals.Checked;
			foreach ((Label label, double value) in new[]
			{
				(labelJulianDate, doubleJulianDate),
				(labelModifiedJulianDate, doubleModifiedJulianDate),
				(labelReducedJulianDate, doubleReducedJulianDate),
				(labelTruncatedJulianDate, doubleTruncatedJulianDate),
				(labelDublinJulianDate, doubleDublinJulianDate),
				(labelCnesJulianDate, doubleCnesJulianDate),
				(labelCcsdsJulianDate, doubleCcsdsJulianDate),
				(labelLopJulianDate, doubleLopJulianDate),
				(labelMillenniumJulianDate, doubleMillenniumJulianDate),
				(labelChronologicalJulianDate, doubleChronologicalJulianDate),
				(labelChronologicalModifiedJulianDate, doubleChronologicalModifiedJulianDate),
				(labelLilianDate, doubleLilianDate),
				(labelRataDie, doubleRataDie),
				(labelMarsSolDate, doubleMarsSolDate),
				(labelUnixtime, doubleUnixtime)})
			{
				label.Text = (truncate ? Math.Truncate(d: value) : value).ToString(provider: culture);
			}
		}

		#endregion

		#region Constructor

		/// <summary>
		/// Initialize the form.
		/// </summary>
		public JulianDateCalculatorForm()
		{
			InitializeComponent();
			Logger.Info(message: "JulianDateCalculatorForm initialized.");
			this.KeyDown += new KeyEventHandler(JulianDateCalculatorForm_KeyDown);
			this.KeyPreview = true; // Ensures the form receives key events before the controls
			doubleJulianDate = JulianDates.CalculateJulianDate();
			doubleModifiedJulianDate = JulianDates.CalculateModifiedJulianDate();
			doubleReducedJulianDate = JulianDates.CalculateReducedJulianDate();
			doubleTruncatedJulianDate = JulianDates.CalculateTruncatedJulianDate();
			doubleDublinJulianDate = JulianDates.CalculateDublinJulianDate();
			doubleCnesJulianDate = JulianDates.CalculateCnesJulianDate();
			doubleCcsdsJulianDate = JulianDates.CalculateCcsdsJulianDate();
			doubleLopJulianDate = JulianDates.CalculateLopJulianDate();
			doubleMillenniumJulianDate = JulianDates.CalculateMillenniumJulianDate();
			doubleChronologicalJulianDate = JulianDates.CalculateChronologicalJulianDate();
			doubleChronologicalModifiedJulianDate = JulianDates.CalculateChronologicalModifiedJulianDate();
			doubleLilianDate = JulianDates.CalculateLilianDate();
			doubleRataDie = JulianDates.CalculateRataDie();
			doubleMarsSolDate = JulianDates.CalculateMarsSolDate();
			doubleUnixtime = JulianDates.CalculateUnixTime();
			labelLocalTime.Text = DateTime.Now.ToString(provider: culture);
			labelUtcTime.Text = DateTime.UtcNow.ToString(provider: culture);
			labelJulianDate.Text = doubleJulianDate.ToString(provider: culture);
			labelModifiedJulianDate.Text = doubleModifiedJulianDate.ToString(provider: culture);
			labelReducedJulianDate.Text = doubleReducedJulianDate.ToString(provider: culture);
			labelTruncatedJulianDate.Text = doubleTruncatedJulianDate.ToString(provider: culture);
			labelDublinJulianDate.Text = doubleDublinJulianDate.ToString(provider: culture);
			labelCnesJulianDate.Text = doubleCnesJulianDate.ToString(provider: culture);
			labelCcsdsJulianDate.Text = doubleCcsdsJulianDate.ToString(provider: culture);
			labelLopJulianDate.Text = doubleLopJulianDate.ToString(provider: culture);
			labelMillenniumJulianDate.Text = doubleMillenniumJulianDate.ToString(provider: culture);
			labelChronologicalJulianDate.Text = doubleChronologicalJulianDate.ToString(provider: culture);
			labelChronologicalModifiedJulianDate.Text = doubleChronologicalModifiedJulianDate.ToString(provider: culture);
			labelLilianDate.Text = doubleLilianDate.ToString(provider: culture);
			labelRataDie.Text = doubleRataDie.ToString(provider: culture);
			labelMarsSolDate.Text = doubleMarsSolDate.ToString(provider: culture);
			labelUnixtime.Text = doubleUnixtime.ToString(provider: culture);
		}

		#endregion

		#region Form event handlers

		/// <summary>
		/// Handles the Load event for the JulianDateCalculatorForm.
		/// Sets the foreground and background colors of the status strip to match the form's colors.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void JulianDateCalculatorForm_Load(object sender, EventArgs e)
		{
			statusStrip.ForeColor = ForeColor;
			statusStrip.BackColor = BackColor;
		}

		#endregion

		#region Click event handlers

		/// <summary>
		/// Handles the Click event for the ToolStripStatusLabelTakeScreenshot.
		/// Plays a camera flash sound, takes a screenshot of the form, saves it to the user's Pictures folder,
		/// and shows a message box with the location of the saved screenshot.
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
				text: strInfotext + "\n\n" + ScreenToPicture(location: strPathToMyPictures + strFilenameWithExtension),
				caption: "Screenshot taken",
				buttons: MessageBoxButtons.OK,
				icon: MessageBoxIcon.Information,
				defaultButton: MessageBoxDefaultButton.Button1,
				options: MessageBoxOptions.DefaultDesktopOnly);
		}

		/// <summary>
		/// Handles the Click event for the UTC time label text.
		/// Shows a message box with information about UTC time.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUtcTimeText_Click(object sender, EventArgs e) => ShowInfoMessage(text: Resources.strUtcTimeText);

		/// <summary>
		/// Handles the Click event for the local time label text.
		/// Shows a message box with information about local time.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLocalTimeText_Click(object sender, EventArgs e) => ShowInfoMessage(text: Resources.strLocalTimeText);

		/// <summary>
		/// Handles the Click event for the Julian date label text.
		/// Shows a message box with information about Julian date.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelJulianDateText_Click(object sender, EventArgs e) => ShowInfoMessage(text: Resources.strJulianDateText);

		/// <summary>
		/// Handles the Click event for the modified Julian date label text.
		/// Shows a message box with information about modified Julian date.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelModifiedJulianDateText_Click(object sender, EventArgs e) => ShowInfoMessage(text: Resources.strModifiedJulianDateText);

		/// <summary>
		/// Handles the Click event for the reduced Julian date label text.
		/// Shows a message box with information about reduced Julian date.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelReducedJulianDateText_Click(object sender, EventArgs e) => ShowInfoMessage(text: Resources.strReducedJulianDateText);

		/// <summary>
		/// Handles the Click event for the truncated Julian date label text.
		/// Shows a message box with information about truncated Julian date.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelTruncatedJulianDateText_Click(object sender, EventArgs e) => ShowInfoMessage(text: Resources.strTruncatedJulianDateText);

		/// <summary>
		/// Handles the Click event for the Dublin Julian date label text.
		/// Shows a message box with information about Dublin Julian date.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelDublinJulianDateText_Click(object sender, EventArgs e) => ShowInfoMessage(text: Resources.strDublinJulianDateText);

		/// <summary>
		/// Handles the Click event for the CNES Julian date label text.
		/// Shows a message box with information about CNES Julian date.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCnesJulianDateText_Click(object sender, EventArgs e) => ShowInfoMessage(text: Resources.strCnesJulianDateText);

		/// <summary>
		/// Handles the Click event for the CCSDS Julian date label text.
		/// Shows a message box with information about CCSDS Julian date.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCcsdsJulianDateText_Click(object sender, EventArgs e) => ShowInfoMessage(text: Resources.strCcsdsJulianDateText);

		/// <summary>
		/// Handles the Click event for the LOP Julian date label text.
		/// Shows a message box with information about LOP Julian date.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLopJulianDateText_Click(object sender, EventArgs e) => ShowInfoMessage(text: Resources.strLopJulianDateText);

		/// <summary>
		/// Handles the Click event for the Millennium Julian date label text.
		/// Shows a message box with information about Millennium Julian date.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMillenniumJulianDateText_Click(object sender, EventArgs e) => ShowInfoMessage(text: Resources.strMillenniumJulianDateText);

		/// <summary>
		/// Handles the Click event for the chronological Julian date label text.
		/// Shows a message box with information about chronological Julian date.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalJulianDateText_Click(object sender, EventArgs e) => ShowInfoMessage(text: Resources.strChronologicalJulianDateText);

		/// <summary>
		/// Handles the Click event for the chronological modified Julian date label text.
		/// Shows a message box with information about chronological modified Julian date.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalModifiedJulianDateText_Click(object sender, EventArgs e) => ShowInfoMessage(text: Resources.strChronologicalModifiedJulianDateText);

		/// <summary>
		/// Handles the Click event for the Lilian date label text.
		/// Shows a message box with information about Lilian date.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLilianDateText_Click(object sender, EventArgs e) => ShowInfoMessage(text: Resources.strLilianDateText);

		/// <summary>
		/// Handles the Click event for the Rata Die label text.
		/// Shows a message box with information about Rata Die.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelRataDieText_Click(object sender, EventArgs e) => ShowInfoMessage(text: Resources.strRataDieText);

		/// <summary>
		/// Handles the Click event for the Mars Sol date label text.
		/// Shows a message box with information about Mars Sol date.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMarsSolDateText_Click(object sender, EventArgs e) => ShowInfoMessage(text: Resources.strMarsSolDateText);

		/// <summary>
		/// Handles the Click event for the Unix time label text.
		/// Shows a message box with information about Unix time.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUnixtimeText_Click(object sender, EventArgs e) => ShowInfoMessage(text: Resources.strUnixtimeText);

		#endregion

		#region DoubleClick event handlers

		/// <summary>
		/// Handles the DoubleClick event for the UTC time label.
		/// Copies the UTC time text to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUtcTime_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelUtcTime.Text);

		/// <summary>
		/// Handles the DoubleClick event for the local time label.
		/// Copies the local time text to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLocalTime_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelLocalTime.Text);

		/// <summary>
		/// Handles the DoubleClick event for the Julian date label.
		/// Copies the Julian date text to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelJulianDate.Text);

		/// <summary>
		/// Handles the DoubleClick event for the modified Julian date label.
		/// Copies the modified Julian date text to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelModifiedJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelModifiedJulianDate.Text);

		/// <summary>
		/// Handles the DoubleClick event for the reduced Julian date label.
		/// Copies the reduced Julian date text to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelReducedJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelReducedJulianDate.Text);

		/// <summary>
		/// Handles the DoubleClick event for the truncated Julian date label.
		/// Copies the truncated Julian date text to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelTruncatedJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelTruncatedJulianDate.Text);

		/// <summary>
		/// Handles the DoubleClick event for the Dublin Julian date label.
		/// Copies the Dublin Julian date text to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelDublinJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelDublinJulianDate.Text);

		/// <summary>
		/// Handles the DoubleClick event for the CNES Julian date label.
		/// Copies the CNES Julian date text to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCnesJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelCnesJulianDate.Text);

		/// <summary>
		/// Handles the DoubleClick event for the CCSDS Julian date label.
		/// Copies the CCSDS Julian date text to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCcsdsJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelCcsdsJulianDate.Text);

		/// <summary>
		/// Handles the DoubleClick event for the LOP Julian date label.
		/// Copies the LOP Julian date text to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLopJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelLopJulianDate.Text);

		/// <summary>
		/// Handles the DoubleClick event for the Millennium Julian date label.
		/// Copies the Millennium Julian date text to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMillenniumJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelMillenniumJulianDate.Text);

		/// <summary>
		/// Handles the DoubleClick event for the chronological Julian date label.
		/// Copies the chronological Julian date text to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelChronologicalJulianDate.Text);

		/// <summary>
		/// Handles the DoubleClick event for the chronological modified Julian date label.
		/// Copies the chronological modified Julian date text to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalModifiedJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelChronologicalModifiedJulianDate.Text);

		/// <summary>
		/// Handles the DoubleClick event for the Lilian date label.
		/// Copies the Lilian date text to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLilianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelLilianDate.Text);

		/// <summary>
		/// Handles the DoubleClick event for the Rata Die label.
		/// Copies the Rata Die text to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelRataDie_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelRataDie.Text);

		/// <summary>
		/// Handles the DoubleClick event for the Mars Sol date label.
		/// Copies the Mars Sol date text to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMarsSolDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelMarsSolDate.Text);

		/// <summary>
		/// Handles the DoubleClick event for the Unix time label.
		/// Copies the Unix time text to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUnixtime_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelUnixtime.Text);

		#endregion

		#region Enter event handlers

		/// <summary>
		/// Handles the Enter event for the UTC time label text.
		/// Changes the cursor and font style, and sets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUtcTimeText_Enter(object sender, EventArgs e) => UpdateLabelOnEnter(label: labelUtcTimeText);

		/// <summary>
		/// Handles the Enter event for the local time label text.
		/// Changes the cursor and font style, and sets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLocalTimeText_Enter(object sender, EventArgs e) => UpdateLabelOnEnter(label: labelLocalTimeText);

		/// <summary>
		/// Handles the Enter event for the Julian date label text.
		/// Changes the cursor and font style, and sets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelJulianDateText_Enter(object sender, EventArgs e) => UpdateLabelOnEnter(label: labelJulianDateText);

		/// <summary>
		/// Handles the Enter event for the modified Julian date label text.
		/// Changes the cursor and font style, and sets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelModifiedJulianDateText_Enter(object sender, EventArgs e) => UpdateLabelOnEnter(label: labelModifiedJulianDateText);

		/// <summary>
		/// Handles the Enter event for the reduced Julian date label text.
		/// Changes the cursor and font style, and sets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelReducedJulianDateText_Enter(object sender, EventArgs e) => UpdateLabelOnEnter(label: labelReducedJulianDateText);

		/// <summary>
		/// Handles the Enter event for the truncated Julian date label text.
		/// Changes the cursor and font style, and sets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelTruncatedJulianDateText_Enter(object sender, EventArgs e) => UpdateLabelOnEnter(label: labelTruncatedJulianDateText);

		/// <summary>
		/// Handles the Enter event for the Dublin Julian date label text.
		/// Changes the cursor and font style, and sets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelDublinJulianDateText_Enter(object sender, EventArgs e) => UpdateLabelOnEnter(label: labelDublinJulianDateText);

		/// <summary>
		/// Handles the Enter event for the CNES Julian date label text.
		/// Changes the cursor and font style, and sets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCnesJulianDateText_Enter(object sender, EventArgs e) => UpdateLabelOnEnter(label: labelCnesJulianDateText);

		/// <summary>
		/// Handles the Enter event for the CCSDS Julian date label text.
		/// Changes the cursor and font style, and sets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCcsdsJulianDateText_Enter(object sender, EventArgs e) => UpdateLabelOnEnter(label: labelCcsdsJulianDateText);

		/// <summary>
		/// Handles the Enter event for the LOP Julian date label text.
		/// Changes the cursor and font style, and sets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLopJulianDateText_Enter(object sender, EventArgs e) => UpdateLabelOnEnter(label: labelLopJulianDateText);

		/// <summary>
		/// Handles the Enter event for the Millennium Julian date label text.
		/// Changes the cursor and font style, and sets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMillenniumJulianDateText_Enter(object sender, EventArgs e) => UpdateLabelOnEnter(label: labelMillenniumJulianDateText);

		/// <summary>
		/// Handles the Enter event for the chronological Julian date label text.
		/// Changes the cursor and font style, and sets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalJulianDateText_Enter(object sender, EventArgs e) => UpdateLabelOnEnter(label: labelChronologicalJulianDateText);

		/// <summary>
		/// Handles the Enter event for the chronological modified Julian date label text.
		/// Changes the cursor and font style, and sets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalModifiedJulianDateText_Enter(object sender, EventArgs e) => UpdateLabelOnEnter(label: labelChronologicalModifiedJulianDateText);

		/// <summary>
		/// Handles the Enter event for the Lilian date label text.
		/// Changes the cursor and font style, and sets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLilianDateText_Enter(object sender, EventArgs e) => UpdateLabelOnEnter(label: labelLilianDateText);

		/// <summary>
		/// Handles the Enter event for the Rata Die label text.
		/// Changes the cursor and font style, and sets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelRataDieText_Enter(object sender, EventArgs e) => UpdateLabelOnEnter(label: labelRataDieText);

		/// <summary>
		/// Handles the Enter event for the Mars Sol date label text.
		/// Changes the cursor and font style, and sets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMarsSolDateText_Enter(object sender, EventArgs e) => UpdateLabelOnEnter(label: labelMarsSolDateText);

		/// <summary>
		/// Handles the Enter event for the Unix time label text.
		/// Changes the cursor and font style, and sets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUnixtimeText_Enter(object sender, EventArgs e) => UpdateLabelOnEnter(label: labelUnixtimeText);

		/// <summary>
		/// Handles the Enter event for the UTC time label.
		/// Sets the status bar text to the accessible description of the UTC time label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUtcTime_Enter(object sender, EventArgs e) => SetStatusbar(text: labelUtcTime.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the Enter event for the local time label.
		/// Sets the status bar text to the accessible description of the local time label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLocalTime_Enter(object sender, EventArgs e) => SetStatusbar(text: labelLocalTime.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the Enter event for the Julian date label.
		/// Sets the status bar text to the accessible description of the Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelJulianDate_Enter(object sender, EventArgs e) => SetStatusbar(text: labelJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the Enter event for the modified Julian date label.
		/// Sets the status bar text to the accessible description of the modified Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelModifiedJulianDate_Enter(object sender, EventArgs e) => SetStatusbar(text: labelModifiedJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the Enter event for the reduced Julian date label.
		/// Sets the status bar text to the accessible description of the reduced Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelReducedJulianDate_Enter(object sender, EventArgs e) => SetStatusbar(text: labelReducedJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the Enter event for the truncated Julian date label.
		/// Sets the status bar text to the accessible description of the truncated Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelTruncatedJulianDate_Enter(object sender, EventArgs e) => SetStatusbar(text: labelTruncatedJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the Enter event for the Dublin Julian date label.
		/// Sets the status bar text to the accessible description of the Dublin Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelDublinJulianDate_Enter(object sender, EventArgs e) => SetStatusbar(text: labelDublinJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the Enter event for the CNES Julian date label.
		/// Sets the status bar text to the accessible description of the CNES Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCnesJulianDate_Enter(object sender, EventArgs e) => SetStatusbar(text: labelCnesJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the Enter event for the CCSDS Julian date label.
		/// Sets the status bar text to the accessible description of the CCSDS Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCcsdsJulianDate_Enter(object sender, EventArgs e) => SetStatusbar(text: labelCcsdsJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the Enter event for the LOP Julian date label.
		/// Sets the status bar text to the accessible description of the LOP Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLopJulianDate_Enter(object sender, EventArgs e) => SetStatusbar(text: labelLopJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the Enter event for the Millennium Julian date label.
		/// Sets the status bar text to the accessible description of the Millennium Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMillenniumJulianDate_Enter(object sender, EventArgs e) => SetStatusbar(text: labelMillenniumJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the Enter event for the chronological Julian date label.
		/// Sets the status bar text to the accessible description of the chronological Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalJulianDate_Enter(object sender, EventArgs e) => SetStatusbar(text: labelChronologicalJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the Enter event for the chronological modified Julian date label.
		/// Sets the status bar text to the accessible description of the chronological modified Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalModifiedJulianDate_Enter(object sender, EventArgs e) => SetStatusbar(text: labelChronologicalModifiedJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the Enter event for the Lilian date label.
		/// Sets the status bar text to the accessible description of the Lilian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLilianDate_Enter(object sender, EventArgs e) => SetStatusbar(text: labelLilianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the Enter event for the Rata Die label.
		/// Sets the status bar text to the accessible description of the Rata Die label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelRataDie_Enter(object sender, EventArgs e) => SetStatusbar(text: labelRataDie.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the Enter event for the Mars Sol date label.
		/// Sets the status bar text to the accessible description of the Mars Sol date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMarsSolDate_Enter(object sender, EventArgs e) => SetStatusbar(text: labelMarsSolDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the Enter event for the Unix time label.
		/// Sets the status bar text to the accessible description of the Unix time label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUnixtime_Enter(object sender, EventArgs e) => SetStatusbar(text: labelUnixtime.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the Enter event for the DateTimePicker.
		/// Sets the status bar text to the accessible description of the DateTimePicker.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void DateTimePicker_Enter(object sender, EventArgs e) => SetStatusbar(text: dateTimePicker.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the Enter event for the CheckBoxIgnoreDecimals.
		/// Sets the status bar text to the accessible description of the CheckBoxIgnoreDecimals.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void CheckBoxIgnoreDecimals_Enter(object sender, EventArgs e) => SetStatusbar(text: checkBoxIgnoreDecimals.AccessibleDescription ?? string.Empty);

		#endregion

		#region Leave event handlers

		/// <summary>
		/// Handles the Leave event for the UTC time label text.
		/// Resets the label's cursor and font style, and resets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUtcTimeText_Leave(object sender, EventArgs e) => UpdateLabelOnLeave(label: labelUtcTimeText);

		/// <summary>
		/// Handles the Leave event for the local time label text.
		/// Resets the label's cursor and font style, and resets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLocalTimeText_Leave(object sender, EventArgs e) => UpdateLabelOnLeave(label: labelLocalTimeText);

		/// <summary>
		/// Handles the Leave event for the Julian date label text.
		/// Resets the label's cursor and font style, and resets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelJulianDateText_Leave(object sender, EventArgs e) => UpdateLabelOnLeave(label: labelJulianDateText);

		/// <summary>
		/// Handles the Leave event for the modified Julian date label text.
		/// Resets the label's cursor and font style, and resets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelModifiedJulianDateText_Leave(object sender, EventArgs e) => UpdateLabelOnLeave(label: labelModifiedJulianDateText);

		/// <summary>
		/// Handles the Leave event for the reduced Julian date label text.
		/// Resets the label's cursor and font style, and resets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelReducedJulianDateText_Leave(object sender, EventArgs e) => UpdateLabelOnLeave(label: labelReducedJulianDateText);

		/// <summary>
		/// Handles the Leave event for the truncated Julian date label text.
		/// Resets the label's cursor and font style, and resets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelTruncatedJulianDateText_Leave(object sender, EventArgs e) => UpdateLabelOnLeave(label: labelTruncatedJulianDateText);

		/// <summary>
		/// Handles the Leave event for the Dublin Julian date label text.
		/// Resets the label's cursor and font style, and resets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelDublinJulianDateText_Leave(object sender, EventArgs e) => UpdateLabelOnLeave(label: labelDublinJulianDateText);

		/// <summary>
		/// Handles the Leave event for the CNES Julian date label text.
		/// Resets the label's cursor and font style, and resets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCnesJulianDateText_Leave(object sender, EventArgs e) => UpdateLabelOnLeave(label: labelCnesJulianDateText);

		/// <summary>
		/// Handles the Leave event for the CCSDS Julian date label text.
		/// Resets the label's cursor and font style, and resets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCcsdsJulianDateText_Leave(object sender, EventArgs e) => UpdateLabelOnLeave(label: labelCcsdsJulianDateText);

		/// <summary>
		/// Handles the Leave event for the LOP Julian date label text.
		/// Resets the label's cursor and font style, and resets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLopJulianDateText_Leave(object sender, EventArgs e) => UpdateLabelOnLeave(label: labelLopJulianDateText);

		/// <summary>
		/// Handles the Leave event for the Millennium Julian date label text.
		/// Resets the label's cursor and font style, and resets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMillenniumJulianDateText_Leave(object sender, EventArgs e) => UpdateLabelOnLeave(label: labelMillenniumJulianDateText);

		/// <summary>
		/// Handles the Leave event for the chronological Julian date label text.
		/// Resets the label's cursor and font style, and resets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalJulianDateText_Leave(object sender, EventArgs e) => UpdateLabelOnLeave(label: labelChronologicalJulianDateText);

		/// <summary>
		/// Handles the Leave event for the chronological modified Julian date label text.
		/// Resets the label's cursor and font style, and resets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalModifiedJulianDateText_Leave(object sender, EventArgs e) => UpdateLabelOnLeave(label: labelChronologicalModifiedJulianDateText);

		/// <summary>
		/// Handles the Leave event for the Lilian date label text.
		/// Resets the label's cursor and font style, and resets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLilianDateText_Leave(object sender, EventArgs e) => UpdateLabelOnLeave(label: labelLilianDateText);

		/// <summary>
		/// Handles the Leave event for the Rata Die label text.
		/// Resets the label's cursor and font style, and resets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelRataDieText_Leave(object sender, EventArgs e) => UpdateLabelOnLeave(label: labelRataDieText);

		/// <summary>
		/// Handles the Leave event for the Mars Sol date label text.
		/// Resets the label's cursor and font style, and resets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMarsSolDateText_Leave(object sender, EventArgs e) => UpdateLabelOnLeave(label: labelMarsSolDateText);

		/// <summary>
		/// Handles the Leave event for the Unix time label text.
		/// Resets the label's cursor and font style, and resets the status bar text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUnixtimeText_Leave(object sender, EventArgs e) => UpdateLabelOnLeave(label: labelUnixtimeText);

		/// <summary>
		/// Handles the Leave event for the UTC time label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUtcTime_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the local time label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLocalTime_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the Julian date label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelJulianDate_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the modified Julian date label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelModifiedJulianDate_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the reduced Julian date label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelReducedJulianDate_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the truncated Julian date label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelTruncatedJulianDate_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the Dublin Julian date label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelDublinJulianDate_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the CNES Julian date label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCnesJulianDate_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the CCSDS Julian date label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCcsdsJulianDate_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the LOP Julian date label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLopJulianDate_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the Millennium Julian date label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMillenniumJulianDate_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the chronological Julian date label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalJulianDate_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the chronological modified Julian date label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalModifiedJulianDate_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the Lilian date label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLilianDate_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the Rata Die label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelRataDie_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the Mars Sol date label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMarsSolDate_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the Unix time label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUnixtime_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the DateTimePicker.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void DateTimePicker_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the CheckBoxIgnoreDecimals.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void CheckBoxIgnoreDecimals_Leave(object sender, EventArgs e) => ResetStatusbar();

		#endregion

		#region MouseEnter event handlers

		/// <summary>
		/// Handles the MouseEnter event for the UTC time label text.
		/// Calls the Enter event handler for the UTC time label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUtcTimeText_MouseEnter(object sender, EventArgs e) => LabelUtcTimeText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the local time label text.
		/// Calls the Enter event handler for the local time label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLocalTimeText_MouseEnter(object sender, EventArgs e) => LabelLocalTimeText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the Julian date label text.
		/// Calls the Enter event handler for the Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelJulianDateText_MouseEnter(object sender, EventArgs e) => LabelJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the modified Julian date label text.
		/// Calls the Enter event handler for the modified Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelModifiedJulianDateText_MouseEnter(object sender, EventArgs e) => LabelModifiedJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the reduced Julian date label text.
		/// Calls the Enter event handler for the reduced Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelReducedJulianDateText_MouseEnter(object sender, EventArgs e) => LabelReducedJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the truncated Julian date label text.
		/// Calls the Enter event handler for the truncated Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelTruncatedJulianDateText_MouseEnter(object sender, EventArgs e) => LabelTruncatedJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the Dublin Julian date label text.
		/// Calls the Enter event handler for the Dublin Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelDublinJulianDateText_MouseEnter(object sender, EventArgs e) => LabelDublinJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the CNES Julian date label text.
		/// Calls the Enter event handler for the CNES Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCnesJulianDateText_MouseEnter(object sender, EventArgs e) => LabelCnesJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the CCSDS Julian date label text.
		/// Calls the Enter event handler for the CCSDS Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCcsdsJulianDateText_MouseEnter(object sender, EventArgs e) => LabelCcsdsJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the LOP Julian date label text.
		/// Calls the Enter event handler for the LOP Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLopJulianDateText_MouseEnter(object sender, EventArgs e) => LabelLopJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the Millennium Julian date label text.
		/// Calls the Enter event handler for the Millennium Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMillenniumJulianDateText_MouseEnter(object sender, EventArgs e) => LabelMillenniumJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the chronological Julian date label text.
		/// Calls the Enter event handler for the chronological Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalJulianDateText_MouseEnter(object sender, EventArgs e) => LabelChronologicalJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the chronological modified Julian date label text.
		/// Calls the Enter event handler for the chronological modified Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalModifiedJulianDateText_MouseEnter(object sender, EventArgs e) => LabelChronologicalModifiedJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the Lilian date label text.
		/// Calls the Enter event handler for the Lilian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLilianDateText_MouseEnter(object sender, EventArgs e) => LabelLilianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the Rata Die label text.
		/// Calls the Enter event handler for the Rata Die label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelRataDieText_MouseEnter(object sender, EventArgs e) => LabelRataDieText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the Mars Sol date label text.
		/// Calls the Enter event handler for the Mars Sol date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMarsSolDateText_MouseEnter(object sender, EventArgs e) => LabelMarsSolDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the Unix time label text.
		/// Calls the Enter event handler for the Unix time label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUnixtimeText_MouseEnter(object sender, EventArgs e) => LabelUnixtimeText_Enter(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseEnter event for the UTC time label.
		/// Sets the status bar text to the accessible description of the UTC time label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUtcTime_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelUtcTime.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the local time label.
		/// Sets the status bar text to the accessible description of the local time label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLocalTime_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelLocalTime.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the Julian date label.
		/// Sets the status bar text to the accessible description of the Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the modified Julian date label.
		/// Sets the status bar text to the accessible description of the modified Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelModifiedJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelModifiedJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the reduced Julian date label.
		/// Sets the status bar text to the accessible description of the reduced Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelReducedJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelReducedJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the truncated Julian date label.
		/// Sets the status bar text to the accessible description of the truncated Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelTruncatedJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelTruncatedJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the Dublin Julian date label.
		/// Sets the status bar text to the accessible description of the Dublin Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelDublinJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelDublinJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the CNES Julian date label.
		/// Sets the status bar text to the accessible description of the CNES Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCnesJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelCnesJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the CCSDS Julian date label.
		/// Sets the status bar text to the accessible description of the CCSDS Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCcsdsJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelCcsdsJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the LOP Julian date label.
		/// Sets the status bar text to the accessible description of the LOP Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLopJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelLopJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the Millennium Julian date label.
		/// Sets the status bar text to the accessible description of the Millennium Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMillenniumJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelMillenniumJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the chronological Julian date label.
		/// Sets the status bar text to the accessible description of the chronological Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelChronologicalJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the chronological modified Julian date label.
		/// Sets the status bar text to the accessible description of the chronological modified Julian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalModifiedJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelChronologicalModifiedJulianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the Lilian date label.
		/// Sets the status bar text to the accessible description of the Lilian date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLilianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelLilianDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the Rata Die label.
		/// Sets the status bar text to the accessible description of the Rata Die label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelRataDie_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelRataDie.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the Mars Sol date label.
		/// Sets the status bar text to the accessible description of the Mars Sol date label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMarsSolDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelMarsSolDate.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the Unix time label.
		/// Sets the status bar text to the accessible description of the Unix time label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUnixtime_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelUnixtime.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the DateTimePicker.
		/// Sets the status bar text to the accessible description of the DateTimePicker.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void DateTimePicker_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: dateTimePicker.AccessibleDescription ?? string.Empty);

		/// <summary>
		/// Handles the MouseEnter event for the CheckBoxIgnoreDecimals.
		/// Sets the status bar text to the accessible description of the CheckBoxIgnoreDecimals.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void CheckBoxIgnoreDecimals_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: checkBoxIgnoreDecimals.AccessibleDescription ?? string.Empty);


		#endregion

		#region MouseLeave event handlers

		/// <summary>
		/// Handles the MouseLeave event for the UTC time label text.
		/// Calls the Leave event handler for the UTC time label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUtcTimeText_MouseLeave(object sender, EventArgs e) => LabelUtcTimeText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the local time label text.
		/// Calls the Leave event handler for the local time label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLocalTimeText_MouseLeave(object sender, EventArgs e) => LabelLocalTimeText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the Julian date label text.
		/// Calls the Leave event handler for the Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelJulianDateText_MouseLeave(object sender, EventArgs e) => LabelJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the modified Julian date label text.
		/// Calls the Leave event handler for the modified Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelModifiedJulianDateText_MouseLeave(object sender, EventArgs e) => LabelModifiedJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the reduced Julian date label text.
		/// Calls the Leave event handler for the reduced Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelReducedJulianDateText_MouseLeave(object sender, EventArgs e) => LabelReducedJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the truncated Julian date label text.
		/// Calls the Leave event handler for the truncated Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelTruncatedJulianDateText_MouseLeave(object sender, EventArgs e) => LabelTruncatedJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the Dublin Julian date label text.
		/// Calls the Leave event handler for the Dublin Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelDublinJulianDateText_MouseLeave(object sender, EventArgs e) => LabelDublinJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the CNES Julian date label text.
		/// Calls the Leave event handler for the CNES Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCnesJulianDateText_MouseLeave(object sender, EventArgs e) => LabelCnesJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the CCSDS Julian date label text.
		/// Calls the Leave event handler for the CCSDS Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCcsdsJulianDateText_MouseLeave(object sender, EventArgs e) => LabelCcsdsJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the LOP Julian date label text.
		/// Calls the Leave event handler for the LOP Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLopJulianDateText_MouseLeave(object sender, EventArgs e) => LabelLopJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the Millennium Julian date label text.
		/// Calls the Leave event handler for the Millennium Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMillenniumJulianDateText_MouseLeave(object sender, EventArgs e) => LabelMillenniumJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the chronological Julian date label text.
		/// Calls the Leave event handler for the chronological Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalJulianDateText_MouseLeave(object sender, EventArgs e) => LabelChronologicalJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the chronological modified Julian date label text.
		/// Calls the Leave event handler for the chronological modified Julian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalModifiedJulianDateText_MouseLeave(object sender, EventArgs e) => LabelChronologicalModifiedJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the Lilian date label text.
		/// Calls the Leave event handler for the Lilian date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLilianDateText_MouseLeave(object sender, EventArgs e) => LabelLilianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the Rata Die label text.
		/// Calls the Leave event handler for the Rata Die label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelRataDieText_MouseLeave(object sender, EventArgs e) => LabelRataDieText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the Mars Sol date label text.
		/// Calls the Leave event handler for the Mars Sol date label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMarsSolDateText_MouseLeave(object sender, EventArgs e) => LabelMarsSolDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the MouseLeave event for the Unix time label text.
		/// Calls the Leave event handler for the Unix time label text.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUnixtimeText_MouseLeave(object sender, EventArgs e) => LabelUnixtimeText_Leave(sender: sender, e: e);

		/// <summary>
		/// Handles the Leave event for the UTC time label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUtcTime_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the local time label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLocalTime_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the Julian date label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the modified Julian date label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelModifiedJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the reduced Julian date label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelReducedJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the truncated Julian date label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelTruncatedJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the Dublin Julian date label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelDublinJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the CNES Julian date label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCnesJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the CCSDS Julian date label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelCcsdsJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the LOP Julian date label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLopJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the Millennium Julian date label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMillenniumJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the chronological Julian date label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the chronological modified Julian date label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelChronologicalModifiedJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the Lilian date label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelLilianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the Rata Die label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelRataDie_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the Mars Sol date label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelMarsSolDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the Unix time label.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void LabelUnixtime_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the DateTime picker.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void DateTimePicker_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// Handles the Leave event for the IngoreDecimals checkbox.
		/// Resets the status bar to its default state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void CheckBoxIgnoreDecimals_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		#endregion

		#region ValueChanged event handlers

		/// <summary>
		/// Handles the ValueChanged event for the DateTimePicker.
		/// Updates the various date labels based on the selected date.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void DateTimePicker_ValueChanged(object sender, EventArgs e)
		{
			DateTime value = dateTimePicker.Value;
			labelUtcTime.Text = value.ToUniversalTime().ToString(provider: culture);
			labelLocalTime.Text = value.ToLocalTime().ToString(provider: culture);
			doubleJulianDate = JulianDates.CalculateJulianDate(date: value);
			doubleModifiedJulianDate = JulianDates.CalculateModifiedJulianDate(date: value);
			doubleReducedJulianDate = JulianDates.CalculateReducedJulianDate(date: value);
			doubleTruncatedJulianDate = JulianDates.CalculateTruncatedJulianDate(date: value);
			doubleDublinJulianDate = JulianDates.CalculateDublinJulianDate(date: value);
			doubleCnesJulianDate = JulianDates.CalculateCnesJulianDate(date: value);
			doubleCcsdsJulianDate = JulianDates.CalculateCcsdsJulianDate(date: value);
			doubleLopJulianDate = JulianDates.CalculateLopJulianDate(date: value);
			doubleMillenniumJulianDate = JulianDates.CalculateMillenniumJulianDate(date: value);
			doubleChronologicalJulianDate = JulianDates.CalculateChronologicalJulianDate(date: value);
			doubleChronologicalModifiedJulianDate = JulianDates.CalculateChronologicalModifiedJulianDate(date: value);
			doubleLilianDate = JulianDates.CalculateLilianDate(date: value);
			doubleRataDie = JulianDates.CalculateRataDie(date: value);
			doubleMarsSolDate = JulianDates.CalculateMarsSolDate(date: value);
			doubleUnixtime = JulianDates.CalculateUnixTime(date: value);
			CheckToTruncateDecimals();
		}

		#endregion

		#region CheckedChanged event handlers

		/// <summary>
		/// Handles the CheckedChanged event for the CheckBoxIgnoreDecimals.
		/// Truncates the decimal values of the Julian dates if the checkbox is checked.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void CheckBoxIgnoreDecimals_CheckedChanged(object sender, EventArgs e) => CheckToTruncateDecimals();

		#endregion

		#region KeyDown event handlers

		/// <summary>
		/// Handles the KeyDown event of the ExportDataSheetForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void JulianDateCalculatorForm_KeyDown(object? sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		#endregion
	}
}
