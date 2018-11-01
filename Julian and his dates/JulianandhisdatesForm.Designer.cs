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
      this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
      this.timer = new System.Windows.Forms.Timer(this.components);
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
      this.labelMilleniumJulianDate = new System.Windows.Forms.Label();
      this.labelMilleniumJulianDateText = new System.Windows.Forms.Label();
      this.buttonInfo = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // notifyIcon
      // 
      this.notifyIcon.Text = "notifyIcon";
      this.notifyIcon.Visible = true;
      // 
      // timer
      // 
      this.timer.Enabled = true;
      this.timer.Interval = 1;
      this.timer.Tick += new System.EventHandler(this.timer_Tick);
      // 
      // labelJulianDateText
      // 
      this.labelJulianDateText.AutoSize = true;
      this.labelJulianDateText.Location = new System.Drawing.Point(12, 9);
      this.labelJulianDateText.Name = "labelJulianDateText";
      this.labelJulianDateText.Size = new System.Drawing.Size(61, 13);
      this.labelJulianDateText.TabIndex = 0;
      this.labelJulianDateText.Text = "Julian date:";
      // 
      // labelJulianDate
      // 
      this.labelJulianDate.AutoSize = true;
      this.labelJulianDate.Location = new System.Drawing.Point(129, 9);
      this.labelJulianDate.Name = "labelJulianDate";
      this.labelJulianDate.Size = new System.Drawing.Size(111, 13);
      this.labelJulianDate.TabIndex = 1;
      this.labelJulianDate.Text = "[your Julian date here]";
      // 
      // buttonRefresh
      // 
      this.buttonRefresh.Location = new System.Drawing.Point(132, 140);
      this.buttonRefresh.Name = "buttonRefresh";
      this.buttonRefresh.Size = new System.Drawing.Size(73, 23);
      this.buttonRefresh.TabIndex = 19;
      this.buttonRefresh.Text = "&Refresh";
      this.buttonRefresh.UseVisualStyleBackColor = true;
      this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
      // 
      // checkBoxAutomaticRefresh
      // 
      this.checkBoxAutomaticRefresh.Appearance = System.Windows.Forms.Appearance.Button;
      this.checkBoxAutomaticRefresh.AutoSize = true;
      this.checkBoxAutomaticRefresh.Location = new System.Drawing.Point(14, 140);
      this.checkBoxAutomaticRefresh.Name = "checkBoxAutomaticRefresh";
      this.checkBoxAutomaticRefresh.Size = new System.Drawing.Size(99, 23);
      this.checkBoxAutomaticRefresh.TabIndex = 18;
      this.checkBoxAutomaticRefresh.Text = "&Automatic refresh";
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
      // 
      // labelModifiedJulianDate
      // 
      this.labelModifiedJulianDate.AutoSize = true;
      this.labelModifiedJulianDate.Location = new System.Drawing.Point(129, 22);
      this.labelModifiedJulianDate.Name = "labelModifiedJulianDate";
      this.labelModifiedJulianDate.Size = new System.Drawing.Size(154, 13);
      this.labelModifiedJulianDate.TabIndex = 3;
      this.labelModifiedJulianDate.Text = "[your Modified Julian date here]";
      // 
      // labelReducedJulianDate
      // 
      this.labelReducedJulianDate.AutoSize = true;
      this.labelReducedJulianDate.Location = new System.Drawing.Point(129, 35);
      this.labelReducedJulianDate.Name = "labelReducedJulianDate";
      this.labelReducedJulianDate.Size = new System.Drawing.Size(158, 13);
      this.labelReducedJulianDate.TabIndex = 5;
      this.labelReducedJulianDate.Text = "[your Reduced Julian date here]";
      // 
      // labelReducedJulianDateText
      // 
      this.labelReducedJulianDateText.AutoSize = true;
      this.labelReducedJulianDateText.Location = new System.Drawing.Point(12, 35);
      this.labelReducedJulianDateText.Name = "labelReducedJulianDateText";
      this.labelReducedJulianDateText.Size = new System.Drawing.Size(108, 13);
      this.labelReducedJulianDateText.TabIndex = 4;
      this.labelReducedJulianDateText.Text = "Reduced Julian date:";
      // 
      // labelTruncatedJulianDate
      // 
      this.labelTruncatedJulianDate.AutoSize = true;
      this.labelTruncatedJulianDate.Location = new System.Drawing.Point(129, 48);
      this.labelTruncatedJulianDate.Name = "labelTruncatedJulianDate";
      this.labelTruncatedJulianDate.Size = new System.Drawing.Size(163, 13);
      this.labelTruncatedJulianDate.TabIndex = 7;
      this.labelTruncatedJulianDate.Text = "[your Truncated Julian date here]";
      // 
      // labelTruncatedJulianDateText
      // 
      this.labelTruncatedJulianDateText.AutoSize = true;
      this.labelTruncatedJulianDateText.Location = new System.Drawing.Point(12, 48);
      this.labelTruncatedJulianDateText.Name = "labelTruncatedJulianDateText";
      this.labelTruncatedJulianDateText.Size = new System.Drawing.Size(113, 13);
      this.labelTruncatedJulianDateText.TabIndex = 6;
      this.labelTruncatedJulianDateText.Text = "Truncated Julian date:";
      // 
      // labelDublinJulianDate
      // 
      this.labelDublinJulianDate.AutoSize = true;
      this.labelDublinJulianDate.Location = new System.Drawing.Point(129, 61);
      this.labelDublinJulianDate.Name = "labelDublinJulianDate";
      this.labelDublinJulianDate.Size = new System.Drawing.Size(144, 13);
      this.labelDublinJulianDate.TabIndex = 9;
      this.labelDublinJulianDate.Text = "[your Dublin Julian date here]";
      // 
      // labelDublinJulianDateText
      // 
      this.labelDublinJulianDateText.AutoSize = true;
      this.labelDublinJulianDateText.Location = new System.Drawing.Point(12, 61);
      this.labelDublinJulianDateText.Name = "labelDublinJulianDateText";
      this.labelDublinJulianDateText.Size = new System.Drawing.Size(94, 13);
      this.labelDublinJulianDateText.TabIndex = 8;
      this.labelDublinJulianDateText.Text = "Dublin Julian date:";
      // 
      // labelCnesJulianDate
      // 
      this.labelCnesJulianDate.AutoSize = true;
      this.labelCnesJulianDate.Location = new System.Drawing.Point(129, 74);
      this.labelCnesJulianDate.Name = "labelCnesJulianDate";
      this.labelCnesJulianDate.Size = new System.Drawing.Size(143, 13);
      this.labelCnesJulianDate.TabIndex = 11;
      this.labelCnesJulianDate.Text = "[your CNES Julian date here]";
      // 
      // labelCnesJulianDateText
      // 
      this.labelCnesJulianDateText.AutoSize = true;
      this.labelCnesJulianDateText.Location = new System.Drawing.Point(12, 74);
      this.labelCnesJulianDateText.Name = "labelCnesJulianDateText";
      this.labelCnesJulianDateText.Size = new System.Drawing.Size(93, 13);
      this.labelCnesJulianDateText.TabIndex = 10;
      this.labelCnesJulianDateText.Text = "CNES Julian date:";
      // 
      // labelCcsdsJulianDate
      // 
      this.labelCcsdsJulianDate.AutoSize = true;
      this.labelCcsdsJulianDate.Location = new System.Drawing.Point(129, 87);
      this.labelCcsdsJulianDate.Name = "labelCcsdsJulianDate";
      this.labelCcsdsJulianDate.Size = new System.Drawing.Size(150, 13);
      this.labelCcsdsJulianDate.TabIndex = 13;
      this.labelCcsdsJulianDate.Text = "[your CCSDS Julian date here]";
      // 
      // labelCcsdsJulianDateText
      // 
      this.labelCcsdsJulianDateText.AutoSize = true;
      this.labelCcsdsJulianDateText.Location = new System.Drawing.Point(12, 87);
      this.labelCcsdsJulianDateText.Name = "labelCcsdsJulianDateText";
      this.labelCcsdsJulianDateText.Size = new System.Drawing.Size(100, 13);
      this.labelCcsdsJulianDateText.TabIndex = 12;
      this.labelCcsdsJulianDateText.Text = "CCSDS Julian date:";
      // 
      // labelLopJulianDate
      // 
      this.labelLopJulianDate.AutoSize = true;
      this.labelLopJulianDate.Location = new System.Drawing.Point(129, 100);
      this.labelLopJulianDate.Name = "labelLopJulianDate";
      this.labelLopJulianDate.Size = new System.Drawing.Size(135, 13);
      this.labelLopJulianDate.TabIndex = 15;
      this.labelLopJulianDate.Text = "[your LOP Julian date here]";
      // 
      // labelLopJulianDateText
      // 
      this.labelLopJulianDateText.AutoSize = true;
      this.labelLopJulianDateText.Location = new System.Drawing.Point(12, 100);
      this.labelLopJulianDateText.Name = "labelLopJulianDateText";
      this.labelLopJulianDateText.Size = new System.Drawing.Size(85, 13);
      this.labelLopJulianDateText.TabIndex = 14;
      this.labelLopJulianDateText.Text = "LOP Julian date:";
      // 
      // labelMilleniumJulianDate
      // 
      this.labelMilleniumJulianDate.AutoSize = true;
      this.labelMilleniumJulianDate.Location = new System.Drawing.Point(129, 113);
      this.labelMilleniumJulianDate.Name = "labelMilleniumJulianDate";
      this.labelMilleniumJulianDate.Size = new System.Drawing.Size(157, 13);
      this.labelMilleniumJulianDate.TabIndex = 17;
      this.labelMilleniumJulianDate.Text = "[your Millenium Julian date here]";
      // 
      // labelMilleniumJulianDateText
      // 
      this.labelMilleniumJulianDateText.AutoSize = true;
      this.labelMilleniumJulianDateText.Location = new System.Drawing.Point(12, 113);
      this.labelMilleniumJulianDateText.Name = "labelMilleniumJulianDateText";
      this.labelMilleniumJulianDateText.Size = new System.Drawing.Size(107, 13);
      this.labelMilleniumJulianDateText.TabIndex = 16;
      this.labelMilleniumJulianDateText.Text = "Millenium Julian date:";
      // 
      // buttonInfo
      // 
      this.buttonInfo.Location = new System.Drawing.Point(222, 140);
      this.buttonInfo.Name = "buttonInfo";
      this.buttonInfo.Size = new System.Drawing.Size(65, 23);
      this.buttonInfo.TabIndex = 20;
      this.buttonInfo.Text = "&Info";
      this.buttonInfo.UseVisualStyleBackColor = true;
      this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
      // 
      // JulianandhisdatesForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(295, 175);
      this.Controls.Add(this.buttonInfo);
      this.Controls.Add(this.labelMilleniumJulianDate);
      this.Controls.Add(this.labelMilleniumJulianDateText);
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
    private System.Windows.Forms.Label labelMilleniumJulianDate;
    private System.Windows.Forms.Label labelMilleniumJulianDateText;
    private System.Windows.Forms.Button buttonInfo;

  }
}

