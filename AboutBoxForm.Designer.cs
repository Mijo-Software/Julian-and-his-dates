using System.ComponentModel;

namespace Julian_and_his_dates
{
	sealed partial class AboutBoxForm
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
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
			ComponentResourceManager resources = new ComponentResourceManager(typeof(AboutBoxForm));
			toolTip = new ToolTip(components);
			okButton = new Button();
			textBoxDescription = new TextBox();
			labelCompanyName = new Label();
			labelCopyright = new Label();
			labelVersion = new Label();
			labelProductName = new Label();
			logoPictureBox = new PictureBox();
			ContentPanel = new ToolStripContentPanel();
			BottomToolStripPanel = new ToolStripPanel();
			TopToolStripPanel = new ToolStripPanel();
			RightToolStripPanel = new ToolStripPanel();
			LeftToolStripPanel = new ToolStripPanel();
			tableLayoutPanel = new TableLayoutPanel();
			statusStrip = new StatusStrip();
			labelInformation = new ToolStripStatusLabel();
			toolStripContainer = new ToolStripContainer();
			((ISupportInitialize)logoPictureBox).BeginInit();
			tableLayoutPanel.SuspendLayout();
			statusStrip.SuspendLayout();
			toolStripContainer.BottomToolStripPanel.SuspendLayout();
			toolStripContainer.ContentPanel.SuspendLayout();
			toolStripContainer.SuspendLayout();
			SuspendLayout();
			// 
			// okButton
			// 
			okButton.AccessibleDescription = "Just a button to close the window";
			okButton.AccessibleName = "OK Button";
			okButton.AccessibleRole = AccessibleRole.PushButton;
			okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			okButton.AutoEllipsis = true;
			okButton.DialogResult = DialogResult.Cancel;
			okButton.FlatStyle = FlatStyle.Popup;
			okButton.Location = new Point(212, 147);
			okButton.Margin = new Padding(4, 3, 4, 3);
			okButton.Name = "okButton";
			okButton.Size = new Size(88, 27);
			okButton.TabIndex = 5;
			okButton.Text = "&OK";
			toolTip.SetToolTip(okButton, "Just a button to close the window");
			okButton.Enter += SetStatusBar_Enter;
			okButton.Leave += ClearStatusBar_Leave;
			okButton.MouseEnter += SetStatusBar_Enter;
			okButton.MouseLeave += ClearStatusBar_Leave;
			// 
			// textBoxDescription
			// 
			textBoxDescription.AccessibleDescription = "This is a longer description of the application.";
			textBoxDescription.AccessibleName = "Description";
			textBoxDescription.AccessibleRole = AccessibleRole.Text;
			textBoxDescription.Dock = DockStyle.Fill;
			textBoxDescription.Location = new Point(98, 71);
			textBoxDescription.Margin = new Padding(7, 3, 4, 3);
			textBoxDescription.Multiline = true;
			textBoxDescription.Name = "textBoxDescription";
			textBoxDescription.ReadOnly = true;
			textBoxDescription.ScrollBars = ScrollBars.Both;
			textBoxDescription.Size = new Size(202, 62);
			textBoxDescription.TabIndex = 4;
			textBoxDescription.TabStop = false;
			textBoxDescription.Text = "Description";
			toolTip.SetToolTip(textBoxDescription, "This is a longer description of the application.");
			textBoxDescription.Enter += SetStatusBar_Enter;
			textBoxDescription.Leave += ClearStatusBar_Leave;
			textBoxDescription.MouseEnter += SetStatusBar_Enter;
			textBoxDescription.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelCompanyName
			// 
			labelCompanyName.AccessibleDescription = "This is the firm name of the application.";
			labelCompanyName.AccessibleName = "Firm Name";
			labelCompanyName.AccessibleRole = AccessibleRole.StatusBar;
			labelCompanyName.AutoEllipsis = true;
			labelCompanyName.BackColor = Color.Transparent;
			labelCompanyName.Dock = DockStyle.Fill;
			labelCompanyName.Location = new Point(98, 51);
			labelCompanyName.Margin = new Padding(7, 0, 4, 0);
			labelCompanyName.MaximumSize = new Size(0, 20);
			labelCompanyName.Name = "labelCompanyName";
			labelCompanyName.Size = new Size(202, 17);
			labelCompanyName.TabIndex = 3;
			labelCompanyName.Text = "Firm Name";
			labelCompanyName.TextAlign = ContentAlignment.MiddleLeft;
			toolTip.SetToolTip(labelCompanyName, "This is the firm name of the application.");
			labelCompanyName.Enter += SetStatusBar_Enter;
			labelCompanyName.Leave += ClearStatusBar_Leave;
			labelCompanyName.MouseEnter += SetStatusBar_Enter;
			labelCompanyName.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelCopyright
			// 
			labelCopyright.AccessibleDescription = "This is the copyright information of the application.";
			labelCopyright.AccessibleName = "Copyright";
			labelCopyright.AccessibleRole = AccessibleRole.StaticText;
			labelCopyright.AutoEllipsis = true;
			labelCopyright.BackColor = Color.Transparent;
			labelCopyright.Dock = DockStyle.Fill;
			labelCopyright.Location = new Point(98, 34);
			labelCopyright.Margin = new Padding(7, 0, 4, 0);
			labelCopyright.MaximumSize = new Size(0, 20);
			labelCopyright.Name = "labelCopyright";
			labelCopyright.Size = new Size(202, 17);
			labelCopyright.TabIndex = 2;
			labelCopyright.Text = "Copyright";
			labelCopyright.TextAlign = ContentAlignment.MiddleLeft;
			toolTip.SetToolTip(labelCopyright, "This is the copyright information of the application.");
			labelCopyright.Enter += SetStatusBar_Enter;
			labelCopyright.Leave += ClearStatusBar_Leave;
			labelCopyright.MouseEnter += SetStatusBar_Enter;
			labelCopyright.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelVersion
			// 
			labelVersion.AccessibleDescription = "This is the version of the application.";
			labelVersion.AccessibleName = "Version";
			labelVersion.AccessibleRole = AccessibleRole.StaticText;
			labelVersion.AutoEllipsis = true;
			labelVersion.BackColor = Color.Transparent;
			labelVersion.Dock = DockStyle.Fill;
			labelVersion.Location = new Point(98, 17);
			labelVersion.Margin = new Padding(7, 0, 4, 0);
			labelVersion.MaximumSize = new Size(0, 20);
			labelVersion.Name = "labelVersion";
			labelVersion.Size = new Size(202, 17);
			labelVersion.TabIndex = 1;
			labelVersion.Text = "Version";
			labelVersion.TextAlign = ContentAlignment.MiddleLeft;
			toolTip.SetToolTip(labelVersion, "This is the version of the application.");
			labelVersion.Enter += SetStatusBar_Enter;
			labelVersion.Leave += ClearStatusBar_Leave;
			labelVersion.MouseEnter += SetStatusBar_Enter;
			labelVersion.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelProductName
			// 
			labelProductName.AccessibleDescription = "This is the name of the application.";
			labelProductName.AccessibleName = "Product Name";
			labelProductName.AccessibleRole = AccessibleRole.StaticText;
			labelProductName.AutoEllipsis = true;
			labelProductName.BackColor = Color.Transparent;
			labelProductName.Dock = DockStyle.Fill;
			labelProductName.Location = new Point(98, 0);
			labelProductName.Margin = new Padding(7, 0, 4, 0);
			labelProductName.MaximumSize = new Size(0, 20);
			labelProductName.Name = "labelProductName";
			labelProductName.Size = new Size(202, 17);
			labelProductName.TabIndex = 0;
			labelProductName.Text = "Product Name";
			labelProductName.TextAlign = ContentAlignment.MiddleLeft;
			toolTip.SetToolTip(labelProductName, "This is the name of the application.");
			labelProductName.Enter += SetStatusBar_Enter;
			labelProductName.Leave += ClearStatusBar_Leave;
			labelProductName.MouseEnter += SetStatusBar_Enter;
			labelProductName.MouseLeave += ClearStatusBar_Leave;
			// 
			// logoPictureBox
			// 
			logoPictureBox.AccessibleDescription = "This is the logo of the application.";
			logoPictureBox.AccessibleName = "Logo";
			logoPictureBox.AccessibleRole = AccessibleRole.Graphic;
			logoPictureBox.Dock = DockStyle.Fill;
			logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
			logoPictureBox.Location = new Point(4, 3);
			logoPictureBox.Margin = new Padding(4, 3, 4, 3);
			logoPictureBox.Name = "logoPictureBox";
			tableLayoutPanel.SetRowSpan(logoPictureBox, 6);
			logoPictureBox.Size = new Size(83, 171);
			logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
			logoPictureBox.TabIndex = 12;
			logoPictureBox.TabStop = false;
			toolTip.SetToolTip(logoPictureBox, "This is the logo of the application.");
			logoPictureBox.Click += LogoPictureBox_Click;
			logoPictureBox.MouseEnter += SetStatusBar_Enter;
			logoPictureBox.MouseLeave += ClearStatusBar_Leave;
			// 
			// ContentPanel
			// 
			ContentPanel.AccessibleDescription = "Just a pane to justify the elements";
			ContentPanel.AccessibleName = "Pane";
			ContentPanel.AccessibleRole = AccessibleRole.Pane;
			ContentPanel.Size = new Size(304, 138);
			// 
			// BottomToolStripPanel
			// 
			BottomToolStripPanel.AccessibleDescription = "Just a pane to justify the elements";
			BottomToolStripPanel.AccessibleName = "Pane";
			BottomToolStripPanel.AccessibleRole = AccessibleRole.Pane;
			BottomToolStripPanel.Location = new Point(0, 0);
			BottomToolStripPanel.Name = "BottomToolStripPanel";
			BottomToolStripPanel.Orientation = Orientation.Horizontal;
			BottomToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
			BottomToolStripPanel.Size = new Size(0, 0);
			// 
			// TopToolStripPanel
			// 
			TopToolStripPanel.AccessibleDescription = "Just a pane to justify the elements";
			TopToolStripPanel.AccessibleName = "Pane";
			TopToolStripPanel.AccessibleRole = AccessibleRole.Pane;
			TopToolStripPanel.Location = new Point(0, 0);
			TopToolStripPanel.Name = "TopToolStripPanel";
			TopToolStripPanel.Orientation = Orientation.Horizontal;
			TopToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
			TopToolStripPanel.Size = new Size(0, 0);
			// 
			// RightToolStripPanel
			// 
			RightToolStripPanel.AccessibleDescription = "Just a pane to justify the elements";
			RightToolStripPanel.AccessibleName = "Pane";
			RightToolStripPanel.AccessibleRole = AccessibleRole.Pane;
			RightToolStripPanel.Location = new Point(0, 0);
			RightToolStripPanel.Name = "RightToolStripPanel";
			RightToolStripPanel.Orientation = Orientation.Horizontal;
			RightToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
			RightToolStripPanel.Size = new Size(0, 0);
			// 
			// LeftToolStripPanel
			// 
			LeftToolStripPanel.AccessibleDescription = "Just a pane to justify the elements";
			LeftToolStripPanel.AccessibleName = "Pane";
			LeftToolStripPanel.AccessibleRole = AccessibleRole.Pane;
			LeftToolStripPanel.Location = new Point(0, 0);
			LeftToolStripPanel.Name = "LeftToolStripPanel";
			LeftToolStripPanel.Orientation = Orientation.Horizontal;
			LeftToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
			LeftToolStripPanel.Size = new Size(0, 0);
			// 
			// tableLayoutPanel
			// 
			tableLayoutPanel.AccessibleDescription = "Just a pane to justify the elements";
			tableLayoutPanel.AccessibleName = "Pane";
			tableLayoutPanel.AccessibleRole = AccessibleRole.Pane;
			tableLayoutPanel.ColumnCount = 2;
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
			tableLayoutPanel.Controls.Add(logoPictureBox, 0, 0);
			tableLayoutPanel.Controls.Add(labelProductName, 1, 0);
			tableLayoutPanel.Controls.Add(labelVersion, 1, 1);
			tableLayoutPanel.Controls.Add(labelCopyright, 1, 2);
			tableLayoutPanel.Controls.Add(labelCompanyName, 1, 3);
			tableLayoutPanel.Controls.Add(textBoxDescription, 1, 4);
			tableLayoutPanel.Controls.Add(okButton, 1, 5);
			tableLayoutPanel.Dock = DockStyle.Fill;
			tableLayoutPanel.Location = new Point(0, 0);
			tableLayoutPanel.Margin = new Padding(4, 3, 4, 3);
			tableLayoutPanel.Name = "tableLayoutPanel";
			tableLayoutPanel.RowCount = 6;
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 38.75F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 21.25F));
			tableLayoutPanel.Size = new Size(304, 177);
			tableLayoutPanel.TabIndex = 0;
			// 
			// statusStrip
			// 
			statusStrip.AccessibleDescription = "Statusbar";
			statusStrip.AccessibleName = "Statusbar";
			statusStrip.AccessibleRole = AccessibleRole.StatusBar;
			statusStrip.Dock = DockStyle.None;
			statusStrip.Items.AddRange(new ToolStripItem[] { labelInformation });
			statusStrip.Location = new Point(0, 0);
			statusStrip.Name = "statusStrip";
			statusStrip.Size = new Size(304, 22);
			statusStrip.TabIndex = 1;
			statusStrip.Text = "Statusbar";
			statusStrip.Enter += SetStatusBar_Enter;
			statusStrip.Leave += ClearStatusBar_Leave;
			statusStrip.MouseEnter += SetStatusBar_Enter;
			statusStrip.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelInformation
			// 
			labelInformation.AccessibleDescription = "Show some information";
			labelInformation.AccessibleName = "Show some information";
			labelInformation.AccessibleRole = AccessibleRole.StaticText;
			labelInformation.AutoToolTip = true;
			labelInformation.Name = "labelInformation";
			labelInformation.Size = new Size(56, 17);
			labelInformation.Text = "Statusbar";
			labelInformation.ToolTipText = "Statusbar";
			labelInformation.MouseEnter += SetStatusBar_Enter;
			labelInformation.MouseLeave += ClearStatusBar_Leave;
			// 
			// toolStripContainer
			// 
			toolStripContainer.AccessibleDescription = "Just a pane to justify the elements";
			toolStripContainer.AccessibleName = "Pane";
			toolStripContainer.AccessibleRole = AccessibleRole.Pane;
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			toolStripContainer.BottomToolStripPanel.Controls.Add(statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			toolStripContainer.ContentPanel.Controls.Add(tableLayoutPanel);
			toolStripContainer.ContentPanel.Size = new Size(304, 177);
			toolStripContainer.Dock = DockStyle.Fill;
			toolStripContainer.Location = new Point(0, 0);
			toolStripContainer.Name = "toolStripContainer";
			toolStripContainer.Size = new Size(304, 224);
			toolStripContainer.TabIndex = 2;
			toolStripContainer.Text = "toolStripContainer";
			// 
			// AboutBoxForm
			// 
			AcceptButton = okButton;
			AccessibleDescription = "Show some information about the application";
			AccessibleName = "Information Window";
			AccessibleRole = AccessibleRole.Window;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(304, 224);
			Controls.Add(toolStripContainer);
			FormBorderStyle = FormBorderStyle.SizableToolWindow;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "AboutBoxForm";
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "About";
			Load += AboutBoxForm_Load;
			((ISupportInitialize)logoPictureBox).EndInit();
			tableLayoutPanel.ResumeLayout(false);
			tableLayoutPanel.PerformLayout();
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			toolStripContainer.BottomToolStripPanel.PerformLayout();
			toolStripContainer.ContentPanel.ResumeLayout(false);
			toolStripContainer.ResumeLayout(false);
			toolStripContainer.PerformLayout();
			ResumeLayout(false);

		}

		#endregion
		private ToolTip toolTip;
		private ToolStripPanel BottomToolStripPanel;
		private ToolStripPanel TopToolStripPanel;
		private ToolStripPanel RightToolStripPanel;
		private ToolStripPanel LeftToolStripPanel;
		private ToolStripContentPanel ContentPanel;
		private TableLayoutPanel tableLayoutPanel;
		private PictureBox logoPictureBox;
		private Label labelProductName;
		private Label labelVersion;
		private Label labelCopyright;
		private Label labelCompanyName;
		private TextBox textBoxDescription;
		private Button okButton;
		private StatusStrip statusStrip;
		private ToolStripContainer toolStripContainer;
		private ToolStripStatusLabel labelInformation;
	}
}
