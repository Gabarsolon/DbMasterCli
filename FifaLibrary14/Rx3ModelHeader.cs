using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000095 RID: 149
	public class Rx3ModelHeader
	{
		// Token: 0x06000B3B RID: 2875 RVA: 0x0004B025 File Offset: 0x00049225
		public Rx3ModelHeader(BinaryReader r, bool swapEndian)
		{
			this.m_SwapEndian = swapEndian;
			this.Load(r);
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x0004B03C File Offset: 0x0004923C
		public bool Load(BinaryReader r)
		{
			if (this.m_SwapEndian)
			{
				this.m_Unknown_00 = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_Unknown_04 = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_Unknown_08 = r.ReadInt32();
				this.m_Unknown_0c = r.ReadInt32();
			}
			else
			{
				this.m_Unknown_00 = r.ReadInt32();
				this.m_Unknown_04 = r.ReadInt32();
				this.m_Unknown_08 = r.ReadInt32();
				this.m_Unknown_0c = r.ReadInt32();
			}
			return true;
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x0004B0C0 File Offset: 0x000492C0
		public bool Save(BinaryWriter w)
		{
			if (this.m_SwapEndian)
			{
				w.Write(FifaUtil.SwapEndian(this.m_Unknown_00));
				w.Write(FifaUtil.SwapEndian(this.m_Unknown_04));
				w.Write(this.m_Unknown_08);
				w.Write(this.m_Unknown_0c);
			}
			else
			{
				w.Write(this.m_Unknown_00);
				w.Write(this.m_Unknown_04);
				w.Write(this.m_Unknown_08);
				w.Write(this.m_Unknown_0c);
			}
			return true;
		}

		// Token: 0x04000FC2 RID: 4034
		private int m_Unknown_00;

		// Token: 0x04000FC3 RID: 4035
		private int m_Unknown_04;

		// Token: 0x04000FC4 RID: 4036
		private int m_Unknown_08;

		// Token: 0x04000FC5 RID: 4037
		private int m_Unknown_0c;

		// Token: 0x04000FC6 RID: 4038
		private bool m_SwapEndian;
	}
}
