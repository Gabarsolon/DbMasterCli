using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000090 RID: 144
	public class Rx3Header
	{
		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000B0E RID: 2830 RVA: 0x0004A794 File Offset: 0x00048994
		// (set) Token: 0x06000B0F RID: 2831 RVA: 0x0004A79C File Offset: 0x0004899C
		public int SizeOf_
		{
			get
			{
				return this.m_SizeOf_;
			}
			set
			{
				this.m_SizeOf_ = value;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x0004A7A5 File Offset: 0x000489A5
		// (set) Token: 0x06000B11 RID: 2833 RVA: 0x0004A7AD File Offset: 0x000489AD
		public int NFiles
		{
			get
			{
				return this.m_NFiles;
			}
			set
			{
				this.m_NFiles = value;
			}
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x0004A7B6 File Offset: 0x000489B6
		public Rx3Header(BinaryReader r, bool swapEndian)
		{
			this.m_SwapEndian = swapEndian;
			this.Load(r);
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x0004A7D0 File Offset: 0x000489D0
		public bool Load(BinaryReader r)
		{
			this.m_Signature = new string(r.ReadChars(4));
			if (this.m_SwapEndian)
			{
				if (!(this.m_Signature == "RX3b"))
				{
					return false;
				}
				this.m_Unknown_04 = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_SizeOf_ = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_NFiles = FifaUtil.SwapEndian(r.ReadInt32());
			}
			else
			{
				if (!(this.m_Signature == "RX3l"))
				{
					return false;
				}
				this.m_Unknown_04 = r.ReadInt32();
				this.m_SizeOf_ = r.ReadInt32();
				this.m_NFiles = r.ReadInt32();
			}
			return true;
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0004A87C File Offset: 0x00048A7C
		public bool Save(BinaryWriter w)
		{
			if (this.m_SwapEndian)
			{
				w.Write('R');
				w.Write('X');
				w.Write('3');
				w.Write('b');
				w.Write(FifaUtil.SwapEndian(this.m_Unknown_04));
				w.Write(FifaUtil.SwapEndian(this.m_SizeOf_));
				w.Write(FifaUtil.SwapEndian(this.m_NFiles));
			}
			else
			{
				w.Write('R');
				w.Write('X');
				w.Write('3');
				w.Write('l');
				w.Write(this.m_Unknown_04);
				w.Write(this.m_SizeOf_);
				w.Write(this.m_NFiles);
			}
			return true;
		}

		// Token: 0x04000FA7 RID: 4007
		private string m_Signature;

		// Token: 0x04000FA8 RID: 4008
		private int m_Unknown_04;

		// Token: 0x04000FA9 RID: 4009
		private int m_SizeOf_;

		// Token: 0x04000FAA RID: 4010
		private int m_NFiles;

		// Token: 0x04000FAB RID: 4011
		private bool m_SwapEndian;
	}
}
