using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000091 RID: 145
	public class Rx3FileDescriptor
	{
		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x0004A92B File Offset: 0x00048B2B
		public uint Signature
		{
			get
			{
				return this.m_Signature;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000B16 RID: 2838 RVA: 0x0004A933 File Offset: 0x00048B33
		// (set) Token: 0x06000B17 RID: 2839 RVA: 0x0004A93B File Offset: 0x00048B3B
		public int Offset
		{
			get
			{
				return this.m_FileOffset;
			}
			set
			{
				this.m_FileOffset = value;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x0004A944 File Offset: 0x00048B44
		// (set) Token: 0x06000B19 RID: 2841 RVA: 0x0004A94C File Offset: 0x00048B4C
		public int Size
		{
			get
			{
				return this.m_FileSize;
			}
			set
			{
				this.m_FileSize = value;
			}
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x0004A955 File Offset: 0x00048B55
		public Rx3FileDescriptor(BinaryReader r, bool swapEndian)
		{
			this.m_SwapEndian = swapEndian;
			this.Load(r);
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x0004A96C File Offset: 0x00048B6C
		public bool Load(BinaryReader r)
		{
			if (this.m_SwapEndian)
			{
				this.m_Signature = FifaUtil.SwapEndian(r.ReadUInt32());
				this.m_FileOffset = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_FileSize = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_Unknown_0c = FifaUtil.SwapEndian(r.ReadInt32());
			}
			else
			{
				this.m_Signature = r.ReadUInt32();
				this.m_FileOffset = r.ReadInt32();
				this.m_FileSize = r.ReadInt32();
				this.m_Unknown_0c = r.ReadInt32();
			}
			return true;
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x0004A9F8 File Offset: 0x00048BF8
		public bool Save(BinaryWriter w)
		{
			if (this.m_SwapEndian)
			{
				w.Write(FifaUtil.SwapEndian(this.m_Signature));
				w.Write(FifaUtil.SwapEndian(this.m_FileOffset));
				w.Write(FifaUtil.SwapEndian(this.m_FileSize));
				w.Write(FifaUtil.SwapEndian(this.m_Unknown_0c));
			}
			else
			{
				w.Write(this.m_Signature);
				w.Write(this.m_FileOffset);
				w.Write(this.m_FileSize);
				w.Write(this.m_Unknown_0c);
			}
			return true;
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x0004AA84 File Offset: 0x00048C84
		public bool Is3dDirectory()
		{
			return this.m_Signature == 582139446U;
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x0004AA93 File Offset: 0x00048C93
		public bool IsTexture()
		{
			return this.m_Signature == 1879793882U;
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x0004AAA2 File Offset: 0x00048CA2
		public bool IsImageDirectory()
		{
			return this.m_Signature == 1808827868U;
		}

		// Token: 0x04000FAC RID: 4012
		private uint m_Signature;

		// Token: 0x04000FAD RID: 4013
		private int m_FileOffset;

		// Token: 0x04000FAE RID: 4014
		private int m_FileSize;

		// Token: 0x04000FAF RID: 4015
		private int m_Unknown_0c;

		// Token: 0x04000FB0 RID: 4016
		private bool m_SwapEndian;
	}
}
