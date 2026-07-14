using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using FifaLibrary;

namespace FifaControls
{
	// Token: 0x0200000F RID: 15
	public class Viewer2D : UserControl
	{
		// Token: 0x0600008C RID: 140 RVA: 0x0000AE7B File Offset: 0x0000907B
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000AE9C File Offset: 0x0000909C
		private void InitializeComponent()
		{
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Viewer2D));
			this.picture = new PictureBox();
			this.contextMenuStrip = new ContextMenuStrip(this.components);
			this.importImageToolStripMenuItem = new ToolStripMenuItem();
			this.exportImageToolStripMenuItem = new ToolStripMenuItem();
			this.removeToolStripMenuItem = new ToolStripMenuItem();
			this.toolStrip = new ToolStrip();
			this.buttonShow = new ToolStripButton();
			this.buttonImportImage = new ToolStripButton();
			this.buttonExportImage = new ToolStripButton();
			this.buttonFullSize = new ToolStripButton();
			this.buttonRemove = new ToolStripButton();
			this.textSize = new ToolStripTextBox();
			this.openFileDialog = new OpenFileDialog();
			((ISupportInitialize)this.picture).BeginInit();
			this.contextMenuStrip.SuspendLayout();
			this.toolStrip.SuspendLayout();
			base.SuspendLayout();
			this.picture.BackColor = SystemColors.Control;
			this.picture.BackgroundImageLayout = ImageLayout.None;
			this.picture.BorderStyle = BorderStyle.FixedSingle;
			this.picture.ContextMenuStrip = this.contextMenuStrip;
			this.picture.Dock = DockStyle.Fill;
			this.picture.Location = new Point(0, 0);
			this.picture.Name = "picture";
			this.picture.Size = new Size(197, 187);
			this.picture.TabIndex = 0;
			this.picture.TabStop = false;
			this.contextMenuStrip.Items.AddRange(new ToolStripItem[] { this.importImageToolStripMenuItem, this.exportImageToolStripMenuItem, this.removeToolStripMenuItem });
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new Size(147, 70);
			this.importImageToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("importImageToolStripMenuItem.Image");
			this.importImageToolStripMenuItem.ImageTransparentColor = Color.Fuchsia;
			this.importImageToolStripMenuItem.Name = "importImageToolStripMenuItem";
			this.importImageToolStripMenuItem.Size = new Size(146, 22);
			this.importImageToolStripMenuItem.Text = "Import Image";
			this.importImageToolStripMenuItem.Click += this.buttonImportImage_Click;
			this.exportImageToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("exportImageToolStripMenuItem.Image");
			this.exportImageToolStripMenuItem.ImageTransparentColor = Color.Fuchsia;
			this.exportImageToolStripMenuItem.Name = "exportImageToolStripMenuItem";
			this.exportImageToolStripMenuItem.Size = new Size(146, 22);
			this.exportImageToolStripMenuItem.Text = "Export Image";
			this.exportImageToolStripMenuItem.Click += this.buttonExportImage_Click;
			this.removeToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("removeToolStripMenuItem.Image");
			this.removeToolStripMenuItem.ImageTransparentColor = Color.Fuchsia;
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.Size = new Size(146, 22);
			this.removeToolStripMenuItem.Text = "Remove";
			this.removeToolStripMenuItem.Click += this.buttonRemove_Click;
			this.toolStrip.Dock = DockStyle.Bottom;
			this.toolStrip.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip.Items.AddRange(new ToolStripItem[] { this.buttonShow, this.buttonImportImage, this.buttonExportImage, this.buttonFullSize, this.buttonRemove, this.textSize });
			this.toolStrip.Location = new Point(0, 187);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new Size(197, 25);
			this.toolStrip.TabIndex = 2;
			this.toolStrip.Text = "toolStrip1";
			this.buttonShow.Checked = true;
			this.buttonShow.CheckOnClick = true;
			this.buttonShow.CheckState = CheckState.Checked;
			this.buttonShow.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonShow.Image = (Image)componentResourceManager.GetObject("buttonShow.Image");
			this.buttonShow.ImageTransparentColor = Color.Magenta;
			this.buttonShow.Name = "buttonShow";
			this.buttonShow.Size = new Size(23, 22);
			this.buttonShow.Text = "Show / Hide";
			this.buttonShow.Click += this.buttonShow_Click;
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
			this.buttonRemove.AutoSize = false;
			this.buttonRemove.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonRemove.Image = (Image)componentResourceManager.GetObject("buttonRemove.Image");
			this.buttonRemove.ImageTransparentColor = Color.Magenta;
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.Size = new Size(20, 22);
			this.buttonRemove.Text = "Remove";
			this.buttonRemove.Visible = false;
			this.buttonRemove.Click += this.buttonRemove_Click;
			this.textSize.BackColor = Color.White;
			this.textSize.Name = "textSize";
			this.textSize.ReadOnly = true;
			this.textSize.Size = new Size(65, 25);
			this.textSize.Text = "1024 x 1024";
			this.textSize.TextBoxTextAlign = HorizontalAlignment.Center;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Transparent;
			base.Controls.Add(this.picture);
			base.Controls.Add(this.toolStrip);
			base.Name = "Viewer2D";
			base.Size = new Size(197, 212);
			((ISupportInitialize)this.picture).EndInit();
			this.contextMenuStrip.ResumeLayout(false);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0000B687 File Offset: 0x00009887
		// (set) Token: 0x0600008F RID: 143 RVA: 0x0000B68F File Offset: 0x0000988F
		[Category("User")]
		[Description("Image Size.")]
		public Size ImageSize
		{
			get
			{
				return this.m_ImageSize;
			}
			set
			{
				this.m_ImageSize = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000090 RID: 144 RVA: 0x0000B698 File Offset: 0x00009898
		// (set) Token: 0x06000091 RID: 145 RVA: 0x0000B6A0 File Offset: 0x000098A0
		[Description("Image Alternative Size Multiplier.")]
		[Category("User")]
		public Viewer2D.SizeMultiplier ImageSizeMultiplier
		{
			get
			{
				return this.m_ImageSizeMultiplier;
			}
			set
			{
				this.m_ImageSizeMultiplier = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000B6A9 File Offset: 0x000098A9
		// (set) Token: 0x06000093 RID: 147 RVA: 0x0000B6B1 File Offset: 0x000098B1
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

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000B6BA File Offset: 0x000098BA
		// (set) Token: 0x06000095 RID: 149 RVA: 0x0000B6C7 File Offset: 0x000098C7
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

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0000B6D5 File Offset: 0x000098D5
		// (set) Token: 0x06000097 RID: 151 RVA: 0x0000B6E2 File Offset: 0x000098E2
		[Description("Remove Button Visible.")]
		[Category("User")]
		public bool RemoveButton
		{
			get
			{
				return this.buttonRemove.Visible;
			}
			set
			{
				this.buttonRemove.Visible = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000098 RID: 152 RVA: 0x0000B6F0 File Offset: 0x000098F0
		// (set) Token: 0x06000099 RID: 153 RVA: 0x0000B6FD File Offset: 0x000098FD
		[Description("Show Button Visible.")]
		[Category("User")]
		public bool ShowButton
		{
			get
			{
				return this.buttonShow.Visible;
			}
			set
			{
				this.buttonShow.Visible = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0000B70B File Offset: 0x0000990B
		// (set) Token: 0x0600009B RID: 155 RVA: 0x0000B718 File Offset: 0x00009918
		[Category("User")]
		[Description("Show Button Checked.")]
		public bool ShowButtonChecked
		{
			get
			{
				return this.buttonShow.Checked;
			}
			set
			{
				this.buttonShow.Checked = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600009C RID: 156 RVA: 0x0000B726 File Offset: 0x00009926
		// (set) Token: 0x0600009D RID: 157 RVA: 0x0000B733 File Offset: 0x00009933
		[Category("User")]
		[Description("Button strip visible.")]
		public bool ButtonStripVisible
		{
			get
			{
				return this.toolStrip.Visible;
			}
			set
			{
				this.toolStrip.Visible = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0000B741 File Offset: 0x00009941
		// (set) Token: 0x0600009F RID: 159 RVA: 0x0000B749 File Offset: 0x00009949
		[Category("User")]
		[Description("Extended Format")]
		public bool ExtendedFormat
		{
			get
			{
				return this.m_ExtendedFormat;
			}
			set
			{
				this.m_ExtendedFormat = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0000B752 File Offset: 0x00009952
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x0000B75A File Offset: 0x0000995A
		public Bitmap CurrentBitmap
		{
			get
			{
				return this.m_Bitmap;
			}
			set
			{
				this.m_Bitmap = value;
				if (this.buttonShow.Checked)
				{
					this.picture.BackgroundImage = value;
					this.EnableButtons();
				}
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0000B782 File Offset: 0x00009982
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x0000B78F File Offset: 0x0000998F
		[Category("User")]
		[Description("Image Layout.")]
		public ImageLayout ImageLayout
		{
			get
			{
				return this.picture.BackgroundImageLayout;
			}
			set
			{
				this.picture.BackgroundImageLayout = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x0000B79D File Offset: 0x0000999D
		public string CurrentFolder
		{
			set
			{
				this.m_InitialDirectory = value;
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000B7A6 File Offset: 0x000099A6
		public Viewer2D()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000B7C0 File Offset: 0x000099C0
		private void buttonImportImage_Click(object sender, EventArgs e)
		{
			this.ImportImage();
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000B7C8 File Offset: 0x000099C8
		private void menuImportImage_Click(object sender, EventArgs e)
		{
			this.ImportImage();
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000B7D0 File Offset: 0x000099D0
		private void ImportImage()
		{
			Bitmap bitmap = this.BrowseAndCheckBitmap();
			if (bitmap == null)
			{
				return;
			}
			if (bitmap.PixelFormat != PixelFormat.Format32bppArgb)
			{
				bitmap = GraphicUtil.Get32bitBitmap(bitmap);
			}
			if (this.ImageImport != null && !this.ImageImport(this, bitmap))
			{
				return;
			}
			this.CurrentBitmap = bitmap;
			this.Refresh();
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000B824 File Offset: 0x00009A24
		private Bitmap BrowseAndCheckBitmap()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.CheckFileExists = true;
			openFileDialog.Multiselect = false;
			openFileDialog.InitialDirectory = this.m_InitialDirectory;
			openFileDialog.RestoreDirectory = true;
			if (this.m_ExtendedFormat)
			{
				openFileDialog.Filter = "Image Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";
			}
			else
			{
				openFileDialog.Filter = "Image Files (*.bmp;*.png)|*.bmp;*.png";
			}
			openFileDialog.FilterIndex = 1;
			openFileDialog.Title = "Open Image File";
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				openFileDialog.Dispose();
				return null;
			}
			string fileName = openFileDialog.FileName;
			this.m_InitialDirectory = Path.GetDirectoryName(fileName);
			openFileDialog.Dispose();
			Bitmap bitmap = new Bitmap(fileName);
			if (bitmap == null)
			{
				return null;
			}
			Cursor.Current = Cursors.WaitCursor;
			base.FindForm().Refresh();
			int num = this.m_ImageSize.Width;
			int num2 = this.m_ImageSize.Height;
			if (bitmap.Width != num || bitmap.Height != num2)
			{
				switch (this.m_ImageSizeMultiplier)
				{
				case Viewer2D.SizeMultiplier.OneAndHalf:
					num += num / 2;
					num2 += num2 / 2;
					break;
				case Viewer2D.SizeMultiplier.Double:
					num *= 2;
					num2 *= 2;
					break;
				case Viewer2D.SizeMultiplier.Half:
					num /= 2;
					num2 /= 2;
					break;
				case Viewer2D.SizeMultiplier.Kit:
					if ((bitmap.Width == 512 && bitmap.Height == 512) || (bitmap.Width == 768 && bitmap.Height == 768) || (bitmap.Width == 1024 && bitmap.Height == 1024))
					{
						num = bitmap.Width;
						num2 = bitmap.Height;
					}
					break;
				case Viewer2D.SizeMultiplier.MiniFace:
					num = bitmap.Width;
					num2 = bitmap.Height;
					if (bitmap.PixelFormat == PixelFormat.Format24bppRgb)
					{
						num = 128;
						num2 = 128;
						bitmap = GraphicUtil.MakeAutoTransparent(bitmap);
						bitmap = GraphicUtil.ResizeBitmap(bitmap, 128, 128, InterpolationMode.HighQualityBilinear);
					}
					break;
				}
				if (this.m_ImageSizeMultiplier != Viewer2D.SizeMultiplier.Free && (bitmap.Width != num || bitmap.Height != num2))
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
					bitmap = GraphicUtil.MakeAutoTransparent(bitmap);
				}
			}
			Cursor.Current = Cursors.Default;
			return bitmap;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000BA6E File Offset: 0x00009C6E
		private void buttonRemove_Click(object sender, EventArgs e)
		{
			this.RemoveImage();
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000BA76 File Offset: 0x00009C76
		private void RemoveImage()
		{
			this.picture.BackgroundImage = null;
			this.CurrentBitmap = null;
			if (this.ImageDelete != null)
			{
				this.ImageDelete(this);
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000BAA0 File Offset: 0x00009CA0
		private void buttonExportImage_Click(object sender, EventArgs e)
		{
			this.ExportImage();
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000BAA8 File Offset: 0x00009CA8
		private void ExportImage()
		{
			this.AskAndSaveBitmap(this.m_Bitmap);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000BAB8 File Offset: 0x00009CB8
		private bool AskAndSaveBitmap(Bitmap bitmap)
		{
			if (bitmap == null)
			{
				return false;
			}
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "bmp files (*.bmp)|*.bmp|png files (*.png)|*.png";
			saveFileDialog.InitialDirectory = this.m_InitialDirectory;
			saveFileDialog.FilterIndex = 2;
			saveFileDialog.Title = "Save picture as .bmp or .png";
			if (saveFileDialog.ShowDialog() != DialogResult.OK)
			{
				saveFileDialog.Dispose();
				return false;
			}
			Cursor.Current = Cursors.WaitCursor;
			base.FindForm().Refresh();
			string extension = Path.GetExtension(saveFileDialog.FileName);
			this.m_InitialDirectory = Path.GetDirectoryName(saveFileDialog.FileName);
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
					Cursor.Current = Cursors.Default;
					return false;
				}
				imageFormat = ImageFormat.Png;
			}
			string fileName = saveFileDialog.FileName;
			bitmap.Save(saveFileDialog.FileName, imageFormat);
			saveFileDialog.Dispose();
			Cursor.Current = Cursors.Default;
			return true;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000BBFD File Offset: 0x00009DFD
		public void DisposeBitmap()
		{
			if (this.picture.BackgroundImage != null)
			{
				this.picture.BackgroundImage.Dispose();
				this.picture.BackgroundImage = null;
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000BC28 File Offset: 0x00009E28
		private void buttonFullSize_Click(object sender, EventArgs e)
		{
			if (this.m_Bitmap != null)
			{
				Viewer2D.s_FullSizeViewer.SetImage(this.m_Bitmap);
				Viewer2D.s_FullSizeViewer.ShowDialog();
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000BC4D File Offset: 0x00009E4D
		private void buttonShow_Click(object sender, EventArgs e)
		{
			this.EnableButtons();
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000BC58 File Offset: 0x00009E58
		private void EnableButtons()
		{
			bool flag = this.buttonShow.Checked && this.m_Bitmap != null;
			this.buttonExportImage.Enabled = flag;
			this.buttonFullSize.Enabled = flag;
			this.buttonRemove.Enabled = flag;
			if (!flag)
			{
				this.textSize.Text = string.Empty;
				this.picture.BackgroundImage = null;
			}
			else
			{
				this.textSize.Text = this.m_Bitmap.Width.ToString() + " x " + this.m_Bitmap.Height.ToString();
				this.picture.BackgroundImage = this.m_Bitmap;
			}
			this.picture.Enabled = this.buttonShow.Checked;
			this.buttonImportImage.Enabled = true;
		}

		// Token: 0x040000D1 RID: 209
		private IContainer components;

		// Token: 0x040000D2 RID: 210
		public PictureBox picture;

		// Token: 0x040000D3 RID: 211
		private ToolStrip toolStrip;

		// Token: 0x040000D4 RID: 212
		private ToolStripTextBox textSize;

		// Token: 0x040000D5 RID: 213
		private OpenFileDialog openFileDialog;

		// Token: 0x040000D6 RID: 214
		public ToolStripButton buttonImportImage;

		// Token: 0x040000D7 RID: 215
		public ToolStripButton buttonExportImage;

		// Token: 0x040000D8 RID: 216
		public ToolStripButton buttonRemove;

		// Token: 0x040000D9 RID: 217
		public ToolStripButton buttonFullSize;

		// Token: 0x040000DA RID: 218
		private ToolStripButton buttonShow;

		// Token: 0x040000DB RID: 219
		private ContextMenuStrip contextMenuStrip;

		// Token: 0x040000DC RID: 220
		private ToolStripMenuItem importImageToolStripMenuItem;

		// Token: 0x040000DD RID: 221
		private ToolStripMenuItem exportImageToolStripMenuItem;

		// Token: 0x040000DE RID: 222
		private ToolStripMenuItem removeToolStripMenuItem;

		// Token: 0x040000DF RID: 223
		private Size m_ImageSize;

		// Token: 0x040000E0 RID: 224
		private Viewer2D.SizeMultiplier m_ImageSizeMultiplier;

		// Token: 0x040000E1 RID: 225
		private bool m_AutoTransparency;

		// Token: 0x040000E2 RID: 226
		private bool m_ExtendedFormat;

		// Token: 0x040000E3 RID: 227
		private Bitmap m_Bitmap;

		// Token: 0x040000E4 RID: 228
		private string m_InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

		// Token: 0x040000E5 RID: 229
		public Viewer2D.ImageImportHandler ImageImport;

		// Token: 0x040000E6 RID: 230
		public Viewer2D.ImageDeleteHandler ImageDelete;

		// Token: 0x040000E7 RID: 231
		private static FullSizeViewer s_FullSizeViewer = new FullSizeViewer();

		// Token: 0x02000010 RID: 16
		public enum SizeMultiplier
		{
			// Token: 0x040000E9 RID: 233
			None,
			// Token: 0x040000EA RID: 234
			OneAndHalf,
			// Token: 0x040000EB RID: 235
			Double,
			// Token: 0x040000EC RID: 236
			Half,
			// Token: 0x040000ED RID: 237
			Kit,
			// Token: 0x040000EE RID: 238
			MiniFace,
			// Token: 0x040000EF RID: 239
			Free
		}

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x060000B5 RID: 181
		public delegate bool ImageImportHandler(object sender, Bitmap bitmap);

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x060000B9 RID: 185
		public delegate bool ImageDeleteHandler(object sender);
	}
}
