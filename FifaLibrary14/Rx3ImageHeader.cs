using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000094 RID: 148
	public class Rx3ImageHeader
	{
		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000B2E RID: 2862 RVA: 0x0004ADC1 File Offset: 0x00048FC1
		// (set) Token: 0x06000B2F RID: 2863 RVA: 0x0004ADC9 File Offset: 0x00048FC9
		public int FileSize
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

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x0004ADD2 File Offset: 0x00048FD2
		// (set) Token: 0x06000B31 RID: 2865 RVA: 0x0004ADDA File Offset: 0x00048FDA
		public EImageType ImageType
		{
			get
			{
				return (EImageType)this.m_ImageType;
			}
			set
			{
				this.m_ImageType = (byte)value;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x0004ADE4 File Offset: 0x00048FE4
		// (set) Token: 0x06000B33 RID: 2867 RVA: 0x0004ADEC File Offset: 0x00048FEC
		public short Width
		{
			get
			{
				return this.m_Width;
			}
			set
			{
				this.m_Width = value;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x0004ADF5 File Offset: 0x00048FF5
		// (set) Token: 0x06000B35 RID: 2869 RVA: 0x0004ADFD File Offset: 0x00048FFD
		public short Height
		{
			get
			{
				return this.m_Height;
			}
			set
			{
				this.m_Height = value;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x0004AE06 File Offset: 0x00049006
		// (set) Token: 0x06000B37 RID: 2871 RVA: 0x0004AE0E File Offset: 0x0004900E
		public short NMipMaps
		{
			get
			{
				return this.m_NMipMaps;
			}
			set
			{
				this.m_NMipMaps = value;
			}
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x0004AE17 File Offset: 0x00049017
		public Rx3ImageHeader(BinaryReader r, bool swapEndian)
		{
			this.m_SwapEndian = swapEndian;
			this.Load(r);
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x0004AE30 File Offset: 0x00049030
		public bool Load(BinaryReader r)
		{
			if (this.m_SwapEndian)
			{
				this.m_FileSize = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_Unknown_04 = r.ReadByte();
				this.m_ImageType = r.ReadByte();
				this.m_Unknown_06 = FifaUtil.SwapEndian(r.ReadInt16());
				this.m_Width = FifaUtil.SwapEndian(r.ReadInt16());
				this.m_Height = FifaUtil.SwapEndian(r.ReadInt16());
				this.m_Unknown_0C = FifaUtil.SwapEndian(r.ReadInt16());
				this.m_NMipMaps = FifaUtil.SwapEndian(r.ReadInt16());
			}
			else
			{
				this.m_FileSize = r.ReadInt32();
				this.m_Unknown_04 = r.ReadByte();
				this.m_ImageType = r.ReadByte();
				this.m_Unknown_06 = r.ReadInt16();
				this.m_Width = r.ReadInt16();
				this.m_Height = r.ReadInt16();
				this.m_Unknown_0C = r.ReadInt16();
				this.m_NMipMaps = r.ReadInt16();
			}
			return true;
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x0004AF2C File Offset: 0x0004912C
		public bool Save(BinaryWriter w)
		{
			if (this.m_SwapEndian)
			{
				w.Write(FifaUtil.SwapEndian(this.m_FileSize));
				w.Write(this.m_Unknown_04);
				w.Write(this.m_ImageType);
				w.Write(FifaUtil.SwapEndian(this.m_Unknown_06));
				w.Write(FifaUtil.SwapEndian(this.m_Width));
				w.Write(FifaUtil.SwapEndian(this.m_Height));
				w.Write(FifaUtil.SwapEndian(this.m_Unknown_0C));
				w.Write(FifaUtil.SwapEndian(this.m_NMipMaps));
			}
			else
			{
				w.Write(this.m_FileSize);
				w.Write(this.m_Unknown_04);
				w.Write(this.m_ImageType);
				w.Write(this.m_Unknown_06);
				w.Write(this.m_Width);
				w.Write(this.m_Height);
				w.Write(this.m_Unknown_0C);
				w.Write(this.m_NMipMaps);
			}
			return true;
		}

		// Token: 0x04000FB9 RID: 4025
		private int m_FileSize;

		// Token: 0x04000FBA RID: 4026
		private byte m_Unknown_04;

		// Token: 0x04000FBB RID: 4027
		private byte m_ImageType;

		// Token: 0x04000FBC RID: 4028
		private short m_Unknown_06;

		// Token: 0x04000FBD RID: 4029
		private short m_Width;

		// Token: 0x04000FBE RID: 4030
		private short m_Height;

		// Token: 0x04000FBF RID: 4031
		private short m_Unknown_0C;

		// Token: 0x04000FC0 RID: 4032
		private short m_NMipMaps;

		// Token: 0x04000FC1 RID: 4033
		private bool m_SwapEndian;
	}
}
