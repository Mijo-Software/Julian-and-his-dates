using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace JulianAndHisDates
{
	/// <summary>
	///  Initialize the form.
	/// </summary>
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

		/// <summary>
		///  Initialize the form.
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

		#endregion

		#region Enter-Eventhandlers

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

		private void DateTimePicker_Enter(object sender, EventArgs e) => SetStatusBar(strText: dateTimePicker.AccessibleDescription);

		private void CheckBoxIgnoreDecimals_Enter(object sender, EventArgs e) => SetStatusBar(strText: checkBoxIgnoreDecimals.AccessibleDescription);

		#endregion

		#region Leave-Eventhandlers

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

		private void DateTimePicker_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void CheckBoxIgnoreDecimals_Leave(object sender, EventArgs e) => ResetStatusBar();

		#endregion

		#region MouseEnter-Eventhandlers

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

		private void DateTimePicker_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: dateTimePicker.AccessibleDescription);

		private void CheckBoxIgnoreDecimals_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: checkBoxIgnoreDecimals.AccessibleDescription);

		#endregion

		#region MouseLeave-Eventhandlers

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
				gGraphics.CopyFromScreen(Location, new Point(0, 0), blockRegionSize: currentScreenSize);
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
			using (SoundPlayer sound = new SoundPlayer(stream: Properties.Resources.wavCameraFlashing))
			{
				sound.Play();
			}
			string
				strPathToMyPictures = Environment.GetFolderPath(folder: Environment.SpecialFolder.MyPictures).ToString() + "\\",
				strFilenameWithExtension = JulianDates.CalculateJulianDate().ToString() + ".png",
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
			}
			else
			{
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

		private void DateTimePicker_ValueChanged(object sender, EventArgs e)
		{
			DateTime value = dateTimePicker.Value;
			labelUtcTime.Text = value.ToUniversalTime().ToString();
			labelLocalTime.Text = value.ToLocalTime().ToString();
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

		private void CheckBoxIgnoreDecimals_CheckedChanged(object sender, EventArgs e) => CheckToTruncateDecimals();
	}
}
