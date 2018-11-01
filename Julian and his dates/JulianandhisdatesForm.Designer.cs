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
      this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
      this.timer = new System.Windows.Forms.Timer(this.components);
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
      this.SuspendLayout();
      // 
      // labelJulianDateText
      // 
      this.labelJulianDateText.AutoSize = true;
      this.labelJulianDateText.Location = new System.Drawing.Point(12, 9);
      this.labelJulianDateText.Name = "labelJulianDateText";
      this.labelJulianDateText.Size = new System.Drawing.Size(61, 13);
      this.labelJulianDateText.TabIndex = 0;
      this.labelJulianDateText.Text = "Julian date:";
      this.toolTip.SetToolTip(this.labelJulianDateText, "Click to show more information");
      this.labelJulianDateText.Click += new System.EventHandler(this.labelJulianDateText_Click);
      // 
      // notifyIcon
      // 
      this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
      this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
      this.notifyIcon.Text = "notifyIcon";
      this.notifyIcon.Visible = true;
      this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
      // 
      // timer
      // 
      this.timer.Enabled = true;
      this.timer.Interval = 1;
      this.timer.Tick += new System.EventHandler(this.timer_Tick);
      // 
      // labelJulianDate
      // 
      this.labelJulianDate.AutoSize = true;
      this.labelJulianDate.Location = new System.Drawing.Point(129, 9);
      this.labelJulianDate.Name = "labelJulianDate";
      this.labelJulianDate.Size = new System.Drawing.Size(111, 13);
      this.labelJulianDate.TabIndex = 1;
      this.labelJulianDate.Text = "[your Julian date here]";
      this.toolTip.SetToolTip(this.labelJulianDate, "Double-click to copy into the clipboard");
      this.labelJulianDate.DoubleClick += new System.EventHandler(this.labelJulianDate_DoubleClick);
      // 
      // buttonRefresh
      // 
      this.buttonRefresh.Location = new System.Drawing.Point(15, 169);
      this.buttonRefresh.Name = "buttonRefresh";
      this.buttonRefresh.Size = new System.Drawing.Size(99, 23);
      this.buttonRefresh.TabIndex = 21;
      this.buttonRefresh.Text = "Manual &refresh";
      this.toolTip.SetToolTip(this.buttonRefresh, "If enabled, you can manually refresh the dates");
      this.buttonRefresh.UseVisualStyleBackColor = true;
      this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
      // 
      // checkBoxAutomaticRefresh
      // 
      this.checkBoxAutomaticRefresh.Appearance = System.Windows.Forms.Appearance.Button;
      this.checkBoxAutomaticRefresh.Location = new System.Drawing.Point(15, 140);
      this.checkBoxAutomaticRefresh.Name = "checkBoxAutomaticRefresh";
      this.checkBoxAutomaticRefresh.Size = new System.Drawing.Size(99, 23);
      this.checkBoxAutomaticRefresh.TabIndex = 18;
      this.checkBoxAutomaticRefresh.Text = "&Automatic refresh";
      this.checkBoxAutomaticRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.toolTip.SetToolTip(this.checkBoxAutomaticRefresh, "Enable/Disable to set the automatic refresh of the dates");
      this.checkBoxAutomaticRefresh.UseVisualStyleBackColor = true;
      this.checkBoxAutomaticRefresh.CheckedChanged += new System.EventHandler(this.checkBoxAutomaticRefresh_CheckedChanged);
      // 
      // labelModifiedJulianDateText
      // 
      this.labelModifiedJulianDateText.AutoSize = true;
      this.labelModifiedJulianDateText.Location = new System.Drawing.Point(12, 22);
      this.labelModifiedJulianDateText.Name = "labelModifiedJulianDateText";
      this.labelModifiedJulianDateText.Size = new System.Drawing.Size(104, 13);
      this.labelModifiedJulianDateText.TabIndex = 2;
      this.labelModifiedJulianDateText.Text = "Modified Julian date:";
      this.toolTip.SetToolTip(this.labelModifiedJulianDateText, "Click to show more information");
      this.labelModifiedJulianDateText.Click += new System.EventHandler(this.labelModifiedJulianDateText_Click);
      // 
      // labelModifiedJulianDate
      // 
      this.labelModifiedJulianDate.AutoSize = true;
      this.labelModifiedJulianDate.Location = new System.Drawing.Point(129, 22);
      this.labelModifiedJulianDate.Name = "labelModifiedJulianDate";
      this.labelModifiedJulianDate.Size = new System.Drawing.Size(154, 13);
      this.labelModifiedJulianDate.TabIndex = 3;
      this.labelModifiedJulianDate.Text = "[your Modified Julian date here]";
      this.toolTip.SetToolTip(this.labelModifiedJulianDate, "Double-click to copy into the clipboard");
      this.labelModifiedJulianDate.DoubleClick += new System.EventHandler(this.labelModifiedJulianDate_DoubleClick);
      // 
      // labelReducedJulianDate
      // 
      this.labelReducedJulianDate.AutoSize = true;
      this.labelReducedJulianDate.Location = new System.Drawing.Point(129, 35);
      this.labelReducedJulianDate.Name = "labelReducedJulianDate";
      this.labelReducedJulianDate.Size = new System.Drawing.Size(158, 13);
      this.labelReducedJulianDate.TabIndex = 5;
      this.labelReducedJulianDate.Text = "[your Reduced Julian date here]";
      this.toolTip.SetToolTip(this.labelReducedJulianDate, "Double-click to copy into the clipboard");
      this.labelReducedJulianDate.DoubleClick += new System.EventHandler(this.labelReducedJulianDate_DoubleClick);
      // 
      // labelReducedJulianDateText
      // 
      this.labelReducedJulianDateText.AutoSize = true;
      this.labelReducedJulianDateText.Location = new System.Drawing.Point(12, 35);
      this.labelReducedJulianDateText.Name = "labelReducedJulianDateText";
      this.labelReducedJulianDateText.Size = new System.Drawing.Size(108, 13);
      this.labelReducedJulianDateText.TabIndex = 4;
      this.labelReducedJulianDateText.Text = "Reduced Julian date:";
      this.toolTip.SetToolTip(this.labelReducedJulianDateText, "Click to show more information");
      this.labelReducedJulianDateText.Click += new System.EventHandler(this.labelReducedJulianDateText_Click);
      // 
      // labelTruncatedJulianDate
      // 
      this.labelTruncatedJulianDate.AutoSize = true;
      this.labelTruncatedJulianDate.Location = new System.Drawing.Point(129, 48);
      this.labelTruncatedJulianDate.Name = "labelTruncatedJulianDate";
      this.labelTruncatedJulianDate.Size = new System.Drawing.Size(163, 13);
      this.labelTruncatedJulianDate.TabIndex = 7;
      this.labelTruncatedJulianDate.Text = "[your Truncated Julian date here]";
      this.toolTip.SetToolTip(this.labelTruncatedJulianDate, "Double-click to copy into the clipboard");
      this.labelTruncatedJulianDate.DoubleClick += new System.EventHandler(this.labelTruncatedJulianDate_DoubleClick);
      // 
      // labelTruncatedJulianDateText
      // 
      this.labelTruncatedJulianDateText.AutoSize = true;
      this.labelTruncatedJulianDateText.Location = new System.Drawing.Point(12, 48);
      this.labelTruncatedJulianDateText.Name = "labelTruncatedJulianDateText";
      this.labelTruncatedJulianDateText.Size = new System.Drawing.Size(113, 13);
      this.labelTruncatedJulianDateText.TabIndex = 6;
      this.labelTruncatedJulianDateText.Text = "Truncated Julian date:";
      this.toolTip.SetToolTip(this.labelTruncatedJulianDateText, "Click to show more information");
      this.labelTruncatedJulianDateText.Click += new System.EventHandler(this.labelTruncatedJulianDateText_Click);
      // 
      // labelDublinJulianDate
      // 
      this.labelDublinJulianDate.AutoSize = true;
      this.labelDublinJulianDate.Location = new System.Drawing.Point(129, 61);
      this.labelDublinJulianDate.Name = "labelDublinJulianDate";
      this.labelDublinJulianDate.Size = new System.Drawing.Size(144, 13);
      this.labelDublinJulianDate.TabIndex = 9;
      this.labelDublinJulianDate.Text = "[your Dublin Julian date here]";
      this.toolTip.SetToolTip(this.labelDublinJulianDate, "Double-click to copy into the clipboard");
      this.labelDublinJulianDate.DoubleClick += new System.EventHandler(this.labelDublinJulianDate_DoubleClick);
      // 
      // labelDublinJulianDateText
      // 
      this.labelDublinJulianDateText.AutoSize = true;
      this.labelDublinJulianDateText.Location = new System.Drawing.Point(12, 61);
      this.labelDublinJulianDateText.Name = "labelDublinJulianDateText";
      this.labelDublinJulianDateText.Size = new System.Drawing.Size(94, 13);
      this.labelDublinJulianDateText.TabIndex = 8;
      this.labelDublinJulianDateText.Text = "Dublin Julian date:";
      this.toolTip.SetToolTip(this.labelDublinJulianDateText, "Click to show more information");
      this.labelDublinJulianDateText.Click += new System.EventHandler(this.labelDublinJulianDateText_Click);
      // 
      // labelCnesJulianDate
      // 
      this.labelCnesJulianDate.AutoSize = true;
      this.labelCnesJulianDate.Location = new System.Drawing.Point(129, 74);
      this.labelCnesJulianDate.Name = "labelCnesJulianDate";
      this.labelCnesJulianDate.Size = new System.Drawing.Size(143, 13);
      this.labelCnesJulianDate.TabIndex = 11;
      this.labelCnesJulianDate.Text = "[your CNES Julian date here]";
      this.toolTip.SetToolTip(this.labelCnesJulianDate, "Double-click to copy into the clipboard");
      this.labelCnesJulianDate.DoubleClick += new System.EventHandler(this.labelCnesJulianDate_DoubleClick);
      // 
      // labelCnesJulianDateText
      // 
      this.labelCnesJulianDateText.AutoSize = true;
      this.labelCnesJulianDateText.Location = new System.Drawing.Point(12, 74);
      this.labelCnesJulianDateText.Name = "labelCnesJulianDateText";
      this.labelCnesJulianDateText.Size = new System.Drawing.Size(93, 13);
      this.labelCnesJulianDateText.TabIndex = 10;
      this.labelCnesJulianDateText.Text = "CNES Julian date:";
      this.toolTip.SetToolTip(this.labelCnesJulianDateText, "Click to show more information");
      this.labelCnesJulianDateText.Click += new System.EventHandler(this.labelCnesJulianDateText_Click);
      // 
      // labelCcsdsJulianDate
      // 
      this.labelCcsdsJulianDate.AutoSize = true;
      this.labelCcsdsJulianDate.Location = new System.Drawing.Point(129, 87);
      this.labelCcsdsJulianDate.Name = "labelCcsdsJulianDate";
      this.labelCcsdsJulianDate.Size = new System.Drawing.Size(150, 13);
      this.labelCcsdsJulianDate.TabIndex = 13;
      this.labelCcsdsJulianDate.Text = "[your CCSDS Julian date here]";
      this.toolTip.SetToolTip(this.labelCcsdsJulianDate, "Double-click to copy into the clipboard");
      this.labelCcsdsJulianDate.DoubleClick += new System.EventHandler(this.labelCcsdsJulianDate_DoubleClick);
      // 
      // labelCcsdsJulianDateText
      // 
      this.labelCcsdsJulianDateText.AutoSize = true;
      this.labelCcsdsJulianDateText.Location = new System.Drawing.Point(12, 87);
      this.labelCcsdsJulianDateText.Name = "labelCcsdsJulianDateText";
      this.labelCcsdsJulianDateText.Size = new System.Drawing.Size(100, 13);
      this.labelCcsdsJulianDateText.TabIndex = 12;
      this.labelCcsdsJulianDateText.Text = "CCSDS Julian date:";
      this.toolTip.SetToolTip(this.labelCcsdsJulianDateText, "Click to show more information");
      this.labelCcsdsJulianDateText.Click += new System.EventHandler(this.labelCcsdsJulianDateText_Click);
      // 
      // labelLopJulianDate
      // 
      this.labelLopJulianDate.AutoSize = true;
      this.labelLopJulianDate.Location = new System.Drawing.Point(129, 100);
      this.labelLopJulianDate.Name = "labelLopJulianDate";
      this.labelLopJulianDate.Size = new System.Drawing.Size(135, 13);
      this.labelLopJulianDate.TabIndex = 15;
      this.labelLopJulianDate.Text = "[your LOP Julian date here]";
      this.toolTip.SetToolTip(this.labelLopJulianDate, "Double-click to copy into the clipboard");
      this.labelLopJulianDate.DoubleClick += new System.EventHandler(this.labelLopJulianDate_DoubleClick);
      // 
      // labelLopJulianDateText
      // 
      this.labelLopJulianDateText.AutoSize = true;
      this.labelLopJulianDateText.Location = new System.Drawing.Point(12, 100);
      this.labelLopJulianDateText.Name = "labelLopJulianDateText";
      this.labelLopJulianDateText.Size = new System.Drawing.Size(85, 13);
      this.labelLopJulianDateText.TabIndex = 14;
      this.labelLopJulianDateText.Text = "LOP Julian date:";
      this.toolTip.SetToolTip(this.labelLopJulianDateText, "Click to show more information");
      this.labelLopJulianDateText.Click += new System.EventHandler(this.labelLopJulianDateText_Click);
      // 
      // labelMillenniumJulianDate
      // 
      this.labelMillenniumJulianDate.AutoSize = true;
      this.labelMillenniumJulianDate.Location = new System.Drawing.Point(129, 113);
      this.labelMillenniumJulianDate.Name = "labelMillenniumJulianDate";
      this.labelMillenniumJulianDate.Size = new System.Drawing.Size(163, 13);
      this.labelMillenniumJulianDate.TabIndex = 17;
      this.labelMillenniumJulianDate.Text = "[your Millennium Julian date here]";
      this.toolTip.SetToolTip(this.labelMillenniumJulianDate, "Double-click to copy into the clipboard");
      this.labelMillenniumJulianDate.DoubleClick += new System.EventHandler(this.labelMillenniumJulianDate_DoubleClick);
      // 
      // labelMillenniumJulianDateText
      // 
      this.labelMillenniumJulianDateText.AutoSize = true;
      this.labelMillenniumJulianDateText.Location = new System.Drawing.Point(12, 113);
      this.labelMillenniumJulianDateText.Name = "labelMillenniumJulianDateText";
      this.labelMillenniumJulianDateText.Size = new System.Drawing.Size(113, 13);
      this.labelMillenniumJulianDateText.TabIndex = 16;
      this.labelMillenniumJulianDateText.Text = "Millennium Julian date:";
      this.toolTip.SetToolTip(this.labelMillenniumJulianDateText, "Click to show more information");
      this.labelMillenniumJulianDateText.Click += new System.EventHandler(this.labelMillenniumJulianDateText_Click);
      // 
      // buttonInfo
      // 
      this.buttonInfo.Location = new System.Drawing.Point(215, 169);
      this.buttonInfo.Name = "buttonInfo";
      this.buttonInfo.Size = new System.Drawing.Size(76, 23);
      this.buttonInfo.TabIndex = 23;
      this.buttonInfo.Text = "&Info";
      this.toolTip.SetToolTip(this.buttonInfo, "Show some information");
      this.buttonInfo.UseVisualStyleBackColor = true;
      this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
      // 
      // buttonMinimizeToTray
      // 
      this.buttonMinimizeToTray.Location = new System.Drawing.Point(120, 169);
      this.buttonMinimizeToTray.Name = "buttonMinimizeToTray";
      this.buttonMinimizeToTray.Size = new System.Drawing.Size(89, 23);
      this.buttonMinimizeToTray.TabIndex = 22;
      this.buttonMinimizeToTray.Text = "&Minimize to tray";
      this.toolTip.SetToolTip(this.buttonMinimizeToTray, "Minimize the application to the tray");
      this.buttonMinimizeToTray.UseVisualStyleBackColor = true;
      this.buttonMinimizeToTray.Click += new System.EventHandler(this.buttonMinimizeToTray_Click);
      // 
      // checkBoxStayOnTop
      // 
      this.checkBoxStayOnTop.Appearance = System.Windows.Forms.Appearance.Button;
      this.checkBoxStayOnTop.Location = new System.Drawing.Point(120, 140);
      this.checkBoxStayOnTop.Name = "checkBoxStayOnTop";
      this.checkBoxStayOnTop.Size = new System.Drawing.Size(89, 23);
      this.checkBoxStayOnTop.TabIndex = 19;
      this.checkBoxStayOnTop.Text = "Always on &top";
      this.checkBoxStayOnTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.toolTip.SetToolTip(this.checkBoxStayOnTop, "Enable/disable to set the application on top");
      this.checkBoxStayOnTop.UseVisualStyleBackColor = true;
      this.checkBoxStayOnTop.CheckedChanged += new System.EventHandler(this.checkBoxStayOnTop_CheckedChanged);
      // 
      // checkBoxDarkLightMode
      // 
      this.checkBoxDarkLightMode.Appearance = System.Windows.Forms.Appearance.Button;
      this.checkBoxDarkLightMode.Location = new System.Drawing.Point(215, 140);
      this.checkBoxDarkLightMode.Name = "checkBoxDarkLightMode";
      this.checkBoxDarkLightMode.Size = new System.Drawing.Size(76, 23);
      this.checkBoxDarkLightMode.TabIndex = 20;
      this.checkBoxDarkLightMode.Text = "&Dark mode";
      this.checkBoxDarkLightMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.toolTip.SetToolTip(this.checkBoxDarkLightMode, "Enable/Disable the dark mode");
      this.checkBoxDarkLightMode.UseVisualStyleBackColor = true;
      this.checkBoxDarkLightMode.CheckedChanged += new System.EventHandler(this.checkBoxDarkLightMode_CheckedChanged);
      // 
      // JulianandhisdatesForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(303, 206);
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
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "JulianandhisdatesForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Julian and his dates";
      this.Load += new System.EventHandler(this.JulianandhisdatesForm_Load);
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

  }
}

