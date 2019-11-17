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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JulianDateCalculatorForm));
			this.labelUnixtime = new System.Windows.Forms.Label();
			this.labelUnixtimeText = new System.Windows.Forms.Label();
			this.labelMarsSolDate = new System.Windows.Forms.Label();
			this.labelMarsSolDateText = new System.Windows.Forms.Label();
			this.labelRataDie = new System.Windows.Forms.Label();
			this.labelRataDieText = new System.Windows.Forms.Label();
			this.labelLilianDate = new System.Windows.Forms.Label();
			this.labelLilianDateText = new System.Windows.Forms.Label();
			this.labelChronologicalModifiedJulianDate = new System.Windows.Forms.Label();
			this.labelChronologicalModifiedJulianDateText = new System.Windows.Forms.Label();
			this.labelChronologicalJulianDate = new System.Windows.Forms.Label();
			this.labelChronologicalJulianDateText = new System.Windows.Forms.Label();
			this.labelUtcTime = new System.Windows.Forms.Label();
			this.labelUtcTimeText = new System.Windows.Forms.Label();
			this.labelLocalTime = new System.Windows.Forms.Label();
			this.labelLocalTimeText = new System.Windows.Forms.Label();
			this.labelMillenniumJulianDate = new System.Windows.Forms.Label();
			this.labelMillenniumJulianDateText = new System.Windows.Forms.Label();
			this.labelLopJulianDate = new System.Windows.Forms.Label();
			this.labelLopJulianDateText = new System.Windows.Forms.Label();
			this.labelCcsdsJulianDate = new System.Windows.Forms.Label();
			this.labelCcsdsJulianDateText = new System.Windows.Forms.Label();
			this.labelCnesJulianDate = new System.Windows.Forms.Label();
			this.labelCnesJulianDateText = new System.Windows.Forms.Label();
			this.labelDublinJulianDate = new System.Windows.Forms.Label();
			this.labelDublinJulianDateText = new System.Windows.Forms.Label();
			this.labelTruncatedJulianDate = new System.Windows.Forms.Label();
			this.labelTruncatedJulianDateText = new System.Windows.Forms.Label();
			this.labelReducedJulianDate = new System.Windows.Forms.Label();
			this.labelReducedJulianDateText = new System.Windows.Forms.Label();
			this.labelModifiedJulianDate = new System.Windows.Forms.Label();
			this.labelModifiedJulianDateText = new System.Windows.Forms.Label();
			this.labelJulianDate = new System.Windows.Forms.Label();
			this.labelJulianDateText = new System.Windows.Forms.Label();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.checkBoxIgnoreDecimals = new System.Windows.Forms.CheckBox();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelTakeScreenshot = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelUnixtime
			// 
			this.labelUnixtime.AccessibleDescription = "Value of the Unix Time";
			this.labelUnixtime.AccessibleName = "Unix Time Value";
			this.labelUnixtime.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelUnixtime.AutoSize = true;
			this.labelUnixtime.BackColor = System.Drawing.Color.Transparent;
			this.labelUnixtime.Location = new System.Drawing.Point(180, 287);
			this.labelUnixtime.Name = "labelUnixtime";
			this.labelUnixtime.Size = new System.Drawing.Size(111, 13);
			this.labelUnixtime.TabIndex = 35;
			this.labelUnixtime.Text = "[your Julian date here]";
			this.toolTip.SetToolTip(this.labelUnixtime, "Double-click to copy into the clipboard");
			this.labelUnixtime.DoubleClick += new System.EventHandler(this.LabelUnixtime_DoubleClick);
			this.labelUnixtime.Enter += new System.EventHandler(this.LabelUnixtime_Enter);
			this.labelUnixtime.Leave += new System.EventHandler(this.LabelUnixtime_Leave);
			this.labelUnixtime.MouseEnter += new System.EventHandler(this.LabelUnixtime_MouseEnter);
			this.labelUnixtime.MouseLeave += new System.EventHandler(this.LabelUnixtime_MouseLeave);
			// 
			// labelUnixtimeText
			// 
			this.labelUnixtimeText.AccessibleDescription = "Description of the Unix time";
			this.labelUnixtimeText.AccessibleName = "Unix Time Description";
			this.labelUnixtimeText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelUnixtimeText.AutoSize = true;
			this.labelUnixtimeText.BackColor = System.Drawing.Color.Transparent;
			this.labelUnixtimeText.Location = new System.Drawing.Point(12, 287);
			this.labelUnixtimeText.Name = "labelUnixtimeText";
			this.labelUnixtimeText.Size = new System.Drawing.Size(57, 13);
			this.labelUnixtimeText.TabIndex = 34;
			this.labelUnixtimeText.Text = "Unix Time:";
			this.toolTip.SetToolTip(this.labelUnixtimeText, "Click to show more information");
			this.labelUnixtimeText.Click += new System.EventHandler(this.LabelUnixtimeText_Click);
			this.labelUnixtimeText.Enter += new System.EventHandler(this.LabelUnixtimeText_Enter);
			this.labelUnixtimeText.Leave += new System.EventHandler(this.LabelUnixtimeText_Leave);
			this.labelUnixtimeText.MouseEnter += new System.EventHandler(this.LabelUnixtimeText_MouseEnter);
			this.labelUnixtimeText.MouseLeave += new System.EventHandler(this.LabelUnixtimeText_MouseLeave);
			// 
			// labelMarsSolDate
			// 
			this.labelMarsSolDate.AccessibleDescription = "Value of the Mars Sol Date";
			this.labelMarsSolDate.AccessibleName = "Mars Sol Date Value";
			this.labelMarsSolDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelMarsSolDate.AutoSize = true;
			this.labelMarsSolDate.BackColor = System.Drawing.Color.Transparent;
			this.labelMarsSolDate.Location = new System.Drawing.Point(180, 274);
			this.labelMarsSolDate.Name = "labelMarsSolDate";
			this.labelMarsSolDate.Size = new System.Drawing.Size(111, 13);
			this.labelMarsSolDate.TabIndex = 33;
			this.labelMarsSolDate.Text = "[your Julian date here]";
			this.toolTip.SetToolTip(this.labelMarsSolDate, "Double-click to copy into the clipboard");
			this.labelMarsSolDate.DoubleClick += new System.EventHandler(this.LabelMarsSolDate_DoubleClick);
			this.labelMarsSolDate.Enter += new System.EventHandler(this.LabelMarsSolDate_Enter);
			this.labelMarsSolDate.Leave += new System.EventHandler(this.LabelMarsSolDate_Leave);
			this.labelMarsSolDate.MouseEnter += new System.EventHandler(this.LabelMarsSolDate_MouseEnter);
			this.labelMarsSolDate.MouseLeave += new System.EventHandler(this.LabelMarsSolDate_MouseLeave);
			// 
			// labelMarsSolDateText
			// 
			this.labelMarsSolDateText.AccessibleDescription = "Description of the Mars Sol Date";
			this.labelMarsSolDateText.AccessibleName = "Mars Sol Date Description";
			this.labelMarsSolDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelMarsSolDateText.AutoSize = true;
			this.labelMarsSolDateText.BackColor = System.Drawing.Color.Transparent;
			this.labelMarsSolDateText.Location = new System.Drawing.Point(12, 274);
			this.labelMarsSolDateText.Name = "labelMarsSolDateText";
			this.labelMarsSolDateText.Size = new System.Drawing.Size(77, 13);
			this.labelMarsSolDateText.TabIndex = 32;
			this.labelMarsSolDateText.Text = "Mars Sol Date:";
			this.toolTip.SetToolTip(this.labelMarsSolDateText, "Click to show more information");
			this.labelMarsSolDateText.Click += new System.EventHandler(this.LabelMarsSolDateText_Click);
			this.labelMarsSolDateText.Enter += new System.EventHandler(this.LabelMarsSolDateText_Enter);
			this.labelMarsSolDateText.Leave += new System.EventHandler(this.LabelMarsSolDateText_Leave);
			this.labelMarsSolDateText.MouseEnter += new System.EventHandler(this.LabelMarsSolDateText_MouseEnter);
			this.labelMarsSolDateText.MouseLeave += new System.EventHandler(this.LabelMarsSolDateText_MouseLeave);
			// 
			// labelRataDie
			// 
			this.labelRataDie.AccessibleDescription = "Value of the Rata Die";
			this.labelRataDie.AccessibleName = "Rata Die Value";
			this.labelRataDie.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelRataDie.AutoSize = true;
			this.labelRataDie.BackColor = System.Drawing.Color.Transparent;
			this.labelRataDie.Location = new System.Drawing.Point(180, 261);
			this.labelRataDie.Name = "labelRataDie";
			this.labelRataDie.Size = new System.Drawing.Size(111, 13);
			this.labelRataDie.TabIndex = 31;
			this.labelRataDie.Text = this.labelMarsSolDate.Text;
			this.toolTip.SetToolTip(this.labelRataDie, "Double-click to copy into the clipboard");
			this.labelRataDie.DoubleClick += new System.EventHandler(this.LabelRataDie_DoubleClick);
			this.labelRataDie.Enter += new System.EventHandler(this.LabelRataDie_Enter);
			this.labelRataDie.Leave += new System.EventHandler(this.LabelRataDie_Leave);
			this.labelRataDie.MouseEnter += new System.EventHandler(this.LabelRataDie_MouseEnter);
			this.labelRataDie.MouseLeave += new System.EventHandler(this.LabelRataDie_MouseLeave);
			// 
			// labelRataDieText
			// 
			this.labelRataDieText.AccessibleDescription = "Description of the Rata Die";
			this.labelRataDieText.AccessibleName = "Rata Die Description";
			this.labelRataDieText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelRataDieText.AutoSize = true;
			this.labelRataDieText.BackColor = System.Drawing.Color.Transparent;
			this.labelRataDieText.Location = new System.Drawing.Point(12, 261);
			this.labelRataDieText.Name = "labelRataDieText";
			this.labelRataDieText.Size = new System.Drawing.Size(52, 13);
			this.labelRataDieText.TabIndex = 30;
			this.labelRataDieText.Text = "Rata Die:";
			this.toolTip.SetToolTip(this.labelRataDieText, "Click to show more information");
			this.labelRataDieText.Click += new System.EventHandler(this.LabelRataDieText_Click);
			this.labelRataDieText.Enter += new System.EventHandler(this.LabelRataDieText_Enter);
			this.labelRataDieText.Leave += new System.EventHandler(this.LabelRataDieText_Leave);
			this.labelRataDieText.MouseEnter += new System.EventHandler(this.LabelRataDieText_MouseEnter);
			this.labelRataDieText.MouseLeave += new System.EventHandler(this.LabelRataDieText_MouseLeave);
			// 
			// labelLilianDate
			// 
			this.labelLilianDate.AccessibleDescription = "Value of the Lilian Date";
			this.labelLilianDate.AccessibleName = "Lilian Date Value";
			this.labelLilianDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelLilianDate.AutoSize = true;
			this.labelLilianDate.BackColor = System.Drawing.Color.Transparent;
			this.labelLilianDate.Location = new System.Drawing.Point(180, 248);
			this.labelLilianDate.Name = "labelLilianDate";
			this.labelLilianDate.Size = new System.Drawing.Size(111, 13);
			this.labelLilianDate.TabIndex = 29;
			this.labelLilianDate.Text = "[your Julian date here]";
			this.toolTip.SetToolTip(this.labelLilianDate, "Double-click to copy into the clipboard");
			this.labelLilianDate.DoubleClick += new System.EventHandler(this.LabelLilianDate_DoubleClick);
			this.labelLilianDate.Enter += new System.EventHandler(this.LabelLilianDate_Enter);
			this.labelLilianDate.Leave += new System.EventHandler(this.LabelLilianDate_Leave);
			this.labelLilianDate.MouseEnter += new System.EventHandler(this.LabelLilianDate_MouseEnter);
			this.labelLilianDate.MouseLeave += new System.EventHandler(this.LabelLilianDate_MouseLeave);
			// 
			// labelLilianDateText
			// 
			this.labelLilianDateText.AccessibleDescription = "Description of the Lilian Date";
			this.labelLilianDateText.AccessibleName = "Lilian Date Description";
			this.labelLilianDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelLilianDateText.AutoSize = true;
			this.labelLilianDateText.BackColor = System.Drawing.Color.Transparent;
			this.labelLilianDateText.Location = new System.Drawing.Point(12, 248);
			this.labelLilianDateText.Name = "labelLilianDateText";
			this.labelLilianDateText.Size = new System.Drawing.Size(60, 13);
			this.labelLilianDateText.TabIndex = 28;
			this.labelLilianDateText.Text = "Lilian Date:";
			this.toolTip.SetToolTip(this.labelLilianDateText, "Click to show more information");
			this.labelLilianDateText.Click += new System.EventHandler(this.LabelLilianDateText_Click);
			this.labelLilianDateText.Enter += new System.EventHandler(this.LabelLilianDateText_Enter);
			this.labelLilianDateText.Leave += new System.EventHandler(this.LabelLilianDateText_Leave);
			this.labelLilianDateText.MouseEnter += new System.EventHandler(this.LabelLilianDateText_MouseEnter);
			this.labelLilianDateText.MouseLeave += new System.EventHandler(this.LabelLilianDateText_MouseLeave);
			// 
			// labelChronologicalModifiedJulianDate
			// 
			this.labelChronologicalModifiedJulianDate.AccessibleDescription = "Value of the Chronological Modified Julian Date";
			this.labelChronologicalModifiedJulianDate.AccessibleName = "Chronological Modified Julian Date Value";
			this.labelChronologicalModifiedJulianDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelChronologicalModifiedJulianDate.AutoSize = true;
			this.labelChronologicalModifiedJulianDate.BackColor = System.Drawing.Color.Transparent;
			this.labelChronologicalModifiedJulianDate.Location = new System.Drawing.Point(180, 235);
			this.labelChronologicalModifiedJulianDate.Name = "labelChronologicalModifiedJulianDate";
			this.labelChronologicalModifiedJulianDate.Size = new System.Drawing.Size(111, 13);
			this.labelChronologicalModifiedJulianDate.TabIndex = 27;
			this.labelChronologicalModifiedJulianDate.Text = "[your Julian date here]";
			this.toolTip.SetToolTip(this.labelChronologicalModifiedJulianDate, "Double-click to copy into the clipboard");
			this.labelChronologicalModifiedJulianDate.DoubleClick += new System.EventHandler(this.LabelChronologicalModifiedJulianDate_DoubleClick);
			this.labelChronologicalModifiedJulianDate.Enter += new System.EventHandler(this.LabelChronologicalModifiedJulianDate_Enter);
			this.labelChronologicalModifiedJulianDate.Leave += new System.EventHandler(this.LabelChronologicalModifiedJulianDate_Leave);
			this.labelChronologicalModifiedJulianDate.MouseEnter += new System.EventHandler(this.LabelChronologicalModifiedJulianDate_MouseEnter);
			this.labelChronologicalModifiedJulianDate.MouseLeave += new System.EventHandler(this.LabelChronologicalModifiedJulianDate_MouseLeave);
			// 
			// labelChronologicalModifiedJulianDateText
			// 
			this.labelChronologicalModifiedJulianDateText.AccessibleDescription = "Description of the Chronological Julian Date";
			this.labelChronologicalModifiedJulianDateText.AccessibleName = "Chronological Modified Julian Date Description";
			this.labelChronologicalModifiedJulianDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelChronologicalModifiedJulianDateText.AutoSize = true;
			this.labelChronologicalModifiedJulianDateText.BackColor = System.Drawing.Color.Transparent;
			this.labelChronologicalModifiedJulianDateText.Location = new System.Drawing.Point(12, 235);
			this.labelChronologicalModifiedJulianDateText.Name = "labelChronologicalModifiedJulianDateText";
			this.labelChronologicalModifiedJulianDateText.Size = new System.Drawing.Size(171, 13);
			this.labelChronologicalModifiedJulianDateText.TabIndex = 26;
			this.labelChronologicalModifiedJulianDateText.Text = "Chronological Modified Julian date:";
			this.toolTip.SetToolTip(this.labelChronologicalModifiedJulianDateText, "Click to show more information");
			this.labelChronologicalModifiedJulianDateText.Click += new System.EventHandler(this.LabelChronologicalModifiedJulianDateText_Click);
			this.labelChronologicalModifiedJulianDateText.Enter += new System.EventHandler(this.LabelChronologicalModifiedJulianDateText_Enter);
			this.labelChronologicalModifiedJulianDateText.Leave += new System.EventHandler(this.LabelChronologicalModifiedJulianDateText_Leave);
			this.labelChronologicalModifiedJulianDateText.MouseEnter += new System.EventHandler(this.LabelChronologicalModifiedJulianDateText_MouseEnter);
			this.labelChronologicalModifiedJulianDateText.MouseLeave += new System.EventHandler(this.LabelChronologicalModifiedJulianDateText_MouseLeave);
			// 
			// labelChronologicalJulianDate
			// 
			this.labelChronologicalJulianDate.AccessibleDescription = "Value of the Chronological Julian Date";
			this.labelChronologicalJulianDate.AccessibleName = "Chronological Julian Date Value";
			this.labelChronologicalJulianDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelChronologicalJulianDate.AutoSize = true;
			this.labelChronologicalJulianDate.BackColor = System.Drawing.Color.Transparent;
			this.labelChronologicalJulianDate.Location = new System.Drawing.Point(180, 222);
			this.labelChronologicalJulianDate.Name = "labelChronologicalJulianDate";
			this.labelChronologicalJulianDate.Size = new System.Drawing.Size(111, 13);
			this.labelChronologicalJulianDate.TabIndex = 25;
			this.labelChronologicalJulianDate.Text = "[your Julian date here]";
			this.toolTip.SetToolTip(this.labelChronologicalJulianDate, "Double-click to copy into the clipboard");
			this.labelChronologicalJulianDate.DoubleClick += new System.EventHandler(this.LabelChronologicalJulianDate_DoubleClick);
			this.labelChronologicalJulianDate.Enter += new System.EventHandler(this.LabelChronologicalJulianDate_Enter);
			this.labelChronologicalJulianDate.Leave += new System.EventHandler(this.LabelChronologicalJulianDate_Leave);
			this.labelChronologicalJulianDate.MouseEnter += new System.EventHandler(this.LabelChronologicalJulianDate_MouseEnter);
			this.labelChronologicalJulianDate.MouseLeave += new System.EventHandler(this.LabelChronologicalJulianDate_MouseLeave);
			// 
			// labelChronologicalJulianDateText
			// 
			this.labelChronologicalJulianDateText.AccessibleDescription = "Description of the Chronological Julian Date";
			this.labelChronologicalJulianDateText.AccessibleName = "Chronological Julian Date Description";
			this.labelChronologicalJulianDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelChronologicalJulianDateText.AutoSize = true;
			this.labelChronologicalJulianDateText.BackColor = System.Drawing.Color.Transparent;
			this.labelChronologicalJulianDateText.Location = new System.Drawing.Point(12, 222);
			this.labelChronologicalJulianDateText.Name = "labelChronologicalJulianDateText";
			this.labelChronologicalJulianDateText.Size = new System.Drawing.Size(128, 13);
			this.labelChronologicalJulianDateText.TabIndex = 24;
			this.labelChronologicalJulianDateText.Text = "Chronological Julian date:";
			this.toolTip.SetToolTip(this.labelChronologicalJulianDateText, "Click to show more information");
			this.labelChronologicalJulianDateText.Click += new System.EventHandler(this.LabelChronologicalJulianDateText_Click);
			this.labelChronologicalJulianDateText.Enter += new System.EventHandler(this.LabelChronologicalJulianDateText_Enter);
			this.labelChronologicalJulianDateText.Leave += new System.EventHandler(this.LabelChronologicalJulianDateText_Leave);
			this.labelChronologicalJulianDateText.MouseEnter += new System.EventHandler(this.LabelChronologicalJulianDateText_MouseEnter);
			this.labelChronologicalJulianDateText.MouseLeave += new System.EventHandler(this.LabelChronologicalJulianDateText_MouseLeave);
			// 
			// labelUtcTime
			// 
			this.labelUtcTime.AccessibleDescription = "Value of the UTC time";
			this.labelUtcTime.AccessibleName = "UTC Time Value";
			this.labelUtcTime.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelUtcTime.AutoSize = true;
			this.labelUtcTime.BackColor = System.Drawing.Color.Transparent;
			this.labelUtcTime.Location = new System.Drawing.Point(180, 78);
			this.labelUtcTime.Name = "labelUtcTime";
			this.labelUtcTime.Size = new System.Drawing.Size(104, 13);
			this.labelUtcTime.TabIndex = 3;
			this.labelUtcTime.Text = "[your UTC time here]";
			this.toolTip.SetToolTip(this.labelUtcTime, "Double-click to copy into the clipboard");
			this.labelUtcTime.DoubleClick += new System.EventHandler(this.LabelUtcTime_DoubleClick);
			this.labelUtcTime.Enter += new System.EventHandler(this.LabelUtcTime_Enter);
			this.labelUtcTime.Leave += new System.EventHandler(this.LabelUtcTime_Leave);
			this.labelUtcTime.MouseEnter += new System.EventHandler(this.LabelUtcTime_MouseEnter);
			this.labelUtcTime.MouseLeave += new System.EventHandler(this.LabelUtcTime_MouseLeave);
			// 
			// labelUtcTimeText
			// 
			this.labelUtcTimeText.AccessibleDescription = "Description of the UTC time";
			this.labelUtcTimeText.AccessibleName = "UTC Time Description";
			this.labelUtcTimeText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelUtcTimeText.AutoSize = true;
			this.labelUtcTimeText.BackColor = System.Drawing.Color.Transparent;
			this.labelUtcTimeText.Location = new System.Drawing.Point(12, 79);
			this.labelUtcTimeText.Name = "labelUtcTimeText";
			this.labelUtcTimeText.Size = new System.Drawing.Size(54, 13);
			this.labelUtcTimeText.TabIndex = 2;
			this.labelUtcTimeText.Text = "UTC time:";
			this.toolTip.SetToolTip(this.labelUtcTimeText, "Click to show more information");
			this.labelUtcTimeText.Click += new System.EventHandler(this.LabelUtcTimeText_Click);
			this.labelUtcTimeText.Enter += new System.EventHandler(this.LabelUtcTimeText_Enter);
			this.labelUtcTimeText.Leave += new System.EventHandler(this.LabelUtcTimeText_Leave);
			this.labelUtcTimeText.MouseEnter += new System.EventHandler(this.LabelUtcTimeText_MouseEnter);
			this.labelUtcTimeText.MouseLeave += new System.EventHandler(this.LabelUtcTimeText_MouseLeave);
			// 
			// labelLocalTime
			// 
			this.labelLocalTime.AccessibleDescription = "Value of the local time";
			this.labelLocalTime.AccessibleName = "Local Time Value";
			this.labelLocalTime.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelLocalTime.AutoSize = true;
			this.labelLocalTime.BackColor = System.Drawing.Color.Transparent;
			this.labelLocalTime.Location = new System.Drawing.Point(180, 91);
			this.labelLocalTime.Name = "labelLocalTime";
			this.labelLocalTime.Size = new System.Drawing.Size(104, 13);
			this.labelLocalTime.TabIndex = 5;
			this.labelLocalTime.Text = "[your local time here]";
			this.toolTip.SetToolTip(this.labelLocalTime, "Double-click to copy into the clipboard");
			this.labelLocalTime.DoubleClick += new System.EventHandler(this.LabelLocalTime_DoubleClick);
			this.labelLocalTime.Enter += new System.EventHandler(this.LabelLocalTime_Enter);
			this.labelLocalTime.Leave += new System.EventHandler(this.LabelLocalTime_Leave);
			this.labelLocalTime.MouseEnter += new System.EventHandler(this.LabelLocalTime_MouseEnter);
			this.labelLocalTime.MouseLeave += new System.EventHandler(this.LabelLocalTime_MouseLeave);
			// 
			// labelLocalTimeText
			// 
			this.labelLocalTimeText.AccessibleDescription = "Description of the local time";
			this.labelLocalTimeText.AccessibleName = "Local Time Description";
			this.labelLocalTimeText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelLocalTimeText.AutoSize = true;
			this.labelLocalTimeText.BackColor = System.Drawing.Color.Transparent;
			this.labelLocalTimeText.Location = new System.Drawing.Point(12, 92);
			this.labelLocalTimeText.Name = "labelLocalTimeText";
			this.labelLocalTimeText.Size = new System.Drawing.Size(58, 13);
			this.labelLocalTimeText.TabIndex = 4;
			this.labelLocalTimeText.Text = "Local time:";
			this.toolTip.SetToolTip(this.labelLocalTimeText, "Click to show more information");
			this.labelLocalTimeText.Click += new System.EventHandler(this.LabelLocalTimeText_Click);
			this.labelLocalTimeText.Enter += new System.EventHandler(this.LabelLocalTimeText_Enter);
			this.labelLocalTimeText.Leave += new System.EventHandler(this.LabelLocalTimeText_Leave);
			this.labelLocalTimeText.MouseEnter += new System.EventHandler(this.LabelLocalTimeText_MouseEnter);
			this.labelLocalTimeText.MouseLeave += new System.EventHandler(this.LabelLocalTimeText_MouseLeave);
			// 
			// labelMillenniumJulianDate
			// 
			this.labelMillenniumJulianDate.AccessibleDescription = "Value of the Millenium Julian Date";
			this.labelMillenniumJulianDate.AccessibleName = "Millennium Julian Date Value";
			this.labelMillenniumJulianDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelMillenniumJulianDate.AutoSize = true;
			this.labelMillenniumJulianDate.BackColor = System.Drawing.Color.Transparent;
			this.labelMillenniumJulianDate.Location = new System.Drawing.Point(180, 209);
			this.labelMillenniumJulianDate.Name = "labelMillenniumJulianDate";
			this.labelMillenniumJulianDate.Size = new System.Drawing.Size(111, 13);
			this.labelMillenniumJulianDate.TabIndex = 23;
			this.labelMillenniumJulianDate.Text = "[your Julian date here]";
			this.toolTip.SetToolTip(this.labelMillenniumJulianDate, "Double-click to copy into the clipboard");
			this.labelMillenniumJulianDate.DoubleClick += new System.EventHandler(this.LabelMillenniumJulianDate_DoubleClick);
			this.labelMillenniumJulianDate.Enter += new System.EventHandler(this.LabelMillenniumJulianDate_Enter);
			this.labelMillenniumJulianDate.Leave += new System.EventHandler(this.LabelMillenniumJulianDate_Leave);
			this.labelMillenniumJulianDate.MouseEnter += new System.EventHandler(this.LabelMillenniumJulianDate_MouseEnter);
			this.labelMillenniumJulianDate.MouseLeave += new System.EventHandler(this.LabelMillenniumJulianDate_MouseLeave);
			// 
			// labelMillenniumJulianDateText
			// 
			this.labelMillenniumJulianDateText.AccessibleDescription = "Description of the Millennium Julian Date";
			this.labelMillenniumJulianDateText.AccessibleName = "Millennium Julian Date Description";
			this.labelMillenniumJulianDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelMillenniumJulianDateText.AutoSize = true;
			this.labelMillenniumJulianDateText.BackColor = System.Drawing.Color.Transparent;
			this.labelMillenniumJulianDateText.Location = new System.Drawing.Point(12, 209);
			this.labelMillenniumJulianDateText.Name = "labelMillenniumJulianDateText";
			this.labelMillenniumJulianDateText.Size = new System.Drawing.Size(113, 13);
			this.labelMillenniumJulianDateText.TabIndex = 22;
			this.labelMillenniumJulianDateText.Text = "Millennium Julian date:";
			this.toolTip.SetToolTip(this.labelMillenniumJulianDateText, "Click to show more information");
			this.labelMillenniumJulianDateText.Click += new System.EventHandler(this.LabelMillenniumJulianDateText_Click);
			this.labelMillenniumJulianDateText.Enter += new System.EventHandler(this.LabelMillenniumJulianDateText_Enter);
			this.labelMillenniumJulianDateText.Leave += new System.EventHandler(this.LabelMillenniumJulianDateText_Leave);
			this.labelMillenniumJulianDateText.MouseEnter += new System.EventHandler(this.LabelMillenniumJulianDateText_MouseEnter);
			this.labelMillenniumJulianDateText.MouseLeave += new System.EventHandler(this.LabelMillenniumJulianDateText_MouseLeave);
			// 
			// labelLopJulianDate
			// 
			this.labelLopJulianDate.AccessibleDescription = "Value of the LOP Julian Date";
			this.labelLopJulianDate.AccessibleName = "LOP Julian Date Value";
			this.labelLopJulianDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelLopJulianDate.AutoSize = true;
			this.labelLopJulianDate.BackColor = System.Drawing.Color.Transparent;
			this.labelLopJulianDate.Location = new System.Drawing.Point(180, 196);
			this.labelLopJulianDate.Name = "labelLopJulianDate";
			this.labelLopJulianDate.Size = new System.Drawing.Size(111, 13);
			this.labelLopJulianDate.TabIndex = 21;
			this.labelLopJulianDate.Text = "[your Julian date here]";
			this.toolTip.SetToolTip(this.labelLopJulianDate, "Double-click to copy into the clipboard");
			this.labelLopJulianDate.DoubleClick += new System.EventHandler(this.LabelLopJulianDate_DoubleClick);
			this.labelLopJulianDate.Enter += new System.EventHandler(this.LabelLopJulianDate_Enter);
			this.labelLopJulianDate.Leave += new System.EventHandler(this.LabelLopJulianDate_Leave);
			this.labelLopJulianDate.MouseEnter += new System.EventHandler(this.LabelLopJulianDate_MouseEnter);
			this.labelLopJulianDate.MouseLeave += new System.EventHandler(this.LabelLopJulianDate_MouseLeave);
			// 
			// labelLopJulianDateText
			// 
			this.labelLopJulianDateText.AccessibleDescription = "Description of the LOP Julian Date";
			this.labelLopJulianDateText.AccessibleName = "LOP Julian Date Description";
			this.labelLopJulianDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelLopJulianDateText.AutoSize = true;
			this.labelLopJulianDateText.BackColor = System.Drawing.Color.Transparent;
			this.labelLopJulianDateText.Location = new System.Drawing.Point(12, 196);
			this.labelLopJulianDateText.Name = "labelLopJulianDateText";
			this.labelLopJulianDateText.Size = new System.Drawing.Size(85, 13);
			this.labelLopJulianDateText.TabIndex = 20;
			this.labelLopJulianDateText.Text = "LOP Julian date:";
			this.toolTip.SetToolTip(this.labelLopJulianDateText, "Click to show more information");
			this.labelLopJulianDateText.Click += new System.EventHandler(this.LabelLopJulianDateText_Click);
			this.labelLopJulianDateText.Enter += new System.EventHandler(this.LabelLopJulianDateText_Enter);
			this.labelLopJulianDateText.Leave += new System.EventHandler(this.LabelLopJulianDateText_Leave);
			this.labelLopJulianDateText.MouseEnter += new System.EventHandler(this.LabelLopJulianDateText_MouseEnter);
			this.labelLopJulianDateText.MouseLeave += new System.EventHandler(this.LabelLopJulianDateText_MouseLeave);
			// 
			// labelCcsdsJulianDate
			// 
			this.labelCcsdsJulianDate.AccessibleDescription = "Value of the CCSDS Julian Date";
			this.labelCcsdsJulianDate.AccessibleName = "CCSDS Julian Date Value";
			this.labelCcsdsJulianDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelCcsdsJulianDate.AutoSize = true;
			this.labelCcsdsJulianDate.BackColor = System.Drawing.Color.Transparent;
			this.labelCcsdsJulianDate.Location = new System.Drawing.Point(180, 183);
			this.labelCcsdsJulianDate.Name = "labelCcsdsJulianDate";
			this.labelCcsdsJulianDate.Size = new System.Drawing.Size(111, 13);
			this.labelCcsdsJulianDate.TabIndex = 19;
			this.labelCcsdsJulianDate.Text = "[your Julian date here]";
			this.toolTip.SetToolTip(this.labelCcsdsJulianDate, "Double-click to copy into the clipboard");
			this.labelCcsdsJulianDate.DoubleClick += new System.EventHandler(this.LabelCcsdsJulianDate_DoubleClick);
			this.labelCcsdsJulianDate.Enter += new System.EventHandler(this.LabelCcsdsJulianDate_Enter);
			this.labelCcsdsJulianDate.Leave += new System.EventHandler(this.LabelCcsdsJulianDate_Leave);
			this.labelCcsdsJulianDate.MouseEnter += new System.EventHandler(this.LabelCcsdsJulianDate_MouseEnter);
			this.labelCcsdsJulianDate.MouseLeave += new System.EventHandler(this.LabelCcsdsJulianDate_MouseLeave);
			// 
			// labelCcsdsJulianDateText
			// 
			this.labelCcsdsJulianDateText.AccessibleDescription = "Description of the CCSDS Julian Date";
			this.labelCcsdsJulianDateText.AccessibleName = "CCSDS Julian Date Description";
			this.labelCcsdsJulianDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelCcsdsJulianDateText.AutoSize = true;
			this.labelCcsdsJulianDateText.BackColor = System.Drawing.Color.Transparent;
			this.labelCcsdsJulianDateText.Location = new System.Drawing.Point(12, 183);
			this.labelCcsdsJulianDateText.Name = "labelCcsdsJulianDateText";
			this.labelCcsdsJulianDateText.Size = new System.Drawing.Size(100, 13);
			this.labelCcsdsJulianDateText.TabIndex = 18;
			this.labelCcsdsJulianDateText.Text = "CCSDS Julian date:";
			this.toolTip.SetToolTip(this.labelCcsdsJulianDateText, "Click to show more information");
			this.labelCcsdsJulianDateText.Click += new System.EventHandler(this.LabelCcsdsJulianDateText_Click);
			this.labelCcsdsJulianDateText.Enter += new System.EventHandler(this.LabelCcsdsJulianDateText_Enter);
			this.labelCcsdsJulianDateText.Leave += new System.EventHandler(this.LabelCcsdsJulianDateText_Leave);
			this.labelCcsdsJulianDateText.MouseEnter += new System.EventHandler(this.LabelCcsdsJulianDateText_MouseEnter);
			this.labelCcsdsJulianDateText.MouseLeave += new System.EventHandler(this.LabelCcsdsJulianDateText_MouseLeave);
			// 
			// labelCnesJulianDate
			// 
			this.labelCnesJulianDate.AccessibleDescription = "Value of the CNES Julian Date";
			this.labelCnesJulianDate.AccessibleName = "CNES Julian Date Value";
			this.labelCnesJulianDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelCnesJulianDate.AutoSize = true;
			this.labelCnesJulianDate.BackColor = System.Drawing.Color.Transparent;
			this.labelCnesJulianDate.Location = new System.Drawing.Point(180, 170);
			this.labelCnesJulianDate.Name = "labelCnesJulianDate";
			this.labelCnesJulianDate.Size = new System.Drawing.Size(111, 13);
			this.labelCnesJulianDate.TabIndex = 17;
			this.labelCnesJulianDate.Text = "[your Julian date here]";
			this.toolTip.SetToolTip(this.labelCnesJulianDate, "Double-click to copy into the clipboard");
			this.labelCnesJulianDate.DoubleClick += new System.EventHandler(this.LabelCnesJulianDate_DoubleClick);
			this.labelCnesJulianDate.Enter += new System.EventHandler(this.LabelCnesJulianDate_Enter);
			this.labelCnesJulianDate.Leave += new System.EventHandler(this.LabelCnesJulianDate_Leave);
			this.labelCnesJulianDate.MouseEnter += new System.EventHandler(this.LabelCnesJulianDate_MouseEnter);
			this.labelCnesJulianDate.MouseLeave += new System.EventHandler(this.LabelCnesJulianDate_MouseLeave);
			// 
			// labelCnesJulianDateText
			// 
			this.labelCnesJulianDateText.AccessibleDescription = "Description of the CNES Julian Date";
			this.labelCnesJulianDateText.AccessibleName = "CNES Julian Date Description";
			this.labelCnesJulianDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelCnesJulianDateText.AutoSize = true;
			this.labelCnesJulianDateText.BackColor = System.Drawing.Color.Transparent;
			this.labelCnesJulianDateText.Location = new System.Drawing.Point(12, 170);
			this.labelCnesJulianDateText.Name = "labelCnesJulianDateText";
			this.labelCnesJulianDateText.Size = new System.Drawing.Size(93, 13);
			this.labelCnesJulianDateText.TabIndex = 16;
			this.labelCnesJulianDateText.Text = "CNES Julian date:";
			this.toolTip.SetToolTip(this.labelCnesJulianDateText, "Click to show more information");
			this.labelCnesJulianDateText.Click += new System.EventHandler(this.LabelCnesJulianDateText_Click);
			this.labelCnesJulianDateText.Enter += new System.EventHandler(this.LabelCnesJulianDateText_Enter);
			this.labelCnesJulianDateText.Leave += new System.EventHandler(this.LabelCnesJulianDateText_Leave);
			this.labelCnesJulianDateText.MouseEnter += new System.EventHandler(this.LabelCnesJulianDateText_MouseEnter);
			this.labelCnesJulianDateText.MouseLeave += new System.EventHandler(this.LabelCnesJulianDateText_MouseLeave);
			// 
			// labelDublinJulianDate
			// 
			this.labelDublinJulianDate.AccessibleDescription = "Value of the Dublin Julian Date";
			this.labelDublinJulianDate.AccessibleName = "Dublin Julian Date Value";
			this.labelDublinJulianDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelDublinJulianDate.AutoSize = true;
			this.labelDublinJulianDate.BackColor = System.Drawing.Color.Transparent;
			this.labelDublinJulianDate.Location = new System.Drawing.Point(180, 157);
			this.labelDublinJulianDate.Name = "labelDublinJulianDate";
			this.labelDublinJulianDate.Size = new System.Drawing.Size(111, 13);
			this.labelDublinJulianDate.TabIndex = 15;
			this.labelDublinJulianDate.Text = "[your Julian date here]";
			this.toolTip.SetToolTip(this.labelDublinJulianDate, "Double-click to copy into the clipboard");
			this.labelDublinJulianDate.DoubleClick += new System.EventHandler(this.LabelDublinJulianDate_DoubleClick);
			this.labelDublinJulianDate.Enter += new System.EventHandler(this.LabelDublinJulianDate_Enter);
			this.labelDublinJulianDate.Leave += new System.EventHandler(this.LabelDublinJulianDate_Leave);
			this.labelDublinJulianDate.MouseEnter += new System.EventHandler(this.LabelDublinJulianDate_MouseEnter);
			this.labelDublinJulianDate.MouseLeave += new System.EventHandler(this.LabelDublinJulianDate_MouseLeave);
			// 
			// labelDublinJulianDateText
			// 
			this.labelDublinJulianDateText.AccessibleDescription = "Description of the Dublin Julian Date";
			this.labelDublinJulianDateText.AccessibleName = "Dubln Julian Date Description";
			this.labelDublinJulianDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelDublinJulianDateText.AutoSize = true;
			this.labelDublinJulianDateText.BackColor = System.Drawing.Color.Transparent;
			this.labelDublinJulianDateText.Location = new System.Drawing.Point(12, 157);
			this.labelDublinJulianDateText.Name = "labelDublinJulianDateText";
			this.labelDublinJulianDateText.Size = new System.Drawing.Size(94, 13);
			this.labelDublinJulianDateText.TabIndex = 14;
			this.labelDublinJulianDateText.Text = "Dublin Julian date:";
			this.toolTip.SetToolTip(this.labelDublinJulianDateText, "Click to show more information");
			this.labelDublinJulianDateText.Click += new System.EventHandler(this.LabelDublinJulianDateText_Click);
			this.labelDublinJulianDateText.Enter += new System.EventHandler(this.LabelDublinJulianDateText_Enter);
			this.labelDublinJulianDateText.Leave += new System.EventHandler(this.LabelDublinJulianDateText_Leave);
			this.labelDublinJulianDateText.MouseEnter += new System.EventHandler(this.LabelDublinJulianDateText_MouseEnter);
			this.labelDublinJulianDateText.MouseLeave += new System.EventHandler(this.LabelDublinJulianDateText_MouseLeave);
			// 
			// labelTruncatedJulianDate
			// 
			this.labelTruncatedJulianDate.AccessibleDescription = "Value of the Truncated Julian Date";
			this.labelTruncatedJulianDate.AccessibleName = "Truncated Julian Date Value";
			this.labelTruncatedJulianDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelTruncatedJulianDate.AutoSize = true;
			this.labelTruncatedJulianDate.BackColor = System.Drawing.Color.Transparent;
			this.labelTruncatedJulianDate.Location = new System.Drawing.Point(180, 144);
			this.labelTruncatedJulianDate.Name = "labelTruncatedJulianDate";
			this.labelTruncatedJulianDate.Size = new System.Drawing.Size(111, 13);
			this.labelTruncatedJulianDate.TabIndex = 13;
			this.labelTruncatedJulianDate.Text = "[your Julian date here]";
			this.toolTip.SetToolTip(this.labelTruncatedJulianDate, "Double-click to copy into the clipboard");
			this.labelTruncatedJulianDate.DoubleClick += new System.EventHandler(this.LabelTruncatedJulianDate_DoubleClick);
			this.labelTruncatedJulianDate.Enter += new System.EventHandler(this.LabelTruncatedJulianDate_Enter);
			this.labelTruncatedJulianDate.Leave += new System.EventHandler(this.LabelTruncatedJulianDate_Leave);
			this.labelTruncatedJulianDate.MouseEnter += new System.EventHandler(this.LabelTruncatedJulianDate_MouseEnter);
			this.labelTruncatedJulianDate.MouseLeave += new System.EventHandler(this.LabelTruncatedJulianDate_MouseLeave);
			// 
			// labelTruncatedJulianDateText
			// 
			this.labelTruncatedJulianDateText.AccessibleDescription = "Description of the Truncated Julian Date";
			this.labelTruncatedJulianDateText.AccessibleName = "Truncated Julian Date Description";
			this.labelTruncatedJulianDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelTruncatedJulianDateText.AutoSize = true;
			this.labelTruncatedJulianDateText.BackColor = System.Drawing.Color.Transparent;
			this.labelTruncatedJulianDateText.Location = new System.Drawing.Point(12, 144);
			this.labelTruncatedJulianDateText.Name = "labelTruncatedJulianDateText";
			this.labelTruncatedJulianDateText.Size = new System.Drawing.Size(113, 13);
			this.labelTruncatedJulianDateText.TabIndex = 12;
			this.labelTruncatedJulianDateText.Text = "Truncated Julian date:";
			this.toolTip.SetToolTip(this.labelTruncatedJulianDateText, "Click to show more information");
			this.labelTruncatedJulianDateText.Click += new System.EventHandler(this.LabelTruncatedJulianDateText_Click);
			this.labelTruncatedJulianDateText.Enter += new System.EventHandler(this.LabelTruncatedJulianDateText_Enter);
			this.labelTruncatedJulianDateText.Leave += new System.EventHandler(this.LabelTruncatedJulianDateText_Leave);
			this.labelTruncatedJulianDateText.MouseEnter += new System.EventHandler(this.LabelTruncatedJulianDateText_MouseEnter);
			this.labelTruncatedJulianDateText.MouseLeave += new System.EventHandler(this.LabelTruncatedJulianDateText_MouseLeave);
			// 
			// labelReducedJulianDate
			// 
			this.labelReducedJulianDate.AccessibleDescription = "Value of the Reduced Julian Date";
			this.labelReducedJulianDate.AccessibleName = "Reduced Julian Date Value";
			this.labelReducedJulianDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelReducedJulianDate.AutoSize = true;
			this.labelReducedJulianDate.BackColor = System.Drawing.Color.Transparent;
			this.labelReducedJulianDate.Location = new System.Drawing.Point(180, 131);
			this.labelReducedJulianDate.Name = "labelReducedJulianDate";
			this.labelReducedJulianDate.Size = new System.Drawing.Size(111, 13);
			this.labelReducedJulianDate.TabIndex = 11;
			this.labelReducedJulianDate.Text = "[your Julian date here]";
			this.toolTip.SetToolTip(this.labelReducedJulianDate, "Double-click to copy into the clipboard");
			this.labelReducedJulianDate.DoubleClick += new System.EventHandler(this.LabelReducedJulianDate_DoubleClick);
			this.labelReducedJulianDate.Enter += new System.EventHandler(this.LabelReducedJulianDate_Enter);
			this.labelReducedJulianDate.Leave += new System.EventHandler(this.LabelReducedJulianDate_Leave);
			this.labelReducedJulianDate.MouseEnter += new System.EventHandler(this.LabelReducedJulianDate_MouseEnter);
			this.labelReducedJulianDate.MouseLeave += new System.EventHandler(this.LabelReducedJulianDate_MouseLeave);
			// 
			// labelReducedJulianDateText
			// 
			this.labelReducedJulianDateText.AccessibleDescription = "Description of the Reduced Julian Date";
			this.labelReducedJulianDateText.AccessibleName = "Reduced Julian Date Description";
			this.labelReducedJulianDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelReducedJulianDateText.AutoSize = true;
			this.labelReducedJulianDateText.BackColor = System.Drawing.Color.Transparent;
			this.labelReducedJulianDateText.Location = new System.Drawing.Point(12, 131);
			this.labelReducedJulianDateText.Name = "labelReducedJulianDateText";
			this.labelReducedJulianDateText.Size = new System.Drawing.Size(108, 13);
			this.labelReducedJulianDateText.TabIndex = 10;
			this.labelReducedJulianDateText.Text = "Reduced Julian date:";
			this.toolTip.SetToolTip(this.labelReducedJulianDateText, "Click to show more information");
			this.labelReducedJulianDateText.Click += new System.EventHandler(this.LabelReducedJulianDateText_Click);
			this.labelReducedJulianDateText.Enter += new System.EventHandler(this.LabelReducedJulianDateText_Enter);
			this.labelReducedJulianDateText.Leave += new System.EventHandler(this.LabelReducedJulianDateText_Leave);
			this.labelReducedJulianDateText.MouseEnter += new System.EventHandler(this.LabelReducedJulianDateText_MouseEnter);
			this.labelReducedJulianDateText.MouseLeave += new System.EventHandler(this.LabelReducedJulianDateText_MouseLeave);
			// 
			// labelModifiedJulianDate
			// 
			this.labelModifiedJulianDate.AccessibleDescription = "Value of the Modified Julian Date";
			this.labelModifiedJulianDate.AccessibleName = "Modified Julian Date Value";
			this.labelModifiedJulianDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelModifiedJulianDate.AutoSize = true;
			this.labelModifiedJulianDate.BackColor = System.Drawing.Color.Transparent;
			this.labelModifiedJulianDate.Location = new System.Drawing.Point(180, 118);
			this.labelModifiedJulianDate.Name = "labelModifiedJulianDate";
			this.labelModifiedJulianDate.Size = new System.Drawing.Size(111, 13);
			this.labelModifiedJulianDate.TabIndex = 9;
			this.labelModifiedJulianDate.Text = "[your Julian date here]";
			this.toolTip.SetToolTip(this.labelModifiedJulianDate, "Double-click to copy into the clipboard");
			this.labelModifiedJulianDate.DoubleClick += new System.EventHandler(this.LabelModifiedJulianDate_DoubleClick);
			this.labelModifiedJulianDate.Enter += new System.EventHandler(this.LabelModifiedJulianDate_Enter);
			this.labelModifiedJulianDate.Leave += new System.EventHandler(this.LabelModifiedJulianDate_Leave);
			this.labelModifiedJulianDate.MouseEnter += new System.EventHandler(this.LabelModifiedJulianDate_MouseEnter);
			this.labelModifiedJulianDate.MouseLeave += new System.EventHandler(this.LabelModifiedJulianDate_MouseLeave);
			// 
			// labelModifiedJulianDateText
			// 
			this.labelModifiedJulianDateText.AccessibleDescription = "Description of the Modified Julian Date";
			this.labelModifiedJulianDateText.AccessibleName = "Modified Julian Date Description";
			this.labelModifiedJulianDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelModifiedJulianDateText.AutoSize = true;
			this.labelModifiedJulianDateText.BackColor = System.Drawing.Color.Transparent;
			this.labelModifiedJulianDateText.Location = new System.Drawing.Point(12, 118);
			this.labelModifiedJulianDateText.Name = "labelModifiedJulianDateText";
			this.labelModifiedJulianDateText.Size = new System.Drawing.Size(104, 13);
			this.labelModifiedJulianDateText.TabIndex = 8;
			this.labelModifiedJulianDateText.Text = "Modified Julian date:";
			this.toolTip.SetToolTip(this.labelModifiedJulianDateText, "Click to show more information");
			this.labelModifiedJulianDateText.Click += new System.EventHandler(this.LabelModifiedJulianDateText_Click);
			this.labelModifiedJulianDateText.Enter += new System.EventHandler(this.LabelModifiedJulianDateText_Enter);
			this.labelModifiedJulianDateText.Leave += new System.EventHandler(this.LabelModifiedJulianDateText_Leave);
			this.labelModifiedJulianDateText.MouseEnter += new System.EventHandler(this.LabelModifiedJulianDateText_MouseEnter);
			this.labelModifiedJulianDateText.MouseLeave += new System.EventHandler(this.LabelModifiedJulianDateText_MouseLeave);
			// 
			// labelJulianDate
			// 
			this.labelJulianDate.AccessibleDescription = "Value of the Julian Date";
			this.labelJulianDate.AccessibleName = "Julian Date Value";
			this.labelJulianDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelJulianDate.AutoSize = true;
			this.labelJulianDate.BackColor = System.Drawing.Color.Transparent;
			this.labelJulianDate.Location = new System.Drawing.Point(180, 105);
			this.labelJulianDate.Name = "labelJulianDate";
			this.labelJulianDate.Size = new System.Drawing.Size(111, 13);
			this.labelJulianDate.TabIndex = 7;
			this.labelJulianDate.Text = "[your Julian date here]";
			this.toolTip.SetToolTip(this.labelJulianDate, "Double-click to copy into the clipboard");
			this.labelJulianDate.DoubleClick += new System.EventHandler(this.LabelJulianDate_DoubleClick);
			this.labelJulianDate.Enter += new System.EventHandler(this.LabelJulianDate_Enter);
			this.labelJulianDate.Leave += new System.EventHandler(this.LabelJulianDate_Leave);
			this.labelJulianDate.MouseEnter += new System.EventHandler(this.LabelJulianDate_MouseEnter);
			this.labelJulianDate.MouseLeave += new System.EventHandler(this.LabelJulianDate_MouseLeave);
			// 
			// labelJulianDateText
			// 
			this.labelJulianDateText.AccessibleDescription = "Description of the Julian Date";
			this.labelJulianDateText.AccessibleName = "Julian Date Description";
			this.labelJulianDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelJulianDateText.AutoSize = true;
			this.labelJulianDateText.BackColor = System.Drawing.Color.Transparent;
			this.labelJulianDateText.Location = new System.Drawing.Point(12, 105);
			this.labelJulianDateText.Name = "labelJulianDateText";
			this.labelJulianDateText.Size = new System.Drawing.Size(61, 13);
			this.labelJulianDateText.TabIndex = 6;
			this.labelJulianDateText.Text = "Julian date:";
			this.toolTip.SetToolTip(this.labelJulianDateText, "Click to show more information");
			this.labelJulianDateText.Click += new System.EventHandler(this.LabelJulianDateText_Click);
			this.labelJulianDateText.Enter += new System.EventHandler(this.LabelJulianDateText_Enter);
			this.labelJulianDateText.Leave += new System.EventHandler(this.LabelJulianDateText_Leave);
			this.labelJulianDateText.MouseEnter += new System.EventHandler(this.LabelJulianDateText_MouseEnter);
			this.labelJulianDateText.MouseLeave += new System.EventHandler(this.LabelJulianDateText_MouseLeave);
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.AccessibleDescription = "Date selection to calculate";
			this.dateTimePicker.AccessibleName = "Date Selection";
			this.dateTimePicker.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
			this.dateTimePicker.Location = new System.Drawing.Point(15, 13);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(276, 20);
			this.dateTimePicker.TabIndex = 0;
			this.toolTip.SetToolTip(this.dateTimePicker, "Select a date to calculate");
			this.dateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
			this.dateTimePicker.Enter += new System.EventHandler(this.DateTimePicker_Enter);
			this.dateTimePicker.Leave += new System.EventHandler(this.DateTimePicker_Leave);
			this.dateTimePicker.MouseEnter += new System.EventHandler(this.DateTimePicker_MouseEnter);
			this.dateTimePicker.MouseLeave += new System.EventHandler(this.DateTimePicker_MouseLeave);
			// 
			// checkBoxIgnoreDecimals
			// 
			this.checkBoxIgnoreDecimals.AccessibleDescription = "Checking for enable or disable the decimal places";
			this.checkBoxIgnoreDecimals.AccessibleName = "Decimal Places Ignoration";
			this.checkBoxIgnoreDecimals.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
			this.checkBoxIgnoreDecimals.AutoSize = true;
			this.checkBoxIgnoreDecimals.Location = new System.Drawing.Point(15, 40);
			this.checkBoxIgnoreDecimals.Name = "checkBoxIgnoreDecimals";
			this.checkBoxIgnoreDecimals.Size = new System.Drawing.Size(129, 17);
			this.checkBoxIgnoreDecimals.TabIndex = 1;
			this.checkBoxIgnoreDecimals.Text = "Ignore decimal places";
			this.toolTip.SetToolTip(this.checkBoxIgnoreDecimals, "Check to ignore the decimal places");
			this.checkBoxIgnoreDecimals.UseVisualStyleBackColor = true;
			this.checkBoxIgnoreDecimals.CheckedChanged += new System.EventHandler(this.CheckBoxIgnoreDecimals_CheckedChanged);
			this.checkBoxIgnoreDecimals.Enter += new System.EventHandler(this.CheckBoxIgnoreDecimals_Enter);
			this.checkBoxIgnoreDecimals.Leave += new System.EventHandler(this.CheckBoxIgnoreDecimals_Leave);
			this.checkBoxIgnoreDecimals.MouseEnter += new System.EventHandler(this.CheckBoxIgnoreDecimals_MouseEnter);
			this.checkBoxIgnoreDecimals.MouseLeave += new System.EventHandler(this.CheckBoxIgnoreDecimals_MouseLeave);
			// 
			// statusStrip
			// 
			this.statusStrip.AccessibleDescription = "Statusbar";
			this.statusStrip.AccessibleName = "Statusbar";
			this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInformation,
            this.toolStripStatusLabelTakeScreenshot});
			this.statusStrip.Location = new System.Drawing.Point(0, 317);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.ShowItemToolTips = true;
			this.statusStrip.Size = new System.Drawing.Size(303, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 36;
			this.statusStrip.TabStop = true;
			this.statusStrip.Text = "statusStrip";
			// 
			// toolStripStatusLabelInformation
			// 
			this.toolStripStatusLabelInformation.AccessibleDescription = "Show some information";
			this.toolStripStatusLabelInformation.AccessibleName = "Information Label";
			this.toolStripStatusLabelInformation.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.toolStripStatusLabelInformation.AutoToolTip = true;
			this.toolStripStatusLabelInformation.Image = global::Julian_and_his_dates.Properties.Resources.picInformation;
			this.toolStripStatusLabelInformation.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.toolStripStatusLabelInformation.Name = "toolStripStatusLabelInformation";
			this.toolStripStatusLabelInformation.Size = new System.Drawing.Size(86, 16);
			this.toolStripStatusLabelInformation.Text = "Information";
			// 
			// toolStripStatusLabelTakeScreenshot
			// 
			this.toolStripStatusLabelTakeScreenshot.AccessibleDescription = "Take a screenshot";
			this.toolStripStatusLabelTakeScreenshot.AccessibleName = "Screenshot Label";
			this.toolStripStatusLabelTakeScreenshot.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.toolStripStatusLabelTakeScreenshot.AutoToolTip = true;
			this.toolStripStatusLabelTakeScreenshot.Image = global::Julian_and_his_dates.Properties.Resources.picCamera;
			this.toolStripStatusLabelTakeScreenshot.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.toolStripStatusLabelTakeScreenshot.Name = "toolStripStatusLabelTakeScreenshot";
			this.toolStripStatusLabelTakeScreenshot.Size = new System.Drawing.Size(81, 16);
			this.toolStripStatusLabelTakeScreenshot.Text = "Screenshot";
			this.toolStripStatusLabelTakeScreenshot.ToolTipText = "Click to take a screenshot";
			this.toolStripStatusLabelTakeScreenshot.Click += new System.EventHandler(this.ToolStripStatusLabelTakeScreenshot_Click);
			// 
			// JulianDateCalculatorForm
			// 
			this.AccessibleDescription = "Calculates the Julian date from a user-defined date";
			this.AccessibleName = "Julian Date Calculator";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(303, 339);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.checkBoxIgnoreDecimals);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.labelUnixtime);
			this.Controls.Add(this.labelUnixtimeText);
			this.Controls.Add(this.labelMarsSolDate);
			this.Controls.Add(this.labelMarsSolDateText);
			this.Controls.Add(this.labelRataDie);
			this.Controls.Add(this.labelRataDieText);
			this.Controls.Add(this.labelLilianDate);
			this.Controls.Add(this.labelLilianDateText);
			this.Controls.Add(this.labelChronologicalModifiedJulianDate);
			this.Controls.Add(this.labelChronologicalModifiedJulianDateText);
			this.Controls.Add(this.labelChronologicalJulianDate);
			this.Controls.Add(this.labelChronologicalJulianDateText);
			this.Controls.Add(this.labelUtcTime);
			this.Controls.Add(this.labelUtcTimeText);
			this.Controls.Add(this.labelLocalTime);
			this.Controls.Add(this.labelLocalTimeText);
			this.Controls.Add(this.labelMillenniumJulianDate);
			this.Controls.Add(this.labelMillenniumJulianDateText);
			this.Controls.Add(this.labelLopJulianDate);
			this.Controls.Add(this.labelLopJulianDateText);
			this.Controls.Add(this.labelCcsdsJulianDate);
			this.Controls.Add(this.labelCcsdsJulianDateText);
			this.Controls.Add(this.labelCnesJulianDate);
			this.Controls.Add(this.labelCnesJulianDateText);
			this.Controls.Add(this.labelDublinJulianDate);
			this.Controls.Add(this.labelDublinJulianDateText);
			this.Controls.Add(this.labelTruncatedJulianDate);
			this.Controls.Add(this.labelTruncatedJulianDateText);
			this.Controls.Add(this.labelReducedJulianDate);
			this.Controls.Add(this.labelReducedJulianDateText);
			this.Controls.Add(this.labelModifiedJulianDate);
			this.Controls.Add(this.labelModifiedJulianDateText);
			this.Controls.Add(this.labelJulianDate);
			this.Controls.Add(this.labelJulianDateText);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "JulianDateCalculatorForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "JD calculator";
			this.toolTip.SetToolTip(this, "show more information");
			this.Load += new System.EventHandler(this.JulianDateCalculatorForm_Load);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelUnixtime;
    private System.Windows.Forms.Label labelUnixtimeText;
    private System.Windows.Forms.Label labelMarsSolDate;
    private System.Windows.Forms.Label labelMarsSolDateText;
    private System.Windows.Forms.Label labelRataDie;
    private System.Windows.Forms.Label labelRataDieText;
    private System.Windows.Forms.Label labelLilianDate;
    private System.Windows.Forms.Label labelLilianDateText;
    private System.Windows.Forms.Label labelChronologicalModifiedJulianDate;
    private System.Windows.Forms.Label labelChronologicalModifiedJulianDateText;
    private System.Windows.Forms.Label labelChronologicalJulianDate;
    private System.Windows.Forms.Label labelChronologicalJulianDateText;
    private System.Windows.Forms.Label labelUtcTime;
    private System.Windows.Forms.Label labelUtcTimeText;
    private System.Windows.Forms.Label labelLocalTime;
    private System.Windows.Forms.Label labelLocalTimeText;
    private System.Windows.Forms.Label labelMillenniumJulianDate;
    private System.Windows.Forms.Label labelMillenniumJulianDateText;
    private System.Windows.Forms.Label labelLopJulianDate;
    private System.Windows.Forms.Label labelLopJulianDateText;
    private System.Windows.Forms.Label labelCcsdsJulianDate;
    private System.Windows.Forms.Label labelCcsdsJulianDateText;
    private System.Windows.Forms.Label labelCnesJulianDate;
    private System.Windows.Forms.Label labelCnesJulianDateText;
    private System.Windows.Forms.Label labelDublinJulianDate;
    private System.Windows.Forms.Label labelDublinJulianDateText;
    private System.Windows.Forms.Label labelTruncatedJulianDate;
    private System.Windows.Forms.Label labelTruncatedJulianDateText;
    private System.Windows.Forms.Label labelReducedJulianDate;
    private System.Windows.Forms.Label labelReducedJulianDateText;
    private System.Windows.Forms.Label labelModifiedJulianDate;
    private System.Windows.Forms.Label labelModifiedJulianDateText;
    private System.Windows.Forms.Label labelJulianDate;
    private System.Windows.Forms.Label labelJulianDateText;
    private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.CheckBox checkBoxIgnoreDecimals;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInformation;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTakeScreenshot;
	}
}