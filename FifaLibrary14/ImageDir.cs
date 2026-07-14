using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000006 RID: 6
	public class ImageDir
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00003DFF File Offset: 0x00001FFF
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00003E07 File Offset: 0x00002007
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

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00003E10 File Offset: 0x00002010
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00003E18 File Offset: 0x00002018
		public int Offset
		{
			get
			{
				return this.m_Offset;
			}
			set
			{
				this.m_Offset = value;
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003E21 File Offset: 0x00002021
		public ImageDir(BinaryReader r)
		{
			this.m_Name = new string(r.ReadChars(4));
			this.m_Offset = r.ReadInt32();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003E48 File Offset: 0x00002048
		public void Save(BinaryWriter w)
		{
			char[] array = this.m_Name.ToCharArray();
			w.Write((byte)array[0]);
			w.Write((byte)array[1]);
			w.Write((byte)array[2]);
			w.Write((byte)array[3]);
			w.Write(this.m_Offset);
		}

		// Token: 0x04000024 RID: 36
		private string m_Name;

		// Token: 0x04000025 RID: 37
		private int m_Offset;
	}
}
