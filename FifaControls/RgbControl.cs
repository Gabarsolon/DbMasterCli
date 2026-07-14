using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FifaControls
{
	// Token: 0x02000002 RID: 2
	public partial class RgbControl : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public RgbControl(Bitmap inputBitmap, Control caller)
		{
			if (inputBitmap == null)
			{
				return;
			}
			this.m_OutputBitmap = inputBitmap;
			this.m_InputBitmap = (Bitmap)inputBitmap.Clone();
			this.m_Caller = caller;
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002084 File Offset: 0x00000284
		private void Colorize()
		{
			if (this.m_InputBitmap == null)
			{
				return;
			}
			if (this.m_InputBitmap.PixelFormat != PixelFormat.Format32bppArgb)
			{
				return;
			}
			Cursor.Current = Cursors.WaitCursor;
			int num = this.m_InputBitmap.Width * this.m_InputBitmap.Height;
			int[] array = new int[num];
			Rectangle rectangle = new Rectangle(0, 0, this.m_InputBitmap.Width, this.m_InputBitmap.Height);
			BitmapData bitmapData = this.m_InputBitmap.LockBits(rectangle, ImageLockMode.WriteOnly, this.m_InputBitmap.PixelFormat);
			IntPtr scan = bitmapData.Scan0;
			Marshal.Copy(scan, array, 0, num);
			this.m_InputBitmap.UnlockBits(bitmapData);
			for (int i = 0; i < num; i++)
			{
				Color color = Color.FromArgb(array[i]);
				int num2 = (int)color.R;
				int num3 = (int)color.G;
				int num4 = (int)color.B;
				int a = (int)color.A;
				num2 += this.trackBarRed.Value;
				num3 += this.trackBarGreen.Value;
				num4 += this.trackBarBlue.Value;
				if (num2 > 255)
				{
					num2 = 255;
				}
				if (num3 > 255)
				{
					num3 = 255;
				}
				if (num4 > 255)
				{
					num4 = 255;
				}
				if (num2 < 0)
				{
					num2 = 0;
				}
				if (num3 < 0)
				{
					num3 = 0;
				}
				if (num4 < 0)
				{
					num4 = 0;
				}
				array[i] = Color.FromArgb(a, num2, num3, num4).ToArgb();
			}
			rectangle = new Rectangle(0, 0, this.m_OutputBitmap.Width, this.m_OutputBitmap.Height);
			BitmapData bitmapData2 = this.m_OutputBitmap.LockBits(rectangle, ImageLockMode.WriteOnly, this.m_OutputBitmap.PixelFormat);
			IntPtr scan2 = bitmapData2.Scan0;
			Marshal.Copy(array, 0, scan2, num);
			this.m_OutputBitmap.UnlockBits(bitmapData2);
			Cursor.Current = Cursors.Default;
			base.FindForm().Refresh();
			this.m_Caller.Refresh();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000227C File Offset: 0x0000047C
		private void buttonOk_Click(object sender, EventArgs e)
		{
			this.m_InputBitmap = this.m_OutputBitmap;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000228A File Offset: 0x0000048A
		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.m_OutputBitmap = this.m_InputBitmap;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002298 File Offset: 0x00000498
		private void trackBarRed_Scroll(object sender, EventArgs e)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000229A File Offset: 0x0000049A
		private void trackBarRed_MouseDown(object sender, MouseEventArgs e)
		{
			this.m_MouseStatus = -1;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000022A3 File Offset: 0x000004A3
		private void trackBarRed_MouseUp(object sender, MouseEventArgs e)
		{
			this.m_MouseStatus = 0;
			this.Colorize();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000022B2 File Offset: 0x000004B2
		private void buttonReset_Click(object sender, EventArgs e)
		{
			this.trackBarRed.Value = 0;
			this.trackBarGreen.Value = 0;
			this.trackBarBlue.Value = 0;
			this.Colorize();
		}

		// Token: 0x04000001 RID: 1
		private Bitmap m_InputBitmap;

		// Token: 0x04000002 RID: 2
		private Bitmap m_OutputBitmap;

		// Token: 0x04000003 RID: 3
		private Control m_Caller;

		// Token: 0x04000004 RID: 4
		private int m_MouseStatus;
	}
}
