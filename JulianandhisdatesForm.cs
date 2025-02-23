using System.Globalization;
using System.Media;
using Julian_and_his_dates.Properties;

namespace Julian_and_his_dates
{
	/// <summary>
	/// Initialize the form
	/// </summary>
	public partial class JulianandhisdatesForm : Form
	{
		/// <summary>
		/// 
		/// </summary>
		private double doubleOldJD = 0.999999999999999999999999;

		/// <summary>
		/// 
		/// </summary>
		private double doubleNewJD;

		/// <summary>
		/// 
		/// </summary>
		private bool boolFirstRun = true;

		/// <summary>
		/// 
		/// </summary>
		private bool boolIsAlarmEnabled = true;

		/// <summary>
		/// 
		/// </summary>
		private readonly int intDefaultTick = 20;

		/// <summary>
		/// 
		/// </summary>
		private readonly Color colorWhiteFont = Color.WhiteSmoke;

		/// <summary>
		/// 
		/// </summary>
		private readonly Color colorDarkBackground = Color.FromArgb(red: 29, green: 32, blue: 41);

		/// <summary>
		/// culture info for the date
		/// </summary>
		private readonly CultureInfo culture = CultureInfo.CurrentUICulture;

		/// <summary>
		/// Initialize the form.
		/// </summary>
		public JulianandhisdatesForm() => InitializeComponent();

		private static Settings GetDefault() => Settings.Default;

		/// <summary>
		/// 
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
			labelChronologicalJulianDate.Text = JulianDates.CalculateChronologicalJulianDate()
				.ToString(provider: culture);
			labelChronologicalModifiedJulianDate.Text = JulianDates.CalculateChronologicalModifiedJulianDate()
				.ToString(provider: culture);
			labelLilianDate.Text = JulianDates.CalculateLilianDate().ToString(provider: culture);
			labelRataDie.Text = JulianDates.CalculateRataDie().ToString(provider: culture);
			labelMarsSolDate.Text = JulianDates.CalculateMarsSolDate().ToString(provider: culture);
			labelUnixtime.Text = JulianDates.CalculateUnixTime().ToString(provider: culture);
		}

		/// <summary>
		/// Saves an image of the screen to the specified path.
		/// </summary>
		/// <param name="location">Path, where output file will be saved at.</param>
		/// <returns>Path of the successfully saved image or error message</returns>
		public string ScreenToPicture(string location)
		{
			try
			{
				using (Bitmap screenToBitmap = new(width: Size.Width, height: Size.Height))
				{
					using (Graphics gGraphics = Graphics.FromImage(image: screenToBitmap))
					{
						Size currentScreenSize = new(width: Size.Width, height: Size.Height);
						gGraphics.CopyFromScreen(
							upperLeftSource: Location,
							upperLeftDestination: new Point(x: 0, y: 0),
							blockRegionSize: currentScreenSize);
					}
					screenToBitmap.Save(filename: location);
				}
				return location;
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void JulianandhisdatesForm_Load(object sender, EventArgs e)
		{
			BackColor = GetDefault().BackgroundColor;
			ForeColor = GetDefault().ForegroundColor;
			labelUtcTimeText.ForeColor = GetDefault().ForegroundColor;
			labelLocalTimeText.ForeColor = GetDefault().ForegroundColor;
			labelJulianDateText.ForeColor = GetDefault().ForegroundColor;
			labelModifiedJulianDateText.ForeColor = GetDefault().ForegroundColor;
			labelReducedJulianDateText.ForeColor = GetDefault().ForegroundColor;
			labelTruncatedJulianDateText.ForeColor = GetDefault().ForegroundColor;
			labelDublinJulianDateText.ForeColor = GetDefault().ForegroundColor;
			labelCnesJulianDateText.ForeColor = GetDefault().ForegroundColor;
			labelCcsdsJulianDateText.ForeColor = GetDefault().ForegroundColor;
			labelLopJulianDateText.ForeColor = GetDefault().ForegroundColor;
			labelMillenniumJulianDateText.ForeColor = GetDefault().ForegroundColor;
			labelChronologicalJulianDateText.ForeColor = GetDefault().ForegroundColor;
			labelChronologicalModifiedJulianDateText.ForeColor = GetDefault().ForegroundColor;
			labelLilianDateText.ForeColor = GetDefault().ForegroundColor;
			labelRataDieText.ForeColor = GetDefault().ForegroundColor;
			labelMarsSolDateText.ForeColor = GetDefault().ForegroundColor;
			labelUnixtimeText.ForeColor = GetDefault().ForegroundColor;
			labelUtcTime.ForeColor = GetDefault().ForegroundColor;
			labelLocalTime.ForeColor = GetDefault().ForegroundColor;
			labelJulianDate.ForeColor = GetDefault().ForegroundColor;
			labelModifiedJulianDate.ForeColor = GetDefault().ForegroundColor;
			labelReducedJulianDate.ForeColor = GetDefault().ForegroundColor;
			labelTruncatedJulianDate.ForeColor = GetDefault().ForegroundColor;
			labelDublinJulianDate.ForeColor = GetDefault().ForegroundColor;
			labelCnesJulianDate.ForeColor = GetDefault().ForegroundColor;
			labelCcsdsJulianDate.ForeColor = GetDefault().ForegroundColor;
			labelLopJulianDate.ForeColor = GetDefault().ForegroundColor;
			labelMillenniumJulianDate.ForeColor = GetDefault().ForegroundColor;
			labelChronologicalJulianDate.ForeColor = GetDefault().ForegroundColor;
			labelChronologicalModifiedJulianDate.ForeColor = GetDefault().ForegroundColor;
			labelLilianDate.ForeColor = GetDefault().ForegroundColor;
			labelRataDie.ForeColor = GetDefault().ForegroundColor;
			labelMarsSolDate.ForeColor = GetDefault().ForegroundColor;
			labelUnixtime.ForeColor = GetDefault().ForegroundColor;
			labelRefreshRateText.ForeColor = GetDefault().ForegroundColor;
			timer.Interval = GetDefault().userTicks;
			checkBoxDarkLightMode.Checked = GetDefault().isDarkmodeEnabled;
			checkBoxAutomaticRefresh.Checked = GetDefault().isAutomaticRefreshing;
			checkBoxStayOnTop.Checked = GetDefault().isStayOnTop;
			if (checkBoxStayOnTop.Checked)
			{
				checkBoxStayOnTop.Text = Resources.strApplicationNotOnTop;
				TopMost = true;
			}
			else
			{
				checkBoxStayOnTop.Text = Resources.strApplicationOnTop;
				TopMost = false;
			}
			numericUpDownRefreshRate.Value = timer.Interval;
			boolIsAlarmEnabled = GetDefault().isAlarmEnabled;
			if (boolIsAlarmEnabled)
			{
				boolIsAlarmEnabled = true;
				toolStripStatusLabelAlarm.Image = Resources.sound;
				toolStripStatusLabelAlarm.Text = Resources.strAlarmOn;
			}
			else
			{
				boolIsAlarmEnabled = false;
				toolStripStatusLabelAlarm.Image = Resources.sound_mute;
				toolStripStatusLabelAlarm.Text = Resources.strAlarmOff;
			}
			UpdateDateInformations();
		}

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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

		/// <summary>
		///
		/// </summary>
		/// <param name="strText"></param>
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
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonRefresh_Click(object sender, EventArgs e) => UpdateDateInformations();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonInfo_Click(object sender, EventArgs e)
		{
			bool boolMainWindowWasOnTop = false;
			if (TopMost)
			{
				TopMost = false;
				boolMainWindowWasOnTop = true;
			}
			using (AboutBoxForm about = new())
			{
				if (checkBoxDarkLightMode.Checked)
				{
					about.BackColor = colorDarkBackground;
					about.ForeColor = colorWhiteFont;
				}
				_ = about.ShowDialog();
			}
			if (boolMainWindowWasOnTop)
			{
				TopMost = true;
			}
		}

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonMinimizeToTray_Click(object sender, EventArgs e)
		{
			Hide();
			notifyIcon.Visible = true;
			notifyIcon.BalloonTipText = Resources.strApplicationMinimizedText;
			notifyIcon.BalloonTipTitle = Resources.strApplicationMinimizedTitle;
			notifyIcon.ShowBalloonTip(timeout: 500);
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
			icon: MessageBoxIcon.Information);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLocalTimeText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strLocalTimeText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelModifiedJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strModifiedJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelReducedJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strReducedJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelTruncatedJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strTruncatedJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDublinJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strDublinJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCnesJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strCnesJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCcsdsJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strCcsdsJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLopJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strLopJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMillenniumJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strMillenniumJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strChronologicalJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalModifiedJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strChronologicalModifiedJulianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLilianDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strLilianDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRataDieText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strRataDieText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMarsSolDateText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strMarsSolDateText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUnixtimeText_Click(object sender, EventArgs e) => MessageBox.Show(
			text: Resources.strUnixtimeText,
			caption: Resources.strInformation,
			buttons: MessageBoxButtons.OK,
			icon: MessageBoxIcon.Information);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUtcTime_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelUtcTime.Text);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLocalTime_DoubleClick(object sender, EventArgs e) => CopyToClipboard(
			strText: labelLocalTime.Text);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(
			strText: labelJulianDate.Text);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelModifiedJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(
			strText: labelModifiedJulianDate.Text);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelReducedJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(
			strText: labelReducedJulianDate.Text);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelTruncatedJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(
			strText: labelTruncatedJulianDate.Text);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDublinJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(
			strText: labelDublinJulianDate.Text);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCnesJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(
			strText: labelCnesJulianDate.Text);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCcsdsJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(
			strText: labelCcsdsJulianDate.Text);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLopJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(
			strText: labelLopJulianDate.Text);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMillenniumJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(
			strText: labelMillenniumJulianDate.Text);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(
			strText: labelChronologicalJulianDate.Text);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalModifiedJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(
			strText: labelChronologicalModifiedJulianDate.Text);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLilianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(
			strText: labelLilianDate.Text);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRataDie_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelRataDie.Text);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMarsSolDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(
			strText: labelMarsSolDate.Text);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUnixtime_DoubleClick(object sender, EventArgs e) => CopyToClipboard(
			strText: labelUnixtime.Text);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Show();
			notifyIcon.BalloonTipText = Resources.strApplicationMaximizedText;
			notifyIcon.BalloonTipTitle = Resources.strApplicationMaximizedTitle;
			notifyIcon.ShowBalloonTip(timeout: 500);
			notifyIcon.Visible = false;
		}

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckBoxAutomaticRefresh_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxAutomaticRefresh.Checked)
			{
				buttonRefresh.Enabled = false;
				timer.Enabled = true;
			}
			else
			{
				buttonRefresh.Enabled = true;
				timer.Enabled = false;
			}
		}

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckBoxStayOnTop_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxStayOnTop.Checked)
			{
				checkBoxStayOnTop.Text = Resources.strApplicationNotOnTop;
				TopMost = true;
			}
			else
			{
				checkBoxStayOnTop.Text = Resources.strApplicationOnTop;
				TopMost = false;
			}
		}

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckBoxDarkLightMode_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxDarkLightMode.Checked)
			{ // Enable dark mode
				checkBoxDarkLightMode.Text = "&Light Mode";
				BackColor = colorDarkBackground;
				ForeColor = colorWhiteFont;
				statusStrip.BackColor = colorDarkBackground;
				labelUtcTimeText.ForeColor = colorWhiteFont;
				labelLocalTimeText.ForeColor = colorWhiteFont;
				labelJulianDateText.ForeColor = colorWhiteFont;
				labelModifiedJulianDateText.ForeColor = colorWhiteFont;
				labelReducedJulianDateText.ForeColor = colorWhiteFont;
				labelTruncatedJulianDateText.ForeColor = colorWhiteFont;
				labelDublinJulianDateText.ForeColor = colorWhiteFont;
				labelCnesJulianDateText.ForeColor = colorWhiteFont;
				labelCcsdsJulianDateText.ForeColor = colorWhiteFont;
				labelLopJulianDateText.ForeColor = colorWhiteFont;
				labelMillenniumJulianDateText.ForeColor = colorWhiteFont;
				labelChronologicalJulianDateText.ForeColor = colorWhiteFont;
				labelChronologicalModifiedJulianDateText.ForeColor = colorWhiteFont;
				labelLilianDateText.ForeColor = colorWhiteFont;
				labelRataDieText.ForeColor = colorWhiteFont;
				labelMarsSolDateText.ForeColor = colorWhiteFont;
				labelUnixtimeText.ForeColor = colorWhiteFont;
				labelUtcTime.ForeColor = colorWhiteFont;
				labelLocalTime.ForeColor = colorWhiteFont;
				labelJulianDate.ForeColor = colorWhiteFont;
				labelModifiedJulianDate.ForeColor = colorWhiteFont;
				labelReducedJulianDate.ForeColor = colorWhiteFont;
				labelTruncatedJulianDate.ForeColor = colorWhiteFont;
				labelDublinJulianDate.ForeColor = colorWhiteFont;
				labelCnesJulianDate.ForeColor = colorWhiteFont;
				labelCcsdsJulianDate.ForeColor = colorWhiteFont;
				labelLopJulianDate.ForeColor = colorWhiteFont;
				labelMillenniumJulianDate.ForeColor = colorWhiteFont;
				labelChronologicalJulianDate.ForeColor = colorWhiteFont;
				labelChronologicalModifiedJulianDate.ForeColor = colorWhiteFont;
				labelLilianDate.ForeColor = colorWhiteFont;
				labelRataDie.ForeColor = colorWhiteFont;
				labelMarsSolDate.ForeColor = colorWhiteFont;
				labelUnixtime.ForeColor = colorWhiteFont;
				labelRefreshRateText.ForeColor = colorWhiteFont;
				statusStrip.ForeColor = colorWhiteFont;
				numericUpDownRefreshRate.BackColor = colorDarkBackground;
				numericUpDownRefreshRate.ForeColor = colorWhiteFont;
				checkBoxAutomaticRefresh.BackColor = colorDarkBackground;
				checkBoxAutomaticRefresh.ForeColor = colorWhiteFont;
				checkBoxStayOnTop.BackColor = colorDarkBackground;
				checkBoxStayOnTop.ForeColor = colorWhiteFont;
				checkBoxDarkLightMode.BackColor = colorDarkBackground;
				checkBoxDarkLightMode.ForeColor = colorWhiteFont;
				buttonMinimizeToTray.BackColor = colorDarkBackground;
				buttonMinimizeToTray.ForeColor = colorWhiteFont;
				buttonInfo.BackColor = colorDarkBackground;
				buttonInfo.ForeColor = colorWhiteFont;
				buttonRefresh.BackColor = colorDarkBackground;
				buttonRefresh.ForeColor = colorWhiteFont;
				buttonOpenJulianDateCalculator.BackColor = colorDarkBackground;
				buttonOpenJulianDateCalculator.ForeColor = colorWhiteFont;
				buttonOpenJulianDateConverter.BackColor = colorDarkBackground;
				buttonOpenJulianDateConverter.ForeColor = colorWhiteFont;
			}
			else
			{ //Enable light mode
				checkBoxDarkLightMode.Text = "&Dark Mode";
				BackColor = SystemColors.Control;
				ForeColor = SystemColors.ControlText;
				statusStrip.BackColor = SystemColors.Control;
				labelUtcTimeText.ForeColor = SystemColors.ControlText;
				labelLocalTimeText.ForeColor = SystemColors.ControlText;
				labelJulianDateText.ForeColor = SystemColors.ControlText;
				labelModifiedJulianDateText.ForeColor = SystemColors.ControlText;
				labelReducedJulianDateText.ForeColor = SystemColors.ControlText;
				labelTruncatedJulianDateText.ForeColor = SystemColors.ControlText;
				labelDublinJulianDateText.ForeColor = SystemColors.ControlText;
				labelCnesJulianDateText.ForeColor = SystemColors.ControlText;
				labelCcsdsJulianDateText.ForeColor = SystemColors.ControlText;
				labelLopJulianDateText.ForeColor = SystemColors.ControlText;
				labelMillenniumJulianDateText.ForeColor = SystemColors.ControlText;
				labelChronologicalJulianDateText.ForeColor = SystemColors.ControlText;
				labelChronologicalModifiedJulianDateText.ForeColor = SystemColors.ControlText;
				labelLilianDateText.ForeColor = SystemColors.ControlText;
				labelRataDieText.ForeColor = SystemColors.ControlText;
				labelMarsSolDateText.ForeColor = SystemColors.ControlText;
				labelUnixtimeText.ForeColor = SystemColors.ControlText;
				labelUtcTime.ForeColor = SystemColors.ControlText;
				labelLocalTime.ForeColor = SystemColors.ControlText;
				labelJulianDate.ForeColor = SystemColors.ControlText;
				labelModifiedJulianDate.ForeColor = SystemColors.ControlText;
				labelReducedJulianDate.ForeColor = SystemColors.ControlText;
				labelTruncatedJulianDate.ForeColor = SystemColors.ControlText;
				labelDublinJulianDate.ForeColor = SystemColors.ControlText;
				labelCnesJulianDate.ForeColor = SystemColors.ControlText;
				labelCcsdsJulianDate.ForeColor = SystemColors.ControlText;
				labelLopJulianDate.ForeColor = SystemColors.ControlText;
				labelMillenniumJulianDate.ForeColor = SystemColors.ControlText;
				labelChronologicalJulianDate.ForeColor = SystemColors.ControlText;
				labelChronologicalModifiedJulianDate.ForeColor = SystemColors.ControlText;
				labelLilianDate.ForeColor = SystemColors.ControlText;
				labelRataDie.ForeColor = SystemColors.ControlText;
				labelMarsSolDate.ForeColor = SystemColors.ControlText;
				labelUnixtime.ForeColor = SystemColors.ControlText;
				labelRefreshRateText.ForeColor = SystemColors.ControlText;
				statusStrip.ForeColor = SystemColors.ControlText;
				numericUpDownRefreshRate.BackColor = SystemColors.Window;
				numericUpDownRefreshRate.ForeColor = SystemColors.ControlText;
				checkBoxAutomaticRefresh.BackColor = SystemColors.Control;
				checkBoxAutomaticRefresh.ForeColor = SystemColors.ControlText;
				checkBoxStayOnTop.BackColor = SystemColors.Control;
				checkBoxStayOnTop.ForeColor = SystemColors.ControlText;
				checkBoxDarkLightMode.BackColor = SystemColors.Control;
				checkBoxDarkLightMode.ForeColor = SystemColors.ControlText;
				buttonMinimizeToTray.BackColor = SystemColors.Control;
				buttonMinimizeToTray.ForeColor = SystemColors.ControlText;
				buttonInfo.BackColor = SystemColors.Control;
				buttonInfo.ForeColor = SystemColors.ControlText;
				buttonRefresh.BackColor = SystemColors.Control;
				buttonRefresh.ForeColor = SystemColors.ControlText;
				buttonOpenJulianDateCalculator.BackColor = SystemColors.Control;
				buttonOpenJulianDateCalculator.ForeColor = SystemColors.ControlText;
				buttonOpenJulianDateConverter.BackColor = SystemColors.Control;
				buttonOpenJulianDateConverter.ForeColor = SystemColors.ControlText;
				checkBoxAutomaticRefresh.FlatAppearance.BorderColor = SystemColors.Control;
				checkBoxStayOnTop.FlatAppearance.BorderColor = SystemColors.Control;
				checkBoxDarkLightMode.FlatAppearance.BorderColor = SystemColors.Control;
				buttonMinimizeToTray.FlatAppearance.BorderColor = SystemColors.Control;
				buttonInfo.FlatAppearance.BorderColor = SystemColors.Control;
				buttonRefresh.FlatAppearance.BorderColor = SystemColors.Control;
				buttonOpenJulianDateCalculator.FlatAppearance.BorderColor = SystemColors.Control;
				buttonOpenJulianDateConverter.FlatAppearance.BorderColor = SystemColors.Control;
			}
			if (!boolFirstRun)
			{
				using SoundPlayer sound = new(stream: Resources.wavBlop);
				sound.Play();
			}
		}

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonOpenJulianDateCalculator_Click(object sender, EventArgs e)
		{
			bool boolMainWindowWasOnTop = false;
			if (TopMost)
			{
				TopMost = false;
				boolMainWindowWasOnTop = true;
			}
			using (JulianDateCalculatorForm formJulianDateCalculator = new())
			{
				if (checkBoxDarkLightMode.Checked)
				{
					formJulianDateCalculator.BackColor = colorDarkBackground;
					formJulianDateCalculator.ForeColor = colorWhiteFont;
				}
				_ = formJulianDateCalculator.ShowDialog();
			}
			if (boolMainWindowWasOnTop)
			{
				TopMost = true;
			}
		}

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonOpenJulianDateConverter_Click(object sender, EventArgs e)
		{
			bool boolMainWindowWasOnTop = false;
			if (TopMost)
			{
				TopMost = false;
				boolMainWindowWasOnTop = true;
			}
			using (JulianDateConverterForm formJulianDateConverter = new())
			{
				if (checkBoxDarkLightMode.Checked)
				{
					formJulianDateConverter.BackColor = colorDarkBackground;
					formJulianDateConverter.ForeColor = colorWhiteFont;
					formJulianDateConverter.SetDarkMode();
				}
				_ = formJulianDateConverter.ShowDialog();
			}
			if (boolMainWindowWasOnTop)
			{
				TopMost = true;
			}
		}

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
				text: strInfotext + "\n\n" + ScreenToPicture(location: strPathToMyPictures + strFilenameWithExtension));
		}

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NumericUpDownRefreshRate_ValueChanged(object sender, EventArgs e) => timer.Interval =
			(int)numericUpDownRefreshRate.Value;

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRefreshRateText_DoubleClick(object sender, EventArgs e) => numericUpDownRefreshRate.Value =
			intDefaultTick;

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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

		/// <summary>
		///
		/// </summary>
		/// <param name="strText"></param>
		private void SetStatusBar(string strText)
		{
			toolStripStatusLabelInformation.Visible = true;
			toolStripStatusLabelInformation.Text = strText;
			toolStripStatusLabelAlarm.Visible = false;
			toolStripStatusLabelTakeScreenshot.Visible = false;
		}

		/// <summary>
		///
		/// </summary>
		private void ResetStatusBar()
		{
			toolStripStatusLabelInformation.Visible = false;
			toolStripStatusLabelInformation.Text = string.Empty;
			toolStripStatusLabelAlarm.Visible = true;
			toolStripStatusLabelTakeScreenshot.Visible = true;
		}

		#region Enter-Eventhandler

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUtcTimeText_Enter(object sender, EventArgs e)
		{
			labelUtcTimeText.Cursor = Cursors.Hand;
			labelUtcTimeText.Font = new Font(prototype: labelUtcTimeText.Font, newStyle: FontStyle.Underline);
			SetStatusBar(strText: labelUtcTimeText.AccessibleDescription);
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
			SetStatusBar(strText: labelLocalTimeText.AccessibleDescription);
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
			SetStatusBar(strText: labelJulianDateText.AccessibleDescription);
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
			SetStatusBar(strText: labelModifiedJulianDateText.AccessibleDescription);
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
			SetStatusBar(strText: labelReducedJulianDateText.AccessibleDescription);
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
			SetStatusBar(strText: labelTruncatedJulianDateText.AccessibleDescription);
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
			SetStatusBar(strText: labelDublinJulianDateText.AccessibleDescription);
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
			SetStatusBar(strText: labelCnesJulianDateText.AccessibleDescription);
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
			SetStatusBar(strText: labelCcsdsJulianDateText.AccessibleDescription);
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
			SetStatusBar(strText: labelLopJulianDateText.AccessibleDescription);
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
			SetStatusBar(strText: labelMillenniumJulianDateText.AccessibleDescription);
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
			SetStatusBar(strText: labelChronologicalJulianDateText.AccessibleDescription);
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
			SetStatusBar(strText: labelChronologicalModifiedJulianDateText.AccessibleDescription);
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
			SetStatusBar(strText: labelLilianDateText.AccessibleDescription);
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
			SetStatusBar(strText: labelRataDieText.AccessibleDescription);
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
			SetStatusBar(strText: labelMarsSolDateText.AccessibleDescription);
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
			SetStatusBar(strText: labelUnixtimeText.AccessibleDescription);
		}

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUtcTime_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelUtcTime.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLocalTime_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelLocalTime.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelJulianDate.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelModifiedJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelModifiedJulianDate.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelReducedJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelReducedJulianDate.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelTruncatedJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelTruncatedJulianDate.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDublinJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelDublinJulianDate.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCnesJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelCnesJulianDate.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCcsdsJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelCcsdsJulianDate.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLopJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelLopJulianDate.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMillenniumJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelMillenniumJulianDate.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelChronologicalJulianDate.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalModifiedJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelChronologicalModifiedJulianDate.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLilianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelLilianDate.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRataDie_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelRataDie.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMarsSolDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelMarsSolDate.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUnixtime_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelUnixtime.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckBoxAutomaticRefresh_Enter(object sender, EventArgs e) => SetStatusBar(strText: checkBoxAutomaticRefresh.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckBoxStayOnTop_Enter(object sender, EventArgs e) => SetStatusBar(strText: checkBoxStayOnTop.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckBoxDarkLightMode_Enter(object sender, EventArgs e) => SetStatusBar(strText: checkBoxDarkLightMode.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRefreshRateText_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelRefreshRateText.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NumericUpDownRefreshRate_Enter(object sender, EventArgs e) => SetStatusBar(strText: numericUpDownRefreshRate.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonMinimizeToTray_Enter(object sender, EventArgs e) => SetStatusBar(strText: buttonMinimizeToTray.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonInfo_Enter(object sender, EventArgs e) => SetStatusBar(strText: buttonInfo.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonRefresh_Enter(object sender, EventArgs e) => SetStatusBar(strText: buttonRefresh.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonOpenJulianDateCalculator_Enter(object sender, EventArgs e) => SetStatusBar(strText: buttonOpenJulianDateCalculator.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonOpenJulianDateConverter_Enter(object sender, EventArgs e) => SetStatusBar(strText: buttonOpenJulianDateConverter.AccessibleDescription);

		#endregion

		#region Leave-Eventhandler

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUtcTimeText_Leave(object sender, EventArgs e)
		{
			labelUtcTimeText.Cursor = Cursors.Default;
			labelUtcTimeText.Font = new Font(prototype: labelUtcTimeText.Font, newStyle: FontStyle.Regular);
			ResetStatusBar();
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
			ResetStatusBar();
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
			ResetStatusBar();
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
			ResetStatusBar();
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
			ResetStatusBar();
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
			ResetStatusBar();
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
			ResetStatusBar();
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
			ResetStatusBar();
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
			ResetStatusBar();
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
			ResetStatusBar();
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
			ResetStatusBar();
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
			ResetStatusBar();
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
			ResetStatusBar();
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
			ResetStatusBar();
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
			ResetStatusBar();
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
			ResetStatusBar();
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
			ResetStatusBar();
		}

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUtcTime_Leave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLocalTime_Leave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelModifiedJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelReducedJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelTruncatedJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDublinJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCnesJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCcsdsJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLopJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMillenniumJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalModifiedJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLilianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRataDie_Leave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMarsSolDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUnixtime_Leave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckBoxAutomaticRefresh_Leave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckBoxStayOnTop_Leave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckBoxDarkLightMode_Leave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRefreshRateText_Leave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NumericUpDownRefreshRate_Leave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonMinimizeToTray_Leave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonInfo_Leave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonRefresh_Leave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonOpenJulianDateCalculator_Leave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonOpenJulianDateConverter_Leave(object sender, EventArgs e) => ResetStatusBar();

		#endregion

		#region MouseEnter-Eventhandler

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
		private void LabelUtcTime_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelUtcTime.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLocalTime_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelLocalTime.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelJulianDate.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelModifiedJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelModifiedJulianDate.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelReducedJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelReducedJulianDate.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelTruncatedJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelTruncatedJulianDate.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDublinJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelDublinJulianDate.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCnesJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelCnesJulianDate.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCcsdsJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelCcsdsJulianDate.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLopJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelLopJulianDate.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMillenniumJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelMillenniumJulianDate.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelChronologicalJulianDate.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalModifiedJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelChronologicalModifiedJulianDate.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLilianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelLilianDate.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRataDie_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelRataDie.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMarsSolDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelMarsSolDate.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUnixtime_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelUnixtime.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckBoxAutomaticRefresh_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: checkBoxAutomaticRefresh.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckBoxStayOnTop_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: checkBoxStayOnTop.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckBoxDarkLightMode_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: checkBoxDarkLightMode.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRefreshRateText_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelRefreshRateText.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonMinimizeToTray_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: buttonMinimizeToTray.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonInfo_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: buttonInfo.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonRefresh_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: buttonRefresh.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonOpenJulianDateCalculator_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: buttonOpenJulianDateCalculator.AccessibleDescription);

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonOpenJulianDateConverter_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: buttonOpenJulianDateConverter.AccessibleDescription);

		#endregion

		#region MouseLeave-Eventhandler

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
		private void LabelUtcTime_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLocalTime_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelModifiedJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelReducedJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelTruncatedJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDublinJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCnesJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelCcsdsJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLopJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMillenniumJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelChronologicalModifiedJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLilianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRataDie_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMarsSolDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelUnixtime_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckBoxAutomaticRefresh_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckBoxStayOnTop_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckBoxDarkLightMode_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRefreshRateText_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonMinimizeToTray_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonInfo_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonRefresh_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonOpenJulianDateCalculator_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		/// <summary>
		///
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonOpenJulianDateConverter_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		#endregion
	}
}