using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200000F RID: 15
	public class BhFileReference
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0000AC25 File Offset: 0x00008E25
		// (set) Token: 0x06000114 RID: 276 RVA: 0x0000AC2D File Offset: 0x00008E2D
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

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000115 RID: 277 RVA: 0x0000AC36 File Offset: 0x00008E36
		// (set) Token: 0x06000116 RID: 278 RVA: 0x0000AC3E File Offset: 0x00008E3E
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

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0000AC47 File Offset: 0x00008E47
		// (set) Token: 0x06000118 RID: 280 RVA: 0x0000AC4F File Offset: 0x00008E4F
		public int UncompressedSize
		{
			get
			{
				return this.m_UncompressedSize;
			}
			set
			{
				this.m_UncompressedSize = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0000AC58 File Offset: 0x00008E58
		// (set) Token: 0x0600011A RID: 282 RVA: 0x0000AC60 File Offset: 0x00008E60
		public ulong Hash
		{
			get
			{
				return this.m_Hash;
			}
			set
			{
				this.m_Hash = value;
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000AC6C File Offset: 0x00008E6C
		public BhFileReference(int startPosition, int size, int uncompressedSize, string name)
		{
			this.m_StartPosition = startPosition;
			this.m_Size = size;
			this.m_UncompressedSize = uncompressedSize;
			if (this.m_UncompressedSize != 0)
			{
				this.m_Size = (this.m_Size + 15 >> 4) * 16;
			}
			this.m_Hash = FifaUtil.ComputeBhHash(name);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000ACBD File Offset: 0x00008EBD
		public BhFileReference()
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000ACC8 File Offset: 0x00008EC8
		public bool Load(BinaryReader r)
		{
			this.m_StartPosition = FifaUtil.SwapEndian(r.ReadInt32());
			this.m_Size = FifaUtil.SwapEndian(r.ReadInt32());
			this.m_UncompressedSize = FifaUtil.SwapEndian(r.ReadInt32());
			this.m_Hash = FifaUtil.SwapEndian(r.ReadUInt64());
			return true;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000AD1C File Offset: 0x00008F1C
		public bool Save(BinaryWriter w)
		{
			w.Write(FifaUtil.SwapEndian(this.m_StartPosition));
			w.Write(FifaUtil.SwapEndian(this.m_Size));
			w.Write(FifaUtil.SwapEndian(this.m_UncompressedSize));
			w.Write(FifaUtil.SwapEndian(this.m_Hash));
			return true;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000AD6E File Offset: 0x00008F6E
		public void Hide()
		{
			this.m_Hash = 0UL;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000AD78 File Offset: 0x00008F78
		public bool IsHidden()
		{
			return this.m_Hash == 0UL;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000AD84 File Offset: 0x00008F84
		public void Restore(string name)
		{
			this.m_Hash = FifaUtil.ComputeBhHash(name);
		}

		// Token: 0x0400009F RID: 159
		private int m_StartPosition;

		// Token: 0x040000A0 RID: 160
		private int m_Size;

		// Token: 0x040000A1 RID: 161
		private int m_UncompressedSize;

		// Token: 0x040000A2 RID: 162
		private ulong m_Hash;
	}
}
