using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using FifaLibrary;

namespace FifaControls
{
	// Token: 0x02000023 RID: 35
	public class MultiViewer2D : UserControl
	{
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00010339 File Offset: 0x0000E539
		// (set) Token: 0x06000157 RID: 343 RVA: 0x00010341 File Offset: 0x0000E541
		[Description("Auto Transparency.")]
		[Category("User")]
		public bool AutoTransparency
		{
			get
			{
				return this.m_AutoTransparency;
			}
			set
			{
				this.m_AutoTransparency = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000158 RID: 344 RVA: 0x0001034A File Offset: 0x0000E54A
		// (set) Token: 0x06000159 RID: 345 RVA: 0x00010352 File Offset: 0x0000E552
		[Category("User")]
		[Description("Check for bitmap size.")]
		public bool CheckBitmapSize
		{
			get
			{
				return this.m_CheckBitmapSize;
			}
			set
			{
				this.m_CheckBitmapSize = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600015A RID: 346 RVA: 0x0001035B File Offset: 0x0000E55B
		// (set) Token: 0x0600015B RID: 347 RVA: 0x00010368 File Offset: 0x0000E568
		[Category("User")]
		[Description("Label text.")]
		public string LabelText
		{
			get
			{
				return this.label.Text;
			}
			set
			{
				this.label.Text = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00010376 File Offset: 0x0000E576
		// (set) Token: 0x0600015D RID: 349 RVA: 0x00010383 File Offset: 0x0000E583
		[Description("Show Delete Button.")]
		[Category("User")]
		public bool ShowDeleteButton
		{
			get
			{
				return this.buttonRemoveRx3.Visible;
			}
			set
			{
				this.buttonRemoveRx3.Visible = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00010391 File Offset: 0x0000E591
		// (set) Token: 0x0600015F RID: 351 RVA: 0x0001039E File Offset: 0x0000E59E
		[Category("User")]
		[Description("Full Size Button Visible.")]
		public bool FullSizeButton
		{
			get
			{
				return this.buttonFullSize.Visible;
			}
			set
			{
				this.buttonFullSize.Visible = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000160 RID: 352 RVA: 0x000103AC File Offset: 0x0000E5AC
		// (set) Token: 0x06000161 RID: 353 RVA: 0x000103B4 File Offset: 0x0000E5B4
		[Description("Fixed size.")]
		[Category("User")]
		public bool FixedSize
		{
			get
			{
				return this.m_FixedSize;
			}
			set
			{
				this.m_FixedSize = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000162 RID: 354 RVA: 0x000103BD File Offset: 0x0000E5BD
		// (set) Token: 0x06000163 RID: 355 RVA: 0x000103C8 File Offset: 0x0000E5C8
		[Description("Bitmaps.")]
		[Category("User")]
		public Bitmap[] Bitmaps
		{
			get
			{
				return this.m_Bitmaps;
			}
			set
			{
				this.m_Bitmaps = value;
				if (this.m_Bitmaps != null)
				{
					this.numeric.Maximum = this.m_Bitmaps.Length;
					this.labelOf.Text = "/" + this.m_Bitmaps.Length.ToString();
					if (this.m_CurrentIndex >= this.m_Bitmaps.Length)
					{
						this.m_CurrentIndex = 0;
					}
					else
					{
						this.numeric_ValueChanged(null, null);
					}
				}
				else
				{
					this.m_CurrentIndex = 0;
					this.numeric_ValueChanged(null, null);
				}
				this.m_NeedToSave = false;
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0001045A File Offset: 0x0000E65A
		public Bitmap GetCurrentBitmap()
		{
			if (this.m_Bitmaps != null && this.m_CurrentIndex < this.m_Bitmaps.Length)
			{
				return this.m_Bitmaps[this.m_CurrentIndex];
			}
			return null;
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00010483 File Offset: 0x0000E683
		// (set) Token: 0x06000166 RID: 358 RVA: 0x0001048B File Offset: 0x0000E68B
		private string InitialDirectory
		{
			get
			{
				return this.m_InitialDirectory;
			}
			set
			{
				this.folderBrowserDialog.SelectedPath = value;
				this.openFileDialogBmp.InitialDirectory = value;
				this.openFileDialogRx3.InitialDirectory = value;
				this.saveFileDialogBmp.InitialDirectory = value;
				this.m_InitialDirectory = value;
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000104C4 File Offset: 0x0000E6C4
		public MultiViewer2D()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000104E0 File Offset: 0x0000E6E0
		private void numeric_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentIndex = (int)this.numeric.Value - 1;
			this.AdjustImageLayout();
			if (this.m_Bitmaps != null && this.m_Bitmaps[this.m_CurrentIndex] != null)
			{
				this.pictureBox.BackgroundImage = this.m_Bitmaps[this.m_CurrentIndex];
				this.textSize.Text = this.m_Bitmaps[this.m_CurrentIndex].Width + " x " + this.m_Bitmaps[this.m_CurrentIndex].Height;
				return;
			}
			this.pictureBox.BackgroundImage = null;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0001058A File Offset: 0x0000E78A
		private void buttonImportImage_Click(object sender, EventArgs e)
		{
			this.ImportImage();
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00010594 File Offset: 0x0000E794
		private void ImportImage()
		{
			Bitmap bitmap = this.BrowseAndCheckBitmap();
			this.Refresh();
			if (bitmap == null)
			{
				return;
			}
			this.pictureBox.BackgroundImage = bitmap;
			this.m_NeedToSave = true;
			this.buttonSave.Enabled = true;
			if (this.m_Bitmaps == null)
			{
				this.m_Bitmaps = new Bitmap[(int)this.numeric.Maximum];
			}
			this.m_Bitmaps[this.m_CurrentIndex] = bitmap;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00010604 File Offset: 0x0000E804
		private Bitmap BrowseAndCheckBitmap()
		{
			this.openFileDialogBmp.CheckFileExists = true;
			this.openFileDialogBmp.Multiselect = false;
			this.openFileDialogBmp.InitialDirectory = this.m_InitialDirectory;
			this.openFileDialogBmp.RestoreDirectory = true;
			this.openFileDialogBmp.Filter = "Image Files (*.bmp;*.png)|*.bmp;*.png";
			this.openFileDialogBmp.FilterIndex = 1;
			this.openFileDialogBmp.Title = "Open Image File";
			if (this.openFileDialogBmp.ShowDialog() != DialogResult.OK)
			{
				return null;
			}
			string fileName = this.openFileDialogBmp.FileName;
			this.InitialDirectory = Path.GetDirectoryName(fileName);
			Bitmap bitmap = new Bitmap(fileName);
			if (bitmap == null)
			{
				return null;
			}
			Cursor.Current = Cursors.WaitCursor;
			base.FindForm().Refresh();
			if (this.m_CheckBitmapSize && this.m_Bitmaps != null && this.m_Bitmaps[this.m_CurrentIndex] != null && this.m_CurrentIndex >= 0 && this.m_CurrentIndex < this.m_Bitmaps.Length)
			{
				int width = this.m_Bitmaps[this.m_CurrentIndex].Width;
				int height = this.m_Bitmaps[this.m_CurrentIndex].Height;
				if ((bitmap.Width != width || bitmap.Height != height) && (bitmap.Width != width || bitmap.Height != height))
				{
					Cursor.Current = Cursors.Default;
					FifaEnvironment.UserMessages.ShowMessage(5015);
					return null;
				}
			}
			if (this.m_AutoTransparency)
			{
				string extension = Path.GetExtension(fileName);
				if (extension.ToLower() == ".bmp")
				{
					Bitmap bitmap2 = new Bitmap(bitmap.Width, bitmap.Height, PixelFormat.Format32bppArgb);
					Color pixel = bitmap.GetPixel(0, 0);
					Color color = Color.FromArgb(0, 0, 0, 0);
					for (int i = 0; i < bitmap.Width; i++)
					{
						for (int j = 0; j < bitmap.Height; j++)
						{
							Color pixel2 = bitmap.GetPixel(i, j);
							if (pixel2 == pixel)
							{
								bitmap2.SetPixel(i, j, color);
							}
							else
							{
								bitmap2.SetPixel(i, j, pixel2);
							}
						}
					}
					Cursor.Current = Cursors.Default;
					return bitmap2;
				}
			}
			Cursor.Current = Cursors.Default;
			return bitmap;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0001082A File Offset: 0x0000EA2A
		private void buttonExportImage_Click(object sender, EventArgs e)
		{
			this.ExportImage();
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00010832 File Offset: 0x0000EA32
		private void ExportImage()
		{
			this.AskAndSaveBitmap((Bitmap)this.pictureBox.BackgroundImage);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0001084C File Offset: 0x0000EA4C
		private bool AskAndSaveBitmap(Bitmap bitmap)
		{
			if (bitmap == null)
			{
				return false;
			}
			this.saveFileDialogBmp.InitialDirectory = this.m_InitialDirectory;
			if (this.saveFileDialogBmp.ShowDialog() != DialogResult.OK)
			{
				return false;
			}
			string extension = Path.GetExtension(this.saveFileDialogBmp.FileName);
			this.InitialDirectory = Path.GetDirectoryName(this.saveFileDialogBmp.FileName);
			ImageFormat imageFormat;
			if (extension.ToLower() == ".bmp")
			{
				imageFormat = ImageFormat.Bmp;
				Color pixel = bitmap.GetPixel(0, 0);
				for (int i = bitmap.Width - 1; i >= 0; i--)
				{
					for (int j = bitmap.Height - 1; j >= 0; j--)
					{
						if (bitmap.GetPixel(i, j).A < 192)
						{
							bitmap.SetPixel(i, j, pixel);
						}
					}
				}
			}
			else
			{
				if (!(extension.ToLower() == ".png"))
				{
					return false;
				}
				imageFormat = ImageFormat.Png;
			}
			bitmap.Save(this.saveFileDialogBmp.FileName, imageFormat);
			return true;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00010945 File Offset: 0x0000EB45
		private void buttonImportFsh_Click(object sender, EventArgs e)
		{
			this.ImportRx3();
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00010950 File Offset: 0x0000EB50
		private void ImportRx3()
		{
			string text = this.BrowseRx3();
			if (text == null)
			{
				return;
			}
			if (this.Rx3ImportDelegate != null)
			{
				this.Rx3ImportDelegate(this, text);
			}
			this.m_NeedToSave = false;
			this.buttonSave.Enabled = false;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00010994 File Offset: 0x0000EB94
		private string BrowseRx3()
		{
			this.openFileDialogRx3.InitialDirectory = this.m_InitialDirectory;
			if (this.openFileDialogRx3.ShowDialog() != DialogResult.OK)
			{
				return null;
			}
			string fileName = this.openFileDialogRx3.FileName;
			this.InitialDirectory = Path.GetDirectoryName(fileName);
			return fileName;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x000109DC File Offset: 0x0000EBDC
		private string BrowseExportingFolder()
		{
			this.folderBrowserDialog.Description = "Select the export folder";
			this.folderBrowserDialog.ShowNewFolderButton = true;
			if (this.folderBrowserDialog.ShowDialog() != DialogResult.OK)
			{
				this.folderBrowserDialog.Dispose();
				return null;
			}
			return this.folderBrowserDialog.SelectedPath;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00010A2B File Offset: 0x0000EC2B
		private void buttonExportRx3_Click(object sender, EventArgs e)
		{
			this.ExportRx3File();
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00010A34 File Offset: 0x0000EC34
		private void ExportRx3File()
		{
			string text = this.BrowseExportingFolder();
			if (text == null)
			{
				return;
			}
			if (this.Rx3ExportDelegate != null)
			{
				this.Rx3ExportDelegate(this, text);
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00010A64 File Offset: 0x0000EC64
		private void buttonSave_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			if (this.Rx3SaveDelegate != null)
			{
				this.Rx3SaveDelegate(sender, this.m_Bitmaps);
			}
			this.m_NeedToSave = false;
			this.buttonSave.Enabled = false;
			Cursor.Current = Cursors.Default;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00010AB3 File Offset: 0x0000ECB3
		private void MultiViewer2D_Resize(object sender, EventArgs e)
		{
			this.AdjustImageLayout();
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00010ABC File Offset: 0x0000ECBC
		private void AdjustImageLayout()
		{
			int num = 128;
			int num2 = 128;
			if (this.m_Bitmaps != null && this.m_Bitmaps[this.m_CurrentIndex] != null)
			{
				num = this.m_Bitmaps[this.m_CurrentIndex].Width;
				num2 = this.m_Bitmaps[this.m_CurrentIndex].Height;
			}
			if (base.Width < num || base.Height < num2)
			{
				this.pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
				return;
			}
			this.pictureBox.BackgroundImageLayout = ImageLayout.Center;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00010B3D File Offset: 0x0000ED3D
		private void buttonFullSize_Click(object sender, EventArgs e)
		{
			if (this.m_Bitmaps[this.m_CurrentIndex] != null)
			{
				MultiViewer2D.s_FullSizeViewer.SetImage(this.m_Bitmaps[this.m_CurrentIndex]);
				MultiViewer2D.s_FullSizeViewer.ShowDialog();
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00010B70 File Offset: 0x0000ED70
		private void buttonRemoveRx3_Click(object sender, EventArgs e)
		{
			this.m_Bitmaps = null;
			this.pictureBox.BackgroundImage = null;
			this.m_CurrentIndex = 0;
			this.numeric.Value = 1m;
			if (this.Rx3DeleteDelegate != null)
			{
				this.Rx3DeleteDelegate(this);
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00010BBD File Offset: 0x0000EDBD
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00010BDC File Offset: 0x0000EDDC
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MultiViewer2D));
			this.label = new Label();
			this.numeric = new NumericUpDown();
			this.toolStrip = new ToolStrip();
			this.buttonImportImage = new ToolStripButton();
			this.buttonExportImage = new ToolStripButton();
			this.buttonFullSize = new ToolStripButton();
			this.buttonImportRx3 = new ToolStripButton();
			this.buttonExportRx3 = new ToolStripButton();
			this.buttonRemoveRx3 = new ToolStripButton();
			this.buttonSave = new ToolStripButton();
			this.textSize = new ToolStripTextBox();
			this.pictureBox = new PictureBox();
			this.folderBrowserDialog = new FolderBrowserDialog();
			this.openFileDialogBmp = new OpenFileDialog();
			this.openFileDialogRx3 = new OpenFileDialog();
			this.saveFileDialogBmp = new SaveFileDialog();
			this.labelOf = new Label();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.toolStripSeparator2 = new ToolStripSeparator();
			((ISupportInitialize)this.numeric).BeginInit();
			this.toolStrip.SuspendLayout();
			((ISupportInitialize)this.pictureBox).BeginInit();
			base.SuspendLayout();
			this.label.Dock = DockStyle.Top;
			this.label.Location = new Point(0, 0);
			this.label.Name = "label";
			this.label.Size = new Size(257, 20);
			this.label.TabIndex = 0;
			this.label.Text = "Image n.";
			this.label.TextAlign = ContentAlignment.MiddleLeft;
			this.numeric.Location = new Point(49, 0);
			NumericUpDown numericUpDown = this.numeric;
			int[] array = new int[4];
			array[0] = 1;
			numericUpDown.Maximum = new decimal(array);
			NumericUpDown numericUpDown2 = this.numeric;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Minimum = new decimal(array2);
			this.numeric.Name = "numeric";
			this.numeric.Size = new Size(54, 20);
			this.numeric.TabIndex = 1;
			this.numeric.TextAlign = HorizontalAlignment.Center;
			NumericUpDown numericUpDown3 = this.numeric;
			int[] array3 = new int[4];
			array3[0] = 1;
			numericUpDown3.Value = new decimal(array3);
			this.numeric.ValueChanged += this.numeric_ValueChanged;
			this.toolStrip.Dock = DockStyle.Bottom;
			this.toolStrip.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip.Items.AddRange(new ToolStripItem[] { this.buttonSave, this.buttonImportImage, this.buttonExportImage, this.toolStripSeparator1, this.buttonImportRx3, this.buttonExportRx3, this.buttonRemoveRx3, this.toolStripSeparator2, this.buttonFullSize, this.textSize });
			this.toolStrip.Location = new Point(0, 248);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new Size(257, 25);
			this.toolStrip.TabIndex = 2;
			this.buttonImportImage.AutoSize = false;
			this.buttonImportImage.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonImportImage.Image = (Image)componentResourceManager.GetObject("buttonImportImage.Image");
			this.buttonImportImage.ImageTransparentColor = Color.Magenta;
			this.buttonImportImage.Name = "buttonImportImage";
			this.buttonImportImage.Size = new Size(20, 22);
			this.buttonImportImage.Text = "Import Image";
			this.buttonImportImage.Click += this.buttonImportImage_Click;
			this.buttonExportImage.AutoSize = false;
			this.buttonExportImage.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonExportImage.Image = (Image)componentResourceManager.GetObject("buttonExportImage.Image");
			this.buttonExportImage.ImageTransparentColor = Color.Magenta;
			this.buttonExportImage.Name = "buttonExportImage";
			this.buttonExportImage.Size = new Size(20, 22);
			this.buttonExportImage.Text = "Export Image";
			this.buttonExportImage.Click += this.buttonExportImage_Click;
			this.buttonFullSize.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonFullSize.Image = (Image)componentResourceManager.GetObject("buttonFullSize.Image");
			this.buttonFullSize.ImageTransparentColor = Color.Magenta;
			this.buttonFullSize.Name = "buttonFullSize";
			this.buttonFullSize.Size = new Size(23, 22);
			this.buttonFullSize.Text = "View Full Size";
			this.buttonFullSize.Visible = false;
			this.buttonFullSize.Click += this.buttonFullSize_Click;
			this.buttonImportRx3.AutoSize = false;
			this.buttonImportRx3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonImportRx3.Image = (Image)componentResourceManager.GetObject("buttonImportRx3.Image");
			this.buttonImportRx3.ImageTransparentColor = Color.Magenta;
			this.buttonImportRx3.Name = "buttonImportRx3";
			this.buttonImportRx3.Size = new Size(20, 22);
			this.buttonImportRx3.Text = "Import Rx3";
			this.buttonImportRx3.Click += this.buttonImportFsh_Click;
			this.buttonExportRx3.AutoSize = false;
			this.buttonExportRx3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonExportRx3.Image = (Image)componentResourceManager.GetObject("buttonExportRx3.Image");
			this.buttonExportRx3.ImageTransparentColor = Color.Magenta;
			this.buttonExportRx3.Name = "buttonExportRx3";
			this.buttonExportRx3.Size = new Size(20, 22);
			this.buttonExportRx3.Text = "Export as Rx3";
			this.buttonExportRx3.Click += this.buttonExportRx3_Click;
			this.buttonRemoveRx3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonRemoveRx3.Image = (Image)componentResourceManager.GetObject("buttonRemoveRx3.Image");
			this.buttonRemoveRx3.ImageTransparentColor = Color.Magenta;
			this.buttonRemoveRx3.Name = "buttonRemoveRx3";
			this.buttonRemoveRx3.Size = new Size(23, 22);
			this.buttonRemoveRx3.Text = "Remove";
			this.buttonRemoveRx3.Click += this.buttonRemoveRx3_Click;
			this.buttonSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonSave.Enabled = false;
			this.buttonSave.Image = (Image)componentResourceManager.GetObject("buttonSave.Image");
			this.buttonSave.ImageTransparentColor = Color.Magenta;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new Size(23, 22);
			this.buttonSave.Text = "Save";
			this.buttonSave.Click += this.buttonSave_Click;
			this.textSize.BackColor = Color.White;
			this.textSize.Name = "textSize";
			this.textSize.ReadOnly = true;
			this.textSize.Size = new Size(70, 25);
			this.textSize.Text = "1024 x 1024";
			this.textSize.TextBoxTextAlign = HorizontalAlignment.Center;
			this.pictureBox.BackgroundImageLayout = ImageLayout.Center;
			this.pictureBox.BorderStyle = BorderStyle.FixedSingle;
			this.pictureBox.Dock = DockStyle.Fill;
			this.pictureBox.Location = new Point(0, 20);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new Size(257, 228);
			this.pictureBox.TabIndex = 3;
			this.pictureBox.TabStop = false;
			this.openFileDialogBmp.Filter = "Image Files (*.bmp;*.png)|*.bmp;*.png";
			this.openFileDialogBmp.Title = "Open Image File";
			this.openFileDialogRx3.Filter = "rx3 files (*.rx3)|*.rx3";
			this.openFileDialogRx3.Title = "Open rx3 file";
			this.saveFileDialogBmp.Filter = "bmp files (*.bmp)|*.bmp|png files (*.png)|*.png";
			this.saveFileDialogBmp.FilterIndex = 2;
			this.saveFileDialogBmp.Title = "Save image as .bmp or .png";
			this.labelOf.AutoSize = true;
			this.labelOf.Location = new Point(107, 4);
			this.labelOf.Name = "labelOf";
			this.labelOf.Size = new Size(19, 13);
			this.labelOf.TabIndex = 4;
			this.labelOf.Text = "of ";
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(6, 25);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new Size(6, 25);
			base.Controls.Add(this.labelOf);
			base.Controls.Add(this.pictureBox);
			base.Controls.Add(this.toolStrip);
			base.Controls.Add(this.numeric);
			base.Controls.Add(this.label);
			base.Name = "MultiViewer2D";
			base.Size = new Size(257, 273);
			base.Resize += this.MultiViewer2D_Resize;
			((ISupportInitialize)this.numeric).EndInit();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			((ISupportInitialize)this.pictureBox).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400016E RID: 366
		private static FullSizeViewer s_FullSizeViewer = new FullSizeViewer();

		// Token: 0x0400016F RID: 367
		private bool m_AutoTransparency;

		// Token: 0x04000170 RID: 368
		private bool m_CheckBitmapSize;

		// Token: 0x04000171 RID: 369
		private bool m_FixedSize;

		// Token: 0x04000172 RID: 370
		public MultiViewer2D.Rx3SaveHandler Rx3SaveDelegate;

		// Token: 0x04000173 RID: 371
		public MultiViewer2D.Rx3ExportHandler Rx3ExportDelegate;

		// Token: 0x04000174 RID: 372
		public MultiViewer2D.Rx3ImportHandler Rx3ImportDelegate;

		// Token: 0x04000175 RID: 373
		public MultiViewer2D.Rx3DeleteHandler Rx3DeleteDelegate;

		// Token: 0x04000176 RID: 374
		private int m_CurrentIndex;

		// Token: 0x04000177 RID: 375
		private Bitmap[] m_Bitmaps;

		// Token: 0x04000178 RID: 376
		private bool m_NeedToSave;

		// Token: 0x04000179 RID: 377
		private string m_InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

		// Token: 0x0400017A RID: 378
		private IContainer components;

		// Token: 0x0400017B RID: 379
		private Label label;

		// Token: 0x0400017C RID: 380
		private NumericUpDown numeric;

		// Token: 0x0400017D RID: 381
		private ToolStrip toolStrip;

		// Token: 0x0400017E RID: 382
		public ToolStripButton buttonImportImage;

		// Token: 0x0400017F RID: 383
		public ToolStripButton buttonExportImage;

		// Token: 0x04000180 RID: 384
		public ToolStripButton buttonImportRx3;

		// Token: 0x04000181 RID: 385
		public ToolStripButton buttonExportRx3;

		// Token: 0x04000182 RID: 386
		private ToolStripTextBox textSize;

		// Token: 0x04000183 RID: 387
		public PictureBox pictureBox;

		// Token: 0x04000184 RID: 388
		public ToolStripButton buttonSave;

		// Token: 0x04000185 RID: 389
		private FolderBrowserDialog folderBrowserDialog;

		// Token: 0x04000186 RID: 390
		private OpenFileDialog openFileDialogBmp;

		// Token: 0x04000187 RID: 391
		private OpenFileDialog openFileDialogRx3;

		// Token: 0x04000188 RID: 392
		private SaveFileDialog saveFileDialogBmp;

		// Token: 0x04000189 RID: 393
		private Label labelOf;

		// Token: 0x0400018A RID: 394
		private ToolStripButton buttonRemoveRx3;

		// Token: 0x0400018B RID: 395
		public ToolStripButton buttonFullSize;

		// Token: 0x0400018C RID: 396
		private ToolStripSeparator toolStripSeparator1;

		// Token: 0x0400018D RID: 397
		private ToolStripSeparator toolStripSeparator2;

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x0600017E RID: 382
		public delegate bool Rx3SaveHandler(object sender, Bitmap[] bitmaps);

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x06000182 RID: 386
		public delegate bool Rx3ImportHandler(object sender, string rx3FileName);

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x06000186 RID: 390
		public delegate bool Rx3ExportHandler(object sender, string exportDir);

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x0600018A RID: 394
		public delegate bool Rx3DeleteHandler(object sender);
	}
}
