using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200008B RID: 139
	public class FifaFileHeader
	{
		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x000479A6 File Offset: 0x00045BA6
		public FifaBigFile BigFile
		{
			get
			{
				return this.m_BigFile;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x000479AE File Offset: 0x00045BAE
		// (set) Token: 0x06000A96 RID: 2710 RVA: 0x000479B6 File Offset: 0x00045BB6
		public int StartPosition
		{
			get
			{
				return this.m_StartPosition;
			}
			set
			{
				this.m_StartPosition = value;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x000479BF File Offset: 0x00045BBF
		// (set) Token: 0x06000A98 RID: 2712 RVA: 0x000479C7 File Offset: 0x00045BC7
		public int Size
		{
			get
			{
				return this.m_Size;
			}
			set
			{
				this.m_Size = value;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x000479D0 File Offset: 0x00045BD0
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x000479D8 File Offset: 0x00045BD8
		public string Name
		{
			get
			{
				return this.m_Name;
			}
			set
			{
				this.m_Name = value;
			}
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x000479E1 File Offset: 0x00045BE1
		public FifaFileHeader(FifaBigFile bigFile)
		{
			this.m_BigFile = bigFile;
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x000479F0 File Offset: 0x00045BF0
		public FifaFileHeader()
		{
			this.m_BigFile = null;
			this.m_StartPosition = 0;
			this.m_Name = null;
			this.m_Size = 0;
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x00047A14 File Offset: 0x00045C14
		public bool Load(BinaryReader r)
		{
			this.m_StartPosition = FifaUtil.SwapEndian(r.ReadInt32());
			this.m_Size = FifaUtil.SwapEndian(r.ReadInt32());
			this.m_Name = FifaUtil.ReadNullTerminatedString(r);
			return true;
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x00047A45 File Offset: 0x00045C45
		public bool Save(BinaryWriter w)
		{
			w.Write(FifaUtil.SwapEndian(this.m_StartPosition));
			w.Write(FifaUtil.SwapEndian(this.m_Size));
			FifaUtil.WriteNullTerminatedString(w, this.m_Name);
			return true;
		}

		// Token: 0x04000F84 RID: 3972
		private FifaBigFile m_BigFile;

		// Token: 0x04000F85 RID: 3973
		private int m_StartPosition;

		// Token: 0x04000F86 RID: 3974
		private int m_Size;

		// Token: 0x04000F87 RID: 3975
		private string m_Name;
	}
}
