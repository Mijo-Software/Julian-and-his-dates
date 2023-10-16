namespace JulianAndHisDates
{
	partial class JulianDateConverterForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JulianDateConverterForm));
			labelUnixtimeText = new Label();
			labelMarsSolDateText = new Label();
			labelRataDieText = new Label();
			labelLilianDateText = new Label();
			labelChronologicalModifiedJulianDateText = new Label();
			labelChronologicalJulianDateText = new Label();
			labelUtcTime = new Label();
			labelUtcTimeText = new Label();
			labelLocalTime = new Label();
			labelLocalTimeText = new Label();
			labelMillenniumJulianDateText = new Label();
			labelLopJulianDateText = new Label();
			labelCcsdsJulianDateText = new Label();
			labelCnesJulianDateText = new Label();
			labelDublinJulianDateText = new Label();
			labelTruncatedJulianDateText = new Label();
			labelReducedJulianDateText = new Label();
			labelModifiedJulianDateText = new Label();
			labelJulianDateText = new Label();
			toolTip = new ToolTip(components);
			textboxJulianDate = new TextBox();
			textboxModifiedJulianDate = new TextBox();
			textboxReducedJulianDate = new TextBox();
			textboxTruncatedJulianDate = new TextBox();
			textboxDublinJulianDate = new TextBox();
			textboxCnesJulianDate = new TextBox();
			textboxCcsdsJulianDate = new TextBox();
			textboxMarsSolDate = new TextBox();
			textboxRataDie = new TextBox();
			textboxLilianDate = new TextBox();
			textboxChronologicalModifiedJulianDate = new TextBox();
			textboxChronologicalJulianDate = new TextBox();
			textboxMillenniumJulianDate = new TextBox();
			textboxLopJulianDate = new TextBox();
			textboxUnixtime = new TextBox();
			statusStrip = new StatusStrip();
			toolStripStatusLabelInformation = new ToolStripStatusLabel();
			toolStripStatusLabelTakeScreenshot = new ToolStripStatusLabel();
			statusStrip.SuspendLayout();
			SuspendLayout();
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
			labelUnixtimeText.Click += LabelUnixtimeText_Click;
			labelUnixtimeText.Enter += LabelUnixtimeText_Enter;
			labelUnixtimeText.Leave += LabelUnixtimeText_Leave;
			labelUnixtimeText.MouseEnter += LabelUnixtimeText_MouseEnter;
			labelUnixtimeText.MouseLeave += LabelUnixtimeText_MouseLeave;
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
			labelMarsSolDateText.Click += LabelMarsSolDateText_Click;
			labelMarsSolDateText.Enter += LabelMarsSolDateText_Enter;
			labelMarsSolDateText.Leave += LabelMarsSolDateText_Leave;
			labelMarsSolDateText.MouseEnter += LabelMarsSolDateText_MouseEnter;
			labelMarsSolDateText.MouseLeave += LabelMarsSolDateText_MouseLeave;
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
			labelRataDieText.Click += LabelRataDieText_Click;
			labelRataDieText.Enter += LabelRataDieText_Enter;
			labelRataDieText.Leave += LabelRataDieText_Leave;
			labelRataDieText.MouseEnter += LabelRataDieText_MouseEnter;
			labelRataDieText.MouseLeave += LabelRataDieText_MouseLeave;
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
			labelLilianDateText.Click += LabelLilianDateText_Click;
			labelLilianDateText.Enter += LabelLilianDateText_Enter;
			labelLilianDateText.Leave += LabelLilianDateText_Leave;
			labelLilianDateText.MouseEnter += LabelLilianDateText_MouseEnter;
			labelLilianDateText.MouseLeave += LabelLilianDateText_MouseLeave;
			// 
			// labelChronologicalModifiedJulianDateText
			// 
			labelChronologicalModifiedJulianDateText.AccessibleDescription = "Description of the Chronological Modified Julian Date";
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
			labelChronologicalModifiedJulianDateText.Click += LabelChronologicalModifiedJulianDateText_Click;
			labelChronologicalModifiedJulianDateText.Enter += LabelChronologicalModifiedJulianDateText_Enter;
			labelChronologicalModifiedJulianDateText.Leave += LabelChronologicalModifiedJulianDateText_Leave;
			labelChronologicalModifiedJulianDateText.MouseEnter += LabelChronologicalModifiedJulianDateText_MouseEnter;
			labelChronologicalModifiedJulianDateText.MouseLeave += LabelChronologicalModifiedJulianDateText_MouseLeave;
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
			labelChronologicalJulianDateText.Click += LabelChronologicalJulianDateText_Click;
			labelChronologicalJulianDateText.Enter += LabelChronologicalJulianDateText_Enter;
			labelChronologicalJulianDateText.Leave += LabelChronologicalJulianDateText_Leave;
			labelChronologicalJulianDateText.MouseEnter += LabelChronologicalJulianDateText_MouseEnter;
			labelChronologicalJulianDateText.MouseLeave += LabelChronologicalJulianDateText_MouseLeave;
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
			labelUtcTimeText.Location = new Point(14, 10);
			labelUtcTimeText.Margin = new Padding(4, 0, 4, 0);
			labelUtcTimeText.Name = "labelUtcTimeText";
			labelUtcTimeText.Size = new Size(58, 15);
			labelUtcTimeText.TabIndex = 0;
			labelUtcTimeText.Text = "UTC time:";
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
			labelLocalTime.Location = new Point(210, 25);
			labelLocalTime.Margin = new Padding(4, 0, 4, 0);
			labelLocalTime.Name = "labelLocalTime";
			labelLocalTime.Size = new Size(120, 15);
			labelLocalTime.TabIndex = 3;
			labelLocalTime.Text = "[your local time here]";
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
			labelLocalTimeText.Location = new Point(14, 25);
			labelLocalTimeText.Margin = new Padding(4, 0, 4, 0);
			labelLocalTimeText.Name = "labelLocalTimeText";
			labelLocalTimeText.Size = new Size(65, 15);
			labelLocalTimeText.TabIndex = 2;
			labelLocalTimeText.Text = "Local time:";
			labelLocalTimeText.Click += LabelLocalTimeText_Click;
			labelLocalTimeText.Enter += LabelLocalTimeText_Enter;
			labelLocalTimeText.Leave += LabelLocalTimeText_Leave;
			labelLocalTimeText.MouseEnter += LabelLocalTimeText_MouseEnter;
			labelLocalTimeText.MouseLeave += LabelLocalTimeText_MouseLeave;
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
			labelMillenniumJulianDateText.Click += LabelMillenniumJulianDateText_Click;
			labelMillenniumJulianDateText.Enter += LabelMillenniumJulianDateText_Enter;
			labelMillenniumJulianDateText.Leave += LabelMillenniumJulianDateText_Leave;
			labelMillenniumJulianDateText.MouseEnter += LabelMillenniumJulianDateText_MouseEnter;
			labelMillenniumJulianDateText.MouseLeave += LabelMillenniumJulianDateText_MouseLeave;
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
			labelLopJulianDateText.Click += LabelLopJulianDateText_Click;
			labelLopJulianDateText.Enter += LabelLopJulianDateText_Enter;
			labelLopJulianDateText.Leave += LabelLopJulianDateText_Leave;
			labelLopJulianDateText.MouseEnter += LabelLopJulianDateText_MouseEnter;
			labelLopJulianDateText.MouseLeave += LabelLopJulianDateText_MouseLeave;
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
			labelCcsdsJulianDateText.Click += LabelCcsdsJulianDateText_Click;
			labelCcsdsJulianDateText.Enter += LabelCcsdsJulianDateText_Enter;
			labelCcsdsJulianDateText.Leave += LabelCcsdsJulianDateText_Leave;
			labelCcsdsJulianDateText.MouseEnter += LabelCcsdsJulianDateText_MouseEnter;
			labelCcsdsJulianDateText.MouseLeave += LabelCcsdsJulianDateText_MouseLeave;
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
			labelCnesJulianDateText.Click += LabelCnesJulianDateText_Click;
			labelCnesJulianDateText.Enter += LabelCnesJulianDateText_Enter;
			labelCnesJulianDateText.Leave += LabelCnesJulianDateText_Leave;
			labelCnesJulianDateText.MouseEnter += LabelCnesJulianDateText_MouseEnter;
			labelCnesJulianDateText.MouseLeave += LabelCnesJulianDateText_MouseLeave;
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
			labelDublinJulianDateText.Click += LabelDublinJulianDateText_Click;
			labelDublinJulianDateText.Enter += LabelDublinJulianDateText_Enter;
			labelDublinJulianDateText.Leave += LabelDublinJulianDateText_Leave;
			labelDublinJulianDateText.MouseEnter += LabelDublinJulianDateText_MouseEnter;
			labelDublinJulianDateText.MouseLeave += LabelDublinJulianDateText_MouseLeave;
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
			labelTruncatedJulianDateText.Click += LabelTruncatedJulianDateText_Click;
			labelTruncatedJulianDateText.Enter += LabelTruncatedJulianDateText_Enter;
			labelTruncatedJulianDateText.Leave += LabelTruncatedJulianDateText_Leave;
			labelTruncatedJulianDateText.MouseEnter += LabelTruncatedJulianDateText_MouseEnter;
			labelTruncatedJulianDateText.MouseLeave += LabelTruncatedJulianDateText_MouseLeave;
			// 
			// labelReducedJulianDateText
			// 
			labelReducedJulianDateText.AccessibleDescription = "Description of the Reduced Julian Date";
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
			labelReducedJulianDateText.Click += LabelReducedJulianDateText_Click;
			labelReducedJulianDateText.Enter += LabelReducedJulianDateText_Enter;
			labelReducedJulianDateText.Leave += LabelReducedJulianDateText_Leave;
			labelReducedJulianDateText.MouseEnter += LabelReducedJulianDateText_MouseEnter;
			labelReducedJulianDateText.MouseLeave += LabelReducedJulianDateText_MouseLeave;
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
			labelModifiedJulianDateText.Click += LabelModifiedJulianDateText_Click;
			labelModifiedJulianDateText.Enter += LabelModifiedJulianDateText_Enter;
			labelModifiedJulianDateText.Leave += LabelModifiedJulianDateText_Leave;
			labelModifiedJulianDateText.MouseEnter += LabelModifiedJulianDateText_MouseEnter;
			labelModifiedJulianDateText.MouseLeave += LabelModifiedJulianDateText_MouseLeave;
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
			labelJulianDateText.Click += LabelJulianDateText_Click;
			labelJulianDateText.Enter += LabelJulianDateText_Enter;
			labelJulianDateText.Leave += LabelJulianDateText_Leave;
			labelJulianDateText.MouseEnter += LabelJulianDateText_MouseEnter;
			labelJulianDateText.MouseLeave += LabelJulianDateText_MouseLeave;
			// 
			// textboxJulianDate
			// 
			textboxJulianDate.AccessibleDescription = "Value of the Julian Date";
			textboxJulianDate.AccessibleName = "Julian Date Value";
			textboxJulianDate.AccessibleRole = AccessibleRole.Text;
			textboxJulianDate.BorderStyle = BorderStyle.None;
			textboxJulianDate.Location = new Point(214, 40);
			textboxJulianDate.Margin = new Padding(4, 3, 4, 3);
			textboxJulianDate.Name = "textboxJulianDate";
			textboxJulianDate.Size = new Size(118, 16);
			textboxJulianDate.TabIndex = 5;
			textboxJulianDate.Text = "[your Julian date here]";
			textboxJulianDate.TextChanged += TextboxJulianDate_TextChanged;
			textboxJulianDate.Enter += TextboxJulianDate_Enter;
			textboxJulianDate.KeyPress += TextboxJulianDate_KeyPress;
			textboxJulianDate.Leave += TextboxJulianDate_Leave;
			textboxJulianDate.MouseEnter += TextboxJulianDate_MouseEnter;
			textboxJulianDate.MouseLeave += TextboxJulianDate_MouseLeave;
			// 
			// textboxModifiedJulianDate
			// 
			textboxModifiedJulianDate.AccessibleDescription = "Value of the Modified Julian Date";
			textboxModifiedJulianDate.AccessibleName = "Modified Julian Date Value";
			textboxModifiedJulianDate.AccessibleRole = AccessibleRole.Text;
			textboxModifiedJulianDate.BorderStyle = BorderStyle.None;
			textboxModifiedJulianDate.Location = new Point(214, 55);
			textboxModifiedJulianDate.Margin = new Padding(4, 3, 4, 3);
			textboxModifiedJulianDate.Name = "textboxModifiedJulianDate";
			textboxModifiedJulianDate.Size = new Size(118, 16);
			textboxModifiedJulianDate.TabIndex = 7;
			textboxModifiedJulianDate.Text = "[your Julian date here]";
			textboxModifiedJulianDate.TextChanged += TextboxModifiedJulianDate_TextChanged;
			textboxModifiedJulianDate.Enter += TextboxModifiedJulianDate_Enter;
			textboxModifiedJulianDate.KeyPress += TextboxModifiedJulianDate_KeyPress;
			textboxModifiedJulianDate.Leave += TextboxModifiedJulianDate_Leave;
			textboxModifiedJulianDate.MouseEnter += TextboxModifiedJulianDate_MouseEnter;
			textboxModifiedJulianDate.MouseLeave += TextboxModifiedJulianDate_MouseLeave;
			// 
			// textboxReducedJulianDate
			// 
			textboxReducedJulianDate.AccessibleDescription = "Value of the Reduced Julian Date";
			textboxReducedJulianDate.AccessibleName = "Reduced Julian Date Value";
			textboxReducedJulianDate.AccessibleRole = AccessibleRole.Text;
			textboxReducedJulianDate.BorderStyle = BorderStyle.None;
			textboxReducedJulianDate.Location = new Point(214, 70);
			textboxReducedJulianDate.Margin = new Padding(4, 3, 4, 3);
			textboxReducedJulianDate.Name = "textboxReducedJulianDate";
			textboxReducedJulianDate.Size = new Size(118, 16);
			textboxReducedJulianDate.TabIndex = 9;
			textboxReducedJulianDate.Text = "[your Julian date here]";
			textboxReducedJulianDate.TextChanged += TextboxReducedJulianDate_TextChanged;
			textboxReducedJulianDate.Enter += TextboxReducedJulianDate_Enter;
			textboxReducedJulianDate.KeyPress += TextboxReducedJulianDate_KeyPress;
			textboxReducedJulianDate.Leave += TextboxReducedJulianDate_Leave;
			textboxReducedJulianDate.MouseEnter += TextboxReducedJulianDate_MouseEnter;
			textboxReducedJulianDate.MouseLeave += TextboxReducedJulianDate_MouseLeave;
			// 
			// textboxTruncatedJulianDate
			// 
			textboxTruncatedJulianDate.AccessibleDescription = "Value of the Truncated Julian Date";
			textboxTruncatedJulianDate.AccessibleName = "Truncated Julian Date Value";
			textboxTruncatedJulianDate.AccessibleRole = AccessibleRole.Text;
			textboxTruncatedJulianDate.BorderStyle = BorderStyle.None;
			textboxTruncatedJulianDate.Location = new Point(214, 85);
			textboxTruncatedJulianDate.Margin = new Padding(4, 3, 4, 3);
			textboxTruncatedJulianDate.Name = "textboxTruncatedJulianDate";
			textboxTruncatedJulianDate.Size = new Size(118, 16);
			textboxTruncatedJulianDate.TabIndex = 11;
			textboxTruncatedJulianDate.Text = "[your Julian date here]";
			textboxTruncatedJulianDate.TextChanged += TextboxTruncatedJulianDate_TextChanged;
			textboxTruncatedJulianDate.Enter += TextboxTruncatedJulianDate_Enter;
			textboxTruncatedJulianDate.KeyPress += TextboxTruncatedJulianDate_KeyPress;
			textboxTruncatedJulianDate.Leave += TextboxTruncatedJulianDate_Leave;
			textboxTruncatedJulianDate.MouseEnter += TextboxTruncatedJulianDate_MouseEnter;
			textboxTruncatedJulianDate.MouseLeave += TextboxTruncatedJulianDate_MouseLeave;
			// 
			// textboxDublinJulianDate
			// 
			textboxDublinJulianDate.AccessibleDescription = "Value of the Dublin Julian Date";
			textboxDublinJulianDate.AccessibleName = "Dublin Julian Date Value";
			textboxDublinJulianDate.AccessibleRole = AccessibleRole.Text;
			textboxDublinJulianDate.BorderStyle = BorderStyle.None;
			textboxDublinJulianDate.Location = new Point(214, 100);
			textboxDublinJulianDate.Margin = new Padding(4, 3, 4, 3);
			textboxDublinJulianDate.Name = "textboxDublinJulianDate";
			textboxDublinJulianDate.Size = new Size(118, 16);
			textboxDublinJulianDate.TabIndex = 13;
			textboxDublinJulianDate.Text = "[your Julian date here]";
			textboxDublinJulianDate.TextChanged += TextboxDublinJulianDate_TextChanged;
			textboxDublinJulianDate.Enter += TextboxDublinJulianDate_Enter;
			textboxDublinJulianDate.KeyPress += TextboxDublinJulianDate_KeyPress;
			textboxDublinJulianDate.Leave += TextboxDublinJulianDate_Leave;
			textboxDublinJulianDate.MouseEnter += TextboxDublinJulianDate_MouseEnter;
			textboxDublinJulianDate.MouseLeave += TextboxDublinJulianDate_MouseLeave;
			// 
			// textboxCnesJulianDate
			// 
			textboxCnesJulianDate.AccessibleDescription = "Value of the CNES Julian Date";
			textboxCnesJulianDate.AccessibleName = "CNES Julian Date Value";
			textboxCnesJulianDate.AccessibleRole = AccessibleRole.Text;
			textboxCnesJulianDate.BorderStyle = BorderStyle.None;
			textboxCnesJulianDate.Location = new Point(214, 115);
			textboxCnesJulianDate.Margin = new Padding(4, 3, 4, 3);
			textboxCnesJulianDate.Name = "textboxCnesJulianDate";
			textboxCnesJulianDate.Size = new Size(118, 16);
			textboxCnesJulianDate.TabIndex = 15;
			textboxCnesJulianDate.Text = "[your Julian date here]";
			textboxCnesJulianDate.TextChanged += TextboxCnesJulianDate_TextChanged;
			textboxCnesJulianDate.Enter += TextboxCnesJulianDate_Enter;
			textboxCnesJulianDate.KeyPress += TextboxCnesJulianDate_KeyPress;
			textboxCnesJulianDate.Leave += TextboxCnesJulianDate_Leave;
			textboxCnesJulianDate.MouseEnter += TextboxCnesJulianDate_MouseEnter;
			textboxCnesJulianDate.MouseLeave += TextboxCnesJulianDate_MouseLeave;
			// 
			// textboxCcsdsJulianDate
			// 
			textboxCcsdsJulianDate.AccessibleDescription = "Value of the CCSDS Julian Date";
			textboxCcsdsJulianDate.AccessibleName = "CCSDS Julian Date Value";
			textboxCcsdsJulianDate.AccessibleRole = AccessibleRole.Text;
			textboxCcsdsJulianDate.BorderStyle = BorderStyle.None;
			textboxCcsdsJulianDate.Location = new Point(214, 130);
			textboxCcsdsJulianDate.Margin = new Padding(4, 3, 4, 3);
			textboxCcsdsJulianDate.Name = "textboxCcsdsJulianDate";
			textboxCcsdsJulianDate.Size = new Size(118, 16);
			textboxCcsdsJulianDate.TabIndex = 17;
			textboxCcsdsJulianDate.Text = "[your Julian date here]";
			textboxCcsdsJulianDate.TextChanged += TextboxCcsdsJulianDate_TextChanged;
			textboxCcsdsJulianDate.Enter += TextboxCcsdsJulianDate_Enter;
			textboxCcsdsJulianDate.KeyPress += TextboxCcsdsJulianDate_KeyPress;
			textboxCcsdsJulianDate.Leave += TextboxCcsdsJulianDate_Leave;
			textboxCcsdsJulianDate.MouseEnter += TextboxCcsdsJulianDate_MouseEnter;
			textboxCcsdsJulianDate.MouseLeave += TextboxCcsdsJulianDate_MouseLeave;
			// 
			// textboxMarsSolDate
			// 
			textboxMarsSolDate.AccessibleDescription = "Value of the Mars Sol Date";
			textboxMarsSolDate.AccessibleName = "Mars Sol Date Value";
			textboxMarsSolDate.AccessibleRole = AccessibleRole.Text;
			textboxMarsSolDate.BorderStyle = BorderStyle.None;
			textboxMarsSolDate.Location = new Point(214, 235);
			textboxMarsSolDate.Margin = new Padding(4, 3, 4, 3);
			textboxMarsSolDate.Name = "textboxMarsSolDate";
			textboxMarsSolDate.Size = new Size(118, 16);
			textboxMarsSolDate.TabIndex = 31;
			textboxMarsSolDate.Text = "[your Julian date here]";
			textboxMarsSolDate.TextChanged += TextboxMarsSolDate_TextChanged;
			textboxMarsSolDate.Enter += TextboxMarsSolDate_Enter;
			textboxMarsSolDate.KeyPress += TextboxMarsSolDate_KeyPress;
			textboxMarsSolDate.Leave += TextboxMarsSolDate_Leave;
			textboxMarsSolDate.MouseEnter += TextboxMarsSolDate_MouseEnter;
			textboxMarsSolDate.MouseLeave += TextboxMarsSolDate_MouseLeave;
			// 
			// textboxRataDie
			// 
			textboxRataDie.AccessibleDescription = "Value of the Rata Die";
			textboxRataDie.AccessibleName = "Rata Die Value";
			textboxRataDie.AccessibleRole = AccessibleRole.Text;
			textboxRataDie.BorderStyle = BorderStyle.None;
			textboxRataDie.Location = new Point(214, 220);
			textboxRataDie.Margin = new Padding(4, 3, 4, 3);
			textboxRataDie.Name = "textboxRataDie";
			textboxRataDie.Size = new Size(118, 16);
			textboxRataDie.TabIndex = 29;
			textboxRataDie.Text = "[your Julian date here]";
			textboxRataDie.TextChanged += TextboxRataDie_TextChanged;
			textboxRataDie.Enter += TextboxRataDie_Enter;
			textboxRataDie.KeyPress += TextboxRataDie_KeyPress;
			textboxRataDie.Leave += TextboxRataDie_Leave;
			textboxRataDie.MouseEnter += TextboxRataDie_MouseEnter;
			textboxRataDie.MouseLeave += TextboxRataDie_MouseLeave;
			// 
			// textboxLilianDate
			// 
			textboxLilianDate.AccessibleDescription = "Value of the Lilian Date";
			textboxLilianDate.AccessibleName = "Lilian Date Value";
			textboxLilianDate.AccessibleRole = AccessibleRole.Text;
			textboxLilianDate.BorderStyle = BorderStyle.None;
			textboxLilianDate.Location = new Point(214, 205);
			textboxLilianDate.Margin = new Padding(4, 3, 4, 3);
			textboxLilianDate.Name = "textboxLilianDate";
			textboxLilianDate.Size = new Size(118, 16);
			textboxLilianDate.TabIndex = 27;
			textboxLilianDate.Text = "[your Julian date here]";
			textboxLilianDate.TextChanged += TextboxLilianDate_TextChanged;
			textboxLilianDate.Enter += TextboxLilianDate_Enter;
			textboxLilianDate.KeyPress += TextboxLilianDate_KeyPress;
			textboxLilianDate.Leave += TextboxLilianDate_Leave;
			textboxLilianDate.MouseEnter += TextboxLilianDate_MouseEnter;
			textboxLilianDate.MouseLeave += TextboxLilianDate_MouseLeave;
			// 
			// textboxChronologicalModifiedJulianDate
			// 
			textboxChronologicalModifiedJulianDate.AccessibleDescription = "Value of the Chronological Modified Julian Date";
			textboxChronologicalModifiedJulianDate.AccessibleName = "Chronological Modified Julian Date Value";
			textboxChronologicalModifiedJulianDate.AccessibleRole = AccessibleRole.Text;
			textboxChronologicalModifiedJulianDate.BorderStyle = BorderStyle.None;
			textboxChronologicalModifiedJulianDate.Location = new Point(214, 190);
			textboxChronologicalModifiedJulianDate.Margin = new Padding(4, 3, 4, 3);
			textboxChronologicalModifiedJulianDate.Name = "textboxChronologicalModifiedJulianDate";
			textboxChronologicalModifiedJulianDate.Size = new Size(118, 16);
			textboxChronologicalModifiedJulianDate.TabIndex = 25;
			textboxChronologicalModifiedJulianDate.Text = "[your Julian date here]";
			textboxChronologicalModifiedJulianDate.TextChanged += TextboxChronologicalModifiedJulianDate_TextChanged;
			textboxChronologicalModifiedJulianDate.Enter += TextboxChronologicalModifiedJulianDate_Enter;
			textboxChronologicalModifiedJulianDate.KeyPress += TextboxChronologicalModifiedJulianDate_KeyPress;
			textboxChronologicalModifiedJulianDate.Leave += TextboxChronologicalModifiedJulianDate_Leave;
			textboxChronologicalModifiedJulianDate.MouseEnter += TextboxChronologicalModifiedJulianDate_MouseEnter;
			textboxChronologicalModifiedJulianDate.MouseLeave += TextboxChronologicalModifiedJulianDate_MouseLeave;
			// 
			// textboxChronologicalJulianDate
			// 
			textboxChronologicalJulianDate.AccessibleDescription = "Value of the Chronological Julian Date";
			textboxChronologicalJulianDate.AccessibleName = "Chronological Julian Date Value";
			textboxChronologicalJulianDate.AccessibleRole = AccessibleRole.Text;
			textboxChronologicalJulianDate.BorderStyle = BorderStyle.None;
			textboxChronologicalJulianDate.Location = new Point(214, 175);
			textboxChronologicalJulianDate.Margin = new Padding(4, 3, 4, 3);
			textboxChronologicalJulianDate.Name = "textboxChronologicalJulianDate";
			textboxChronologicalJulianDate.Size = new Size(118, 16);
			textboxChronologicalJulianDate.TabIndex = 23;
			textboxChronologicalJulianDate.Text = "[your Julian date here]";
			textboxChronologicalJulianDate.TextChanged += TextboxChronologicalJulianDate_TextChanged;
			textboxChronologicalJulianDate.Enter += TextboxChronologicalJulianDate_Enter;
			textboxChronologicalJulianDate.KeyPress += TextboxChronologicalJulianDate_KeyPress;
			textboxChronologicalJulianDate.Leave += TextboxChronologicalJulianDate_Leave;
			textboxChronologicalJulianDate.MouseEnter += TextboxChronologicalJulianDate_MouseEnter;
			textboxChronologicalJulianDate.MouseLeave += TextboxChronologicalJulianDate_MouseLeave;
			// 
			// textboxMillenniumJulianDate
			// 
			textboxMillenniumJulianDate.AccessibleDescription = "Value of the Millenium Julian Date";
			textboxMillenniumJulianDate.AccessibleName = "Millennium Julian Date Value";
			textboxMillenniumJulianDate.AccessibleRole = AccessibleRole.Text;
			textboxMillenniumJulianDate.BorderStyle = BorderStyle.None;
			textboxMillenniumJulianDate.Location = new Point(214, 160);
			textboxMillenniumJulianDate.Margin = new Padding(4, 3, 4, 3);
			textboxMillenniumJulianDate.Name = "textboxMillenniumJulianDate";
			textboxMillenniumJulianDate.Size = new Size(118, 16);
			textboxMillenniumJulianDate.TabIndex = 21;
			textboxMillenniumJulianDate.Text = "[your Julian date here]";
			textboxMillenniumJulianDate.TextChanged += TextboxMillenniumJulianDate_TextChanged;
			textboxMillenniumJulianDate.Enter += TextboxMillenniumJulianDate_Enter;
			textboxMillenniumJulianDate.KeyPress += TextboxMillenniumJulianDate_KeyPress;
			textboxMillenniumJulianDate.Leave += TextboxMillenniumJulianDate_Leave;
			textboxMillenniumJulianDate.MouseEnter += TextboxMillenniumJulianDate_MouseEnter;
			textboxMillenniumJulianDate.MouseLeave += TextboxMillenniumJulianDate_MouseLeave;
			// 
			// textboxLopJulianDate
			// 
			textboxLopJulianDate.AccessibleDescription = "Value of the LOP Julian Date";
			textboxLopJulianDate.AccessibleName = "LOP Julian Date Value";
			textboxLopJulianDate.AccessibleRole = AccessibleRole.Text;
			textboxLopJulianDate.BorderStyle = BorderStyle.None;
			textboxLopJulianDate.Location = new Point(214, 145);
			textboxLopJulianDate.Margin = new Padding(4, 3, 4, 3);
			textboxLopJulianDate.Name = "textboxLopJulianDate";
			textboxLopJulianDate.Size = new Size(118, 16);
			textboxLopJulianDate.TabIndex = 19;
			textboxLopJulianDate.Text = "[your Julian date here]";
			textboxLopJulianDate.TextChanged += TextboxLopJulianDate_TextChanged;
			textboxLopJulianDate.Enter += TextboxLopJulianDate_Enter;
			textboxLopJulianDate.KeyPress += TextboxLopJulianDate_KeyPress;
			textboxLopJulianDate.Leave += TextboxLopJulianDate_Leave;
			textboxLopJulianDate.MouseEnter += TextboxLopJulianDate_MouseEnter;
			textboxLopJulianDate.MouseLeave += TextboxLopJulianDate_MouseLeave;
			// 
			// textboxUnixtime
			// 
			textboxUnixtime.AccessibleDescription = "Value of the Unix Time";
			textboxUnixtime.AccessibleName = "Unix Time Value";
			textboxUnixtime.AccessibleRole = AccessibleRole.Text;
			textboxUnixtime.BorderStyle = BorderStyle.None;
			textboxUnixtime.Location = new Point(214, 250);
			textboxUnixtime.Margin = new Padding(4, 3, 4, 3);
			textboxUnixtime.Name = "textboxUnixtime";
			textboxUnixtime.Size = new Size(118, 16);
			textboxUnixtime.TabIndex = 33;
			textboxUnixtime.Text = "[your Julian date here]";
			textboxUnixtime.TextChanged += TextboxUnixtime_TextChanged;
			textboxUnixtime.Enter += TextboxUnixtime_Enter;
			textboxUnixtime.KeyPress += TextboxUnixTime_KeyPress;
			textboxUnixtime.Leave += TextboxUnixtime_Leave;
			textboxUnixtime.MouseEnter += TextboxUnixtime_MouseEnter;
			textboxUnixtime.MouseLeave += TextboxUnixtime_MouseLeave;
			// 
			// statusStrip
			// 
			statusStrip.AccessibleDescription = "StatusBar";
			statusStrip.AccessibleName = "StatusBar";
			statusStrip.AccessibleRole = AccessibleRole.StatusBar;
			statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelInformation, toolStripStatusLabelTakeScreenshot });
			statusStrip.Location = new Point(0, 285);
			statusStrip.Name = "statusStrip";
			statusStrip.Padding = new Padding(1, 0, 16, 0);
			statusStrip.ShowItemToolTips = true;
			statusStrip.Size = new Size(354, 22);
			statusStrip.SizingGrip = false;
			statusStrip.TabIndex = 34;
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
			// JulianDateConverterForm
			// 
			AccessibleDescription = "Converts the Julian date to an other Julian date forn";
			AccessibleName = "Julian Date Converter";
			AccessibleRole = AccessibleRole.Window;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(354, 307);
			Controls.Add(statusStrip);
			Controls.Add(textboxUnixtime);
			Controls.Add(textboxMarsSolDate);
			Controls.Add(textboxRataDie);
			Controls.Add(textboxLilianDate);
			Controls.Add(textboxChronologicalModifiedJulianDate);
			Controls.Add(textboxChronologicalJulianDate);
			Controls.Add(textboxMillenniumJulianDate);
			Controls.Add(textboxLopJulianDate);
			Controls.Add(textboxCcsdsJulianDate);
			Controls.Add(textboxCnesJulianDate);
			Controls.Add(textboxDublinJulianDate);
			Controls.Add(textboxTruncatedJulianDate);
			Controls.Add(textboxReducedJulianDate);
			Controls.Add(textboxModifiedJulianDate);
			Controls.Add(textboxJulianDate);
			Controls.Add(labelUnixtimeText);
			Controls.Add(labelMarsSolDateText);
			Controls.Add(labelRataDieText);
			Controls.Add(labelLilianDateText);
			Controls.Add(labelChronologicalModifiedJulianDateText);
			Controls.Add(labelChronologicalJulianDateText);
			Controls.Add(labelUtcTime);
			Controls.Add(labelUtcTimeText);
			Controls.Add(labelLocalTime);
			Controls.Add(labelLocalTimeText);
			Controls.Add(labelMillenniumJulianDateText);
			Controls.Add(labelLopJulianDateText);
			Controls.Add(labelCcsdsJulianDateText);
			Controls.Add(labelCnesJulianDateText);
			Controls.Add(labelDublinJulianDateText);
			Controls.Add(labelTruncatedJulianDateText);
			Controls.Add(labelReducedJulianDateText);
			Controls.Add(labelModifiedJulianDateText);
			Controls.Add(labelJulianDateText);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "JulianDateConverterForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "JD converter";
			Load += JulianDateConverterForm_Load;
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label labelUnixtimeText;
		private Label labelMarsSolDateText;
		private Label labelRataDieText;
		private Label labelLilianDateText;
		private Label labelChronologicalModifiedJulianDateText;
		private Label labelChronologicalJulianDateText;
		private Label labelUtcTime;
		private Label labelUtcTimeText;
		private Label labelLocalTime;
		private Label labelLocalTimeText;
		private Label labelMillenniumJulianDateText;
		private Label labelLopJulianDateText;
		private Label labelCcsdsJulianDateText;
		private Label labelCnesJulianDateText;
		private Label labelDublinJulianDateText;
		private Label labelTruncatedJulianDateText;
		private Label labelReducedJulianDateText;
		private Label labelModifiedJulianDateText;
		private Label labelJulianDateText;
		private ToolTip toolTip;
		private TextBox textboxJulianDate;
		private TextBox textboxModifiedJulianDate;
		private TextBox textboxReducedJulianDate;
		private TextBox textboxTruncatedJulianDate;
		private TextBox textboxDublinJulianDate;
		private TextBox textboxCnesJulianDate;
		private TextBox textboxCcsdsJulianDate;
		private TextBox textboxMarsSolDate;
		private TextBox textboxRataDie;
		private TextBox textboxLilianDate;
		private TextBox textboxChronologicalModifiedJulianDate;
		private TextBox textboxChronologicalJulianDate;
		private TextBox textboxMillenniumJulianDate;
		private TextBox textboxLopJulianDate;
		private TextBox textboxUnixtime;
		private StatusStrip statusStrip;
		private ToolStripStatusLabel toolStripStatusLabelInformation;
		private ToolStripStatusLabel toolStripStatusLabelTakeScreenshot;
	}
}