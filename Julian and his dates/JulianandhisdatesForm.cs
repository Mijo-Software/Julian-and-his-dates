using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Julian_and_his_dates
{
	/// <summary>
	///  Initialize the form.
	/// </summary>
	public partial class JulianandhisdatesForm : Form
  {
    double doubleOldJD = 0.999999999999999999999999, doubleNewJD;
    bool boolFirstRun = true;
    bool boolIsAlarmEnabled = true;
    int intDefaultTick = 20;
		Color
			colorWhiteFont = Color.WhiteSmoke,
			colorDarkBackground = Color.FromArgb(29, 32, 41);

		/// <summary>
		///  Initialize the form.
		/// </summary>
		public JulianandhisdatesForm()
    {
      InitializeComponent();
    }

		private static Properties.Settings GetDefault() => Properties.Settings.Default;

		private void UpdateDateInformations()
    {
      labelLocalTime.Text = DateTime.Now.ToString();
      labelUtcTime.Text = DateTime.UtcNow.ToString();
      labelJulianDate.Text = JulianDatesClass.CalcJulianDate().ToString();
      labelModifiedJulianDate.Text = JulianDatesClass.CalcModifiedJulianDate().ToString();
      labelReducedJulianDate.Text = JulianDatesClass.CalcReducedJulianDate().ToString();
      labelTruncatedJulianDate.Text = JulianDatesClass.CalcTruncatedJulianDate().ToString();
      labelDublinJulianDate.Text = JulianDatesClass.CalcDublinJulianDate().ToString();
      labelCnesJulianDate.Text = JulianDatesClass.CalcCnesJulianDate().ToString();
      labelCcsdsJulianDate.Text = JulianDatesClass.CalcCcsdsJulianDate().ToString();
      labelLopJulianDate.Text = JulianDatesClass.CalcLopJulianDate().ToString();
      labelMillenniumJulianDate.Text = JulianDatesClass.CalcMillenniumJulianDate().ToString();
      labelChronologicalJulianDate.Text = JulianDatesClass.CalcChronologicalJulianDate().ToString();
      labelChronologicalModifiedJulianDate.Text = JulianDatesClass.calcChronologicalModifiedJulianDate().ToString();
      labelLilianDate.Text = JulianDatesClass.CalcLilianDate().ToString();
      labelRataDie.Text = JulianDatesClass.CalcRataDie().ToString();
      labelMarsSolDate.Text = JulianDatesClass.CalcMarsSolDate().ToString();
      labelUnixtime.Text = JulianDatesClass.CalcUnixtime().ToString();
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
        Size currentScreenSize = new Size(Size.Width, Size.Height);
        Bitmap screenToBitmap = new Bitmap(Size.Width, Size.Height);
        Graphics gGraphics = Graphics.FromImage(image: screenToBitmap);
        gGraphics.CopyFromScreen(this.Location, new Point(0, 0), blockRegionSize: currentScreenSize);
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
			this.BackColor = GetDefault().BackgroundColor;
			this.ForeColor = GetDefault().ForegroundColor;
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
				this.TopMost = true;
			}
			else
			{
				checkBoxStayOnTop.Text = Properties.Resources.strApplicationOnTop;
				this.TopMost = false;
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
      doubleNewJD = JulianDatesClass.CalcJulianDate();
      doubleNewJD = doubleNewJD - Math.Truncate(d: doubleNewJD);
      if (doubleNewJD < doubleOldJD)
      {
        doubleOldJD = doubleNewJD;
        if (boolFirstRun == true)
				{
					boolFirstRun = false;
				} else {
          SoundPlayer sound = new SoundPlayer(Properties.Resources.wavBleep);
          sound.Play();
          notifyIcon.BalloonTipText = JulianDatesClass.CalcJulianDate().ToString();
          notifyIcon.BalloonTipTitle = Properties.Resources.strJdSwitched;
          notifyIcon.ShowBalloonTip(500);
        }
      }
    }

		private void ButtonRefresh_Click(object sender, EventArgs e) => UpdateDateInformations();

		private void CheckBoxAutomaticRefresh_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBoxAutomaticRefresh.Checked)
      {
        buttonRefresh.Enabled = false;
        timer.Enabled = true;
      } else {
        buttonRefresh.Enabled = true;
        timer.Enabled = false;
      }
    }

    private void ButtonInfo_Click(object sender, EventArgs e)
    {
      bool boolMainWindowWasOnTop = false;
      if (this.TopMost == true) { this.TopMost = false; boolMainWindowWasOnTop = true; }
      AboutBoxForm about = new AboutBoxForm();
      if (checkBoxDarkLightMode.Checked == true)
      {
				about.BackColor = colorDarkBackground;
        about.ForeColor = colorWhiteFont;
      }
      about.ShowDialog();
      if (boolMainWindowWasOnTop == true) this.TopMost = true;
    }

    private void ButtonMinimizeToTray_Click(object sender, EventArgs e)
    {
      this.Hide();
      notifyIcon.Visible = true;
      notifyIcon.BalloonTipText = Properties.Resources.strApplicationMinimizedText;
      notifyIcon.BalloonTipTitle = Properties.Resources.strApplicationMinimizedTitle;
      notifyIcon.ShowBalloonTip(500);
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

		private void CopyToClipboard(string strText)
		{
			Clipboard.SetText(text: strText);
			MessageBox.Show(text: Properties.Resources.strCopiedToClipboard, caption: Properties.Resources.strInformation, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);	
		}

		private void LabelUtcTime_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelUtcTime.Text);

		private void LabelLocalTime_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelLocalTime.Text);

		private void LabelJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelJulianDate.Text);

		private void LabelModifiedJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelModifiedJulianDate.Text);

		private void LabelReducedJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelReducedJulianDate.Text);

		private void LabelTruncatedJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelTruncatedJulianDate.Text);

		private void LabelDublinJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelDublinJulianDate.Text);

		private void LabelCnesJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelCnesJulianDate.Text);

		private void LabelCcsdsJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelCcsdsJulianDate.Text);

		private void LabelLopJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelLopJulianDate.Text);

		private void LabelMillenniumJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelMillenniumJulianDate.Text);

		private void LabelChronologicalJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelChronologicalJulianDate.Text);

		private void LabelChronologicalModifiedJulianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelChronologicalModifiedJulianDate.Text);

		private void LabelLilianDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelLilianDate.Text);

		private void LabelRataDie_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelRataDie.Text);

		private void LabelMarsSolDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelMarsSolDate.Text);

		private void LabelUnixtime_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelUnixtime.Text);

		private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      this.Show();
      notifyIcon.BalloonTipText = Properties.Resources.strApplicationMaximizedText;
      notifyIcon.BalloonTipTitle = Properties.Resources.strApplicationMaximizedTitle;
      notifyIcon.ShowBalloonTip(500);
      notifyIcon.Visible = false;
    }

    private void CheckBoxStayOnTop_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBoxStayOnTop.Checked)
      {
        checkBoxStayOnTop.Text = Properties.Resources.strApplicationNotOnTop;
        this.TopMost = true;
      } else {
        checkBoxStayOnTop.Text = Properties.Resources.strApplicationOnTop;
        this.TopMost = false;
      }
    }

    private void CheckBoxDarkLightMode_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBoxDarkLightMode.Checked)
      { // Enable dark mode
        this.BackColor = colorDarkBackground;
				this.ForeColor = colorWhiteFont;
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
			else { //Enable light mode
        this.BackColor = SystemColors.Control;
				this.ForeColor = SystemColors.ControlText;
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
        SoundPlayer sound = new SoundPlayer(Properties.Resources.wavBlop);
        sound.Play();
      }
    }

    private void ButtonOpenJulianDateCalculator_Click(object sender, EventArgs e)
    {
      bool boolMainWindowWasOnTop = false;
      if (this.TopMost) { this.TopMost = false; boolMainWindowWasOnTop = true; }
      JulianDateCalculatorForm formJulianDateCalculator = new JulianDateCalculatorForm();
      if (checkBoxDarkLightMode.Checked)
      {
				formJulianDateCalculator.BackColor = colorDarkBackground;
        formJulianDateCalculator.ForeColor = colorWhiteFont;
      }
      formJulianDateCalculator.ShowDialog();
      if (boolMainWindowWasOnTop) this.TopMost = true;
    }

    private void ButtonOpenJulianDateConverter_Click(object sender, EventArgs e)
    {
      bool boolMainWindowWasOnTop = false;
      if (this.TopMost == true) { this.TopMost = false; boolMainWindowWasOnTop = true; }
      JulianDateConverterForm formJulianDateConverter = new JulianDateConverterForm();
      if (checkBoxDarkLightMode.Checked)
      {
        formJulianDateConverter.BackColor = colorDarkBackground;
        formJulianDateConverter.ForeColor = colorWhiteFont;
      }
      formJulianDateConverter.ShowDialog();
      if (boolMainWindowWasOnTop) this.TopMost = true;
    }

		private void NumericUpDownRefreshRate_ValueChanged(object sender, EventArgs e) => timer.Interval = (int)numericUpDownRefreshRate.Value;

		private void LabelRefreshRateText_DoubleClick(object sender, EventArgs e) => numericUpDownRefreshRate.Value = intDefaultTick;

		private void JulianandhisdatesForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Properties.Settings.Default.BackgroundColor = this.BackColor;
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

		#region ENTER

		private void LabelUtcTimeText_Enter(object sender, EventArgs e) => SetStatusBar(labelUtcTimeText.AccessibleDescription);

		private void LabelLocalTimeText_Enter(object sender, EventArgs e) => SetStatusBar(labelLocalTimeText.AccessibleDescription);

		private void LabelJulianDateText_Enter(object sender, EventArgs e) => SetStatusBar(labelJulianDateText.AccessibleDescription);

		private void LabelModifiedJulianDateText_Enter(object sender, EventArgs e) => SetStatusBar(labelModifiedJulianDateText.AccessibleDescription);

		private void LabelReducedJulianDateText_Enter(object sender, EventArgs e) => SetStatusBar(labelReducedJulianDateText.AccessibleDescription);

		private void LabelTruncatedJulianDateText_Enter(object sender, EventArgs e) => SetStatusBar(labelTruncatedJulianDateText.AccessibleDescription);

		private void LabelDublinJulianDateText_Enter(object sender, EventArgs e) => SetStatusBar(labelDublinJulianDateText.AccessibleDescription);

		private void LabelCnesJulianDateText_Enter(object sender, EventArgs e) => SetStatusBar(labelCnesJulianDateText.AccessibleDescription);

		private void LabelCcsdsJulianDateText_Enter(object sender, EventArgs e) => SetStatusBar(labelCcsdsJulianDateText.AccessibleDescription);

		private void LabelLopJulianDateText_Enter(object sender, EventArgs e) => SetStatusBar(labelLopJulianDateText.AccessibleDescription);

		private void LabelMillenniumJulianDateText_Enter(object sender, EventArgs e) => SetStatusBar(labelMillenniumJulianDateText.AccessibleDescription);

		private void LabelChronologicalJulianDateText_Enter(object sender, EventArgs e) => SetStatusBar(labelChronologicalJulianDateText.AccessibleDescription);

		private void LabelChronologicalModifiedJulianDateText_Enter(object sender, EventArgs e) => SetStatusBar(labelChronologicalModifiedJulianDateText.AccessibleDescription);

		private void LabelLilianDateText_Enter(object sender, EventArgs e) => SetStatusBar(labelLilianDateText.AccessibleDescription);

		private void LabelRataDieText_Enter(object sender, EventArgs e) => SetStatusBar(labelRataDieText.AccessibleDescription);

		private void LabelMarsSolDateText_Enter(object sender, EventArgs e) => SetStatusBar(labelMarsSolDateText.AccessibleDescription);

		private void LabelUnixtimeText_Enter(object sender, EventArgs e) => SetStatusBar(labelUnixtimeText.AccessibleDescription);

		private void LabelUtcTime_Enter(object sender, EventArgs e) => SetStatusBar(labelUtcTime.AccessibleDescription);

		private void LabelLocalTime_Enter(object sender, EventArgs e) => SetStatusBar(labelLocalTime.AccessibleDescription);

		private void LabelJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(labelJulianDate.AccessibleDescription);

		private void LabelModifiedJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(labelModifiedJulianDate.AccessibleDescription);

		private void LabelReducedJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(labelReducedJulianDate.AccessibleDescription);

		private void LabelTruncatedJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(labelTruncatedJulianDate.AccessibleDescription);

		private void LabelDublinJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(labelDublinJulianDate.AccessibleDescription);

		private void LabelCnesJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(labelCnesJulianDate.AccessibleDescription);

		private void LabelCcsdsJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(labelCcsdsJulianDate.AccessibleDescription);

		private void LabelLopJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(labelLopJulianDate.AccessibleDescription);

		private void LabelMillenniumJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(labelMillenniumJulianDate.AccessibleDescription);

		private void LabelChronologicalJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(labelChronologicalJulianDate.AccessibleDescription);

		private void LabelChronologicalModifiedJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(labelChronologicalModifiedJulianDate.AccessibleDescription);

		private void LabelLilianDate_Enter(object sender, EventArgs e) => SetStatusBar(labelLilianDate.AccessibleDescription);

		private void LabelRataDie_Enter(object sender, EventArgs e) => SetStatusBar(labelRataDie.AccessibleDescription);

		private void LabelMarsSolDate_Enter(object sender, EventArgs e) => SetStatusBar(labelMarsSolDate.AccessibleDescription);

		private void LabelUnixtime_Enter(object sender, EventArgs e) => SetStatusBar(labelUnixtime.AccessibleDescription);

		private void CheckBoxAutomaticRefresh_Enter(object sender, EventArgs e) => SetStatusBar(checkBoxAutomaticRefresh.AccessibleDescription);

		private void CheckBoxStayOnTop_Enter(object sender, EventArgs e) => SetStatusBar(checkBoxStayOnTop.AccessibleDescription);

		private void CheckBoxDarkLightMode_Enter(object sender, EventArgs e) => SetStatusBar(checkBoxDarkLightMode.AccessibleDescription);

		private void LabelRefreshRateText_Enter(object sender, EventArgs e) => SetStatusBar(labelRefreshRateText.AccessibleDescription);

		private void NumericUpDownRefreshRate_Enter(object sender, EventArgs e) => SetStatusBar(numericUpDownRefreshRate.AccessibleDescription);

		private void ButtonMinimizeToTray_Enter(object sender, EventArgs e) => SetStatusBar(buttonMinimizeToTray.AccessibleDescription);

		private void ButtonInfo_Enter(object sender, EventArgs e) => SetStatusBar(buttonInfo.AccessibleDescription);

		private void ButtonRefresh_Enter(object sender, EventArgs e) => SetStatusBar(buttonRefresh.AccessibleDescription);

		private void ButtonOpenJulianDateCalculator_Enter(object sender, EventArgs e) => SetStatusBar(buttonOpenJulianDateCalculator.AccessibleDescription);

		private void ButtonOpenJulianDateConverter_Enter(object sender, EventArgs e) => SetStatusBar(buttonOpenJulianDateConverter.AccessibleDescription);

		#endregion

		#region LEAVE

		private void LabelUtcTimeText_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelLocalTimeText_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelJulianDateText_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelModifiedJulianDateText_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelReducedJulianDateText_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelTruncatedJulianDateText_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelDublinJulianDateText_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelCnesJulianDateText_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelCcsdsJulianDateText_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelLopJulianDateText_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelMillenniumJulianDateText_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelChronologicalJulianDateText_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelChronologicalModifiedJulianDateText_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelLilianDateText_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelRataDieText_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelMarsSolDateText_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelUnixtimeText_Leave(object sender, EventArgs e) => ResetStatusBar();

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

		#region MOUSEENTER

		private void LabelUtcTimeText_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelUtcTimeText.AccessibleDescription);

		private void LabelLocalTimeText_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelLocalTimeText.AccessibleDescription);

		private void LabelJulianDateText_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelJulianDateText.AccessibleDescription);

		private void LabelModifiedJulianDateText_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelModifiedJulianDateText.AccessibleDescription);

		private void LabelReducedJulianDateText_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelReducedJulianDateText.AccessibleDescription);

		private void LabelTruncatedJulianDateText_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelTruncatedJulianDateText.AccessibleDescription);

		private void LabelDublinJulianDateText_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelDublinJulianDateText.AccessibleDescription);

		private void LabelCnesJulianDateText_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelCnesJulianDateText.AccessibleDescription);

		private void LabelCcsdsJulianDateText_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelCcsdsJulianDateText.AccessibleDescription);

		private void LabelLopJulianDateText_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelLopJulianDateText.AccessibleDescription);

		private void LabelMillenniumJulianDateText_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelMillenniumJulianDateText.AccessibleDescription);

		private void LabelChronologicalJulianDateText_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelChronologicalJulianDateText.AccessibleDescription);

		private void LabelChronologicalModifiedJulianDateText_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelChronologicalModifiedJulianDateText.AccessibleDescription);

		private void LabelLilianDateText_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelLilianDateText.AccessibleDescription);

		private void LabelRataDieText_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelRataDieText.AccessibleDescription);

		private void LabelMarsSolDateText_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelMarsSolDateText.AccessibleDescription);

		private void LabelUnixtimeText_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelUnixtimeText.AccessibleDescription);

		private void LabelUtcTime_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelUtcTime.AccessibleDescription);

		private void LabelLocalTime_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelLocalTime.AccessibleDescription);

		private void LabelJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelJulianDate.AccessibleDescription);

		private void LabelModifiedJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelModifiedJulianDate.AccessibleDescription);

		private void LabelReducedJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelReducedJulianDate.AccessibleDescription);

		private void LabelTruncatedJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelTruncatedJulianDate.AccessibleDescription);

		private void LabelDublinJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelDublinJulianDate.AccessibleDescription);

		private void LabelCnesJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelCnesJulianDate.AccessibleDescription);

		private void LabelCcsdsJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelCcsdsJulianDate.AccessibleDescription);

		private void LabelLopJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelLopJulianDate.AccessibleDescription);

		private void LabelMillenniumJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelMillenniumJulianDate.AccessibleDescription);

		private void LabelChronologicalJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelChronologicalJulianDate.AccessibleDescription);

		private void LabelChronologicalModifiedJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelChronologicalModifiedJulianDate.AccessibleDescription);

		private void LabelLilianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelLilianDate.AccessibleDescription);

		private void LabelRataDie_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelRataDie.AccessibleDescription);

		private void LabelMarsSolDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelMarsSolDate.AccessibleDescription);

		private void LabelUnixtime_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelUnixtime.AccessibleDescription);

		private void CheckBoxAutomaticRefresh_MouseEnter(object sender, EventArgs e) => SetStatusBar(checkBoxAutomaticRefresh.AccessibleDescription);

		private void CheckBoxStayOnTop_MouseEnter(object sender, EventArgs e) => SetStatusBar(checkBoxStayOnTop.AccessibleDescription);

		private void CheckBoxDarkLightMode_MouseEnter(object sender, EventArgs e) => SetStatusBar(checkBoxDarkLightMode.AccessibleDescription);

		private void LabelRefreshRateText_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelRefreshRateText.AccessibleDescription);

		private void ButtonMinimizeToTray_MouseEnter(object sender, EventArgs e) => SetStatusBar(buttonMinimizeToTray.AccessibleDescription);

		private void ButtonInfo_MouseEnter(object sender, EventArgs e) => SetStatusBar(buttonInfo.AccessibleDescription);

		private void ButtonRefresh_MouseEnter(object sender, EventArgs e) => SetStatusBar(buttonRefresh.AccessibleDescription);

		private void ButtonOpenJulianDateCalculator_MouseEnter(object sender, EventArgs e) => SetStatusBar(buttonOpenJulianDateCalculator.AccessibleDescription);

		private void ButtonOpenJulianDateConverter_MouseEnter(object sender, EventArgs e) => SetStatusBar(buttonOpenJulianDateConverter.AccessibleDescription);

		#endregion

		#region MOUSELEAVE

		private void LabelUtcTimeText_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelLocalTimeText_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelJulianDateText_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelModifiedJulianDateText_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelReducedJulianDateText_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelTruncatedJulianDateText_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelDublinJulianDateText_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelCnesJulianDateText_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelCcsdsJulianDateText_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelLopJulianDateText_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelMillenniumJulianDateText_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelChronologicalJulianDateText_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelChronologicalModifiedJulianDateText_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelLilianDateText_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelRataDieText_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelMarsSolDateText_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelUnixtimeText_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

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

		private void ToolStripStatusLabelAlarm_Click(object sender, EventArgs e)
    {
      if (boolIsAlarmEnabled)
      {
        boolIsAlarmEnabled = false;
        toolStripStatusLabelAlarm.Image = Properties.Resources.picSoundMute;
        toolStripStatusLabelAlarm.Text = Properties.Resources.strAlarmOff;
      } else {
        boolIsAlarmEnabled = true;
        toolStripStatusLabelAlarm.Image = Properties.Resources.picSound;
        toolStripStatusLabelAlarm.Text = Properties.Resources.strAlarmOn;
        SoundPlayer sound = new SoundPlayer(stream: Properties.Resources.wavBleep);
        sound.Play();
      }
    }

    private void ToolStripStatusLabelTakeScreenshot_Click(object sender, EventArgs e)
    {
      SoundPlayer sound = new SoundPlayer(stream: Properties.Resources.wavCameraFlashing);
      sound.Play();
			string
				strPathToMyPictures = Environment.GetFolderPath(folder: Environment.SpecialFolder.MyPictures).ToString() + "\\",
				strFilenameWithExtension = JulianDatesClass.CalcJulianDate().ToString() + ".png",
				strInfotext = Properties.Resources.strScreenshotSavedTo;
			MessageBox.Show(text: strInfotext + "\n\n" + ScreenToPicture(location: strPathToMyPictures + strFilenameWithExtension));
		}
	}
}