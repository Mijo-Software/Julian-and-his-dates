using System;
using System.Drawing;
using System.Globalization;
using System.Media;
using System.Windows.Forms;

namespace JulianAndHisDates
{
	/// <summary>
	///  Initialize the form.
	/// </summary>
	public partial class JulianandhisdatesForm : Form
	{
		private double doubleOldJD = 0.999999999999999999999999;
		private double doubleNewJD;
		private bool boolFirstRun = true;
		private bool boolIsAlarmEnabled = true;
		private readonly int intDefaultTick = 20;
		private readonly Color colorWhiteFont = Color.WhiteSmoke;
		private readonly Color colorDarkBackground = Color.FromArgb(red: 29, green: 32, blue: 41);

		/// <summary>
		/// culture info for the date
		/// </summary>
		private readonly CultureInfo culture = CultureInfo.CurrentUICulture;

		/// <summary>
		///  Initialize the form.
		/// </summary>
		public JulianandhisdatesForm() => InitializeComponent();

		private static Properties.Settings GetDefault() => Properties.Settings.Default;

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
		/// 
		/// </summary>
		/// <param name="location">Path, where output file will be saved at.</param>
		/// <returns>Path of the successfully saved image or errormessage</returns>
		public string ScreenToPicture(string location)
		{
			try
			{
				Size currentScreenSize = new Size(width: Size.Width, height: Size.Height);
				Bitmap screenToBitmap = new Bitmap(width: Size.Width, height: Size.Height);
				Graphics gGraphics = Graphics.FromImage(image: screenToBitmap);
				gGraphics.CopyFromScreen(upperLeftSource: Location, upperLeftDestination: new Point(0, 0), blockRegionSize: currentScreenSize);
				screenToBitmap.Save(filename: location);
				return location;
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}

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
				checkBoxStayOnTop.Text = Properties.Resources.strApplicationNotOnTop;
				TopMost = true;
			}
			else
			{
				checkBoxStayOnTop.Text = Properties.Resources.strApplicationOnTop;
				TopMost = false;
			}
			numericUpDownRefreshRate.Value = timer.Interval;
			boolIsAlarmEnabled = GetDefault().isAlarmEnabled;
			if (boolIsAlarmEnabled)
			{
				boolIsAlarmEnabled = true;
				toolStripStatusLabelAlarm.Image = Properties.Resources.picSound;
				toolStripStatusLabelAlarm.Text = Properties.Resources.strAlarmOn;
			}
			else
			{
				boolIsAlarmEnabled = false;
				toolStripStatusLabelAlarm.Image = Properties.Resources.picSoundMute;
				toolStripStatusLabelAlarm.Text = Properties.Resources.strAlarmOff;
			}
			UpdateDateInformations();
		}

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
					using (SoundPlayer sound = new SoundPlayer(stream: Properties.Resources.wavBleep))
					{
						sound.Play();
					}
					notifyIcon.BalloonTipText = JulianDates.CalculateJulianDate().ToString(provider: culture);
					notifyIcon.BalloonTipTitle = Properties.Resources.strJdSwitched;
					notifyIcon.ShowBalloonTip(timeout: 500);
				}
			}
		}

		private void CopyToClipboard(string strText)
		{
			Clipboard.SetText(text: strText);
			MessageBox.Show(text: Properties.Resources.strCopiedToClipboard, caption: Properties.Resources.strInformation, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
		}

		private void ButtonRefresh_Click(object sender, EventArgs e) => UpdateDateInformations();

		private void ButtonInfo_Click(object sender, EventArgs e)
		{
			bool boolMainWindowWasOnTop = false;
			if (TopMost) { TopMost = false; boolMainWindowWasOnTop = true; }
			using (AboutBoxForm about = new AboutBoxForm())
			{
				if (checkBoxDarkLightMode.Checked)
				{
					about.BackColor = colorDarkBackground;
					about.ForeColor = colorWhiteFont;
				}
				about.ShowDialog();
			}
			if (boolMainWindowWasOnTop)
			{
				TopMost = true;
			}
		}

		private void ButtonMinimizeToTray_Click(object sender, EventArgs e)
		{
			Hide();
			notifyIcon.Visible = true;
			notifyIcon.BalloonTipText = Properties.Resources.strApplicationMinimizedText;
			notifyIcon.BalloonTipTitle = Properties.Resources.strApplicationMinimizedTitle;
			notifyIcon.ShowBalloonTip(timeout: 500);
		}

		private void LabelUtcTimeText_Click(object sender, EventArgs e) => MessageBox.Show(text: Properties.Resources.strUtcTimeText, caption: Properties.Resources.strInformation, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

		private void LabelLocalTimeText_Click(object sender, EventArgs e) => MessageBox.Show(text: Properties.Resources.strLocalTimeText, caption: Properties.Resources.strInformation, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

		private void LabelJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(text: Properties.Resources.strJulianDateText, caption: Properties.Resources.strInformation, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

		private void LabelModifiedJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(text: Properties.Resources.strModifiedJulianDateText, caption: Properties.Resources.strInformation, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

		private void LabelReducedJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(text: Properties.Resources.strReducedJulianDateText, caption: Properties.Resources.strInformation, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

		private void LabelTruncatedJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(text: Properties.Resources.strTruncatedJulianDateText, caption: Properties.Resources.strInformation, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

		private void LabelDublinJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(text: Properties.Resources.strDublinJulianDateText, caption: Properties.Resources.strInformation, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

		private void LabelCnesJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(text: Properties.Resources.strCnesJulianDateText, caption: Properties.Resources.strInformation, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

		private void LabelCcsdsJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(text: Properties.Resources.strCcsdsJulianDateText, caption: Properties.Resources.strInformation, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

		private void LabelLopJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(text: Properties.Resources.strLopJulianDateText, caption: Properties.Resources.strInformation, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

		private void LabelMillenniumJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(text: Properties.Resources.strMillenniumJulianDateText, caption: Properties.Resources.strInformation, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

		private void LabelChronologicalJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(text: Properties.Resources.strChronologicalJulianDateText, caption: Properties.Resources.strInformation, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

		private void LabelChronologicalModifiedJulianDateText_Click(object sender, EventArgs e) => MessageBox.Show(text: Properties.Resources.strChronologicalModifiedJulianDateText, caption: Properties.Resources.strInformation, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

		private void LabelLilianDateText_Click(object sender, EventArgs e) => MessageBox.Show(text: Properties.Resources.strLilianDateText, caption: Properties.Resources.strInformation, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

		private void LabelRataDieText_Click(object sender, EventArgs e) => MessageBox.Show(text: Properties.Resources.strRataDieText, caption: Properties.Resources.strInformation, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

		private void LabelMarsSolDateText_Click(object sender, EventArgs e) => MessageBox.Show(text: Properties.Resources.strMarsSolDateText, caption: Properties.Resources.strInformation, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

		private void LabelUnixtimeText_Click(object sender, EventArgs e) => MessageBox.Show(text: Properties.Resources.strUnixtimeText, caption: Properties.Resources.strInformation, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

		private void LabelUtcTime_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelUtcTime.Text);

		private void LabelLocalTime_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelLocalTime.Text);

		private void LabelJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelJulianDate.Text);

		private void LabelModifiedJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelModifiedJulianDate.Text);

		private void LabelReducedJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelReducedJulianDate.Text);

		private void LabelTruncatedJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelTruncatedJulianDate.Text);

		private void LabelDublinJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelDublinJulianDate.Text);

		private void LabelCnesJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelCnesJulianDate.Text);

		private void LabelCcsdsJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelCcsdsJulianDate.Text);

		private void LabelLopJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelLopJulianDate.Text);

		private void LabelMillenniumJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelMillenniumJulianDate.Text);

		private void LabelChronologicalJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelChronologicalJulianDate.Text);

		private void LabelChronologicalModifiedJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelChronologicalModifiedJulianDate.Text);

		private void LabelLilianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelLilianDate.Text);

		private void LabelRataDie_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelRataDie.Text);

		private void LabelMarsSolDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelMarsSolDate.Text);

		private void LabelUnixtime_DoubleClick(object sender, EventArgs e) => CopyToClipboard(strText: labelUnixtime.Text);

		private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Show();
			notifyIcon.BalloonTipText = Properties.Resources.strApplicationMaximizedText;
			notifyIcon.BalloonTipTitle = Properties.Resources.strApplicationMaximizedTitle;
			notifyIcon.ShowBalloonTip(timeout: 500);
			notifyIcon.Visible = false;
		}

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

		private void CheckBoxStayOnTop_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxStayOnTop.Checked)
			{
				checkBoxStayOnTop.Text = Properties.Resources.strApplicationNotOnTop;
				TopMost = true;
			}
			else
			{
				checkBoxStayOnTop.Text = Properties.Resources.strApplicationOnTop;
				TopMost = false;
			}
		}

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
				using (SoundPlayer sound = new SoundPlayer(Properties.Resources.wavBlop))
				{
					sound.Play();
				}
			}
		}

		private void ButtonOpenJulianDateCalculator_Click(object sender, EventArgs e)
		{
			bool boolMainWindowWasOnTop = false;
			if (TopMost) { TopMost = false; boolMainWindowWasOnTop = true; }
			using (JulianDateCalculatorForm formJulianDateCalculator = new JulianDateCalculatorForm())
			{
				if (checkBoxDarkLightMode.Checked)
				{
					formJulianDateCalculator.BackColor = colorDarkBackground;
					formJulianDateCalculator.ForeColor = colorWhiteFont;
				}
				formJulianDateCalculator.ShowDialog();
			}
			if (boolMainWindowWasOnTop)
			{
				TopMost = true;
			}
		}

		private void ButtonOpenJulianDateConverter_Click(object sender, EventArgs e)
		{
			bool boolMainWindowWasOnTop = false;
			if (TopMost) { TopMost = false; boolMainWindowWasOnTop = true; }
			using (JulianDateConverterForm formJulianDateConverter = new JulianDateConverterForm())
			{
				if (checkBoxDarkLightMode.Checked)
				{
					formJulianDateConverter.BackColor = colorDarkBackground;
					formJulianDateConverter.ForeColor = colorWhiteFont;
					formJulianDateConverter.SetDarkmode();
				}
				formJulianDateConverter.ShowDialog();
			}
			if (boolMainWindowWasOnTop)
			{
				TopMost = true;
			}
		}

		private void ToolStripStatusLabelAlarm_Click(object sender, EventArgs e)
		{
			if (boolIsAlarmEnabled)
			{
				boolIsAlarmEnabled = false;
				toolStripStatusLabelAlarm.Image = Properties.Resources.picSoundMute;
				toolStripStatusLabelAlarm.Text = Properties.Resources.strAlarmOff;
			}
			else
			{
				boolIsAlarmEnabled = true;
				toolStripStatusLabelAlarm.Image = Properties.Resources.picSound;
				toolStripStatusLabelAlarm.Text = Properties.Resources.strAlarmOn;
				using (SoundPlayer sound = new SoundPlayer(stream: Properties.Resources.wavBleep))
				{
					sound.Play();
				}
			}
		}

		private void ToolStripStatusLabelTakeScreenshot_Click(object sender, EventArgs e)
		{
			using (SoundPlayer sound = new SoundPlayer(stream: Properties.Resources.wavCameraFlashing))
			{
				sound.Play();
			}
			string
				strPathToMyPictures = Environment.GetFolderPath(folder: Environment.SpecialFolder.MyPictures) + "\\",
				strFilenameWithExtension = JulianDates.CalculateJulianDate().ToString(provider: culture) + ".png",
				strInfotext = Properties.Resources.strScreenshotSavedTo;
			MessageBox.Show(text: strInfotext + "\n\n" + ScreenToPicture(location: strPathToMyPictures + strFilenameWithExtension));
		}

		private void NumericUpDownRefreshRate_ValueChanged(object sender, EventArgs e) => timer.Interval = (int)numericUpDownRefreshRate.Value;

		private void LabelRefreshRateText_DoubleClick(object sender, EventArgs e) => numericUpDownRefreshRate.Value = intDefaultTick;

		private void JulianandhisdatesForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Properties.Settings.Default.BackgroundColor = BackColor;
			Properties.Settings.Default.ForegroundColor = labelUtcTimeText.ForeColor;
			Properties.Settings.Default.userTicks = timer.Interval;
			Properties.Settings.Default.isDarkmodeEnabled = checkBoxDarkLightMode.Checked;
			Properties.Settings.Default.isAlarmEnabled = boolIsAlarmEnabled;
			Properties.Settings.Default.isAutomaticRefreshing = checkBoxAutomaticRefresh.Checked;
			Properties.Settings.Default.isStayOnTop = checkBoxStayOnTop.Checked;
			Properties.Settings.Default.Save();
		}

		private void SetStatusBar(string strText)
		{
			toolStripStatusLabelInformation.Visible = true;
			toolStripStatusLabelInformation.Text = strText;
			toolStripStatusLabelAlarm.Visible = false;
			toolStripStatusLabelTakeScreenshot.Visible = false;
		}

		private void ResetStatusBar()
		{
			toolStripStatusLabelInformation.Visible = false;
			toolStripStatusLabelInformation.Text = "";
			toolStripStatusLabelAlarm.Visible = true;
			toolStripStatusLabelTakeScreenshot.Visible = true;
		}

		#region Enter-Eventhandler

		private void LabelUtcTimeText_Enter(object sender, EventArgs e)
		{
			labelUtcTimeText.Cursor = Cursors.Hand;
			labelUtcTimeText.Font = new Font(prototype: labelUtcTimeText.Font, newStyle: FontStyle.Underline);
			SetStatusBar(strText: labelUtcTimeText.AccessibleDescription);
		}

		private void LabelLocalTimeText_Enter(object sender, EventArgs e)
		{
			labelLocalTimeText.Cursor = Cursors.Hand;
			labelLocalTimeText.Font = new Font(prototype: labelLocalTimeText.Font, newStyle: FontStyle.Underline);
			SetStatusBar(strText: labelLocalTimeText.AccessibleDescription);
		}

		private void LabelJulianDateText_Enter(object sender, EventArgs e)
		{
			labelJulianDateText.Cursor = Cursors.Hand;
			labelJulianDateText.Font = new Font(prototype: labelJulianDateText.Font, newStyle: FontStyle.Underline);
			SetStatusBar(strText: labelJulianDateText.AccessibleDescription);
		}

		private void LabelModifiedJulianDateText_Enter(object sender, EventArgs e)
		{
			labelModifiedJulianDateText.Cursor = Cursors.Hand;
			labelModifiedJulianDateText.Font = new Font(prototype: labelModifiedJulianDateText.Font, newStyle: FontStyle.Underline);
			SetStatusBar(strText: labelModifiedJulianDateText.AccessibleDescription);
		}

		private void LabelReducedJulianDateText_Enter(object sender, EventArgs e)
		{
			labelReducedJulianDateText.Cursor = Cursors.Hand;
			labelReducedJulianDateText.Font = new Font(prototype: labelReducedJulianDateText.Font, newStyle: FontStyle.Underline);
			SetStatusBar(strText: labelReducedJulianDateText.AccessibleDescription);
		}

		private void LabelTruncatedJulianDateText_Enter(object sender, EventArgs e)
		{
			labelTruncatedJulianDateText.Cursor = Cursors.Hand;
			labelTruncatedJulianDateText.Font = new Font(prototype: labelTruncatedJulianDateText.Font, newStyle: FontStyle.Underline);
			SetStatusBar(strText: labelTruncatedJulianDateText.AccessibleDescription);
		}

		private void LabelDublinJulianDateText_Enter(object sender, EventArgs e)
		{
			labelDublinJulianDateText.Cursor = Cursors.Hand;
			labelDublinJulianDateText.Font = new Font(prototype: labelDublinJulianDateText.Font, newStyle: FontStyle.Underline);
			SetStatusBar(strText: labelDublinJulianDateText.AccessibleDescription);
		}

		private void LabelCnesJulianDateText_Enter(object sender, EventArgs e)
		{
			labelCnesJulianDateText.Cursor = Cursors.Hand;
			labelCnesJulianDateText.Font = new Font(prototype: labelCnesJulianDateText.Font, newStyle: FontStyle.Underline);
			SetStatusBar(strText: labelCnesJulianDateText.AccessibleDescription);
		}

		private void LabelCcsdsJulianDateText_Enter(object sender, EventArgs e)
		{
			labelCcsdsJulianDateText.Cursor = Cursors.Hand;
			labelCcsdsJulianDateText.Font = new Font(prototype: labelCcsdsJulianDateText.Font, newStyle: FontStyle.Underline);
			SetStatusBar(strText: labelCcsdsJulianDateText.AccessibleDescription);
		}

		private void LabelLopJulianDateText_Enter(object sender, EventArgs e)
		{
			labelLopJulianDateText.Cursor = Cursors.Hand;
			labelLopJulianDateText.Font = new Font(prototype: labelLopJulianDateText.Font, newStyle: FontStyle.Underline);
			SetStatusBar(strText: labelLopJulianDateText.AccessibleDescription);
		}

		private void LabelMillenniumJulianDateText_Enter(object sender, EventArgs e)
		{
			labelMillenniumJulianDateText.Cursor = Cursors.Hand;
			labelMillenniumJulianDateText.Font = new Font(prototype: labelMillenniumJulianDateText.Font, newStyle: FontStyle.Underline);
			SetStatusBar(strText: labelMillenniumJulianDateText.AccessibleDescription);
		}

		private void LabelChronologicalJulianDateText_Enter(object sender, EventArgs e)
		{
			labelChronologicalJulianDateText.Cursor = Cursors.Hand;
			labelChronologicalJulianDateText.Font = new Font(prototype: labelChronologicalJulianDateText.Font, newStyle: FontStyle.Underline);
			SetStatusBar(strText: labelChronologicalJulianDateText.AccessibleDescription);
		}

		private void LabelChronologicalModifiedJulianDateText_Enter(object sender, EventArgs e)
		{
			labelChronologicalModifiedJulianDateText.Cursor = Cursors.Hand;
			labelChronologicalModifiedJulianDateText.Font = new Font(prototype: labelChronologicalModifiedJulianDateText.Font, newStyle: FontStyle.Underline);
			SetStatusBar(strText: labelChronologicalModifiedJulianDateText.AccessibleDescription);
		}

		private void LabelLilianDateText_Enter(object sender, EventArgs e)
		{
			labelLilianDateText.Cursor = Cursors.Hand;
			labelLilianDateText.Font = new Font(prototype: labelLilianDateText.Font, newStyle: FontStyle.Underline);
			SetStatusBar(strText: labelLilianDateText.AccessibleDescription);
		}

		private void LabelRataDieText_Enter(object sender, EventArgs e)
		{
			labelRataDieText.Cursor = Cursors.Hand;
			labelRataDieText.Font = new Font(prototype: labelRataDieText.Font, newStyle: FontStyle.Underline);
			SetStatusBar(strText: labelRataDieText.AccessibleDescription);
		}

		private void LabelMarsSolDateText_Enter(object sender, EventArgs e)
		{
			labelMarsSolDateText.Cursor = Cursors.Hand;
			labelMarsSolDateText.Font = new Font(prototype: labelMarsSolDateText.Font, newStyle: FontStyle.Underline);
			SetStatusBar(strText: labelMarsSolDateText.AccessibleDescription);
		}

		private void LabelUnixtimeText_Enter(object sender, EventArgs e)
		{
			labelUnixtimeText.Cursor = Cursors.Hand;
			labelUnixtimeText.Font = new Font(prototype: labelUnixtimeText.Font, newStyle: FontStyle.Underline);
			SetStatusBar(strText: labelUnixtimeText.AccessibleDescription);
		}

		private void LabelUtcTime_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelUtcTime.AccessibleDescription);

		private void LabelLocalTime_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelLocalTime.AccessibleDescription);

		private void LabelJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelJulianDate.AccessibleDescription);

		private void LabelModifiedJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelModifiedJulianDate.AccessibleDescription);

		private void LabelReducedJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelReducedJulianDate.AccessibleDescription);

		private void LabelTruncatedJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelTruncatedJulianDate.AccessibleDescription);

		private void LabelDublinJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelDublinJulianDate.AccessibleDescription);

		private void LabelCnesJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelCnesJulianDate.AccessibleDescription);

		private void LabelCcsdsJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelCcsdsJulianDate.AccessibleDescription);

		private void LabelLopJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelLopJulianDate.AccessibleDescription);

		private void LabelMillenniumJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelMillenniumJulianDate.AccessibleDescription);

		private void LabelChronologicalJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelChronologicalJulianDate.AccessibleDescription);

		private void LabelChronologicalModifiedJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelChronologicalModifiedJulianDate.AccessibleDescription);

		private void LabelLilianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelLilianDate.AccessibleDescription);

		private void LabelRataDie_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelRataDie.AccessibleDescription);

		private void LabelMarsSolDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelMarsSolDate.AccessibleDescription);

		private void LabelUnixtime_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelUnixtime.AccessibleDescription);

		private void CheckBoxAutomaticRefresh_Enter(object sender, EventArgs e) => SetStatusBar(strText: checkBoxAutomaticRefresh.AccessibleDescription);

		private void CheckBoxStayOnTop_Enter(object sender, EventArgs e) => SetStatusBar(strText: checkBoxStayOnTop.AccessibleDescription);

		private void CheckBoxDarkLightMode_Enter(object sender, EventArgs e) => SetStatusBar(strText: checkBoxDarkLightMode.AccessibleDescription);

		private void LabelRefreshRateText_Enter(object sender, EventArgs e) => SetStatusBar(strText: labelRefreshRateText.AccessibleDescription);

		private void NumericUpDownRefreshRate_Enter(object sender, EventArgs e) => SetStatusBar(strText: numericUpDownRefreshRate.AccessibleDescription);

		private void ButtonMinimizeToTray_Enter(object sender, EventArgs e) => SetStatusBar(strText: buttonMinimizeToTray.AccessibleDescription);

		private void ButtonInfo_Enter(object sender, EventArgs e) => SetStatusBar(strText: buttonInfo.AccessibleDescription);

		private void ButtonRefresh_Enter(object sender, EventArgs e) => SetStatusBar(strText: buttonRefresh.AccessibleDescription);

		private void ButtonOpenJulianDateCalculator_Enter(object sender, EventArgs e) => SetStatusBar(strText: buttonOpenJulianDateCalculator.AccessibleDescription);

		private void ButtonOpenJulianDateConverter_Enter(object sender, EventArgs e) => SetStatusBar(strText: buttonOpenJulianDateConverter.AccessibleDescription);

		#endregion

		#region Leave-Eventhandler

		private void LabelUtcTimeText_Leave(object sender, EventArgs e)
		{
			labelUtcTimeText.Cursor = Cursors.Default;
			labelUtcTimeText.Font = new Font(prototype: labelUtcTimeText.Font, newStyle: FontStyle.Regular);
			ResetStatusBar();
		}

		private void LabelLocalTimeText_Leave(object sender, EventArgs e)
		{
			labelLocalTimeText.Cursor = Cursors.Default;
			labelLocalTimeText.Font = new Font(prototype: labelLocalTimeText.Font, newStyle: FontStyle.Regular);
			ResetStatusBar();
		}

		private void LabelJulianDateText_Leave(object sender, EventArgs e)
		{
			labelJulianDateText.Cursor = Cursors.Default;
			labelJulianDateText.Font = new Font(prototype: labelJulianDateText.Font, newStyle: FontStyle.Regular);
			ResetStatusBar();
		}

		private void LabelModifiedJulianDateText_Leave(object sender, EventArgs e)
		{
			labelModifiedJulianDateText.Cursor = Cursors.Default;
			labelModifiedJulianDateText.Font = new Font(prototype: labelModifiedJulianDateText.Font, newStyle: FontStyle.Regular);
			ResetStatusBar();
		}

		private void LabelReducedJulianDateText_Leave(object sender, EventArgs e)
		{
			labelReducedJulianDateText.Cursor = Cursors.Default;
			labelReducedJulianDateText.Font = new Font(prototype: labelReducedJulianDateText.Font, newStyle: FontStyle.Regular);
			ResetStatusBar();
		}

		private void LabelTruncatedJulianDateText_Leave(object sender, EventArgs e)
		{
			labelTruncatedJulianDateText.Cursor = Cursors.Default;
			labelTruncatedJulianDateText.Font = new Font(prototype: labelTruncatedJulianDateText.Font, newStyle: FontStyle.Regular);
			ResetStatusBar();
		}

		private void LabelDublinJulianDateText_Leave(object sender, EventArgs e)
		{
			labelDublinJulianDateText.Cursor = Cursors.Default;
			labelDublinJulianDateText.Font = new Font(prototype: labelDublinJulianDateText.Font, newStyle: FontStyle.Regular);
			ResetStatusBar();
		}

		private void LabelCnesJulianDateText_Leave(object sender, EventArgs e)
		{
			labelCnesJulianDateText.Cursor = Cursors.Default;
			labelCnesJulianDateText.Font = new Font(prototype: labelCnesJulianDateText.Font, newStyle: FontStyle.Regular);
			ResetStatusBar();
		}

		private void LabelCcsdsJulianDateText_Leave(object sender, EventArgs e)
		{
			labelCcsdsJulianDateText.Cursor = Cursors.Default;
			labelCcsdsJulianDateText.Font = new Font(prototype: labelCcsdsJulianDateText.Font, newStyle: FontStyle.Regular);
			ResetStatusBar();
		}

		private void LabelLopJulianDateText_Leave(object sender, EventArgs e)
		{
			labelLopJulianDateText.Cursor = Cursors.Default;
			labelLopJulianDateText.Font = new Font(prototype: labelLopJulianDateText.Font, newStyle: FontStyle.Regular);
			ResetStatusBar();
		}

		private void LabelMillenniumJulianDateText_Leave(object sender, EventArgs e)
		{
			labelMillenniumJulianDateText.Cursor = Cursors.Default;
			labelMillenniumJulianDateText.Font = new Font(prototype: labelMillenniumJulianDateText.Font, newStyle: FontStyle.Regular);
			ResetStatusBar();
		}

		private void LabelChronologicalJulianDateText_Leave(object sender, EventArgs e)
		{
			labelChronologicalJulianDateText.Cursor = Cursors.Default;
			labelChronologicalJulianDateText.Font = new Font(prototype: labelChronologicalJulianDateText.Font, newStyle: FontStyle.Regular);
			ResetStatusBar();
		}

		private void LabelChronologicalModifiedJulianDateText_Leave(object sender, EventArgs e)
		{
			labelChronologicalModifiedJulianDateText.Cursor = Cursors.Default;
			labelChronologicalModifiedJulianDateText.Font = new Font(prototype: labelChronologicalModifiedJulianDateText.Font, newStyle: FontStyle.Regular);
			ResetStatusBar();
		}

		private void LabelLilianDateText_Leave(object sender, EventArgs e)
		{
			labelLilianDateText.Cursor = Cursors.Default;
			labelLilianDateText.Font = new Font(prototype: labelLilianDateText.Font, newStyle: FontStyle.Regular);
			ResetStatusBar();
		}

		private void LabelRataDieText_Leave(object sender, EventArgs e)
		{
			labelRataDieText.Cursor = Cursors.Default;
			labelRataDieText.Font = new Font(prototype: labelRataDieText.Font, newStyle: FontStyle.Regular);
			ResetStatusBar();
		}

		private void LabelMarsSolDateText_Leave(object sender, EventArgs e)
		{
			labelMarsSolDateText.Cursor = Cursors.Default;
			labelMarsSolDateText.Font = new Font(prototype: labelMarsSolDateText.Font, newStyle: FontStyle.Regular);
			ResetStatusBar();
		}

		private void LabelUnixtimeText_Leave(object sender, EventArgs e)
		{
			labelUnixtimeText.Cursor = Cursors.Default;
			labelUnixtimeText.Font = new Font(prototype: labelUnixtimeText.Font, newStyle: FontStyle.Regular);
			ResetStatusBar();
		}

		private void LabelUtcTime_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelLocalTime_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelModifiedJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelReducedJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelTruncatedJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelDublinJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelCnesJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelCcsdsJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelLopJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelMillenniumJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelChronologicalJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelChronologicalModifiedJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelLilianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelRataDie_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelMarsSolDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelUnixtime_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void CheckBoxAutomaticRefresh_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void CheckBoxStayOnTop_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void CheckBoxDarkLightMode_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelRefreshRateText_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void NumericUpDownRefreshRate_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void ButtonMinimizeToTray_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void ButtonInfo_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void ButtonRefresh_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void ButtonOpenJulianDateCalculator_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void ButtonOpenJulianDateConverter_Leave(object sender, EventArgs e) => ResetStatusBar();

		#endregion

		#region MouseEnter-Eventhandler

		private void LabelUtcTimeText_MouseEnter(object sender, EventArgs e) => LabelUtcTimeText_Enter(sender: sender, e: e);

		private void LabelLocalTimeText_MouseEnter(object sender, EventArgs e) => LabelLocalTimeText_Enter(sender: sender, e: e);

		private void LabelJulianDateText_MouseEnter(object sender, EventArgs e) => LabelJulianDateText_Enter(sender: sender, e: e);

		private void LabelModifiedJulianDateText_MouseEnter(object sender, EventArgs e) => LabelModifiedJulianDateText_Enter(sender: sender, e: e);

		private void LabelReducedJulianDateText_MouseEnter(object sender, EventArgs e) => LabelReducedJulianDateText_Enter(sender: sender, e: e);

		private void LabelTruncatedJulianDateText_MouseEnter(object sender, EventArgs e) => LabelTruncatedJulianDateText_Enter(sender: sender, e: e);

		private void LabelDublinJulianDateText_MouseEnter(object sender, EventArgs e) => LabelDublinJulianDateText_Enter(sender: sender, e: e);

		private void LabelCnesJulianDateText_MouseEnter(object sender, EventArgs e) => LabelCnesJulianDateText_Enter(sender: sender, e: e);

		private void LabelCcsdsJulianDateText_MouseEnter(object sender, EventArgs e) => LabelCcsdsJulianDateText_Enter(sender: sender, e: e);

		private void LabelLopJulianDateText_MouseEnter(object sender, EventArgs e) => LabelLopJulianDateText_Enter(sender: sender, e: e);

		private void LabelMillenniumJulianDateText_MouseEnter(object sender, EventArgs e) => LabelMillenniumJulianDateText_Enter(sender: sender, e: e);

		private void LabelChronologicalJulianDateText_MouseEnter(object sender, EventArgs e) => LabelChronologicalJulianDateText_Enter(sender: sender, e: e);

		private void LabelChronologicalModifiedJulianDateText_MouseEnter(object sender, EventArgs e) => LabelChronologicalModifiedJulianDateText_Enter(sender: sender, e: e);

		private void LabelLilianDateText_MouseEnter(object sender, EventArgs e) => LabelLilianDateText_Enter(sender: sender, e: e);

		private void LabelRataDieText_MouseEnter(object sender, EventArgs e) => LabelRataDieText_Enter(sender: sender, e: e);

		private void LabelMarsSolDateText_MouseEnter(object sender, EventArgs e) => LabelMarsSolDateText_Enter(sender: sender, e: e);

		private void LabelUnixtimeText_MouseEnter(object sender, EventArgs e) => LabelUnixtimeText_Enter(sender: sender, e: e);

		private void LabelUtcTime_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelUtcTime.AccessibleDescription);

		private void LabelLocalTime_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelLocalTime.AccessibleDescription);

		private void LabelJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelJulianDate.AccessibleDescription);

		private void LabelModifiedJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelModifiedJulianDate.AccessibleDescription);

		private void LabelReducedJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelReducedJulianDate.AccessibleDescription);

		private void LabelTruncatedJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelTruncatedJulianDate.AccessibleDescription);

		private void LabelDublinJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelDublinJulianDate.AccessibleDescription);

		private void LabelCnesJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelCnesJulianDate.AccessibleDescription);

		private void LabelCcsdsJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelCcsdsJulianDate.AccessibleDescription);

		private void LabelLopJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelLopJulianDate.AccessibleDescription);

		private void LabelMillenniumJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelMillenniumJulianDate.AccessibleDescription);

		private void LabelChronologicalJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelChronologicalJulianDate.AccessibleDescription);

		private void LabelChronologicalModifiedJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelChronologicalModifiedJulianDate.AccessibleDescription);

		private void LabelLilianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelLilianDate.AccessibleDescription);

		private void LabelRataDie_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelRataDie.AccessibleDescription);

		private void LabelMarsSolDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelMarsSolDate.AccessibleDescription);

		private void LabelUnixtime_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelUnixtime.AccessibleDescription);

		private void CheckBoxAutomaticRefresh_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: checkBoxAutomaticRefresh.AccessibleDescription);

		private void CheckBoxStayOnTop_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: checkBoxStayOnTop.AccessibleDescription);

		private void CheckBoxDarkLightMode_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: checkBoxDarkLightMode.AccessibleDescription);

		private void LabelRefreshRateText_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelRefreshRateText.AccessibleDescription);

		private void ButtonMinimizeToTray_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: buttonMinimizeToTray.AccessibleDescription);

		private void ButtonInfo_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: buttonInfo.AccessibleDescription);

		private void ButtonRefresh_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: buttonRefresh.AccessibleDescription);

		private void ButtonOpenJulianDateCalculator_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: buttonOpenJulianDateCalculator.AccessibleDescription);

		private void ButtonOpenJulianDateConverter_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: buttonOpenJulianDateConverter.AccessibleDescription);

		#endregion

		#region MouseLeave-Eventhandler

		private void LabelUtcTimeText_MouseLeave(object sender, EventArgs e) => LabelUtcTimeText_Leave(sender: sender, e: e);

		private void LabelLocalTimeText_MouseLeave(object sender, EventArgs e) => LabelLocalTimeText_Leave(sender: sender, e: e);

		private void LabelJulianDateText_MouseLeave(object sender, EventArgs e) => LabelJulianDateText_Leave(sender: sender, e: e);

		private void LabelModifiedJulianDateText_MouseLeave(object sender, EventArgs e) => LabelModifiedJulianDateText_Leave(sender: sender, e: e);

		private void LabelReducedJulianDateText_MouseLeave(object sender, EventArgs e) => LabelReducedJulianDateText_Leave(sender: sender, e: e);

		private void LabelTruncatedJulianDateText_MouseLeave(object sender, EventArgs e) => LabelTruncatedJulianDateText_Leave(sender: sender, e: e);

		private void LabelDublinJulianDateText_MouseLeave(object sender, EventArgs e) => LabelDublinJulianDateText_Leave(sender: sender, e: e);

		private void LabelCnesJulianDateText_MouseLeave(object sender, EventArgs e) => LabelCnesJulianDateText_Leave(sender: sender, e: e);

		private void LabelCcsdsJulianDateText_MouseLeave(object sender, EventArgs e) => LabelCcsdsJulianDateText_Leave(sender: sender, e: e);

		private void LabelLopJulianDateText_MouseLeave(object sender, EventArgs e) => LabelLopJulianDateText_Leave(sender: sender, e: e);

		private void LabelMillenniumJulianDateText_MouseLeave(object sender, EventArgs e) => LabelMillenniumJulianDateText_Leave(sender: sender, e: e);

		private void LabelChronologicalJulianDateText_MouseLeave(object sender, EventArgs e) => LabelChronologicalJulianDateText_Leave(sender: sender, e: e);

		private void LabelChronologicalModifiedJulianDateText_MouseLeave(object sender, EventArgs e) => LabelChronologicalModifiedJulianDateText_Leave(sender: sender, e: e);

		private void LabelLilianDateText_MouseLeave(object sender, EventArgs e) => LabelLilianDateText_Leave(sender: sender, e: e);

		private void LabelRataDieText_MouseLeave(object sender, EventArgs e) => LabelRataDieText_Leave(sender: sender, e: e);

		private void LabelMarsSolDateText_MouseLeave(object sender, EventArgs e) => LabelMarsSolDateText_Leave(sender: sender, e: e);

		private void LabelUnixtimeText_MouseLeave(object sender, EventArgs e) => LabelUnixtimeText_Leave(sender: sender, e: e);

		private void LabelUtcTime_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelLocalTime_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelModifiedJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelReducedJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelTruncatedJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelDublinJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelCnesJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelCcsdsJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelLopJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelMillenniumJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelChronologicalJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelChronologicalModifiedJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelLilianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelRataDie_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelMarsSolDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelUnixtime_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void CheckBoxAutomaticRefresh_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void CheckBoxStayOnTop_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void CheckBoxDarkLightMode_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelRefreshRateText_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void ButtonMinimizeToTray_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void ButtonInfo_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void ButtonRefresh_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void ButtonOpenJulianDateCalculator_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void ButtonOpenJulianDateConverter_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		#endregion
	}
}