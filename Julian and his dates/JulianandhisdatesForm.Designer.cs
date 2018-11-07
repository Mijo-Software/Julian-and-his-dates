namespace Julian_and_his_dates
{
  partial class JulianandhisdatesForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JulianandhisdatesForm));
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.labelJulianDateText = new System.Windows.Forms.Label();
			this.labelJulianDate = new System.Windows.Forms.Label();
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.checkBoxAutomaticRefresh = new System.Windows.Forms.CheckBox();
			this.labelModifiedJulianDateText = new System.Windows.Forms.Label();
			this.labelModifiedJulianDate = new System.Windows.Forms.Label();
			this.labelReducedJulianDate = new System.Windows.Forms.Label();
			this.labelReducedJulianDateText = new System.Windows.Forms.Label();
			this.labelTruncatedJulianDate = new System.Windows.Forms.Label();
			this.labelTruncatedJulianDateText = new System.Windows.Forms.Label();
			this.labelDublinJulianDate = new System.Windows.Forms.Label();
			this.labelDublinJulianDateText = new System.Windows.Forms.Label();
			this.labelCnesJulianDate = new System.Windows.Forms.Label();
			this.labelCnesJulianDateText = new System.Windows.Forms.Label();
			this.labelCcsdsJulianDate = new System.Windows.Forms.Label();
			this.labelCcsdsJulianDateText = new System.Windows.Forms.Label();
			this.labelLopJulianDate = new System.Windows.Forms.Label();
			this.labelLopJulianDateText = new System.Windows.Forms.Label();
			this.labelMillenniumJulianDate = new System.Windows.Forms.Label();
			this.labelMillenniumJulianDateText = new System.Windows.Forms.Label();
			this.buttonInfo = new System.Windows.Forms.Button();
			this.buttonMinimizeToTray = new System.Windows.Forms.Button();
			this.checkBoxStayOnTop = new System.Windows.Forms.CheckBox();
			this.checkBoxDarkLightMode = new System.Windows.Forms.CheckBox();
			this.labelLocalTimeText = new System.Windows.Forms.Label();
			this.labelLocalTime = new System.Windows.Forms.Label();
			this.labelUtcTime = new System.Windows.Forms.Label();
			this.labelUtcTimeText = new System.Windows.Forms.Label();
			this.labelChronologicalJulianDate = new System.Windows.Forms.Label();
			this.labelChronologicalJulianDateText = new System.Windows.Forms.Label();
			this.labelChronologicalModifiedJulianDate = new System.Windows.Forms.Label();
			this.labelChronologicalModifiedJulianDateText = new System.Windows.Forms.Label();
			this.labelLilianDate = new System.Windows.Forms.Label();
			this.labelLilianDateText = new System.Windows.Forms.Label();
			this.labelRataDie = new System.Windows.Forms.Label();
			this.labelRataDieText = new System.Windows.Forms.Label();
			this.labelMarsSolDate = new System.Windows.Forms.Label();
			this.labelMarsSolDateText = new System.Windows.Forms.Label();
			this.labelUnixtime = new System.Windows.Forms.Label();
			this.labelUnixtimeText = new System.Windows.Forms.Label();
			this.buttonOpenJulianDateCalculator = new System.Windows.Forms.Button();
			this.buttonOpenJulianDateConverter = new System.Windows.Forms.Button();
			this.numericUpDownRefreshRate = new System.Windows.Forms.NumericUpDown();
			this.labelRefreshRateText = new System.Windows.Forms.Label();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelAlarm = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelTakeScreenshot = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRefreshRate)).BeginInit();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelJulianDateText
			// 
			this.labelJulianDateText.AccessibleDescription = "Description of the Julian Date";
			this.labelJulianDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelJulianDateText.AutoSize = true;
			this.labelJulianDateText.Location = new System.Drawing.Point(12, 35);
			this.labelJulianDateText.Name = "labelJulianDateText";
			this.labelJulianDateText.Size = new System.Drawing.Size(61, 13);
			this.labelJulianDateText.TabIndex = 4;
			this.labelJulianDateText.Text = "Julian date:";
			this.toolTip.SetToolTip(this.labelJulianDateText, "Click to show more information");
			this.labelJulianDateText.Click += new System.EventHandler(this.LabelJulianDateText_Click);
			this.labelJulianDateText.Enter += new System.EventHandler(this.LabelJulianDateText_Enter);
			this.labelJulianDateText.Leave += new System.EventHandler(this.LabelJulianDateText_Leave);
			this.labelJulianDateText.MouseEnter += new System.EventHandler(this.LabelJulianDateText_MouseEnter);
			this.labelJulianDateText.MouseLeave += new System.EventHandler(this.LabelJulianDateText_MouseLeave);
			// 
			// labelJulianDate
			// 
			this.labelJulianDate.AccessibleDescription = "Value of the Julian Date";
			this.labelJulianDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelJulianDate.AutoSize = true;
			this.labelJulianDate.Location = new System.Drawing.Point(180, 35);
			this.labelJulianDate.Name = "labelJulianDate";
			this.labelJulianDate.Size = new System.Drawing.Size(111, 13);
			this.labelJulianDate.TabIndex = 5;
			this.labelJulianDate.Text = "[your Julian date here]";
			this.toolTip.SetToolTip(this.labelJulianDate, "Double-click to copy into the clipboard");
			this.labelJulianDate.DoubleClick += new System.EventHandler(this.LabelJulianDate_DoubleClick);
			this.labelJulianDate.Enter += new System.EventHandler(this.LabelJulianDate_Enter);
			this.labelJulianDate.Leave += new System.EventHandler(this.LabelJulianDate_Leave);
			this.labelJulianDate.MouseEnter += new System.EventHandler(this.LabelJulianDate_MouseEnter);
			this.labelJulianDate.MouseLeave += new System.EventHandler(this.LabelJulianDate_MouseLeave);
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.AccessibleDescription = "If enabled you can manually refresh the dates";
			this.buttonRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonRefresh.Location = new System.Drawing.Point(15, 303);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(99, 23);
			this.buttonRefresh.TabIndex = 41;
			this.buttonRefresh.Text = "Manual &refresh";
			this.toolTip.SetToolTip(this.buttonRefresh, "If enabled you can manually refresh the dates");
			this.buttonRefresh.UseVisualStyleBackColor = true;
			this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
			this.buttonRefresh.Enter += new System.EventHandler(this.ButtonRefresh_Enter);
			this.buttonRefresh.Leave += new System.EventHandler(this.ButtonRefresh_Leave);
			this.buttonRefresh.MouseEnter += new System.EventHandler(this.ButtonRefresh_MouseEnter);
			this.buttonRefresh.MouseLeave += new System.EventHandler(this.ButtonRefresh_MouseLeave);
			// 
			// checkBoxAutomaticRefresh
			// 
			this.checkBoxAutomaticRefresh.AccessibleDescription = "Enable/Disable to set the automatic refresh of the dates";
			this.checkBoxAutomaticRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
			this.checkBoxAutomaticRefresh.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBoxAutomaticRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.checkBoxAutomaticRefresh.Location = new System.Drawing.Point(15, 245);
			this.checkBoxAutomaticRefresh.Name = "checkBoxAutomaticRefresh";
			this.checkBoxAutomaticRefresh.Size = new System.Drawing.Size(99, 23);
			this.checkBoxAutomaticRefresh.TabIndex = 34;
			this.checkBoxAutomaticRefresh.Text = "&Automatic refresh";
			this.checkBoxAutomaticRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip.SetToolTip(this.checkBoxAutomaticRefresh, "Enable/Disable to set the automatic refresh of the dates");
			this.checkBoxAutomaticRefresh.UseVisualStyleBackColor = true;
			this.checkBoxAutomaticRefresh.CheckedChanged += new System.EventHandler(this.CheckBoxAutomaticRefresh_CheckedChanged);
			this.checkBoxAutomaticRefresh.Enter += new System.EventHandler(this.CheckBoxAutomaticRefresh_Enter);
			this.checkBoxAutomaticRefresh.Leave += new System.EventHandler(this.CheckBoxAutomaticRefresh_Leave);
			this.checkBoxAutomaticRefresh.MouseEnter += new System.EventHandler(this.CheckBoxAutomaticRefresh_MouseEnter);
			this.checkBoxAutomaticRefresh.MouseLeave += new System.EventHandler(this.CheckBoxAutomaticRefresh_MouseLeave);
			// 
			// labelModifiedJulianDateText
			// 
			this.labelModifiedJulianDateText.AccessibleDescription = "Description of the Modified Julian Date";
			this.labelModifiedJulianDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelModifiedJulianDateText.AutoSize = true;
			this.labelModifiedJulianDateText.Location = new System.Drawing.Point(12, 48);
			this.labelModifiedJulianDateText.Name = "labelModifiedJulianDateText";
			this.labelModifiedJulianDateText.Size = new System.Drawing.Size(104, 13);
			this.labelModifiedJulianDateText.TabIndex = 6;
			this.labelModifiedJulianDateText.Text = "Modified Julian date:";
			this.toolTip.SetToolTip(this.labelModifiedJulianDateText, "Click to show more information");
			this.labelModifiedJulianDateText.Click += new System.EventHandler(this.LabelModifiedJulianDateText_Click);
			this.labelModifiedJulianDateText.Enter += new System.EventHandler(this.LabelModifiedJulianDateText_Enter);
			this.labelModifiedJulianDateText.Leave += new System.EventHandler(this.LabelModifiedJulianDateText_Leave);
			this.labelModifiedJulianDateText.MouseEnter += new System.EventHandler(this.LabelModifiedJulianDateText_MouseEnter);
			this.labelModifiedJulianDateText.MouseLeave += new System.EventHandler(this.LabelModifiedJulianDateText_MouseLeave);
			// 
			// labelModifiedJulianDate
			// 
			this.labelModifiedJulianDate.AccessibleDescription = "Value of the Modified Julian Date";
			this.labelModifiedJulianDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelModifiedJulianDate.AutoSize = true;
			this.labelModifiedJulianDate.Location = new System.Drawing.Point(180, 48);
			this.labelModifiedJulianDate.Name = "labelModifiedJulianDate";
			this.labelModifiedJulianDate.Size = new System.Drawing.Size(111, 13);
			this.labelModifiedJulianDate.TabIndex = 7;
			this.labelModifiedJulianDate.Text = "[your Julian date here]";
			this.toolTip.SetToolTip(this.labelModifiedJulianDate, "Double-click to copy into the clipboard");
			this.labelModifiedJulianDate.DoubleClick += new System.EventHandler(this.LabelModifiedJulianDate_DoubleClick);
			this.labelModifiedJulianDate.Enter += new System.EventHandler(this.LabelModifiedJulianDate_Enter);
			this.labelModifiedJulianDate.Leave += new System.EventHandler(this.LabelModifiedJulianDate_Leave);
			this.labelModifiedJulianDate.MouseEnter += new System.EventHandler(this.LabelModifiedJulianDate_MouseEnter);
			this.labelModifiedJulianDate.MouseLeave += new System.EventHandler(this.LabelModifiedJulianDate_MouseLeave);
			// 
			// labelReducedJulianDate
			// 
			this.labelReducedJulianDate.AccessibleDescription = "Value of the Reduced Julian Date";
			this.labelReducedJulianDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelReducedJulianDate.AutoSize = true;
			this.labelReducedJulianDate.Location = new System.Drawing.Point(180, 61);
			this.labelReducedJulianDate.Name = "labelReducedJulianDate";
			this.labelReducedJulianDate.Size = new System.Drawing.Size(111, 13);
			this.labelReducedJulianDate.TabIndex = 9;
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
			this.labelReducedJulianDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelReducedJulianDateText.AutoSize = true;
			this.labelReducedJulianDateText.Location = new System.Drawing.Point(12, 61);
			this.labelReducedJulianDateText.Name = "labelReducedJulianDateText";
			this.labelReducedJulianDateText.Size = new System.Drawing.Size(108, 13);
			this.labelReducedJulianDateText.TabIndex = 8;
			this.labelReducedJulianDateText.Text = "Reduced Julian date:";
			this.toolTip.SetToolTip(this.labelReducedJulianDateText, "Click to show more information");
			this.labelReducedJulianDateText.Click += new System.EventHandler(this.LabelReducedJulianDateText_Click);
			this.labelReducedJulianDateText.Enter += new System.EventHandler(this.LabelReducedJulianDateText_Enter);
			this.labelReducedJulianDateText.Leave += new System.EventHandler(this.LabelReducedJulianDateText_Leave);
			this.labelReducedJulianDateText.MouseEnter += new System.EventHandler(this.LabelReducedJulianDateText_MouseEnter);
			this.labelReducedJulianDateText.MouseLeave += new System.EventHandler(this.LabelReducedJulianDateText_MouseLeave);
			// 
			// labelTruncatedJulianDate
			// 
			this.labelTruncatedJulianDate.AccessibleDescription = "Value of the Truncated Julian Date";
			this.labelTruncatedJulianDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelTruncatedJulianDate.AutoSize = true;
			this.labelTruncatedJulianDate.Location = new System.Drawing.Point(180, 74);
			this.labelTruncatedJulianDate.Name = "labelTruncatedJulianDate";
			this.labelTruncatedJulianDate.Size = new System.Drawing.Size(111, 13);
			this.labelTruncatedJulianDate.TabIndex = 11;
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
			this.labelTruncatedJulianDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelTruncatedJulianDateText.AutoSize = true;
			this.labelTruncatedJulianDateText.Location = new System.Drawing.Point(12, 74);
			this.labelTruncatedJulianDateText.Name = "labelTruncatedJulianDateText";
			this.labelTruncatedJulianDateText.Size = new System.Drawing.Size(113, 13);
			this.labelTruncatedJulianDateText.TabIndex = 10;
			this.labelTruncatedJulianDateText.Text = "Truncated Julian date:";
			this.toolTip.SetToolTip(this.labelTruncatedJulianDateText, "Click to show more information");
			this.labelTruncatedJulianDateText.Click += new System.EventHandler(this.LabelTruncatedJulianDateText_Click);
			this.labelTruncatedJulianDateText.Enter += new System.EventHandler(this.LabelTruncatedJulianDateText_Enter);
			this.labelTruncatedJulianDateText.Leave += new System.EventHandler(this.LabelTruncatedJulianDateText_Leave);
			this.labelTruncatedJulianDateText.MouseEnter += new System.EventHandler(this.LabelTruncatedJulianDateText_MouseEnter);
			this.labelTruncatedJulianDateText.MouseLeave += new System.EventHandler(this.LabelTruncatedJulianDateText_MouseLeave);
			// 
			// labelDublinJulianDate
			// 
			this.labelDublinJulianDate.AccessibleDescription = "Value of the Dublin Julian Date";
			this.labelDublinJulianDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelDublinJulianDate.AutoSize = true;
			this.labelDublinJulianDate.Location = new System.Drawing.Point(180, 87);
			this.labelDublinJulianDate.Name = "labelDublinJulianDate";
			this.labelDublinJulianDate.Size = new System.Drawing.Size(111, 13);
			this.labelDublinJulianDate.TabIndex = 13;
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
			this.labelDublinJulianDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelDublinJulianDateText.AutoSize = true;
			this.labelDublinJulianDateText.Location = new System.Drawing.Point(12, 87);
			this.labelDublinJulianDateText.Name = "labelDublinJulianDateText";
			this.labelDublinJulianDateText.Size = new System.Drawing.Size(94, 13);
			this.labelDublinJulianDateText.TabIndex = 12;
			this.labelDublinJulianDateText.Text = "Dublin Julian date:";
			this.toolTip.SetToolTip(this.labelDublinJulianDateText, "Click to show more information");
			this.labelDublinJulianDateText.Click += new System.EventHandler(this.LabelDublinJulianDateText_Click);
			this.labelDublinJulianDateText.Enter += new System.EventHandler(this.LabelDublinJulianDateText_Enter);
			this.labelDublinJulianDateText.Leave += new System.EventHandler(this.LabelDublinJulianDateText_Leave);
			this.labelDublinJulianDateText.MouseEnter += new System.EventHandler(this.LabelDublinJulianDateText_MouseEnter);
			this.labelDublinJulianDateText.MouseLeave += new System.EventHandler(this.LabelDublinJulianDateText_MouseLeave);
			// 
			// labelCnesJulianDate
			// 
			this.labelCnesJulianDate.AccessibleDescription = "Value of the CNES Julian Date";
			this.labelCnesJulianDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelCnesJulianDate.AutoSize = true;
			this.labelCnesJulianDate.Location = new System.Drawing.Point(180, 100);
			this.labelCnesJulianDate.Name = "labelCnesJulianDate";
			this.labelCnesJulianDate.Size = new System.Drawing.Size(111, 13);
			this.labelCnesJulianDate.TabIndex = 15;
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
			this.labelCnesJulianDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelCnesJulianDateText.AutoSize = true;
			this.labelCnesJulianDateText.Location = new System.Drawing.Point(12, 100);
			this.labelCnesJulianDateText.Name = "labelCnesJulianDateText";
			this.labelCnesJulianDateText.Size = new System.Drawing.Size(93, 13);
			this.labelCnesJulianDateText.TabIndex = 14;
			this.labelCnesJulianDateText.Text = "CNES Julian date:";
			this.toolTip.SetToolTip(this.labelCnesJulianDateText, "Click to show more information");
			this.labelCnesJulianDateText.Click += new System.EventHandler(this.LabelCnesJulianDateText_Click);
			this.labelCnesJulianDateText.Enter += new System.EventHandler(this.LabelCnesJulianDateText_Enter);
			this.labelCnesJulianDateText.Leave += new System.EventHandler(this.LabelCnesJulianDateText_Leave);
			this.labelCnesJulianDateText.MouseEnter += new System.EventHandler(this.LabelCnesJulianDateText_MouseEnter);
			this.labelCnesJulianDateText.MouseLeave += new System.EventHandler(this.LabelCnesJulianDateText_MouseLeave);
			// 
			// labelCcsdsJulianDate
			// 
			this.labelCcsdsJulianDate.AccessibleDescription = "Value of the CCSDS Julian Date";
			this.labelCcsdsJulianDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelCcsdsJulianDate.AutoSize = true;
			this.labelCcsdsJulianDate.Location = new System.Drawing.Point(180, 113);
			this.labelCcsdsJulianDate.Name = "labelCcsdsJulianDate";
			this.labelCcsdsJulianDate.Size = new System.Drawing.Size(111, 13);
			this.labelCcsdsJulianDate.TabIndex = 17;
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
			this.labelCcsdsJulianDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelCcsdsJulianDateText.AutoSize = true;
			this.labelCcsdsJulianDateText.Location = new System.Drawing.Point(12, 113);
			this.labelCcsdsJulianDateText.Name = "labelCcsdsJulianDateText";
			this.labelCcsdsJulianDateText.Size = new System.Drawing.Size(100, 13);
			this.labelCcsdsJulianDateText.TabIndex = 16;
			this.labelCcsdsJulianDateText.Text = "CCSDS Julian date:";
			this.toolTip.SetToolTip(this.labelCcsdsJulianDateText, "Click to show more information");
			this.labelCcsdsJulianDateText.Click += new System.EventHandler(this.LabelCcsdsJulianDateText_Click);
			this.labelCcsdsJulianDateText.Enter += new System.EventHandler(this.LabelCcsdsJulianDateText_Enter);
			this.labelCcsdsJulianDateText.Leave += new System.EventHandler(this.LabelCcsdsJulianDateText_Leave);
			this.labelCcsdsJulianDateText.MouseEnter += new System.EventHandler(this.LabelCcsdsJulianDateText_MouseEnter);
			this.labelCcsdsJulianDateText.MouseLeave += new System.EventHandler(this.LabelCcsdsJulianDateText_MouseLeave);
			// 
			// labelLopJulianDate
			// 
			this.labelLopJulianDate.AccessibleDescription = "Value of the LOP Julian Date";
			this.labelLopJulianDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelLopJulianDate.AutoSize = true;
			this.labelLopJulianDate.Location = new System.Drawing.Point(180, 126);
			this.labelLopJulianDate.Name = "labelLopJulianDate";
			this.labelLopJulianDate.Size = new System.Drawing.Size(111, 13);
			this.labelLopJulianDate.TabIndex = 19;
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
			this.labelLopJulianDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelLopJulianDateText.AutoSize = true;
			this.labelLopJulianDateText.Location = new System.Drawing.Point(12, 126);
			this.labelLopJulianDateText.Name = "labelLopJulianDateText";
			this.labelLopJulianDateText.Size = new System.Drawing.Size(85, 13);
			this.labelLopJulianDateText.TabIndex = 18;
			this.labelLopJulianDateText.Text = "LOP Julian date:";
			this.toolTip.SetToolTip(this.labelLopJulianDateText, "Click to show more information");
			this.labelLopJulianDateText.Click += new System.EventHandler(this.LabelLopJulianDateText_Click);
			this.labelLopJulianDateText.Enter += new System.EventHandler(this.LabelLopJulianDateText_Enter);
			this.labelLopJulianDateText.Leave += new System.EventHandler(this.LabelLopJulianDateText_Leave);
			this.labelLopJulianDateText.MouseEnter += new System.EventHandler(this.LabelLopJulianDateText_MouseEnter);
			this.labelLopJulianDateText.MouseLeave += new System.EventHandler(this.LabelLopJulianDateText_MouseLeave);
			// 
			// labelMillenniumJulianDate
			// 
			this.labelMillenniumJulianDate.AccessibleDescription = "Value of the Millenium Julian Date";
			this.labelMillenniumJulianDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelMillenniumJulianDate.AutoSize = true;
			this.labelMillenniumJulianDate.Location = new System.Drawing.Point(180, 139);
			this.labelMillenniumJulianDate.Name = "labelMillenniumJulianDate";
			this.labelMillenniumJulianDate.Size = new System.Drawing.Size(111, 13);
			this.labelMillenniumJulianDate.TabIndex = 21;
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
			this.labelMillenniumJulianDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelMillenniumJulianDateText.AutoSize = true;
			this.labelMillenniumJulianDateText.Location = new System.Drawing.Point(12, 139);
			this.labelMillenniumJulianDateText.Name = "labelMillenniumJulianDateText";
			this.labelMillenniumJulianDateText.Size = new System.Drawing.Size(113, 13);
			this.labelMillenniumJulianDateText.TabIndex = 20;
			this.labelMillenniumJulianDateText.Text = "Millennium Julian date:";
			this.toolTip.SetToolTip(this.labelMillenniumJulianDateText, "Click to show more information");
			this.labelMillenniumJulianDateText.Click += new System.EventHandler(this.LabelMillenniumJulianDateText_Click);
			this.labelMillenniumJulianDateText.Enter += new System.EventHandler(this.LabelMillenniumJulianDateText_Enter);
			this.labelMillenniumJulianDateText.Leave += new System.EventHandler(this.LabelMillenniumJulianDateText_Leave);
			this.labelMillenniumJulianDateText.MouseEnter += new System.EventHandler(this.LabelMillenniumJulianDateText_MouseEnter);
			this.labelMillenniumJulianDateText.MouseLeave += new System.EventHandler(this.LabelMillenniumJulianDateText_MouseLeave);
			// 
			// buttonInfo
			// 
			this.buttonInfo.AccessibleDescription = "Show some information";
			this.buttonInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonInfo.Location = new System.Drawing.Point(215, 274);
			this.buttonInfo.Name = "buttonInfo";
			this.buttonInfo.Size = new System.Drawing.Size(76, 23);
			this.buttonInfo.TabIndex = 40;
			this.buttonInfo.Text = "&Info";
			this.toolTip.SetToolTip(this.buttonInfo, "Show some information");
			this.buttonInfo.UseVisualStyleBackColor = true;
			this.buttonInfo.Click += new System.EventHandler(this.ButtonInfo_Click);
			this.buttonInfo.Enter += new System.EventHandler(this.ButtonInfo_Enter);
			this.buttonInfo.Leave += new System.EventHandler(this.ButtonInfo_Leave);
			this.buttonInfo.MouseEnter += new System.EventHandler(this.ButtonInfo_MouseEnter);
			this.buttonInfo.MouseLeave += new System.EventHandler(this.ButtonInfo_MouseLeave);
			// 
			// buttonMinimizeToTray
			// 
			this.buttonMinimizeToTray.AccessibleDescription = "Minimize the application to the tray";
			this.buttonMinimizeToTray.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonMinimizeToTray.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonMinimizeToTray.Location = new System.Drawing.Point(120, 274);
			this.buttonMinimizeToTray.Name = "buttonMinimizeToTray";
			this.buttonMinimizeToTray.Size = new System.Drawing.Size(89, 23);
			this.buttonMinimizeToTray.TabIndex = 39;
			this.buttonMinimizeToTray.Text = "&Minimize to tray";
			this.toolTip.SetToolTip(this.buttonMinimizeToTray, "Minimize the application to the tray");
			this.buttonMinimizeToTray.UseVisualStyleBackColor = true;
			this.buttonMinimizeToTray.Click += new System.EventHandler(this.ButtonMinimizeToTray_Click);
			this.buttonMinimizeToTray.Enter += new System.EventHandler(this.ButtonMinimizeToTray_Enter);
			this.buttonMinimizeToTray.Leave += new System.EventHandler(this.ButtonMinimizeToTray_Leave);
			this.buttonMinimizeToTray.MouseEnter += new System.EventHandler(this.ButtonMinimizeToTray_MouseEnter);
			this.buttonMinimizeToTray.MouseLeave += new System.EventHandler(this.ButtonMinimizeToTray_MouseLeave);
			// 
			// checkBoxStayOnTop
			// 
			this.checkBoxStayOnTop.AccessibleDescription = "Enable/Disable to set the application on top";
			this.checkBoxStayOnTop.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
			this.checkBoxStayOnTop.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBoxStayOnTop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.checkBoxStayOnTop.Location = new System.Drawing.Point(120, 245);
			this.checkBoxStayOnTop.Name = "checkBoxStayOnTop";
			this.checkBoxStayOnTop.Size = new System.Drawing.Size(89, 23);
			this.checkBoxStayOnTop.TabIndex = 35;
			this.checkBoxStayOnTop.Text = "Always on &top";
			this.checkBoxStayOnTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip.SetToolTip(this.checkBoxStayOnTop, "Enable/Disable to set the application on top");
			this.checkBoxStayOnTop.UseVisualStyleBackColor = true;
			this.checkBoxStayOnTop.CheckedChanged += new System.EventHandler(this.CheckBoxStayOnTop_CheckedChanged);
			this.checkBoxStayOnTop.Enter += new System.EventHandler(this.CheckBoxStayOnTop_Enter);
			this.checkBoxStayOnTop.Leave += new System.EventHandler(this.CheckBoxStayOnTop_Leave);
			this.checkBoxStayOnTop.MouseEnter += new System.EventHandler(this.CheckBoxStayOnTop_MouseEnter);
			this.checkBoxStayOnTop.MouseLeave += new System.EventHandler(this.CheckBoxStayOnTop_MouseLeave);
			// 
			// checkBoxDarkLightMode
			// 
			this.checkBoxDarkLightMode.AccessibleDescription = "Enable/Disable the dark mode";
			this.checkBoxDarkLightMode.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
			this.checkBoxDarkLightMode.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBoxDarkLightMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.checkBoxDarkLightMode.Location = new System.Drawing.Point(215, 245);
			this.checkBoxDarkLightMode.Name = "checkBoxDarkLightMode";
			this.checkBoxDarkLightMode.Size = new System.Drawing.Size(76, 23);
			this.checkBoxDarkLightMode.TabIndex = 36;
			this.checkBoxDarkLightMode.Text = "&Dark mode";
			this.checkBoxDarkLightMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip.SetToolTip(this.checkBoxDarkLightMode, "Enable/Disable the dark mode");
			this.checkBoxDarkLightMode.UseVisualStyleBackColor = true;
			this.checkBoxDarkLightMode.CheckedChanged += new System.EventHandler(this.CheckBoxDarkLightMode_CheckedChanged);
			this.checkBoxDarkLightMode.Enter += new System.EventHandler(this.CheckBoxDarkLightMode_Enter);
			this.checkBoxDarkLightMode.Leave += new System.EventHandler(this.CheckBoxDarkLightMode_Leave);
			this.checkBoxDarkLightMode.MouseEnter += new System.EventHandler(this.CheckBoxDarkLightMode_MouseEnter);
			this.checkBoxDarkLightMode.MouseLeave += new System.EventHandler(this.CheckBoxDarkLightMode_MouseLeave);
			// 
			// labelLocalTimeText
			// 
			this.labelLocalTimeText.AccessibleDescription = "Description of the local time";
			this.labelLocalTimeText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelLocalTimeText.AutoSize = true;
			this.labelLocalTimeText.Location = new System.Drawing.Point(12, 22);
			this.labelLocalTimeText.Name = "labelLocalTimeText";
			this.labelLocalTimeText.Size = new System.Drawing.Size(58, 13);
			this.labelLocalTimeText.TabIndex = 2;
			this.labelLocalTimeText.Text = "Local time:";
			this.toolTip.SetToolTip(this.labelLocalTimeText, "Click to show more information");
			this.labelLocalTimeText.Click += new System.EventHandler(this.LabelLocalTimeText_Click);
			this.labelLocalTimeText.Enter += new System.EventHandler(this.LabelLocalTimeText_Enter);
			this.labelLocalTimeText.Leave += new System.EventHandler(this.LabelLocalTimeText_Leave);
			this.labelLocalTimeText.MouseEnter += new System.EventHandler(this.LabelLocalTimeText_MouseEnter);
			this.labelLocalTimeText.MouseLeave += new System.EventHandler(this.LabelLocalTimeText_MouseLeave);
			// 
			// labelLocalTime
			// 
			this.labelLocalTime.AccessibleDescription = "Value of the local time";
			this.labelLocalTime.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelLocalTime.AutoSize = true;
			this.labelLocalTime.Location = new System.Drawing.Point(180, 22);
			this.labelLocalTime.Name = "labelLocalTime";
			this.labelLocalTime.Size = new System.Drawing.Size(104, 13);
			this.labelLocalTime.TabIndex = 3;
			this.labelLocalTime.Text = "[your local time here]";
			this.toolTip.SetToolTip(this.labelLocalTime, "Double-click to copy into the clipboard");
			this.labelLocalTime.DoubleClick += new System.EventHandler(this.LabelLocalTime_DoubleClick);
			this.labelLocalTime.Enter += new System.EventHandler(this.LabelLocalTime_Enter);
			this.labelLocalTime.Leave += new System.EventHandler(this.LabelLocalTime_Leave);
			this.labelLocalTime.MouseEnter += new System.EventHandler(this.LabelLocalTime_MouseEnter);
			this.labelLocalTime.MouseLeave += new System.EventHandler(this.LabelLocalTime_MouseLeave);
			// 
			// labelUtcTime
			// 
			this.labelUtcTime.AccessibleDescription = "Value of the UTC time";
			this.labelUtcTime.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelUtcTime.AutoSize = true;
			this.labelUtcTime.Location = new System.Drawing.Point(180, 9);
			this.labelUtcTime.Name = "labelUtcTime";
			this.labelUtcTime.Size = new System.Drawing.Size(104, 13);
			this.labelUtcTime.TabIndex = 1;
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
			this.labelUtcTimeText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelUtcTimeText.AutoSize = true;
			this.labelUtcTimeText.Location = new System.Drawing.Point(12, 9);
			this.labelUtcTimeText.Name = "labelUtcTimeText";
			this.labelUtcTimeText.Size = new System.Drawing.Size(54, 13);
			this.labelUtcTimeText.TabIndex = 0;
			this.labelUtcTimeText.Text = "UTC time:";
			this.toolTip.SetToolTip(this.labelUtcTimeText, "Click to show more information");
			this.labelUtcTimeText.Click += new System.EventHandler(this.LabelUtcTimeText_Click);
			this.labelUtcTimeText.Enter += new System.EventHandler(this.LabelUtcTimeText_Enter);
			this.labelUtcTimeText.Leave += new System.EventHandler(this.LabelUtcTimeText_Leave);
			this.labelUtcTimeText.MouseEnter += new System.EventHandler(this.LabelUtcTimeText_MouseEnter);
			this.labelUtcTimeText.MouseLeave += new System.EventHandler(this.LabelUtcTimeText_MouseLeave);
			// 
			// labelChronologicalJulianDate
			// 
			this.labelChronologicalJulianDate.AccessibleDescription = "Value of the Chronological Julian Date";
			this.labelChronologicalJulianDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelChronologicalJulianDate.AutoSize = true;
			this.labelChronologicalJulianDate.Location = new System.Drawing.Point(180, 152);
			this.labelChronologicalJulianDate.Name = "labelChronologicalJulianDate";
			this.labelChronologicalJulianDate.Size = new System.Drawing.Size(111, 13);
			this.labelChronologicalJulianDate.TabIndex = 23;
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
			this.labelChronologicalJulianDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelChronologicalJulianDateText.AutoSize = true;
			this.labelChronologicalJulianDateText.Location = new System.Drawing.Point(12, 152);
			this.labelChronologicalJulianDateText.Name = "labelChronologicalJulianDateText";
			this.labelChronologicalJulianDateText.Size = new System.Drawing.Size(128, 13);
			this.labelChronologicalJulianDateText.TabIndex = 22;
			this.labelChronologicalJulianDateText.Text = "Chronological Julian date:";
			this.toolTip.SetToolTip(this.labelChronologicalJulianDateText, "Click to show more information");
			this.labelChronologicalJulianDateText.Click += new System.EventHandler(this.LabelChronologicalJulianDateText_Click);
			this.labelChronologicalJulianDateText.Enter += new System.EventHandler(this.LabelChronologicalJulianDateText_Enter);
			this.labelChronologicalJulianDateText.Leave += new System.EventHandler(this.LabelChronologicalJulianDateText_Leave);
			this.labelChronologicalJulianDateText.MouseEnter += new System.EventHandler(this.LabelChronologicalJulianDateText_MouseEnter);
			this.labelChronologicalJulianDateText.MouseLeave += new System.EventHandler(this.LabelChronologicalJulianDateText_MouseLeave);
			// 
			// labelChronologicalModifiedJulianDate
			// 
			this.labelChronologicalModifiedJulianDate.AccessibleDescription = "Value of the Chronological Modified Julian Date";
			this.labelChronologicalModifiedJulianDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelChronologicalModifiedJulianDate.AutoSize = true;
			this.labelChronologicalModifiedJulianDate.Location = new System.Drawing.Point(180, 165);
			this.labelChronologicalModifiedJulianDate.Name = "labelChronologicalModifiedJulianDate";
			this.labelChronologicalModifiedJulianDate.Size = new System.Drawing.Size(111, 13);
			this.labelChronologicalModifiedJulianDate.TabIndex = 25;
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
			this.labelChronologicalModifiedJulianDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelChronologicalModifiedJulianDateText.AutoSize = true;
			this.labelChronologicalModifiedJulianDateText.Location = new System.Drawing.Point(12, 165);
			this.labelChronologicalModifiedJulianDateText.Name = "labelChronologicalModifiedJulianDateText";
			this.labelChronologicalModifiedJulianDateText.Size = new System.Drawing.Size(171, 13);
			this.labelChronologicalModifiedJulianDateText.TabIndex = 24;
			this.labelChronologicalModifiedJulianDateText.Text = "Chronological Modified Julian date:";
			this.toolTip.SetToolTip(this.labelChronologicalModifiedJulianDateText, "Click to show more information");
			this.labelChronologicalModifiedJulianDateText.Click += new System.EventHandler(this.LabelChronologicalModifiedJulianDateText_Click);
			this.labelChronologicalModifiedJulianDateText.Enter += new System.EventHandler(this.LabelChronologicalModifiedJulianDateText_Enter);
			this.labelChronologicalModifiedJulianDateText.Leave += new System.EventHandler(this.LabelChronologicalModifiedJulianDateText_Leave);
			this.labelChronologicalModifiedJulianDateText.MouseEnter += new System.EventHandler(this.LabelChronologicalModifiedJulianDateText_MouseEnter);
			this.labelChronologicalModifiedJulianDateText.MouseLeave += new System.EventHandler(this.LabelChronologicalModifiedJulianDateText_MouseLeave);
			// 
			// labelLilianDate
			// 
			this.labelLilianDate.AccessibleDescription = "Value of the Lilian Date";
			this.labelLilianDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelLilianDate.AutoSize = true;
			this.labelLilianDate.Location = new System.Drawing.Point(180, 178);
			this.labelLilianDate.Name = "labelLilianDate";
			this.labelLilianDate.Size = new System.Drawing.Size(111, 13);
			this.labelLilianDate.TabIndex = 27;
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
			this.labelLilianDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelLilianDateText.AutoSize = true;
			this.labelLilianDateText.Location = new System.Drawing.Point(12, 178);
			this.labelLilianDateText.Name = "labelLilianDateText";
			this.labelLilianDateText.Size = new System.Drawing.Size(60, 13);
			this.labelLilianDateText.TabIndex = 26;
			this.labelLilianDateText.Text = "Lilian Date:";
			this.toolTip.SetToolTip(this.labelLilianDateText, "Click to show more information");
			this.labelLilianDateText.Click += new System.EventHandler(this.LabelLilianDateText_Click);
			this.labelLilianDateText.Enter += new System.EventHandler(this.LabelLilianDateText_Enter);
			this.labelLilianDateText.Leave += new System.EventHandler(this.LabelLilianDateText_Leave);
			this.labelLilianDateText.MouseEnter += new System.EventHandler(this.LabelLilianDateText_MouseEnter);
			this.labelLilianDateText.MouseLeave += new System.EventHandler(this.LabelLilianDateText_MouseLeave);
			// 
			// labelRataDie
			// 
			this.labelRataDie.AccessibleDescription = "Value of the Rata Die";
			this.labelRataDie.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelRataDie.AutoSize = true;
			this.labelRataDie.Location = new System.Drawing.Point(180, 191);
			this.labelRataDie.Name = "labelRataDie";
			this.labelRataDie.Size = new System.Drawing.Size(111, 13);
			this.labelRataDie.TabIndex = 29;
			this.labelRataDie.Text = "[your Julian date here]";
			this.toolTip.SetToolTip(this.labelRataDie, "Double-click to copy into the clipboard");
			this.labelRataDie.DoubleClick += new System.EventHandler(this.LabelRataDie_DoubleClick);
			this.labelRataDie.Enter += new System.EventHandler(this.LabelRataDie_Enter);
			this.labelRataDie.MouseEnter += new System.EventHandler(this.LabelRataDie_MouseEnter);
			this.labelRataDie.MouseLeave += new System.EventHandler(this.LabelRataDie_MouseLeave);
			// 
			// labelRataDieText
			// 
			this.labelRataDieText.AccessibleDescription = "Description of the Rata Die";
			this.labelRataDieText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelRataDieText.AutoSize = true;
			this.labelRataDieText.Location = new System.Drawing.Point(12, 191);
			this.labelRataDieText.Name = "labelRataDieText";
			this.labelRataDieText.Size = new System.Drawing.Size(52, 13);
			this.labelRataDieText.TabIndex = 28;
			this.labelRataDieText.Text = "Rata Die:";
			this.toolTip.SetToolTip(this.labelRataDieText, "Click to show more information");
			this.labelRataDieText.Click += new System.EventHandler(this.LabelRataDieText_Click);
			this.labelRataDieText.Enter += new System.EventHandler(this.LabelRataDieText_Enter);
			this.labelRataDieText.Leave += new System.EventHandler(this.LabelRataDieText_Leave);
			this.labelRataDieText.MouseEnter += new System.EventHandler(this.LabelRataDieText_MouseEnter);
			this.labelRataDieText.MouseLeave += new System.EventHandler(this.LabelRataDieText_MouseLeave);
			// 
			// labelMarsSolDate
			// 
			this.labelMarsSolDate.AccessibleDescription = "Value of the Mars Sol Date";
			this.labelMarsSolDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelMarsSolDate.AutoSize = true;
			this.labelMarsSolDate.Location = new System.Drawing.Point(180, 204);
			this.labelMarsSolDate.Name = "labelMarsSolDate";
			this.labelMarsSolDate.Size = new System.Drawing.Size(111, 13);
			this.labelMarsSolDate.TabIndex = 31;
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
			this.labelMarsSolDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelMarsSolDateText.AutoSize = true;
			this.labelMarsSolDateText.Location = new System.Drawing.Point(12, 204);
			this.labelMarsSolDateText.Name = "labelMarsSolDateText";
			this.labelMarsSolDateText.Size = new System.Drawing.Size(77, 13);
			this.labelMarsSolDateText.TabIndex = 30;
			this.labelMarsSolDateText.Text = "Mars Sol Date:";
			this.toolTip.SetToolTip(this.labelMarsSolDateText, "Click to show more information");
			this.labelMarsSolDateText.Click += new System.EventHandler(this.LabelMarsSolDateText_Click);
			this.labelMarsSolDateText.Enter += new System.EventHandler(this.LabelMarsSolDateText_Enter);
			this.labelMarsSolDateText.Leave += new System.EventHandler(this.LabelMarsSolDateText_Leave);
			this.labelMarsSolDateText.MouseEnter += new System.EventHandler(this.LabelMarsSolDateText_MouseEnter);
			this.labelMarsSolDateText.MouseLeave += new System.EventHandler(this.LabelMarsSolDateText_MouseLeave);
			// 
			// labelUnixtime
			// 
			this.labelUnixtime.AccessibleDescription = "Value of the Unixtime";
			this.labelUnixtime.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelUnixtime.AutoSize = true;
			this.labelUnixtime.Location = new System.Drawing.Point(180, 217);
			this.labelUnixtime.Name = "labelUnixtime";
			this.labelUnixtime.Size = new System.Drawing.Size(111, 13);
			this.labelUnixtime.TabIndex = 33;
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
			this.labelUnixtimeText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelUnixtimeText.AutoSize = true;
			this.labelUnixtimeText.Location = new System.Drawing.Point(12, 217);
			this.labelUnixtimeText.Name = "labelUnixtimeText";
			this.labelUnixtimeText.Size = new System.Drawing.Size(53, 13);
			this.labelUnixtimeText.TabIndex = 32;
			this.labelUnixtimeText.Text = "Unix time:";
			this.toolTip.SetToolTip(this.labelUnixtimeText, "Click to show more information");
			this.labelUnixtimeText.Click += new System.EventHandler(this.LabelUnixtimeText_Click);
			this.labelUnixtimeText.Enter += new System.EventHandler(this.LabelUnixtimeText_Enter);
			this.labelUnixtimeText.Leave += new System.EventHandler(this.LabelUnixtimeText_Leave);
			this.labelUnixtimeText.MouseEnter += new System.EventHandler(this.LabelUnixtimeText_MouseEnter);
			this.labelUnixtimeText.MouseLeave += new System.EventHandler(this.LabelUnixtimeText_MouseLeave);
			// 
			// buttonOpenJulianDateCalculator
			// 
			this.buttonOpenJulianDateCalculator.AccessibleDescription = "Open the Julian Dates Calculator";
			this.buttonOpenJulianDateCalculator.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonOpenJulianDateCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonOpenJulianDateCalculator.Location = new System.Drawing.Point(120, 303);
			this.buttonOpenJulianDateCalculator.Name = "buttonOpenJulianDateCalculator";
			this.buttonOpenJulianDateCalculator.Size = new System.Drawing.Size(89, 23);
			this.buttonOpenJulianDateCalculator.TabIndex = 42;
			this.buttonOpenJulianDateCalculator.Text = "JD calculator";
			this.toolTip.SetToolTip(this.buttonOpenJulianDateCalculator, "Open the Julian Dates Calculator");
			this.buttonOpenJulianDateCalculator.UseVisualStyleBackColor = true;
			this.buttonOpenJulianDateCalculator.Click += new System.EventHandler(this.ButtonOpenJulianDateCalculator_Click);
			this.buttonOpenJulianDateCalculator.Enter += new System.EventHandler(this.ButtonOpenJulianDateCalculator_Enter);
			this.buttonOpenJulianDateCalculator.Leave += new System.EventHandler(this.ButtonOpenJulianDateCalculator_Leave);
			this.buttonOpenJulianDateCalculator.MouseEnter += new System.EventHandler(this.ButtonOpenJulianDateCalculator_MouseEnter);
			this.buttonOpenJulianDateCalculator.MouseLeave += new System.EventHandler(this.ButtonOpenJulianDateCalculator_MouseLeave);
			// 
			// buttonOpenJulianDateConverter
			// 
			this.buttonOpenJulianDateConverter.AccessibleDescription = "Open the Julian Dates Converter";
			this.buttonOpenJulianDateConverter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonOpenJulianDateConverter.Enabled = false;
			this.buttonOpenJulianDateConverter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonOpenJulianDateConverter.Location = new System.Drawing.Point(215, 303);
			this.buttonOpenJulianDateConverter.Name = "buttonOpenJulianDateConverter";
			this.buttonOpenJulianDateConverter.Size = new System.Drawing.Size(76, 23);
			this.buttonOpenJulianDateConverter.TabIndex = 43;
			this.buttonOpenJulianDateConverter.Text = "JD converter";
			this.toolTip.SetToolTip(this.buttonOpenJulianDateConverter, "Open the Julian Dates Converter");
			this.buttonOpenJulianDateConverter.UseVisualStyleBackColor = true;
			this.buttonOpenJulianDateConverter.Visible = false;
			this.buttonOpenJulianDateConverter.Click += new System.EventHandler(this.ButtonOpenJulianDateConverter_Click);
			this.buttonOpenJulianDateConverter.Enter += new System.EventHandler(this.ButtonOpenJulianDateConverter_Enter);
			this.buttonOpenJulianDateConverter.Leave += new System.EventHandler(this.ButtonOpenJulianDateConverter_Leave);
			this.buttonOpenJulianDateConverter.MouseEnter += new System.EventHandler(this.ButtonOpenJulianDateConverter_MouseEnter);
			this.buttonOpenJulianDateConverter.MouseLeave += new System.EventHandler(this.ButtonOpenJulianDateConverter_MouseLeave);
			// 
			// numericUpDownRefreshRate
			// 
			this.numericUpDownRefreshRate.AccessibleDescription = "Refresh rate in milliseconds";
			this.numericUpDownRefreshRate.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
			this.numericUpDownRefreshRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDownRefreshRate.Location = new System.Drawing.Point(76, 275);
			this.numericUpDownRefreshRate.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.numericUpDownRefreshRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownRefreshRate.Name = "numericUpDownRefreshRate";
			this.numericUpDownRefreshRate.Size = new System.Drawing.Size(40, 20);
			this.numericUpDownRefreshRate.TabIndex = 38;
			this.toolTip.SetToolTip(this.numericUpDownRefreshRate, "Refresh rate in milliseconds");
			this.numericUpDownRefreshRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownRefreshRate.ValueChanged += new System.EventHandler(this.NumericUpDownRefreshRate_ValueChanged);
			this.numericUpDownRefreshRate.Enter += new System.EventHandler(this.NumericUpDownRefreshRate_Enter);
			this.numericUpDownRefreshRate.Leave += new System.EventHandler(this.NumericUpDownRefreshRate_Leave);
			// 
			// labelRefreshRateText
			// 
			this.labelRefreshRateText.AccessibleDescription = "Refresh rate in milliseconds";
			this.labelRefreshRateText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelRefreshRateText.AutoSize = true;
			this.labelRefreshRateText.Location = new System.Drawing.Point(15, 277);
			this.labelRefreshRateText.Name = "labelRefreshRateText";
			this.labelRefreshRateText.Size = new System.Drawing.Size(60, 13);
			this.labelRefreshRateText.TabIndex = 37;
			this.labelRefreshRateText.Text = "refresh rate";
			this.toolTip.SetToolTip(this.labelRefreshRateText, "Refresh rate in milliseconds");
			this.labelRefreshRateText.DoubleClick += new System.EventHandler(this.LabelRefreshRateText_DoubleClick);
			this.labelRefreshRateText.Enter += new System.EventHandler(this.LabelRefreshRateText_Enter);
			this.labelRefreshRateText.Leave += new System.EventHandler(this.LabelRefreshRateText_Leave);
			this.labelRefreshRateText.MouseEnter += new System.EventHandler(this.LabelRefreshRateText_MouseEnter);
			this.labelRefreshRateText.MouseLeave += new System.EventHandler(this.LabelRefreshRateText_MouseLeave);
			// 
			// notifyIcon
			// 
			this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "Julian an his dates";
			this.notifyIcon.Visible = true;
			this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 20;
			this.timer.Tick += new System.EventHandler(this.Timer_Tick);
			// 
			// statusStrip
			// 
			this.statusStrip.AccessibleDescription = "Statusbar";
			this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInformation,
            this.toolStripStatusLabelAlarm,
            this.toolStripStatusLabelTakeScreenshot});
			this.statusStrip.Location = new System.Drawing.Point(0, 338);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.ShowItemToolTips = true;
			this.statusStrip.Size = new System.Drawing.Size(303, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 44;
			this.statusStrip.Text = "statusStrip";
			// 
			// toolStripStatusLabelInformation
			// 
			this.toolStripStatusLabelInformation.AccessibleDescription = "Show some information";
			this.toolStripStatusLabelInformation.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.toolStripStatusLabelInformation.AutoToolTip = true;
			this.toolStripStatusLabelInformation.Image = global::Julian_and_his_dates.Properties.Resources.picInformation;
			this.toolStripStatusLabelInformation.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.toolStripStatusLabelInformation.Name = "toolStripStatusLabelInformation";
			this.toolStripStatusLabelInformation.Size = new System.Drawing.Size(86, 16);
			this.toolStripStatusLabelInformation.Text = "Information";
			// 
			// toolStripStatusLabelAlarm
			// 
			this.toolStripStatusLabelAlarm.AccessibleDescription = "Click to set alarm on/off";
			this.toolStripStatusLabelAlarm.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.toolStripStatusLabelAlarm.AutoToolTip = true;
			this.toolStripStatusLabelAlarm.Image = global::Julian_and_his_dates.Properties.Resources.picSound;
			this.toolStripStatusLabelAlarm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.toolStripStatusLabelAlarm.Name = "toolStripStatusLabelAlarm";
			this.toolStripStatusLabelAlarm.Size = new System.Drawing.Size(55, 16);
			this.toolStripStatusLabelAlarm.Text = "Alarm";
			this.toolStripStatusLabelAlarm.ToolTipText = "Click to set alarm on/off";
			this.toolStripStatusLabelAlarm.Click += new System.EventHandler(this.ToolStripStatusLabelAlarm_Click);
			// 
			// toolStripStatusLabelTakeScreenshot
			// 
			this.toolStripStatusLabelTakeScreenshot.AccessibleDescription = "Take a screenshot";
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
			// JulianandhisdatesForm
			// 
			this.AccessibleDescription = "Application";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(303, 360);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.labelRefreshRateText);
			this.Controls.Add(this.numericUpDownRefreshRate);
			this.Controls.Add(this.buttonOpenJulianDateConverter);
			this.Controls.Add(this.buttonOpenJulianDateCalculator);
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
			this.Controls.Add(this.checkBoxDarkLightMode);
			this.Controls.Add(this.checkBoxStayOnTop);
			this.Controls.Add(this.buttonMinimizeToTray);
			this.Controls.Add(this.buttonInfo);
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
			this.Controls.Add(this.checkBoxAutomaticRefresh);
			this.Controls.Add(this.buttonRefresh);
			this.Controls.Add(this.labelJulianDate);
			this.Controls.Add(this.labelJulianDateText);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "JulianandhisdatesForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Julian and his dates";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JulianandhisdatesForm_FormClosing);
			this.Load += new System.EventHandler(this.JulianandhisdatesForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRefreshRate)).EndInit();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolTip toolTip;
    private System.Windows.Forms.NotifyIcon notifyIcon;
    private System.Windows.Forms.Timer timer;
    private System.Windows.Forms.Label labelJulianDateText;
    private System.Windows.Forms.Label labelJulianDate;
    private System.Windows.Forms.Button buttonRefresh;
    private System.Windows.Forms.CheckBox checkBoxAutomaticRefresh;
    private System.Windows.Forms.Label labelModifiedJulianDateText;
    private System.Windows.Forms.Label labelModifiedJulianDate;
    private System.Windows.Forms.Label labelReducedJulianDate;
    private System.Windows.Forms.Label labelReducedJulianDateText;
    private System.Windows.Forms.Label labelTruncatedJulianDate;
    private System.Windows.Forms.Label labelTruncatedJulianDateText;
    private System.Windows.Forms.Label labelDublinJulianDate;
    private System.Windows.Forms.Label labelDublinJulianDateText;
    private System.Windows.Forms.Label labelCnesJulianDate;
    private System.Windows.Forms.Label labelCnesJulianDateText;
    private System.Windows.Forms.Label labelCcsdsJulianDate;
    private System.Windows.Forms.Label labelCcsdsJulianDateText;
    private System.Windows.Forms.Label labelLopJulianDate;
    private System.Windows.Forms.Label labelLopJulianDateText;
    private System.Windows.Forms.Label labelMillenniumJulianDate;
    private System.Windows.Forms.Label labelMillenniumJulianDateText;
    private System.Windows.Forms.Button buttonInfo;
    private System.Windows.Forms.Button buttonMinimizeToTray;
    private System.Windows.Forms.CheckBox checkBoxStayOnTop;
    private System.Windows.Forms.CheckBox checkBoxDarkLightMode;
    private System.Windows.Forms.Label labelLocalTimeText;
    private System.Windows.Forms.Label labelLocalTime;
    private System.Windows.Forms.Label labelUtcTime;
    private System.Windows.Forms.Label labelUtcTimeText;
    private System.Windows.Forms.Label labelChronologicalJulianDate;
    private System.Windows.Forms.Label labelChronologicalJulianDateText;
    private System.Windows.Forms.Label labelChronologicalModifiedJulianDate;
    private System.Windows.Forms.Label labelChronologicalModifiedJulianDateText;
    private System.Windows.Forms.Label labelLilianDate;
    private System.Windows.Forms.Label labelLilianDateText;
    private System.Windows.Forms.Label labelRataDie;
    private System.Windows.Forms.Label labelRataDieText;
    private System.Windows.Forms.Label labelMarsSolDate;
    private System.Windows.Forms.Label labelMarsSolDateText;
    private System.Windows.Forms.Label labelUnixtime;
    private System.Windows.Forms.Label labelUnixtimeText;
    private System.Windows.Forms.Button buttonOpenJulianDateCalculator;
    private System.Windows.Forms.Button buttonOpenJulianDateConverter;
    private System.Windows.Forms.NumericUpDown numericUpDownRefreshRate;
    private System.Windows.Forms.Label labelRefreshRateText;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInformation;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelAlarm;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTakeScreenshot;

  }
}

