using System.ComponentModel;
using Julian_and_his_dates.Properties;
using Timer = System.Windows.Forms.Timer;

namespace Julian_and_his_dates
{
	partial class MainForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			components = new Container();
			ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
			toolTip = new ToolTip(components);
			labelJulianDateText = new Label();
			labelJulianDate = new Label();
			buttonRefresh = new Button();
			checkBoxAutomaticRefresh = new CheckBox();
			labelModifiedJulianDateText = new Label();
			labelModifiedJulianDate = new Label();
			labelReducedJulianDate = new Label();
			labelReducedJulianDateText = new Label();
			labelTruncatedJulianDate = new Label();
			labelTruncatedJulianDateText = new Label();
			labelDublinJulianDate = new Label();
			labelDublinJulianDateText = new Label();
			labelCnesJulianDate = new Label();
			labelCnesJulianDateText = new Label();
			labelCcsdsJulianDate = new Label();
			labelCcsdsJulianDateText = new Label();
			labelLopJulianDate = new Label();
			labelLopJulianDateText = new Label();
			labelMillenniumJulianDate = new Label();
			labelMillenniumJulianDateText = new Label();
			buttonInfo = new Button();
			buttonMinimizeToTray = new Button();
			checkBoxStayOnTop = new CheckBox();
			checkBoxDarkLightMode = new CheckBox();
			labelLocalTimeText = new Label();
			labelLocalTime = new Label();
			labelUtcTime = new Label();
			labelUtcTimeText = new Label();
			labelChronologicalJulianDate = new Label();
			labelChronologicalJulianDateText = new Label();
			labelChronologicalModifiedJulianDate = new Label();
			labelChronologicalModifiedJulianDateText = new Label();
			labelLilianDate = new Label();
			labelLilianDateText = new Label();
			labelRataDie = new Label();
			labelRataDieText = new Label();
			labelMarsSolDate = new Label();
			labelMarsSolDateText = new Label();
			labelUnixtime = new Label();
			labelUnixtimeText = new Label();
			buttonOpenJulianDateCalculator = new Button();
			buttonOpenJulianDateConverter = new Button();
			numericUpDownRefreshRate = new NumericUpDown();
			labelRefreshRateText = new Label();
			notifyIcon = new NotifyIcon(components);
			timer = new Timer(components);
			statusStrip = new StatusStrip();
			toolStripStatusLabelInformation = new ToolStripStatusLabel();
			toolStripStatusLabelAlarm = new ToolStripStatusLabel();
			toolStripStatusLabelTakeScreenshot = new ToolStripStatusLabel();
			((ISupportInitialize)numericUpDownRefreshRate).BeginInit();
			statusStrip.SuspendLayout();
			SuspendLayout();
			// 
			// labelJulianDateText
			// 
			labelJulianDateText.AccessibleDescription = "Description of the Julian Date";
			labelJulianDateText.AccessibleName = "Julian Date Description";
			labelJulianDateText.AccessibleRole = AccessibleRole.StaticText;
			labelJulianDateText.AutoEllipsis = true;
			labelJulianDateText.AutoSize = true;
			labelJulianDateText.BackColor = Color.Transparent;
			labelJulianDateText.Location = new Point(14, 40);
			labelJulianDateText.Margin = new Padding(4, 0, 4, 0);
			labelJulianDateText.Name = "labelJulianDateText";
			labelJulianDateText.Size = new Size(66, 15);
			labelJulianDateText.TabIndex = 4;
			labelJulianDateText.Text = "Julian date:";
			toolTip.SetToolTip(labelJulianDateText, "Click to show more information");
			labelJulianDateText.Click += LabelJulianDateText_Click;
			labelJulianDateText.Enter += LabelJulianDateText_Enter;
			labelJulianDateText.Leave += LabelJulianDateText_Leave;
			labelJulianDateText.MouseEnter += LabelJulianDateText_MouseEnter;
			labelJulianDateText.MouseLeave += LabelJulianDateText_MouseLeave;
			// 
			// labelJulianDate
			// 
			labelJulianDate.AccessibleDescription = "Value of the Julian Date";
			labelJulianDate.AccessibleName = "Julian Date Value";
			labelJulianDate.AccessibleRole = AccessibleRole.StaticText;
			labelJulianDate.AutoEllipsis = true;
			labelJulianDate.AutoSize = true;
			labelJulianDate.BackColor = Color.Transparent;
			labelJulianDate.Location = new Point(210, 40);
			labelJulianDate.Margin = new Padding(4, 0, 4, 0);
			labelJulianDate.Name = "labelJulianDate";
			labelJulianDate.Size = new Size(124, 15);
			labelJulianDate.TabIndex = 5;
			labelJulianDate.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelJulianDate, "Double-click to copy into the clipboard");
			labelJulianDate.DoubleClick += LabelJulianDate_DoubleClick;
			labelJulianDate.Enter += SetStatusBar_Enter;
			labelJulianDate.Leave += ClearStatusBar_Leave;
			labelJulianDate.MouseEnter += LabelJulianDate_MouseEnter;
			labelJulianDate.MouseLeave += LabelJulianDate_MouseLeave;
			// 
			// buttonRefresh
			// 
			buttonRefresh.AccessibleDescription = "If enabled you can manually refresh the dates";
			buttonRefresh.AccessibleName = "Automatic Refresh Button";
			buttonRefresh.AccessibleRole = AccessibleRole.CheckButton;
			buttonRefresh.AutoEllipsis = true;
			buttonRefresh.FlatStyle = FlatStyle.Popup;
			buttonRefresh.Location = new Point(18, 350);
			buttonRefresh.Margin = new Padding(4, 3, 4, 3);
			buttonRefresh.Name = "buttonRefresh";
			buttonRefresh.Size = new Size(115, 27);
			buttonRefresh.TabIndex = 41;
			buttonRefresh.Text = "Manual &refresh";
			toolTip.SetToolTip(buttonRefresh, "If enabled you can manually refresh the dates");
			buttonRefresh.UseVisualStyleBackColor = true;
			buttonRefresh.Click += ButtonRefresh_Click;
			buttonRefresh.Enter += SetStatusBar_Enter;
			buttonRefresh.Leave += ClearStatusBar_Leave;
			buttonRefresh.MouseEnter += SetStatusBar_Enter;
			buttonRefresh.MouseLeave += ClearStatusBar_Leave;
			// 
			// checkBoxAutomaticRefresh
			// 
			checkBoxAutomaticRefresh.AccessibleDescription = "Enable/Disable to set the automatic refresh of the dates";
			checkBoxAutomaticRefresh.AccessibleName = "Automatic Refresh Button";
			checkBoxAutomaticRefresh.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxAutomaticRefresh.Appearance = Appearance.Button;
			checkBoxAutomaticRefresh.AutoEllipsis = true;
			checkBoxAutomaticRefresh.FlatStyle = FlatStyle.Popup;
			checkBoxAutomaticRefresh.Location = new Point(18, 283);
			checkBoxAutomaticRefresh.Margin = new Padding(4, 3, 4, 3);
			checkBoxAutomaticRefresh.Name = "checkBoxAutomaticRefresh";
			checkBoxAutomaticRefresh.Size = new Size(115, 27);
			checkBoxAutomaticRefresh.TabIndex = 34;
			checkBoxAutomaticRefresh.Text = "&Automatic refresh";
			checkBoxAutomaticRefresh.TextAlign = ContentAlignment.MiddleCenter;
			toolTip.SetToolTip(checkBoxAutomaticRefresh, "Enable/Disable to set the automatic refresh of the dates");
			checkBoxAutomaticRefresh.UseVisualStyleBackColor = true;
			checkBoxAutomaticRefresh.CheckedChanged += CheckBoxAutomaticRefresh_CheckedChanged;
			checkBoxAutomaticRefresh.Enter += SetStatusBar_Enter;
			checkBoxAutomaticRefresh.Leave += ClearStatusBar_Leave;
			checkBoxAutomaticRefresh.MouseEnter += SetStatusBar_Enter;
			checkBoxAutomaticRefresh.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelModifiedJulianDateText
			// 
			labelModifiedJulianDateText.AccessibleDescription = "Description of the Modified Julian Date";
			labelModifiedJulianDateText.AccessibleName = "Modified Julian Date Description";
			labelModifiedJulianDateText.AccessibleRole = AccessibleRole.StaticText;
			labelModifiedJulianDateText.AutoEllipsis = true;
			labelModifiedJulianDateText.AutoSize = true;
			labelModifiedJulianDateText.BackColor = Color.Transparent;
			labelModifiedJulianDateText.Location = new Point(14, 55);
			labelModifiedJulianDateText.Margin = new Padding(4, 0, 4, 0);
			labelModifiedJulianDateText.Name = "labelModifiedJulianDateText";
			labelModifiedJulianDateText.Size = new Size(117, 15);
			labelModifiedJulianDateText.TabIndex = 6;
			labelModifiedJulianDateText.Text = "Modified Julian date:";
			toolTip.SetToolTip(labelModifiedJulianDateText, "Click to show more information");
			labelModifiedJulianDateText.Click += LabelModifiedJulianDateText_Click;
			labelModifiedJulianDateText.Enter += LabelModifiedJulianDateText_Enter;
			labelModifiedJulianDateText.Leave += LabelModifiedJulianDateText_Leave;
			labelModifiedJulianDateText.MouseEnter += LabelModifiedJulianDateText_MouseEnter;
			labelModifiedJulianDateText.MouseLeave += LabelModifiedJulianDateText_MouseLeave;
			// 
			// labelModifiedJulianDate
			// 
			labelModifiedJulianDate.AccessibleDescription = "Value of the Modified Julian Date";
			labelModifiedJulianDate.AccessibleName = "Modified Julian Date Value";
			labelModifiedJulianDate.AccessibleRole = AccessibleRole.StaticText;
			labelModifiedJulianDate.AutoEllipsis = true;
			labelModifiedJulianDate.AutoSize = true;
			labelModifiedJulianDate.BackColor = Color.Transparent;
			labelModifiedJulianDate.Location = new Point(210, 55);
			labelModifiedJulianDate.Margin = new Padding(4, 0, 4, 0);
			labelModifiedJulianDate.Name = "labelModifiedJulianDate";
			labelModifiedJulianDate.Size = new Size(124, 15);
			labelModifiedJulianDate.TabIndex = 7;
			labelModifiedJulianDate.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelModifiedJulianDate, "Double-click to copy into the clipboard");
			labelModifiedJulianDate.DoubleClick += LabelModifiedJulianDate_DoubleClick;
			labelModifiedJulianDate.Enter += SetStatusBar_Enter;
			labelModifiedJulianDate.Leave += ClearStatusBar_Leave;
			labelModifiedJulianDate.MouseEnter += LabelModifiedJulianDate_MouseEnter;
			labelModifiedJulianDate.MouseLeave += LabelModifiedJulianDate_MouseLeave;
			// 
			// labelReducedJulianDate
			// 
			labelReducedJulianDate.AccessibleDescription = "Value of the Reduced Julian Date";
			labelReducedJulianDate.AccessibleName = "Reduced Julian Date Value";
			labelReducedJulianDate.AccessibleRole = AccessibleRole.StaticText;
			labelReducedJulianDate.AutoEllipsis = true;
			labelReducedJulianDate.AutoSize = true;
			labelReducedJulianDate.BackColor = Color.Transparent;
			labelReducedJulianDate.Location = new Point(210, 70);
			labelReducedJulianDate.Margin = new Padding(4, 0, 4, 0);
			labelReducedJulianDate.Name = "labelReducedJulianDate";
			labelReducedJulianDate.Size = new Size(124, 15);
			labelReducedJulianDate.TabIndex = 9;
			labelReducedJulianDate.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelReducedJulianDate, "Double-click to copy into the clipboard");
			labelReducedJulianDate.DoubleClick += LabelReducedJulianDate_DoubleClick;
			labelReducedJulianDate.Enter += SetStatusBar_Enter;
			labelReducedJulianDate.Leave += ClearStatusBar_Leave;
			labelReducedJulianDate.MouseEnter += LabelReducedJulianDate_MouseEnter;
			labelReducedJulianDate.MouseLeave += LabelReducedJulianDate_MouseLeave;
			// 
			// labelReducedJulianDateText
			// 
			labelReducedJulianDateText.AccessibleDescription = "Description of the Reduced Julian Date";
			labelReducedJulianDateText.AccessibleName = "Reduced Julian Date Description";
			labelReducedJulianDateText.AccessibleRole = AccessibleRole.StaticText;
			labelReducedJulianDateText.AutoEllipsis = true;
			labelReducedJulianDateText.AutoSize = true;
			labelReducedJulianDateText.BackColor = Color.Transparent;
			labelReducedJulianDateText.Location = new Point(14, 70);
			labelReducedJulianDateText.Margin = new Padding(4, 0, 4, 0);
			labelReducedJulianDateText.Name = "labelReducedJulianDateText";
			labelReducedJulianDateText.Size = new Size(115, 15);
			labelReducedJulianDateText.TabIndex = 8;
			labelReducedJulianDateText.Text = "Reduced Julian date:";
			toolTip.SetToolTip(labelReducedJulianDateText, "Click to show more information");
			labelReducedJulianDateText.Click += LabelReducedJulianDateText_Click;
			labelReducedJulianDateText.Enter += LabelReducedJulianDateText_Enter;
			labelReducedJulianDateText.Leave += LabelReducedJulianDateText_Leave;
			labelReducedJulianDateText.MouseEnter += LabelReducedJulianDateText_MouseEnter;
			labelReducedJulianDateText.MouseLeave += LabelReducedJulianDateText_MouseLeave;
			// 
			// labelTruncatedJulianDate
			// 
			labelTruncatedJulianDate.AccessibleDescription = "Value of the Truncated Julian Date";
			labelTruncatedJulianDate.AccessibleName = "Truncated Julian Date Value";
			labelTruncatedJulianDate.AccessibleRole = AccessibleRole.StaticText;
			labelTruncatedJulianDate.AutoEllipsis = true;
			labelTruncatedJulianDate.AutoSize = true;
			labelTruncatedJulianDate.BackColor = Color.Transparent;
			labelTruncatedJulianDate.Location = new Point(210, 85);
			labelTruncatedJulianDate.Margin = new Padding(4, 0, 4, 0);
			labelTruncatedJulianDate.Name = "labelTruncatedJulianDate";
			labelTruncatedJulianDate.Size = new Size(124, 15);
			labelTruncatedJulianDate.TabIndex = 11;
			labelTruncatedJulianDate.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelTruncatedJulianDate, "Double-click to copy into the clipboard");
			labelTruncatedJulianDate.DoubleClick += LabelTruncatedJulianDate_DoubleClick;
			labelTruncatedJulianDate.Enter += SetStatusBar_Enter;
			labelTruncatedJulianDate.Leave += ClearStatusBar_Leave;
			labelTruncatedJulianDate.MouseEnter += LabelTruncatedJulianDate_MouseEnter;
			labelTruncatedJulianDate.MouseLeave += LabelTruncatedJulianDate_MouseLeave;
			// 
			// labelTruncatedJulianDateText
			// 
			labelTruncatedJulianDateText.AccessibleDescription = "Description of the Truncated Julian Date";
			labelTruncatedJulianDateText.AccessibleName = "Truncated Julian Date Description";
			labelTruncatedJulianDateText.AccessibleRole = AccessibleRole.StaticText;
			labelTruncatedJulianDateText.AutoEllipsis = true;
			labelTruncatedJulianDateText.AutoSize = true;
			labelTruncatedJulianDateText.BackColor = Color.Transparent;
			labelTruncatedJulianDateText.Location = new Point(14, 85);
			labelTruncatedJulianDateText.Margin = new Padding(4, 0, 4, 0);
			labelTruncatedJulianDateText.Name = "labelTruncatedJulianDateText";
			labelTruncatedJulianDateText.Size = new Size(121, 15);
			labelTruncatedJulianDateText.TabIndex = 10;
			labelTruncatedJulianDateText.Text = "Truncated Julian date:";
			toolTip.SetToolTip(labelTruncatedJulianDateText, "Click to show more information");
			labelTruncatedJulianDateText.Click += LabelTruncatedJulianDateText_Click;
			labelTruncatedJulianDateText.Enter += LabelTruncatedJulianDateText_Enter;
			labelTruncatedJulianDateText.Leave += LabelTruncatedJulianDateText_Leave;
			labelTruncatedJulianDateText.MouseEnter += LabelTruncatedJulianDateText_MouseEnter;
			labelTruncatedJulianDateText.MouseLeave += LabelTruncatedJulianDateText_MouseLeave;
			// 
			// labelDublinJulianDate
			// 
			labelDublinJulianDate.AccessibleDescription = "Value of the Dublin Julian Date";
			labelDublinJulianDate.AccessibleName = "Dublin Julian Date Value";
			labelDublinJulianDate.AccessibleRole = AccessibleRole.StaticText;
			labelDublinJulianDate.AutoEllipsis = true;
			labelDublinJulianDate.AutoSize = true;
			labelDublinJulianDate.BackColor = Color.Transparent;
			labelDublinJulianDate.Location = new Point(210, 100);
			labelDublinJulianDate.Margin = new Padding(4, 0, 4, 0);
			labelDublinJulianDate.Name = "labelDublinJulianDate";
			labelDublinJulianDate.Size = new Size(124, 15);
			labelDublinJulianDate.TabIndex = 13;
			labelDublinJulianDate.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelDublinJulianDate, "Double-click to copy into the clipboard");
			labelDublinJulianDate.DoubleClick += LabelDublinJulianDate_DoubleClick;
			labelDublinJulianDate.Enter += SetStatusBar_Enter;
			labelDublinJulianDate.Leave += ClearStatusBar_Leave;
			labelDublinJulianDate.MouseEnter += LabelDublinJulianDate_MouseEnter;
			labelDublinJulianDate.MouseLeave += LabelDublinJulianDate_MouseLeave;
			// 
			// labelDublinJulianDateText
			// 
			labelDublinJulianDateText.AccessibleDescription = "Description of the Dublin Julian Date";
			labelDublinJulianDateText.AccessibleName = "Dubln Julian Date Description";
			labelDublinJulianDateText.AccessibleRole = AccessibleRole.StaticText;
			labelDublinJulianDateText.AutoEllipsis = true;
			labelDublinJulianDateText.AutoSize = true;
			labelDublinJulianDateText.BackColor = Color.Transparent;
			labelDublinJulianDateText.Location = new Point(14, 100);
			labelDublinJulianDateText.Margin = new Padding(4, 0, 4, 0);
			labelDublinJulianDateText.Name = "labelDublinJulianDateText";
			labelDublinJulianDateText.Size = new Size(104, 15);
			labelDublinJulianDateText.TabIndex = 12;
			labelDublinJulianDateText.Text = "Dublin Julian date:";
			toolTip.SetToolTip(labelDublinJulianDateText, "Click to show more information");
			labelDublinJulianDateText.Click += LabelDublinJulianDateText_Click;
			labelDublinJulianDateText.Enter += LabelDublinJulianDateText_Enter;
			labelDublinJulianDateText.Leave += LabelDublinJulianDateText_Leave;
			labelDublinJulianDateText.MouseEnter += LabelDublinJulianDateText_MouseEnter;
			labelDublinJulianDateText.MouseLeave += LabelDublinJulianDateText_MouseLeave;
			// 
			// labelCnesJulianDate
			// 
			labelCnesJulianDate.AccessibleDescription = "Value of the CNES Julian Date";
			labelCnesJulianDate.AccessibleName = "CNES Julian Date Value";
			labelCnesJulianDate.AccessibleRole = AccessibleRole.StaticText;
			labelCnesJulianDate.AutoEllipsis = true;
			labelCnesJulianDate.AutoSize = true;
			labelCnesJulianDate.BackColor = Color.Transparent;
			labelCnesJulianDate.Location = new Point(210, 115);
			labelCnesJulianDate.Margin = new Padding(4, 0, 4, 0);
			labelCnesJulianDate.Name = "labelCnesJulianDate";
			labelCnesJulianDate.Size = new Size(124, 15);
			labelCnesJulianDate.TabIndex = 15;
			labelCnesJulianDate.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelCnesJulianDate, "Double-click to copy into the clipboard");
			labelCnesJulianDate.DoubleClick += LabelCnesJulianDate_DoubleClick;
			labelCnesJulianDate.Enter += SetStatusBar_Enter;
			labelCnesJulianDate.Leave += ClearStatusBar_Leave;
			labelCnesJulianDate.MouseEnter += LabelCnesJulianDate_MouseEnter;
			labelCnesJulianDate.MouseLeave += LabelCnesJulianDate_MouseLeave;
			// 
			// labelCnesJulianDateText
			// 
			labelCnesJulianDateText.AccessibleDescription = "Description of the CNES Julian Date";
			labelCnesJulianDateText.AccessibleName = "CNES Julian Date Description";
			labelCnesJulianDateText.AccessibleRole = AccessibleRole.StaticText;
			labelCnesJulianDateText.AutoEllipsis = true;
			labelCnesJulianDateText.AutoSize = true;
			labelCnesJulianDateText.BackColor = Color.Transparent;
			labelCnesJulianDateText.Location = new Point(14, 115);
			labelCnesJulianDateText.Margin = new Padding(4, 0, 4, 0);
			labelCnesJulianDateText.Name = "labelCnesJulianDateText";
			labelCnesJulianDateText.Size = new Size(98, 15);
			labelCnesJulianDateText.TabIndex = 14;
			labelCnesJulianDateText.Text = "CNES Julian date:";
			toolTip.SetToolTip(labelCnesJulianDateText, "Click to show more information");
			labelCnesJulianDateText.Click += LabelCnesJulianDateText_Click;
			labelCnesJulianDateText.Enter += LabelCnesJulianDateText_Enter;
			labelCnesJulianDateText.Leave += LabelCnesJulianDateText_Leave;
			labelCnesJulianDateText.MouseEnter += LabelCnesJulianDateText_MouseEnter;
			labelCnesJulianDateText.MouseLeave += LabelCnesJulianDateText_MouseLeave;
			// 
			// labelCcsdsJulianDate
			// 
			labelCcsdsJulianDate.AccessibleDescription = "Value of the CCSDS Julian Date";
			labelCcsdsJulianDate.AccessibleName = "CCSDS Julian Date Value";
			labelCcsdsJulianDate.AccessibleRole = AccessibleRole.StaticText;
			labelCcsdsJulianDate.AutoEllipsis = true;
			labelCcsdsJulianDate.AutoSize = true;
			labelCcsdsJulianDate.BackColor = Color.Transparent;
			labelCcsdsJulianDate.Location = new Point(210, 130);
			labelCcsdsJulianDate.Margin = new Padding(4, 0, 4, 0);
			labelCcsdsJulianDate.Name = "labelCcsdsJulianDate";
			labelCcsdsJulianDate.Size = new Size(124, 15);
			labelCcsdsJulianDate.TabIndex = 17;
			labelCcsdsJulianDate.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelCcsdsJulianDate, "Double-click to copy into the clipboard");
			labelCcsdsJulianDate.DoubleClick += LabelCcsdsJulianDate_DoubleClick;
			labelCcsdsJulianDate.Enter += SetStatusBar_Enter;
			labelCcsdsJulianDate.Leave += ClearStatusBar_Leave;
			labelCcsdsJulianDate.MouseEnter += LabelCcsdsJulianDate_MouseEnter;
			labelCcsdsJulianDate.MouseLeave += LabelCcsdsJulianDate_MouseLeave;
			// 
			// labelCcsdsJulianDateText
			// 
			labelCcsdsJulianDateText.AccessibleDescription = "Description of the CCSDS Julian Date";
			labelCcsdsJulianDateText.AccessibleName = "CCSDS Julian Date Description";
			labelCcsdsJulianDateText.AccessibleRole = AccessibleRole.StaticText;
			labelCcsdsJulianDateText.AutoEllipsis = true;
			labelCcsdsJulianDateText.AutoSize = true;
			labelCcsdsJulianDateText.BackColor = Color.Transparent;
			labelCcsdsJulianDateText.Location = new Point(14, 130);
			labelCcsdsJulianDateText.Margin = new Padding(4, 0, 4, 0);
			labelCcsdsJulianDateText.Name = "labelCcsdsJulianDateText";
			labelCcsdsJulianDateText.Size = new Size(105, 15);
			labelCcsdsJulianDateText.TabIndex = 16;
			labelCcsdsJulianDateText.Text = "CCSDS Julian date:";
			toolTip.SetToolTip(labelCcsdsJulianDateText, "Click to show more information");
			labelCcsdsJulianDateText.Click += LabelCcsdsJulianDateText_Click;
			labelCcsdsJulianDateText.Enter += LabelCcsdsJulianDateText_Enter;
			labelCcsdsJulianDateText.Leave += LabelCcsdsJulianDateText_Leave;
			labelCcsdsJulianDateText.MouseEnter += LabelCcsdsJulianDateText_MouseEnter;
			labelCcsdsJulianDateText.MouseLeave += LabelCcsdsJulianDateText_MouseLeave;
			// 
			// labelLopJulianDate
			// 
			labelLopJulianDate.AccessibleDescription = "Value of the LOP Julian Date";
			labelLopJulianDate.AccessibleName = "LOP Julian Date Value";
			labelLopJulianDate.AccessibleRole = AccessibleRole.StaticText;
			labelLopJulianDate.AutoEllipsis = true;
			labelLopJulianDate.AutoSize = true;
			labelLopJulianDate.BackColor = Color.Transparent;
			labelLopJulianDate.Location = new Point(210, 145);
			labelLopJulianDate.Margin = new Padding(4, 0, 4, 0);
			labelLopJulianDate.Name = "labelLopJulianDate";
			labelLopJulianDate.Size = new Size(124, 15);
			labelLopJulianDate.TabIndex = 19;
			labelLopJulianDate.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelLopJulianDate, "Double-click to copy into the clipboard");
			labelLopJulianDate.DoubleClick += LabelLopJulianDate_DoubleClick;
			labelLopJulianDate.Enter += SetStatusBar_Enter;
			labelLopJulianDate.Leave += ClearStatusBar_Leave;
			labelLopJulianDate.MouseEnter += LabelLopJulianDate_MouseEnter;
			labelLopJulianDate.MouseLeave += LabelLopJulianDate_MouseLeave;
			// 
			// labelLopJulianDateText
			// 
			labelLopJulianDateText.AccessibleDescription = "Description of the LOP Julian Date";
			labelLopJulianDateText.AccessibleName = "LOP Julian Date Description";
			labelLopJulianDateText.AccessibleRole = AccessibleRole.StaticText;
			labelLopJulianDateText.AutoEllipsis = true;
			labelLopJulianDateText.AutoSize = true;
			labelLopJulianDateText.BackColor = Color.Transparent;
			labelLopJulianDateText.Location = new Point(14, 145);
			labelLopJulianDateText.Margin = new Padding(4, 0, 4, 0);
			labelLopJulianDateText.Name = "labelLopJulianDateText";
			labelLopJulianDateText.Size = new Size(91, 15);
			labelLopJulianDateText.TabIndex = 18;
			labelLopJulianDateText.Text = "LOP Julian date:";
			toolTip.SetToolTip(labelLopJulianDateText, "Click to show more information");
			labelLopJulianDateText.Click += LabelLopJulianDateText_Click;
			labelLopJulianDateText.Enter += LabelLopJulianDateText_Enter;
			labelLopJulianDateText.Leave += LabelLopJulianDateText_Leave;
			labelLopJulianDateText.MouseEnter += LabelLopJulianDateText_MouseEnter;
			labelLopJulianDateText.MouseLeave += LabelLopJulianDateText_MouseLeave;
			// 
			// labelMillenniumJulianDate
			// 
			labelMillenniumJulianDate.AccessibleDescription = "Value of the Millenium Julian Date";
			labelMillenniumJulianDate.AccessibleName = "Millennium Julian Date Value";
			labelMillenniumJulianDate.AccessibleRole = AccessibleRole.StaticText;
			labelMillenniumJulianDate.AutoEllipsis = true;
			labelMillenniumJulianDate.AutoSize = true;
			labelMillenniumJulianDate.BackColor = Color.Transparent;
			labelMillenniumJulianDate.Location = new Point(210, 160);
			labelMillenniumJulianDate.Margin = new Padding(4, 0, 4, 0);
			labelMillenniumJulianDate.Name = "labelMillenniumJulianDate";
			labelMillenniumJulianDate.Size = new Size(124, 15);
			labelMillenniumJulianDate.TabIndex = 21;
			labelMillenniumJulianDate.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelMillenniumJulianDate, "Double-click to copy into the clipboard");
			labelMillenniumJulianDate.DoubleClick += LabelMillenniumJulianDate_DoubleClick;
			labelMillenniumJulianDate.Enter += SetStatusBar_Enter;
			labelMillenniumJulianDate.Leave += ClearStatusBar_Leave;
			labelMillenniumJulianDate.MouseEnter += LabelMillenniumJulianDate_MouseEnter;
			labelMillenniumJulianDate.MouseLeave += LabelMillenniumJulianDate_MouseLeave;
			// 
			// labelMillenniumJulianDateText
			// 
			labelMillenniumJulianDateText.AccessibleDescription = "Description of the Millennium Julian Date";
			labelMillenniumJulianDateText.AccessibleName = "Millennium Julian Date Description";
			labelMillenniumJulianDateText.AccessibleRole = AccessibleRole.StaticText;
			labelMillenniumJulianDateText.AutoEllipsis = true;
			labelMillenniumJulianDateText.AutoSize = true;
			labelMillenniumJulianDateText.BackColor = Color.Transparent;
			labelMillenniumJulianDateText.Location = new Point(14, 160);
			labelMillenniumJulianDateText.Margin = new Padding(4, 0, 4, 0);
			labelMillenniumJulianDateText.Name = "labelMillenniumJulianDateText";
			labelMillenniumJulianDateText.Size = new Size(130, 15);
			labelMillenniumJulianDateText.TabIndex = 20;
			labelMillenniumJulianDateText.Text = "Millennium Julian date:";
			toolTip.SetToolTip(labelMillenniumJulianDateText, "Click to show more information");
			labelMillenniumJulianDateText.Click += LabelMillenniumJulianDateText_Click;
			labelMillenniumJulianDateText.Enter += LabelMillenniumJulianDateText_Enter;
			labelMillenniumJulianDateText.Leave += LabelMillenniumJulianDateText_Leave;
			labelMillenniumJulianDateText.MouseEnter += LabelMillenniumJulianDateText_MouseEnter;
			labelMillenniumJulianDateText.MouseLeave += LabelMillenniumJulianDateText_MouseLeave;
			// 
			// buttonInfo
			// 
			buttonInfo.AccessibleDescription = "Show some information";
			buttonInfo.AccessibleName = "Information";
			buttonInfo.AccessibleRole = AccessibleRole.PushButton;
			buttonInfo.AutoEllipsis = true;
			buttonInfo.FlatStyle = FlatStyle.Popup;
			buttonInfo.Location = new Point(251, 316);
			buttonInfo.Margin = new Padding(4, 3, 4, 3);
			buttonInfo.Name = "buttonInfo";
			buttonInfo.Size = new Size(89, 27);
			buttonInfo.TabIndex = 40;
			buttonInfo.Text = "&Info";
			toolTip.SetToolTip(buttonInfo, "Show some information");
			buttonInfo.UseVisualStyleBackColor = true;
			buttonInfo.Click += ButtonInfo_Click;
			buttonInfo.Enter += SetStatusBar_Enter;
			buttonInfo.Leave += ClearStatusBar_Leave;
			buttonInfo.MouseEnter += SetStatusBar_Enter;
			buttonInfo.MouseLeave += ClearStatusBar_Leave;
			// 
			// buttonMinimizeToTray
			// 
			buttonMinimizeToTray.AccessibleDescription = "Minimize the application to the tray";
			buttonMinimizeToTray.AccessibleName = "Minimize To Tray Button";
			buttonMinimizeToTray.AccessibleRole = AccessibleRole.PushButton;
			buttonMinimizeToTray.AutoEllipsis = true;
			buttonMinimizeToTray.FlatStyle = FlatStyle.Popup;
			buttonMinimizeToTray.Location = new Point(140, 316);
			buttonMinimizeToTray.Margin = new Padding(4, 3, 4, 3);
			buttonMinimizeToTray.Name = "buttonMinimizeToTray";
			buttonMinimizeToTray.Size = new Size(104, 27);
			buttonMinimizeToTray.TabIndex = 39;
			buttonMinimizeToTray.Text = "&Minimize to tray";
			toolTip.SetToolTip(buttonMinimizeToTray, "Minimize the application to the tray");
			buttonMinimizeToTray.UseVisualStyleBackColor = true;
			buttonMinimizeToTray.Click += ButtonMinimizeToTray_Click;
			buttonMinimizeToTray.Enter += SetStatusBar_Enter;
			buttonMinimizeToTray.Leave += ClearStatusBar_Leave;
			buttonMinimizeToTray.MouseEnter += SetStatusBar_Enter;
			buttonMinimizeToTray.MouseLeave += ClearStatusBar_Leave;
			// 
			// checkBoxStayOnTop
			// 
			checkBoxStayOnTop.AccessibleDescription = "Enable/Disable to set the application on top";
			checkBoxStayOnTop.AccessibleName = "Aways On Top Button";
			checkBoxStayOnTop.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxStayOnTop.Appearance = Appearance.Button;
			checkBoxStayOnTop.AutoEllipsis = true;
			checkBoxStayOnTop.FlatStyle = FlatStyle.Popup;
			checkBoxStayOnTop.Location = new Point(140, 283);
			checkBoxStayOnTop.Margin = new Padding(4, 3, 4, 3);
			checkBoxStayOnTop.Name = "checkBoxStayOnTop";
			checkBoxStayOnTop.Size = new Size(104, 27);
			checkBoxStayOnTop.TabIndex = 35;
			checkBoxStayOnTop.Text = "Always on &top";
			checkBoxStayOnTop.TextAlign = ContentAlignment.MiddleCenter;
			toolTip.SetToolTip(checkBoxStayOnTop, "Enable/Disable to set the application on top");
			checkBoxStayOnTop.UseVisualStyleBackColor = true;
			checkBoxStayOnTop.CheckedChanged += CheckBoxStayOnTop_CheckedChanged;
			checkBoxStayOnTop.Enter += SetStatusBar_Enter;
			checkBoxStayOnTop.Leave += ClearStatusBar_Leave;
			checkBoxStayOnTop.MouseEnter += SetStatusBar_Enter;
			checkBoxStayOnTop.MouseLeave += ClearStatusBar_Leave;
			// 
			// checkBoxDarkLightMode
			// 
			checkBoxDarkLightMode.AccessibleDescription = "Enable/Disable the dark mode";
			checkBoxDarkLightMode.AccessibleName = "Dark Mode Button";
			checkBoxDarkLightMode.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxDarkLightMode.Appearance = Appearance.Button;
			checkBoxDarkLightMode.AutoEllipsis = true;
			checkBoxDarkLightMode.FlatStyle = FlatStyle.Popup;
			checkBoxDarkLightMode.Location = new Point(251, 283);
			checkBoxDarkLightMode.Margin = new Padding(4, 3, 4, 3);
			checkBoxDarkLightMode.Name = "checkBoxDarkLightMode";
			checkBoxDarkLightMode.Size = new Size(89, 27);
			checkBoxDarkLightMode.TabIndex = 36;
			checkBoxDarkLightMode.Text = "&Dark mode";
			checkBoxDarkLightMode.TextAlign = ContentAlignment.MiddleCenter;
			toolTip.SetToolTip(checkBoxDarkLightMode, "Enable/Disable the dark mode");
			checkBoxDarkLightMode.UseVisualStyleBackColor = true;
			checkBoxDarkLightMode.CheckedChanged += CheckBoxDarkLightMode_CheckedChanged;
			checkBoxDarkLightMode.Enter += SetStatusBar_Enter;
			checkBoxDarkLightMode.Leave += ClearStatusBar_Leave;
			checkBoxDarkLightMode.MouseEnter += SetStatusBar_Enter;
			checkBoxDarkLightMode.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelLocalTimeText
			// 
			labelLocalTimeText.AccessibleDescription = "Description of the local time";
			labelLocalTimeText.AccessibleName = "Local Time Description";
			labelLocalTimeText.AccessibleRole = AccessibleRole.StaticText;
			labelLocalTimeText.AutoEllipsis = true;
			labelLocalTimeText.AutoSize = true;
			labelLocalTimeText.BackColor = Color.Transparent;
			labelLocalTimeText.Location = new Point(14, 25);
			labelLocalTimeText.Margin = new Padding(4, 0, 4, 0);
			labelLocalTimeText.Name = "labelLocalTimeText";
			labelLocalTimeText.Size = new Size(65, 15);
			labelLocalTimeText.TabIndex = 2;
			labelLocalTimeText.Text = "Local time:";
			toolTip.SetToolTip(labelLocalTimeText, "Click to show more information");
			labelLocalTimeText.Click += LabelLocalTimeText_Click;
			labelLocalTimeText.Enter += LabelLocalTimeText_Enter;
			labelLocalTimeText.Leave += LabelLocalTimeText_Leave;
			labelLocalTimeText.MouseEnter += LabelLocalTimeText_MouseEnter;
			labelLocalTimeText.MouseLeave += LabelLocalTimeText_MouseLeave;
			// 
			// labelLocalTime
			// 
			labelLocalTime.AccessibleDescription = "Value of the local time";
			labelLocalTime.AccessibleName = "Local Time Value";
			labelLocalTime.AccessibleRole = AccessibleRole.StaticText;
			labelLocalTime.AutoEllipsis = true;
			labelLocalTime.AutoSize = true;
			labelLocalTime.BackColor = Color.Transparent;
			labelLocalTime.Location = new Point(210, 25);
			labelLocalTime.Margin = new Padding(4, 0, 4, 0);
			labelLocalTime.Name = "labelLocalTime";
			labelLocalTime.Size = new Size(120, 15);
			labelLocalTime.TabIndex = 3;
			labelLocalTime.Text = "[your local time here]";
			toolTip.SetToolTip(labelLocalTime, "Double-click to copy into the clipboard");
			labelLocalTime.DoubleClick += LabelLocalTime_DoubleClick;
			labelLocalTime.Enter += SetStatusBar_Enter;
			labelLocalTime.Leave += ClearStatusBar_Leave;
			labelLocalTime.MouseEnter += LabelLocalTime_MouseEnter;
			labelLocalTime.MouseLeave += LabelLocalTime_MouseLeave;
			// 
			// labelUtcTime
			// 
			labelUtcTime.AccessibleDescription = "Value of the UTC time";
			labelUtcTime.AccessibleName = "Local Time Value";
			labelUtcTime.AccessibleRole = AccessibleRole.StaticText;
			labelUtcTime.AutoEllipsis = true;
			labelUtcTime.AutoSize = true;
			labelUtcTime.BackColor = Color.Transparent;
			labelUtcTime.Location = new Point(210, 10);
			labelUtcTime.Margin = new Padding(4, 0, 4, 0);
			labelUtcTime.Name = "labelUtcTime";
			labelUtcTime.Size = new Size(116, 15);
			labelUtcTime.TabIndex = 1;
			labelUtcTime.Text = "[your UTC time here]";
			toolTip.SetToolTip(labelUtcTime, "Double-click to copy into the clipboard");
			labelUtcTime.DoubleClick += LabelUtcTime_DoubleClick;
			labelUtcTime.Enter += SetStatusBar_Enter;
			labelUtcTime.Leave += ClearStatusBar_Leave;
			labelUtcTime.MouseEnter += LabelUtcTime_MouseEnter;
			labelUtcTime.MouseLeave += LabelUtcTime_MouseLeave;
			// 
			// labelUtcTimeText
			// 
			labelUtcTimeText.AccessibleDescription = "Description of the UTC time";
			labelUtcTimeText.AccessibleName = "UTC Time Description";
			labelUtcTimeText.AccessibleRole = AccessibleRole.StaticText;
			labelUtcTimeText.AutoEllipsis = true;
			labelUtcTimeText.AutoSize = true;
			labelUtcTimeText.BackColor = Color.Transparent;
			labelUtcTimeText.Location = new Point(14, 10);
			labelUtcTimeText.Margin = new Padding(4, 0, 4, 0);
			labelUtcTimeText.Name = "labelUtcTimeText";
			labelUtcTimeText.Size = new Size(58, 15);
			labelUtcTimeText.TabIndex = 0;
			labelUtcTimeText.Text = "UTC time:";
			toolTip.SetToolTip(labelUtcTimeText, "Click to show more information");
			labelUtcTimeText.Click += LabelUtcTimeText_Click;
			labelUtcTimeText.Enter += LabelUtcTimeText_Enter;
			labelUtcTimeText.Leave += LabelUtcTimeText_Leave;
			labelUtcTimeText.MouseEnter += LabelUtcTimeText_MouseEnter;
			labelUtcTimeText.MouseLeave += LabelUtcTimeText_MouseLeave;
			// 
			// labelChronologicalJulianDate
			// 
			labelChronologicalJulianDate.AccessibleDescription = "Value of the Chronological Julian Date";
			labelChronologicalJulianDate.AccessibleName = "Chronological Julian Date Value";
			labelChronologicalJulianDate.AccessibleRole = AccessibleRole.StaticText;
			labelChronologicalJulianDate.AutoEllipsis = true;
			labelChronologicalJulianDate.AutoSize = true;
			labelChronologicalJulianDate.BackColor = Color.Transparent;
			labelChronologicalJulianDate.Location = new Point(210, 175);
			labelChronologicalJulianDate.Margin = new Padding(4, 0, 4, 0);
			labelChronologicalJulianDate.Name = "labelChronologicalJulianDate";
			labelChronologicalJulianDate.Size = new Size(124, 15);
			labelChronologicalJulianDate.TabIndex = 23;
			labelChronologicalJulianDate.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelChronologicalJulianDate, "Double-click to copy into the clipboard");
			labelChronologicalJulianDate.DoubleClick += LabelChronologicalJulianDate_DoubleClick;
			labelChronologicalJulianDate.Enter += SetStatusBar_Enter;
			labelChronologicalJulianDate.Leave += ClearStatusBar_Leave;
			labelChronologicalJulianDate.MouseEnter += LabelChronologicalJulianDate_MouseEnter;
			labelChronologicalJulianDate.MouseLeave += LabelChronologicalJulianDate_MouseLeave;
			// 
			// labelChronologicalJulianDateText
			// 
			labelChronologicalJulianDateText.AccessibleDescription = "Description of the Chronological Julian Date";
			labelChronologicalJulianDateText.AccessibleName = "Chronological Julian Date Description";
			labelChronologicalJulianDateText.AccessibleRole = AccessibleRole.StaticText;
			labelChronologicalJulianDateText.AutoEllipsis = true;
			labelChronologicalJulianDateText.AutoSize = true;
			labelChronologicalJulianDateText.BackColor = Color.Transparent;
			labelChronologicalJulianDateText.Location = new Point(14, 175);
			labelChronologicalJulianDateText.Margin = new Padding(4, 0, 4, 0);
			labelChronologicalJulianDateText.Name = "labelChronologicalJulianDateText";
			labelChronologicalJulianDateText.Size = new Size(144, 15);
			labelChronologicalJulianDateText.TabIndex = 22;
			labelChronologicalJulianDateText.Text = "Chronological Julian date:";
			toolTip.SetToolTip(labelChronologicalJulianDateText, "Click to show more information");
			labelChronologicalJulianDateText.Click += LabelChronologicalJulianDateText_Click;
			labelChronologicalJulianDateText.Enter += LabelChronologicalJulianDateText_Enter;
			labelChronologicalJulianDateText.Leave += LabelChronologicalJulianDateText_Leave;
			labelChronologicalJulianDateText.MouseEnter += LabelChronologicalJulianDateText_MouseEnter;
			labelChronologicalJulianDateText.MouseLeave += LabelChronologicalJulianDateText_MouseLeave;
			// 
			// labelChronologicalModifiedJulianDate
			// 
			labelChronologicalModifiedJulianDate.AccessibleDescription = "Value of the Chronological Modified Julian Date";
			labelChronologicalModifiedJulianDate.AccessibleName = "Chronological Modified Julian Date Value";
			labelChronologicalModifiedJulianDate.AccessibleRole = AccessibleRole.StaticText;
			labelChronologicalModifiedJulianDate.AutoEllipsis = true;
			labelChronologicalModifiedJulianDate.AutoSize = true;
			labelChronologicalModifiedJulianDate.BackColor = Color.Transparent;
			labelChronologicalModifiedJulianDate.Location = new Point(210, 190);
			labelChronologicalModifiedJulianDate.Margin = new Padding(4, 0, 4, 0);
			labelChronologicalModifiedJulianDate.Name = "labelChronologicalModifiedJulianDate";
			labelChronologicalModifiedJulianDate.Size = new Size(124, 15);
			labelChronologicalModifiedJulianDate.TabIndex = 25;
			labelChronologicalModifiedJulianDate.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelChronologicalModifiedJulianDate, "Double-click to copy into the clipboard");
			labelChronologicalModifiedJulianDate.DoubleClick += LabelChronologicalModifiedJulianDate_DoubleClick;
			labelChronologicalModifiedJulianDate.Enter += SetStatusBar_Enter;
			labelChronologicalModifiedJulianDate.Leave += ClearStatusBar_Leave;
			labelChronologicalModifiedJulianDate.MouseEnter += LabelChronologicalModifiedJulianDate_MouseEnter;
			labelChronologicalModifiedJulianDate.MouseLeave += LabelChronologicalModifiedJulianDate_MouseLeave;
			// 
			// labelChronologicalModifiedJulianDateText
			// 
			labelChronologicalModifiedJulianDateText.AccessibleDescription = "Description of the Chronological Julian Date";
			labelChronologicalModifiedJulianDateText.AccessibleName = "Chronological Modified Julian Date Description";
			labelChronologicalModifiedJulianDateText.AccessibleRole = AccessibleRole.StaticText;
			labelChronologicalModifiedJulianDateText.AutoEllipsis = true;
			labelChronologicalModifiedJulianDateText.AutoSize = true;
			labelChronologicalModifiedJulianDateText.BackColor = Color.Transparent;
			labelChronologicalModifiedJulianDateText.Location = new Point(14, 190);
			labelChronologicalModifiedJulianDateText.Margin = new Padding(4, 0, 4, 0);
			labelChronologicalModifiedJulianDateText.Name = "labelChronologicalModifiedJulianDateText";
			labelChronologicalModifiedJulianDateText.Size = new Size(195, 15);
			labelChronologicalModifiedJulianDateText.TabIndex = 24;
			labelChronologicalModifiedJulianDateText.Text = "Chronological Modified Julian date:";
			toolTip.SetToolTip(labelChronologicalModifiedJulianDateText, "Click to show more information");
			labelChronologicalModifiedJulianDateText.Click += LabelChronologicalModifiedJulianDateText_Click;
			labelChronologicalModifiedJulianDateText.Enter += LabelChronologicalModifiedJulianDateText_Enter;
			labelChronologicalModifiedJulianDateText.Leave += LabelChronologicalModifiedJulianDateText_Leave;
			labelChronologicalModifiedJulianDateText.MouseEnter += LabelChronologicalModifiedJulianDateText_MouseEnter;
			labelChronologicalModifiedJulianDateText.MouseLeave += LabelChronologicalModifiedJulianDateText_MouseLeave;
			// 
			// labelLilianDate
			// 
			labelLilianDate.AccessibleDescription = "Value of the Lilian Date";
			labelLilianDate.AccessibleName = "Lilian Date Value";
			labelLilianDate.AccessibleRole = AccessibleRole.StaticText;
			labelLilianDate.AutoEllipsis = true;
			labelLilianDate.AutoSize = true;
			labelLilianDate.BackColor = Color.Transparent;
			labelLilianDate.Location = new Point(210, 205);
			labelLilianDate.Margin = new Padding(4, 0, 4, 0);
			labelLilianDate.Name = "labelLilianDate";
			labelLilianDate.Size = new Size(124, 15);
			labelLilianDate.TabIndex = 27;
			labelLilianDate.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelLilianDate, "Double-click to copy into the clipboard");
			labelLilianDate.DoubleClick += LabelLilianDate_DoubleClick;
			labelLilianDate.Enter += SetStatusBar_Enter;
			labelLilianDate.Leave += ClearStatusBar_Leave;
			labelLilianDate.MouseEnter += LabelLilianDate_MouseEnter;
			labelLilianDate.MouseLeave += LabelLilianDate_MouseLeave;
			// 
			// labelLilianDateText
			// 
			labelLilianDateText.AccessibleDescription = "Description of the Lilian Date";
			labelLilianDateText.AccessibleName = "Lilian Date Description";
			labelLilianDateText.AccessibleRole = AccessibleRole.StaticText;
			labelLilianDateText.AutoEllipsis = true;
			labelLilianDateText.AutoSize = true;
			labelLilianDateText.BackColor = Color.Transparent;
			labelLilianDateText.Location = new Point(14, 205);
			labelLilianDateText.Margin = new Padding(4, 0, 4, 0);
			labelLilianDateText.Name = "labelLilianDateText";
			labelLilianDateText.Size = new Size(65, 15);
			labelLilianDateText.TabIndex = 26;
			labelLilianDateText.Text = "Lilian Date:";
			toolTip.SetToolTip(labelLilianDateText, "Click to show more information");
			labelLilianDateText.Click += LabelLilianDateText_Click;
			labelLilianDateText.Enter += LabelLilianDateText_Enter;
			labelLilianDateText.Leave += LabelLilianDateText_Leave;
			labelLilianDateText.MouseEnter += LabelLilianDateText_MouseEnter;
			labelLilianDateText.MouseLeave += LabelLilianDateText_MouseLeave;
			// 
			// labelRataDie
			// 
			labelRataDie.AccessibleDescription = "Value of the Rata Die";
			labelRataDie.AccessibleName = "Rata Die Value";
			labelRataDie.AccessibleRole = AccessibleRole.StaticText;
			labelRataDie.AutoEllipsis = true;
			labelRataDie.AutoSize = true;
			labelRataDie.BackColor = Color.Transparent;
			labelRataDie.Location = new Point(210, 220);
			labelRataDie.Margin = new Padding(4, 0, 4, 0);
			labelRataDie.Name = "labelRataDie";
			labelRataDie.Size = new Size(124, 15);
			labelRataDie.TabIndex = 29;
			labelRataDie.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelRataDie, "Double-click to copy into the clipboard");
			labelRataDie.DoubleClick += LabelRataDie_DoubleClick;
			labelRataDie.Enter += SetStatusBar_Enter;
			labelRataDie.Leave += ClearStatusBar_Leave;
			labelRataDie.MouseEnter += LabelRataDie_MouseEnter;
			labelRataDie.MouseLeave += LabelRataDie_MouseLeave;
			// 
			// labelRataDieText
			// 
			labelRataDieText.AccessibleDescription = "Description of the Rata Die";
			labelRataDieText.AccessibleName = "Rata Die Description";
			labelRataDieText.AccessibleRole = AccessibleRole.StaticText;
			labelRataDieText.AutoEllipsis = true;
			labelRataDieText.AutoSize = true;
			labelRataDieText.BackColor = Color.Transparent;
			labelRataDieText.Location = new Point(14, 220);
			labelRataDieText.Margin = new Padding(4, 0, 4, 0);
			labelRataDieText.Name = "labelRataDieText";
			labelRataDieText.Size = new Size(53, 15);
			labelRataDieText.TabIndex = 28;
			labelRataDieText.Text = "Rata Die:";
			toolTip.SetToolTip(labelRataDieText, "Click to show more information");
			labelRataDieText.Click += LabelRataDieText_Click;
			labelRataDieText.Enter += LabelRataDieText_Enter;
			labelRataDieText.Leave += LabelRataDieText_Leave;
			labelRataDieText.MouseEnter += LabelRataDieText_MouseEnter;
			labelRataDieText.MouseLeave += LabelRataDieText_MouseLeave;
			// 
			// labelMarsSolDate
			// 
			labelMarsSolDate.AccessibleDescription = "Value of the Mars Sol Date";
			labelMarsSolDate.AccessibleName = "Mars Sol Date Value";
			labelMarsSolDate.AccessibleRole = AccessibleRole.StaticText;
			labelMarsSolDate.AutoEllipsis = true;
			labelMarsSolDate.AutoSize = true;
			labelMarsSolDate.BackColor = Color.Transparent;
			labelMarsSolDate.Location = new Point(210, 235);
			labelMarsSolDate.Margin = new Padding(4, 0, 4, 0);
			labelMarsSolDate.Name = "labelMarsSolDate";
			labelMarsSolDate.Size = new Size(124, 15);
			labelMarsSolDate.TabIndex = 31;
			labelMarsSolDate.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelMarsSolDate, "Double-click to copy into the clipboard");
			labelMarsSolDate.DoubleClick += LabelMarsSolDate_DoubleClick;
			labelMarsSolDate.Enter += SetStatusBar_Enter;
			labelMarsSolDate.Leave += ClearStatusBar_Leave;
			labelMarsSolDate.MouseEnter += LabelMarsSolDate_MouseEnter;
			labelMarsSolDate.MouseLeave += LabelMarsSolDate_MouseLeave;
			// 
			// labelMarsSolDateText
			// 
			labelMarsSolDateText.AccessibleDescription = "Description of the Mars Sol Date";
			labelMarsSolDateText.AccessibleName = "Mars Sol Date Description";
			labelMarsSolDateText.AccessibleRole = AccessibleRole.StaticText;
			labelMarsSolDateText.AutoEllipsis = true;
			labelMarsSolDateText.AutoSize = true;
			labelMarsSolDateText.BackColor = Color.Transparent;
			labelMarsSolDateText.Location = new Point(14, 235);
			labelMarsSolDateText.Margin = new Padding(4, 0, 4, 0);
			labelMarsSolDateText.Name = "labelMarsSolDateText";
			labelMarsSolDateText.Size = new Size(82, 15);
			labelMarsSolDateText.TabIndex = 30;
			labelMarsSolDateText.Text = "Mars Sol Date:";
			toolTip.SetToolTip(labelMarsSolDateText, "Click to show more information");
			labelMarsSolDateText.Click += LabelMarsSolDateText_Click;
			labelMarsSolDateText.Enter += LabelMarsSolDateText_Enter;
			labelMarsSolDateText.Leave += LabelMarsSolDateText_Leave;
			labelMarsSolDateText.MouseEnter += LabelMarsSolDateText_MouseEnter;
			labelMarsSolDateText.MouseLeave += LabelMarsSolDateText_MouseLeave;
			// 
			// labelUnixtime
			// 
			labelUnixtime.AccessibleDescription = "Value of the Unix Time";
			labelUnixtime.AccessibleName = "Unix Time Value";
			labelUnixtime.AccessibleRole = AccessibleRole.StaticText;
			labelUnixtime.AutoEllipsis = true;
			labelUnixtime.AutoSize = true;
			labelUnixtime.BackColor = Color.Transparent;
			labelUnixtime.Location = new Point(210, 250);
			labelUnixtime.Margin = new Padding(4, 0, 4, 0);
			labelUnixtime.Name = "labelUnixtime";
			labelUnixtime.Size = new Size(124, 15);
			labelUnixtime.TabIndex = 33;
			labelUnixtime.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelUnixtime, "Double-click to copy into the clipboard");
			labelUnixtime.DoubleClick += LabelUnixTime_DoubleClick;
			labelUnixtime.Enter += SetStatusBar_Enter;
			labelUnixtime.Leave += ClearStatusBar_Leave;
			labelUnixtime.MouseEnter += LabelUnixTime_MouseEnter;
			labelUnixtime.MouseLeave += LabelUnixTime_MouseLeave;
			// 
			// labelUnixtimeText
			// 
			labelUnixtimeText.AccessibleDescription = "Description of the Unix time";
			labelUnixtimeText.AccessibleName = "Unix Time Description";
			labelUnixtimeText.AccessibleRole = AccessibleRole.StaticText;
			labelUnixtimeText.AutoEllipsis = true;
			labelUnixtimeText.AutoSize = true;
			labelUnixtimeText.BackColor = Color.Transparent;
			labelUnixtimeText.Location = new Point(14, 250);
			labelUnixtimeText.Margin = new Padding(4, 0, 4, 0);
			labelUnixtimeText.Name = "labelUnixtimeText";
			labelUnixtimeText.Size = new Size(63, 15);
			labelUnixtimeText.TabIndex = 32;
			labelUnixtimeText.Text = "Unix Time:";
			toolTip.SetToolTip(labelUnixtimeText, "Click to show more information");
			labelUnixtimeText.Click += LabelUnixTimeText_Click;
			labelUnixtimeText.Enter += LabelUnixTimeText_Enter;
			labelUnixtimeText.Leave += LabelUnixTimeText_Leave;
			labelUnixtimeText.MouseEnter += LabelUnixTimeText_MouseEnter;
			labelUnixtimeText.MouseLeave += LabelUnixTimeText_MouseLeave;
			// 
			// buttonOpenJulianDateCalculator
			// 
			buttonOpenJulianDateCalculator.AccessibleDescription = "Open the Julian Dates Calculator";
			buttonOpenJulianDateCalculator.AccessibleName = "Julian Date Calculator";
			buttonOpenJulianDateCalculator.AccessibleRole = AccessibleRole.PushButton;
			buttonOpenJulianDateCalculator.AutoEllipsis = true;
			buttonOpenJulianDateCalculator.FlatStyle = FlatStyle.Popup;
			buttonOpenJulianDateCalculator.Location = new Point(140, 350);
			buttonOpenJulianDateCalculator.Margin = new Padding(4, 3, 4, 3);
			buttonOpenJulianDateCalculator.Name = "buttonOpenJulianDateCalculator";
			buttonOpenJulianDateCalculator.Size = new Size(104, 27);
			buttonOpenJulianDateCalculator.TabIndex = 42;
			buttonOpenJulianDateCalculator.Text = "JD &calculator";
			toolTip.SetToolTip(buttonOpenJulianDateCalculator, "Open the Julian Dates Calculator");
			buttonOpenJulianDateCalculator.UseVisualStyleBackColor = true;
			buttonOpenJulianDateCalculator.Click += ButtonOpenJulianDateCalculator_Click;
			buttonOpenJulianDateCalculator.Enter += SetStatusBar_Enter;
			buttonOpenJulianDateCalculator.Leave += ClearStatusBar_Leave;
			buttonOpenJulianDateCalculator.MouseEnter += SetStatusBar_Enter;
			buttonOpenJulianDateCalculator.MouseLeave += ClearStatusBar_Leave;
			// 
			// buttonOpenJulianDateConverter
			// 
			buttonOpenJulianDateConverter.AccessibleDescription = "Open the Julian Dates Converter";
			buttonOpenJulianDateConverter.AccessibleName = "Julian Date Converter";
			buttonOpenJulianDateConverter.AccessibleRole = AccessibleRole.PushButton;
			buttonOpenJulianDateConverter.AutoEllipsis = true;
			buttonOpenJulianDateConverter.FlatStyle = FlatStyle.Popup;
			buttonOpenJulianDateConverter.Location = new Point(251, 350);
			buttonOpenJulianDateConverter.Margin = new Padding(4, 3, 4, 3);
			buttonOpenJulianDateConverter.Name = "buttonOpenJulianDateConverter";
			buttonOpenJulianDateConverter.Size = new Size(89, 27);
			buttonOpenJulianDateConverter.TabIndex = 43;
			buttonOpenJulianDateConverter.Text = "JD con&verter";
			toolTip.SetToolTip(buttonOpenJulianDateConverter, "Open the Julian Dates Converter");
			buttonOpenJulianDateConverter.UseVisualStyleBackColor = true;
			buttonOpenJulianDateConverter.Visible = false;
			buttonOpenJulianDateConverter.Click += ButtonOpenJulianDateConverter_Click;
			buttonOpenJulianDateConverter.Enter += SetStatusBar_Enter;
			buttonOpenJulianDateConverter.Leave += ClearStatusBar_Leave;
			buttonOpenJulianDateConverter.MouseEnter += SetStatusBar_Enter;
			buttonOpenJulianDateConverter.MouseLeave += ClearStatusBar_Leave;
			// 
			// numericUpDownRefreshRate
			// 
			numericUpDownRefreshRate.AccessibleDescription = "Refresh rate in milliseconds";
			numericUpDownRefreshRate.AccessibleName = "Refresh Rate Button";
			numericUpDownRefreshRate.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownRefreshRate.BackColor = SystemColors.Window;
			numericUpDownRefreshRate.BorderStyle = BorderStyle.FixedSingle;
			numericUpDownRefreshRate.Location = new Point(89, 317);
			numericUpDownRefreshRate.Margin = new Padding(4, 3, 4, 3);
			numericUpDownRefreshRate.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
			numericUpDownRefreshRate.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownRefreshRate.Name = "numericUpDownRefreshRate";
			numericUpDownRefreshRate.Size = new Size(47, 23);
			numericUpDownRefreshRate.TabIndex = 38;
			numericUpDownRefreshRate.TextAlign = HorizontalAlignment.Center;
			toolTip.SetToolTip(numericUpDownRefreshRate, "Refresh rate in milliseconds");
			numericUpDownRefreshRate.Value = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownRefreshRate.ValueChanged += NumericUpDownRefreshRate_ValueChanged;
			numericUpDownRefreshRate.Enter += SetStatusBar_Enter;
			numericUpDownRefreshRate.Leave += ClearStatusBar_Leave;
			// 
			// labelRefreshRateText
			// 
			labelRefreshRateText.AccessibleDescription = "Refresh rate in milliseconds";
			labelRefreshRateText.AccessibleName = "Refresh Rate Label";
			labelRefreshRateText.AccessibleRole = AccessibleRole.StaticText;
			labelRefreshRateText.AutoEllipsis = true;
			labelRefreshRateText.AutoSize = true;
			labelRefreshRateText.BackColor = Color.Transparent;
			labelRefreshRateText.Location = new Point(18, 320);
			labelRefreshRateText.Margin = new Padding(4, 0, 4, 0);
			labelRefreshRateText.Name = "labelRefreshRateText";
			labelRefreshRateText.Size = new Size(66, 15);
			labelRefreshRateText.TabIndex = 37;
			labelRefreshRateText.Text = "refresh rate";
			toolTip.SetToolTip(labelRefreshRateText, "Refresh rate in milliseconds");
			labelRefreshRateText.DoubleClick += LabelRefreshRateText_DoubleClick;
			labelRefreshRateText.Enter += SetStatusBar_Enter;
			labelRefreshRateText.Leave += ClearStatusBar_Leave;
			labelRefreshRateText.MouseEnter += SetStatusBar_Enter;
			labelRefreshRateText.MouseLeave += ClearStatusBar_Leave;
			// 
			// notifyIcon
			// 
			notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
			notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
			notifyIcon.Text = "Julian an his dates";
			notifyIcon.Visible = true;
			notifyIcon.MouseDoubleClick += NotifyIcon_MouseDoubleClick;
			// 
			// timer
			// 
			timer.Enabled = true;
			timer.Interval = 20;
			timer.Tick += Timer_Tick;
			// 
			// statusStrip
			// 
			statusStrip.AccessibleDescription = "Statusbar";
			statusStrip.AccessibleName = "Statusbar";
			statusStrip.AccessibleRole = AccessibleRole.StatusBar;
			statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelInformation, toolStripStatusLabelAlarm, toolStripStatusLabelTakeScreenshot });
			statusStrip.Location = new Point(0, 393);
			statusStrip.Name = "statusStrip";
			statusStrip.Padding = new Padding(1, 0, 16, 0);
			statusStrip.ShowItemToolTips = true;
			statusStrip.Size = new Size(354, 22);
			statusStrip.SizingGrip = false;
			statusStrip.TabIndex = 44;
			statusStrip.TabStop = true;
			statusStrip.Text = "statusStrip";
			statusStrip.Enter += SetStatusBar_Enter;
			statusStrip.Leave += ClearStatusBar_Leave;
			statusStrip.MouseEnter += SetStatusBar_Enter;
			statusStrip.MouseLeave += ClearStatusBar_Leave;
			// 
			// toolStripStatusLabelInformation
			// 
			toolStripStatusLabelInformation.AccessibleDescription = "Show some information";
			toolStripStatusLabelInformation.AccessibleName = "Information Label";
			toolStripStatusLabelInformation.AccessibleRole = AccessibleRole.StaticText;
			toolStripStatusLabelInformation.AutoToolTip = true;
			toolStripStatusLabelInformation.Image = Resources.information;
			toolStripStatusLabelInformation.Margin = new Padding(2, 3, 2, 3);
			toolStripStatusLabelInformation.Name = "toolStripStatusLabelInformation";
			toolStripStatusLabelInformation.Size = new Size(86, 16);
			toolStripStatusLabelInformation.Text = "Information";
			toolStripStatusLabelInformation.MouseEnter += SetStatusBar_Enter;
			toolStripStatusLabelInformation.MouseLeave += ClearStatusBar_Leave;
			// 
			// toolStripStatusLabelAlarm
			// 
			toolStripStatusLabelAlarm.AccessibleDescription = "Click to set alarm on/off";
			toolStripStatusLabelAlarm.AccessibleName = "Alarm Label";
			toolStripStatusLabelAlarm.AccessibleRole = AccessibleRole.StaticText;
			toolStripStatusLabelAlarm.AutoToolTip = true;
			toolStripStatusLabelAlarm.Image = Resources.sound;
			toolStripStatusLabelAlarm.Margin = new Padding(2, 3, 2, 3);
			toolStripStatusLabelAlarm.Name = "toolStripStatusLabelAlarm";
			toolStripStatusLabelAlarm.Size = new Size(55, 16);
			toolStripStatusLabelAlarm.Text = "Alarm";
			toolStripStatusLabelAlarm.ToolTipText = "Click to set alarm on/off";
			toolStripStatusLabelAlarm.Click += ToolStripStatusLabelAlarm_Click;
			toolStripStatusLabelAlarm.MouseEnter += SetStatusBar_Enter;
			toolStripStatusLabelAlarm.MouseLeave += ClearStatusBar_Leave;
			// 
			// toolStripStatusLabelTakeScreenshot
			// 
			toolStripStatusLabelTakeScreenshot.AccessibleDescription = "Take a screenshot";
			toolStripStatusLabelTakeScreenshot.AccessibleName = "Screeshot Label";
			toolStripStatusLabelTakeScreenshot.AccessibleRole = AccessibleRole.StaticText;
			toolStripStatusLabelTakeScreenshot.AutoToolTip = true;
			toolStripStatusLabelTakeScreenshot.Image = Resources.camera;
			toolStripStatusLabelTakeScreenshot.Margin = new Padding(2, 3, 2, 3);
			toolStripStatusLabelTakeScreenshot.Name = "toolStripStatusLabelTakeScreenshot";
			toolStripStatusLabelTakeScreenshot.Size = new Size(81, 16);
			toolStripStatusLabelTakeScreenshot.Text = "Screenshot";
			toolStripStatusLabelTakeScreenshot.ToolTipText = "Click to take a screenshot";
			toolStripStatusLabelTakeScreenshot.Click += ToolStripStatusLabelTakeScreenshot_Click;
			toolStripStatusLabelTakeScreenshot.MouseEnter += SetStatusBar_Enter;
			toolStripStatusLabelTakeScreenshot.MouseLeave += ClearStatusBar_Leave;
			// 
			// MainForm
			// 
			AccessibleDescription = "Application";
			AccessibleName = "Application";
			AccessibleRole = AccessibleRole.Application;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(354, 415);
			Controls.Add(statusStrip);
			Controls.Add(labelRefreshRateText);
			Controls.Add(numericUpDownRefreshRate);
			Controls.Add(buttonOpenJulianDateConverter);
			Controls.Add(buttonOpenJulianDateCalculator);
			Controls.Add(labelUnixtime);
			Controls.Add(labelUnixtimeText);
			Controls.Add(labelMarsSolDate);
			Controls.Add(labelMarsSolDateText);
			Controls.Add(labelRataDie);
			Controls.Add(labelRataDieText);
			Controls.Add(labelLilianDate);
			Controls.Add(labelLilianDateText);
			Controls.Add(labelChronologicalModifiedJulianDate);
			Controls.Add(labelChronologicalModifiedJulianDateText);
			Controls.Add(labelChronologicalJulianDate);
			Controls.Add(labelChronologicalJulianDateText);
			Controls.Add(labelUtcTime);
			Controls.Add(labelUtcTimeText);
			Controls.Add(labelLocalTime);
			Controls.Add(labelLocalTimeText);
			Controls.Add(checkBoxDarkLightMode);
			Controls.Add(checkBoxStayOnTop);
			Controls.Add(buttonMinimizeToTray);
			Controls.Add(buttonInfo);
			Controls.Add(labelMillenniumJulianDate);
			Controls.Add(labelMillenniumJulianDateText);
			Controls.Add(labelLopJulianDate);
			Controls.Add(labelLopJulianDateText);
			Controls.Add(labelCcsdsJulianDate);
			Controls.Add(labelCcsdsJulianDateText);
			Controls.Add(labelCnesJulianDate);
			Controls.Add(labelCnesJulianDateText);
			Controls.Add(labelDublinJulianDate);
			Controls.Add(labelDublinJulianDateText);
			Controls.Add(labelTruncatedJulianDate);
			Controls.Add(labelTruncatedJulianDateText);
			Controls.Add(labelReducedJulianDate);
			Controls.Add(labelReducedJulianDateText);
			Controls.Add(labelModifiedJulianDate);
			Controls.Add(labelModifiedJulianDateText);
			Controls.Add(checkBoxAutomaticRefresh);
			Controls.Add(buttonRefresh);
			Controls.Add(labelJulianDate);
			Controls.Add(labelJulianDateText);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Julian and his dates";
			FormClosing += MainForm_FormClosing;
			Load += MainForm_Load;
			((ISupportInitialize)numericUpDownRefreshRate).EndInit();
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ToolTip toolTip;
		private NotifyIcon notifyIcon;
		private Timer timer;
		private Label labelJulianDateText;
		private Label labelJulianDate;
		private Button buttonRefresh;
		private CheckBox checkBoxAutomaticRefresh;
		private Label labelModifiedJulianDateText;
		private Label labelModifiedJulianDate;
		private Label labelReducedJulianDate;
		private Label labelReducedJulianDateText;
		private Label labelTruncatedJulianDate;
		private Label labelTruncatedJulianDateText;
		private Label labelDublinJulianDate;
		private Label labelDublinJulianDateText;
		private Label labelCnesJulianDate;
		private Label labelCnesJulianDateText;
		private Label labelCcsdsJulianDate;
		private Label labelCcsdsJulianDateText;
		private Label labelLopJulianDate;
		private Label labelLopJulianDateText;
		private Label labelMillenniumJulianDate;
		private Label labelMillenniumJulianDateText;
		private Button buttonInfo;
		private Button buttonMinimizeToTray;
		private CheckBox checkBoxStayOnTop;
		private CheckBox checkBoxDarkLightMode;
		private Label labelLocalTimeText;
		private Label labelLocalTime;
		private Label labelUtcTime;
		private Label labelUtcTimeText;
		private Label labelChronologicalJulianDate;
		private Label labelChronologicalJulianDateText;
		private Label labelChronologicalModifiedJulianDate;
		private Label labelChronologicalModifiedJulianDateText;
		private Label labelLilianDate;
		private Label labelLilianDateText;
		private Label labelRataDie;
		private Label labelRataDieText;
		private Label labelMarsSolDate;
		private Label labelMarsSolDateText;
		private Label labelUnixtime;
		private Label labelUnixtimeText;
		private Button buttonOpenJulianDateCalculator;
		private Button buttonOpenJulianDateConverter;
		private NumericUpDown numericUpDownRefreshRate;
		private Label labelRefreshRateText;
		private StatusStrip statusStrip;
		private ToolStripStatusLabel toolStripStatusLabelInformation;
		private ToolStripStatusLabel toolStripStatusLabelAlarm;
		private ToolStripStatusLabel toolStripStatusLabelTakeScreenshot;

	}
}

