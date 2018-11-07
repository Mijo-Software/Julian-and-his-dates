using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Julian_and_his_dates
{
	public partial class JulianDateCalculatorForm : Form
  {
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

		private void JulianDateCalculatorForm_Load(object sender, EventArgs e)
		{
			statusStrip.ForeColor = ForeColor;
			statusStrip.BackColor = BackColor;
		}

		private void CopyToClipboard(string strText)
		{
			Clipboard.SetText(text: strText);
			MessageBox.Show(text: Properties.Resources.strCopiedToClipboard, caption: Properties.Resources.strInformation, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
		}

		private void SetStatusBar(string strText)
		{
			toolStripStatusLabelInformation.Visible = true;
			toolStripStatusLabelInformation.Text = strText;
			toolStripStatusLabelTakeScreenshot.Visible = false;
		}

		private void ResetStatusBar()
		{
			toolStripStatusLabelInformation.Visible = false;
			toolStripStatusLabelInformation.Text = "";
			toolStripStatusLabelTakeScreenshot.Visible = true;
		}

		#region Click-Eventhandlers

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

		#endregion

		#region DoubleClick-Eventhandlers

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

		#endregion

		#region Enter-Eventhandlers

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

		private void DateTimePicker_Enter(object sender, EventArgs e) => SetStatusBar(dateTimePicker.AccessibleDescription);

		private void CheckBoxIgnoreDecimals_Enter(object sender, EventArgs e) => SetStatusBar(checkBoxIgnoreDecimals.AccessibleDescription);

		#endregion

		#region Leave-Eventhandlers

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

		private void DateTimePicker_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void CheckBoxIgnoreDecimals_Leave(object sender, EventArgs e) => ResetStatusBar();

		#endregion

		#region MouseEnter-Eventhandlers

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

		private void DateTimePicker_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelUnixtime.AccessibleDescription);

		private void CheckBoxIgnoreDecimals_MouseEnter(object sender, EventArgs e) => SetStatusBar(labelUnixtime.AccessibleDescription);

		#endregion

		#region MouseLeave-Eventhandlers

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

		private void DateTimePicker_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void CheckBoxIgnoreDecimals_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelLopJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelMillenniumJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelChronologicalJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelChronologicalModifiedJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelLilianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelRataDie_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelMarsSolDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelUnixtime_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		#endregion

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

		private void CheckToTruncateDecimals()
		{
			if (checkBoxIgnoreDecimals.Checked)
			{
				labelJulianDate.Text = Math.Truncate(d: doubleJulianDate).ToString();
				labelModifiedJulianDate.Text = Math.Truncate(d: doubleModifiedJulianDate).ToString();
				labelReducedJulianDate.Text = Math.Truncate(d: doubleReducedJulianDate).ToString();
				labelTruncatedJulianDate.Text = Math.Truncate(d: doubleTruncatedJulianDate).ToString();
				labelDublinJulianDate.Text = Math.Truncate(d: doubleDublinJulianDate).ToString();
				labelCnesJulianDate.Text = Math.Truncate(d: doubleCnesJulianDate).ToString();
				labelCcsdsJulianDate.Text = Math.Truncate(d: doubleCcsdsJulianDate).ToString();
				labelLopJulianDate.Text = Math.Truncate(d: doubleLopJulianDate).ToString();
				labelMillenniumJulianDate.Text = Math.Truncate(d: doubleMillenniumJulianDate).ToString();
				labelChronologicalJulianDate.Text = Math.Truncate(d: doubleChronologicalJulianDate).ToString();
				labelChronologicalModifiedJulianDate.Text = Math.Truncate(d: doubleChronologicalModifiedJulianDate).ToString();
				labelLilianDate.Text = Math.Truncate(d: doubleLilianDate).ToString();
				labelRataDie.Text = Math.Truncate(d: doubleRataDie).ToString();
				labelMarsSolDate.Text = Math.Truncate(d: doubleMarsSolDate).ToString();
				labelUnixtime.Text = Math.Truncate(d: doubleUnixtime).ToString();
			} else {
				labelJulianDate.Text = doubleJulianDate.ToString();
				labelModifiedJulianDate.Text = doubleModifiedJulianDate.ToString();
				labelReducedJulianDate.Text = doubleReducedJulianDate.ToString();
				labelTruncatedJulianDate.Text = doubleTruncatedJulianDate.ToString();
				labelDublinJulianDate.Text = doubleDublinJulianDate.ToString();
				labelCnesJulianDate.Text = doubleCnesJulianDate.ToString();
				labelCcsdsJulianDate.Text = doubleCcsdsJulianDate.ToString();
				labelLopJulianDate.Text = doubleLopJulianDate.ToString();
				labelMillenniumJulianDate.Text = doubleMillenniumJulianDate.ToString();
				labelChronologicalJulianDate.Text = doubleChronologicalJulianDate.ToString();
				labelChronologicalModifiedJulianDate.Text = doubleChronologicalModifiedJulianDate.ToString();
				labelLilianDate.Text = doubleLilianDate.ToString();
				labelRataDie.Text = doubleRataDie.ToString();
				labelMarsSolDate.Text = doubleMarsSolDate.ToString();
				labelUnixtime.Text = doubleUnixtime.ToString();
			}
		}

		/// <summary>
		///  Initialize the form.
		/// </summary>
		public JulianDateCalculatorForm()
    {
      InitializeComponent();
			doubleJulianDate = JulianDatesClass.CalcJulianDate();
			doubleModifiedJulianDate = JulianDatesClass.CalcModifiedJulianDate();
			doubleReducedJulianDate = JulianDatesClass.CalcReducedJulianDate();
			doubleTruncatedJulianDate = JulianDatesClass.CalcTruncatedJulianDate();
			doubleDublinJulianDate = JulianDatesClass.CalcDublinJulianDate();
			doubleCnesJulianDate = JulianDatesClass.CalcCnesJulianDate();
			doubleCcsdsJulianDate = JulianDatesClass.CalcCcsdsJulianDate();
			doubleLopJulianDate = JulianDatesClass.CalcLopJulianDate();
			doubleMillenniumJulianDate = JulianDatesClass.CalcMillenniumJulianDate();
			doubleChronologicalJulianDate = JulianDatesClass.CalcChronologicalJulianDate();
			doubleChronologicalModifiedJulianDate = JulianDatesClass.calcChronologicalModifiedJulianDate();
			doubleLilianDate = JulianDatesClass.CalcLilianDate();
			doubleRataDie = JulianDatesClass.CalcRataDie();
			doubleMarsSolDate = JulianDatesClass.CalcMarsSolDate();
			doubleUnixtime = JulianDatesClass.CalcUnixtime();
			labelLocalTime.Text = DateTime.Now.ToString();
			labelUtcTime.Text = DateTime.UtcNow.ToString();
			labelJulianDate.Text = doubleJulianDate.ToString();
			labelModifiedJulianDate.Text = doubleModifiedJulianDate.ToString();
			labelReducedJulianDate.Text = doubleReducedJulianDate.ToString();
			labelTruncatedJulianDate.Text = doubleTruncatedJulianDate.ToString();
			labelDublinJulianDate.Text = doubleDublinJulianDate.ToString();
			labelCnesJulianDate.Text = doubleCnesJulianDate.ToString();
			labelCcsdsJulianDate.Text = doubleCcsdsJulianDate.ToString();
			labelLopJulianDate.Text = doubleLopJulianDate.ToString();
			labelMillenniumJulianDate.Text = doubleMillenniumJulianDate.ToString();
			labelChronologicalJulianDate.Text = doubleChronologicalJulianDate.ToString();
			labelChronologicalModifiedJulianDate.Text = doubleChronologicalModifiedJulianDate.ToString();
			labelLilianDate.Text = doubleLilianDate.ToString();
			labelRataDie.Text = doubleRataDie.ToString();
			labelMarsSolDate.Text = doubleMarsSolDate.ToString();
			labelUnixtime.Text = doubleUnixtime.ToString();
		}

		private void DateTimePicker_ValueChanged(object sender, EventArgs e)
		{
			DateTime value = dateTimePicker.Value;
			labelUtcTime.Text = value.ToUniversalTime().ToString();
			labelLocalTime.Text = value.ToLocalTime().ToString();
			doubleJulianDate = JulianDatesClass.CalcJulianDate(date: value);
			doubleModifiedJulianDate = JulianDatesClass.CalcModifiedJulianDate(date: value);
			doubleReducedJulianDate = JulianDatesClass.CalcReducedJulianDate(date: value);
			doubleTruncatedJulianDate = JulianDatesClass.CalcTruncatedJulianDate(date: value);
			doubleDublinJulianDate = JulianDatesClass.CalcDublinJulianDate(date: value);
			doubleCnesJulianDate = JulianDatesClass.CalcCnesJulianDate(date: value);
			doubleCcsdsJulianDate = JulianDatesClass.CalcCcsdsJulianDate(date: value);
			doubleLopJulianDate = JulianDatesClass.CalcLopJulianDate(date: value);
			doubleMillenniumJulianDate = JulianDatesClass.CalcMillenniumJulianDate(date: value);
			doubleChronologicalJulianDate = JulianDatesClass.CalcChronologicalJulianDate(date: value);
			doubleChronologicalModifiedJulianDate = JulianDatesClass.CalcChronologicalModifiedJulianDate(date: value);
			doubleLilianDate = JulianDatesClass.CalcLilianDate(date: value);
			doubleRataDie = JulianDatesClass.CalcRataDie(date: value);
			doubleMarsSolDate = JulianDatesClass.CalcMarsSolDate(date: value);
			doubleUnixtime = JulianDatesClass.CalcUnixtime(date: value);
			CheckToTruncateDecimals();
		}

		private void CheckBoxIgnoreDecimals_CheckedChanged(object sender, EventArgs e) => CheckToTruncateDecimals();
	}
}
