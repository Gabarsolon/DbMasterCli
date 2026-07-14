using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace FifaControls
{
	// Token: 0x02000003 RID: 3
	public class Previewer : UserControl
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002A30 File Offset: 0x00000C30
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002A50 File Offset: 0x00000C50
		private void InitializeComponent()
		{
			this.pictureBox = new PictureBox();
			((ISupportInitialize)this.pictureBox).BeginInit();
			base.SuspendLayout();
			this.pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
			this.pictureBox.Dock = DockStyle.Fill;
			this.pictureBox.Location = new Point(0, 0);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new Size(150, 150);
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.pictureBox);
			base.Name = "Previewer";
			((ISupportInitialize)this.pictureBox).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002B2F File Offset: 0x00000D2F
		public Previewer()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002B40 File Offset: 0x00000D40
		public void Show(Image bitmap, int x, int y, int srcWidth, int srcHeight)
		{
			if (bitmap == null)
			{
				this.pictureBox.BackgroundImage = null;
				return;
			}
			int width = this.pictureBox.Width;
			int height = this.pictureBox.Height;
			if (this.pictureBox.BackgroundImage != null)
			{
				this.pictureBox.BackgroundImage.Dispose();
			}
			this.pictureBox.BackgroundImage = new Bitmap(this.pictureBox.Width, this.pictureBox.Height, PixelFormat.Format32bppArgb);
			Graphics graphics = Graphics.FromImage(this.pictureBox.BackgroundImage);
			graphics.InterpolationMode = InterpolationMode.Bicubic;
			graphics.DrawImage((Bitmap)bitmap, new Rectangle(0, 0, this.pictureBox.Width, this.pictureBox.Height), new Rectangle(x, y, srcWidth, srcHeight), GraphicsUnit.Pixel);
			graphics.Dispose();
		}

		// Token: 0x0400000F RID: 15
		private IContainer components;

		// Token: 0x04000010 RID: 16
		private PictureBox pictureBox;
	}
}
