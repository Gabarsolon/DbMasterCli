using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000092 RID: 146
	public class Rx3ImageDirectory
	{
		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x0004AAB1 File Offset: 0x00048CB1
		// (set) Token: 0x06000B21 RID: 2849 RVA: 0x0004AAB9 File Offset: 0x00048CB9
		public int NFiles
		{
			get
			{
				return this.m_NFiles;
			}
			set
			{
				this.m_NFiles = value;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000B22 RID: 2850 RVA: 0x0004AAC2 File Offset: 0x00048CC2
		// (set) Token: 0x06000B23 RID: 2851 RVA: 0x0004AACA File Offset: 0x00048CCA
		public Rx3ImageHeader[] Rx3ImageHeader
		{
			get
			{
				return this.m_Rx3ImageHeader;
			}
			set
			{
				this.m_Rx3ImageHeader = value;
			}
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x0004AAD3 File Offset: 0x00048CD3
		public Rx3ImageDirectory(BinaryReader r, bool swapEndian)
		{
			this.m_SwapEndian = swapEndian;
			this.Load(r);
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x0004AAEC File Offset: 0x00048CEC
		public bool Load(BinaryReader r)
		{
			if (this.m_SwapEndian)
			{
				this.m_NFiles = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_Padding = r.ReadBytes(12);
				this.m_Rx3ImageHeader = new Rx3ImageHeader[this.m_NFiles];
				for (int i = 0; i < this.m_NFiles; i++)
				{
					this.m_Rx3ImageHeader[i] = new Rx3ImageHeader(r, this.m_SwapEndian);
				}
			}
			else
			{
				this.m_NFiles = r.ReadInt32();
				this.m_Padding = r.ReadBytes(12);
				this.m_Rx3ImageHeader = new Rx3ImageHeader[this.m_NFiles];
				for (int j = 0; j < this.m_NFiles; j++)
				{
					this.m_Rx3ImageHeader[j] = new Rx3ImageHeader(r, this.m_SwapEndian);
				}
			}
			return true;
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x0004ABAC File Offset: 0x00048DAC
		public bool Save(BinaryWriter w)
		{
			if (this.m_SwapEndian)
			{
				w.Write(FifaUtil.SwapEndian(this.m_NFiles));
				w.Write(this.m_Padding);
				for (int i = 0; i < this.m_NFiles; i++)
				{
					this.m_Rx3ImageHeader[i].Save(w);
				}
			}
			else
			{
				w.Write(this.m_NFiles);
				w.Write(this.m_Padding);
				for (int j = 0; j < this.m_NFiles; j++)
				{
					this.m_Rx3ImageHeader[j].Save(w);
				}
			}
			return true;
		}

		// Token: 0x04000FB1 RID: 4017
		private int m_NFiles;

		// Token: 0x04000FB2 RID: 4018
		private byte[] m_Padding;

		// Token: 0x04000FB3 RID: 4019
		private Rx3ImageHeader[] m_Rx3ImageHeader;

		// Token: 0x04000FB4 RID: 4020
		private bool m_SwapEndian;
	}
}
