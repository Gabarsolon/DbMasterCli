using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace FifaLibrary
{
	// Token: 0x02000007 RID: 7
	public class FshSection
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00003E95 File Offset: 0x00002095
		public int Type
		{
			get
			{
				return this.m_Type;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00003E9D File Offset: 0x0000209D
		public FshSection NextSection
		{
			get
			{
				return this.m_NextSection;
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003EA8 File Offset: 0x000020A8
		public FshSection(Fsh parent, BinaryReader r, int maxSize)
		{
			this.m_Parent = parent;
			int num = r.ReadInt32();
			this.m_NextOffset = (num >> 8) & 16777215;
			maxSize -= this.m_NextOffset;
			this.m_Type = num & 127;
			this.m_IsCompressed = (num & 128) != 0;
			this.m_IsPalette = false;
			if (this.m_NextOffset != 0)
			{
				this.m_Size = this.m_NextOffset;
			}
			else
			{
				this.m_Size = maxSize;
			}
			int type = this.m_Type;
			if (type <= 98)
			{
				switch (type)
				{
				case 34:
				case 35:
					goto IL_02F9;
				case 36:
					break;
				default:
					switch (type)
					{
					case 41:
					case 43:
					case 44:
					case 45:
						goto IL_02F9;
					case 42:
						break;
					default:
						switch (type)
						{
						case 96:
						case 97:
						case 98:
							goto IL_0121;
						default:
							goto IL_02F9;
						}
						break;
					}
					break;
				}
				this.m_Width = r.ReadInt16();
				this.m_Height = r.ReadInt16();
				this.m_Misc[0] = r.ReadInt16();
				this.m_Misc[1] = r.ReadInt16();
				this.m_Misc[2] = r.ReadInt16();
				this.m_Misc[3] = r.ReadInt16();
				this.m_IsPalette = true;
				num = this.m_Size - 16;
				this.m_RawData = r.ReadBytes(num);
				goto IL_02F9;
			}
			if (type == 105)
			{
				this.m_Width = r.ReadInt16();
				this.m_Height = r.ReadInt16();
				this.m_Misc[0] = r.ReadInt16();
				this.m_Misc[1] = r.ReadInt16();
				this.m_Misc[2] = r.ReadInt16();
				this.m_Misc[3] = r.ReadInt16();
				num = this.m_Size - 16;
				this.m_RawData = r.ReadBytes(num);
				goto IL_02F9;
			}
			switch (type)
			{
			case 109:
				break;
			case 110:
				goto IL_02F9;
			case 111:
				this.m_Width = r.ReadInt16();
				this.m_Height = r.ReadInt16();
				num = this.m_Size - 8;
				this.m_RawData = r.ReadBytes(num);
				goto IL_02F9;
			case 112:
				num = this.m_Size - 4;
				this.m_RawData = r.ReadBytes(num);
				goto IL_02F9;
			default:
				switch (type)
				{
				case 120:
				case 123:
				case 125:
				case 126:
				case 127:
					break;
				case 121:
				case 122:
					goto IL_02F9;
				case 124:
					this.m_Width = r.ReadInt16();
					this.m_Height = r.ReadInt16();
					num = this.m_Size - 8;
					this.m_RawData = r.ReadBytes(num);
					goto IL_02F9;
				default:
					goto IL_02F9;
				}
				break;
			}
			IL_0121:
			this.m_Width = r.ReadInt16();
			this.m_Height = r.ReadInt16();
			this.m_Misc[0] = r.ReadInt16();
			this.m_Misc[1] = r.ReadInt16();
			this.m_Misc[2] = r.ReadInt16();
			this.m_Misc[3] = r.ReadInt16();
			this.m_NScales = (this.m_Misc[3] >> 12) & 15;
			num = this.m_Size - 16;
			this.m_RawData = r.ReadBytes(num);
			IL_02F9:
			if (this.m_NextOffset != 0)
			{
				this.m_NextSection = new FshSection(this.m_Parent, r, maxSize);
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000041CC File Offset: 0x000023CC
		public FshSection(BinaryReader r)
		{
			int num = (int)(r.BaseStream.Length - r.BaseStream.Position);
			this.m_RawData = r.ReadBytes(num);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00004214 File Offset: 0x00002414
		public void Save(BinaryWriter w)
		{
			int num = 0;
			num |= (this.m_NextOffset & 16777215) << 8;
			num |= (this.m_IsCompressed ? 128 : 0);
			num |= this.m_Type & 127;
			w.Write(num);
			int type = this.m_Type;
			if (type <= 98)
			{
				switch (type)
				{
				case 34:
				case 35:
					goto IL_018E;
				case 36:
					break;
				default:
					switch (type)
					{
					case 41:
					case 43:
					case 44:
					case 45:
						goto IL_018E;
					case 42:
						break;
					default:
						switch (type)
						{
						case 96:
						case 97:
						case 98:
							break;
						default:
							goto IL_018E;
						}
						break;
					}
					break;
				}
			}
			else if (type != 105)
			{
				switch (type)
				{
				case 109:
					goto IL_00DD;
				case 110:
					goto IL_018E;
				case 111:
					break;
				case 112:
					w.Write(this.m_RawData);
					goto IL_018E;
				default:
					switch (type)
					{
					case 120:
					case 123:
					case 125:
					case 126:
					case 127:
						goto IL_00DD;
					case 121:
					case 122:
						goto IL_018E;
					case 124:
						break;
					default:
						goto IL_018E;
					}
					break;
				}
				w.Write(this.m_Width);
				w.Write(this.m_Height);
				w.Write(this.m_RawData);
				goto IL_018E;
			}
			IL_00DD:
			w.Write(this.m_Width);
			w.Write(this.m_Height);
			w.Write(this.m_Misc[0]);
			w.Write(this.m_Misc[1]);
			w.Write(this.m_Misc[2]);
			this.m_Misc[3] = (short)((int)(this.m_Misc[3] & 4095) | (this.m_NScales << 12));
			w.Write(this.m_Misc[3]);
			w.Write(this.m_RawData);
			IL_018E:
			if (this.m_NextOffset != 0)
			{
				this.m_NextSection.Save(w);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000043C4 File Offset: 0x000025C4
		public Color[] RawDataToPalette()
		{
			if (this.m_IsPalette)
			{
				Color[] array = new Color[(int)this.m_Width];
				int type = this.m_Type;
				if (type != 36)
				{
					if (type != 42)
					{
						return null;
					}
					for (int i = 0; i < (int)this.m_Width; i++)
					{
						array[i] = Color.FromArgb((int)this.m_RawData[i * 4], (int)this.m_RawData[i * 4 + 1], (int)this.m_RawData[i * 4 + 2], (int)this.m_RawData[i * 4 + 3]);
					}
				}
				else
				{
					for (int j = 0; j < (int)this.m_Width; j++)
					{
						array[j] = Color.FromArgb((int)this.m_RawData[j * 3], (int)this.m_RawData[j * 3 + 1], (int)this.m_RawData[j * 3 + 2]);
					}
				}
				return array;
			}
			return null;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000449C File Offset: 0x0000269C
		public int ComputeRawDataLength(int width, int height)
		{
			int num = 0;
			int num2 = 0;
			for (int i = 0; i <= this.m_NScales; i++)
			{
				int type = this.m_Type;
				if (type <= 98)
				{
					switch (type)
					{
					case 34:
					case 35:
					case 36:
						break;
					default:
						switch (type)
						{
						case 41:
						case 42:
						case 43:
						case 44:
						case 45:
							break;
						default:
							switch (type)
							{
							case 96:
								num = (width + 3) / 4 * ((height + 3) / 4) * 8;
								break;
							case 97:
							case 98:
								num = (width + 3) / 4 * ((height + 3) / 4) * 16;
								break;
							}
							break;
						}
						break;
					}
				}
				else if (type != 105)
				{
					switch (type)
					{
					case 109:
						break;
					case 110:
					case 111:
					case 112:
						goto IL_00F4;
					default:
						switch (type)
						{
						case 120:
						case 126:
							break;
						case 121:
						case 122:
						case 124:
							goto IL_00F4;
						case 123:
							num = width * height;
							goto IL_00F4;
						case 125:
							num = width * height * 4;
							goto IL_00F4;
						case 127:
							num = width * height * 3;
							goto IL_00F4;
						default:
							goto IL_00F4;
						}
						break;
					}
					num = width * height * 2;
				}
				IL_00F4:
				num2 += num;
				width /= 2;
				height /= 2;
			}
			int num3 = num2 & 15;
			if (num3 != 0)
			{
				num2 += 16 - num3;
			}
			return num2;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000045CC File Offset: 0x000027CC
		public Bitmap RawDataToBmp()
		{
			bool isCompressed = this.m_IsCompressed;
			this.m_Bitmap = new Bitmap((int)this.m_Width, (int)this.m_Height, PixelFormat.Format32bppArgb);
			Stream stream = new MemoryStream(this.m_RawData);
			BinaryReader binaryReader = new BinaryReader(stream);
			new BinaryWriter(stream);
			int type = this.m_Type;
			switch (type)
			{
			case 96:
				this.ReadDxtToBitmap(1, binaryReader);
				break;
			case 97:
				this.ReadDxtToBitmap(3, binaryReader);
				break;
			case 98:
				this.ReadDxtToBitmap(5, binaryReader);
				break;
			default:
				if (type != 109)
				{
					switch (type)
					{
					case 120:
					{
						for (int i = 0; i < this.m_Bitmap.Height; i++)
						{
							for (int j = 0; j < this.m_Bitmap.Width; j++)
							{
								ushort num = binaryReader.ReadUInt16();
								int num2 = (int)((num & 31) * 8);
								int num3 = ((num >> 5) & 63) * 4;
								int num4 = ((num >> 11) & 31) * 8;
								this.m_Bitmap.SetPixel(j, i, Color.FromArgb(num4, num3, num2));
							}
						}
						break;
					}
					case 123:
					{
						for (FshSection fshSection = this.m_NextSection; fshSection != null; fshSection = fshSection.m_NextSection)
						{
							this.m_Palette = fshSection.RawDataToPalette();
							if (this.m_Palette != null)
							{
								break;
							}
						}
						if (this.m_Palette != null)
						{
							for (int k = 0; k < this.m_Bitmap.Height; k++)
							{
								for (int l = 0; l < this.m_Bitmap.Width; l++)
								{
									int num5 = (int)binaryReader.ReadByte();
									this.m_Bitmap.SetPixel(l, k, this.m_Palette[num5]);
								}
							}
						}
						break;
					}
					case 125:
					{
						Rectangle rectangle = new Rectangle(0, 0, this.m_Bitmap.Width, this.m_Bitmap.Height);
						BitmapData bitmapData = this.m_Bitmap.LockBits(rectangle, ImageLockMode.WriteOnly, this.m_Bitmap.PixelFormat);
						IntPtr scan = bitmapData.Scan0;
						int num6 = this.m_Bitmap.Width * this.m_Bitmap.Height;
						Marshal.Copy(this.m_RawData, 0, scan, num6 * 4);
						this.m_Bitmap.UnlockBits(bitmapData);
						break;
					}
					case 126:
					{
						for (int m = 0; m < this.m_Bitmap.Height; m++)
						{
							for (int n = 0; n < this.m_Bitmap.Width; n++)
							{
								ushort num7 = binaryReader.ReadUInt16();
								int num8 = (int)((num7 & 31) * 8);
								int num9 = ((num7 >> 5) & 31) * 8;
								int num10 = ((num7 >> 10) & 31) * 8;
								int num11 = (((num7 & 32768) != 0) ? 255 : 0);
								this.m_Bitmap.SetPixel(n, m, Color.FromArgb(num11, num10, num9, num8));
							}
						}
						break;
					}
					case 127:
					{
						for (int num12 = 0; num12 < this.m_Bitmap.Height; num12++)
						{
							for (int num13 = 0; num13 < this.m_Bitmap.Width; num13++)
							{
								int num14 = (int)binaryReader.ReadByte();
								int num15 = (int)binaryReader.ReadByte();
								int num16 = (int)binaryReader.ReadByte();
								this.m_Bitmap.SetPixel(num13, num12, Color.FromArgb(num16, num15, num14));
							}
						}
						break;
					}
					}
				}
				else
				{
					for (int num17 = 0; num17 < this.m_Bitmap.Height; num17++)
					{
						for (int num18 = 0; num18 < this.m_Bitmap.Width; num18++)
						{
							ushort num19 = binaryReader.ReadUInt16();
							int num20 = (int)((num19 & 15) * 16);
							int num21 = ((num19 >> 4) & 15) * 16;
							int num22 = ((num19 >> 8) & 15) * 16;
							int num23 = ((num19 >> 12) & 15) * 16;
							this.m_Bitmap.SetPixel(num18, num17, Color.FromArgb(num23, num22, num21, num20));
						}
					}
				}
				break;
			}
			return this.m_Bitmap;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000049AC File Offset: 0x00002BAC
		public bool WriteBitmap(Bitmap bitmap, BinaryWriter bw)
		{
			int type = this.m_Type;
			switch (type)
			{
			case 96:
				return this.WriteBitmapToDxt(bitmap, 1, bw);
			case 97:
				return this.WriteBitmapToDxt(bitmap, 3, bw);
			case 98:
				return this.WriteBitmapToDxt(bitmap, 5, bw);
			default:
				if (type != 109)
				{
					switch (type)
					{
					case 120:
					{
						for (int i = 0; i < bitmap.Height; i++)
						{
							for (int j = 0; j < bitmap.Width; j++)
							{
								Color pixel = bitmap.GetPixel(j, i);
								byte b = pixel.B;
								byte g = pixel.G;
								byte r = pixel.R;
								ushort num = 0;
								num |= (ushort)((b & 248) >> 3);
								num |= (ushort)((g & 252) << 3);
								num |= (ushort)((r & 248) << 8);
								bw.Write(num);
							}
						}
						break;
					}
					case 123:
					{
						if (this.m_Palette == null)
						{
							return false;
						}
						for (int k = 0; k < bitmap.Height; k++)
						{
							for (int l = 0; l < bitmap.Width; l++)
							{
								Color pixel2 = bitmap.GetPixel(l, k);
								byte b2 = 0;
								for (int m = 0; m < this.m_Palette.Length; m++)
								{
									if (pixel2 == this.m_Palette[m])
									{
										b2 = (byte)m;
										break;
									}
								}
								bw.Write(b2);
							}
						}
						break;
					}
					case 125:
					{
						for (int n = 0; n < bitmap.Height; n++)
						{
							for (int num2 = 0; num2 < bitmap.Width; num2++)
							{
								Color pixel3 = bitmap.GetPixel(num2, n);
								byte b3 = pixel3.B;
								byte g2 = pixel3.G;
								byte r2 = pixel3.R;
								byte a = pixel3.A;
								bw.Write(b3);
								bw.Write(g2);
								bw.Write(r2);
								bw.Write(a);
							}
						}
						break;
					}
					case 126:
					{
						for (int num3 = 0; num3 < bitmap.Height; num3++)
						{
							for (int num4 = 0; num4 < bitmap.Width; num4++)
							{
								Color pixel4 = bitmap.GetPixel(num4, num3);
								byte b4 = pixel4.B;
								byte g3 = pixel4.G;
								byte r3 = pixel4.R;
								byte a2 = pixel4.A;
								ushort num5 = 0;
								num5 |= (ushort)((b4 & 248) >> 3);
								num5 |= (ushort)((g3 & 248) << 2);
								num5 |= (ushort)((r3 & 248) << 7);
								if (a2 != 0)
								{
									num5 |= 32768;
								}
								bw.Write(num5);
							}
						}
						break;
					}
					case 127:
					{
						for (int num6 = 0; num6 < bitmap.Height; num6++)
						{
							for (int num7 = 0; num7 < bitmap.Width; num7++)
							{
								Color pixel5 = bitmap.GetPixel(num7, num6);
								byte b5 = pixel5.B;
								byte g4 = pixel5.G;
								byte r4 = pixel5.R;
								bw.Write(b5);
								bw.Write(g4);
								bw.Write(r4);
							}
						}
						break;
					}
					}
				}
				else
				{
					for (int num8 = 0; num8 < bitmap.Height; num8++)
					{
						for (int num9 = 0; num9 < bitmap.Width; num9++)
						{
							Color pixel6 = bitmap.GetPixel(num9, num8);
							byte b6 = pixel6.B;
							byte g5 = pixel6.G;
							byte r5 = pixel6.R;
							byte a3 = pixel6.A;
							ushort num10 = 0;
							num10 |= (ushort)((b6 & 240) >> 4);
							num10 |= (ushort)(g5 & 240);
							num10 |= (ushort)((r5 & 240) << 4);
							num10 |= (ushort)((a3 & 240) << 8);
							bw.Write(num10);
						}
					}
				}
				return true;
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004D9C File Offset: 0x00002F9C
		public bool BitmapToRawData()
		{
			int num = this.ComputeRawDataLength(this.m_Bitmap.Width, this.m_Bitmap.Height);
			if (num != this.m_RawData.Length)
			{
				this.m_RawData = new byte[num];
				this.m_Size = num + 16;
				if (this.m_NextSection != null)
				{
					this.m_NextOffset = this.m_Size;
				}
				else
				{
					this.m_NextOffset = 0;
				}
				this.m_Height = (short)this.m_Bitmap.Height;
				this.m_Width = (short)this.m_Bitmap.Width;
				this.m_Parent.ComputeImageDir();
			}
			Stream stream = new MemoryStream(this.m_RawData);
			BinaryWriter binaryWriter = new BinaryWriter(stream);
			Bitmap bitmap = this.m_Bitmap;
			int num2 = (1 << this.m_NScales) - 1;
			if (((this.m_Bitmap.Width & num2) | (this.m_Bitmap.Height & num2)) != 0)
			{
				this.m_NScales = 0;
			}
			for (int i = 0; i <= this.m_NScales; i++)
			{
				if (!this.WriteBitmap(bitmap, binaryWriter))
				{
					return false;
				}
				if (i < this.m_NScales)
				{
					bitmap = GraphicUtil.ReduceBitmap(bitmap);
					if (bitmap == null)
					{
						this.m_NScales = i - 1;
						break;
					}
				}
			}
			return true;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00004EC4 File Offset: 0x000030C4
		public bool ReplaceRawData(byte[] rawData, int width, int height)
		{
			int num = rawData.Length;
			if (num != this.m_RawData.Length)
			{
				this.m_RawData = new byte[num];
				this.m_Size = num + 16;
				if (this.m_NextSection != null)
				{
					this.m_NextOffset = this.m_Size;
				}
				else
				{
					this.m_NextOffset = 0;
				}
				this.m_Height = (short)width;
				this.m_Width = (short)height;
				this.m_Parent.ComputeImageDir();
			}
			for (int i = 0; i < this.m_RawData.Length; i++)
			{
				this.m_RawData[i] = rawData[i];
			}
			return true;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00004F50 File Offset: 0x00003150
		private void ReadDxtToBitmap(int dxtType, BinaryReader br)
		{
			DxtBlock dxtBlock = new DxtBlock(dxtType);
			Rectangle rectangle = new Rectangle(0, 0, this.m_Bitmap.Width, this.m_Bitmap.Height);
			BitmapData bitmapData = this.m_Bitmap.LockBits(rectangle, ImageLockMode.WriteOnly, this.m_Bitmap.PixelFormat);
			IntPtr scan = bitmapData.Scan0;
			int num = this.m_Bitmap.Width * this.m_Bitmap.Height;
			int[] array = new int[num];
			for (int i = 0; i < this.m_Bitmap.Height / 4; i++)
			{
				for (int j = 0; j < this.m_Bitmap.Width / 4; j++)
				{
					dxtBlock.Load(br);
					int num2 = i * 4 * this.m_Bitmap.Width;
					num2 += j * 4;
					array[num2] = dxtBlock.Colors[0, 0].ToArgb();
					array[num2 + 1] = dxtBlock.Colors[1, 0].ToArgb();
					array[num2 + 2] = dxtBlock.Colors[2, 0].ToArgb();
					array[num2 + 3] = dxtBlock.Colors[3, 0].ToArgb();
					num2 += this.m_Bitmap.Width;
					array[num2] = dxtBlock.Colors[0, 1].ToArgb();
					array[num2 + 1] = dxtBlock.Colors[1, 1].ToArgb();
					array[num2 + 2] = dxtBlock.Colors[2, 1].ToArgb();
					array[num2 + 3] = dxtBlock.Colors[3, 1].ToArgb();
					num2 += this.m_Bitmap.Width;
					array[num2] = dxtBlock.Colors[0, 2].ToArgb();
					array[num2 + 1] = dxtBlock.Colors[1, 2].ToArgb();
					array[num2 + 2] = dxtBlock.Colors[2, 2].ToArgb();
					array[num2 + 3] = dxtBlock.Colors[3, 2].ToArgb();
					num2 += this.m_Bitmap.Width;
					array[num2] = dxtBlock.Colors[0, 3].ToArgb();
					array[num2 + 1] = dxtBlock.Colors[1, 3].ToArgb();
					array[num2 + 2] = dxtBlock.Colors[2, 3].ToArgb();
					array[num2 + 3] = dxtBlock.Colors[3, 3].ToArgb();
				}
			}
			Marshal.Copy(array, 0, scan, num);
			this.m_Bitmap.UnlockBits(bitmapData);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000051FC File Offset: 0x000033FC
		private bool WriteBitmapToDxt(Bitmap bitmap, int dxtType, BinaryWriter bw)
		{
			if (((bitmap.Height & 3) | (bitmap.Width & 3)) != 0)
			{
				return false;
			}
			DxtBlock dxtBlock = new DxtBlock(dxtType);
			int num = (bitmap.Height + 3) / 4;
			int num2 = (bitmap.Width + 3) / 4;
			for (int i = 0; i < num; i++)
			{
				int num3 = i * 4;
				for (int j = 0; j < num2; j++)
				{
					int num4 = j * 4;
					dxtBlock.Colors[0, 0] = bitmap.GetPixel(num4, num3);
					dxtBlock.Colors[0, 1] = bitmap.GetPixel(num4, num3 + 1);
					dxtBlock.Colors[0, 2] = bitmap.GetPixel(num4, num3 + 2);
					dxtBlock.Colors[0, 3] = bitmap.GetPixel(num4, num3 + 3);
					dxtBlock.Colors[1, 0] = bitmap.GetPixel(num4 + 1, num3);
					dxtBlock.Colors[1, 1] = bitmap.GetPixel(num4 + 1, num3 + 1);
					dxtBlock.Colors[1, 2] = bitmap.GetPixel(num4 + 1, num3 + 2);
					dxtBlock.Colors[1, 3] = bitmap.GetPixel(num4 + 1, num3 + 3);
					dxtBlock.Colors[2, 0] = bitmap.GetPixel(num4 + 2, num3);
					dxtBlock.Colors[2, 1] = bitmap.GetPixel(num4 + 2, num3 + 1);
					dxtBlock.Colors[2, 2] = bitmap.GetPixel(num4 + 2, num3 + 2);
					dxtBlock.Colors[2, 3] = bitmap.GetPixel(num4 + 2, num3 + 3);
					dxtBlock.Colors[3, 0] = bitmap.GetPixel(num4 + 3, num3);
					dxtBlock.Colors[3, 1] = bitmap.GetPixel(num4 + 3, num3 + 1);
					dxtBlock.Colors[3, 2] = bitmap.GetPixel(num4 + 3, num3 + 2);
					dxtBlock.Colors[3, 3] = bitmap.GetPixel(num4 + 3, num3 + 3);
					dxtBlock.Save(bw);
				}
			}
			return true;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00005466 File Offset: 0x00003666
		public bool ReplaceBitmap(Bitmap bitmap)
		{
			if (bitmap == null)
			{
				return false;
			}
			this.m_Bitmap = bitmap;
			this.BitmapToRawData();
			return true;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000547C File Offset: 0x0000367C
		public void Hash(string fileName)
		{
			if (this.m_Type == 111)
			{
				char[] array = FifaUtil.ComputeHash(fileName).ToString("x8").ToCharArray();
				for (int i = 0; i < this.m_RawData.Length - 11; i++)
				{
					if (this.m_RawData[i] == 44 && this.m_RawData[i + 1] == 48 && this.m_RawData[i + 2] == 120)
					{
						i += 3;
						for (int j = 0; j < 8; j++)
						{
							this.m_RawData[i + j] = (byte)array[j];
						}
						return;
					}
				}
			}
		}

		// Token: 0x04000026 RID: 38
		private Fsh m_Parent;

		// Token: 0x04000027 RID: 39
		private int m_Type;

		// Token: 0x04000028 RID: 40
		public bool m_IsCompressed;

		// Token: 0x04000029 RID: 41
		public bool m_IsBitmap;

		// Token: 0x0400002A RID: 42
		public Bitmap m_Bitmap;

		// Token: 0x0400002B RID: 43
		public bool m_IsPalette;

		// Token: 0x0400002C RID: 44
		public Color[] m_Palette;

		// Token: 0x0400002D RID: 45
		public int m_NextOffset;

		// Token: 0x0400002E RID: 46
		public int m_Size;

		// Token: 0x0400002F RID: 47
		private FshSection m_NextSection;

		// Token: 0x04000030 RID: 48
		public short m_Width;

		// Token: 0x04000031 RID: 49
		public short m_Height;

		// Token: 0x04000032 RID: 50
		public short[] m_Misc = new short[4];

		// Token: 0x04000033 RID: 51
		public int m_NScales;

		// Token: 0x04000034 RID: 52
		public byte[] m_RawData;

		// Token: 0x04000035 RID: 53
		public byte[] PadData;
	}
}
