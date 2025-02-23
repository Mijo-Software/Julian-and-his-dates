namespace Julian_and_his_dates
{
	partial class JulianDateCalculatorForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JulianDateCalculatorForm));
			labelUnixtime = new Label();
			labelUnixtimeText = new Label();
			labelMarsSolDate = new Label();
			labelMarsSolDateText = new Label();
			labelRataDie = new Label();
			labelRataDieText = new Label();
			labelLilianDate = new Label();
			labelLilianDateText = new Label();
			labelChronologicalModifiedJulianDate = new Label();
			labelChronologicalModifiedJulianDateText = new Label();
			labelChronologicalJulianDate = new Label();
			labelChronologicalJulianDateText = new Label();
			labelUtcTime = new Label();
			labelUtcTimeText = new Label();
			labelLocalTime = new Label();
			labelLocalTimeText = new Label();
			labelMillenniumJulianDate = new Label();
			labelMillenniumJulianDateText = new Label();
			labelLopJulianDate = new Label();
			labelLopJulianDateText = new Label();
			labelCcsdsJulianDate = new Label();
			labelCcsdsJulianDateText = new Label();
			labelCnesJulianDate = new Label();
			labelCnesJulianDateText = new Label();
			labelDublinJulianDate = new Label();
			labelDublinJulianDateText = new Label();
			labelTruncatedJulianDate = new Label();
			labelTruncatedJulianDateText = new Label();
			labelReducedJulianDate = new Label();
			labelReducedJulianDateText = new Label();
			labelModifiedJulianDate = new Label();
			labelModifiedJulianDateText = new Label();
			labelJulianDate = new Label();
			labelJulianDateText = new Label();
			toolTip = new ToolTip(components);
			dateTimePicker = new DateTimePicker();
			checkBoxIgnoreDecimals = new CheckBox();
			statusStrip = new StatusStrip();
			toolStripStatusLabelInformation = new ToolStripStatusLabel();
			toolStripStatusLabelTakeScreenshot = new ToolStripStatusLabel();
			statusStrip.SuspendLayout();
			SuspendLayout();
			// 
			// labelUnixtime
			// 
			labelUnixtime.AccessibleDescription = "Value of the Unix Time";
			labelUnixtime.AccessibleName = "Unix Time Value";
			labelUnixtime.AccessibleRole = AccessibleRole.StaticText;
			labelUnixtime.AutoEllipsis = true;
			labelUnixtime.AutoSize = true;
			labelUnixtime.BackColor = Color.Transparent;
			labelUnixtime.Location = new Point(210, 331);
			labelUnixtime.Margin = new Padding(4, 0, 4, 0);
			labelUnixtime.Name = "labelUnixtime";
			labelUnixtime.Size = new Size(124, 15);
			labelUnixtime.TabIndex = 35;
			labelUnixtime.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelUnixtime, "Double-click to copy into the clipboard");
			labelUnixtime.DoubleClick += LabelUnixtime_DoubleClick;
			labelUnixtime.Enter += LabelUnixtime_Enter;
			labelUnixtime.Leave += LabelUnixtime_Leave;
			labelUnixtime.MouseEnter += LabelUnixtime_MouseEnter;
			labelUnixtime.MouseLeave += LabelUnixtime_MouseLeave;
			// 
			// labelUnixtimeText
			// 
			labelUnixtimeText.AccessibleDescription = "Description of the Unix time";
			labelUnixtimeText.AccessibleName = "Unix Time Description";
			labelUnixtimeText.AccessibleRole = AccessibleRole.StaticText;
			labelUnixtimeText.AutoEllipsis = true;
			labelUnixtimeText.AutoSize = true;
			labelUnixtimeText.BackColor = Color.Transparent;
			labelUnixtimeText.Location = new Point(14, 331);
			labelUnixtimeText.Margin = new Padding(4, 0, 4, 0);
			labelUnixtimeText.Name = "labelUnixtimeText";
			labelUnixtimeText.Size = new Size(63, 15);
			labelUnixtimeText.TabIndex = 34;
			labelUnixtimeText.Text = "Unix Time:";
			toolTip.SetToolTip(labelUnixtimeText, "Click to show more information");
			labelUnixtimeText.Click += LabelUnixtimeText_Click;
			labelUnixtimeText.Enter += LabelUnixtimeText_Enter;
			labelUnixtimeText.Leave += LabelUnixtimeText_Leave;
			labelUnixtimeText.MouseEnter += LabelUnixtimeText_MouseEnter;
			labelUnixtimeText.MouseLeave += LabelUnixtimeText_MouseLeave;
			// 
			// labelMarsSolDate
			// 
			labelMarsSolDate.AccessibleDescription = "Value of the Mars Sol Date";
			labelMarsSolDate.AccessibleName = "Mars Sol Date Value";
			labelMarsSolDate.AccessibleRole = AccessibleRole.StaticText;
			labelMarsSolDate.AutoEllipsis = true;
			labelMarsSolDate.AutoSize = true;
			labelMarsSolDate.BackColor = Color.Transparent;
			labelMarsSolDate.Location = new Point(210, 316);
			labelMarsSolDate.Margin = new Padding(4, 0, 4, 0);
			labelMarsSolDate.Name = "labelMarsSolDate";
			labelMarsSolDate.Size = new Size(124, 15);
			labelMarsSolDate.TabIndex = 33;
			labelMarsSolDate.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelMarsSolDate, "Double-click to copy into the clipboard");
			labelMarsSolDate.DoubleClick += LabelMarsSolDate_DoubleClick;
			labelMarsSolDate.Enter += LabelMarsSolDate_Enter;
			labelMarsSolDate.Leave += LabelMarsSolDate_Leave;
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
			labelMarsSolDateText.Location = new Point(14, 316);
			labelMarsSolDateText.Margin = new Padding(4, 0, 4, 0);
			labelMarsSolDateText.Name = "labelMarsSolDateText";
			labelMarsSolDateText.Size = new Size(82, 15);
			labelMarsSolDateText.TabIndex = 32;
			labelMarsSolDateText.Text = "Mars Sol Date:";
			toolTip.SetToolTip(labelMarsSolDateText, "Click to show more information");
			labelMarsSolDateText.Click += LabelMarsSolDateText_Click;
			labelMarsSolDateText.Enter += LabelMarsSolDateText_Enter;
			labelMarsSolDateText.Leave += LabelMarsSolDateText_Leave;
			labelMarsSolDateText.MouseEnter += LabelMarsSolDateText_MouseEnter;
			labelMarsSolDateText.MouseLeave += LabelMarsSolDateText_MouseLeave;
			// 
			// labelRataDie
			// 
			labelRataDie.AccessibleDescription = "Value of the Rata Die";
			labelRataDie.AccessibleName = "Rata Die Value";
			labelRataDie.AccessibleRole = AccessibleRole.StaticText;
			labelRataDie.AutoEllipsis = true;
			labelRataDie.AutoSize = true;
			labelRataDie.BackColor = Color.Transparent;
			labelRataDie.Location = new Point(210, 301);
			labelRataDie.Margin = new Padding(4, 0, 4, 0);
			labelRataDie.Name = "labelRataDie";
			labelRataDie.Size = new Size(124, 15);
			labelRataDie.TabIndex = 31;
			labelRataDie.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelRataDie, "Double-click to copy into the clipboard");
			labelRataDie.DoubleClick += LabelRataDie_DoubleClick;
			labelRataDie.Enter += LabelRataDie_Enter;
			labelRataDie.Leave += LabelRataDie_Leave;
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
			labelRataDieText.Location = new Point(14, 301);
			labelRataDieText.Margin = new Padding(4, 0, 4, 0);
			labelRataDieText.Name = "labelRataDieText";
			labelRataDieText.Size = new Size(53, 15);
			labelRataDieText.TabIndex = 30;
			labelRataDieText.Text = "Rata Die:";
			toolTip.SetToolTip(labelRataDieText, "Click to show more information");
			labelRataDieText.Click += LabelRataDieText_Click;
			labelRataDieText.Enter += LabelRataDieText_Enter;
			labelRataDieText.Leave += LabelRataDieText_Leave;
			labelRataDieText.MouseEnter += LabelRataDieText_MouseEnter;
			labelRataDieText.MouseLeave += LabelRataDieText_MouseLeave;
			// 
			// labelLilianDate
			// 
			labelLilianDate.AccessibleDescription = "Value of the Lilian Date";
			labelLilianDate.AccessibleName = "Lilian Date Value";
			labelLilianDate.AccessibleRole = AccessibleRole.StaticText;
			labelLilianDate.AutoEllipsis = true;
			labelLilianDate.AutoSize = true;
			labelLilianDate.BackColor = Color.Transparent;
			labelLilianDate.Location = new Point(210, 286);
			labelLilianDate.Margin = new Padding(4, 0, 4, 0);
			labelLilianDate.Name = "labelLilianDate";
			labelLilianDate.Size = new Size(124, 15);
			labelLilianDate.TabIndex = 29;
			labelLilianDate.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelLilianDate, "Double-click to copy into the clipboard");
			labelLilianDate.DoubleClick += LabelLilianDate_DoubleClick;
			labelLilianDate.Enter += LabelLilianDate_Enter;
			labelLilianDate.Leave += LabelLilianDate_Leave;
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
			labelLilianDateText.Location = new Point(14, 286);
			labelLilianDateText.Margin = new Padding(4, 0, 4, 0);
			labelLilianDateText.Name = "labelLilianDateText";
			labelLilianDateText.Size = new Size(65, 15);
			labelLilianDateText.TabIndex = 28;
			labelLilianDateText.Text = "Lilian Date:";
			toolTip.SetToolTip(labelLilianDateText, "Click to show more information");
			labelLilianDateText.Click += LabelLilianDateText_Click;
			labelLilianDateText.Enter += LabelLilianDateText_Enter;
			labelLilianDateText.Leave += LabelLilianDateText_Leave;
			labelLilianDateText.MouseEnter += LabelLilianDateText_MouseEnter;
			labelLilianDateText.MouseLeave += LabelLilianDateText_MouseLeave;
			// 
			// labelChronologicalModifiedJulianDate
			// 
			labelChronologicalModifiedJulianDate.AccessibleDescription = "Value of the Chronological Modified Julian Date";
			labelChronologicalModifiedJulianDate.AccessibleName = "Chronological Modified Julian Date Value";
			labelChronologicalModifiedJulianDate.AccessibleRole = AccessibleRole.StaticText;
			labelChronologicalModifiedJulianDate.AutoEllipsis = true;
			labelChronologicalModifiedJulianDate.AutoSize = true;
			labelChronologicalModifiedJulianDate.BackColor = Color.Transparent;
			labelChronologicalModifiedJulianDate.Location = new Point(210, 271);
			labelChronologicalModifiedJulianDate.Margin = new Padding(4, 0, 4, 0);
			labelChronologicalModifiedJulianDate.Name = "labelChronologicalModifiedJulianDate";
			labelChronologicalModifiedJulianDate.Size = new Size(124, 15);
			labelChronologicalModifiedJulianDate.TabIndex = 27;
			labelChronologicalModifiedJulianDate.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelChronologicalModifiedJulianDate, "Double-click to copy into the clipboard");
			labelChronologicalModifiedJulianDate.DoubleClick += LabelChronologicalModifiedJulianDate_DoubleClick;
			labelChronologicalModifiedJulianDate.Enter += LabelChronologicalModifiedJulianDate_Enter;
			labelChronologicalModifiedJulianDate.Leave += LabelChronologicalModifiedJulianDate_Leave;
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
			labelChronologicalModifiedJulianDateText.Location = new Point(14, 271);
			labelChronologicalModifiedJulianDateText.Margin = new Padding(4, 0, 4, 0);
			labelChronologicalModifiedJulianDateText.Name = "labelChronologicalModifiedJulianDateText";
			labelChronologicalModifiedJulianDateText.Size = new Size(195, 15);
			labelChronologicalModifiedJulianDateText.TabIndex = 26;
			labelChronologicalModifiedJulianDateText.Text = "Chronological Modified Julian date:";
			toolTip.SetToolTip(labelChronologicalModifiedJulianDateText, "Click to show more information");
			labelChronologicalModifiedJulianDateText.Click += LabelChronologicalModifiedJulianDateText_Click;
			labelChronologicalModifiedJulianDateText.Enter += LabelChronologicalModifiedJulianDateText_Enter;
			labelChronologicalModifiedJulianDateText.Leave += LabelChronologicalModifiedJulianDateText_Leave;
			labelChronologicalModifiedJulianDateText.MouseEnter += LabelChronologicalModifiedJulianDateText_MouseEnter;
			labelChronologicalModifiedJulianDateText.MouseLeave += LabelChronologicalModifiedJulianDateText_MouseLeave;
			// 
			// labelChronologicalJulianDate
			// 
			labelChronologicalJulianDate.AccessibleDescription = "Value of the Chronological Julian Date";
			labelChronologicalJulianDate.AccessibleName = "Chronological Julian Date Value";
			labelChronologicalJulianDate.AccessibleRole = AccessibleRole.StaticText;
			labelChronologicalJulianDate.AutoEllipsis = true;
			labelChronologicalJulianDate.AutoSize = true;
			labelChronologicalJulianDate.BackColor = Color.Transparent;
			labelChronologicalJulianDate.Location = new Point(210, 256);
			labelChronologicalJulianDate.Margin = new Padding(4, 0, 4, 0);
			labelChronologicalJulianDate.Name = "labelChronologicalJulianDate";
			labelChronologicalJulianDate.Size = new Size(124, 15);
			labelChronologicalJulianDate.TabIndex = 25;
			labelChronologicalJulianDate.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelChronologicalJulianDate, "Double-click to copy into the clipboard");
			labelChronologicalJulianDate.DoubleClick += LabelChronologicalJulianDate_DoubleClick;
			labelChronologicalJulianDate.Enter += LabelChronologicalJulianDate_Enter;
			labelChronologicalJulianDate.Leave += LabelChronologicalJulianDate_Leave;
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
			labelChronologicalJulianDateText.Location = new Point(14, 256);
			labelChronologicalJulianDateText.Margin = new Padding(4, 0, 4, 0);
			labelChronologicalJulianDateText.Name = "labelChronologicalJulianDateText";
			labelChronologicalJulianDateText.Size = new Size(144, 15);
			labelChronologicalJulianDateText.TabIndex = 24;
			labelChronologicalJulianDateText.Text = "Chronological Julian date:";
			toolTip.SetToolTip(labelChronologicalJulianDateText, "Click to show more information");
			labelChronologicalJulianDateText.Click += LabelChronologicalJulianDateText_Click;
			labelChronologicalJulianDateText.Enter += LabelChronologicalJulianDateText_Enter;
			labelChronologicalJulianDateText.Leave += LabelChronologicalJulianDateText_Leave;
			labelChronologicalJulianDateText.MouseEnter += LabelChronologicalJulianDateText_MouseEnter;
			labelChronologicalJulianDateText.MouseLeave += LabelChronologicalJulianDateText_MouseLeave;
			// 
			// labelUtcTime
			// 
			labelUtcTime.AccessibleDescription = "Value of the UTC time";
			labelUtcTime.AccessibleName = "UTC Time Value";
			labelUtcTime.AccessibleRole = AccessibleRole.StaticText;
			labelUtcTime.AutoEllipsis = true;
			labelUtcTime.AutoSize = true;
			labelUtcTime.BackColor = Color.Transparent;
			labelUtcTime.Location = new Point(210, 90);
			labelUtcTime.Margin = new Padding(4, 0, 4, 0);
			labelUtcTime.Name = "labelUtcTime";
			labelUtcTime.Size = new Size(116, 15);
			labelUtcTime.TabIndex = 3;
			labelUtcTime.Text = "[your UTC time here]";
			toolTip.SetToolTip(labelUtcTime, "Double-click to copy into the clipboard");
			labelUtcTime.DoubleClick += LabelUtcTime_DoubleClick;
			labelUtcTime.Enter += LabelUtcTime_Enter;
			labelUtcTime.Leave += LabelUtcTime_Leave;
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
			labelUtcTimeText.Location = new Point(14, 91);
			labelUtcTimeText.Margin = new Padding(4, 0, 4, 0);
			labelUtcTimeText.Name = "labelUtcTimeText";
			labelUtcTimeText.Size = new Size(58, 15);
			labelUtcTimeText.TabIndex = 2;
			labelUtcTimeText.Text = "UTC time:";
			toolTip.SetToolTip(labelUtcTimeText, "Click to show more information");
			labelUtcTimeText.Click += LabelUtcTimeText_Click;
			labelUtcTimeText.Enter += LabelUtcTimeText_Enter;
			labelUtcTimeText.Leave += LabelUtcTimeText_Leave;
			labelUtcTimeText.MouseEnter += LabelUtcTimeText_MouseEnter;
			labelUtcTimeText.MouseLeave += LabelUtcTimeText_MouseLeave;
			// 
			// labelLocalTime
			// 
			labelLocalTime.AccessibleDescription = "Value of the local time";
			labelLocalTime.AccessibleName = "Local Time Value";
			labelLocalTime.AccessibleRole = AccessibleRole.StaticText;
			labelLocalTime.AutoEllipsis = true;
			labelLocalTime.AutoSize = true;
			labelLocalTime.BackColor = Color.Transparent;
			labelLocalTime.Location = new Point(210, 105);
			labelLocalTime.Margin = new Padding(4, 0, 4, 0);
			labelLocalTime.Name = "labelLocalTime";
			labelLocalTime.Size = new Size(120, 15);
			labelLocalTime.TabIndex = 5;
			labelLocalTime.Text = "[your local time here]";
			toolTip.SetToolTip(labelLocalTime, "Double-click to copy into the clipboard");
			labelLocalTime.DoubleClick += LabelLocalTime_DoubleClick;
			labelLocalTime.Enter += LabelLocalTime_Enter;
			labelLocalTime.Leave += LabelLocalTime_Leave;
			labelLocalTime.MouseEnter += LabelLocalTime_MouseEnter;
			labelLocalTime.MouseLeave += LabelLocalTime_MouseLeave;
			// 
			// labelLocalTimeText
			// 
			labelLocalTimeText.AccessibleDescription = "Description of the local time";
			labelLocalTimeText.AccessibleName = "Local Time Description";
			labelLocalTimeText.AccessibleRole = AccessibleRole.StaticText;
			labelLocalTimeText.AutoEllipsis = true;
			labelLocalTimeText.AutoSize = true;
			labelLocalTimeText.BackColor = Color.Transparent;
			labelLocalTimeText.Location = new Point(14, 106);
			labelLocalTimeText.Margin = new Padding(4, 0, 4, 0);
			labelLocalTimeText.Name = "labelLocalTimeText";
			labelLocalTimeText.Size = new Size(65, 15);
			labelLocalTimeText.TabIndex = 4;
			labelLocalTimeText.Text = "Local time:";
			toolTip.SetToolTip(labelLocalTimeText, "Click to show more information");
			labelLocalTimeText.Click += LabelLocalTimeText_Click;
			labelLocalTimeText.Enter += LabelLocalTimeText_Enter;
			labelLocalTimeText.Leave += LabelLocalTimeText_Leave;
			labelLocalTimeText.MouseEnter += LabelLocalTimeText_MouseEnter;
			labelLocalTimeText.MouseLeave += LabelLocalTimeText_MouseLeave;
			// 
			// labelMillenniumJulianDate
			// 
			labelMillenniumJulianDate.AccessibleDescription = "Value of the Millenium Julian Date";
			labelMillenniumJulianDate.AccessibleName = "Millennium Julian Date Value";
			labelMillenniumJulianDate.AccessibleRole = AccessibleRole.StaticText;
			labelMillenniumJulianDate.AutoEllipsis = true;
			labelMillenniumJulianDate.AutoSize = true;
			labelMillenniumJulianDate.BackColor = Color.Transparent;
			labelMillenniumJulianDate.Location = new Point(210, 241);
			labelMillenniumJulianDate.Margin = new Padding(4, 0, 4, 0);
			labelMillenniumJulianDate.Name = "labelMillenniumJulianDate";
			labelMillenniumJulianDate.Size = new Size(124, 15);
			labelMillenniumJulianDate.TabIndex = 23;
			labelMillenniumJulianDate.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelMillenniumJulianDate, "Double-click to copy into the clipboard");
			labelMillenniumJulianDate.DoubleClick += LabelMillenniumJulianDate_DoubleClick;
			labelMillenniumJulianDate.Enter += LabelMillenniumJulianDate_Enter;
			labelMillenniumJulianDate.Leave += LabelMillenniumJulianDate_Leave;
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
			labelMillenniumJulianDateText.Location = new Point(14, 241);
			labelMillenniumJulianDateText.Margin = new Padding(4, 0, 4, 0);
			labelMillenniumJulianDateText.Name = "labelMillenniumJulianDateText";
			labelMillenniumJulianDateText.Size = new Size(130, 15);
			labelMillenniumJulianDateText.TabIndex = 22;
			labelMillenniumJulianDateText.Text = "Millennium Julian date:";
			toolTip.SetToolTip(labelMillenniumJulianDateText, "Click to show more information");
			labelMillenniumJulianDateText.Click += LabelMillenniumJulianDateText_Click;
			labelMillenniumJulianDateText.Enter += LabelMillenniumJulianDateText_Enter;
			labelMillenniumJulianDateText.Leave += LabelMillenniumJulianDateText_Leave;
			labelMillenniumJulianDateText.MouseEnter += LabelMillenniumJulianDateText_MouseEnter;
			labelMillenniumJulianDateText.MouseLeave += LabelMillenniumJulianDateText_MouseLeave;
			// 
			// labelLopJulianDate
			// 
			labelLopJulianDate.AccessibleDescription = "Value of the LOP Julian Date";
			labelLopJulianDate.AccessibleName = "LOP Julian Date Value";
			labelLopJulianDate.AccessibleRole = AccessibleRole.StaticText;
			labelLopJulianDate.AutoEllipsis = true;
			labelLopJulianDate.AutoSize = true;
			labelLopJulianDate.BackColor = Color.Transparent;
			labelLopJulianDate.Location = new Point(210, 226);
			labelLopJulianDate.Margin = new Padding(4, 0, 4, 0);
			labelLopJulianDate.Name = "labelLopJulianDate";
			labelLopJulianDate.Size = new Size(124, 15);
			labelLopJulianDate.TabIndex = 21;
			labelLopJulianDate.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelLopJulianDate, "Double-click to copy into the clipboard");
			labelLopJulianDate.DoubleClick += LabelLopJulianDate_DoubleClick;
			labelLopJulianDate.Enter += LabelLopJulianDate_Enter;
			labelLopJulianDate.Leave += LabelLopJulianDate_Leave;
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
			labelLopJulianDateText.Location = new Point(14, 226);
			labelLopJulianDateText.Margin = new Padding(4, 0, 4, 0);
			labelLopJulianDateText.Name = "labelLopJulianDateText";
			labelLopJulianDateText.Size = new Size(91, 15);
			labelLopJulianDateText.TabIndex = 20;
			labelLopJulianDateText.Text = "LOP Julian date:";
			toolTip.SetToolTip(labelLopJulianDateText, "Click to show more information");
			labelLopJulianDateText.Click += LabelLopJulianDateText_Click;
			labelLopJulianDateText.Enter += LabelLopJulianDateText_Enter;
			labelLopJulianDateText.Leave += LabelLopJulianDateText_Leave;
			labelLopJulianDateText.MouseEnter += LabelLopJulianDateText_MouseEnter;
			labelLopJulianDateText.MouseLeave += LabelLopJulianDateText_MouseLeave;
			// 
			// labelCcsdsJulianDate
			// 
			labelCcsdsJulianDate.AccessibleDescription = "Value of the CCSDS Julian Date";
			labelCcsdsJulianDate.AccessibleName = "CCSDS Julian Date Value";
			labelCcsdsJulianDate.AccessibleRole = AccessibleRole.StaticText;
			labelCcsdsJulianDate.AutoEllipsis = true;
			labelCcsdsJulianDate.AutoSize = true;
			labelCcsdsJulianDate.BackColor = Color.Transparent;
			labelCcsdsJulianDate.Location = new Point(210, 211);
			labelCcsdsJulianDate.Margin = new Padding(4, 0, 4, 0);
			labelCcsdsJulianDate.Name = "labelCcsdsJulianDate";
			labelCcsdsJulianDate.Size = new Size(124, 15);
			labelCcsdsJulianDate.TabIndex = 19;
			labelCcsdsJulianDate.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelCcsdsJulianDate, "Double-click to copy into the clipboard");
			labelCcsdsJulianDate.DoubleClick += LabelCcsdsJulianDate_DoubleClick;
			labelCcsdsJulianDate.Enter += LabelCcsdsJulianDate_Enter;
			labelCcsdsJulianDate.Leave += LabelCcsdsJulianDate_Leave;
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
			labelCcsdsJulianDateText.Location = new Point(14, 211);
			labelCcsdsJulianDateText.Margin = new Padding(4, 0, 4, 0);
			labelCcsdsJulianDateText.Name = "labelCcsdsJulianDateText";
			labelCcsdsJulianDateText.Size = new Size(105, 15);
			labelCcsdsJulianDateText.TabIndex = 18;
			labelCcsdsJulianDateText.Text = "CCSDS Julian date:";
			toolTip.SetToolTip(labelCcsdsJulianDateText, "Click to show more information");
			labelCcsdsJulianDateText.Click += LabelCcsdsJulianDateText_Click;
			labelCcsdsJulianDateText.Enter += LabelCcsdsJulianDateText_Enter;
			labelCcsdsJulianDateText.Leave += LabelCcsdsJulianDateText_Leave;
			labelCcsdsJulianDateText.MouseEnter += LabelCcsdsJulianDateText_MouseEnter;
			labelCcsdsJulianDateText.MouseLeave += LabelCcsdsJulianDateText_MouseLeave;
			// 
			// labelCnesJulianDate
			// 
			labelCnesJulianDate.AccessibleDescription = "Value of the CNES Julian Date";
			labelCnesJulianDate.AccessibleName = "CNES Julian Date Value";
			labelCnesJulianDate.AccessibleRole = AccessibleRole.StaticText;
			labelCnesJulianDate.AutoEllipsis = true;
			labelCnesJulianDate.AutoSize = true;
			labelCnesJulianDate.BackColor = Color.Transparent;
			labelCnesJulianDate.Location = new Point(210, 196);
			labelCnesJulianDate.Margin = new Padding(4, 0, 4, 0);
			labelCnesJulianDate.Name = "labelCnesJulianDate";
			labelCnesJulianDate.Size = new Size(124, 15);
			labelCnesJulianDate.TabIndex = 17;
			labelCnesJulianDate.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelCnesJulianDate, "Double-click to copy into the clipboard");
			labelCnesJulianDate.DoubleClick += LabelCnesJulianDate_DoubleClick;
			labelCnesJulianDate.Enter += LabelCnesJulianDate_Enter;
			labelCnesJulianDate.Leave += LabelCnesJulianDate_Leave;
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
			labelCnesJulianDateText.Location = new Point(14, 196);
			labelCnesJulianDateText.Margin = new Padding(4, 0, 4, 0);
			labelCnesJulianDateText.Name = "labelCnesJulianDateText";
			labelCnesJulianDateText.Size = new Size(98, 15);
			labelCnesJulianDateText.TabIndex = 16;
			labelCnesJulianDateText.Text = "CNES Julian date:";
			toolTip.SetToolTip(labelCnesJulianDateText, "Click to show more information");
			labelCnesJulianDateText.Click += LabelCnesJulianDateText_Click;
			labelCnesJulianDateText.Enter += LabelCnesJulianDateText_Enter;
			labelCnesJulianDateText.Leave += LabelCnesJulianDateText_Leave;
			labelCnesJulianDateText.MouseEnter += LabelCnesJulianDateText_MouseEnter;
			labelCnesJulianDateText.MouseLeave += LabelCnesJulianDateText_MouseLeave;
			// 
			// labelDublinJulianDate
			// 
			labelDublinJulianDate.AccessibleDescription = "Value of the Dublin Julian Date";
			labelDublinJulianDate.AccessibleName = "Dublin Julian Date Value";
			labelDublinJulianDate.AccessibleRole = AccessibleRole.StaticText;
			labelDublinJulianDate.AutoEllipsis = true;
			labelDublinJulianDate.AutoSize = true;
			labelDublinJulianDate.BackColor = Color.Transparent;
			labelDublinJulianDate.Location = new Point(210, 181);
			labelDublinJulianDate.Margin = new Padding(4, 0, 4, 0);
			labelDublinJulianDate.Name = "labelDublinJulianDate";
			labelDublinJulianDate.Size = new Size(124, 15);
			labelDublinJulianDate.TabIndex = 15;
			labelDublinJulianDate.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelDublinJulianDate, "Double-click to copy into the clipboard");
			labelDublinJulianDate.DoubleClick += LabelDublinJulianDate_DoubleClick;
			labelDublinJulianDate.Enter += LabelDublinJulianDate_Enter;
			labelDublinJulianDate.Leave += LabelDublinJulianDate_Leave;
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
			labelDublinJulianDateText.Location = new Point(14, 181);
			labelDublinJulianDateText.Margin = new Padding(4, 0, 4, 0);
			labelDublinJulianDateText.Name = "labelDublinJulianDateText";
			labelDublinJulianDateText.Size = new Size(104, 15);
			labelDublinJulianDateText.TabIndex = 14;
			labelDublinJulianDateText.Text = "Dublin Julian date:";
			toolTip.SetToolTip(labelDublinJulianDateText, "Click to show more information");
			labelDublinJulianDateText.Click += LabelDublinJulianDateText_Click;
			labelDublinJulianDateText.Enter += LabelDublinJulianDateText_Enter;
			labelDublinJulianDateText.Leave += LabelDublinJulianDateText_Leave;
			labelDublinJulianDateText.MouseEnter += LabelDublinJulianDateText_MouseEnter;
			labelDublinJulianDateText.MouseLeave += LabelDublinJulianDateText_MouseLeave;
			// 
			// labelTruncatedJulianDate
			// 
			labelTruncatedJulianDate.AccessibleDescription = "Value of the Truncated Julian Date";
			labelTruncatedJulianDate.AccessibleName = "Truncated Julian Date Value";
			labelTruncatedJulianDate.AccessibleRole = AccessibleRole.StaticText;
			labelTruncatedJulianDate.AutoEllipsis = true;
			labelTruncatedJulianDate.AutoSize = true;
			labelTruncatedJulianDate.BackColor = Color.Transparent;
			labelTruncatedJulianDate.Location = new Point(210, 166);
			labelTruncatedJulianDate.Margin = new Padding(4, 0, 4, 0);
			labelTruncatedJulianDate.Name = "labelTruncatedJulianDate";
			labelTruncatedJulianDate.Size = new Size(124, 15);
			labelTruncatedJulianDate.TabIndex = 13;
			labelTruncatedJulianDate.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelTruncatedJulianDate, "Double-click to copy into the clipboard");
			labelTruncatedJulianDate.DoubleClick += LabelTruncatedJulianDate_DoubleClick;
			labelTruncatedJulianDate.Enter += LabelTruncatedJulianDate_Enter;
			labelTruncatedJulianDate.Leave += LabelTruncatedJulianDate_Leave;
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
			labelTruncatedJulianDateText.Location = new Point(14, 166);
			labelTruncatedJulianDateText.Margin = new Padding(4, 0, 4, 0);
			labelTruncatedJulianDateText.Name = "labelTruncatedJulianDateText";
			labelTruncatedJulianDateText.Size = new Size(121, 15);
			labelTruncatedJulianDateText.TabIndex = 12;
			labelTruncatedJulianDateText.Text = "Truncated Julian date:";
			toolTip.SetToolTip(labelTruncatedJulianDateText, "Click to show more information");
			labelTruncatedJulianDateText.Click += LabelTruncatedJulianDateText_Click;
			labelTruncatedJulianDateText.Enter += LabelTruncatedJulianDateText_Enter;
			labelTruncatedJulianDateText.Leave += LabelTruncatedJulianDateText_Leave;
			labelTruncatedJulianDateText.MouseEnter += LabelTruncatedJulianDateText_MouseEnter;
			labelTruncatedJulianDateText.MouseLeave += LabelTruncatedJulianDateText_MouseLeave;
			// 
			// labelReducedJulianDate
			// 
			labelReducedJulianDate.AccessibleDescription = "Value of the Reduced Julian Date";
			labelReducedJulianDate.AccessibleName = "Reduced Julian Date Value";
			labelReducedJulianDate.AccessibleRole = AccessibleRole.StaticText;
			labelReducedJulianDate.AutoEllipsis = true;
			labelReducedJulianDate.AutoSize = true;
			labelReducedJulianDate.BackColor = Color.Transparent;
			labelReducedJulianDate.Location = new Point(210, 151);
			labelReducedJulianDate.Margin = new Padding(4, 0, 4, 0);
			labelReducedJulianDate.Name = "labelReducedJulianDate";
			labelReducedJulianDate.Size = new Size(124, 15);
			labelReducedJulianDate.TabIndex = 11;
			labelReducedJulianDate.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelReducedJulianDate, "Double-click to copy into the clipboard");
			labelReducedJulianDate.DoubleClick += LabelReducedJulianDate_DoubleClick;
			labelReducedJulianDate.Enter += LabelReducedJulianDate_Enter;
			labelReducedJulianDate.Leave += LabelReducedJulianDate_Leave;
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
			labelReducedJulianDateText.Location = new Point(14, 151);
			labelReducedJulianDateText.Margin = new Padding(4, 0, 4, 0);
			labelReducedJulianDateText.Name = "labelReducedJulianDateText";
			labelReducedJulianDateText.Size = new Size(115, 15);
			labelReducedJulianDateText.TabIndex = 10;
			labelReducedJulianDateText.Text = "Reduced Julian date:";
			toolTip.SetToolTip(labelReducedJulianDateText, "Click to show more information");
			labelReducedJulianDateText.Click += LabelReducedJulianDateText_Click;
			labelReducedJulianDateText.Enter += LabelReducedJulianDateText_Enter;
			labelReducedJulianDateText.Leave += LabelReducedJulianDateText_Leave;
			labelReducedJulianDateText.MouseEnter += LabelReducedJulianDateText_MouseEnter;
			labelReducedJulianDateText.MouseLeave += LabelReducedJulianDateText_MouseLeave;
			// 
			// labelModifiedJulianDate
			// 
			labelModifiedJulianDate.AccessibleDescription = "Value of the Modified Julian Date";
			labelModifiedJulianDate.AccessibleName = "Modified Julian Date Value";
			labelModifiedJulianDate.AccessibleRole = AccessibleRole.StaticText;
			labelModifiedJulianDate.AutoEllipsis = true;
			labelModifiedJulianDate.AutoSize = true;
			labelModifiedJulianDate.BackColor = Color.Transparent;
			labelModifiedJulianDate.Location = new Point(210, 136);
			labelModifiedJulianDate.Margin = new Padding(4, 0, 4, 0);
			labelModifiedJulianDate.Name = "labelModifiedJulianDate";
			labelModifiedJulianDate.Size = new Size(124, 15);
			labelModifiedJulianDate.TabIndex = 9;
			labelModifiedJulianDate.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelModifiedJulianDate, "Double-click to copy into the clipboard");
			labelModifiedJulianDate.DoubleClick += LabelModifiedJulianDate_DoubleClick;
			labelModifiedJulianDate.Enter += LabelModifiedJulianDate_Enter;
			labelModifiedJulianDate.Leave += LabelModifiedJulianDate_Leave;
			labelModifiedJulianDate.MouseEnter += LabelModifiedJulianDate_MouseEnter;
			labelModifiedJulianDate.MouseLeave += LabelModifiedJulianDate_MouseLeave;
			// 
			// labelModifiedJulianDateText
			// 
			labelModifiedJulianDateText.AccessibleDescription = "Description of the Modified Julian Date";
			labelModifiedJulianDateText.AccessibleName = "Modified Julian Date Description";
			labelModifiedJulianDateText.AccessibleRole = AccessibleRole.StaticText;
			labelModifiedJulianDateText.AutoEllipsis = true;
			labelModifiedJulianDateText.AutoSize = true;
			labelModifiedJulianDateText.BackColor = Color.Transparent;
			labelModifiedJulianDateText.Location = new Point(14, 136);
			labelModifiedJulianDateText.Margin = new Padding(4, 0, 4, 0);
			labelModifiedJulianDateText.Name = "labelModifiedJulianDateText";
			labelModifiedJulianDateText.Size = new Size(117, 15);
			labelModifiedJulianDateText.TabIndex = 8;
			labelModifiedJulianDateText.Text = "Modified Julian date:";
			toolTip.SetToolTip(labelModifiedJulianDateText, "Click to show more information");
			labelModifiedJulianDateText.Click += LabelModifiedJulianDateText_Click;
			labelModifiedJulianDateText.Enter += LabelModifiedJulianDateText_Enter;
			labelModifiedJulianDateText.Leave += LabelModifiedJulianDateText_Leave;
			labelModifiedJulianDateText.MouseEnter += LabelModifiedJulianDateText_MouseEnter;
			labelModifiedJulianDateText.MouseLeave += LabelModifiedJulianDateText_MouseLeave;
			// 
			// labelJulianDate
			// 
			labelJulianDate.AccessibleDescription = "Value of the Julian Date";
			labelJulianDate.AccessibleName = "Julian Date Value";
			labelJulianDate.AccessibleRole = AccessibleRole.StaticText;
			labelJulianDate.AutoEllipsis = true;
			labelJulianDate.AutoSize = true;
			labelJulianDate.BackColor = Color.Transparent;
			labelJulianDate.Location = new Point(210, 121);
			labelJulianDate.Margin = new Padding(4, 0, 4, 0);
			labelJulianDate.Name = "labelJulianDate";
			labelJulianDate.Size = new Size(124, 15);
			labelJulianDate.TabIndex = 7;
			labelJulianDate.Text = "[your Julian date here]";
			toolTip.SetToolTip(labelJulianDate, "Double-click to copy into the clipboard");
			labelJulianDate.DoubleClick += LabelJulianDate_DoubleClick;
			labelJulianDate.Enter += LabelJulianDate_Enter;
			labelJulianDate.Leave += LabelJulianDate_Leave;
			labelJulianDate.MouseEnter += LabelJulianDate_MouseEnter;
			labelJulianDate.MouseLeave += LabelJulianDate_MouseLeave;
			// 
			// labelJulianDateText
			// 
			labelJulianDateText.AccessibleDescription = "Description of the Julian Date";
			labelJulianDateText.AccessibleName = "Julian Date Description";
			labelJulianDateText.AccessibleRole = AccessibleRole.StaticText;
			labelJulianDateText.AutoEllipsis = true;
			labelJulianDateText.AutoSize = true;
			labelJulianDateText.BackColor = Color.Transparent;
			labelJulianDateText.Location = new Point(14, 121);
			labelJulianDateText.Margin = new Padding(4, 0, 4, 0);
			labelJulianDateText.Name = "labelJulianDateText";
			labelJulianDateText.Size = new Size(66, 15);
			labelJulianDateText.TabIndex = 6;
			labelJulianDateText.Text = "Julian date:";
			toolTip.SetToolTip(labelJulianDateText, "Click to show more information");
			labelJulianDateText.Click += LabelJulianDateText_Click;
			labelJulianDateText.Enter += LabelJulianDateText_Enter;
			labelJulianDateText.Leave += LabelJulianDateText_Leave;
			labelJulianDateText.MouseEnter += LabelJulianDateText_MouseEnter;
			labelJulianDateText.MouseLeave += LabelJulianDateText_MouseLeave;
			// 
			// dateTimePicker
			// 
			dateTimePicker.AccessibleDescription = "Date selection to calculate";
			dateTimePicker.AccessibleName = "Date Selection";
			dateTimePicker.AccessibleRole = AccessibleRole.ButtonDropDown;
			dateTimePicker.Location = new Point(18, 15);
			dateTimePicker.Margin = new Padding(4, 3, 4, 3);
			dateTimePicker.Name = "dateTimePicker";
			dateTimePicker.RightToLeft = RightToLeft.No;
			dateTimePicker.Size = new Size(321, 23);
			dateTimePicker.TabIndex = 0;
			toolTip.SetToolTip(dateTimePicker, "Select a date to calculate");
			dateTimePicker.ValueChanged += DateTimePicker_ValueChanged;
			dateTimePicker.Enter += DateTimePicker_Enter;
			dateTimePicker.Leave += DateTimePicker_Leave;
			dateTimePicker.MouseEnter += DateTimePicker_MouseEnter;
			dateTimePicker.MouseLeave += DateTimePicker_MouseLeave;
			// 
			// checkBoxIgnoreDecimals
			// 
			checkBoxIgnoreDecimals.AccessibleDescription = "Checking for enable or disable the decimal places";
			checkBoxIgnoreDecimals.AccessibleName = "Decimal Places Ignoration";
			checkBoxIgnoreDecimals.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxIgnoreDecimals.AutoSize = true;
			checkBoxIgnoreDecimals.Location = new Point(18, 46);
			checkBoxIgnoreDecimals.Margin = new Padding(4, 3, 4, 3);
			checkBoxIgnoreDecimals.Name = "checkBoxIgnoreDecimals";
			checkBoxIgnoreDecimals.RightToLeft = RightToLeft.No;
			checkBoxIgnoreDecimals.Size = new Size(141, 19);
			checkBoxIgnoreDecimals.TabIndex = 1;
			checkBoxIgnoreDecimals.Text = "Ignore decimal places";
			toolTip.SetToolTip(checkBoxIgnoreDecimals, "Check to ignore the decimal places");
			checkBoxIgnoreDecimals.UseVisualStyleBackColor = true;
			checkBoxIgnoreDecimals.CheckedChanged += CheckBoxIgnoreDecimals_CheckedChanged;
			checkBoxIgnoreDecimals.Enter += CheckBoxIgnoreDecimals_Enter;
			checkBoxIgnoreDecimals.Leave += CheckBoxIgnoreDecimals_Leave;
			checkBoxIgnoreDecimals.MouseEnter += CheckBoxIgnoreDecimals_MouseEnter;
			checkBoxIgnoreDecimals.MouseLeave += CheckBoxIgnoreDecimals_MouseLeave;
			// 
			// statusStrip
			// 
			statusStrip.AccessibleDescription = "Statusbar";
			statusStrip.AccessibleName = "Statusbar";
			statusStrip.AccessibleRole = AccessibleRole.StatusBar;
			statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelInformation, toolStripStatusLabelTakeScreenshot });
			statusStrip.Location = new Point(0, 369);
			statusStrip.Name = "statusStrip";
			statusStrip.Padding = new Padding(1, 0, 16, 0);
			statusStrip.ShowItemToolTips = true;
			statusStrip.Size = new Size(354, 22);
			statusStrip.SizingGrip = false;
			statusStrip.TabIndex = 36;
			statusStrip.TabStop = true;
			statusStrip.Text = "statusStrip";
			// 
			// toolStripStatusLabelInformation
			// 
			toolStripStatusLabelInformation.AccessibleDescription = "Show some information";
			toolStripStatusLabelInformation.AccessibleName = "Information Label";
			toolStripStatusLabelInformation.AccessibleRole = AccessibleRole.StaticText;
			toolStripStatusLabelInformation.AutoToolTip = true;
			toolStripStatusLabelInformation.Image = Julian_and_his_dates.Properties.Resources.information;
			toolStripStatusLabelInformation.Margin = new Padding(2, 3, 2, 3);
			toolStripStatusLabelInformation.Name = "toolStripStatusLabelInformation";
			toolStripStatusLabelInformation.Size = new Size(86, 16);
			toolStripStatusLabelInformation.Text = "Information";
			// 
			// toolStripStatusLabelTakeScreenshot
			// 
			toolStripStatusLabelTakeScreenshot.AccessibleDescription = "Take a screenshot";
			toolStripStatusLabelTakeScreenshot.AccessibleName = "Screenshot Label";
			toolStripStatusLabelTakeScreenshot.AccessibleRole = AccessibleRole.StaticText;
			toolStripStatusLabelTakeScreenshot.AutoToolTip = true;
			toolStripStatusLabelTakeScreenshot.Image = Julian_and_his_dates.Properties.Resources.camera;
			toolStripStatusLabelTakeScreenshot.Margin = new Padding(2, 3, 2, 3);
			toolStripStatusLabelTakeScreenshot.Name = "toolStripStatusLabelTakeScreenshot";
			toolStripStatusLabelTakeScreenshot.Size = new Size(81, 16);
			toolStripStatusLabelTakeScreenshot.Text = "Screenshot";
			toolStripStatusLabelTakeScreenshot.ToolTipText = "Click to take a screenshot";
			toolStripStatusLabelTakeScreenshot.Click += ToolStripStatusLabelTakeScreenshot_Click;
			// 
			// JulianDateCalculatorForm
			// 
			AccessibleDescription = "Calculates the Julian date from a user-defined date";
			AccessibleName = "Julian Date Calculator";
			AccessibleRole = AccessibleRole.Window;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(354, 391);
			Controls.Add(statusStrip);
			Controls.Add(checkBoxIgnoreDecimals);
			Controls.Add(dateTimePicker);
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
			Controls.Add(labelJulianDate);
			Controls.Add(labelJulianDateText);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "JulianDateCalculatorForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "JD calculator";
			toolTip.SetToolTip(this, "show more information");
			Load += JulianDateCalculatorForm_Load;
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label labelUnixtime;
		private Label labelUnixtimeText;
		private Label labelMarsSolDate;
		private Label labelMarsSolDateText;
		private Label labelRataDie;
		private Label labelRataDieText;
		private Label labelLilianDate;
		private Label labelLilianDateText;
		private Label labelChronologicalModifiedJulianDate;
		private Label labelChronologicalModifiedJulianDateText;
		private Label labelChronologicalJulianDate;
		private Label labelChronologicalJulianDateText;
		private Label labelUtcTime;
		private Label labelUtcTimeText;
		private Label labelLocalTime;
		private Label labelLocalTimeText;
		private Label labelMillenniumJulianDate;
		private Label labelMillenniumJulianDateText;
		private Label labelLopJulianDate;
		private Label labelLopJulianDateText;
		private Label labelCcsdsJulianDate;
		private Label labelCcsdsJulianDateText;
		private Label labelCnesJulianDate;
		private Label labelCnesJulianDateText;
		private Label labelDublinJulianDate;
		private Label labelDublinJulianDateText;
		private Label labelTruncatedJulianDate;
		private Label labelTruncatedJulianDateText;
		private Label labelReducedJulianDate;
		private Label labelReducedJulianDateText;
		private Label labelModifiedJulianDate;
		private Label labelModifiedJulianDateText;
		private Label labelJulianDate;
		private Label labelJulianDateText;
		private ToolTip toolTip;
		private DateTimePicker dateTimePicker;
		private CheckBox checkBoxIgnoreDecimals;
		private StatusStrip statusStrip;
		private ToolStripStatusLabel toolStripStatusLabelInformation;
		private ToolStripStatusLabel toolStripStatusLabelTakeScreenshot;
	}
}