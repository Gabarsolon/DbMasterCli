using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FifaLibrary
{
	// Token: 0x0200003D RID: 61
	public class GraphicUtil
	{
		// Token: 0x060005C5 RID: 1477 RVA: 0x000205D0 File Offset: 0x0001E7D0
		public static Bitmap ReduceBitmap(Bitmap srcBitmap)
		{
			int num = srcBitmap.Width;
			int num2 = srcBitmap.Height;
			if (num * num2 == 0)
			{
				return null;
			}
			num /= 2;
			num2 /= 2;
			if (num == 0)
			{
				num = 1;
			}
			if (num2 == 0)
			{
				num2 = 1;
			}
			return GraphicUtil.ResizeBitmap(srcBitmap, num, num2, InterpolationMode.HighQualityBicubic);
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00020610 File Offset: 0x0001E810
		public static Bitmap RemapBitmap(Bitmap srcBitmap, int destWidth, int destHeight)
		{
			Bitmap bitmap = new Bitmap(destWidth, destHeight, PixelFormat.Format32bppArgb);
			int width = srcBitmap.Width;
			int height = srcBitmap.Height;
			float num = (float)width / (float)destWidth;
			float num2 = (float)height / (float)destHeight;
			for (int i = 0; i < destWidth; i++)
			{
				for (int j = 0; j < destHeight; j++)
				{
					bitmap.SetPixel(i, j, GraphicUtil.RemapPixel(srcBitmap, (float)i * num, (float)j * num2));
				}
			}
			return bitmap;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00020684 File Offset: 0x0001E884
		private static Color RemapPixel(Bitmap srcBitmap, float x, float y)
		{
			int num = (int)Math.Floor((double)x);
			int num2 = (int)Math.Floor((double)y);
			int num3 = ((num < srcBitmap.Width) ? num : (srcBitmap.Width - 1));
			int num4 = ((num + 1 < srcBitmap.Width) ? (num + 1) : (srcBitmap.Width - 1));
			int num5 = ((num2 < srcBitmap.Height) ? num2 : (srcBitmap.Height - 1));
			int num6 = ((num2 + 1 < srcBitmap.Height) ? (num2 + 1) : (srcBitmap.Height - 1));
			Color pixel = srcBitmap.GetPixel(num3, num5);
			Color pixel2 = srcBitmap.GetPixel(num4, num5);
			Color pixel3 = srcBitmap.GetPixel(num3, num6);
			Color pixel4 = srcBitmap.GetPixel(num4, num6);
			float num7 = x - (float)num;
			float num8 = y - (float)num2;
			float num9 = (1f - num7) * (1f - num8);
			float num10 = num7 * (1f - num8);
			float num11 = (1f - num7) * num8;
			float num12 = num7 * num8;
			int num13 = (int)((float)pixel.R * num9 + (float)pixel2.R * num10 + (float)pixel3.R * num11 + (float)pixel4.R * num12);
			int num14 = (int)((float)pixel.G * num9 + (float)pixel2.G * num10 + (float)pixel3.G * num11 + (float)pixel4.G * num12);
			int num15 = (int)((float)pixel.B * num9 + (float)pixel2.B * num10 + (float)pixel3.B * num11 + (float)pixel4.B * num12);
			int num16 = (int)((float)pixel.A * num9 + (float)pixel2.A * num10 + (float)pixel3.A * num11 + (float)pixel4.A * num12);
			return Color.FromArgb(num16, num13, num14, num15);
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00020844 File Offset: 0x0001EA44
		public static void LoadPictureImage(PictureBox picture, Bitmap bitmap)
		{
			if (bitmap == null)
			{
				picture.Image = bitmap;
				return;
			}
			if (picture.Width == bitmap.Width && picture.Height == bitmap.Height)
			{
				picture.Image = bitmap;
				return;
			}
			picture.Image = GraphicUtil.RemapBitmap(bitmap, picture.Width, picture.Height);
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00020898 File Offset: 0x0001EA98
		public static Bitmap ResizeBitmap(Bitmap sourceBitmap, int width, int height, InterpolationMode interpolationMode)
		{
			if (sourceBitmap == null)
			{
				return null;
			}
			if (width < 0)
			{
				width = -width;
			}
			if (height < 0)
			{
				height = -height;
			}
			if (width == 0 || height == 0)
			{
				return null;
			}
			if (sourceBitmap.Width == width && sourceBitmap.Height == height)
			{
				return sourceBitmap;
			}
			Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.InterpolationMode = interpolationMode;
			graphics.DrawImage(sourceBitmap, new Rectangle(0, 0, width, height), 0, 0, sourceBitmap.Width, sourceBitmap.Height, GraphicsUnit.Pixel);
			graphics.Dispose();
			return bitmap;
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00020918 File Offset: 0x0001EB18
		public static Bitmap CanvasSizeBitmap(Bitmap sourceBitmap, int width, int height)
		{
			if (sourceBitmap == null)
			{
				return null;
			}
			Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.DrawImage(sourceBitmap, new Rectangle(0, 0, width, height), 0, 0, width, height, GraphicsUnit.Pixel);
			graphics.Dispose();
			return bitmap;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x0002095C File Offset: 0x0001EB5C
		public static Bitmap CanvasSizeBitmapCentered(Bitmap sourceBitmap, int width, int height)
		{
			if (sourceBitmap == null)
			{
				return null;
			}
			if (width > sourceBitmap.Width || height > sourceBitmap.Height)
			{
				return null;
			}
			int num = (sourceBitmap.Width - width) / 2;
			int num2 = (sourceBitmap.Height - height) / 2;
			Bitmap bitmap = new Bitmap(width, height, sourceBitmap.PixelFormat);
			Rectangle rectangle = new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height);
			BitmapData bitmapData = sourceBitmap.LockBits(rectangle, ImageLockMode.ReadOnly, sourceBitmap.PixelFormat);
			rectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
			BitmapData bitmapData2 = bitmap.LockBits(rectangle, ImageLockMode.ReadWrite, bitmap.PixelFormat);
			IntPtr scan = bitmapData.Scan0;
			IntPtr scan2 = bitmapData2.Scan0;
			int num3 = sourceBitmap.Width * sourceBitmap.Height;
			int num4 = bitmap.Width * bitmap.Height;
			int[] array = new int[num3];
			int[] array2 = new int[num4];
			Marshal.Copy(scan, array, 0, num3);
			Marshal.Copy(scan2, array2, 0, num4);
			int num5 = 0;
			int num6 = num2 * sourceBitmap.Width + num;
			for (int i = 0; i < bitmap.Height; i++)
			{
				for (int j = 0; j < bitmap.Width; j++)
				{
					array2[num5] = array[num6];
					num5++;
					num6++;
				}
				num6 += num * 2;
			}
			Marshal.Copy(array2, 0, scan2, num4);
			sourceBitmap.UnlockBits(bitmapData);
			bitmap.UnlockBits(bitmapData2);
			return bitmap;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00020AC0 File Offset: 0x0001ECC0
		public static Bitmap Get32bitBitmap(Bitmap sourceBitmap)
		{
			Bitmap bitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height, PixelFormat.Format32bppArgb);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.DrawImage(sourceBitmap, 0, 0, sourceBitmap.Width, sourceBitmap.Height);
			graphics.Dispose();
			return bitmap;
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00020B08 File Offset: 0x0001ED08
		public static bool GetAlfaFromChannel(Bitmap sourceBitmap, Bitmap alfaBitmap, int channel)
		{
			if (sourceBitmap.Width != alfaBitmap.Width || sourceBitmap.Height != alfaBitmap.Height)
			{
				return false;
			}
			Rectangle rectangle = new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height);
			BitmapData bitmapData = sourceBitmap.LockBits(rectangle, ImageLockMode.ReadWrite, sourceBitmap.PixelFormat);
			rectangle = new Rectangle(0, 0, alfaBitmap.Width, alfaBitmap.Height);
			BitmapData bitmapData2 = alfaBitmap.LockBits(rectangle, ImageLockMode.ReadOnly, alfaBitmap.PixelFormat);
			IntPtr scan = bitmapData.Scan0;
			IntPtr scan2 = bitmapData2.Scan0;
			int num = sourceBitmap.Width * sourceBitmap.Height;
			byte[] array = new byte[num * 4];
			byte[] array2 = new byte[num * 4];
			Marshal.Copy(scan, array, 0, num * 4);
			Marshal.Copy(scan2, array2, 0, num * 4);
			for (int i = 3; i < num * 4; i += 4)
			{
				array[i] = array2[i - channel];
			}
			Marshal.Copy(array, 0, scan, num * 4);
			sourceBitmap.UnlockBits(bitmapData);
			alfaBitmap.UnlockBits(bitmapData2);
			return true;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00020C08 File Offset: 0x0001EE08
		public static bool RemoveAlfaChannel(Bitmap sourceBitmap)
		{
			if (sourceBitmap == null)
			{
				return false;
			}
			Rectangle rectangle = new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height);
			BitmapData bitmapData = sourceBitmap.LockBits(rectangle, ImageLockMode.ReadWrite, sourceBitmap.PixelFormat);
			IntPtr scan = bitmapData.Scan0;
			int num = sourceBitmap.Width * sourceBitmap.Height;
			byte[] array = new byte[num * 4];
			Marshal.Copy(scan, array, 0, num * 4);
			for (int i = 3; i < num * 4; i += 4)
			{
				array[i] = byte.MaxValue;
			}
			Marshal.Copy(array, 0, scan, num * 4);
			sourceBitmap.UnlockBits(bitmapData);
			return true;
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00020C9C File Offset: 0x0001EE9C
		public static Bitmap SubSampleBitmap(Bitmap sourceBitmap, int xStep, int yStep)
		{
			if (sourceBitmap == null)
			{
				return null;
			}
			if (xStep <= 0 || yStep <= 0)
			{
				return null;
			}
			if (xStep == 1 && yStep == 1)
			{
				return (Bitmap)sourceBitmap.Clone();
			}
			Bitmap bitmap = new Bitmap(sourceBitmap.Width / xStep, sourceBitmap.Height / yStep, sourceBitmap.PixelFormat);
			Rectangle rectangle = new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height);
			BitmapData bitmapData = sourceBitmap.LockBits(rectangle, ImageLockMode.ReadOnly, sourceBitmap.PixelFormat);
			rectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
			BitmapData bitmapData2 = bitmap.LockBits(rectangle, ImageLockMode.ReadWrite, bitmap.PixelFormat);
			IntPtr scan = bitmapData.Scan0;
			IntPtr scan2 = bitmapData2.Scan0;
			int num = sourceBitmap.Width * sourceBitmap.Height;
			int num2 = bitmap.Width * bitmap.Height;
			int[] array = new int[num];
			int[] array2 = new int[num2];
			Marshal.Copy(scan, array, 0, num);
			Marshal.Copy(scan2, array2, 0, num2);
			int num3 = 0;
			int num4 = 0;
			for (int i = 0; i < bitmap.Height; i++)
			{
				for (int j = 0; j < bitmap.Width; j++)
				{
					array2[num3] = array[num4];
					num3++;
					num4 += xStep;
				}
				num4 += (yStep - 1) * sourceBitmap.Width;
			}
			Marshal.Copy(array2, 0, scan2, num2);
			sourceBitmap.UnlockBits(bitmapData);
			bitmap.UnlockBits(bitmapData2);
			return bitmap;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00020DF8 File Offset: 0x0001EFF8
		public static bool ColorizeRGB(Bitmap sourceBitmap, Color color1, Color color2, Color color3, bool preserveArmBand)
		{
			if (sourceBitmap == null)
			{
				return false;
			}
			Color[,] array = new Color[48, 256];
			preserveArmBand = preserveArmBand && sourceBitmap.Width == 1024 && sourceBitmap.Height == 1024;
			if (preserveArmBand)
			{
				int num = 0;
				for (int i = 975; i <= 1022; i++)
				{
					int num2 = 0;
					for (int j = 384; j <= 639; j++)
					{
						array[num, num2++] = sourceBitmap.GetPixel(j, i);
					}
					num++;
				}
			}
			bool flag = GraphicUtil.ColorizeRGB(sourceBitmap, color1, color2, color3, 0, sourceBitmap.Height);
			if (flag && preserveArmBand)
			{
				int num3 = 0;
				for (int k = 975; k <= 1022; k++)
				{
					int num4 = 0;
					for (int l = 384; l <= 639; l++)
					{
						sourceBitmap.SetPixel(l, k, array[num3, num4++]);
					}
					num3++;
				}
			}
			return flag;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00020F08 File Offset: 0x0001F108
		public static bool ColorizeRGB(Bitmap sourceBitmap, Color color1, Color color2, Color color3, int firstRow, int lastRow)
		{
			if (sourceBitmap == null)
			{
				return false;
			}
			Rectangle rectangle = new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height);
			BitmapData bitmapData = sourceBitmap.LockBits(rectangle, ImageLockMode.ReadWrite, sourceBitmap.PixelFormat);
			IntPtr scan = bitmapData.Scan0;
			int num = sourceBitmap.Width * sourceBitmap.Height;
			byte[] array = new byte[num * 4];
			Marshal.Copy(scan, array, 0, num * 4);
			for (int i = firstRow * sourceBitmap.Width; i < lastRow * sourceBitmap.Width; i++)
			{
				int num2 = (int)array[i * 4];
				int num3 = (int)array[i * 4 + 1];
				int num4 = (int)array[i * 4 + 2];
				int num5 = ((int)color1.R * num4 + (int)color2.R * num3 + (int)color3.R * num2) / 226;
				int num6 = ((int)color1.G * num4 + (int)color2.G * num3 + (int)color3.G * num2) / 226;
				int num7 = ((int)color1.B * num4 + (int)color2.B * num3 + (int)color3.B * num2) / 226;
				if (num5 > 255)
				{
					num5 = 255;
				}
				if (num6 > 255)
				{
					num6 = 255;
				}
				if (num7 > 255)
				{
					num7 = 255;
				}
				array[i * 4] = (byte)num7;
				array[i * 4 + 1] = (byte)num6;
				array[i * 4 + 2] = (byte)num5;
			}
			Marshal.Copy(array, 0, scan, num * 4);
			sourceBitmap.UnlockBits(bitmapData);
			return true;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0002108C File Offset: 0x0001F28C
		public static bool PrepareToColorize(Bitmap sourceBitmap, int firstRow, int lastRow)
		{
			if (sourceBitmap == null)
			{
				return false;
			}
			Rectangle rectangle = new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height);
			BitmapData bitmapData = sourceBitmap.LockBits(rectangle, ImageLockMode.ReadWrite, sourceBitmap.PixelFormat);
			IntPtr scan = bitmapData.Scan0;
			int num = sourceBitmap.Width * sourceBitmap.Height;
			byte[] array = new byte[num * 4];
			Marshal.Copy(scan, array, 0, num * 4);
			for (int i = firstRow * sourceBitmap.Width; i < lastRow * sourceBitmap.Width; i++)
			{
				int num2 = (int)array[i * 4];
				int num3 = (int)array[i * 4 + 1];
				int num4 = (int)array[i * 4 + 2];
				while (num4 + num3 + num2 > 226)
				{
					if (num4 > 0)
					{
						num4--;
					}
					if (num3 > 0)
					{
						num3--;
					}
					if (num2 > 0)
					{
						num2--;
					}
				}
				array[i * 4] = (byte)num2;
				array[i * 4 + 1] = (byte)num3;
				array[i * 4 + 2] = (byte)num4;
			}
			Marshal.Copy(array, 0, scan, num * 4);
			sourceBitmap.UnlockBits(bitmapData);
			return true;
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00021198 File Offset: 0x0001F398
		public static Bitmap MultiplyBitmap(Bitmap sourceBitmap, Bitmap multBitmap)
		{
			if (sourceBitmap == null)
			{
				return null;
			}
			if (multBitmap == null)
			{
				return (Bitmap)sourceBitmap.Clone();
			}
			int num = sourceBitmap.Width * sourceBitmap.Height;
			Rectangle rectangle = new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height);
			int[] array = new int[num];
			int[] array2 = new int[num];
			if (multBitmap == null)
			{
				return (Bitmap)sourceBitmap.Clone();
			}
			BitmapData bitmapData = sourceBitmap.LockBits(rectangle, ImageLockMode.ReadWrite, sourceBitmap.PixelFormat);
			IntPtr scan = bitmapData.Scan0;
			Marshal.Copy(scan, array, 0, num);
			sourceBitmap.UnlockBits(bitmapData);
			if (multBitmap.Width != sourceBitmap.Width || multBitmap.Height != sourceBitmap.Height)
			{
				multBitmap = GraphicUtil.ResizeBitmap(multBitmap, sourceBitmap.Width, sourceBitmap.Height, InterpolationMode.Bilinear);
			}
			BitmapData bitmapData2 = multBitmap.LockBits(rectangle, ImageLockMode.ReadWrite, multBitmap.PixelFormat);
			IntPtr scan2 = bitmapData2.Scan0;
			Marshal.Copy(scan2, array2, 0, num);
			multBitmap.UnlockBits(bitmapData);
			for (int i = 0; i < num; i++)
			{
				Color color = Color.FromArgb(array[i]);
				int num2 = array2[i] & 255;
				int num3 = (int)(((long)array2[i] & 0xFF000000L) >> 24);
				int num4 = (int)color.R * num2 / 255;
				int num5 = (int)color.G * num2 / 255;
				int num6 = (int)color.B * num2 / 255;
				int num7 = (int)color.A * num3 / 255;
				array[i] = (((((num7 << 8) | num4) << 8) | num5) << 8) | num6;
			}
			Bitmap bitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height, PixelFormat.Format32bppArgb);
			rectangle = new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height);
			BitmapData bitmapData3 = bitmap.LockBits(rectangle, ImageLockMode.WriteOnly, bitmap.PixelFormat);
			IntPtr scan3 = bitmapData3.Scan0;
			Marshal.Copy(array, 0, scan3, num);
			bitmap.UnlockBits(bitmapData3);
			return bitmap;
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x0002137C File Offset: 0x0001F57C
		public static Bitmap MultiplyColorToBitmap(Bitmap sourceBitmap, Color color, int divisor)
		{
			if (sourceBitmap == null)
			{
				return null;
			}
			int num = sourceBitmap.Width * sourceBitmap.Height;
			Rectangle rectangle = new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height);
			int[] array = new int[num];
			BitmapData bitmapData = sourceBitmap.LockBits(rectangle, ImageLockMode.ReadWrite, sourceBitmap.PixelFormat);
			IntPtr scan = bitmapData.Scan0;
			Marshal.Copy(scan, array, 0, num);
			sourceBitmap.UnlockBits(bitmapData);
			for (int i = 0; i < num; i++)
			{
				Color color2 = Color.FromArgb(array[i]);
				int num2 = (int)(color.R * color2.R) / divisor;
				int num3 = (int)(color.G * color2.G) / divisor;
				int num4 = (int)(color.B * color2.B) / divisor;
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
				int num5 = 255;
				array[i] = (((((num5 << 8) | num2) << 8) | num3) << 8) | num4;
			}
			Bitmap bitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height, PixelFormat.Format32bppArgb);
			rectangle = new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height);
			BitmapData bitmapData2 = bitmap.LockBits(rectangle, ImageLockMode.WriteOnly, bitmap.PixelFormat);
			IntPtr scan2 = bitmapData2.Scan0;
			Marshal.Copy(array, 0, scan2, num);
			bitmap.UnlockBits(bitmapData2);
			return bitmap;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x000214E4 File Offset: 0x0001F6E4
		public static Bitmap AddWrinklesBitmap(Bitmap sourceBitmap, Bitmap wrinkleBitmap)
		{
			if (sourceBitmap == null)
			{
				return null;
			}
			if (wrinkleBitmap == null)
			{
				return (Bitmap)sourceBitmap.Clone();
			}
			int num = sourceBitmap.Width * sourceBitmap.Height;
			Rectangle rectangle = new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height);
			int[] array = new int[num];
			int[] array2 = new int[num];
			if (wrinkleBitmap == null)
			{
				return (Bitmap)sourceBitmap.Clone();
			}
			BitmapData bitmapData = sourceBitmap.LockBits(rectangle, ImageLockMode.ReadWrite, sourceBitmap.PixelFormat);
			IntPtr scan = bitmapData.Scan0;
			Marshal.Copy(scan, array, 0, num);
			sourceBitmap.UnlockBits(bitmapData);
			if (wrinkleBitmap.Width != sourceBitmap.Width || wrinkleBitmap.Height != sourceBitmap.Height)
			{
				wrinkleBitmap = GraphicUtil.ResizeBitmap(wrinkleBitmap, sourceBitmap.Width, sourceBitmap.Height, InterpolationMode.Bilinear);
			}
			BitmapData bitmapData2 = wrinkleBitmap.LockBits(rectangle, ImageLockMode.ReadWrite, wrinkleBitmap.PixelFormat);
			IntPtr scan2 = bitmapData2.Scan0;
			Marshal.Copy(scan2, array2, 0, num);
			wrinkleBitmap.UnlockBits(bitmapData);
			for (int i = 0; i < num; i++)
			{
				Color color = Color.FromArgb(array[i]);
				int num2 = array2[i] & 255;
				int num3 = (int)(((long)array2[i] & 0xFF000000L) >> 24);
				int num4 = (int)color.R * num2 / 255;
				int num5 = (int)color.G * num2 / 255;
				int num6 = (int)color.B * num2 / 255;
				int num7 = (int)color.A * num3 / 255;
				array[i] = (((((num7 << 8) | num4) << 8) | num5) << 8) | num6;
			}
			Bitmap bitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height, PixelFormat.Format32bppArgb);
			rectangle = new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height);
			BitmapData bitmapData3 = bitmap.LockBits(rectangle, ImageLockMode.WriteOnly, bitmap.PixelFormat);
			IntPtr scan3 = bitmapData3.Scan0;
			Marshal.Copy(array, 0, scan3, num);
			bitmap.UnlockBits(bitmapData3);
			return bitmap;
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x000216C8 File Offset: 0x0001F8C8
		public static Bitmap EmbossBitmap(Bitmap sourceBitmap, Bitmap embossingBitmap)
		{
			if (sourceBitmap == null)
			{
				return null;
			}
			if (embossingBitmap == null)
			{
				return (Bitmap)sourceBitmap.Clone();
			}
			int num = sourceBitmap.Width * sourceBitmap.Height;
			Rectangle rectangle = new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height);
			int[] array = new int[num];
			int[] array2 = new int[num];
			if (embossingBitmap == null)
			{
				return (Bitmap)sourceBitmap.Clone();
			}
			BitmapData bitmapData = sourceBitmap.LockBits(rectangle, ImageLockMode.ReadWrite, sourceBitmap.PixelFormat);
			IntPtr scan = bitmapData.Scan0;
			Marshal.Copy(scan, array, 0, num);
			sourceBitmap.UnlockBits(bitmapData);
			if (embossingBitmap.Width != sourceBitmap.Width || embossingBitmap.Height != sourceBitmap.Height)
			{
				embossingBitmap = GraphicUtil.ResizeBitmap(embossingBitmap, sourceBitmap.Width, sourceBitmap.Height, InterpolationMode.Bilinear);
			}
			BitmapData bitmapData2 = embossingBitmap.LockBits(rectangle, ImageLockMode.ReadWrite, embossingBitmap.PixelFormat);
			IntPtr scan2 = bitmapData2.Scan0;
			Marshal.Copy(scan2, array2, 0, num);
			embossingBitmap.UnlockBits(bitmapData);
			for (int i = 0; i < num; i++)
			{
				Color color = Color.FromArgb(array[i]);
				int num2 = (127 - ((array2[i] & 65280) >> 8)) / 2;
				int num3 = (int)color.R + num2;
				if (num3 > 255)
				{
					num3 = 255;
				}
				if (num3 < 0)
				{
					num3 = 0;
				}
				int num4 = (int)color.G + num2;
				if (num4 > 255)
				{
					num4 = 255;
				}
				if (num4 < 0)
				{
					num4 = 0;
				}
				int num5 = (int)color.B + num2;
				if (num5 > 255)
				{
					num5 = 255;
				}
				if (num5 < 0)
				{
					num5 = 0;
				}
				int a = (int)color.A;
				array[i] = (((((a << 8) | num3) << 8) | num4) << 8) | num5;
			}
			Bitmap bitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height, PixelFormat.Format32bppArgb);
			rectangle = new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height);
			BitmapData bitmapData3 = bitmap.LockBits(rectangle, ImageLockMode.WriteOnly, bitmap.PixelFormat);
			IntPtr scan3 = bitmapData3.Scan0;
			Marshal.Copy(array, 0, scan3, num);
			bitmap.UnlockBits(bitmapData3);
			return bitmap;
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x000218CC File Offset: 0x0001FACC
		public static Bitmap Overlap(Bitmap lowerBitmap, Bitmap upperBitmap, Rectangle destRectangle)
		{
			if (lowerBitmap == null && upperBitmap == null)
			{
				return null;
			}
			if (lowerBitmap == null)
			{
				return (Bitmap)upperBitmap.Clone();
			}
			if (upperBitmap == null)
			{
				return (Bitmap)lowerBitmap.Clone();
			}
			Bitmap bitmap = GraphicUtil.ResizeBitmap(upperBitmap, destRectangle.Width, destRectangle.Height, InterpolationMode.Bicubic);
			if (bitmap != null)
			{
				Bitmap bitmap2 = (Bitmap)lowerBitmap.Clone();
				Graphics graphics = Graphics.FromImage(bitmap2);
				graphics.DrawImage(bitmap, destRectangle.Left, destRectangle.Top);
				graphics.Dispose();
				return bitmap2;
			}
			return lowerBitmap;
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0002194C File Offset: 0x0001FB4C
		public static Bitmap ColorizeWhite(Bitmap srcBitmap, Color color)
		{
			if (srcBitmap == null)
			{
				return null;
			}
			int r = (int)color.R;
			int g = (int)color.G;
			int b = (int)color.B;
			for (int i = 0; i < srcBitmap.Width; i++)
			{
				for (int j = 0; j < srcBitmap.Height; j++)
				{
					Color pixel = srcBitmap.GetPixel(i, j);
					if (pixel != Color.FromArgb(0, 0, 0, 0))
					{
						srcBitmap.SetPixel(i, j, Color.FromArgb((int)pixel.A, r, g, b));
					}
				}
			}
			return srcBitmap;
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x000219D4 File Offset: 0x0001FBD4
		public static void RemapRectangle(Bitmap srcBitmap, Rectangle srcRect, Bitmap destBitmap, Rectangle destRect)
		{
			Graphics graphics = Graphics.FromImage(destBitmap);
			graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			graphics.DrawImage(srcBitmap, destRect, srcRect, GraphicsUnit.Pixel);
			graphics.Dispose();
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00021A00 File Offset: 0x0001FC00
		public static void DrawOver(Bitmap belowBitmap, Bitmap overBitmap)
		{
			Graphics graphics = Graphics.FromImage(belowBitmap);
			graphics.DrawImage(overBitmap, 0, 0, overBitmap.Width, overBitmap.Height);
			graphics.Dispose();
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00021A30 File Offset: 0x0001FC30
		public static Bitmap MakeAutoTransparent(Bitmap bitmap)
		{
			Color pixel = bitmap.GetPixel(0, 0);
			bitmap.MakeTransparent(pixel);
			return bitmap;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00021A50 File Offset: 0x0001FC50
		public static Color GetDominantColor(Bitmap bitmap, Rectangle rectangle)
		{
			int[] array = new int[256];
			for (int i = rectangle.X; i < rectangle.X + rectangle.Width; i++)
			{
				for (int j = rectangle.Y; j < rectangle.Y + rectangle.Height; j++)
				{
					array[(int)bitmap.GetPixel(i, j).R]++;
				}
			}
			int num = -1;
			int num2 = 0;
			for (int k = 0; k < 256; k++)
			{
				if (array[k] > num)
				{
					num = array[k];
					num2 = k;
				}
			}
			int num3 = 0;
			int num4 = 0;
			for (int l = rectangle.X; l < rectangle.X + rectangle.Width; l++)
			{
				for (int m = rectangle.Y; m < rectangle.Y + rectangle.Height; m++)
				{
					Color pixel = bitmap.GetPixel(l, m);
					if ((int)pixel.R == num2)
					{
						num3 += (int)pixel.G;
						num4 += (int)pixel.B;
					}
				}
			}
			int num5 = num3 / num;
			int num6 = num4 / num;
			return Color.FromArgb(255, num2, num5, num6);
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00021B98 File Offset: 0x0001FD98
		public static Bitmap ColorTuning(Bitmap variableBitmap, Bitmap referenceBitmap, Rectangle rect)
		{
			Color dominantColor = GraphicUtil.GetDominantColor(variableBitmap, rect);
			Color dominantColor2 = GraphicUtil.GetDominantColor(referenceBitmap, rect);
			int num = (int)(dominantColor2.R - dominantColor.R);
			int num2 = (int)(dominantColor2.G - dominantColor.G);
			int num3 = (int)(dominantColor2.B - dominantColor.B);
			Bitmap bitmap = (Bitmap)variableBitmap.Clone();
			GraphicUtil.AddColorOffset(bitmap, num, num2, num3);
			return bitmap;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00021C00 File Offset: 0x0001FE00
		public static Bitmap ColorTuning(Bitmap variableBitmap, Rectangle variableRect, Bitmap referenceBitmap, Rectangle referenceRect)
		{
			Color dominantColor = GraphicUtil.GetDominantColor(variableBitmap, variableRect);
			Color dominantColor2 = GraphicUtil.GetDominantColor(referenceBitmap, referenceRect);
			int num = (int)(dominantColor2.R - dominantColor.R);
			int num2 = (int)(dominantColor2.G - dominantColor.G);
			int num3 = (int)(dominantColor2.B - dominantColor.B);
			Bitmap bitmap = (Bitmap)variableBitmap.Clone();
			GraphicUtil.AddColorOffset(bitmap, num, num2, num3);
			return bitmap;
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00021C68 File Offset: 0x0001FE68
		public static void AddColorOffset(Bitmap bitmap, int deltaR, int deltaG, int deltaB)
		{
			if (bitmap == null)
			{
				return;
			}
			for (int i = 0; i < bitmap.Width; i++)
			{
				for (int j = 0; j < bitmap.Height; j++)
				{
					Color pixel = bitmap.GetPixel(i, j);
					int num = (int)pixel.R + deltaR;
					int num2 = (int)pixel.G + deltaG;
					int num3 = (int)pixel.B + deltaB;
					if (num > 255)
					{
						num = 255;
					}
					if (num2 > 255)
					{
						num2 = 255;
					}
					if (num3 > 255)
					{
						num3 = 255;
					}
					if (num < 0)
					{
						num = 0;
					}
					if (num2 < 0)
					{
						num2 = 0;
					}
					if (num3 < 0)
					{
						num3 = 0;
					}
					bitmap.SetPixel(i, j, Color.FromArgb((int)pixel.A, num, num2, num3));
				}
			}
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00021D30 File Offset: 0x0001FF30
		public static Bitmap CreateReferenceBitmap(Bitmap sourceBitmap, Color c1, Color c2, Color c3)
		{
			if (sourceBitmap == null)
			{
				return null;
			}
			int num = sourceBitmap.Width * sourceBitmap.Height;
			Rectangle rectangle = new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height);
			int[] array = new int[num];
			int[] array2 = new int[3];
			BitmapData bitmapData = sourceBitmap.LockBits(rectangle, ImageLockMode.ReadWrite, sourceBitmap.PixelFormat);
			IntPtr scan = bitmapData.Scan0;
			Marshal.Copy(scan, array, 0, num);
			sourceBitmap.UnlockBits(bitmapData);
			Color[] array3 = new Color[] { c1, c2, c3 };
			int[] array4 = new int[3];
			for (int i = 0; i < num; i++)
			{
				Color color = Color.FromArgb(array[i]);
				int num5;
				int num4;
				int num3;
				int num2 = (num3 = (num4 = (num5 = 0)));
				if (color == c1)
				{
					num2 = 226;
					num4 = 0;
					num5 = 0;
					num3 = 255;
				}
				else if (color == c2)
				{
					num2 = 0;
					num4 = 226;
					num5 = 0;
					num3 = 255;
				}
				else if (color == c3)
				{
					num2 = 0;
					num4 = 0;
					num5 = 226;
					num3 = 255;
				}
				else if (GraphicUtil.UseColorCombination(array3, color, ref array4, true, array2))
				{
					num2 = array4[0];
					num4 = array4[1];
					num5 = array4[2];
					num3 = 255;
				}
				if (num3 == 255)
				{
					array[i] = (((((num3 << 8) | num2) << 8) | num4) << 8) | num5;
				}
				else
				{
					num2 = (int)color.R;
					num4 = (int)color.G;
					num5 = (int)color.B;
					num3 = 0;
					array[i] = (((((num3 << 8) | num2) << 8) | num4) << 8) | num5;
				}
			}
			for (int j = 0; j < num; j++)
			{
				Color color2 = Color.FromArgb(array[j]);
				if (color2.A == 0)
				{
					int num6 = j / sourceBitmap.Width;
					int num7 = j - num6 * sourceBitmap.Width;
					array2[0] = (array2[1] = (array2[2] = 0));
					for (int k = -2; k <= 2; k++)
					{
						for (int l = -2; l <= 2; l++)
						{
							int num8 = num6 + k;
							int num9 = num7 + l;
							if (num8 >= 0 && num8 < sourceBitmap.Height && num9 >= 0 && num9 < sourceBitmap.Width)
							{
								Color color3 = Color.FromArgb(array[num8 * sourceBitmap.Width + num9]);
								if (color3.A != 0)
								{
									if (color3.R != 0)
									{
										array2[0]++;
									}
									else if (color3.G != 0)
									{
										array2[1]++;
									}
									else if (color3.B != 0)
									{
										array2[2]++;
									}
								}
							}
						}
					}
					GraphicUtil.UseColorCombination(array3, color2, ref array4, false, array2);
					int num2 = array4[0];
					int num4 = array4[1];
					int num5 = array4[2];
					int num3 = 255;
					array[j] = (((((num3 << 8) | num2) << 8) | num4) << 8) | num5;
				}
			}
			Bitmap bitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height, PixelFormat.Format32bppArgb);
			rectangle = new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height);
			BitmapData bitmapData2 = bitmap.LockBits(rectangle, ImageLockMode.WriteOnly, bitmap.PixelFormat);
			IntPtr scan2 = bitmapData2.Scan0;
			Marshal.Copy(array, 0, scan2, num);
			bitmap.UnlockBits(bitmapData2);
			return bitmap;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x000220B0 File Offset: 0x000202B0
		public static Bitmap CreateReferenceBitmap(Bitmap sourceBitmap, Color c1, Color c2, Color c3, bool preserveArmBand)
		{
			Color[,] array = new Color[48, 256];
			preserveArmBand = preserveArmBand && sourceBitmap.Width == 1024 && sourceBitmap.Height == 1024;
			if (preserveArmBand)
			{
				int num = 0;
				for (int i = 975; i <= 1022; i++)
				{
					int num2 = 0;
					for (int j = 384; j <= 639; j++)
					{
						array[num, num2++] = sourceBitmap.GetPixel(j, i);
					}
					num++;
				}
			}
			Bitmap bitmap = GraphicUtil.CreateReferenceBitmap(sourceBitmap, c1, c2, c3);
			if (bitmap != null && preserveArmBand)
			{
				int num3 = 0;
				for (int k = 975; k <= 1022; k++)
				{
					int num4 = 0;
					for (int l = 384; l <= 639; l++)
					{
						bitmap.SetPixel(l, k, array[num3, num4++]);
					}
					num3++;
				}
			}
			return bitmap;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x000221B4 File Offset: 0x000203B4
		private static bool UseColorCombination(Color[] refColors, Color tC, ref int[] rgb, bool useOneColor, int[] hist)
		{
			int[] array = new int[3];
			rgb[0] = (rgb[1] = (rgb[2] = 0));
			if (hist[0] + hist[1] + hist[2] != 0)
			{
				if (hist[0] > 0 && hist[1] == 0 && hist[2] == 0)
				{
					rgb[0] = GraphicUtil.UseOneColor(refColors[0], tC);
					return true;
				}
				if (hist[1] > 0 && hist[0] == 0 && hist[2] == 0)
				{
					rgb[1] = GraphicUtil.UseOneColor(refColors[1], tC);
					return true;
				}
				if (hist[2] > 0 && hist[0] == 0 && hist[1] == 0)
				{
					rgb[2] = GraphicUtil.UseOneColor(refColors[2], tC);
					return true;
				}
				if (!useOneColor)
				{
					if (hist[0] >= hist[2] && hist[1] >= hist[2])
					{
						if (GraphicUtil.UseTwoColors(refColors[0], refColors[1], tC, out rgb[0], out rgb[1]))
						{
							return true;
						}
					}
					else if (hist[0] >= hist[1] && hist[2] >= hist[1])
					{
						if (GraphicUtil.UseTwoColors(refColors[0], refColors[2], tC, out rgb[0], out rgb[2]))
						{
							return true;
						}
					}
					else if (hist[1] >= hist[0] && hist[2] >= hist[0] && GraphicUtil.UseTwoColors(refColors[1], refColors[2], tC, out rgb[1], out rgb[2]))
					{
						return true;
					}
				}
			}
			for (int i = 0; i < 3; i++)
			{
				rgb[i] = 0;
				array[i] = (int)((tC.R - refColors[i].R) * (tC.R - refColors[i].R) + (tC.G - refColors[i].G) * (tC.G - refColors[i].G) + (tC.B - refColors[i].B) * (tC.B - refColors[i].B));
				if (refColors[i].A == 0)
				{
					array[i] = int.MaxValue;
				}
			}
			int num;
			int num2;
			int num3;
			if (array[0] <= array[1] && array[0] <= array[2])
			{
				num = 0;
				if (array[1] < array[2])
				{
					num2 = 1;
					num3 = 2;
				}
				else
				{
					num2 = 2;
					num3 = 1;
				}
			}
			else if (array[1] <= array[0] && array[1] <= array[2])
			{
				num = 1;
				if (array[0] < array[2])
				{
					num2 = 0;
					num3 = 2;
				}
				else
				{
					num2 = 2;
					num3 = 0;
				}
			}
			else
			{
				num = 2;
				if (array[0] < array[1])
				{
					num2 = 0;
					num3 = 1;
				}
				else
				{
					num2 = 1;
					num3 = 0;
				}
			}
			if (array[num] * 8 < array[num2])
			{
				rgb[num] = GraphicUtil.UseOneColor(refColors[num], tC);
				return true;
			}
			if (useOneColor)
			{
				return false;
			}
			if (array[num] * 8 > array[num2] && GraphicUtil.UseTwoColors(refColors[num], refColors[num2], tC, out rgb[num], out rgb[num2]))
			{
				return true;
			}
			if (array[num] * 8 > array[num3] && GraphicUtil.UseTwoColors(refColors[num], refColors[num3], tC, out rgb[num], out rgb[num3]))
			{
				return true;
			}
			rgb[num] = GraphicUtil.UseOneColor(refColors[num], tC);
			return true;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00022528 File Offset: 0x00020728
		private static int UseOneColor(Color refColor, Color targetColor)
		{
			int num = (int)((refColor.R + refColor.G + refColor.B) / 3);
			int num2 = (int)((targetColor.R + targetColor.G + targetColor.B) / 3);
			int num3;
			if (num2 > num)
			{
				num3 = 226 + 30 * (num2 - num) / (255 - num);
			}
			else
			{
				num3 = 226 * num2 / num;
			}
			if (num3 < 0)
			{
				num3 = 0;
			}
			if (num3 > 255)
			{
				num3 = 255;
			}
			return num3;
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x000225A4 File Offset: 0x000207A4
		private static bool UseTwoColors(Color c1, Color c2, Color tc, out int w1, out int w2)
		{
			int num = Math.Abs((int)(c1.R - c2.R));
			int num2 = Math.Abs((int)(c1.G - c2.G));
			int num3 = Math.Abs((int)(c1.B - c2.B));
			if (num >= num2 && num >= num3)
			{
				if (c1.R < c2.R)
				{
					w1 = (int)((c2.R - tc.R) * 226) / num;
					w2 = (int)((tc.R - c1.R) * 226) / num;
				}
				else
				{
					w1 = (int)((tc.R - c2.R) * 226) / num;
					w2 = (int)((c1.R - tc.R) * 226) / num;
				}
			}
			else if (num2 >= num && num2 >= num3)
			{
				if (c1.G < c2.G)
				{
					w1 = (int)((c2.G - tc.G) * 226) / num2;
					w2 = (int)((tc.G - c1.G) * 226) / num2;
				}
				else
				{
					w1 = (int)((tc.G - c2.G) * 226) / num2;
					w2 = (int)((c1.G - tc.G) * 226) / num2;
				}
			}
			else if (c1.B < c2.B)
			{
				w1 = (int)((c2.B - tc.B) * 226) / num3;
				w2 = (int)((tc.B - c1.B) * 226) / num3;
			}
			else
			{
				w1 = (int)((tc.B - c2.B) * 226) / num3;
				w2 = (int)((c1.B - tc.B) * 226) / num3;
			}
			if (w1 < 0)
			{
				w1 = 0;
			}
			if (w1 > 255)
			{
				w1 = 255;
			}
			if (w2 < 0)
			{
				w2 = 0;
			}
			if (w2 > 255)
			{
				w2 = 255;
			}
			return w1 >= 0 && w2 >= 0;
		}
	}
}
