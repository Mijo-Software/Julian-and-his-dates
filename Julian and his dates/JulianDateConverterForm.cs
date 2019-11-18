using System;
using System.Drawing;
using System.Globalization;
using System.Media;
using System.Windows.Forms;

namespace Julian_and_his_dates
{
	/// <summary>
	///  Initialize the form.
	/// </summary>
	public partial class JulianDateConverterForm : Form
	{

		private const double julianDateMinimum = 1721423.5;
		private const double julianDateMaximum = 5373483.5;
		private readonly double doubleJulianDate;
		private readonly double doubleModifiedJulianDate;
		private readonly double doubleReducedJulianDate;
		private readonly double doubleTruncatedJulianDate;
		private readonly double doubleDublinJulianDate;
		private readonly double doubleCnesJulianDate;
		private readonly double doubleCcsdsJulianDate;
		private readonly double doubleLopJulianDate;
		private readonly double doubleMillenniumJulianDate;
		private readonly double doubleLilianDate;
		private readonly double doubleChronologicalJulianDate;
		private readonly double doubleChronologicalModifiedJulianDate;
		private readonly double doubleRataDie;
		private readonly double doubleMarsSolDate;
		private readonly double doubleUnixtime;
		private readonly CultureInfo culture = CultureInfo.CreateSpecificCulture(name: "en-GB");
		private readonly NumberStyles style = NumberStyles.AllowDecimalPoint;
		private readonly Color colorWhiteFont = Color.WhiteSmoke;
		private readonly Color colorDarkBackground = Color.FromArgb(red: 29, green: 32, blue: 41);


		/// <summary>
		///  Initialize the form.
		/// </summary>
		public JulianDateConverterForm()
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
			textboxJulianDate.Text = doubleJulianDate.ToString();
			textboxModifiedJulianDate.Text = doubleModifiedJulianDate.ToString();
			textboxReducedJulianDate.Text = doubleReducedJulianDate.ToString();
			textboxTruncatedJulianDate.Text = doubleTruncatedJulianDate.ToString();
			textboxDublinJulianDate.Text = doubleDublinJulianDate.ToString();
			textboxCnesJulianDate.Text = doubleCnesJulianDate.ToString();
			textboxCcsdsJulianDate.Text = doubleCcsdsJulianDate.ToString();
			textboxLopJulianDate.Text = doubleLopJulianDate.ToString();
			textboxMillenniumJulianDate.Text = doubleMillenniumJulianDate.ToString();
			textboxChronologicalJulianDate.Text = doubleChronologicalJulianDate.ToString();
			textboxChronologicalModifiedJulianDate.Text = doubleChronologicalModifiedJulianDate.ToString();
			textboxLilianDate.Text = doubleLilianDate.ToString();
			textboxRataDie.Text = doubleRataDie.ToString();
			textboxMarsSolDate.Text = doubleMarsSolDate.ToString();
			textboxUnixtime.Text = doubleUnixtime.ToString();
		}

		/// <summary>
		/// 
		/// </summary>
		public void SetDarkmode()
		{
			textboxJulianDate.ForeColor = colorWhiteFont;
			textboxJulianDate.BackColor = colorDarkBackground;
			textboxModifiedJulianDate.ForeColor = colorWhiteFont;
			textboxModifiedJulianDate.BackColor = colorDarkBackground;
			textboxReducedJulianDate.ForeColor = colorWhiteFont;
			textboxReducedJulianDate.BackColor = colorDarkBackground;
			textboxTruncatedJulianDate.ForeColor = colorWhiteFont;
			textboxTruncatedJulianDate.BackColor = colorDarkBackground;
			textboxDublinJulianDate.ForeColor = colorWhiteFont;
			textboxDublinJulianDate.BackColor = colorDarkBackground;
			textboxCnesJulianDate.ForeColor = colorWhiteFont;
			textboxCnesJulianDate.BackColor = colorDarkBackground;
			textboxCcsdsJulianDate.ForeColor = colorWhiteFont;
			textboxCcsdsJulianDate.BackColor = colorDarkBackground;
			textboxLopJulianDate.ForeColor = colorWhiteFont;
			textboxLopJulianDate.BackColor = colorDarkBackground;
			textboxMillenniumJulianDate.ForeColor = colorWhiteFont;
			textboxMillenniumJulianDate.BackColor = colorDarkBackground;
			textboxChronologicalJulianDate.ForeColor = colorWhiteFont;
			textboxChronologicalJulianDate.BackColor = colorDarkBackground;
			textboxChronologicalModifiedJulianDate.ForeColor = colorWhiteFont;
			textboxChronologicalModifiedJulianDate.BackColor = colorDarkBackground;
			textboxLilianDate.ForeColor = colorWhiteFont;
			textboxLilianDate.BackColor = colorDarkBackground;
			textboxRataDie.ForeColor = colorWhiteFont;
			textboxRataDie.BackColor = colorDarkBackground;
			textboxMarsSolDate.ForeColor = colorWhiteFont;
			textboxMarsSolDate.BackColor = colorDarkBackground;
			textboxUnixtime.ForeColor = colorWhiteFont;
			textboxUnixtime.BackColor = colorDarkBackground;
		}

		private void JulianDateConverterForm_Load(object sender, EventArgs e)
		{
			statusStrip.ForeColor = ForeColor;
			statusStrip.BackColor = BackColor;
		}

		private bool IsOKForDecimalTextBox(char theCharacter, TextBox theTextBox)
		{
			// Only allow control characters, digits, plus and minus signs.
			// Only allow ONE plus sign.
			// Only allow ONE minus sign.
			// Only allow the plus or minus sign as the FIRST character.
			// Only allow ONE decimal point.
			// Do NOT allow decimal point or digits BEFORE any plus or minus sign.
			if (
				!char.IsControl(c: theCharacter)
				&& !char.IsDigit(c: theCharacter)
				&& (theCharacter != '.')
				&& (theCharacter != ',')
				&& (theCharacter != '-')
				&& (theCharacter != '+')
			)
			{
				// Then it is NOT a character we want allowed in the text box.
				return false;
			}
			// Only allow one decimal point.
			if (((theCharacter == '.') || (theCharacter == ',')) && ((theTextBox.Text.IndexOf(value: '.') > -1) || (theTextBox.Text.IndexOf(value: ',') > -1)))
			{
				// Then there is already a decimal point in the text box.
				return false;
			}
			// Only allow one minus sign.
			if (theCharacter == '-' && theTextBox.Text.IndexOf(value: theCharacter) > -1)
			{
				// Then there is already a minus sign in the text box.
				return false;
			}
			// Only allow one plus sign.
			if (theCharacter == '+' && theTextBox.Text.IndexOf(value: theCharacter) > -1)
			{
				// Then there is already a plus sign in the text box.
				return false;
			}
			// Only allow one plus sign OR minus sign, but not both.
			if ((
					(theCharacter == '-')
					|| (theCharacter == '+')
				)
				&&
				(
					(theTextBox.Text.IndexOf(value: '-') > -1)
					|| (theTextBox.Text.IndexOf(value: '+') > -1)
				)
			)
			{
				// Then the user is trying to enter a plus or minus sign and
				// there is ALREADY a plus or minus sign in the text box.
				return false;
			}
			// Only allow a minus or plus sign at the first character position.
			if ((
					(theCharacter == '-')
					|| (theCharacter == '+')
				)
				&& theTextBox.SelectionStart != 0
			)
			{
				// Then the user is trying to enter a minus or plus sign at some position 
				// OTHER than the first character position in the text box.
				return false;
			}

			// Only allow digits and decimal point AFTER any existing plus or minus sign
			if (
				(
					// Is digit or decimal point
					char.IsDigit(theCharacter) || (theCharacter == '.')
				)
				&&
				(
					// A plus or minus sign EXISTS
					(theTextBox.Text.IndexOf(value: '-') > -1) || (theTextBox.Text.IndexOf(value: '+') > -1)
				)
				&&
				// Attempting to put the character at the beginning of the field.
				theTextBox.SelectionStart == 0
			)
			{
				// Then the user is trying to enter a digit or decimal point in front of a minus or plus sign.
				return false;
			}

			// Only allow digits and decimal point AFTER any existing plus or minus sign
			if (
				(
					// Is digit or decimal point
					char.IsDigit(c: theCharacter) || (theCharacter == ',')
				)
				&&
				(
					// A plus or minus sign EXISTS
					(theTextBox.Text.IndexOf(value: '-') > -1) || (theTextBox.Text.IndexOf(value: '+') > -1)
				)
				&&
				// Attempting to put the character at the beginning of the field.
				theTextBox.SelectionStart == 0
			)
			{
				// Then the user is trying to enter a digit or decimal point in front of a minus or plus sign.
				return false;
			}
			// Otherwise the character is perfectly fine for a decimal value and the character
			// may indeed be placed at the current insertion position.
			return true;
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
				gGraphics.CopyFromScreen(upperLeftSource: Location, upperLeftDestination: new Point(x: 0, y: 0), blockRegionSize: currentScreenSize);
				screenToBitmap.Save(filename: location);
				return location;
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
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

		private void TextboxJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: textboxJulianDate.AccessibleDescription);

		private void TextboxModifiedJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: textboxModifiedJulianDate.AccessibleDescription);

		private void TextboxReducedJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: textboxReducedJulianDate.AccessibleDescription);

		private void TextboxTruncatedJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: textboxTruncatedJulianDate.AccessibleDescription);

		private void TextboxDublinJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: textboxDublinJulianDate.AccessibleDescription);

		private void TextboxCnesJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: textboxCnesJulianDate.AccessibleDescription);

		private void TextboxCcsdsJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: textboxCcsdsJulianDate.AccessibleDescription);

		private void TextboxLopJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: textboxLopJulianDate.AccessibleDescription);

		private void TextboxMillenniumJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: textboxMillenniumJulianDate.AccessibleDescription);

		private void TextboxChronologicalJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: textboxChronologicalJulianDate.AccessibleDescription);

		private void TextboxChronologicalModifiedJulianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: textboxChronologicalModifiedJulianDate.AccessibleDescription);

		private void TextboxLilianDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: textboxLilianDate.AccessibleDescription);

		private void TextboxRataDie_Enter(object sender, EventArgs e) => SetStatusBar(strText: textboxRataDie.AccessibleDescription);

		private void TextboxMarsSolDate_Enter(object sender, EventArgs e) => SetStatusBar(strText: textboxMarsSolDate.AccessibleDescription);

		private void TextboxUnixtime_Enter(object sender, EventArgs e) => SetStatusBar(strText: textboxUnixtime.AccessibleDescription);

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

		private void TextboxJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void TextboxModifiedJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void TextboxReducedJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void TextboxTruncatedJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void TextboxDublinJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void TextboxCnesJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void TextboxCcsdsJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void TextboxLopJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void TextboxMillenniumJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void TextboxChronologicalJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void TextboxChronologicalModifiedJulianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void TextboxLilianDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void TextboxRataDie_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void TextboxMarsSolDate_Leave(object sender, EventArgs e) => ResetStatusBar();

		private void TextboxUnixtime_Leave(object sender, EventArgs e) => ResetStatusBar();

		#endregion

		#region MouseEnter-Eventhandlers

		private void LabelUtcTimeText_MouseEnter(object sender, EventArgs e) => LabelUtcTimeText_Enter(sender: sender, e: e);

		private void LabelLocalTimeText_MouseEnter(object sender, EventArgs e) => LabelLocalTimeText_Enter(sender, e);

		private void LabelJulianDateText_MouseEnter(object sender, EventArgs e) => LabelJulianDateText_Enter(sender, e);

		private void LabelModifiedJulianDateText_MouseEnter(object sender, EventArgs e) => LabelModifiedJulianDateText_Enter(sender, e);

		private void LabelReducedJulianDateText_MouseEnter(object sender, EventArgs e) => LabelReducedJulianDateText_Enter(sender, e);

		private void LabelTruncatedJulianDateText_MouseEnter(object sender, EventArgs e) => LabelTruncatedJulianDateText_Enter(sender, e);

		private void LabelDublinJulianDateText_MouseEnter(object sender, EventArgs e) => LabelDublinJulianDateText_Enter(sender, e);

		private void LabelCnesJulianDateText_MouseEnter(object sender, EventArgs e) => LabelCnesJulianDateText_Enter(sender, e);

		private void LabelCcsdsJulianDateText_MouseEnter(object sender, EventArgs e) => LabelCcsdsJulianDateText_Enter(sender, e);

		private void LabelLopJulianDateText_MouseEnter(object sender, EventArgs e) => LabelLopJulianDateText_Enter(sender, e);

		private void LabelMillenniumJulianDateText_MouseEnter(object sender, EventArgs e) => LabelMillenniumJulianDateText_Enter(sender, e);

		private void LabelChronologicalJulianDateText_MouseEnter(object sender, EventArgs e) => LabelChronologicalJulianDateText_Enter(sender, e);

		private void LabelChronologicalModifiedJulianDateText_MouseEnter(object sender, EventArgs e) => LabelChronologicalModifiedJulianDateText_Enter(sender, e);

		private void LabelLilianDateText_MouseEnter(object sender, EventArgs e) => LabelLilianDateText_Enter(sender, e);

		private void LabelRataDieText_MouseEnter(object sender, EventArgs e) => LabelRataDieText_Enter(sender, e);

		private void LabelMarsSolDateText_MouseEnter(object sender, EventArgs e) => LabelMarsSolDateText_Enter(sender, e);

		private void LabelUnixtimeText_MouseEnter(object sender, EventArgs e) => LabelUnixtimeText_Enter(sender, e);

		private void LabelUtcTime_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelUtcTime.AccessibleDescription);

		private void LabelLocalTime_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: labelLocalTime.AccessibleDescription);

		private void TextboxJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: textboxJulianDate.AccessibleDescription);

		private void TextboxModifiedJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: textboxModifiedJulianDate.AccessibleDescription);

		private void TextboxReducedJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: textboxReducedJulianDate.AccessibleDescription);

		private void TextboxTruncatedJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: textboxTruncatedJulianDate.AccessibleDescription);

		private void TextboxDublinJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: textboxDublinJulianDate.AccessibleDescription);

		private void TextboxCnesJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: textboxCnesJulianDate.AccessibleDescription);

		private void TextboxCcsdsJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: textboxCcsdsJulianDate.AccessibleDescription);

		private void TextboxLopJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: textboxLopJulianDate.AccessibleDescription);

		private void TextboxMillenniumJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: textboxMillenniumJulianDate.AccessibleDescription);

		private void TextboxChronologicalJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: textboxChronologicalJulianDate.AccessibleDescription);

		private void TextboxChronologicalModifiedJulianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: textboxChronologicalModifiedJulianDate.AccessibleDescription);

		private void TextboxLilianDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: textboxLilianDate.AccessibleDescription);

		private void TextboxRataDie_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: textboxRataDie.AccessibleDescription);

		private void TextboxMarsSolDate_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: textboxMarsSolDate.AccessibleDescription);

		private void TextboxUnixtime_MouseEnter(object sender, EventArgs e) => SetStatusBar(strText: textboxUnixtime.AccessibleDescription);

		#endregion

		#region MouseLeave-Eventhandlers

		private void LabelUtcTimeText_MouseLeave(object sender, EventArgs e) => LabelUtcTimeText_Leave(sender, e);

		private void LabelLocalTimeText_MouseLeave(object sender, EventArgs e) => LabelLocalTimeText_Leave(sender, e);

		private void LabelJulianDateText_MouseLeave(object sender, EventArgs e) => LabelJulianDateText_Leave(sender, e);

		private void LabelModifiedJulianDateText_MouseLeave(object sender, EventArgs e) => LabelModifiedJulianDateText_Leave(sender, e);

		private void LabelReducedJulianDateText_MouseLeave(object sender, EventArgs e) => LabelReducedJulianDateText_Leave(sender, e);

		private void LabelTruncatedJulianDateText_MouseLeave(object sender, EventArgs e) => LabelTruncatedJulianDateText_Leave(sender, e);

		private void LabelDublinJulianDateText_MouseLeave(object sender, EventArgs e) => LabelDublinJulianDateText_Leave(sender, e);

		private void LabelCnesJulianDateText_MouseLeave(object sender, EventArgs e) => LabelCnesJulianDateText_Leave(sender, e);

		private void LabelCcsdsJulianDateText_MouseLeave(object sender, EventArgs e) => LabelCcsdsJulianDateText_Leave(sender, e);

		private void LabelLopJulianDateText_MouseLeave(object sender, EventArgs e) => LabelLopJulianDateText_Leave(sender, e);

		private void LabelMillenniumJulianDateText_MouseLeave(object sender, EventArgs e) => LabelMillenniumJulianDateText_Leave(sender, e);

		private void LabelChronologicalJulianDateText_MouseLeave(object sender, EventArgs e) => LabelChronologicalJulianDateText_Leave(sender, e);

		private void LabelChronologicalModifiedJulianDateText_MouseLeave(object sender, EventArgs e) => LabelChronologicalModifiedJulianDateText_Leave(sender, e);

		private void LabelLilianDateText_MouseLeave(object sender, EventArgs e) => LabelLilianDateText_Leave(sender, e);

		private void LabelRataDieText_MouseLeave(object sender, EventArgs e) => LabelRataDieText_Leave(sender, e);

		private void LabelMarsSolDateText_MouseLeave(object sender, EventArgs e) => LabelMarsSolDateText_Leave(sender, e);

		private void LabelUnixtimeText_MouseLeave(object sender, EventArgs e) => LabelUnixtimeText_Leave(sender, e);

		private void LabelUtcTime_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void LabelLocalTime_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void TextboxJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void TextboxModifiedJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void TextboxReducedJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void TextboxTruncatedJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void TextboxDublinJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void TextboxCnesJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void TextboxCcsdsJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void TextboxLopJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void TextboxMillenniumJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void TextboxChronologicalJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void TextboxChronologicalModifiedJulianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void TextboxLilianDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void TextboxRataDie_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void TextboxMarsSolDate_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		private void TextboxUnixtime_MouseLeave(object sender, EventArgs e) => ResetStatusBar();

		#endregion

		#region TextChangend-Eventhandlers

		private void TextboxJulianDate_TextChanged(object sender, EventArgs e)
		{
			double.TryParse(s: textboxJulianDate.Text.Replace(",", "."), style: style, provider: culture, result: out double julianDate);
			if (julianDate < julianDateMinimum)
			{
				julianDate = julianDateMinimum;
				textboxJulianDate.Text = julianDate.ToString();
				labelUtcTime.Text = Properties.Resources.strOutOfYearRange;
			}
			else if (julianDate > julianDateMaximum)
			{
				julianDate = julianDateMaximum;
				textboxJulianDate.Text = julianDate.ToString();
				labelUtcTime.Text = Properties.Resources.strOutOfYearRange;
			}
			else
			{
				labelUtcTime.Text = JulianDates.ConvertJulianDateToCivilCalendar(julianDate: julianDate).ToString();
			}
			textboxModifiedJulianDate.Text = JulianDates.ConvertJulianDateToModifiedJulianDate(julianDate: julianDate).ToString();
			textboxReducedJulianDate.Text = JulianDates.ConvertJulianDateToReducedJulianDate(julianDate: julianDate).ToString();
			textboxTruncatedJulianDate.Text = JulianDates.ConvertJulianDateToTruncatedJulianDate(julianDate: julianDate).ToString();
			textboxDublinJulianDate.Text = JulianDates.ConvertJulianDateToDublinJulianDate(julianDate: julianDate).ToString();
			textboxCnesJulianDate.Text = JulianDates.ConvertJulianDateToCnesJulianDate(julianDate: julianDate).ToString();
			textboxCcsdsJulianDate.Text = JulianDates.ConvertJulianDateToCcsdsJulianDate(julianDate: julianDate).ToString();
			textboxLopJulianDate.Text = JulianDates.ConvertJulianDateToLopJulianDate(julianDate: julianDate).ToString();
			textboxMillenniumJulianDate.Text = JulianDates.ConvertJulianDateToMillenniumJulianDate(julianDate: julianDate).ToString();
			textboxChronologicalJulianDate.Text = JulianDates.ConvertJulianDateToChronologicalJulianDate(julianDate: julianDate).ToString();
			textboxChronologicalModifiedJulianDate.Text = JulianDates.ConvertJulianDateToChronologicalModifiedJulianDate(julianDate: julianDate).ToString();
			textboxLilianDate.Text = JulianDates.ConvertJulianDateToLilianDate(julianDate: julianDate).ToString();
			textboxRataDie.Text = JulianDates.ConvertJulianDateToRataDie(julianDate: julianDate).ToString();
			textboxMarsSolDate.Text = JulianDates.ConvertJulianDateToMarsSolDate(julianDate: julianDate).ToString();
			textboxUnixtime.Text = JulianDates.ConvertJulianDateToUnixtime(julianDate: julianDate).ToString();
		}

		private void TextboxModifiedJulianDate_TextChanged(object sender, EventArgs e)
		{
			double.TryParse(s: textboxModifiedJulianDate.Text.Replace(",", "."), style: style, provider: culture, result: out double julianModifiedDate);
			double julianDate = JulianDates.ConvertModifiedJulianDateToJulianDate(julianModifiedDate);
			if (julianDate < julianDateMinimum)
			{
				julianDate = julianDateMinimum;
				textboxJulianDate.Text = julianDate.ToString();
				labelUtcTime.Text = Properties.Resources.strOutOfYearRange;
			}
			else if (julianDate > julianDateMaximum)
			{
				julianDate = julianDateMaximum;
				textboxJulianDate.Text = julianDate.ToString();
				labelUtcTime.Text = Properties.Resources.strOutOfYearRange;
			}
			else
			{
				labelUtcTime.Text = JulianDates.ConvertJulianDateToCivilCalendar(julianDate: julianDate).ToString();
			}
			textboxJulianDate.Text = julianDate.ToString();
			textboxReducedJulianDate.Text = JulianDates.ConvertJulianDateToReducedJulianDate(julianDate: julianDate).ToString();
			textboxTruncatedJulianDate.Text = JulianDates.ConvertJulianDateToTruncatedJulianDate(julianDate: julianDate).ToString();
			textboxDublinJulianDate.Text = JulianDates.ConvertJulianDateToDublinJulianDate(julianDate: julianDate).ToString();
			textboxCnesJulianDate.Text = JulianDates.ConvertJulianDateToCnesJulianDate(julianDate: julianDate).ToString();
			textboxCcsdsJulianDate.Text = JulianDates.ConvertJulianDateToCcsdsJulianDate(julianDate: julianDate).ToString();
			textboxLopJulianDate.Text = JulianDates.ConvertJulianDateToLopJulianDate(julianDate: julianDate).ToString();
			textboxMillenniumJulianDate.Text = JulianDates.ConvertJulianDateToMillenniumJulianDate(julianDate: julianDate).ToString();
			textboxChronologicalJulianDate.Text = JulianDates.ConvertJulianDateToChronologicalJulianDate(julianDate: julianDate).ToString();
			textboxChronologicalModifiedJulianDate.Text = JulianDates.ConvertJulianDateToChronologicalModifiedJulianDate(julianDate: julianDate).ToString();
			textboxLilianDate.Text = JulianDates.ConvertJulianDateToLilianDate(julianDate: julianDate).ToString();
			textboxRataDie.Text = JulianDates.ConvertJulianDateToRataDie(julianDate: julianDate).ToString();
			textboxMarsSolDate.Text = JulianDates.ConvertJulianDateToMarsSolDate(julianDate: julianDate).ToString();
			textboxUnixtime.Text = JulianDates.ConvertJulianDateToUnixtime(julianDate: julianDate).ToString();
		}

		private void TextboxReducedJulianDate_TextChanged(object sender, EventArgs e)
		{
		}

		private void TextboxTruncatedJulianDate_TextChanged(object sender, EventArgs e)
		{
		}

		private void TextboxDublinJulianDate_TextChanged(object sender, EventArgs e)
		{
		}

		private void TextboxCnesJulianDate_TextChanged(object sender, EventArgs e)
		{
		}

		private void TextboxCcsdsJulianDate_TextChanged(object sender, EventArgs e)
		{
		}

		private void TextboxLopJulianDate_TextChanged(object sender, EventArgs e)
		{
		}

		private void TextboxMillenniumJulianDate_TextChanged(object sender, EventArgs e)
		{
		}

		private void TextboxChronologicalJulianDate_TextChanged(object sender, EventArgs e)
		{
		}

		private void TextboxChronologicalModifiedJulianDate_TextChanged(object sender, EventArgs e)
		{
		}

		private void TextboxLilianDate_TextChanged(object sender, EventArgs e)
		{
		}

		private void TextboxRataDie_TextChanged(object sender, EventArgs e)
		{
		}

		private void TextboxMarsSolDate_TextChanged(object sender, EventArgs e)
		{
		}

		private void TextboxUnixtime_TextChanged(object sender, EventArgs e)
		{
		}

		#endregion

		#region KeyPress-Eventhandlers

		private void TextboxJulianDate_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !IsOKForDecimalTextBox(theCharacter: e.KeyChar, theTextBox: textboxJulianDate);

		private void TextboxModifiedJulianDate_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !IsOKForDecimalTextBox(theCharacter: e.KeyChar, theTextBox: textboxModifiedJulianDate);

		private void TextboxReducedJulianDate_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !IsOKForDecimalTextBox(theCharacter: e.KeyChar, theTextBox: textboxReducedJulianDate);

		private void TextboxTruncatedJulianDate_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !IsOKForDecimalTextBox(theCharacter: e.KeyChar, theTextBox: textboxTruncatedJulianDate);

		private void TextboxDublinJulianDate_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !IsOKForDecimalTextBox(theCharacter: e.KeyChar, theTextBox: textboxDublinJulianDate);

		private void TextboxCnesJulianDate_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !IsOKForDecimalTextBox(theCharacter: e.KeyChar, theTextBox: textboxCnesJulianDate);

		private void TextboxCcsdsJulianDate_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !IsOKForDecimalTextBox(theCharacter: e.KeyChar, theTextBox: textboxCcsdsJulianDate);

		private void TextboxLopJulianDate_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !IsOKForDecimalTextBox(theCharacter: e.KeyChar, theTextBox: textboxLopJulianDate);

		private void TextboxMillenniumJulianDate_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !IsOKForDecimalTextBox(theCharacter: e.KeyChar, theTextBox: textboxMillenniumJulianDate);

		private void TextboxChronologicalJulianDate_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !IsOKForDecimalTextBox(theCharacter: e.KeyChar, theTextBox: textboxChronologicalJulianDate);

		private void TextboxChronologicalModifiedJulianDate_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !IsOKForDecimalTextBox(theCharacter: e.KeyChar, theTextBox: textboxChronologicalModifiedJulianDate);

		private void TextboxLilianDate_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !IsOKForDecimalTextBox(theCharacter: e.KeyChar, theTextBox: textboxLilianDate);

		private void TextboxRataDie_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !IsOKForDecimalTextBox(theCharacter: e.KeyChar, theTextBox: textboxRataDie);

		private void TextboxMarsSolDate_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !IsOKForDecimalTextBox(theCharacter: e.KeyChar, theTextBox: textboxMarsSolDate);

		private void TextboxUnixTime_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !IsOKForDecimalTextBox(theCharacter: e.KeyChar, theTextBox: textboxUnixtime);

		#endregion

	}
}
