using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000044 RID: 68
	public class Nation : Compobj
	{
		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x000270BD File Offset: 0x000252BD
		// (set) Token: 0x06000692 RID: 1682 RVA: 0x000270C5 File Offset: 0x000252C5
		public Country Country
		{
			get
			{
				return this.m_Country;
			}
			set
			{
				this.m_Country = value;
				base.Settings.m_nation_id = ((this.m_Country != null) ? this.m_Country.Id : (-1));
			}
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x000270EF File Offset: 0x000252EF
		public override void LinkCountry(CountryList countryList)
		{
			if (countryList == null)
			{
				return;
			}
			this.m_Country = (Country)countryList.SearchId(base.Settings.m_nation_id);
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x00027111 File Offset: 0x00025311
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x00027119 File Offset: 0x00025319
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

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x00027122 File Offset: 0x00025322
		// (set) Token: 0x06000697 RID: 1687 RVA: 0x0002712A File Offset: 0x0002532A
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

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x00027133 File Offset: 0x00025333
		// (set) Token: 0x06000699 RID: 1689 RVA: 0x0002713B File Offset: 0x0002533B
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

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x00027144 File Offset: 0x00025344
		// (set) Token: 0x0600069B RID: 1691 RVA: 0x0002714C File Offset: 0x0002534C
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

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x00027155 File Offset: 0x00025355
		// (set) Token: 0x0600069D RID: 1693 RVA: 0x0002715D File Offset: 0x0002535D
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

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x00027166 File Offset: 0x00025366
		// (set) Token: 0x0600069F RID: 1695 RVA: 0x0002716E File Offset: 0x0002536E
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

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x00027177 File Offset: 0x00025377
		public Confederation Confederation
		{
			get
			{
				if (base.ParentObj.TypeNumber == 1)
				{
					return (Confederation)base.ParentObj;
				}
				return null;
			}
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00027194 File Offset: 0x00025394
		public Nation(int id, string typeString, string description, Compobj parentObj)
			: base(id, 2, typeString, description, parentObj)
		{
			this.m_Trophies = new TrophyList();
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00027208 File Offset: 0x00025408
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

		// Token: 0x060006A3 RID: 1699 RVA: 0x0002733C File Offset: 0x0002553C
		public bool RemoveTrophy()
		{
			if (this.m_Trophies.Count < 1)
			{
				return false;
			}
			Trophy trophy = (Trophy)this.m_Trophies[this.m_Trophies.Count - 1];
			this.m_Trophies.Remove(trophy);
			FifaEnvironment.CompetitionObjects.Remove(trophy);
			trophy.RemoveAllStages();
			return true;
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00027398 File Offset: 0x00025598
		public bool RemoveAllTrophies()
		{
			int count = this.m_Trophies.Count;
			for (int i = 0; i < count; i++)
			{
				this.RemoveTrophy();
			}
			return true;
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x000273C5 File Offset: 0x000255C5
		public override void Normalize()
		{
		}

		// Token: 0x04000284 RID: 644
		private Country m_Country;

		// Token: 0x04000285 RID: 645
		private int[] m_DryProb = new int[12];

		// Token: 0x04000286 RID: 646
		private int[] m_RainProb = new int[12];

		// Token: 0x04000287 RID: 647
		private int[] m_SnowProb = new int[12];

		// Token: 0x04000288 RID: 648
		private int[] m_OvercastProb = new int[12];

		// Token: 0x04000289 RID: 649
		private int[] m_SunsetTime = new int[12];

		// Token: 0x0400028A RID: 650
		private int[] m_DarkTime = new int[12];
	}
}
