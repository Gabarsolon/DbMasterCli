using System;
using System.Drawing;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000008 RID: 8
	public class FshImage
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00005509 File Offset: 0x00003709
		public Bitmap Bitmap
		{
			get
			{
				return this.m_MainSection.m_Bitmap;
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00005516 File Offset: 0x00003716
		public FshImage(Fsh parent, BinaryReader r, int maxSize)
		{
			this.m_Parent = parent;
			this.m_MainSection = new FshSection(parent, r, maxSize);
			this.m_MainSection.RawDataToBmp();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000553F File Offset: 0x0000373F
		public void Save(BinaryWriter w)
		{
			this.m_MainSection.Save(w);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000554D File Offset: 0x0000374D
		public bool ReplaceBitmap(Bitmap bitmap)
		{
			return this.m_MainSection.ReplaceBitmap(bitmap);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000555B File Offset: 0x0000375B
		public bool ReplaceRawData(byte[] rawData, int width, int height)
		{
			return this.m_MainSection.ReplaceRawData(rawData, width, height);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000556B File Offset: 0x0000376B
		public byte[] GetRawData()
		{
			return this.m_MainSection.m_RawData;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00005578 File Offset: 0x00003778
		public void Hash(string fileName)
		{
			for (FshSection fshSection = this.m_MainSection.NextSection; fshSection != null; fshSection = fshSection.NextSection)
			{
				if (fshSection.Type == 111)
				{
					fshSection.Hash(fileName);
					return;
				}
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000055B0 File Offset: 0x000037B0
		public int ComputeLength()
		{
			int num = this.m_MainSection.m_Size;
			for (FshSection fshSection = this.m_MainSection.NextSection; fshSection != null; fshSection = fshSection.NextSection)
			{
				num += fshSection.m_Size;
			}
			return num;
		}

		// Token: 0x04000036 RID: 54
		private FshSection m_MainSection;

		// Token: 0x04000037 RID: 55
		private Fsh m_Parent;
	}
}
