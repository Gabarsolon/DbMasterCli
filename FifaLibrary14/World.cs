using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000041 RID: 65
	public class World : Compobj
	{
		// Token: 0x06000679 RID: 1657 RVA: 0x00026C84 File Offset: 0x00024E84
		public World(int id, string typeString, string description)
			: base(id, 0, typeString, description, null)
		{
			this.m_Confederations = new ConfederationList();
			this.m_Trophies = new TrophyList();
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x00026D00 File Offset: 0x00024F00
		// (set) Token: 0x0600067B RID: 1659 RVA: 0x00026D08 File Offset: 0x00024F08
		public int[] DryProb
		{
			get
			{
				return this.m_DryProb;
			}
			set
			{
				this.m_DryProb = value;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x00026D11 File Offset: 0x00024F11
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x00026D19 File Offset: 0x00024F19
		public int[] RainProb
		{
			get
			{
				return this.m_RainProb;
			}
			set
			{
				this.m_RainProb = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x00026D22 File Offset: 0x00024F22
		// (set) Token: 0x0600067F RID: 1663 RVA: 0x00026D2A File Offset: 0x00024F2A
		public int[] SnowProb
		{
			get
			{
				return this.m_SnowProb;
			}
			set
			{
				this.m_SnowProb = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x00026D33 File Offset: 0x00024F33
		// (set) Token: 0x06000681 RID: 1665 RVA: 0x00026D3B File Offset: 0x00024F3B
		public int[] OvercastProb
		{
			get
			{
				return this.m_OvercastProb;
			}
			set
			{
				this.m_OvercastProb = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x00026D44 File Offset: 0x00024F44
		// (set) Token: 0x06000683 RID: 1667 RVA: 0x00026D4C File Offset: 0x00024F4C
		public int[] SunsetTime
		{
			get
			{
				return this.m_SunsetTime;
			}
			set
			{
				this.m_SunsetTime = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x00026D55 File Offset: 0x00024F55
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x00026D5D File Offset: 0x00024F5D
		public int[] DarkTime
		{
			get
			{
				return this.m_DarkTime;
			}
			set
			{
				this.m_DarkTime = value;
			}
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00026D68 File Offset: 0x00024F68
		public override bool SaveToWeather(StreamWriter w)
		{
			if (w == null)
			{
				return false;
			}
			for (int i = 0; i < 12; i++)
			{
				if (this.m_DryProb[i] + this.m_RainProb[i] + this.m_SnowProb[i] == 100)
				{
					string text = string.Concat(new string[]
					{
						base.Id.ToString(),
						",",
						(i + 1).ToString(),
						",",
						this.m_DryProb[i].ToString(),
						",",
						this.m_RainProb[i].ToString(),
						",",
						this.m_SnowProb[i].ToString(),
						",",
						this.m_OvercastProb[i].ToString(),
						",",
						this.m_SunsetTime[i].ToString(),
						",",
						this.m_DarkTime[i].ToString()
					});
					w.WriteLine(text);
				}
			}
			return true;
		}

		// Token: 0x0400027D RID: 637
		private int[] m_DryProb = new int[12];

		// Token: 0x0400027E RID: 638
		private int[] m_RainProb = new int[12];

		// Token: 0x0400027F RID: 639
		private int[] m_SnowProb = new int[12];

		// Token: 0x04000280 RID: 640
		private int[] m_OvercastProb = new int[12];

		// Token: 0x04000281 RID: 641
		private int[] m_SunsetTime = new int[12];

		// Token: 0x04000282 RID: 642
		private int[] m_DarkTime = new int[12];
	}
}
