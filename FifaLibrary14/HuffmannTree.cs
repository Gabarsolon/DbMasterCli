using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000061 RID: 97
	public class HuffmannTree
	{
		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x00031F36 File Offset: 0x00030136
		// (set) Token: 0x06000864 RID: 2148 RVA: 0x00031F3E File Offset: 0x0003013E
		public int NNodes
		{
			get
			{
				return this.m_NNodes;
			}
			set
			{
				this.m_NNodes = value;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x00031F47 File Offset: 0x00030147
		public int Size
		{
			get
			{
				return this.m_NNodes * 4;
			}
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00031F54 File Offset: 0x00030154
		public HuffmannTree(int nNodes)
		{
			this.m_NNodes = nNodes;
			this.m_Child = new byte[this.m_NNodes, 2];
			this.m_Leaf = new byte[this.m_NNodes, 2];
			for (int i = 0; i < this.m_NNodes; i++)
			{
				this.m_Child[i, 0] = 0;
				this.m_Child[i, 1] = 0;
				this.m_Leaf[i, 0] = 0;
				this.m_Leaf[i, 1] = 0;
			}
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00031FFC File Offset: 0x000301FC
		public void Load(DbReader r)
		{
			for (int i = 0; i < this.m_NNodes; i++)
			{
				this.m_Child[i, 0] = r.ReadByte();
				this.m_Leaf[i, 0] = r.ReadByte();
				this.m_Child[i, 1] = r.ReadByte();
				this.m_Leaf[i, 1] = r.ReadByte();
			}
			this.BuildEncodingTable();
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x0003206C File Offset: 0x0003026C
		public void Save(BinaryWriter w)
		{
			for (int i = 0; i < this.m_NNodes; i++)
			{
				w.Write(this.m_Child[i, 0]);
				w.Write(this.m_Leaf[i, 0]);
				w.Write(this.m_Child[i, 1]);
				w.Write(this.m_Leaf[i, 1]);
			}
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x000320D8 File Offset: 0x000302D8
		private void BuildEncodingTable()
		{
			ushort[] array = new ushort[this.m_NNodes];
			byte[] array2 = new byte[this.m_NNodes];
			for (int i = 0; i < this.m_NNodes; i++)
			{
				ushort num = (ushort)(array[i] * 2);
				byte b = (byte)(array2[i] + 1);
				byte b2 = this.m_Child[i, 0];
				if (b2 != 0)
				{
					array[(int)b2] = num;
					array2[(int)b2] = b;
				}
				else
				{
					byte b3 = this.m_Leaf[i, 0];
					this.m_EncodingValue[(int)b3] = num;
					this.m_nBitsForEncoding[(int)b3] = b;
				}
				num += 1;
				byte b4 = this.m_Child[i, 1];
				if (b4 != 0)
				{
					array[(int)b4] = num;
					array2[(int)b4] = b;
				}
				else
				{
					byte b5 = this.m_Leaf[i, 1];
					this.m_EncodingValue[(int)b5] = num;
					this.m_nBitsForEncoding[(int)b5] = b;
				}
			}
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x000321B0 File Offset: 0x000303B0
		public string ReadString(DbReader r, int outputLength)
		{
			int num = 0;
			int num2 = 0;
			if (outputLength <= 0)
			{
				return string.Empty;
			}
			byte[] array;
			if (this.m_NNodes == 0)
			{
				array = r.ReadBytes(outputLength);
			}
			else
			{
				array = new byte[outputLength];
				do
				{
					byte b = r.ReadByte();
					for (int i = 7; i >= 0; i--)
					{
						int num3 = (b >> i) & 1;
						int num4 = (int)this.m_Child[num2, num3];
						if (num4 == 0)
						{
							array[num++] = this.m_Leaf[num2, num3];
							if (num == outputLength)
							{
								break;
							}
							num2 = 0;
						}
						else
						{
							num2 = num4;
						}
					}
				}
				while (num < outputLength);
			}
			return FifaUtil.ConvertBytesToString(array);
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00032248 File Offset: 0x00030448
		public int WriteString(BinaryWriter w, string str, bool longString)
		{
			if (str == null || str.Length == 0)
			{
				return 0;
			}
			byte[] array = FifaUtil.ConvertStringToBytes(str);
			int num2;
			if (longString)
			{
				ushort num = (ushort)array.Length;
				w.Write(FifaUtil.SwapEndian(num));
				num2 = 2;
			}
			else
			{
				w.Write((byte)array.Length);
				num2 = 1;
			}
			if (this.m_NNodes == 0)
			{
				w.Write(array);
				return num2 + array.Length;
			}
			int num3 = 7;
			byte b = 0;
			foreach (byte b2 in array)
			{
				int num4 = (int)this.m_EncodingValue[(int)b2];
				int num5 = (int)this.m_nBitsForEncoding[(int)b2];
				if (num5 == 0)
				{
					num4 = (int)this.m_EncodingValue[32];
					num5 = (int)this.m_nBitsForEncoding[32];
				}
				for (int j = num5 - 1; j >= 0; j--)
				{
					int num6 = num4 & (1 << j);
					if (num6 != 0)
					{
						b = (byte)((int)b + (1 << num3));
					}
					num3--;
					if (num3 == -1)
					{
						num3 = 7;
						w.Write(b);
						num2++;
						b = 0;
					}
				}
			}
			w.Write(b);
			return num2 + 1;
		}

		// Token: 0x04000379 RID: 889
		private byte[,] m_Child;

		// Token: 0x0400037A RID: 890
		private byte[,] m_Leaf;

		// Token: 0x0400037B RID: 891
		private ushort[] m_EncodingValue = new ushort[256];

		// Token: 0x0400037C RID: 892
		private byte[] m_nBitsForEncoding = new byte[256];

		// Token: 0x0400037D RID: 893
		private int m_NNodes;
	}
}
