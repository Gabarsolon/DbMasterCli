using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000093 RID: 147
	public class Rx3ModelDirectory
	{
		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x0004AC39 File Offset: 0x00048E39
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x0004AC41 File Offset: 0x00048E41
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

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x0004AC4A File Offset: 0x00048E4A
		// (set) Token: 0x06000B2A RID: 2858 RVA: 0x0004AC52 File Offset: 0x00048E52
		public Rx3ModelHeader[] Rx3ModelHeader
		{
			get
			{
				return this.m_Rx3ModelHeader;
			}
			set
			{
				this.m_Rx3ModelHeader = value;
			}
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x0004AC5B File Offset: 0x00048E5B
		public Rx3ModelDirectory(BinaryReader r, bool swapEndian)
		{
			this.m_SwapEndian = swapEndian;
			this.Load(r);
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x0004AC74 File Offset: 0x00048E74
		public bool Load(BinaryReader r)
		{
			if (this.m_SwapEndian)
			{
				this.m_NFiles = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_Padding = r.ReadBytes(12);
				this.m_Rx3ModelHeader = new Rx3ModelHeader[this.m_NFiles];
				for (int i = 0; i < this.m_NFiles; i++)
				{
					this.m_Rx3ModelHeader[i] = new Rx3ModelHeader(r, this.m_SwapEndian);
				}
			}
			else
			{
				this.m_NFiles = r.ReadInt32();
				this.m_Padding = r.ReadBytes(12);
				this.m_Rx3ModelHeader = new Rx3ModelHeader[this.m_NFiles];
				for (int j = 0; j < this.m_NFiles; j++)
				{
					this.m_Rx3ModelHeader[j] = new Rx3ModelHeader(r, this.m_SwapEndian);
				}
			}
			return true;
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x0004AD34 File Offset: 0x00048F34
		public bool Save(BinaryWriter w)
		{
			if (this.m_SwapEndian)
			{
				w.Write(FifaUtil.SwapEndian(this.m_NFiles));
				w.Write(this.m_Padding);
				for (int i = 0; i < this.m_NFiles; i++)
				{
					this.m_Rx3ModelHeader[i].Save(w);
				}
			}
			else
			{
				w.Write(this.m_NFiles);
				w.Write(this.m_Padding);
				for (int j = 0; j < this.m_NFiles; j++)
				{
					this.m_Rx3ModelHeader[j].Save(w);
				}
			}
			return true;
		}

		// Token: 0x04000FB5 RID: 4021
		private int m_NFiles;

		// Token: 0x04000FB6 RID: 4022
		private byte[] m_Padding;

		// Token: 0x04000FB7 RID: 4023
		private Rx3ModelHeader[] m_Rx3ModelHeader;

		// Token: 0x04000FB8 RID: 4024
		private bool m_SwapEndian;
	}
}
