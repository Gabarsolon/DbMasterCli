using System;

namespace FifaLibrary
{
	// Token: 0x0200009E RID: 158
	public class RefereeList : IdArrayList
	{
		// Token: 0x06000BE7 RID: 3047 RVA: 0x0004DCFC File Offset: 0x0004BEFC
		public RefereeList()
			: base(typeof(Referee))
		{
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x0004DD0E File Offset: 0x0004BF0E
		public RefereeList(DbFile fifaDbFile)
			: base(typeof(Referee))
		{
			this.Load(fifaDbFile);
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x0004DD28 File Offset: 0x0004BF28
		public void Load(DbFile fifaDbFile)
		{
			int num = FifaEnvironment.FifaDb.Table[TI.referee].TableDescriptor.MinValues[FI.referee_refereeid];
			int num2 = FifaEnvironment.FifaDb.Table[TI.referee].TableDescriptor.MaxValues[FI.referee_refereeid];
			Table table = fifaDbFile.Table[TI.referee];
			this.Load(table, num, num2);
			table = fifaDbFile.Table[TI.leaguerefereelinks];
			this.FillFromLeagueRefereeLinks(table);
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x0004DDA4 File Offset: 0x0004BFA4
		public void Load(Table t, int minId, int maxId)
		{
			base.MinId = minId;
			base.MaxId = maxId;
			this.Clear();
			for (int i = 0; i < t.NRecords; i++)
			{
				Referee referee = new Referee(t.Records[i]);
				this.Add(referee);
			}
			base.SortId();
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x0004DDF4 File Offset: 0x0004BFF4
		public void FillFromLeagueRefereeLinks(Table t)
		{
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.leaguerefereelinks_refereeid];
				Referee referee = (Referee)base.SearchId(num);
				if (referee != null)
				{
					referee.FillFromLeagueRefereeLinks(record);
				}
			}
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x0004DE40 File Offset: 0x0004C040
		public void Save(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.referee];
			table.ResizeRecords(this.Count);
			Table table2 = fifaDbFile.Table[TI.leaguerefereelinks];
			int num = 0;
			int num2 = 0;
			foreach (object obj in this)
			{
				Referee referee = (Referee)obj;
				Record record = table.Records[num2];
				referee.SaveReferee(record);
				num2++;
				num += referee.CntLeagues();
			}
			table2.ResizeRecords(num);
			int num3 = 0;
			foreach (object obj2 in this)
			{
				Referee referee2 = (Referee)obj2;
				for (int i = 0; i < referee2.Leagues.Length; i++)
				{
					if (referee2.Leagues[i] != null)
					{
						Record record2 = table2.Records[num3];
						referee2.SaveLeagueRefereeLinks(record2, i);
						num3++;
					}
				}
			}
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x0004DF70 File Offset: 0x0004C170
		public int GetNewRefereeHeadId()
		{
			int num = 0;
			int num2 = FifaEnvironment.FifaDb.Table[TI.referee].TableDescriptor.MinValues[FI.referee_refereeid];
			int num3 = FifaEnvironment.FifaDb.Table[TI.referee].TableDescriptor.MaxValues[FI.referee_refereeid];
			for (int i = num3; i >= num2; i--)
			{
				bool flag = false;
				foreach (object obj in this)
				{
					Referee referee = (Referee)obj;
					if (i == referee.Id)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					num = i;
					break;
				}
			}
			return num;
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x0004E030 File Offset: 0x0004C230
		public Referee FitReferee(string name, int id)
		{
			foreach (object obj in this)
			{
				Referee referee = (Referee)obj;
				if (referee.ToString() == name)
				{
					return referee;
				}
			}
			return null;
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x0004E094 File Offset: 0x0004C294
		public void DeleteReferee(Referee referee)
		{
			base.RemoveId(referee);
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x0004E0A0 File Offset: 0x0004C2A0
		public void LinkCountry(CountryList countryList)
		{
			foreach (object obj in this)
			{
				Referee referee = (Referee)obj;
				referee.LinkCountry(countryList);
			}
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x0004E0F4 File Offset: 0x0004C2F4
		public void LinkLeague(LeagueList leagueList)
		{
			foreach (object obj in this)
			{
				Referee referee = (Referee)obj;
				referee.LinkLeague(leagueList);
			}
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x0004E148 File Offset: 0x0004C348
		public override IdArrayList Filter(IdObject filter)
		{
			if (filter == null)
			{
				return this;
			}
			RefereeList refereeList = new RefereeList();
			if (filter.GetType().Name == "Country")
			{
				Country country = (Country)filter;
				for (int i = 0; i < this.Count; i++)
				{
					Referee referee = (Referee)this[i];
					if (referee.Country == country)
					{
						refereeList.Add(referee);
					}
				}
				return refereeList;
			}
			if (filter.GetType().Name == "League")
			{
				League league = (League)filter;
				for (int j = 0; j < this.Count; j++)
				{
					Referee referee2 = (Referee)this[j];
					if (referee2.IsInLeague(league))
					{
						refereeList.Add(referee2);
					}
				}
				return refereeList;
			}
			return this;
		}

		// Token: 0x0400101E RID: 4126
		public static KitList s_RefereeKits;
	}
}
