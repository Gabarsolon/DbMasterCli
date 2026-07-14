namespace DbMaster
{
	// Token: 0x02000014 RID: 20
	public partial class DbMaster : global::System.Windows.Forms.Form
	{
		// Token: 0x060002AE RID: 686 RVA: 0x0000D283 File Offset: 0x0000B483
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000D2A4 File Offset: 0x0000B4A4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::DbMaster.DbMaster));
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.mainMenu = new global::System.Windows.Forms.MenuStrip();
			this.menuFile = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuOpen = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuSave = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuClose = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuExit = new global::System.Windows.Forms.ToolStripMenuItem();
			this.extractFromBigToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mainDatabaseToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.localDatabasesToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuTable = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuExportCsv = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuImportCsv = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuExportAll = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuImportAll = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuRecord = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuCopy = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuPaste = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuReplace = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuDelete = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuCount = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuSort = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuTools = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuLoadIntelli = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuFind = new global::System.Windows.Forms.ToolStripMenuItem();
			this.findExactlyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuEnableAllMessages = new global::System.Windows.Forms.ToolStripMenuItem();
			this.expandFifadbToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.diagnosticToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.calculateHashidToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuHelp = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuHelpFile = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuAbout = new global::System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip = new global::System.Windows.Forms.StatusStrip();
			this.progressBar = new global::System.Windows.Forms.ToolStripProgressBar();
			this.statusLabel = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.panelTop = new global::System.Windows.Forms.Panel();
			this.buttonComputeHash = new global::System.Windows.Forms.Button();
			this.dateIntelli = new global::System.Windows.Forms.DateTimePicker();
			this.textType = new global::System.Windows.Forms.TextBox();
			this.labelMax = new global::System.Windows.Forms.Label();
			this.numericMax = new global::System.Windows.Forms.NumericUpDown();
			this.numericMin = new global::System.Windows.Forms.NumericUpDown();
			this.labelMin = new global::System.Windows.Forms.Label();
			this.comboSearch = new global::System.Windows.Forms.ComboBox();
			this.comboIntelli = new global::System.Windows.Forms.ComboBox();
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.listBoxTables = new global::System.Windows.Forms.ListBox();
			this.dataGridView = new global::System.Windows.Forms.DataGridView();
			this.toolStrip = new global::System.Windows.Forms.ToolStrip();
			this.buttonOpen = new global::System.Windows.Forms.ToolStripButton();
			this.buttonSave = new global::System.Windows.Forms.ToolStripButton();
			this.buttonClose = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.buttonExportSingle = new global::System.Windows.Forms.ToolStripButton();
			this.buttonExportMulti = new global::System.Windows.Forms.ToolStripButton();
			this.buttonImportSingle = new global::System.Windows.Forms.ToolStripButton();
			this.buttonImportMulti = new global::System.Windows.Forms.ToolStripButton();
			this.buttonIntelliEdit = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.buttonRecordCopy = new global::System.Windows.Forms.ToolStripButton();
			this.buttonRecordcInsert = new global::System.Windows.Forms.ToolStripButton();
			this.buttonRecordcReplace = new global::System.Windows.Forms.ToolStripButton();
			this.buttonRecordcDelete = new global::System.Windows.Forms.ToolStripButton();
			this.buttonRecordcCount = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.buttonFindExactly = new global::System.Windows.Forms.ToolStripButton();
			this.buttonFind = new global::System.Windows.Forms.ToolStripButton();
			this.textSearch = new global::System.Windows.Forms.ToolStripTextBox();
			this.openFileDialog = new global::System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new global::System.Windows.Forms.SaveFileDialog();
			this.folderBrowser = new global::System.Windows.Forms.FolderBrowserDialog();
			this.contextMenuCell = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.mainMenu.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.panelTop.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericMax).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericMin).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView).BeginInit();
			this.toolStrip.SuspendLayout();
			base.SuspendLayout();
			this.mainMenu.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("mainMenu.BackgroundImage");
			this.mainMenu.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.mainMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.menuFile, this.menuTable, this.menuRecord, this.menuTools, this.menuHelp });
			this.mainMenu.Location = new global::System.Drawing.Point(0, 0);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Size = new global::System.Drawing.Size(985, 24);
			this.mainMenu.TabIndex = 0;
			this.mainMenu.Text = "mainMenu";
			this.menuFile.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.menuOpen, this.menuSave, this.menuClose, this.menuExit, this.extractFromBigToolStripMenuItem });
			this.menuFile.Name = "menuFile";
			this.menuFile.Size = new global::System.Drawing.Size(37, 20);
			this.menuFile.Text = "File";
			this.menuOpen.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuOpen.Image");
			this.menuOpen.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuOpen.Name = "menuOpen";
			this.menuOpen.Size = new global::System.Drawing.Size(162, 22);
			this.menuOpen.Text = "Open DB";
			this.menuOpen.Click += new global::System.EventHandler(this.menuOpen_Click);
			this.menuSave.Enabled = false;
			this.menuSave.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuSave.Image");
			this.menuSave.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuSave.Name = "menuSave";
			this.menuSave.Size = new global::System.Drawing.Size(162, 22);
			this.menuSave.Text = "Save";
			this.menuSave.Click += new global::System.EventHandler(this.menuSave_Click);
			this.menuClose.Enabled = false;
			this.menuClose.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuClose.Image");
			this.menuClose.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuClose.Name = "menuClose";
			this.menuClose.Size = new global::System.Drawing.Size(162, 22);
			this.menuClose.Text = "Close";
			this.menuClose.Click += new global::System.EventHandler(this.menuClose_Click);
			this.menuExit.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuExit.Image");
			this.menuExit.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuExit.Name = "menuExit";
			this.menuExit.Size = new global::System.Drawing.Size(162, 22);
			this.menuExit.Text = "Exit";
			this.menuExit.Click += new global::System.EventHandler(this.menuExit_Click);
			this.extractFromBigToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.mainDatabaseToolStripMenuItem, this.localDatabasesToolStripMenuItem });
			this.extractFromBigToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("extractFromBigToolStripMenuItem.Image");
			this.extractFromBigToolStripMenuItem.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.extractFromBigToolStripMenuItem.Name = "extractFromBigToolStripMenuItem";
			this.extractFromBigToolStripMenuItem.Size = new global::System.Drawing.Size(162, 22);
			this.extractFromBigToolStripMenuItem.Text = "Extract from .BIG";
			this.mainDatabaseToolStripMenuItem.Name = "mainDatabaseToolStripMenuItem";
			this.mainDatabaseToolStripMenuItem.Size = new global::System.Drawing.Size(157, 22);
			this.mainDatabaseToolStripMenuItem.Text = "Main database";
			this.mainDatabaseToolStripMenuItem.Click += new global::System.EventHandler(this.mainDatabaseToolStripMenuItem_Click);
			this.localDatabasesToolStripMenuItem.Name = "localDatabasesToolStripMenuItem";
			this.localDatabasesToolStripMenuItem.Size = new global::System.Drawing.Size(157, 22);
			this.localDatabasesToolStripMenuItem.Text = "Local databases";
			this.localDatabasesToolStripMenuItem.Click += new global::System.EventHandler(this.localDatabasesToolStripMenuItem_Click);
			this.menuTable.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.menuExportCsv, this.menuImportCsv, this.menuExportAll, this.menuImportAll });
			this.menuTable.Enabled = false;
			this.menuTable.Name = "menuTable";
			this.menuTable.Size = new global::System.Drawing.Size(48, 20);
			this.menuTable.Text = "Table";
			this.menuExportCsv.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuExportCsv.Image");
			this.menuExportCsv.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuExportCsv.Name = "menuExportCsv";
			this.menuExportCsv.Size = new global::System.Drawing.Size(152, 22);
			this.menuExportCsv.Text = "Export Single";
			this.menuExportCsv.Click += new global::System.EventHandler(this.menuExportCsv_Click);
			this.menuImportCsv.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuImportCsv.Image");
			this.menuImportCsv.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuImportCsv.Name = "menuImportCsv";
			this.menuImportCsv.Size = new global::System.Drawing.Size(152, 22);
			this.menuImportCsv.Text = "Import Single";
			this.menuImportCsv.Click += new global::System.EventHandler(this.menuImportCsv_Click);
			this.menuExportAll.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuExportAll.Image");
			this.menuExportAll.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuExportAll.Name = "menuExportAll";
			this.menuExportAll.Size = new global::System.Drawing.Size(152, 22);
			this.menuExportAll.Text = "Export All";
			this.menuExportAll.Click += new global::System.EventHandler(this.menuExportAll_Click);
			this.menuImportAll.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuImportAll.Image");
			this.menuImportAll.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuImportAll.Name = "menuImportAll";
			this.menuImportAll.Size = new global::System.Drawing.Size(152, 22);
			this.menuImportAll.Text = "Import All";
			this.menuImportAll.Click += new global::System.EventHandler(this.menuImportAll_Click);
			this.menuRecord.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.menuCopy, this.menuPaste, this.menuReplace, this.menuDelete, this.menuCount, this.menuSort });
			this.menuRecord.Enabled = false;
			this.menuRecord.Name = "menuRecord";
			this.menuRecord.Size = new global::System.Drawing.Size(56, 20);
			this.menuRecord.Text = "Record";
			this.menuCopy.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuCopy.Image");
			this.menuCopy.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuCopy.Name = "menuCopy";
			this.menuCopy.ShortcutKeys = global::System.Windows.Forms.Keys.F4;
			this.menuCopy.Size = new global::System.Drawing.Size(152, 22);
			this.menuCopy.Text = "Copy";
			this.menuCopy.Click += new global::System.EventHandler(this.menuCopy_Click);
			this.menuPaste.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuPaste.Image");
			this.menuPaste.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuPaste.Name = "menuPaste";
			this.menuPaste.ShortcutKeys = global::System.Windows.Forms.Keys.F5;
			this.menuPaste.Size = new global::System.Drawing.Size(152, 22);
			this.menuPaste.Text = "Insert";
			this.menuPaste.Click += new global::System.EventHandler(this.menuPaste_Click);
			this.menuReplace.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuReplace.Image");
			this.menuReplace.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuReplace.Name = "menuReplace";
			this.menuReplace.ShortcutKeys = global::System.Windows.Forms.Keys.F6;
			this.menuReplace.Size = new global::System.Drawing.Size(152, 22);
			this.menuReplace.Text = "Replace";
			this.menuReplace.Click += new global::System.EventHandler(this.menuReplace_Click);
			this.menuDelete.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuDelete.Image");
			this.menuDelete.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuDelete.Name = "menuDelete";
			this.menuDelete.ShortcutKeys = (global::System.Windows.Forms.Keys)131140;
			this.menuDelete.Size = new global::System.Drawing.Size(152, 22);
			this.menuDelete.Text = "Delete";
			this.menuDelete.Click += new global::System.EventHandler(this.menuDelete_Click);
			this.menuCount.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuCount.Image");
			this.menuCount.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuCount.Name = "menuCount";
			this.menuCount.Size = new global::System.Drawing.Size(152, 22);
			this.menuCount.Text = "Count";
			this.menuCount.Click += new global::System.EventHandler(this.menuCount_Click);
			this.menuSort.Checked = true;
			this.menuSort.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.menuSort.Name = "menuSort";
			this.menuSort.Size = new global::System.Drawing.Size(152, 22);
			this.menuSort.Text = "Sort";
			this.menuSort.Visible = false;
			this.menuSort.Click += new global::System.EventHandler(this.menuSort_Click);
			this.menuTools.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.menuLoadIntelli, this.menuFind, this.findExactlyToolStripMenuItem, this.menuEnableAllMessages, this.expandFifadbToolStripMenuItem, this.diagnosticToolStripMenuItem, this.calculateHashidToolStripMenuItem });
			this.menuTools.Enabled = false;
			this.menuTools.Name = "menuTools";
			this.menuTools.Size = new global::System.Drawing.Size(48, 20);
			this.menuTools.Text = "Tools";
			this.menuLoadIntelli.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuLoadIntelli.Image");
			this.menuLoadIntelli.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuLoadIntelli.Name = "menuLoadIntelli";
			this.menuLoadIntelli.Size = new global::System.Drawing.Size(202, 22);
			this.menuLoadIntelli.Text = "Load Intelli-Edit Schema";
			this.menuLoadIntelli.Click += new global::System.EventHandler(this.menuLoadIntelli_Click);
			this.menuFind.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuFind.Image");
			this.menuFind.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuFind.Name = "menuFind";
			this.menuFind.ShortcutKeys = global::System.Windows.Forms.Keys.F3;
			this.menuFind.Size = new global::System.Drawing.Size(202, 22);
			this.menuFind.Text = "Find";
			this.menuFind.Click += new global::System.EventHandler(this.menuFind_Click);
			this.findExactlyToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("findExactlyToolStripMenuItem.Image");
			this.findExactlyToolStripMenuItem.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.findExactlyToolStripMenuItem.Name = "findExactlyToolStripMenuItem";
			this.findExactlyToolStripMenuItem.Size = new global::System.Drawing.Size(202, 22);
			this.findExactlyToolStripMenuItem.Text = "Find Exactly";
			this.menuEnableAllMessages.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuEnableAllMessages.Image");
			this.menuEnableAllMessages.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuEnableAllMessages.Name = "menuEnableAllMessages";
			this.menuEnableAllMessages.Size = new global::System.Drawing.Size(202, 22);
			this.menuEnableAllMessages.Text = "Enable All Messages";
			this.menuEnableAllMessages.Click += new global::System.EventHandler(this.menuEnableAllMessages_Click);
			this.expandFifadbToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("expandFifadbToolStripMenuItem.Image");
			this.expandFifadbToolStripMenuItem.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.expandFifadbToolStripMenuItem.Name = "expandFifadbToolStripMenuItem";
			this.expandFifadbToolStripMenuItem.Size = new global::System.Drawing.Size(202, 22);
			this.expandFifadbToolStripMenuItem.Text = "Expand FIFA Database";
			this.expandFifadbToolStripMenuItem.Click += new global::System.EventHandler(this.expandFifadbToolStripMenuItem_Click);
			this.diagnosticToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("diagnosticToolStripMenuItem.Image");
			this.diagnosticToolStripMenuItem.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.diagnosticToolStripMenuItem.Name = "diagnosticToolStripMenuItem";
			this.diagnosticToolStripMenuItem.Size = new global::System.Drawing.Size(202, 22);
			this.diagnosticToolStripMenuItem.Text = "Diagnostic";
			this.diagnosticToolStripMenuItem.Visible = false;
			this.diagnosticToolStripMenuItem.Click += new global::System.EventHandler(this.diagnosticToolStripMenuItem_Click);
			this.calculateHashidToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("calculateHashidToolStripMenuItem.Image");
			this.calculateHashidToolStripMenuItem.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.calculateHashidToolStripMenuItem.Name = "calculateHashidToolStripMenuItem";
			this.calculateHashidToolStripMenuItem.Size = new global::System.Drawing.Size(202, 22);
			this.calculateHashidToolStripMenuItem.Text = "Calculate All Hash";
			this.calculateHashidToolStripMenuItem.Click += new global::System.EventHandler(this.calculateHashidToolStripMenuItem_Click);
			this.menuHelp.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.menuHelpFile, this.menuAbout });
			this.menuHelp.Name = "menuHelp";
			this.menuHelp.Size = new global::System.Drawing.Size(44, 20);
			this.menuHelp.Text = "Help";
			this.menuHelpFile.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuHelpFile.Image");
			this.menuHelpFile.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuHelpFile.Name = "menuHelpFile";
			this.menuHelpFile.Size = new global::System.Drawing.Size(107, 22);
			this.menuHelpFile.Text = "Help";
			this.menuHelpFile.Click += new global::System.EventHandler(this.menuHelpFile_Click);
			this.menuAbout.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuAbout.Image");
			this.menuAbout.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuAbout.Name = "menuAbout";
			this.menuAbout.Size = new global::System.Drawing.Size(107, 22);
			this.menuAbout.Text = "About";
			this.menuAbout.Click += new global::System.EventHandler(this.menuAbout_Click);
			this.statusStrip.BackColor = global::System.Drawing.SystemColors.InactiveCaptionText;
			this.statusStrip.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("statusStrip.BackgroundImage");
			this.statusStrip.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.statusStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.progressBar, this.statusLabel });
			this.statusStrip.Location = new global::System.Drawing.Point(0, 559);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new global::System.Drawing.Size(985, 22);
			this.statusStrip.TabIndex = 1;
			this.statusStrip.Text = "statusStrip";
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new global::System.Drawing.Size(120, 16);
			this.progressBar.Style = global::System.Windows.Forms.ProgressBarStyle.Continuous;
			this.statusLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new global::System.Drawing.Size(39, 17);
			this.statusLabel.Text = "Ready";
			this.statusLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.panelTop.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panelTop.BackgroundImage");
			this.panelTop.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.panelTop.Controls.Add(this.buttonComputeHash);
			this.panelTop.Controls.Add(this.dateIntelli);
			this.panelTop.Controls.Add(this.textType);
			this.panelTop.Controls.Add(this.labelMax);
			this.panelTop.Controls.Add(this.numericMax);
			this.panelTop.Controls.Add(this.numericMin);
			this.panelTop.Controls.Add(this.labelMin);
			this.panelTop.Controls.Add(this.comboSearch);
			this.panelTop.Controls.Add(this.comboIntelli);
			this.panelTop.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelTop.Enabled = false;
			this.panelTop.Location = new global::System.Drawing.Point(0, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new global::System.Drawing.Size(798, 26);
			this.panelTop.TabIndex = 1;
			this.buttonComputeHash.Location = new global::System.Drawing.Point(477, 1);
			this.buttonComputeHash.Name = "buttonComputeHash";
			this.buttonComputeHash.Size = new global::System.Drawing.Size(75, 23);
			this.buttonComputeHash.TabIndex = 12;
			this.buttonComputeHash.Text = "HASH";
			this.buttonComputeHash.UseVisualStyleBackColor = true;
			this.buttonComputeHash.Visible = false;
			this.buttonComputeHash.Click += new global::System.EventHandler(this.buttonComputeHash_Click);
			this.dateIntelli.Format = global::System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateIntelli.Location = new global::System.Drawing.Point(558, 2);
			this.dateIntelli.Name = "dateIntelli";
			this.dateIntelli.Size = new global::System.Drawing.Size(152, 20);
			this.dateIntelli.TabIndex = 11;
			this.dateIntelli.Value = new global::System.DateTime(1985, 1, 1, 0, 0, 0, 0);
			this.dateIntelli.Visible = false;
			this.dateIntelli.ValueChanged += new global::System.EventHandler(this.dateIntelli_ValueChanged);
			this.textType.BackColor = global::System.Drawing.Color.White;
			this.textType.Location = new global::System.Drawing.Point(160, 3);
			this.textType.Name = "textType";
			this.textType.ReadOnly = true;
			this.textType.Size = new global::System.Drawing.Size(81, 20);
			this.textType.TabIndex = 10;
			this.labelMax.BackColor = global::System.Drawing.Color.Transparent;
			this.labelMax.Location = new global::System.Drawing.Point(364, 5);
			this.labelMax.Name = "labelMax";
			this.labelMax.Size = new global::System.Drawing.Size(32, 16);
			this.labelMax.TabIndex = 4;
			this.labelMax.Text = "max";
			this.labelMax.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.numericMax.Location = new global::System.Drawing.Point(399, 3);
			this.numericMax.Name = "numericMax";
			this.numericMax.Size = new global::System.Drawing.Size(72, 20);
			this.numericMax.TabIndex = 3;
			this.numericMax.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericMax.ValueChanged += new global::System.EventHandler(this.numericMax_ValueChanged);
			this.numericMin.Location = new global::System.Drawing.Point(277, 3);
			this.numericMin.Name = "numericMin";
			this.numericMin.Size = new global::System.Drawing.Size(72, 20);
			this.numericMin.TabIndex = 1;
			this.numericMin.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.labelMin.BackColor = global::System.Drawing.Color.Transparent;
			this.labelMin.Location = new global::System.Drawing.Point(247, 5);
			this.labelMin.Name = "labelMin";
			this.labelMin.Size = new global::System.Drawing.Size(24, 16);
			this.labelMin.TabIndex = 2;
			this.labelMin.Text = "min";
			this.labelMin.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.comboSearch.FormattingEnabled = true;
			this.comboSearch.Location = new global::System.Drawing.Point(3, 2);
			this.comboSearch.Name = "comboSearch";
			this.comboSearch.Size = new global::System.Drawing.Size(152, 21);
			this.comboSearch.TabIndex = 0;
			this.comboSearch.SelectedIndexChanged += new global::System.EventHandler(this.comboSearch_SelectedIndexChanged);
			this.comboIntelli.Location = new global::System.Drawing.Point(558, 2);
			this.comboIntelli.MaxDropDownItems = 12;
			this.comboIntelli.Name = "comboIntelli";
			this.comboIntelli.Size = new global::System.Drawing.Size(172, 21);
			this.comboIntelli.TabIndex = 1;
			this.comboIntelli.Visible = false;
			this.comboIntelli.SelectedIndexChanged += new global::System.EventHandler(this.comboIntelli_SelectedIndexChanged);
			this.comboIntelli.SelectionChangeCommitted += new global::System.EventHandler(this.comboIntelli_SelectionChangeCommitted);
			this.splitContainer1.BackColor = global::System.Drawing.Color.Gold;
			this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new global::System.Drawing.Point(0, 49);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Panel1.Controls.Add(this.listBoxTables);
			this.splitContainer1.Panel2.Controls.Add(this.dataGridView);
			this.splitContainer1.Panel2.Controls.Add(this.panelTop);
			this.splitContainer1.Size = new global::System.Drawing.Size(985, 510);
			this.splitContainer1.SplitterDistance = 185;
			this.splitContainer1.SplitterWidth = 2;
			this.splitContainer1.TabIndex = 2;
			this.listBoxTables.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.listBoxTables.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listBoxTables.FormattingEnabled = true;
			this.listBoxTables.Location = new global::System.Drawing.Point(0, 0);
			this.listBoxTables.Name = "listBoxTables";
			this.listBoxTables.Size = new global::System.Drawing.Size(185, 510);
			this.listBoxTables.TabIndex = 0;
			this.listBoxTables.SelectedIndexChanged += new global::System.EventHandler(this.listBox_SelectedIndexChanged);
			this.dataGridView.AllowUserToOrderColumns = true;
			this.dataGridView.ClipboardCopyMode = global::System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridView.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dataGridView.Location = new global::System.Drawing.Point(0, 26);
			this.dataGridView.Name = "dataGridView";
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle3.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView.Size = new global::System.Drawing.Size(798, 484);
			this.dataGridView.TabIndex = 1;
			this.dataGridView.CurrentCellChanged += new global::System.EventHandler(this.dataGridView_CurrentCellChanged);
			this.dataGridView.Enter += new global::System.EventHandler(this.dataGridView_Enter);
			this.toolStrip.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("toolStrip.BackgroundImage");
			this.toolStrip.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.toolStrip.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.buttonOpen, this.buttonSave, this.buttonClose, this.toolStripSeparator1, this.buttonExportSingle, this.buttonExportMulti, this.buttonImportSingle, this.buttonImportMulti, this.buttonIntelliEdit, this.toolStripSeparator2,
				this.buttonRecordCopy, this.buttonRecordcInsert, this.buttonRecordcReplace, this.buttonRecordcDelete, this.buttonRecordcCount, this.toolStripSeparator3, this.buttonFindExactly, this.buttonFind, this.textSearch
			});
			this.toolStrip.Location = new global::System.Drawing.Point(0, 24);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new global::System.Drawing.Size(985, 25);
			this.toolStrip.TabIndex = 0;
			this.toolStrip.Text = "toolStrip";
			this.buttonOpen.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonOpen.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonOpen.Image");
			this.buttonOpen.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.Size = new global::System.Drawing.Size(23, 22);
			this.buttonOpen.Text = "toolStripButton13";
			this.buttonOpen.ToolTipText = "Open DB file";
			this.buttonOpen.Click += new global::System.EventHandler(this.buttonOpen_Click);
			this.buttonSave.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonSave.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonSave.Image");
			this.buttonSave.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new global::System.Drawing.Size(23, 22);
			this.buttonSave.Text = "toolStripButton15";
			this.buttonSave.ToolTipText = "Save File";
			this.buttonSave.Click += new global::System.EventHandler(this.buttonSave_Click);
			this.buttonClose.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonClose.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonClose.Image");
			this.buttonClose.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(23, 22);
			this.buttonClose.Text = "Close File";
			this.buttonClose.ToolTipText = "Close File";
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(6, 25);
			this.buttonExportSingle.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonExportSingle.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonExportSingle.Image");
			this.buttonExportSingle.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonExportSingle.Name = "buttonExportSingle";
			this.buttonExportSingle.Size = new global::System.Drawing.Size(23, 22);
			this.buttonExportSingle.Text = "toolStripButton3";
			this.buttonExportSingle.ToolTipText = "Export Single Table";
			this.buttonExportSingle.Click += new global::System.EventHandler(this.buttonExportSingle_Click);
			this.buttonExportMulti.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonExportMulti.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonExportMulti.Image");
			this.buttonExportMulti.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonExportMulti.Name = "buttonExportMulti";
			this.buttonExportMulti.Size = new global::System.Drawing.Size(23, 22);
			this.buttonExportMulti.Text = "toolStripButton4";
			this.buttonExportMulti.ToolTipText = "Export All Tables";
			this.buttonExportMulti.Click += new global::System.EventHandler(this.buttonExportMulti_Click);
			this.buttonImportSingle.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonImportSingle.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonImportSingle.Image");
			this.buttonImportSingle.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonImportSingle.Name = "buttonImportSingle";
			this.buttonImportSingle.Size = new global::System.Drawing.Size(23, 22);
			this.buttonImportSingle.Text = "toolStripButton5";
			this.buttonImportSingle.ToolTipText = "Import Single Table";
			this.buttonImportSingle.Click += new global::System.EventHandler(this.buttonImportSingle_Click);
			this.buttonImportMulti.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonImportMulti.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonImportMulti.Image");
			this.buttonImportMulti.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonImportMulti.Name = "buttonImportMulti";
			this.buttonImportMulti.Size = new global::System.Drawing.Size(23, 22);
			this.buttonImportMulti.Text = "toolStripButton6";
			this.buttonImportMulti.ToolTipText = "Import All Tables";
			this.buttonImportMulti.Click += new global::System.EventHandler(this.buttonImportMulti_Click);
			this.buttonIntelliEdit.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonIntelliEdit.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonIntelliEdit.Image");
			this.buttonIntelliEdit.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonIntelliEdit.Name = "buttonIntelliEdit";
			this.buttonIntelliEdit.Size = new global::System.Drawing.Size(23, 22);
			this.buttonIntelliEdit.Text = "Load Intelli-Edit";
			this.buttonIntelliEdit.Click += new global::System.EventHandler(this.buttonIntelliEdit_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new global::System.Drawing.Size(6, 25);
			this.buttonRecordCopy.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonRecordCopy.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonRecordCopy.Image");
			this.buttonRecordCopy.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonRecordCopy.Name = "buttonRecordCopy";
			this.buttonRecordCopy.Size = new global::System.Drawing.Size(23, 22);
			this.buttonRecordCopy.Text = "toolStripButton7";
			this.buttonRecordCopy.ToolTipText = "Copy Record";
			this.buttonRecordCopy.Click += new global::System.EventHandler(this.buttonRecordCopy_Click);
			this.buttonRecordcInsert.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonRecordcInsert.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonRecordcInsert.Image");
			this.buttonRecordcInsert.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonRecordcInsert.Name = "buttonRecordcInsert";
			this.buttonRecordcInsert.Size = new global::System.Drawing.Size(23, 22);
			this.buttonRecordcInsert.Text = "toolStripButton8";
			this.buttonRecordcInsert.ToolTipText = "Insert Record";
			this.buttonRecordcInsert.Click += new global::System.EventHandler(this.buttonRecordcInsert_Click);
			this.buttonRecordcReplace.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonRecordcReplace.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonRecordcReplace.Image");
			this.buttonRecordcReplace.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonRecordcReplace.Name = "buttonRecordcReplace";
			this.buttonRecordcReplace.Size = new global::System.Drawing.Size(23, 22);
			this.buttonRecordcReplace.Text = "toolStripButton9";
			this.buttonRecordcReplace.ToolTipText = "Replace Record";
			this.buttonRecordcReplace.Click += new global::System.EventHandler(this.buttonRecordcReplace_Click);
			this.buttonRecordcDelete.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonRecordcDelete.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonRecordcDelete.Image");
			this.buttonRecordcDelete.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonRecordcDelete.Name = "buttonRecordcDelete";
			this.buttonRecordcDelete.Size = new global::System.Drawing.Size(23, 22);
			this.buttonRecordcDelete.Text = "toolStripButton10";
			this.buttonRecordcDelete.ToolTipText = "Delete Record";
			this.buttonRecordcDelete.Click += new global::System.EventHandler(this.buttonRecordcDelete_Click);
			this.buttonRecordcCount.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonRecordcCount.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonRecordcCount.Image");
			this.buttonRecordcCount.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonRecordcCount.Name = "buttonRecordcCount";
			this.buttonRecordcCount.Size = new global::System.Drawing.Size(23, 22);
			this.buttonRecordcCount.Text = "toolStripButton11";
			this.buttonRecordcCount.ToolTipText = "Count Records";
			this.buttonRecordcCount.Click += new global::System.EventHandler(this.buttonRecordcCount_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new global::System.Drawing.Size(6, 25);
			this.buttonFindExactly.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonFindExactly.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonFindExactly.Image");
			this.buttonFindExactly.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonFindExactly.Name = "buttonFindExactly";
			this.buttonFindExactly.Size = new global::System.Drawing.Size(23, 22);
			this.buttonFindExactly.Text = "Find Exactly";
			this.buttonFindExactly.Click += new global::System.EventHandler(this.buttonFindExactly_Click);
			this.buttonFind.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonFind.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonFind.Image");
			this.buttonFind.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonFind.Name = "buttonFind";
			this.buttonFind.Size = new global::System.Drawing.Size(23, 22);
			this.buttonFind.Text = "Find";
			this.buttonFind.Click += new global::System.EventHandler(this.toolStripButton1_Click);
			this.textSearch.Name = "textSearch";
			this.textSearch.Size = new global::System.Drawing.Size(200, 25);
			this.textSearch.ToolTipText = "Type in the text to search";
			this.textSearch.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.textSearch_KeyDown);
			this.contextMenuCell.Name = "contextMenuCell";
			this.contextMenuCell.Size = new global::System.Drawing.Size(61, 4);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("$this.BackgroundImage");
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(985, 581);
			base.Controls.Add(this.splitContainer1);
			base.Controls.Add(this.toolStrip);
			base.Controls.Add(this.statusStrip);
			base.Controls.Add(this.mainMenu);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MainMenuStrip = this.mainMenu;
			base.Name = "DbMaster";
			this.Text = "DB Master";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.DbMaster_FormClosing);
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.panelTop.ResumeLayout(false);
			this.panelTop.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericMax).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericMin).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView).EndInit();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000099 RID: 153
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400009A RID: 154
		private global::System.Windows.Forms.MenuStrip mainMenu;

		// Token: 0x0400009B RID: 155
		private global::System.Windows.Forms.StatusStrip statusStrip;

		// Token: 0x0400009C RID: 156
		private global::System.Windows.Forms.ToolStripProgressBar progressBar;

		// Token: 0x0400009D RID: 157
		private global::System.Windows.Forms.ToolStripStatusLabel statusLabel;

		// Token: 0x0400009E RID: 158
		private global::System.Windows.Forms.ToolStripMenuItem menuFile;

		// Token: 0x0400009F RID: 159
		private global::System.Windows.Forms.ToolStripMenuItem menuOpen;

		// Token: 0x040000A0 RID: 160
		private global::System.Windows.Forms.ToolStripMenuItem menuSave;

		// Token: 0x040000A1 RID: 161
		private global::System.Windows.Forms.ToolStripMenuItem menuClose;

		// Token: 0x040000A2 RID: 162
		private global::System.Windows.Forms.ToolStripMenuItem menuExit;

		// Token: 0x040000A3 RID: 163
		private global::System.Windows.Forms.ToolStripMenuItem menuTable;

		// Token: 0x040000A4 RID: 164
		private global::System.Windows.Forms.ToolStripMenuItem menuExportCsv;

		// Token: 0x040000A5 RID: 165
		private global::System.Windows.Forms.ToolStripMenuItem menuImportCsv;

		// Token: 0x040000A6 RID: 166
		private global::System.Windows.Forms.ToolStripMenuItem menuExportAll;

		// Token: 0x040000A7 RID: 167
		private global::System.Windows.Forms.ToolStripMenuItem menuImportAll;

		// Token: 0x040000A8 RID: 168
		private global::System.Windows.Forms.ToolStripMenuItem menuRecord;

		// Token: 0x040000A9 RID: 169
		private global::System.Windows.Forms.ToolStripMenuItem menuCopy;

		// Token: 0x040000AA RID: 170
		private global::System.Windows.Forms.ToolStripMenuItem menuPaste;

		// Token: 0x040000AB RID: 171
		private global::System.Windows.Forms.ToolStripMenuItem menuReplace;

		// Token: 0x040000AC RID: 172
		private global::System.Windows.Forms.ToolStripMenuItem menuDelete;

		// Token: 0x040000AD RID: 173
		private global::System.Windows.Forms.ToolStripMenuItem menuCount;

		// Token: 0x040000AE RID: 174
		private global::System.Windows.Forms.ToolStripMenuItem menuTools;

		// Token: 0x040000AF RID: 175
		private global::System.Windows.Forms.ToolStripMenuItem menuLoadIntelli;

		// Token: 0x040000B0 RID: 176
		private global::System.Windows.Forms.ToolStripMenuItem menuHelp;

		// Token: 0x040000B1 RID: 177
		private global::System.Windows.Forms.ToolStripMenuItem menuHelpFile;

		// Token: 0x040000B2 RID: 178
		private global::System.Windows.Forms.ToolStripMenuItem menuAbout;

		// Token: 0x040000B3 RID: 179
		private global::System.Windows.Forms.Panel panelTop;

		// Token: 0x040000B4 RID: 180
		private global::System.Windows.Forms.ListBox listBoxTables;

		// Token: 0x040000B5 RID: 181
		private global::System.Windows.Forms.DataGridView dataGridView;

		// Token: 0x040000B6 RID: 182
		private global::System.Windows.Forms.Label labelMax;

		// Token: 0x040000B7 RID: 183
		private global::System.Windows.Forms.NumericUpDown numericMax;

		// Token: 0x040000B8 RID: 184
		private global::System.Windows.Forms.Label labelMin;

		// Token: 0x040000B9 RID: 185
		private global::System.Windows.Forms.NumericUpDown numericMin;

		// Token: 0x040000BA RID: 186
		private global::System.Windows.Forms.ComboBox comboIntelli;

		// Token: 0x040000BB RID: 187
		private global::System.Windows.Forms.ComboBox comboSearch;

		// Token: 0x040000BC RID: 188
		private global::System.Windows.Forms.ToolStrip toolStrip;

		// Token: 0x040000BD RID: 189
		private global::System.Windows.Forms.ToolStripTextBox textSearch;

		// Token: 0x040000BE RID: 190
		private global::System.Windows.Forms.ToolStripButton buttonFindExactly;

		// Token: 0x040000BF RID: 191
		private global::System.Windows.Forms.ToolStripButton buttonFind;

		// Token: 0x040000C0 RID: 192
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x040000C1 RID: 193
		private global::System.Windows.Forms.TextBox textType;

		// Token: 0x040000C2 RID: 194
		private global::System.Windows.Forms.ToolStripButton buttonExportSingle;

		// Token: 0x040000C3 RID: 195
		private global::System.Windows.Forms.ToolStripButton buttonExportMulti;

		// Token: 0x040000C4 RID: 196
		private global::System.Windows.Forms.ToolStripButton buttonImportSingle;

		// Token: 0x040000C5 RID: 197
		private global::System.Windows.Forms.ToolStripButton buttonImportMulti;

		// Token: 0x040000C6 RID: 198
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x040000C7 RID: 199
		private global::System.Windows.Forms.ToolStripButton buttonRecordCopy;

		// Token: 0x040000C8 RID: 200
		private global::System.Windows.Forms.ToolStripButton buttonRecordcInsert;

		// Token: 0x040000C9 RID: 201
		private global::System.Windows.Forms.ToolStripButton buttonRecordcReplace;

		// Token: 0x040000CA RID: 202
		private global::System.Windows.Forms.ToolStripButton buttonRecordcDelete;

		// Token: 0x040000CB RID: 203
		private global::System.Windows.Forms.ToolStripButton buttonRecordcCount;

		// Token: 0x040000CC RID: 204
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		// Token: 0x040000CD RID: 205
		private global::System.Windows.Forms.ToolStripButton buttonOpen;

		// Token: 0x040000CE RID: 206
		private global::System.Windows.Forms.ToolStripButton buttonSave;

		// Token: 0x040000CF RID: 207
		private global::System.Windows.Forms.ToolStripButton buttonClose;

		// Token: 0x040000D0 RID: 208
		private global::System.Windows.Forms.ToolStripMenuItem menuEnableAllMessages;

		// Token: 0x040000D1 RID: 209
		private global::System.Windows.Forms.OpenFileDialog openFileDialog;

		// Token: 0x040000D2 RID: 210
		private global::System.Windows.Forms.DateTimePicker dateIntelli;

		// Token: 0x040000D3 RID: 211
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x040000D4 RID: 212
		private global::System.Windows.Forms.SaveFileDialog saveFileDialog;

		// Token: 0x040000D5 RID: 213
		private global::System.Windows.Forms.FolderBrowserDialog folderBrowser;

		// Token: 0x040000D6 RID: 214
		private global::System.Windows.Forms.ContextMenuStrip contextMenuCell;

		// Token: 0x040000D7 RID: 215
		private global::System.Windows.Forms.ToolStripMenuItem menuFind;

		// Token: 0x040000D8 RID: 216
		private global::System.Windows.Forms.ToolStripMenuItem menuSort;

		// Token: 0x040000D9 RID: 217
		private global::System.Windows.Forms.ToolStripMenuItem findExactlyToolStripMenuItem;

		// Token: 0x040000DA RID: 218
		private global::System.Windows.Forms.ToolStripButton buttonIntelliEdit;

		// Token: 0x040000DB RID: 219
		private global::System.Windows.Forms.ToolStripMenuItem expandFifadbToolStripMenuItem;

		// Token: 0x040000DC RID: 220
		private global::System.Windows.Forms.ToolStripMenuItem diagnosticToolStripMenuItem;

		// Token: 0x040000DD RID: 221
		private global::System.Windows.Forms.ToolStripMenuItem extractFromBigToolStripMenuItem;

		// Token: 0x040000DE RID: 222
		private global::System.Windows.Forms.ToolStripMenuItem mainDatabaseToolStripMenuItem;

		// Token: 0x040000DF RID: 223
		private global::System.Windows.Forms.ToolStripMenuItem localDatabasesToolStripMenuItem;

		// Token: 0x040000E0 RID: 224
		private global::System.Windows.Forms.Button buttonComputeHash;

		// Token: 0x040000E1 RID: 225
		private global::System.Windows.Forms.ToolStripMenuItem calculateHashidToolStripMenuItem;
	}
}
