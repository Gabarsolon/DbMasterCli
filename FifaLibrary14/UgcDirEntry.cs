using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000015 RID: 21
	public class UgcDirEntry
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000166 RID: 358 RVA: 0x0000DE88 File Offset: 0x0000C088
		public uint Offset
		{
			get
			{
				return this.m_Offset;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000167 RID: 359 RVA: 0x0000DE90 File Offset: 0x0000C090
		public string FileName
		{
			get
			{
				return this.m_FileName;
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000DE98 File Offset: 0x0000C098
		public override string ToString()
		{
			return Path.GetFileName(this.m_FileName);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000DEA5 File Offset: 0x0000C0A5
		public UgcDirEntry(BinaryReader r)
		{
			this.Load(r);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000DEB5 File Offset: 0x0000C0B5
		public bool Load(BinaryReader r)
		{
			r.ReadBytes(16);
			this.m_Offset = r.ReadUInt32();
			r.ReadInt16();
			this.m_FileName = FifaUtil.ReadNullPaddedString(r, 66);
			return true;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000DEE2 File Offset: 0x0000C0E2
		public bool IsPng()
		{
			return this.m_FileName.EndsWith("png");
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000DEF4 File Offset: 0x0000C0F4
		public bool IsDb()
		{
			return this.m_FileName.EndsWith("db");
		}

		// Token: 0x040000C1 RID: 193
		private uint m_Offset;

		// Token: 0x040000C2 RID: 194
		private string m_FileName;
	}
}
