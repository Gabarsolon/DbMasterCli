using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000057 RID: 87
	public class CompetitionSettings
	{
		// Token: 0x0600079C RID: 1948 RVA: 0x0002C428 File Offset: 0x0002A628
		public void GetInfoColorSlotChampCup(out int min, out int max)
		{
			if (this.m_N_info_color_slot_champ_cup == 0)
			{
				min = -1;
				max = -1;
				return;
			}
			min = this.m_info_color_slot_champ_cup[0];
			max = this.m_info_color_slot_champ_cup[this.m_N_info_color_slot_champ_cup - 1];
			if (min > max)
			{
				int num = min;
				min = max;
				max = num;
			}
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0002C470 File Offset: 0x0002A670
		public bool SetInfoColorSlotChampCup(int min, int max)
		{
			if (min == -1 || max == -1 || min > max)
			{
				this.m_N_info_color_slot_champ_cup = 0;
				this.m_info_color_slot_champ_cup[0] = -1;
				return true;
			}
			for (int i = 0; i < this.m_info_color_slot_champ_cup.Length; i++)
			{
				if (min + i <= max)
				{
					this.m_info_color_slot_champ_cup[i] = min + i;
					this.m_N_info_color_slot_champ_cup = i + 1;
				}
				else
				{
					this.m_info_color_slot_champ_cup[i] = -1;
				}
			}
			return true;
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0002C4D4 File Offset: 0x0002A6D4
		public void GetInfoColorSlotEuroLeague(out int min, out int max)
		{
			if (this.m_N_info_color_slot_euro_league == 0)
			{
				min = -1;
				max = -1;
				return;
			}
			min = this.m_info_color_slot_euro_league[0];
			max = this.m_info_color_slot_euro_league[this.m_N_info_color_slot_euro_league - 1];
			if (min > max)
			{
				int num = min;
				min = max;
				max = num;
			}
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0002C51C File Offset: 0x0002A71C
		public bool SetInfoColorSlotEuroLeague(int min, int max)
		{
			if (min == -1 || max == -1 || min > max)
			{
				this.m_N_info_color_slot_euro_league = 0;
				this.m_info_color_slot_euro_league[0] = -1;
				return true;
			}
			for (int i = 0; i < this.m_info_color_slot_euro_league.Length; i++)
			{
				if (min + i <= max)
				{
					this.m_info_color_slot_euro_league[i] = min + i;
					this.m_N_info_color_slot_euro_league = i + 1;
				}
				else
				{
					this.m_info_color_slot_euro_league[i] = -1;
				}
			}
			return true;
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x0002C580 File Offset: 0x0002A780
		public void GetInfoColorSlotPromo(out int min, out int max)
		{
			if (this.m_N_info_color_slot_promo == 0)
			{
				min = -1;
				max = -1;
				return;
			}
			min = this.m_info_color_slot_promo[0];
			max = this.m_info_color_slot_promo[this.m_N_info_color_slot_promo - 1];
			if (min > max)
			{
				int num = min;
				min = max;
				max = num;
			}
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x0002C5C8 File Offset: 0x0002A7C8
		public bool SetInfoColorSlotPromo(int min, int max)
		{
			if (min == -1 || max == -1 || min > max)
			{
				this.m_N_info_color_slot_promo = 0;
				this.m_info_color_slot_promo[0] = -1;
				return true;
			}
			for (int i = 0; i < this.m_info_color_slot_promo.Length; i++)
			{
				if (min + i <= max)
				{
					this.m_info_color_slot_promo[i] = min + i;
					this.m_N_info_color_slot_promo = i + 1;
				}
				else
				{
					this.m_info_color_slot_promo[i] = -1;
				}
			}
			return true;
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x0002C62C File Offset: 0x0002A82C
		public void GetInfoColorSlotPromoPoss(out int min, out int max)
		{
			if (this.m_N_info_color_slot_promo_poss == 0)
			{
				min = -1;
				max = -1;
				return;
			}
			min = this.m_info_color_slot_promo_poss[0];
			max = this.m_info_color_slot_promo_poss[this.m_N_info_color_slot_promo_poss - 1];
			if (min > max)
			{
				int num = min;
				min = max;
				max = num;
			}
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0002C674 File Offset: 0x0002A874
		public bool SetInfoColorSlotPromoPoss(int min, int max)
		{
			if (min == -1 || max == -1 || min > max)
			{
				this.m_N_info_color_slot_promo_poss = 0;
				this.m_info_color_slot_promo_poss[0] = -1;
				return true;
			}
			for (int i = 0; i < this.m_info_color_slot_promo_poss.Length; i++)
			{
				if (min + i <= max)
				{
					this.m_info_color_slot_promo_poss[i] = min + i;
					this.m_N_info_color_slot_promo_poss = i + 1;
				}
				else
				{
					this.m_info_color_slot_promo_poss[i] = -1;
				}
			}
			return true;
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0002C6D8 File Offset: 0x0002A8D8
		public void GetInfoColorSlotReleg(out int min, out int max)
		{
			if (this.m_N_info_color_slot_releg == 0)
			{
				min = -1;
				max = -1;
				return;
			}
			min = this.m_info_color_slot_releg[0];
			max = this.m_info_color_slot_releg[this.m_N_info_color_slot_releg - 1];
			if (min > max)
			{
				int num = min;
				min = max;
				max = num;
			}
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0002C720 File Offset: 0x0002A920
		public bool SetInfoColorSlotReleg(int min, int max)
		{
			if (min == -1 || max == -1 || min > max)
			{
				this.m_N_info_color_slot_releg = 0;
				this.m_info_color_slot_releg[0] = -1;
				return true;
			}
			for (int i = 0; i < this.m_info_color_slot_releg.Length; i++)
			{
				if (min + i <= max)
				{
					this.m_info_color_slot_releg[i] = min + i;
					this.m_N_info_color_slot_releg = i + 1;
				}
				else
				{
					this.m_info_color_slot_releg[i] = -1;
				}
			}
			return true;
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0002C784 File Offset: 0x0002A984
		public void GetInfoColorSlotRelegPoss(out int min, out int max)
		{
			if (this.m_N_info_color_slot_releg_poss == 0)
			{
				min = -1;
				max = -1;
				return;
			}
			min = this.m_info_color_slot_releg_poss[0];
			max = this.m_info_color_slot_releg_poss[this.m_N_info_color_slot_releg_poss - 1];
			if (min > max)
			{
				int num = min;
				min = max;
				max = num;
			}
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0002C7CC File Offset: 0x0002A9CC
		public bool SetInfoColorSlotRelegPoss(int min, int max)
		{
			if (min == -1 || max == -1 || min > max)
			{
				this.m_N_info_color_slot_releg_poss = 0;
				this.m_info_color_slot_releg_poss[0] = -1;
				return true;
			}
			for (int i = 0; i < this.m_info_color_slot_releg_poss.Length; i++)
			{
				if (min + i <= max)
				{
					this.m_info_color_slot_releg_poss[i] = min + i;
					this.m_N_info_color_slot_releg_poss = i + 1;
				}
				else
				{
					this.m_info_color_slot_releg_poss[i] = -1;
				}
			}
			return true;
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0002C830 File Offset: 0x0002AA30
		public void GetInfoColorSlotAdvGroup(out int min, out int max)
		{
			if (this.m_N_info_color_slot_adv_group == 0)
			{
				min = -1;
				max = -1;
				return;
			}
			min = this.m_info_color_slot_adv_group[0];
			max = this.m_info_color_slot_adv_group[this.m_N_info_color_slot_adv_group - 1];
			if (min > max)
			{
				int num = min;
				min = max;
				max = num;
			}
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0002C878 File Offset: 0x0002AA78
		public bool SetInfoColorSlotAdvGroup(int min, int max)
		{
			if (min == -1 || max == -1 || min > max)
			{
				this.m_N_info_color_slot_adv_group = 0;
				this.m_info_color_slot_adv_group[0] = -1;
				return true;
			}
			for (int i = 0; i < this.m_info_color_slot_adv_group.Length; i++)
			{
				if (min + i <= max)
				{
					this.m_info_color_slot_adv_group[i] = min + i;
					this.m_N_info_color_slot_adv_group = i + 1;
				}
				else
				{
					this.m_info_color_slot_adv_group[i] = -1;
				}
			}
			return true;
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x0002C8DC File Offset: 0x0002AADC
		public void GetInfoSlotPromo(out int min, out int max)
		{
			if (this.m_N_info_slot_promo == 0)
			{
				min = -1;
				max = -1;
				return;
			}
			min = this.m_info_slot_promo[0];
			max = this.m_info_slot_promo[this.m_N_info_slot_promo - 1];
			if (min > max)
			{
				int num = min;
				min = max;
				max = num;
			}
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0002C924 File Offset: 0x0002AB24
		public bool SetInfoSlotPromo(int min, int max)
		{
			if (min == -1 || max == -1 || min > max)
			{
				this.m_N_info_slot_promo = 0;
				this.m_info_slot_promo[0] = -1;
				return true;
			}
			for (int i = 0; i < this.m_info_slot_promo.Length; i++)
			{
				if (min + i <= max)
				{
					this.m_info_slot_promo[i] = min + i;
					this.m_N_info_slot_promo = i + 1;
				}
				else
				{
					this.m_info_slot_promo[i] = -1;
				}
			}
			return true;
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0002C988 File Offset: 0x0002AB88
		public void GetInfoSlotPromoPoss(out int min, out int max)
		{
			if (this.m_N_info_slot_promo_poss == 0)
			{
				min = -1;
				max = -1;
				return;
			}
			min = this.m_info_slot_promo_poss[0];
			max = this.m_info_slot_promo_poss[this.m_N_info_slot_promo_poss - 1];
			if (min > max)
			{
				int num = min;
				min = max;
				max = num;
			}
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0002C9D0 File Offset: 0x0002ABD0
		public bool SetInfoSlotPromoPoss(int min, int max)
		{
			if (min == -1 || max == -1 || min > max)
			{
				this.m_N_info_slot_promo_poss = 0;
				this.m_info_slot_promo_poss[0] = -1;
				return true;
			}
			for (int i = 0; i < this.m_info_slot_promo_poss.Length; i++)
			{
				if (min + i <= max)
				{
					this.m_info_slot_promo_poss[i] = min + i;
					this.m_N_info_slot_promo_poss = i + 1;
				}
				else
				{
					this.m_info_slot_promo_poss[i] = -1;
				}
			}
			return true;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0002CA34 File Offset: 0x0002AC34
		public void GetInfoSlotReleg(out int min, out int max)
		{
			if (this.m_N_info_slot_releg == 0)
			{
				min = -1;
				max = -1;
				return;
			}
			min = this.m_info_slot_releg[0];
			max = this.m_info_slot_releg[this.m_N_info_slot_releg - 1];
			if (min > max)
			{
				int num = min;
				min = max;
				max = num;
			}
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0002CA7C File Offset: 0x0002AC7C
		public bool SetInfoSlotReleg(int min, int max)
		{
			if (min == -1 || max == -1 || min > max)
			{
				this.m_N_info_slot_releg = 0;
				this.m_info_slot_releg[0] = -1;
				return true;
			}
			for (int i = 0; i < this.m_info_slot_releg.Length; i++)
			{
				if (min + i <= max)
				{
					this.m_info_slot_releg[i] = min + i;
					this.m_N_info_slot_releg = i + 1;
				}
				else
				{
					this.m_info_slot_releg[i] = -1;
				}
			}
			return true;
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x0002CAE0 File Offset: 0x0002ACE0
		public void GetInfoSlotRelegPoss(out int min, out int max)
		{
			if (this.m_N_info_slot_releg_poss == 0)
			{
				min = -1;
				max = -1;
				return;
			}
			min = this.m_info_slot_releg_poss[0];
			max = this.m_info_slot_releg_poss[this.m_N_info_slot_releg_poss - 1];
			if (min > max)
			{
				int num = min;
				min = max;
				max = num;
			}
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x0002CB28 File Offset: 0x0002AD28
		public bool SetInfoSlotRelegPoss(int min, int max)
		{
			if (min == -1 || max == -1 || min > max)
			{
				this.m_N_info_slot_releg_poss = 0;
				this.m_info_slot_releg_poss[0] = -1;
				return true;
			}
			for (int i = 0; i < this.m_info_slot_releg_poss.Length; i++)
			{
				if (min + i <= max)
				{
					this.m_info_slot_releg_poss[i] = min + i;
					this.m_N_info_slot_releg_poss = i + 1;
				}
				else
				{
					this.m_info_slot_releg_poss[i] = -1;
				}
			}
			return true;
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060007B2 RID: 1970 RVA: 0x0002CB8C File Offset: 0x0002AD8C
		// (set) Token: 0x060007B3 RID: 1971 RVA: 0x0002CBC0 File Offset: 0x0002ADC0
		public Trophy TrophyCompdependency
		{
			get
			{
				if (this.m_TrophyCompdependency == null && this.m_schedule_compdependency != -1)
				{
					this.m_TrophyCompdependency = (Trophy)FifaEnvironment.CompetitionObjects.SearchId(this.m_schedule_compdependency);
				}
				return this.m_TrophyCompdependency;
			}
			set
			{
				this.m_TrophyCompdependency = value;
				this.m_schedule_compdependency = ((this.m_TrophyCompdependency != null) ? this.m_TrophyCompdependency.Id : (-1));
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x0002CBE5 File Offset: 0x0002ADE5
		// (set) Token: 0x060007B5 RID: 1973 RVA: 0x0002CC19 File Offset: 0x0002AE19
		public Trophy TrophyForcecomp
		{
			get
			{
				if (this.m_TrophyForcecomp == null && this.m_schedule_forcecomp != -1)
				{
					this.m_TrophyForcecomp = (Trophy)FifaEnvironment.CompetitionObjects.SearchId(this.m_schedule_forcecomp);
				}
				return this.m_TrophyForcecomp;
			}
			set
			{
				this.m_TrophyForcecomp = value;
				this.m_schedule_forcecomp = ((this.m_TrophyForcecomp != null) ? this.m_TrophyForcecomp.Id : (-1));
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060007B6 RID: 1974 RVA: 0x0002CC3E File Offset: 0x0002AE3E
		// (set) Token: 0x060007B7 RID: 1975 RVA: 0x0002CC46 File Offset: 0x0002AE46
		public int Advance_maxteamsstageref
		{
			get
			{
				return this.m_advance_maxteamsstageref;
			}
			set
			{
				this.m_advance_maxteamsstageref = value;
				this.UpdateStageReferenceUsingId();
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x0002CC55 File Offset: 0x0002AE55
		// (set) Token: 0x060007B9 RID: 1977 RVA: 0x0002CC5D File Offset: 0x0002AE5D
		public int Advance_standingskeep
		{
			get
			{
				return this.m_advance_standingskeep;
			}
			set
			{
				this.m_advance_standingskeep = value;
				this.UpdateStageReferenceUsingId();
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x0002CC6C File Offset: 0x0002AE6C
		// (set) Token: 0x060007BB RID: 1979 RVA: 0x0002CC74 File Offset: 0x0002AE74
		public int Advance_standingsrank
		{
			get
			{
				return this.m_advance_standingsrank;
			}
			set
			{
				this.m_advance_standingsrank = value;
				this.UpdateStageReferenceUsingId();
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x0002CC83 File Offset: 0x0002AE83
		// (set) Token: 0x060007BD RID: 1981 RVA: 0x0002CC8B File Offset: 0x0002AE8B
		public int Standings_checkrank
		{
			get
			{
				return this.m_standings_checkrank;
			}
			set
			{
				this.m_standings_checkrank = value;
				this.UpdateStageReferenceUsingId();
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x0002CC9A File Offset: 0x0002AE9A
		// (set) Token: 0x060007BF RID: 1983 RVA: 0x0002CCA2 File Offset: 0x0002AEA2
		public League LeaguePromo
		{
			get
			{
				return this.m_LeaguePromo;
			}
			set
			{
				this.m_LeaguePromo = value;
				this.m_info_league_promo = ((this.m_LeaguePromo != null) ? this.m_LeaguePromo.Id : (-1));
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x0002CCC7 File Offset: 0x0002AEC7
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x0002CCCF File Offset: 0x0002AECF
		public League LeagueReleg
		{
			get
			{
				return this.m_LeagueReleg;
			}
			set
			{
				this.m_LeagueReleg = value;
				this.m_info_league_releg = ((this.m_LeagueReleg != null) ? this.m_LeagueReleg.Id : (-1));
			}
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x0002CCF4 File Offset: 0x0002AEF4
		public CompetitionSettings(Compobj compobj)
		{
			this.m_OwnerCompObj = compobj;
			if (compobj.ParentObj != null)
			{
				this.m_ParentSettings = compobj.ParentObj.Settings;
			}
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x0002CF40 File Offset: 0x0002B140
		public void SetProperty(string property, int index, string val)
		{
			if (index == 0)
			{
				this.LoadProperty(property, val);
				return;
			}
			if (property == "match_endruleko1leg")
			{
				if (index < this.m_match_endruleko1leg.Length)
				{
					this.m_match_endruleko1leg[index] = val;
					return;
				}
			}
			else if (property == "match_endruleko2leg2")
			{
				if (index < this.m_match_endruleko2leg2.Length)
				{
					this.m_match_endruleko2leg2[index] = val;
					return;
				}
			}
			else if (property == "standings_sort")
			{
				if (index < this.m_standings_sort.Length)
				{
					this.m_standings_sort[index] = val;
					return;
				}
			}
			else if (property == "info_slot_promo")
			{
				if (index < this.m_info_slot_promo.Length)
				{
					this.m_info_slot_promo[index] = Convert.ToInt32(val);
					return;
				}
			}
			else if (property == "info_slot_promo_poss")
			{
				if (index < this.m_info_slot_promo_poss.Length)
				{
					this.m_info_slot_promo_poss[index] = Convert.ToInt32(val);
					return;
				}
			}
			else if (property == "info_slot_releg")
			{
				if (index < this.m_info_slot_releg.Length)
				{
					this.m_info_slot_releg[index] = Convert.ToInt32(val);
					return;
				}
			}
			else if (property == "info_slot_releg_poss")
			{
				if (index < this.m_info_slot_releg_poss.Length)
				{
					this.m_info_slot_releg_poss[index] = Convert.ToInt32(val);
					return;
				}
			}
			else if (property == "info_color_slot_champ_cup")
			{
				if (index < this.m_info_color_slot_champ_cup.Length)
				{
					this.m_info_color_slot_champ_cup[index] = Convert.ToInt32(val);
					return;
				}
			}
			else if (property == "info_color_slot_euro_league")
			{
				if (index < this.m_info_color_slot_euro_league.Length)
				{
					this.m_info_color_slot_euro_league[index] = Convert.ToInt32(val);
					return;
				}
			}
			else if (property == "info_color_slot_promo")
			{
				if (index < this.m_info_color_slot_promo.Length)
				{
					this.m_info_color_slot_promo[index] = Convert.ToInt32(val);
					return;
				}
			}
			else if (property == "info_color_slot_promo_poss")
			{
				if (index < this.m_info_color_slot_promo_poss.Length)
				{
					this.m_info_color_slot_promo_poss[index] = Convert.ToInt32(val);
					return;
				}
			}
			else if (property == "info_color_slot_releg")
			{
				if (index < this.m_info_color_slot_releg.Length)
				{
					this.m_info_color_slot_releg[index] = Convert.ToInt32(val);
					return;
				}
			}
			else if (property == "info_color_slot_releg_poss")
			{
				if (index < this.m_info_color_slot_releg_poss.Length)
				{
					this.m_info_color_slot_releg_poss[index] = Convert.ToInt32(val);
					return;
				}
			}
			else if (property == "match_stadium")
			{
				if (this.m_match_stadium == null)
				{
					this.m_match_stadium = new int[12];
					for (int i = 0; i < this.m_match_stadium.Length; i++)
					{
						this.m_match_stadium[i] = -1;
					}
				}
				if (index < this.m_match_stadium.Length)
				{
					this.m_match_stadium[index] = Convert.ToInt32(val);
					return;
				}
			}
			else if (property == "info_color_slot_adv_group")
			{
				if (index < this.m_info_color_slot_adv_group.Length)
				{
					this.m_info_color_slot_adv_group[index] = Convert.ToInt32(val);
					return;
				}
			}
			else if (property == "info_special_team_id" && index < this.m_info_special_team_id.Length)
			{
				this.m_info_special_team_id[index] = Convert.ToInt32(val);
			}
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x0002D214 File Offset: 0x0002B414
		public void UpdateIdUsingStageReference()
		{
			this.m_advance_maxteamsstageref = ((this.m_StageAdvanceMaxteamsStageRef != null) ? this.m_StageAdvanceMaxteamsStageRef.Id : (-1));
			this.m_advance_standingskeep = ((this.m_StageAdvanceStandingsKeep != null) ? this.m_StageAdvanceStandingsKeep.Id : (-1));
			this.m_advance_standingsrank = ((this.m_StageAdvanceStandingsRank != null) ? this.m_StageAdvanceStandingsRank.Id : (-1));
			this.m_standings_checkrank = ((this.m_StageStandingsCheckRank != null) ? this.m_StageStandingsCheckRank.Id : (-1));
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0002D294 File Offset: 0x0002B494
		public void UpdateStageReferenceUsingId()
		{
			if (FifaEnvironment.CompetitionObjects == null)
			{
				return;
			}
			Compobj compobj;
			if (this.m_standings_checkrank == -1)
			{
				this.m_StageStandingsCheckRank = null;
			}
			else
			{
				compobj = (Compobj)FifaEnvironment.CompetitionObjects.SearchId(this.m_standings_checkrank);
				if (compobj != null && compobj.IsStage())
				{
					this.m_StageStandingsCheckRank = (Stage)compobj;
				}
				else
				{
					this.m_StageStandingsCheckRank = null;
				}
			}
			if (this.m_advance_standingsrank == -1)
			{
				this.m_StageAdvanceStandingsRank = null;
			}
			else
			{
				compobj = (Compobj)FifaEnvironment.CompetitionObjects.SearchId(this.m_advance_standingsrank);
				if (compobj != null && compobj.IsStage())
				{
					this.m_StageAdvanceStandingsRank = (Stage)compobj;
				}
				else
				{
					this.m_StageAdvanceStandingsRank = null;
				}
			}
			if (this.m_advance_standingskeep == -1)
			{
				this.m_StageAdvanceStandingsKeep = null;
			}
			else
			{
				compobj = (Compobj)FifaEnvironment.CompetitionObjects.SearchId(this.m_advance_standingskeep);
				if (compobj != null && compobj.IsStage())
				{
					this.m_StageAdvanceStandingsKeep = (Stage)compobj;
				}
				else
				{
					this.m_StageAdvanceStandingsKeep = null;
				}
			}
			if (this.m_advance_maxteamsstageref == -1)
			{
				this.m_StageAdvanceMaxteamsStageRef = null;
				return;
			}
			compobj = (Compobj)FifaEnvironment.CompetitionObjects.SearchId(this.m_advance_maxteamsstageref);
			if (compobj != null && compobj.IsStage())
			{
				this.m_StageAdvanceMaxteamsStageRef = (Stage)compobj;
				return;
			}
			this.m_StageAdvanceMaxteamsStageRef = null;
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x0002D3CC File Offset: 0x0002B5CC
		public bool IsStringProperty(string property)
		{
			return property == "comp_type" || property == "rule_bookings" || property == "rule_offsides" || property == "rule_injuries" || property == "match_stagetype" || property == "match_matchsituation" || property == "match_endruleleague" || property == "match_endruleko1leg" || property == "match_endruleko2leg1" || property == "match_endruleko2leg2" || property == "match_endrulefriendly" || property == "standings_sort" || property == "schedule_seasonstartmonth";
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x0002D4A0 File Offset: 0x0002B6A0
		public int IsMultipleProperty(string property)
		{
			if (property == "match_endruleko1leg")
			{
				return this.m_match_endruleko1leg.Length;
			}
			if (property == "match_endruleko2leg2")
			{
				return this.m_match_endruleko2leg2.Length;
			}
			if (property == "standings_sort")
			{
				return this.m_standings_sort.Length;
			}
			if (property == "info_slot_promo")
			{
				return this.m_info_slot_promo.Length;
			}
			if (property == "info_slot_promo_poss")
			{
				return this.m_info_slot_promo_poss.Length;
			}
			if (property == "info_slot_releg")
			{
				return this.m_info_slot_releg.Length;
			}
			if (property == "info_slot_releg_poss")
			{
				return this.m_info_slot_releg_poss.Length;
			}
			if (property == "info_color_slot_champ_cup")
			{
				return this.m_info_color_slot_champ_cup.Length;
			}
			if (property == "info_color_slot_euro_league")
			{
				return this.m_info_color_slot_euro_league.Length;
			}
			if (property == "info_color_slot_promo")
			{
				return this.m_info_color_slot_promo.Length;
			}
			if (property == "info_color_slot_promo_poss")
			{
				return this.m_info_color_slot_promo_poss.Length;
			}
			if (property == "info_color_slot_releg")
			{
				return this.m_info_color_slot_releg.Length;
			}
			if (property == "info_color_slot_releg_poss")
			{
				return this.m_info_color_slot_releg_poss.Length;
			}
			if (property == "match_stadium")
			{
				return this.m_match_stadium.Length;
			}
			if (property == "info_color_slot_adv_group")
			{
				return this.m_info_color_slot_adv_group.Length;
			}
			if (property == "info_special_team_id")
			{
				return this.m_info_special_team_id.Length;
			}
			return 1;
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x0002D610 File Offset: 0x0002B810
		public string GetProperty(string property, int index, out bool isSpecific)
		{
			string text = this.GetSpecificProperty(property, index);
			isSpecific = false;
			if (text != null && text != "-1")
			{
				isSpecific = true;
				return text;
			}
			if (this.m_ParentSettings != null)
			{
				bool flag;
				text = this.m_ParentSettings.GetProperty(property, index, out flag);
			}
			if (text == null)
			{
				text = string.Empty;
			}
			return text;
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x0002D660 File Offset: 0x0002B860
		public void LoadProperty(string property, string val)
		{
			if (property == "comp_type")
			{
				this.m_comp_type = val;
				return;
			}
			if (property == "rule_bookings")
			{
				this.m_rule_bookings = val;
				return;
			}
			if (property == "rule_offsides")
			{
				this.m_rule_offsides = val;
				return;
			}
			if (property == "rule_injuries")
			{
				this.m_rule_injuries = val;
				return;
			}
			if (property == "rule_numsubsbench")
			{
				this.m_rule_numsubsbench = Convert.ToInt32(val);
				return;
			}
			if (property == "rule_numsubsmatch")
			{
				this.m_rule_numsubsmatch = Convert.ToInt32(val);
				return;
			}
			if (property == "rule_suspension")
			{
				this.m_rule_suspension = Convert.ToInt32(val);
				return;
			}
			if (property == "rule_numyellowstored")
			{
				this.m_rule_numyellowstored = Convert.ToInt32(val);
				return;
			}
			if (property == "rule_numgamesbanredmax")
			{
				this.m_rule_numgamesbanredmax = Convert.ToInt32(val);
				return;
			}
			if (property == "rule_numgamesbanredmin")
			{
				this.m_rule_numgamesbanredmin = Convert.ToInt32(val);
				return;
			}
			if (property == "rule_numgamesbandoubleyellowmax")
			{
				this.m_rule_numgamesbandoubleyellowmax = Convert.ToInt32(val);
				return;
			}
			if (property == "rule_numgamesbandoubleyellowmin")
			{
				this.m_rule_numgamesbandoubleyellowmin = Convert.ToInt32(val);
				return;
			}
			if (property == "rule_numgamesbanyellowsmax")
			{
				this.m_rule_numgamesbanyellowsmax = Convert.ToInt32(val);
				return;
			}
			if (property == "rule_numgamesbanyellowsmin")
			{
				this.m_rule_numgamesbanyellowsmin = Convert.ToInt32(val);
				return;
			}
			if (property == "standings_pointswin")
			{
				this.m_standings_pointswin = Convert.ToInt32(val);
				return;
			}
			if (property == "standings_pointsdraw")
			{
				this.m_standings_pointsdraw = Convert.ToInt32(val);
				return;
			}
			if (property == "standings_pointsloss")
			{
				this.m_standings_pointsloss = Convert.ToInt32(val);
				return;
			}
			if (property == "match_matchimportance")
			{
				this.m_match_matchimportance = Convert.ToInt32(val);
				return;
			}
			if (property == "match_stagetype")
			{
				this.m_match_stagetype = val;
				return;
			}
			if (property == "match_matchsituation")
			{
				this.m_match_matchsituation = val;
				return;
			}
			if (property == "nation_id")
			{
				this.m_nation_id = Convert.ToInt32(val);
				return;
			}
			if (property == "asset_id")
			{
				this.m_asset_id = Convert.ToInt32(val);
				return;
			}
			if (property == "match_endruleleague")
			{
				this.m_match_endruleleague = val;
				return;
			}
			if (property == "match_endruleko1leg")
			{
				this.m_match_endruleko1leg[this.m_N_endruleko1leg] = val;
				this.m_N_endruleko1leg++;
				this.m_EndRuleKo1Leg = CompetitionSettings.GetKo1Rule(this.m_match_endruleko1leg);
				return;
			}
			if (property == "match_endruleko2leg1")
			{
				this.m_match_endruleko2leg1 = val;
				return;
			}
			if (property == "match_endruleko2leg2")
			{
				this.m_match_endruleko2leg2[this.m_N_endruleko2leg2] = val;
				this.m_N_endruleko2leg2++;
				this.m_EndRuleKo2Leg2 = CompetitionSettings.GetKo2Rule(this.m_match_endruleko2leg2);
				return;
			}
			if (property == "match_endrulefriendly")
			{
				this.m_match_endrulefriendly = val;
				return;
			}
			if (property == "info_prize_money")
			{
				this.m_info_prize_money = Convert.ToInt32(val);
				return;
			}
			if (property == "info_prize_money_drop")
			{
				this.m_info_prize_money_drop = Convert.ToInt32(val);
				return;
			}
			if (property == "standings_sort")
			{
				this.m_standings_sort[this.m_N_standings_sort] = val;
				this.m_N_standings_sort++;
				this.m_StandingsSort = CompetitionSettings.GetStandingRule(this.m_standings_sort);
				return;
			}
			if (property == "schedule_seasonstartmonth")
			{
				this.m_schedule_seasonstartmonth = val;
				return;
			}
			if (property == "schedule_year_start")
			{
				this.m_schedule_year_start = Convert.ToInt32(val);
				return;
			}
			if (property == "schedule_year_offset")
			{
				this.m_schedule_year_offset = Convert.ToInt32(val);
				return;
			}
			if (property == "schedule_friendlydaysbetweenmin")
			{
				this.m_schedule_friendlydaysbetweenmin = Convert.ToInt32(val);
				return;
			}
			if (property == "schedule_friendlydaysbefore")
			{
				this.m_schedule_friendlydaysbefore = Convert.ToInt32(val);
				return;
			}
			if (property == "schedule_use_dates_comp")
			{
				this.m_schedule_use_dates_comp = Convert.ToInt32(val);
				return;
			}
			if (property == "info_slot_champ")
			{
				this.m_info_slot_champ = Convert.ToInt32(val);
				return;
			}
			if (property == "info_color_slot_champ")
			{
				this.m_info_color_slot_champ = Convert.ToInt32(val);
				return;
			}
			if (property == "info_slot_promo")
			{
				if (this.m_info_slot_promo == null)
				{
					this.m_info_slot_promo = new int[4];
				}
				if (this.m_N_info_slot_promo < this.m_info_slot_promo.Length)
				{
					this.m_info_slot_promo[this.m_N_info_slot_promo] = Convert.ToInt32(val);
					this.m_N_info_slot_promo++;
					return;
				}
			}
			else if (property == "info_slot_promo_poss")
			{
				if (this.m_info_slot_promo_poss == null)
				{
					this.m_info_slot_promo_poss = new int[4];
				}
				if (this.m_N_info_slot_promo_poss < this.m_info_slot_promo_poss.Length)
				{
					this.m_info_slot_promo_poss[this.m_N_info_slot_promo_poss] = Convert.ToInt32(val);
					this.m_N_info_slot_promo_poss++;
					return;
				}
			}
			else if (property == "info_slot_releg")
			{
				if (this.m_info_slot_releg == null)
				{
					this.m_info_slot_releg = new int[4];
				}
				if (this.m_N_info_slot_releg < this.m_info_slot_releg.Length)
				{
					this.m_info_slot_releg[this.m_N_info_slot_releg] = Convert.ToInt32(val);
					this.m_N_info_slot_releg++;
					return;
				}
			}
			else if (property == "info_slot_releg_poss")
			{
				if (this.m_info_slot_releg_poss == null)
				{
					this.m_info_slot_releg_poss = new int[4];
				}
				if (this.m_N_info_slot_releg_poss < this.m_info_slot_releg_poss.Length)
				{
					this.m_info_slot_releg_poss[this.m_N_info_slot_releg_poss] = Convert.ToInt32(val);
					this.m_N_info_slot_releg_poss++;
					return;
				}
			}
			else if (property == "info_color_slot_champ_cup")
			{
				if (this.m_info_color_slot_champ_cup == null)
				{
					this.m_info_color_slot_champ_cup = new int[3];
				}
				if (this.m_N_info_color_slot_champ_cup < this.m_info_color_slot_champ_cup.Length)
				{
					this.m_info_color_slot_champ_cup[this.m_N_info_color_slot_champ_cup] = Convert.ToInt32(val);
					this.m_N_info_color_slot_champ_cup++;
					return;
				}
			}
			else if (property == "info_color_slot_euro_league")
			{
				if (this.m_info_color_slot_euro_league == null)
				{
					this.m_info_color_slot_euro_league = new int[4];
				}
				if (this.m_N_info_color_slot_euro_league < this.m_info_color_slot_euro_league.Length)
				{
					this.m_info_color_slot_euro_league[this.m_N_info_color_slot_euro_league] = Convert.ToInt32(val);
					this.m_N_info_color_slot_euro_league++;
					return;
				}
			}
			else if (property == "info_color_slot_promo")
			{
				if (this.m_info_color_slot_promo == null)
				{
					this.m_info_color_slot_promo = new int[4];
				}
				if (this.m_N_info_color_slot_promo < this.m_info_color_slot_promo.Length)
				{
					this.m_info_color_slot_promo[this.m_N_info_color_slot_promo] = Convert.ToInt32(val);
					this.m_N_info_color_slot_promo++;
					return;
				}
			}
			else if (property == "info_color_slot_promo_poss")
			{
				if (this.m_info_color_slot_promo_poss == null)
				{
					this.m_info_color_slot_promo_poss = new int[4];
				}
				if (this.m_N_info_color_slot_promo_poss < this.m_info_color_slot_promo_poss.Length)
				{
					this.m_info_color_slot_promo_poss[this.m_N_info_color_slot_promo_poss] = Convert.ToInt32(val);
					this.m_N_info_color_slot_promo_poss++;
					return;
				}
			}
			else if (property == "info_color_slot_releg")
			{
				if (this.m_info_color_slot_releg == null)
				{
					this.m_info_color_slot_releg = new int[4];
				}
				if (this.m_N_info_color_slot_releg < this.m_info_color_slot_releg.Length)
				{
					this.m_info_color_slot_releg[this.m_N_info_color_slot_releg] = Convert.ToInt32(val);
					this.m_N_info_color_slot_releg++;
					return;
				}
			}
			else if (property == "info_color_slot_releg_poss")
			{
				if (this.m_info_color_slot_releg_poss == null)
				{
					this.m_info_color_slot_releg_poss = new int[4];
				}
				if (this.m_N_info_color_slot_releg_poss < this.m_info_color_slot_releg_poss.Length)
				{
					this.m_info_color_slot_releg_poss[this.m_N_info_color_slot_releg_poss] = Convert.ToInt32(val);
					this.m_N_info_color_slot_releg_poss++;
					return;
				}
			}
			else
			{
				if (property == "num_games")
				{
					this.m_num_games = Convert.ToInt32(val);
					return;
				}
				if (property == "advance_pointskeep")
				{
					this.m_advance_pointskeep = Convert.ToInt32(val);
					return;
				}
				if (property == "advance_pointskeeppercentage")
				{
					this.m_advance_pointskeeppercentage = Convert.ToInt32(val);
					return;
				}
				if (property == "advance_matchupkeep")
				{
					this.m_advance_matchupkeep = Convert.ToInt32(val);
					return;
				}
				if (property == "match_stadium")
				{
					if (this.m_match_stadium == null)
					{
						this.m_match_stadium = new int[12];
						for (int i = 0; i < this.m_match_stadium.Length; i++)
						{
							this.m_match_stadium[i] = -1;
						}
					}
					this.m_match_stadium[0] = Convert.ToInt32(val);
					return;
				}
				if (property == "info_color_slot_adv_group")
				{
					if (this.m_info_color_slot_adv_group == null)
					{
						this.m_info_color_slot_adv_group = new int[8];
					}
					if (this.m_N_info_color_slot_adv_group < this.m_info_color_slot_adv_group.Length)
					{
						this.m_info_color_slot_adv_group[this.m_N_info_color_slot_adv_group] = Convert.ToInt32(val);
						this.m_N_info_color_slot_adv_group++;
						return;
					}
				}
				else
				{
					if (property == "advance_standingsrank")
					{
						this.Advance_standingsrank = Convert.ToInt32(val);
						return;
					}
					if (property == "asset_id")
					{
						this.m_asset_id = Convert.ToInt32(val);
						return;
					}
					if (property == "rule_numsubsmatch")
					{
						this.m_rule_numsubsmatch = Convert.ToInt32(val);
						return;
					}
					if (property == "schedule_checkconflict")
					{
						this.m_schedule_checkconflict = Convert.ToInt32(val);
						return;
					}
					if (property == "schedule_compdependency")
					{
						this.m_schedule_compdependency = Convert.ToInt32(val);
						return;
					}
					if (property == "schedule_internationaldependency")
					{
						this.m_schedule_internationaldependency = Convert.ToInt32(val);
						return;
					}
					if (property == "schedule_forcecomp")
					{
						this.m_schedule_forcecomp = Convert.ToInt32(val);
						return;
					}
					if (property == "advance_teamcompdependency")
					{
						this.m_advance_teamcompdependency = Convert.ToInt32(val);
						return;
					}
					if (property == "info_league_promo")
					{
						this.m_info_league_promo = Convert.ToInt32(val);
						return;
					}
					if (property == "info_league_releg")
					{
						this.m_info_league_releg = Convert.ToInt32(val);
						return;
					}
					if (property == "info_special_team_id")
					{
						this.m_info_special_team_id[this.m_N_info_special_team_id] = Convert.ToInt32(val);
						this.m_N_info_special_team_id++;
						return;
					}
					if (property == "advance_random_draw_event")
					{
						this.m_advance_random_draw_event = Convert.ToInt32(val);
						return;
					}
					if (property == "advance_randomdraw")
					{
						this.m_advance_randomdraw = Convert.ToInt32(val);
						return;
					}
					if (property == "advance_calccompavgs")
					{
						this.m_advance_calccompavgs = Convert.ToInt32(val);
						return;
					}
					if (property == "advance_maxteamsassoc")
					{
						this.m_advance_maxteamsassoc = Convert.ToInt32(val);
						return;
					}
					if (property == "advance_maxteamsgroup")
					{
						this.m_advance_maxteamsgroup = Convert.ToInt32(val);
						return;
					}
					if (property == "advance_maxteamsstageref")
					{
						this.Advance_maxteamsstageref = Convert.ToInt32(val);
						return;
					}
					if (property == "advance_standingskeep")
					{
						this.Advance_standingskeep = Convert.ToInt32(val);
						return;
					}
					if (property == "advance_standingsrank")
					{
						this.Advance_standingsrank = Convert.ToInt32(val);
						return;
					}
					if (property == "schedule_matchreplay")
					{
						this.m_schedule_matchreplay = Convert.ToInt32(val);
						return;
					}
					if (property == "schedule_reversed")
					{
						this.m_schedule_reversed = Convert.ToInt32(val);
						return;
					}
					if (property == "schedule_year_real")
					{
						this.m_schedule_year_real = Convert.ToInt32(val);
						return;
					}
					if (property == "standings_checkrank")
					{
						this.Standings_checkrank = Convert.ToInt32(val);
					}
				}
			}
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x0002E14C File Offset: 0x0002C34C
		public string GetSpecificProperty(string property, int index)
		{
			if (property == "comp_type")
			{
				return this.m_comp_type;
			}
			if (property == "rule_bookings")
			{
				return this.m_rule_bookings;
			}
			if (property == "rule_offsides")
			{
				return this.m_rule_offsides;
			}
			if (property == "rule_injuries")
			{
				return this.m_rule_injuries;
			}
			if (property == "rule_numsubsbench")
			{
				return this.m_rule_numsubsbench.ToString();
			}
			if (property == "rule_numsubsmatch")
			{
				return this.m_rule_numsubsmatch.ToString();
			}
			if (property == "rule_suspension")
			{
				return this.m_rule_suspension.ToString();
			}
			if (property == "rule_numyellowstored")
			{
				return this.m_rule_numyellowstored.ToString();
			}
			if (property == "rule_numgamesbanredmax")
			{
				return this.m_rule_numgamesbanredmax.ToString();
			}
			if (property == "rule_numgamesbanredmin")
			{
				return this.m_rule_numgamesbanredmin.ToString();
			}
			if (property == "rule_numgamesbandoubleyellowmax")
			{
				return this.m_rule_numgamesbandoubleyellowmax.ToString();
			}
			if (property == "rule_numgamesbandoubleyellowmin")
			{
				return this.m_rule_numgamesbandoubleyellowmin.ToString();
			}
			if (property == "rule_numgamesbanyellowsmax")
			{
				return this.m_rule_numgamesbanyellowsmax.ToString();
			}
			if (property == "rule_numgamesbanyellowsmin")
			{
				return this.m_rule_numgamesbanyellowsmin.ToString();
			}
			if (property == "standings_pointswin")
			{
				return this.m_standings_pointswin.ToString();
			}
			if (property == "standings_pointsdraw")
			{
				return this.m_standings_pointsdraw.ToString();
			}
			if (property == "standings_pointsloss")
			{
				return this.m_standings_pointsloss.ToString();
			}
			if (property == "match_matchimportance")
			{
				return this.m_match_matchimportance.ToString();
			}
			if (property == "match_stagetype")
			{
				return this.m_match_stagetype;
			}
			if (property == "match_matchsituation")
			{
				return this.m_match_matchsituation;
			}
			if (property == "nation_id")
			{
				return this.m_nation_id.ToString();
			}
			if (property == "asset_id")
			{
				return this.m_asset_id.ToString();
			}
			if (property == "match_endruleleague")
			{
				return this.m_match_endruleleague;
			}
			if (property == "match_endruleko1leg")
			{
				return this.m_match_endruleko1leg[this.m_N_endruleko1leg];
			}
			if (property == "match_endruleko2leg1")
			{
				return this.m_match_endruleko2leg1;
			}
			if (property == "match_endruleko2leg2")
			{
				return this.m_match_endruleko2leg2[index];
			}
			if (property == "match_endrulefriendly")
			{
				return this.m_match_endrulefriendly;
			}
			if (property == "info_prize_money")
			{
				return this.m_info_prize_money.ToString();
			}
			if (property == "info_prize_money_drop")
			{
				return this.m_info_prize_money_drop.ToString();
			}
			if (property == "standings_sort")
			{
				return this.m_standings_sort[index];
			}
			if (property == "schedule_seasonstartmonth")
			{
				return this.m_schedule_seasonstartmonth;
			}
			if (property == "schedule_year_start")
			{
				return this.m_schedule_year_start.ToString();
			}
			if (property == "schedule_year_offset")
			{
				return this.m_schedule_year_offset.ToString();
			}
			if (property == "schedule_friendlydaysbetweenmin")
			{
				return this.m_schedule_friendlydaysbetweenmin.ToString();
			}
			if (property == "schedule_friendlydaysbefore")
			{
				return this.m_schedule_friendlydaysbetweenmin.ToString();
			}
			if (property == "schedule_use_dates_comp")
			{
				return this.m_schedule_use_dates_comp.ToString();
			}
			if (property == "info_slot_champ")
			{
				return this.m_info_slot_champ.ToString();
			}
			if (property == "info_color_slot_champ")
			{
				return this.m_info_color_slot_champ.ToString();
			}
			if (property == "info_slot_promo")
			{
				if (this.m_N_info_slot_promo < this.m_info_slot_promo.Length)
				{
					return this.m_info_slot_promo[index].ToString();
				}
			}
			else if (property == "info_slot_promo_poss")
			{
				if (this.m_N_info_slot_promo_poss < this.m_info_slot_promo_poss.Length)
				{
					return this.m_info_slot_promo_poss[index].ToString();
				}
			}
			else if (property == "info_slot_releg")
			{
				if (this.m_N_info_slot_releg < this.m_info_slot_releg.Length)
				{
					return this.m_info_slot_releg[index].ToString();
				}
			}
			else if (property == "info_slot_releg_poss")
			{
				if (this.m_N_info_slot_releg_poss < this.m_info_slot_releg_poss.Length)
				{
					return this.m_info_slot_releg_poss[index].ToString();
				}
			}
			else if (property == "info_color_slot_champ_cup")
			{
				if (this.m_N_info_color_slot_champ_cup < this.m_info_color_slot_champ_cup.Length)
				{
					return this.m_info_color_slot_champ_cup[index].ToString();
				}
			}
			else if (property == "info_color_slot_euro_league")
			{
				if (this.m_N_info_color_slot_euro_league < this.m_info_color_slot_euro_league.Length)
				{
					return this.m_info_color_slot_euro_league[index].ToString();
				}
			}
			else if (property == "info_color_slot_promo")
			{
				if (this.m_N_info_color_slot_promo < this.m_info_color_slot_promo.Length)
				{
					return this.m_info_color_slot_promo[index].ToString();
				}
			}
			else if (property == "info_color_slot_promo_poss")
			{
				if (this.m_N_info_color_slot_promo_poss < this.m_info_color_slot_promo_poss.Length)
				{
					return this.m_info_color_slot_promo_poss[index].ToString();
				}
			}
			else if (property == "info_color_slot_releg")
			{
				if (this.m_N_info_color_slot_releg < this.m_info_color_slot_releg.Length)
				{
					return this.m_info_color_slot_releg[index].ToString();
				}
			}
			else if (property == "info_color_slot_releg_poss")
			{
				if (this.m_N_info_color_slot_releg_poss < this.m_info_color_slot_releg_poss.Length)
				{
					return this.m_info_color_slot_releg_poss[index].ToString();
				}
			}
			else
			{
				if (property == "num_games")
				{
					return this.m_num_games.ToString();
				}
				if (property == "advance_pointskeep")
				{
					return this.m_advance_pointskeep.ToString();
				}
				if (property == "advance_pointskeeppercentage")
				{
					return this.m_advance_pointskeeppercentage.ToString();
				}
				if (property == "advance_matchupkeep")
				{
					return this.m_advance_matchupkeep.ToString();
				}
				if (property == "match_stadium")
				{
					if (index < this.m_match_stadium.Length)
					{
						return this.m_match_stadium[index].ToString();
					}
				}
				else if (property == "info_color_slot_adv_group")
				{
					if (this.m_N_info_color_slot_adv_group < this.m_info_color_slot_adv_group.Length)
					{
						return this.m_info_color_slot_adv_group[index].ToString();
					}
				}
				else if (property == "advance_standingsrank")
				{
					return this.m_advance_standingsrank.ToString();
				}
			}
			if (property == "asset_id")
			{
				return this.m_asset_id.ToString();
			}
			if (property == "rule_numsubsmatch")
			{
				return this.m_rule_numsubsmatch.ToString();
			}
			if (property == "schedule_checkconflict")
			{
				return this.m_schedule_checkconflict.ToString();
			}
			if (property == "schedule_compdependency")
			{
				return this.m_schedule_compdependency.ToString();
			}
			if (property == "schedule_internationaldependency")
			{
				return this.m_schedule_internationaldependency.ToString();
			}
			if (property == "schedule_forcecomp")
			{
				return this.m_schedule_forcecomp.ToString();
			}
			if (property == "advance_teamcompdependency")
			{
				return this.m_advance_teamcompdependency.ToString();
			}
			if (property == "info_league_promo")
			{
				return this.m_info_league_promo.ToString();
			}
			if (property == "info_league_releg")
			{
				return this.m_info_league_releg.ToString();
			}
			if (property == "info_special_team_id")
			{
				return this.m_info_special_team_id[index].ToString();
			}
			if (property == "advance_random_draw_rvrny")
			{
				return this.m_advance_random_draw_event.ToString();
			}
			if (property == "advance_randomdraw")
			{
				return this.m_advance_randomdraw.ToString();
			}
			if (property == "advance_calccompavgs")
			{
				return this.m_advance_calccompavgs.ToString();
			}
			if (property == "advance_maxteamsassoc")
			{
				return this.m_advance_maxteamsassoc.ToString();
			}
			if (property == "advance_maxteamsgroup")
			{
				return this.m_advance_maxteamsgroup.ToString();
			}
			if (property == "advance_maxteamsstageref")
			{
				return this.m_advance_maxteamsstageref.ToString();
			}
			if (property == "advance_standingskeep")
			{
				return this.m_advance_standingskeep.ToString();
			}
			if (property == "advance_standingsrank")
			{
				return this.m_advance_standingsrank.ToString();
			}
			if (property == "schedule_matchreplay")
			{
				return this.m_schedule_matchreplay.ToString();
			}
			if (property == "schedule_reversed")
			{
				return this.m_schedule_reversed.ToString();
			}
			if (property == "schedule_year_real")
			{
				return this.m_schedule_year_real.ToString();
			}
			if (property == "standings_checkrank")
			{
				return this.m_standings_checkrank.ToString();
			}
			return null;
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x0002E9D0 File Offset: 0x0002CBD0
		public bool SaveToSettings(int id, StreamWriter w)
		{
			if (w == null)
			{
				return false;
			}
			if (this.m_asset_id != -1)
			{
				string text = id + ",asset_id," + this.m_asset_id;
				w.WriteLine(text);
			}
			if (this.m_comp_type != null)
			{
				string text = id + ",comp_type," + this.m_comp_type;
				w.WriteLine(text);
			}
			if (this.m_nation_id != -1)
			{
				string text = id + ",nation_id," + this.m_nation_id;
				w.WriteLine(text);
			}
			if (this.m_rule_bookings != null)
			{
				string text = id + ",rule_bookings," + this.m_rule_bookings;
				w.WriteLine(text);
			}
			if (this.m_rule_offsides != null)
			{
				string text = id + ",rule_offsides," + this.m_rule_offsides;
				w.WriteLine(text);
			}
			if (this.m_rule_injuries != null)
			{
				string text = id + ",rule_injuries," + this.m_rule_injuries;
				w.WriteLine(text);
			}
			if (this.m_rule_numsubsbench != -1)
			{
				string text = id + ",rule_numsubsbench," + this.m_rule_numsubsbench;
				w.WriteLine(text);
			}
			if (this.m_rule_numsubsmatch != -1)
			{
				string text = id + ",rule_numsubsmatch," + this.m_rule_numsubsmatch;
				w.WriteLine(text);
			}
			if (this.m_rule_suspension != -1)
			{
				string text = id + ",rule_suspension," + this.m_rule_suspension;
				w.WriteLine(text);
			}
			if (this.m_rule_numyellowstored != -1)
			{
				string text = id + ",rule_numyellowstored," + this.m_rule_numyellowstored;
				w.WriteLine(text);
			}
			if (this.m_rule_numgamesbanredmax != -1)
			{
				string text = id + ",rule_numgamesbanredmax," + this.m_rule_numgamesbanredmax;
				w.WriteLine(text);
			}
			if (this.m_rule_numgamesbanredmin != -1)
			{
				string text = id + ",rule_numgamesbanredmin," + this.m_rule_numgamesbanredmin;
				w.WriteLine(text);
			}
			if (this.m_rule_numgamesbandoubleyellowmax != -1)
			{
				string text = id + ",rule_numgamesbandoubleyellowmax," + this.m_rule_numgamesbandoubleyellowmax;
				w.WriteLine(text);
			}
			if (this.m_rule_numgamesbandoubleyellowmin != -1)
			{
				string text = id + ",rule_numgamesbandoubleyellowmin," + this.m_rule_numgamesbandoubleyellowmin;
				w.WriteLine(text);
			}
			if (this.m_rule_numgamesbanyellowsmax != -1)
			{
				string text = id + ",rule_numgamesbanyellowsmax," + this.m_rule_numgamesbanyellowsmax;
				w.WriteLine(text);
			}
			if (this.m_rule_numgamesbanyellowsmin != -1)
			{
				string text = id + ",rule_numgamesbanyellowsmin," + this.m_rule_numgamesbanyellowsmin;
				w.WriteLine(text);
			}
			if (this.m_standings_pointswin != -1)
			{
				string text = id + ",standings_pointswin," + this.m_standings_pointswin;
				w.WriteLine(text);
			}
			if (this.m_standings_pointsdraw != -1)
			{
				string text = id + ",standings_pointsdraw," + this.m_standings_pointsdraw;
				w.WriteLine(text);
			}
			if (this.m_standings_pointsloss != -1)
			{
				string text = id + ",standings_pointsloss," + this.m_standings_pointsloss;
				w.WriteLine(text);
			}
			if (this.m_standings_checkrank != -1)
			{
				string text = id + ",standings_checkrank," + this.m_standings_checkrank;
				w.WriteLine(text);
			}
			if (this.m_schedule_seasonstartmonth != null)
			{
				string text = id + ",schedule_seasonstartmonth," + this.m_schedule_seasonstartmonth;
				w.WriteLine(text);
			}
			if (this.m_schedule_year_start != -1)
			{
				string text = id + ",schedule_year_start," + this.m_schedule_year_start;
				w.WriteLine(text);
			}
			if (this.m_schedule_year_offset != -1)
			{
				string text = id + ",schedule_year_offset," + this.m_schedule_year_offset;
				w.WriteLine(text);
			}
			if (this.m_schedule_friendlydaysbetweenmin != -1)
			{
				string text = id + ",schedule_friendlydaysbetweenmin," + this.m_schedule_friendlydaysbetweenmin;
				w.WriteLine(text);
			}
			if (this.m_schedule_friendlydaysbefore != -1)
			{
				string text = id + ",schedule_friendlydaysbefore," + this.m_schedule_friendlydaysbefore;
				w.WriteLine(text);
			}
			if (this.m_schedule_internationaldependency != -1)
			{
				string text = id + ",schedule_internationaldependency," + this.m_schedule_internationaldependency;
				w.WriteLine(text);
			}
			if (this.m_schedule_use_dates_comp != -1)
			{
				string text = id + ",schedule_use_dates_comp," + this.m_schedule_use_dates_comp;
				w.WriteLine(text);
			}
			if (this.m_schedule_checkconflict == 1)
			{
				string text = id + ",schedule_checkconflict," + this.m_schedule_checkconflict;
				w.WriteLine(text);
			}
			if (this.TrophyCompdependency != null)
			{
				string text = id + ",schedule_compdependency," + this.m_TrophyCompdependency.Id;
				w.WriteLine(text);
			}
			if (this.TrophyForcecomp != null)
			{
				string text = id + ",schedule_forcecomp," + this.m_TrophyForcecomp.Id;
				w.WriteLine(text);
			}
			if (this.m_schedule_matchreplay != -1)
			{
				string text = id + ",schedule_matchreplay," + this.m_schedule_matchreplay;
				w.WriteLine(text);
			}
			if (this.m_schedule_reversed != -1)
			{
				string text = id + ",schedule_reversed," + this.m_schedule_reversed;
				w.WriteLine(text);
			}
			if (this.m_schedule_year_real != -1)
			{
				string text = id + ",schedule_year_real," + this.m_schedule_year_real;
				w.WriteLine(text);
			}
			if (this.m_match_matchimportance != -1)
			{
				string text = id + ",match_matchimportance," + this.m_match_matchimportance;
				w.WriteLine(text);
			}
			if (this.m_match_stagetype != null)
			{
				string text = id + ",match_stagetype," + this.m_match_stagetype;
				w.WriteLine(text);
			}
			if (this.m_match_matchsituation != null)
			{
				string text = id + ",match_matchsituation," + this.m_match_matchsituation;
				w.WriteLine(text);
			}
			if (this.m_match_endruleleague != null)
			{
				string text = id + ",match_endruleleague," + this.m_match_endruleleague;
				w.WriteLine(text);
			}
			this.m_N_endruleko1leg = CompetitionSettings.SetKo1Rule(this.m_EndRuleKo1Leg, ref this.m_match_endruleko1leg);
			for (int i = 0; i < this.m_N_endruleko1leg; i++)
			{
				string text = id + ",match_endruleko1leg," + this.m_match_endruleko1leg[i];
				w.WriteLine(text);
			}
			if (this.m_match_endruleko2leg1 != null)
			{
				string text = id + ",match_endruleko2leg1," + this.m_match_endruleko2leg1;
				w.WriteLine(text);
			}
			this.m_N_endruleko2leg2 = CompetitionSettings.SetKo2Rule(this.m_EndRuleKo2Leg2, ref this.m_match_endruleko2leg2);
			for (int j = 0; j < this.m_N_endruleko2leg2; j++)
			{
				string text = id + ",match_endruleko2leg2," + this.m_match_endruleko2leg2[j];
				w.WriteLine(text);
			}
			if (this.m_match_endrulefriendly != null)
			{
				string text = id + ",match_endrulefriendly," + this.m_match_endrulefriendly;
				w.WriteLine(text);
			}
			if (this.m_match_stadium != null)
			{
				for (int k = 0; k < this.m_match_stadium.Length; k++)
				{
					if (this.m_match_stadium[k] >= 0)
					{
						string text = id + ",match_stadium," + this.m_match_stadium[k];
						w.WriteLine(text);
					}
				}
			}
			if (this.m_info_prize_money != -1)
			{
				string text = id + ",info_prize_money," + this.m_info_prize_money;
				w.WriteLine(text);
			}
			if (this.m_info_prize_money_drop != -1)
			{
				string text = id + ",info_prize_money_drop," + this.m_info_prize_money_drop;
				w.WriteLine(text);
			}
			this.m_N_standings_sort = CompetitionSettings.SetStandingRule(this.m_StandingsSort, ref this.m_standings_sort);
			for (int l = 0; l < this.m_N_standings_sort; l++)
			{
				string text = id + ",standings_sort," + this.m_standings_sort[l];
				w.WriteLine(text);
			}
			if (this.m_num_games != -1)
			{
				string text = id + ",num_games," + this.m_num_games;
				w.WriteLine(text);
			}
			if (this.m_info_color_slot_champ != -1)
			{
				string text = id + ",info_color_slot_champ," + this.m_info_color_slot_champ;
				w.WriteLine(text);
			}
			for (int m = 0; m < this.m_N_info_color_slot_champ_cup; m++)
			{
				string text = id + ",info_color_slot_champ_cup," + this.m_info_color_slot_champ_cup[m];
				w.WriteLine(text);
			}
			for (int n = 0; n < this.m_N_info_color_slot_euro_league; n++)
			{
				string text = id + ",info_color_slot_euro_league," + this.m_info_color_slot_euro_league[n];
				w.WriteLine(text);
			}
			for (int num = 0; num < this.m_N_info_color_slot_promo; num++)
			{
				string text = id + ",info_color_slot_promo," + this.m_info_color_slot_promo[num];
				w.WriteLine(text);
			}
			for (int num2 = 0; num2 < this.m_N_info_color_slot_promo_poss; num2++)
			{
				string text = id + ",info_color_slot_promo_poss," + this.m_info_color_slot_promo_poss[num2];
				w.WriteLine(text);
			}
			for (int num3 = 0; num3 < this.m_N_info_color_slot_releg; num3++)
			{
				string text = id + ",info_color_slot_releg," + this.m_info_color_slot_releg[num3];
				w.WriteLine(text);
			}
			for (int num4 = 0; num4 < this.m_N_info_color_slot_releg_poss; num4++)
			{
				string text = id + ",info_color_slot_releg_poss," + this.m_info_color_slot_releg_poss[num4];
				w.WriteLine(text);
			}
			for (int num5 = 0; num5 < this.m_N_info_color_slot_adv_group; num5++)
			{
				string text = id + ",info_color_slot_adv_group," + this.m_info_color_slot_adv_group[num5];
				w.WriteLine(text);
			}
			if (this.m_info_slot_champ != -1)
			{
				string text = id + ",info_slot_champ," + this.m_info_slot_champ;
				w.WriteLine(text);
			}
			for (int num6 = 0; num6 < this.m_N_info_slot_promo; num6++)
			{
				string text = id + ",info_slot_promo," + this.m_info_slot_promo[num6];
				w.WriteLine(text);
			}
			for (int num7 = 0; num7 < this.m_N_info_slot_promo_poss; num7++)
			{
				string text = id + ",info_slot_promo_poss," + this.m_info_slot_promo_poss[num7];
				w.WriteLine(text);
			}
			for (int num8 = 0; num8 < this.m_N_info_slot_releg; num8++)
			{
				string text = id + ",info_slot_releg," + this.m_info_slot_releg[num8];
				w.WriteLine(text);
			}
			for (int num9 = 0; num9 < this.m_N_info_slot_releg_poss; num9++)
			{
				string text = id + ",info_slot_releg_poss," + this.m_info_slot_releg_poss[num9];
				w.WriteLine(text);
			}
			if (this.m_info_league_promo != -1)
			{
				string text = id + ",info_league_promo," + this.m_info_league_promo;
				w.WriteLine(text);
			}
			if (this.m_info_league_releg != -1)
			{
				string text = id + ",info_league_releg," + this.m_info_league_releg;
				w.WriteLine(text);
			}
			for (int num10 = 0; num10 < this.m_N_info_special_team_id; num10++)
			{
				if (this.m_info_special_team_id[num10] >= 0)
				{
					string text = id + ",info_special_team_id," + this.m_info_special_team_id[num10];
					w.WriteLine(text);
				}
			}
			if (this.m_advance_pointskeep != -1)
			{
				string text = id + ",advance_pointskeep," + this.m_advance_pointskeep;
				w.WriteLine(text);
			}
			if (this.m_advance_pointskeeppercentage != -1)
			{
				string text = id + ",advance_pointskeeppercentage," + this.m_advance_pointskeeppercentage;
				w.WriteLine(text);
			}
			if (this.m_advance_matchupkeep != -1)
			{
				string text = id + ",advance_matchupkeep," + this.m_advance_matchupkeep;
				w.WriteLine(text);
			}
			if (this.m_advance_standingsrank != -1)
			{
				string text = id + ",advance_standingsrank," + this.m_advance_standingsrank;
				w.WriteLine(text);
			}
			if (this.m_advance_random_draw_event != -1)
			{
				string text = id + ",advance_random_draw_event," + this.m_advance_random_draw_event;
				w.WriteLine(text);
			}
			if (this.m_advance_randomdraw != -1)
			{
				string text = id + ",advance_randomdraw," + this.m_advance_randomdraw;
				w.WriteLine(text);
			}
			if (this.m_advance_maxteamsassoc != -1)
			{
				string text = id + ",advance_maxteamsassoc," + this.m_advance_maxteamsassoc;
				w.WriteLine(text);
			}
			if (this.m_advance_maxteamsgroup != -1)
			{
				string text = id + ",advance_maxteamsgroup," + this.m_advance_maxteamsgroup;
				w.WriteLine(text);
			}
			if (this.m_advance_maxteamsstageref != -1)
			{
				string text = id + ",advance_maxteamsstageref," + this.m_advance_maxteamsstageref;
				w.WriteLine(text);
			}
			if (this.m_advance_calccompavgs != -1)
			{
				string text = id + ",advance_calccompavgs," + this.m_advance_calccompavgs;
				w.WriteLine(text);
			}
			if (this.m_advance_standingskeep != -1)
			{
				string text = id + ",advance_standingskeep," + this.m_advance_standingskeep;
				w.WriteLine(text);
			}
			if (this.m_advance_teamcompdependency != -1)
			{
				string text = id + ",advance_teamcompdependency," + this.m_advance_teamcompdependency;
				w.WriteLine(text);
			}
			return true;
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x0002F7A0 File Offset: 0x0002D9A0
		public static int GetStandingRule(string[] rules)
		{
			if (rules == null)
			{
				return -1;
			}
			if (rules[0] == "POINTS")
			{
				if (rules[1] == "GOALDIFF")
				{
					if (rules[3] == "H2HPOINTS")
					{
						return 5;
					}
					return 0;
				}
				else
				{
					if (rules[1] == "WINS")
					{
						return 1;
					}
					if (rules[1] == "H2HPOINTS")
					{
						return 2;
					}
					return 0;
				}
			}
			else
			{
				if (rules[0] == "TEAMRATING")
				{
					return 3;
				}
				if (rules[0] == "PREVRANK")
				{
					return 4;
				}
				return 0;
			}
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x0002F82C File Offset: 0x0002DA2C
		public static int SetStandingRule(int rulesId, ref string[] rules)
		{
			switch (rulesId)
			{
			case -1:
				return 0;
			case 1:
				rules[0] = "POINTS";
				rules[1] = "WINS";
				rules[2] = "GOALDIFF";
				rules[3] = "GOALSFOR";
				return 4;
			case 2:
				rules[0] = "POINTS";
				rules[1] = "H2HPOINTS";
				rules[3] = "H2HGOALDIFF";
				rules[3] = "H2HGOALSFOR";
				rules[4] = "GOALDIFF";
				rules[5] = "GOALSFOR";
				return 6;
			case 3:
				rules[0] = "TEAMRATING";
				return 1;
			case 4:
				rules[0] = "PREVRANK";
				return 1;
			case 5:
				rules[0] = "POINTS";
				rules[1] = "GOALDIFF";
				rules[2] = "GOALSFOR";
				rules[3] = "H2HPOINTS";
				return 4;
			}
			rules[0] = "POINTS";
			rules[1] = "GOALDIFF";
			rules[2] = "GOALSFOR";
			rules[3] = "WINS";
			return 4;
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x0002F924 File Offset: 0x0002DB24
		public static int GetKo1Rule(string[] rules)
		{
			if (rules == null)
			{
				return -1;
			}
			if (rules[0] == "ET")
			{
				if (rules[1] == "PENS")
				{
					return 0;
				}
			}
			else
			{
				if (rules[0] == "PENS")
				{
					return 1;
				}
				if (rules[0] == "END")
				{
					return 2;
				}
			}
			return -1;
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x0002F97C File Offset: 0x0002DB7C
		public static int SetKo1Rule(int rulesId, ref string[] rules)
		{
			switch (rulesId)
			{
			case -1:
				return 0;
			case 1:
				rules[0] = "PENS";
				return 1;
			case 2:
				rules[0] = "END";
				return 1;
			}
			rules[0] = "ET";
			rules[1] = "PENS";
			return 2;
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x0002F9D0 File Offset: 0x0002DBD0
		public static int GetKo2Rule(string[] rules)
		{
			if (rules == null)
			{
				return -1;
			}
			if (!(rules[0] == "AGG"))
			{
				return -1;
			}
			if (rules[1] == "AWAY")
			{
				return 0;
			}
			if (rules[1] == "ET")
			{
				return 1;
			}
			if (rules[1] == "PENS")
			{
				return 2;
			}
			return 3;
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x0002FA28 File Offset: 0x0002DC28
		public static int SetKo2Rule(int rulesId, ref string[] rules)
		{
			switch (rulesId)
			{
			case -1:
				return 0;
			case 1:
				rules[0] = "AGG";
				rules[1] = "ET";
				rules[2] = "PENS";
				return 3;
			case 2:
				rules[0] = "AGG";
				rules[1] = "PENS";
				return 2;
			case 3:
				rules[0] = "AGG";
				return 1;
			}
			rules[0] = "AGG";
			rules[1] = "AWAY";
			rules[2] = "ET";
			rules[3] = "ET_AWAY";
			rules[4] = "PENS";
			return 5;
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x0002FAC4 File Offset: 0x0002DCC4
		public void UnsetProperty(string property)
		{
			int num = this.IsMultipleProperty(property);
			if (num <= 1)
			{
				this.UnsetProperty(property, 0);
				return;
			}
			for (int i = 0; i < num; i++)
			{
				this.UnsetProperty(property, i);
			}
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x0002FAFA File Offset: 0x0002DCFA
		private void UnsetProperty(string property, int index)
		{
			if (this.IsStringProperty(property))
			{
				this.SetProperty(property, index, null);
				return;
			}
			this.SetProperty(property, index, "-1");
		}

		// Token: 0x040002D3 RID: 723
		private Compobj m_OwnerCompObj;

		// Token: 0x040002D4 RID: 724
		public CompetitionSettings m_ParentSettings;

		// Token: 0x040002D5 RID: 725
		public string m_comp_type;

		// Token: 0x040002D6 RID: 726
		public int m_nation_id = -1;

		// Token: 0x040002D7 RID: 727
		public int m_asset_id = -1;

		// Token: 0x040002D8 RID: 728
		public string m_rule_bookings;

		// Token: 0x040002D9 RID: 729
		public string m_rule_offsides;

		// Token: 0x040002DA RID: 730
		public string m_rule_injuries;

		// Token: 0x040002DB RID: 731
		public int m_rule_numsubsbench = -1;

		// Token: 0x040002DC RID: 732
		public int m_rule_numsubsmatch = -1;

		// Token: 0x040002DD RID: 733
		public int m_rule_suspension = -1;

		// Token: 0x040002DE RID: 734
		public int m_rule_numyellowstored = -1;

		// Token: 0x040002DF RID: 735
		public int m_rule_numgamesbanredmax = -1;

		// Token: 0x040002E0 RID: 736
		public int m_rule_numgamesbanredmin = -1;

		// Token: 0x040002E1 RID: 737
		public int m_rule_numgamesbandoubleyellowmax = -1;

		// Token: 0x040002E2 RID: 738
		public int m_rule_numgamesbandoubleyellowmin = -1;

		// Token: 0x040002E3 RID: 739
		public int m_rule_numgamesbanyellowsmax = -1;

		// Token: 0x040002E4 RID: 740
		public int m_rule_numgamesbanyellowsmin = -1;

		// Token: 0x040002E5 RID: 741
		public int m_standings_pointswin = -1;

		// Token: 0x040002E6 RID: 742
		public int m_standings_pointsdraw = -1;

		// Token: 0x040002E7 RID: 743
		public int m_standings_pointsloss = -1;

		// Token: 0x040002E8 RID: 744
		public string[] m_standings_sort = new string[6];

		// Token: 0x040002E9 RID: 745
		public int m_N_standings_sort;

		// Token: 0x040002EA RID: 746
		public int m_StandingsSort = -1;

		// Token: 0x040002EB RID: 747
		private Stage m_StageAdvanceMaxteamsStageRef;

		// Token: 0x040002EC RID: 748
		private Stage m_StageAdvanceStandingsKeep;

		// Token: 0x040002ED RID: 749
		private Stage m_StageAdvanceStandingsRank;

		// Token: 0x040002EE RID: 750
		private Stage m_StageStandingsCheckRank;

		// Token: 0x040002EF RID: 751
		public int m_match_matchimportance = -1;

		// Token: 0x040002F0 RID: 752
		public string m_match_stagetype;

		// Token: 0x040002F1 RID: 753
		public string m_match_matchsituation;

		// Token: 0x040002F2 RID: 754
		public string m_match_endruleleague;

		// Token: 0x040002F3 RID: 755
		public string[] m_match_endruleko1leg = new string[6];

		// Token: 0x040002F4 RID: 756
		public int m_N_endruleko1leg;

		// Token: 0x040002F5 RID: 757
		public int m_EndRuleKo1Leg = -1;

		// Token: 0x040002F6 RID: 758
		public string m_match_endruleko2leg1;

		// Token: 0x040002F7 RID: 759
		public string[] m_match_endruleko2leg2 = new string[6];

		// Token: 0x040002F8 RID: 760
		public int m_EndRuleKo2Leg2 = -1;

		// Token: 0x040002F9 RID: 761
		public int m_N_endruleko2leg2;

		// Token: 0x040002FA RID: 762
		public string m_match_endrulefriendly;

		// Token: 0x040002FB RID: 763
		public int[] m_match_stadium;

		// Token: 0x040002FC RID: 764
		public int m_N_match_stadium;

		// Token: 0x040002FD RID: 765
		public int m_info_prize_money = -1;

		// Token: 0x040002FE RID: 766
		public int m_info_prize_money_drop = -1;

		// Token: 0x040002FF RID: 767
		public int m_info_color_slot_champ = -1;

		// Token: 0x04000300 RID: 768
		public int[] m_info_color_slot_champ_cup = new int[4];

		// Token: 0x04000301 RID: 769
		public int m_N_info_color_slot_champ_cup;

		// Token: 0x04000302 RID: 770
		public int[] m_info_color_slot_euro_league = new int[4];

		// Token: 0x04000303 RID: 771
		public int m_N_info_color_slot_euro_league;

		// Token: 0x04000304 RID: 772
		public int[] m_info_color_slot_promo = new int[4];

		// Token: 0x04000305 RID: 773
		public int m_N_info_color_slot_promo;

		// Token: 0x04000306 RID: 774
		public int[] m_info_color_slot_promo_poss = new int[4];

		// Token: 0x04000307 RID: 775
		public int m_N_info_color_slot_promo_poss;

		// Token: 0x04000308 RID: 776
		public int[] m_info_color_slot_releg = new int[4];

		// Token: 0x04000309 RID: 777
		public int m_N_info_color_slot_releg;

		// Token: 0x0400030A RID: 778
		public int[] m_info_color_slot_releg_poss = new int[4];

		// Token: 0x0400030B RID: 779
		public int m_N_info_color_slot_releg_poss;

		// Token: 0x0400030C RID: 780
		public int[] m_info_color_slot_adv_group = new int[8];

		// Token: 0x0400030D RID: 781
		public int m_N_info_color_slot_adv_group;

		// Token: 0x0400030E RID: 782
		public int m_info_slot_champ = -1;

		// Token: 0x0400030F RID: 783
		public int[] m_info_slot_promo = new int[4];

		// Token: 0x04000310 RID: 784
		public int m_N_info_slot_promo;

		// Token: 0x04000311 RID: 785
		public int[] m_info_slot_promo_poss = new int[4];

		// Token: 0x04000312 RID: 786
		public int m_N_info_slot_promo_poss;

		// Token: 0x04000313 RID: 787
		public int[] m_info_slot_releg = new int[4];

		// Token: 0x04000314 RID: 788
		public int m_N_info_slot_releg;

		// Token: 0x04000315 RID: 789
		public int[] m_info_slot_releg_poss = new int[4];

		// Token: 0x04000316 RID: 790
		public int m_N_info_slot_releg_poss;

		// Token: 0x04000317 RID: 791
		public int m_info_league_promo = -1;

		// Token: 0x04000318 RID: 792
		public int m_info_league_releg = -1;

		// Token: 0x04000319 RID: 793
		public int[] m_info_special_team_id = new int[8];

		// Token: 0x0400031A RID: 794
		public int m_N_info_special_team_id;

		// Token: 0x0400031B RID: 795
		public string m_schedule_seasonstartmonth;

		// Token: 0x0400031C RID: 796
		public int m_schedule_year_start = -1;

		// Token: 0x0400031D RID: 797
		public int m_schedule_year_offset = -1;

		// Token: 0x0400031E RID: 798
		public int m_schedule_friendlydaysbetweenmin = -1;

		// Token: 0x0400031F RID: 799
		public int m_schedule_friendlydaysbefore = -1;

		// Token: 0x04000320 RID: 800
		public int m_schedule_checkconflict = -1;

		// Token: 0x04000321 RID: 801
		private int m_schedule_compdependency = -1;

		// Token: 0x04000322 RID: 802
		private int m_schedule_forcecomp = -1;

		// Token: 0x04000323 RID: 803
		private int m_schedule_use_dates_comp = -1;

		// Token: 0x04000324 RID: 804
		private int m_schedule_internationaldependency = -1;

		// Token: 0x04000325 RID: 805
		private Trophy m_TrophyCompdependency;

		// Token: 0x04000326 RID: 806
		private Trophy m_TrophyForcecomp;

		// Token: 0x04000327 RID: 807
		public int m_schedule_matchreplay = -1;

		// Token: 0x04000328 RID: 808
		public int m_schedule_reversed = -1;

		// Token: 0x04000329 RID: 809
		public int m_schedule_year_real = -1;

		// Token: 0x0400032A RID: 810
		public int m_num_games = -1;

		// Token: 0x0400032B RID: 811
		public int m_advance_pointskeep = -1;

		// Token: 0x0400032C RID: 812
		public int m_advance_pointskeeppercentage = -1;

		// Token: 0x0400032D RID: 813
		public int m_advance_matchupkeep = -1;

		// Token: 0x0400032E RID: 814
		public int m_advance_random_draw_event = -1;

		// Token: 0x0400032F RID: 815
		public int m_advance_randomdraw = -1;

		// Token: 0x04000330 RID: 816
		public int m_advance_calccompavgs = -1;

		// Token: 0x04000331 RID: 817
		public int m_advance_maxteamsassoc = -1;

		// Token: 0x04000332 RID: 818
		public int m_advance_maxteamsgroup = -1;

		// Token: 0x04000333 RID: 819
		private int m_advance_maxteamsstageref = -1;

		// Token: 0x04000334 RID: 820
		private int m_advance_standingskeep = -1;

		// Token: 0x04000335 RID: 821
		private int m_advance_standingsrank = -1;

		// Token: 0x04000336 RID: 822
		private int m_standings_checkrank = -1;

		// Token: 0x04000337 RID: 823
		public int m_advance_teamcompdependency = -1;

		// Token: 0x04000338 RID: 824
		private League m_LeaguePromo;

		// Token: 0x04000339 RID: 825
		private League m_LeagueReleg;
	}
}
