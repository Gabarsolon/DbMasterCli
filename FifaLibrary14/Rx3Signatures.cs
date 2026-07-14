using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200009C RID: 156
	public class Rx3Signatures
	{
		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x0004C244 File Offset: 0x0004A444
		// (set) Token: 0x06000B6E RID: 2926 RVA: 0x0004C24C File Offset: 0x0004A44C
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

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x0004C255 File Offset: 0x0004A455
		// (set) Token: 0x06000B70 RID: 2928 RVA: 0x0004C25D File Offset: 0x0004A45D
		public int Length
		{
			get
			{
				return this.m_Length;
			}
			set
			{
				this.m_Length = value;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x0004C266 File Offset: 0x0004A466
		// (set) Token: 0x06000B72 RID: 2930 RVA: 0x0004C26E File Offset: 0x0004A46E
		public string[] Signatures
		{
			get
			{
				return this.m_Signatures;
			}
			set
			{
				this.m_Signatures = value;
			}
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x0004C277 File Offset: 0x0004A477
		public Rx3Signatures(int offset, int length, string[] signatures)
		{
			this.Init(offset, length, signatures);
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x0004C288 File Offset: 0x0004A488
		private void Init(int offset, int length, string[] signatures)
		{
			this.m_Offset = offset;
			this.m_Length = length;
			this.m_Signatures = signatures;
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x0004C2A0 File Offset: 0x0004A4A0
		public bool Save(BinaryWriter w)
		{
			if (this.m_Signatures == null)
			{
				return false;
			}
			for (int i = 0; i < this.m_Signatures.Length; i++)
			{
				w.BaseStream.Position = (long)(this.m_Offset + this.m_Length * i + 4);
				w.Write(this.m_Signatures[i].Length + 1);
				w.Write(this.m_Signatures[i].ToCharArray(0, this.m_Signatures[i].Length));
				for (int j = this.m_Signatures[i].Length; j < this.m_Length; j++)
				{
					w.Write(0);
				}
			}
			return true;
		}

		// Token: 0x04000FE7 RID: 4071
		private int m_Offset;

		// Token: 0x04000FE8 RID: 4072
		private int m_Length;

		// Token: 0x04000FE9 RID: 4073
		private string[] m_Signatures;
	}
}
