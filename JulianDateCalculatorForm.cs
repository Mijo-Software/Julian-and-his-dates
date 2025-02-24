using System.Diagnostics;
using System.Globalization;
using System.Media;
using Julian_and_his_dates.Properties;

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

		#region Helper Methods

		/// <summary>
		/// Returns a string that represents the current object for debugging purposes.
		/// </summary>
		/// <returns>A string that represents the current object.</returns>
		private string GetDebuggerDisplay() => ToString();

		/// <summary>
		/// Copies the specified text to the clipboard and shows a message box.
		/// </summary>
		/// <param name="strText">The text to copy to the clipboard.</param>
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
			if (checkBoxIgnoreDecimals.Checked)
			{
				labelJulianDate.Text = Math.Truncate(d: doubleJulianDate).ToString(provider: culture);
				labelModifiedJulianDate.Text = Math.Truncate(d: doubleModifiedJulianDate).ToString(provider: culture);
				labelReducedJulianDate.Text = Math.Truncate(d: doubleReducedJulianDate).ToString(provider: culture);
				labelTruncatedJulianDate.Text = Math.Truncate(d: doubleTruncatedJulianDate).ToString(provider: culture);
				labelDublinJulianDate.Text = Math.Truncate(d: doubleDublinJulianDate).ToString(provider: culture);
				labelCnesJulianDate.Text = Math.Truncate(d: doubleCnesJulianDate).ToString(provider: culture);
				labelCcsdsJulianDate.Text = Math.Truncate(d: doubleCcsdsJulianDate).ToString(provider: culture);
				labelLopJulianDate.Text = Math.Truncate(d: doubleLopJulianDate).ToString(provider: culture);
				labelMillenniumJulianDate.Text = Math.Truncate(d: doubleMillenniumJulianDate).ToString(provider: culture);
				labelChronologicalJulianDate.Text = Math.Truncate(d: doubleChronologicalJulianDate).ToString(provider: culture);
				labelChronologicalModifiedJulianDate.Text = Math.Truncate(d: doubleChronologicalModifiedJulianDate).ToString(provider: culture);
				labelLilianDate.Text = Math.Truncate(d: doubleLilianDate).ToString(provider: culture);
				labelRataDie.Text = Math.Truncate(d: doubleRataDie).ToString(provider: culture);
				labelMarsSolDate.Text = Math.Truncate(d: doubleMarsSolDate).ToString(provider: culture);
				labelUnixtime.Text = Math.Truncate(d: doubleUnixtime).ToString(provider: culture);
			}
			else
			{
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
		}

		#endregion

		#region Constructor

		/// <summary>
		/// Initialize the form.
		/// </summary>
		public JulianDateCalculatorForm()
		{
			InitializeComponent();
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

		#region Form Event Handlers

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void JulianDateCalculatorForm_Load(object sender, EventArgs e)
		{
			statusStrip.ForeColor = ForeColor;
			statusStrip.BackColor = BackColor;
		}

		#endregion

		#region Click Event Handlers

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUtcTimeText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strUtcTimeText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information,
			defaultButton: MessageBoxDefaultButton.Button1,
			options: MessageBoxOptions.DefaultDesktopOnly);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLocalTimeText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strLocalTimeText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information,
			defaultButton: MessageBoxDefaultButton.Button1,
			options: MessageBoxOptions.DefaultDesktopOnly);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information,
			defaultButton: MessageBoxDefaultButton.Button1,
			options: MessageBoxOptions.DefaultDesktopOnly);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelModifiedJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strModifiedJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information,
			defaultButton: MessageBoxDefaultButton.Button1,
			options: MessageBoxOptions.DefaultDesktopOnly);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelReducedJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strReducedJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information,
			defaultButton: MessageBoxDefaultButton.Button1,
			options: MessageBoxOptions.DefaultDesktopOnly);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelTruncatedJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strTruncatedJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information,
			defaultButton: MessageBoxDefaultButton.Button1,
			options: MessageBoxOptions.DefaultDesktopOnly);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDublinJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strDublinJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information,
			defaultButton: MessageBoxDefaultButton.Button1,
			options: MessageBoxOptions.DefaultDesktopOnly);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCnesJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strCnesJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information,
			defaultButton: MessageBoxDefaultButton.Button1,
			options: MessageBoxOptions.DefaultDesktopOnly);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCcsdsJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strCcsdsJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information,
			defaultButton: MessageBoxDefaultButton.Button1,
			options: MessageBoxOptions.DefaultDesktopOnly);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLopJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strLopJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information,
			defaultButton: MessageBoxDefaultButton.Button1,
			options: MessageBoxOptions.DefaultDesktopOnly);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMillenniumJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strMillenniumJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information,
			defaultButton: MessageBoxDefaultButton.Button1,
			options: MessageBoxOptions.DefaultDesktopOnly);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strChronologicalJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information,
			defaultButton: MessageBoxDefaultButton.Button1,
			options: MessageBoxOptions.DefaultDesktopOnly);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalModifiedJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strChronologicalModifiedJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information,
			defaultButton: MessageBoxDefaultButton.Button1,
			options: MessageBoxOptions.DefaultDesktopOnly);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLilianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strLilianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information,
			defaultButton: MessageBoxDefaultButton.Button1,
			options: MessageBoxOptions.DefaultDesktopOnly);

		private void LabelRataDieText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strRataDieText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information,
			defaultButton: MessageBoxDefaultButton.Button1,
			options: MessageBoxOptions.DefaultDesktopOnly);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMarsSolDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strMarsSolDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information,
			defaultButton: MessageBoxDefaultButton.Button1,
			options: MessageBoxOptions.DefaultDesktopOnly);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUnixtimeText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strUnixtimeText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information,
			defaultButton: MessageBoxDefaultButton.Button1,
			options: MessageBoxOptions.DefaultDesktopOnly);

		#endregion

		#region DoubleClick Event Handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUtcTime_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelUtcTime.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLocalTime_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelLocalTime.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelJulianDate.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelModifiedJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelModifiedJulianDate.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelReducedJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelReducedJulianDate.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelTruncatedJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelTruncatedJulianDate.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDublinJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelDublinJulianDate.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCnesJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelCnesJulianDate.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCcsdsJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelCcsdsJulianDate.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLopJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelLopJulianDate.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMillenniumJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelMillenniumJulianDate.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelChronologicalJulianDate.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalModifiedJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelChronologicalModifiedJulianDate.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLilianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelLilianDate.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRataDie_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelRataDie.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMarsSolDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelMarsSolDate.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUnixtime_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelUnixtime.Text);

		#endregion

		#region Enter Event Handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUtcTimeText_Enter(object sender, EventArgs e)
		{
			labelUtcTimeText.Cursor = Cursors.Hand;
			labelUtcTimeText.Font = new Font(prototype: labelUtcTimeText.Font, newStyle: FontStyle.Underline);
			SetStatusbar(text: labelUtcTimeText.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLocalTimeText_Enter(object sender, EventArgs e)
		{
			labelLocalTimeText.Cursor = Cursors.Hand;
			labelLocalTimeText.Font = new Font(prototype: labelLocalTimeText.Font, newStyle: FontStyle.Underline);
			SetStatusbar(text: labelLocalTimeText.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelJulianDateText_Enter(object sender, EventArgs e)
		{
			labelJulianDateText.Cursor = Cursors.Hand;
			labelJulianDateText.Font = new Font(prototype: labelJulianDateText.Font, newStyle: FontStyle.Underline);
			SetStatusbar(text: labelJulianDateText.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelModifiedJulianDateText_Enter(object sender, EventArgs e)
		{
			labelModifiedJulianDateText.Cursor = Cursors.Hand;
			labelModifiedJulianDateText.Font = new Font(
				prototype: labelModifiedJulianDateText.Font,
				newStyle: FontStyle.Underline);
			SetStatusbar(text: labelModifiedJulianDateText.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelReducedJulianDateText_Enter(object sender, EventArgs e)
		{
			labelReducedJulianDateText.Cursor = Cursors.Hand;
			labelReducedJulianDateText.Font = new Font(
				prototype: labelReducedJulianDateText.Font,
				newStyle: FontStyle.Underline);
			SetStatusbar(text: labelReducedJulianDateText.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelTruncatedJulianDateText_Enter(object sender, EventArgs e)
		{
			labelTruncatedJulianDateText.Cursor = Cursors.Hand;
			labelTruncatedJulianDateText.Font = new Font(
				prototype: labelTruncatedJulianDateText.Font,
				newStyle: FontStyle.Underline);
			SetStatusbar(text: labelTruncatedJulianDateText.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDublinJulianDateText_Enter(object sender, EventArgs e)
		{
			labelDublinJulianDateText.Cursor = Cursors.Hand;
			labelDublinJulianDateText.Font = new Font(
				prototype: labelDublinJulianDateText.Font,
				newStyle: FontStyle.Underline);
			SetStatusbar(text: labelDublinJulianDateText.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCnesJulianDateText_Enter(object sender, EventArgs e)
		{
			labelCnesJulianDateText.Cursor = Cursors.Hand;
			labelCnesJulianDateText.Font = new Font(
				prototype: labelCnesJulianDateText.Font,
				newStyle: FontStyle.Underline);
			SetStatusbar(text: labelCnesJulianDateText.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCcsdsJulianDateText_Enter(object sender, EventArgs e)
		{
			labelCcsdsJulianDateText.Cursor = Cursors.Hand;
			labelCcsdsJulianDateText.Font = new Font(
				prototype: labelCcsdsJulianDateText.Font,
				newStyle: FontStyle.Underline);
			SetStatusbar(text: labelCcsdsJulianDateText.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLopJulianDateText_Enter(object sender, EventArgs e)
		{
			labelLopJulianDateText.Cursor = Cursors.Hand;
			labelLopJulianDateText.Font = new Font(
				prototype: labelLopJulianDateText.Font,
				newStyle: FontStyle.Underline);
			SetStatusbar(text: labelLopJulianDateText.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMillenniumJulianDateText_Enter(object sender, EventArgs e)
		{
			labelMillenniumJulianDateText.Cursor = Cursors.Hand;
			labelMillenniumJulianDateText.Font = new Font(
				prototype: labelMillenniumJulianDateText.Font,
				newStyle: FontStyle.Underline);
			SetStatusbar(text: labelMillenniumJulianDateText.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalJulianDateText_Enter(object sender, EventArgs e)
		{
			labelChronologicalJulianDateText.Cursor = Cursors.Hand;
			labelChronologicalJulianDateText.Font = new Font(
				prototype: labelChronologicalJulianDateText.Font,
				newStyle: FontStyle.Underline);
			SetStatusbar(text: labelChronologicalJulianDateText.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalModifiedJulianDateText_Enter(object sender, EventArgs e)
		{
			labelChronologicalModifiedJulianDateText.Cursor = Cursors.Hand;
			labelChronologicalModifiedJulianDateText.Font = new Font(
				prototype: labelChronologicalModifiedJulianDateText.Font,
				newStyle: FontStyle.Underline);
			SetStatusbar(text: labelChronologicalModifiedJulianDateText.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLilianDateText_Enter(object sender, EventArgs e)
		{
			labelLilianDateText.Cursor = Cursors.Hand;
			labelLilianDateText.Font = new Font(prototype: labelLilianDateText.Font, newStyle: FontStyle.Underline);
			SetStatusbar(text: labelLilianDateText.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRataDieText_Enter(object sender, EventArgs e)
		{
			labelRataDieText.Cursor = Cursors.Hand;
			labelRataDieText.Font = new Font(prototype: labelRataDieText.Font, newStyle: FontStyle.Underline);
			SetStatusbar(text: labelRataDieText.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMarsSolDateText_Enter(object sender, EventArgs e)
		{
			labelMarsSolDateText.Cursor = Cursors.Hand;
			labelMarsSolDateText.Font = new Font(prototype: labelMarsSolDateText.Font, newStyle: FontStyle.Underline);
			SetStatusbar(text: labelMarsSolDateText.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUnixtimeText_Enter(object sender, EventArgs e)
		{
			labelUnixtimeText.Cursor = Cursors.Hand;
			labelUnixtimeText.Font = new Font(prototype: labelUnixtimeText.Font, newStyle: FontStyle.Underline);
			SetStatusbar(text: labelUnixtimeText.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUtcTime_Enter(object sender, EventArgs e) => SetStatusbar(text: labelUtcTime.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLocalTime_Enter(object sender, EventArgs e) => SetStatusbar(text: labelLocalTime.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelJulianDate_Enter(object sender, EventArgs e) => SetStatusbar(text: labelJulianDate.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelModifiedJulianDate_Enter(object sender, EventArgs e) => SetStatusbar(text: labelModifiedJulianDate.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelReducedJulianDate_Enter(object sender, EventArgs e) => SetStatusbar(text: labelReducedJulianDate.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelTruncatedJulianDate_Enter(object sender, EventArgs e) => SetStatusbar(text: labelTruncatedJulianDate.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDublinJulianDate_Enter(object sender, EventArgs e) => SetStatusbar(text: labelDublinJulianDate.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCnesJulianDate_Enter(object sender, EventArgs e) => SetStatusbar(text: labelCnesJulianDate.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCcsdsJulianDate_Enter(object sender, EventArgs e) => SetStatusbar(text: labelCcsdsJulianDate.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLopJulianDate_Enter(object sender, EventArgs e) => SetStatusbar(text: labelLopJulianDate.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMillenniumJulianDate_Enter(object sender, EventArgs e) => SetStatusbar(text: labelMillenniumJulianDate.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalJulianDate_Enter(object sender, EventArgs e) => SetStatusbar(text: labelChronologicalJulianDate.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalModifiedJulianDate_Enter(object sender, EventArgs e) => SetStatusbar(text: labelChronologicalModifiedJulianDate.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLilianDate_Enter(object sender, EventArgs e) => SetStatusbar(text: labelLilianDate.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRataDie_Enter(object sender, EventArgs e) => SetStatusbar(text: labelRataDie.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMarsSolDate_Enter(object sender, EventArgs e) => SetStatusbar(text: labelMarsSolDate.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUnixtime_Enter(object sender, EventArgs e) => SetStatusbar(text: labelUnixtime.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DateTimePicker_Enter(object sender, EventArgs e) => SetStatusbar(text: dateTimePicker.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckBoxIgnoreDecimals_Enter(object sender, EventArgs e) => SetStatusbar(
			text: checkBoxIgnoreDecimals.AccessibleDescription);

		#endregion

		#region Leave Event Handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUtcTimeText_Leave(object sender, EventArgs e)
		{
			labelUtcTimeText.Cursor = Cursors.Default;
			labelUtcTimeText.Font = new Font(prototype: labelUtcTimeText.Font, newStyle: FontStyle.Regular);
			ResetStatusbar();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLocalTimeText_Leave(object sender, EventArgs e)
		{
			labelLocalTimeText.Cursor = Cursors.Default;
			labelLocalTimeText.Font = new Font(prototype: labelLocalTimeText.Font, newStyle: FontStyle.Regular);
			ResetStatusbar();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelJulianDateText_Leave(object sender, EventArgs e)
		{
			labelJulianDateText.Cursor = Cursors.Default;
			labelJulianDateText.Font = new Font(prototype: labelJulianDateText.Font, newStyle: FontStyle.Regular);
			ResetStatusbar();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelModifiedJulianDateText_Leave(object sender, EventArgs e)
		{
			labelModifiedJulianDateText.Cursor = Cursors.Default;
			labelModifiedJulianDateText.Font = new Font(
				prototype: labelModifiedJulianDateText.Font,
				newStyle: FontStyle.Regular);
			ResetStatusbar();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelReducedJulianDateText_Leave(object sender, EventArgs e)
		{
			labelReducedJulianDateText.Cursor = Cursors.Default;
			labelReducedJulianDateText.Font = new Font(
				prototype: labelReducedJulianDateText.Font,
				newStyle: FontStyle.Regular);
			ResetStatusbar();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelTruncatedJulianDateText_Leave(object sender, EventArgs e)
		{
			labelTruncatedJulianDateText.Cursor = Cursors.Default;
			labelTruncatedJulianDateText.Font = new Font(
				prototype: labelTruncatedJulianDateText.Font,
				newStyle: FontStyle.Regular);
			ResetStatusbar();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDublinJulianDateText_Leave(object sender, EventArgs e)
		{
			labelDublinJulianDateText.Cursor = Cursors.Default;
			labelDublinJulianDateText.Font = new Font(
				prototype: labelDublinJulianDateText.Font,
				newStyle: FontStyle.Regular);
			ResetStatusbar();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCnesJulianDateText_Leave(object sender, EventArgs e)
		{
			labelCnesJulianDateText.Cursor = Cursors.Default;
			labelCnesJulianDateText.Font = new Font(
				prototype: labelCnesJulianDateText.Font,
				newStyle: FontStyle.Regular);
			ResetStatusbar();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCcsdsJulianDateText_Leave(object sender, EventArgs e)
		{
			labelCcsdsJulianDateText.Cursor = Cursors.Default;
			labelCcsdsJulianDateText.Font = new Font(
				prototype: labelCcsdsJulianDateText.Font,
				newStyle: FontStyle.Regular);
			ResetStatusbar();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLopJulianDateText_Leave(object sender, EventArgs e)
		{
			labelLopJulianDateText.Cursor = Cursors.Default;
			labelLopJulianDateText.Font = new Font(prototype: labelLopJulianDateText.Font, newStyle: FontStyle.Regular);
			ResetStatusbar();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMillenniumJulianDateText_Leave(object sender, EventArgs e)
		{
			labelMillenniumJulianDateText.Cursor = Cursors.Default;
			labelMillenniumJulianDateText.Font = new Font(
				prototype: labelMillenniumJulianDateText.Font,
				newStyle: FontStyle.Regular);
			ResetStatusbar();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalJulianDateText_Leave(object sender, EventArgs e)
		{
			labelChronologicalJulianDateText.Cursor = Cursors.Default;
			labelChronologicalJulianDateText.Font = new Font(
				prototype: labelChronologicalJulianDateText.Font,
				newStyle: FontStyle.Regular);
			ResetStatusbar();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalModifiedJulianDateText_Leave(object sender, EventArgs e)
		{
			labelChronologicalModifiedJulianDateText.Cursor = Cursors.Default;
			labelChronologicalModifiedJulianDateText.Font = new Font(
				prototype: labelChronologicalModifiedJulianDateText.Font,
				newStyle: FontStyle.Regular);
			ResetStatusbar();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLilianDateText_Leave(object sender, EventArgs e)
		{
			labelLilianDateText.Cursor = Cursors.Default;
			labelLilianDateText.Font = new Font(prototype: labelLilianDateText.Font, newStyle: FontStyle.Regular);
			ResetStatusbar();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRataDieText_Leave(object sender, EventArgs e)
		{
			labelRataDieText.Cursor = Cursors.Default;
			labelRataDieText.Font = new Font(prototype: labelRataDieText.Font, newStyle: FontStyle.Regular);
			ResetStatusbar();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMarsSolDateText_Leave(object sender, EventArgs e)
		{
			labelMarsSolDateText.Cursor = Cursors.Default;
			labelMarsSolDateText.Font = new Font(prototype: labelMarsSolDateText.Font, newStyle: FontStyle.Regular);
			ResetStatusbar();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUnixtimeText_Leave(object sender, EventArgs e)
		{
			labelUnixtimeText.Cursor = Cursors.Default;
			labelUnixtimeText.Font = new Font(prototype: labelUnixtimeText.Font, newStyle: FontStyle.Regular);
			ResetStatusbar();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUtcTime_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLocalTime_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelJulianDate_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelModifiedJulianDate_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelReducedJulianDate_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelTruncatedJulianDate_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDublinJulianDate_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCnesJulianDate_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCcsdsJulianDate_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLopJulianDate_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMillenniumJulianDate_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalJulianDate_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalModifiedJulianDate_Leave(object sender, EventArgs e) => ResetStatusbar();

		private void LabelLilianDate_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRataDie_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMarsSolDate_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUnixtime_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DateTimePicker_Leave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckBoxIgnoreDecimals_Leave(object sender, EventArgs e) => ResetStatusbar();

		#endregion

		#region MouseEnter Event Handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUtcTimeText_MouseEnter(object sender, EventArgs e) => LabelUtcTimeText_Enter(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLocalTimeText_MouseEnter(object sender, EventArgs e) => LabelLocalTimeText_Enter(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelJulianDateText_MouseEnter(object sender, EventArgs e) => LabelJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelModifiedJulianDateText_MouseEnter(object sender, EventArgs e) => LabelModifiedJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelReducedJulianDateText_MouseEnter(object sender, EventArgs e) => LabelReducedJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelTruncatedJulianDateText_MouseEnter(object sender, EventArgs e) => LabelTruncatedJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDublinJulianDateText_MouseEnter(object sender, EventArgs e) => LabelDublinJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCnesJulianDateText_MouseEnter(object sender, EventArgs e) => LabelCnesJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCcsdsJulianDateText_MouseEnter(object sender, EventArgs e) => LabelCcsdsJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLopJulianDateText_MouseEnter(object sender, EventArgs e) => LabelLopJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMillenniumJulianDateText_MouseEnter(object sender, EventArgs e) => LabelMillenniumJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalJulianDateText_MouseEnter(object sender, EventArgs e) => LabelChronologicalJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalModifiedJulianDateText_MouseEnter(object sender, EventArgs e) => LabelChronologicalModifiedJulianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLilianDateText_MouseEnter(object sender, EventArgs e) => LabelLilianDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRataDieText_MouseEnter(object sender, EventArgs e) => LabelRataDieText_Enter(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMarsSolDateText_MouseEnter(object sender, EventArgs e) => LabelMarsSolDateText_Enter(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUnixtimeText_MouseEnter(object sender, EventArgs e) => LabelUnixtimeText_Enter(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUtcTime_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelUtcTime.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLocalTime_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelLocalTime.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelJulianDate.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelModifiedJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelModifiedJulianDate.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelReducedJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelReducedJulianDate.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelTruncatedJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelTruncatedJulianDate.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDublinJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelDublinJulianDate.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCnesJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelCnesJulianDate.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCcsdsJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelCcsdsJulianDate.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLopJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelLopJulianDate.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMillenniumJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelMillenniumJulianDate.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelChronologicalJulianDate.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalModifiedJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelChronologicalModifiedJulianDate.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLilianDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelLilianDate.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRataDie_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelRataDie.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMarsSolDate_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelMarsSolDate.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUnixtime_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: labelUnixtime.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DateTimePicker_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: dateTimePicker.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckBoxIgnoreDecimals_MouseEnter(object sender, EventArgs e) => SetStatusbar(text: checkBoxIgnoreDecimals.AccessibleDescription);

		#endregion

		#region MouseLeave Event Handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUtcTimeText_MouseLeave(object sender, EventArgs e) => LabelUtcTimeText_Leave(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLocalTimeText_MouseLeave(object sender, EventArgs e) => LabelLocalTimeText_Leave(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelJulianDateText_MouseLeave(object sender, EventArgs e) => LabelJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelModifiedJulianDateText_MouseLeave(object sender, EventArgs e) => LabelModifiedJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelReducedJulianDateText_MouseLeave(object sender, EventArgs e) => LabelReducedJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelTruncatedJulianDateText_MouseLeave(object sender, EventArgs e) => LabelTruncatedJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDublinJulianDateText_MouseLeave(object sender, EventArgs e) => LabelDublinJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCnesJulianDateText_MouseLeave(object sender, EventArgs e) => LabelCnesJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCcsdsJulianDateText_MouseLeave(object sender, EventArgs e) => LabelCcsdsJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLopJulianDateText_MouseLeave(object sender, EventArgs e) => LabelLopJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMillenniumJulianDateText_MouseLeave(object sender, EventArgs e) => LabelMillenniumJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalJulianDateText_MouseLeave(object sender, EventArgs e) => LabelChronologicalJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalModifiedJulianDateText_MouseLeave(object sender, EventArgs e) => LabelChronologicalModifiedJulianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLilianDateText_MouseLeave(object sender, EventArgs e) => LabelLilianDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRataDieText_MouseLeave(object sender, EventArgs e) => LabelRataDieText_Leave(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMarsSolDateText_MouseLeave(object sender, EventArgs e) => LabelMarsSolDateText_Leave(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUnixtimeText_MouseLeave(object sender, EventArgs e) => LabelUnixtimeText_Leave(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUtcTime_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLocalTime_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelModifiedJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelReducedJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelTruncatedJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDublinJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCnesJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCcsdsJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DateTimePicker_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckBoxIgnoreDecimals_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLopJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMillenniumJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalModifiedJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLilianDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRataDie_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMarsSolDate_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUnixtime_MouseLeave(object sender, EventArgs e) => ResetStatusbar();

		#endregion

		#region ValueChanged Event Handlers

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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

		#region CheckedChanged Event Handlers

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckBoxIgnoreDecimals_CheckedChanged(object sender, EventArgs e) => CheckToTruncateDecimals();

		#endregion
	}
}
