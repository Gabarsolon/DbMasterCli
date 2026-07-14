using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000097 RID: 151
	public class Rx3IndexArray
	{
		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000B46 RID: 2886 RVA: 0x0004B2EC File Offset: 0x000494EC
		// (set) Token: 0x06000B47 RID: 2887 RVA: 0x0004B2F3 File Offset: 0x000494F3
		public static Rx3IndexArray.ETriangleListType TriangleListType
		{
			get
			{
				return Rx3IndexArray.s_TriangleListType;
			}
			set
			{
				Rx3IndexArray.s_TriangleListType = value;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000B48 RID: 2888 RVA: 0x0004B2FB File Offset: 0x000494FB
		public int NIndex
		{
			get
			{
				return this.m_nIndex;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x0004B303 File Offset: 0x00049503
		public int nFaces
		{
			get
			{
				return this.m_nFaces;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000B4A RID: 2890 RVA: 0x0004B30B File Offset: 0x0004950B
		public short[] IndexStream
		{
			get
			{
				return this.m_IndexStream;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x0004B313 File Offset: 0x00049513
		public bool IsTriangleList
		{
			get
			{
				return this.m_IsTriangleList;
			}
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x0004B31B File Offset: 0x0004951B
		public Rx3IndexArray(BinaryReader r, bool swapEndian)
		{
			this.m_SwapEndian = swapEndian;
			this.Load(r);
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x0004B334 File Offset: 0x00049534
		public bool Load(BinaryReader r)
		{
			if (this.m_SwapEndian)
			{
				this.m_Size = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_nIndex = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_SizeOfIndex = r.ReadInt32();
				this.m_Unknown = r.ReadInt32();
				this.m_IndexStream = new short[this.m_nIndex];
				for (int i = 0; i < this.m_nIndex; i++)
				{
					this.m_IndexStream[i] = FifaUtil.SwapEndian(r.ReadInt16());
				}
			}
			else
			{
				this.m_Size = r.ReadInt32();
				this.m_nIndex = r.ReadInt32();
				this.m_SizeOfIndex = r.ReadInt32();
				this.m_Unknown = r.ReadInt32();
				this.m_IndexStream = new short[this.m_nIndex];
				for (int j = 0; j < this.m_nIndex; j++)
				{
					this.m_IndexStream[j] = r.ReadInt16();
				}
			}
			this.m_IsTriangleList = false;
			this.m_nFaces = this.m_nIndex / 3;
			if (this.m_nFaces * 3 != this.m_nIndex)
			{
				this.m_IsTriangleList = true;
			}
			else
			{
				for (int k = 0; k < this.nFaces; k++)
				{
					short num = this.m_IndexStream[k * 3];
					short num2 = this.m_IndexStream[k * 3 + 1];
					short num3 = this.m_IndexStream[k * 3 + 2];
					if (num == num2 || num2 == num3 || num == num3)
					{
						this.m_IsTriangleList = true;
						break;
					}
				}
			}
			if (this.m_IsTriangleList)
			{
				this.m_nFaces = 0;
				for (int l = 0; l < this.m_nIndex - 2; l++)
				{
					short num4 = this.m_IndexStream[l];
					short num5 = this.m_IndexStream[l + 1];
					short num6 = this.m_IndexStream[l + 2];
					if (num4 != num5 && num5 != num6 && num4 != num6)
					{
						this.m_nFaces++;
					}
				}
			}
			return true;
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x0004B508 File Offset: 0x00049708
		public bool Save(BinaryWriter w)
		{
			if (this.m_SwapEndian)
			{
				w.Write(FifaUtil.SwapEndian(this.m_Size));
				w.Write(FifaUtil.SwapEndian(this.m_nIndex));
				w.Write(this.m_SizeOfIndex);
				w.Write(this.m_Unknown);
				for (int i = 0; i < this.m_nIndex; i++)
				{
					w.Write(FifaUtil.SwapEndian(this.m_IndexStream[i]));
				}
			}
			else
			{
				w.Write(this.m_Size);
				w.Write(this.m_nIndex);
				w.Write(this.m_SizeOfIndex);
				w.Write(this.m_Unknown);
				for (int j = 0; j < this.m_nIndex; j++)
				{
					w.Write(this.m_IndexStream[j]);
				}
			}
			return true;
		}

		// Token: 0x04000FCA RID: 4042
		private static Rx3IndexArray.ETriangleListType s_TriangleListType;

		// Token: 0x04000FCB RID: 4043
		private int m_Size;

		// Token: 0x04000FCC RID: 4044
		private int m_nIndex;

		// Token: 0x04000FCD RID: 4045
		private int m_SizeOfIndex;

		// Token: 0x04000FCE RID: 4046
		private int m_Unknown;

		// Token: 0x04000FCF RID: 4047
		private int m_nFaces;

		// Token: 0x04000FD0 RID: 4048
		private short[] m_IndexStream;

		// Token: 0x04000FD1 RID: 4049
		private bool m_IsTriangleList;

		// Token: 0x04000FD2 RID: 4050
		private bool m_SwapEndian;

		// Token: 0x02000098 RID: 152
		public enum ETriangleListType
		{
			// Token: 0x04000FD4 RID: 4052
			InvertOdd,
			// Token: 0x04000FD5 RID: 4053
			InvertEven
		}
	}
}
