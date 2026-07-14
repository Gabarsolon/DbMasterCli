using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200000A RID: 10
	public class MipMap : RawImage
	{
		// Token: 0x06000069 RID: 105 RVA: 0x000063B0 File Offset: 0x000045B0
		public MipMap(int width, int height, EImageType dxtType, bool swapEndian)
			: base(width, height, dxtType, 0)
		{
			this.m_SwapEndian = swapEndian;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000063C4 File Offset: 0x000045C4
		public new bool Load(BinaryReader r)
		{
			if (this.m_SwapEndian)
			{
				this.m_Unknown0 = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_Unknown4 = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_Size = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_UnknownC = FifaUtil.SwapEndian(r.ReadInt32());
				base.Load(r);
			}
			else
			{
				this.m_Unknown0 = r.ReadInt32();
				this.m_Unknown4 = r.ReadInt32();
				this.m_Size = r.ReadInt32();
				this.m_UnknownC = r.ReadInt32();
				base.Load(r);
			}
			return true;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00006460 File Offset: 0x00004660
		public new bool Save(BinaryWriter w)
		{
			if (this.m_SwapEndian)
			{
				w.Write(FifaUtil.SwapEndian(this.m_Unknown0));
				w.Write(FifaUtil.SwapEndian(this.m_Unknown4));
				w.Write(FifaUtil.SwapEndian(this.m_Size));
				w.Write(FifaUtil.SwapEndian(this.m_UnknownC));
				base.Save(w);
			}
			else
			{
				w.Write(this.m_Unknown0);
				w.Write(this.m_Unknown4);
				w.Write(this.m_Size);
				w.Write(this.m_UnknownC);
				base.Save(w);
			}
			return true;
		}

		// Token: 0x04000040 RID: 64
		private int m_Unknown0;

		// Token: 0x04000041 RID: 65
		private int m_Unknown4;

		// Token: 0x04000042 RID: 66
		private int m_UnknownC;
	}
}
