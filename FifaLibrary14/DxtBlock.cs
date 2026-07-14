using System;
using System.Drawing;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200000B RID: 11
	public class DxtBlock
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000064FC File Offset: 0x000046FC
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00006504 File Offset: 0x00004704
		public Color[,] Colors
		{
			get
			{
				return this.m_Colors;
			}
			set
			{
				this.m_Colors = value;
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00006510 File Offset: 0x00004710
		public DxtBlock(int dxtType)
		{
			this.m_ColorLut = new int[4, 4];
			this.m_AlfaLut = new int[4, 4];
			this.m_Colors = new Color[4, 4];
			this.m_Alfa = new int[4, 4];
			this.Init(dxtType);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000655E File Offset: 0x0000475E
		public DxtBlock(int dxtType, BinaryReader br)
		{
			this.m_DxtType = (EImageType)dxtType;
			this.m_ColorLut = new int[4, 4];
			this.m_Colors = new Color[4, 4];
			this.Load(br);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00006590 File Offset: 0x00004790
		public void Load(BinaryReader br)
		{
			switch (this.m_DxtType)
			{
			case EImageType.DXT1:
				this.ReadColorLut(br);
				break;
			case EImageType.DXT3:
				this.ReadAlfaChannel(br);
				this.ReadColorLut(br);
				break;
			case EImageType.DXT5:
				this.ReadAlfaLut(br);
				this.ReadColorLut(br);
				break;
			default:
				return;
			}
			this.ConvertTo4x4();
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000065E4 File Offset: 0x000047E4
		public void Save(BinaryWriter bw)
		{
			this.ConvertFrom4x4();
			switch (this.m_DxtType)
			{
			case EImageType.DXT1:
				this.WriteColorLut(bw);
				return;
			case EImageType.DXT3:
				this.WriteAlfaChannel(bw);
				this.WriteColorLut(bw);
				return;
			case EImageType.DXT5:
				this.WriteAlfaLut(bw);
				this.WriteColorLut(bw);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00006638 File Offset: 0x00004838
		private void Init(int dxtType)
		{
			this.m_DxtType = (EImageType)dxtType;
			this.m_Col0 = 0;
			this.m_Col1 = 0;
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					this.m_ColorLut[i, j] = 0;
					this.m_Alfa[i, j] = 255;
					this.m_Colors[i, j] = Color.FromArgb(0, 0, 0);
				}
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000066AC File Offset: 0x000048AC
		private void ReadAlfaChannel(BinaryReader br)
		{
			for (int i = 0; i < 4; i++)
			{
				int num = (int)br.ReadInt16();
				this.m_Alfa[0, i] = (num & 15) << 4;
				this.m_Alfa[1, i] = ((num >> 4) & 15) << 4;
				this.m_Alfa[2, i] = ((num >> 8) & 15) << 4;
				this.m_Alfa[3, i] = ((num >> 12) & 15) << 4;
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00006720 File Offset: 0x00004920
		private void ReadColorLut(BinaryReader br)
		{
			this.m_Col0 = br.ReadUInt16();
			this.m_Col1 = br.ReadUInt16();
			for (int i = 0; i < 4; i++)
			{
				byte b = br.ReadByte();
				this.m_ColorLut[0, i] = (int)(b & 3);
				this.m_ColorLut[1, i] = (b >> 2) & 3;
				this.m_ColorLut[2, i] = (b >> 4) & 3;
				this.m_ColorLut[3, i] = (b >> 6) & 3;
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000067A0 File Offset: 0x000049A0
		private void ReadAlfaLut(BinaryReader br)
		{
			this.m_Alfa0 = br.ReadByte();
			this.m_Alfa1 = br.ReadByte();
			byte[] array = br.ReadBytes(6);
			ulong num = 0UL;
			for (int i = 5; i >= 0; i--)
			{
				num = (num * 256UL) | (ulong)array[i];
			}
			for (int j = 0; j < 4; j++)
			{
				for (int k = 0; k < 4; k++)
				{
					this.m_AlfaLut[k, j] = (int)(num & 7UL);
					num >>= 3;
				}
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00006820 File Offset: 0x00004A20
		private void WriteAlfaChannel(BinaryWriter bw)
		{
			for (int i = 0; i < 4; i++)
			{
				ushort num = (ushort)((this.m_Alfa[0, i] & 240) >> 4);
				num |= (ushort)(this.m_Alfa[1, i] & 240);
				num |= (ushort)((this.m_Alfa[2, i] & 240) << 4);
				num |= (ushort)((this.m_Alfa[3, i] & 240) << 8);
				bw.Write(num);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000068A8 File Offset: 0x00004AA8
		private void WriteColorLut(BinaryWriter bw)
		{
			bw.Write(this.m_Col0);
			bw.Write(this.m_Col1);
			for (int i = 0; i < 4; i++)
			{
				byte b = (byte)(this.m_ColorLut[0, i] & 3);
				b |= (byte)((this.m_ColorLut[1, i] & 3) << 2);
				b |= (byte)((this.m_ColorLut[2, i] & 3) << 4);
				b |= (byte)((this.m_ColorLut[3, i] & 3) << 6);
				bw.Write(b);
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00006938 File Offset: 0x00004B38
		private void WriteAlfaLut(BinaryWriter bw)
		{
			bw.Write(this.m_Alfa0);
			bw.Write(this.m_Alfa1);
			ulong num = 0UL;
			for (int i = 3; i >= 0; i--)
			{
				for (int j = 3; j >= 0; j--)
				{
					num <<= 3;
					num |= (ulong)(this.m_AlfaLut[j, i] & 7);
				}
			}
			byte[] array = new byte[6];
			for (int k = 0; k < 6; k++)
			{
				array[k] = (byte)(num & 255UL);
				num >>= 8;
			}
			bw.Write(array);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000069C0 File Offset: 0x00004BC0
		private void CleanLuts()
		{
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					this.m_AlfaLut[i, j] = 0;
					this.m_ColorLut[i, j] = 0;
				}
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00006A04 File Offset: 0x00004C04
		private void ConvertFrom4x4()
		{
			Color[] array = new Color[16];
			bool flag = false;
			int num = 0;
			int num2 = 255;
			int num3 = 0;
			int num4 = 4;
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					uint num5 = (uint)this.m_Colors[i, j].ToArgb();
					num5 &= 4294507768U;
					this.m_Colors[i, j] = Color.FromArgb((int)num5);
				}
			}
			for (int k = 0; k < 4; k++)
			{
				int l = 0;
				while (l < 4)
				{
					bool flag2 = false;
					if (this.m_DxtType == EImageType.DXT1)
					{
						if (this.m_Colors[k, l].A != 0)
						{
							goto IL_0108;
						}
						flag = true;
						num4 = 3;
					}
					else
					{
						if ((int)this.m_Colors[k, l].A < num2)
						{
							num2 = (int)this.m_Colors[k, l].A;
						}
						if ((int)this.m_Colors[k, l].A > num3)
						{
							num3 = (int)this.m_Colors[k, l].A;
							goto IL_0108;
						}
						goto IL_0108;
					}
					IL_01AE:
					l++;
					continue;
					IL_0108:
					for (int m = 0; m < num; m++)
					{
						if (this.m_Colors[k, l].R == array[m].R && this.m_Colors[k, l].G == array[m].G && this.m_Colors[k, l].B == array[m].B)
						{
							flag2 = true;
							break;
						}
					}
					if (!flag2)
					{
						array[num] = this.m_Colors[k, l];
						num++;
						goto IL_01AE;
					}
					goto IL_01AE;
				}
			}
			int num6 = 16777215;
			this.m_TempLut = new int[4, 4];
			if (this.m_DxtType == EImageType.DXT1 && flag)
			{
				if (num == 0)
				{
					for (int n = 0; n < 4; n++)
					{
						for (int num7 = 0; num7 < 4; num7++)
						{
							this.m_ColorLut[n, num7] = 3;
						}
					}
					this.m_Col0 = 0;
					this.m_Col1 = 0;
					return;
				}
				if (num == 1)
				{
					for (int num8 = 0; num8 < 4; num8++)
					{
						for (int num9 = 0; num9 < 4; num9++)
						{
							if (this.m_Colors[num8, num9].A == 0)
							{
								this.m_ColorLut[num8, num9] = 3;
							}
							else
							{
								this.m_ColorLut[num8, num9] = 0;
							}
						}
					}
					this.m_Col0 = (this.m_Col1 = (ushort)(((int)(array[0].R & 248) << 8) | ((int)(array[0].G & 252) << 3) | ((array[0].B & 248) >> 3)));
					return;
				}
				if (num == 2)
				{
					this.m_Col0 = (ushort)(((int)(array[0].R & 248) << 8) | ((int)(array[0].G & 252) << 3) | ((array[0].B & 248) >> 3));
					this.m_Col1 = (ushort)(((int)(array[1].R & 248) << 8) | ((int)(array[1].G & 252) << 3) | ((array[1].B & 248) >> 3));
					if (this.m_Col0 >= this.m_Col1)
					{
						ushort col = this.m_Col0;
						this.m_Col0 = this.m_Col1;
						this.m_Col1 = col;
						Color color = array[0];
						array[0] = array[1];
						array[1] = color;
					}
					for (int num10 = 0; num10 < 4; num10++)
					{
						for (int num11 = 0; num11 < 4; num11++)
						{
							if (this.m_Colors[num10, num11].A == 0)
							{
								this.m_ColorLut[num10, num11] = 3;
							}
							else if (this.m_Colors[num10, num11] == array[0])
							{
								this.m_ColorLut[num10, num11] = 0;
							}
							else
							{
								this.m_ColorLut[num10, num11] = 1;
							}
						}
					}
					return;
				}
			}
			this.CleanLuts();
			if (num3 == 0 && num2 == 0)
			{
				this.m_Alfa0 = 0;
				this.m_Col0 = 0;
				this.m_Alfa1 = 1;
				this.m_Col1 = 1;
				num = 0;
			}
			if (num == 1)
			{
				for (int num12 = 0; num12 < 4; num12++)
				{
					for (int num13 = 0; num13 < 4; num13++)
					{
						this.m_ColorLut[num12, num13] = 0;
					}
				}
				this.m_Col0 = (this.m_Col1 = (ushort)(((int)(array[0].R & 248) << 8) | ((int)(array[0].G & 252) << 3) | ((array[0].B & 248) >> 3)));
			}
			for (int num14 = 0; num14 < num; num14++)
			{
				for (int num15 = num14 + 1; num15 < num; num15++)
				{
					ushort num16 = (ushort)(((int)(array[num14].R & 248) << 8) | ((int)(array[num14].G & 252) << 3) | ((array[num14].B & 248) >> 3));
					ushort num17 = (ushort)(((int)(array[num15].R & 248) << 8) | ((int)(array[num15].G & 252) << 3) | ((array[num15].B & 248) >> 3));
					ushort num18;
					ushort num19;
					int num20;
					int num21;
					if (num16 < num17)
					{
						num18 = num16;
						num19 = num17;
						num20 = num14;
						num21 = num15;
					}
					else
					{
						num18 = num17;
						num19 = num16;
						num20 = num15;
						num21 = num14;
					}
					if (num4 == 4)
					{
						int num22 = this.ScoreColors(array[num21], array[num20], num4);
						if (num22 < num6)
						{
							num6 = num22;
							for (int num23 = 0; num23 < 4; num23++)
							{
								for (int num24 = 0; num24 < 4; num24++)
								{
									this.m_ColorLut[num23, num24] = this.m_TempLut[num23, num24];
								}
							}
							this.m_Col0 = num19;
							this.m_Col1 = num18;
							if (num22 == 0)
							{
								break;
							}
						}
					}
					if (this.m_DxtType == EImageType.DXT1)
					{
						int num22 = this.ScoreColors(array[num20], array[num21], 3);
						if (num22 < num6)
						{
							num6 = num22;
							for (int num25 = 0; num25 < 4; num25++)
							{
								for (int num26 = 0; num26 < 4; num26++)
								{
									this.m_ColorLut[num25, num26] = this.m_TempLut[num25, num26];
								}
							}
							this.m_Col0 = num18;
							this.m_Col1 = num19;
							if (num22 == 0)
							{
								break;
							}
						}
					}
				}
			}
			if (this.m_DxtType == EImageType.DXT3 || this.m_DxtType == EImageType.DXT3)
			{
				for (int num27 = 0; num27 < 4; num27++)
				{
					for (int num28 = 0; num28 < 4; num28++)
					{
						this.m_Alfa[num27, num28] = (int)(this.m_Colors[num27, num28].A & 240);
					}
				}
			}
			if (this.m_DxtType == EImageType.DXT5 || this.m_DxtType == EImageType.DXT5)
			{
				if (num2 == 0 && num3 == 0)
				{
					return;
				}
				this.m_Alfa1 = (byte)num2;
				this.m_Alfa0 = (byte)num3;
				int num29 = num3 - num2;
				int[] array2 = new int[8];
				if (num29 != 0)
				{
					for (int num30 = 2; num30 < 8; num30++)
					{
						array2[num30] = ((int)this.m_Alfa0 * (8 - num30) + (int)this.m_Alfa1 * (num30 - 1)) / 7;
					}
				}
				int num31 = num29 / 7 / 2;
				for (int num32 = 0; num32 < 4; num32++)
				{
					for (int num33 = 0; num33 < 4; num33++)
					{
						int a = (int)this.m_Colors[num32, num33].A;
						if (a <= num2 + num31)
						{
							this.m_AlfaLut[num32, num33] = 1;
						}
						else if (a >= num3 - num31)
						{
							this.m_AlfaLut[num32, num33] = 0;
						}
						else if (num29 != 0)
						{
							this.m_AlfaLut[num32, num33] = 0;
							for (int num34 = 2; num34 < 8; num34++)
							{
								if (a > array2[num34] - num31)
								{
									this.m_AlfaLut[num32, num33] = num34;
									break;
								}
							}
						}
						else
						{
							this.m_AlfaLut[num32, num33] = 0;
						}
					}
				}
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000072BC File Offset: 0x000054BC
		private void ConvertTo4x4()
		{
			int[] array = new int[8];
			array[0] = (int)this.m_Alfa0;
			array[1] = (int)this.m_Alfa1;
			if (this.m_DxtType == EImageType.DXT5)
			{
				if (this.m_Alfa0 > this.m_Alfa1)
				{
					for (int i = 2; i < 8; i++)
					{
						array[i] = ((int)this.m_Alfa0 * (8 - i) + (int)this.m_Alfa1 * (i - 1)) / 7;
					}
				}
				else
				{
					for (int j = 2; j < 6; j++)
					{
						array[j] = ((int)this.m_Alfa0 * (6 - j) + (int)this.m_Alfa1 * (j - 1)) / 5;
					}
					array[6] = 0;
					array[7] = 255;
				}
			}
			if (this.m_DxtType == EImageType.DXT5)
			{
				for (int k = 0; k < 4; k++)
				{
					for (int l = 0; l < 4; l++)
					{
						int num = this.m_AlfaLut[k, l];
						this.m_Alfa[k, l] = array[num];
					}
				}
			}
			if (this.m_DxtType == EImageType.DXT1)
			{
				for (int m = 0; m < 4; m++)
				{
					for (int n = 0; n < 4; n++)
					{
						int num2 = this.m_ColorLut[m, n];
						if (this.m_Col0 <= this.m_Col1 && num2 == 3)
						{
							this.m_Alfa[m, n] = 0;
						}
						else
						{
							this.m_Alfa[m, n] = 255;
						}
					}
				}
			}
			int[] array2 = new int[4];
			int[] array3 = new int[4];
			int[] array4 = new int[4];
			array4[0] = (int)(8 * (this.m_Col0 & 31));
			array3[0] = 4 * ((this.m_Col0 >> 5) & 63);
			array2[0] = 8 * (this.m_Col0 >> 11);
			array4[1] = (int)(8 * (this.m_Col1 & 31));
			array3[1] = 4 * ((this.m_Col1 >> 5) & 63);
			array2[1] = 8 * (this.m_Col1 >> 11);
			if (this.m_Col0 > this.m_Col1 || this.m_DxtType != EImageType.DXT1)
			{
				array2[2] = (2 * array2[0] + array2[1]) / 3;
				array3[2] = (2 * array3[0] + array3[1]) / 3;
				array4[2] = (2 * array4[0] + array4[1]) / 3;
				array2[3] = (array2[0] + 2 * array2[1]) / 3;
				array3[3] = (array3[0] + 2 * array3[1]) / 3;
				array4[3] = (array4[0] + 2 * array4[1]) / 3;
			}
			else
			{
				array2[2] = (array2[0] + array2[1]) / 2;
				array3[2] = (array3[0] + array3[1]) / 2;
				array4[2] = (array4[0] + array4[1]) / 2;
				array2[3] = 0;
				array3[3] = 0;
				array4[3] = 0;
			}
			for (int num3 = 0; num3 < 4; num3++)
			{
				for (int num4 = 0; num4 < 4; num4++)
				{
					int num5 = this.m_ColorLut[num3, num4];
					this.m_Colors[num3, num4] = Color.FromArgb(this.m_Alfa[num3, num4], array2[num5], array3[num5], array4[num5]);
				}
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000075A4 File Offset: 0x000057A4
		private int[] ComputeInterpolatedAlfa(int alfa0, int alfa1)
		{
			int[] array = new int[8];
			array[0] = alfa0;
			array[1] = alfa1;
			for (int i = 2; i < 8; i++)
			{
				int num = 8 - i;
				int num2 = i - 1;
				array[i] = (num * alfa0 + num2 * alfa1) / 7;
			}
			return array;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000075E4 File Offset: 0x000057E4
		private int[,] ComputeInterpolatedRgb(Color col0, Color col1, int nColors)
		{
			int[,] array = new int[4, 3];
			array[0, 0] = (int)col0.R;
			array[0, 1] = (int)col0.G;
			array[0, 2] = (int)col0.B;
			array[1, 0] = (int)col1.R;
			array[1, 1] = (int)col1.G;
			array[1, 2] = (int)col1.B;
			if (nColors <= 3)
			{
				nColors = 3;
				for (int i = 2; i < nColors; i++)
				{
					int num = nColors - i;
					int num2 = i - 1;
					array[i, 0] = (num * (int)col0.R + num2 * (int)col1.R) / 2;
					array[i, 1] = (num * (int)col0.G + num2 * (int)col1.G) / 2;
					array[i, 2] = (num * (int)col0.B + num2 * (int)col1.B) / 2;
				}
				array[3, 0] = 0;
				array[3, 1] = 0;
				array[3, 2] = 0;
			}
			else
			{
				nColors = 4;
				for (int j = 2; j < nColors; j++)
				{
					int num3 = nColors - j;
					int num4 = j - 1;
					array[j, 0] = (num3 * (int)col0.R + num4 * (int)col1.R) / 3;
					array[j, 1] = (num3 * (int)col0.G + num4 * (int)col1.G) / 3;
					array[j, 2] = (num3 * (int)col0.B + num4 * (int)col1.B) / 3;
				}
			}
			return array;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00007768 File Offset: 0x00005968
		private int ScoreColors(Color col0, Color col1, int nColors)
		{
			int[,] array = this.ComputeInterpolatedRgb(col0, col1, nColors);
			int num = 0;
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					int num2 = 16777215;
					int r = (int)this.m_Colors[i, j].R;
					int g = (int)this.m_Colors[i, j].G;
					int b = (int)this.m_Colors[i, j].B;
					if (this.m_Colors[i, j].A == 0 && nColors == 3)
					{
						this.m_TempLut[i, j] = 3;
					}
					else
					{
						for (int k = 0; k < nColors; k++)
						{
							int num3 = array[k, 0] - r;
							int num4 = array[k, 1] - g;
							int num5 = array[k, 2] - b;
							int num6 = num3 * num3 + num4 * num4 + num5 * num5;
							if (num6 < num2)
							{
								num2 = num6;
								this.m_TempLut[i, j] = k;
								if (num6 == 0)
								{
									break;
								}
							}
						}
						num += num2;
					}
				}
			}
			return num;
		}

		// Token: 0x04000043 RID: 67
		private EImageType m_DxtType;

		// Token: 0x04000044 RID: 68
		private ushort m_Col0;

		// Token: 0x04000045 RID: 69
		private ushort m_Col1;

		// Token: 0x04000046 RID: 70
		private byte m_Alfa0;

		// Token: 0x04000047 RID: 71
		private byte m_Alfa1;

		// Token: 0x04000048 RID: 72
		private int[,] m_ColorLut;

		// Token: 0x04000049 RID: 73
		private int[,] m_AlfaLut;

		// Token: 0x0400004A RID: 74
		private int[,] m_Alfa;

		// Token: 0x0400004B RID: 75
		private int[,] m_TempLut;

		// Token: 0x0400004C RID: 76
		private Color[,] m_Colors;
	}
}
