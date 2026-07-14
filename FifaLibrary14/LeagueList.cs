using System;

namespace FifaLibrary
{
	// Token: 0x02000033 RID: 51
	public class LeagueList : IdArrayList
	{
		// Token: 0x060004FB RID: 1275 RVA: 0x0001CDF4 File Offset: 0x0001AFF4
		public LeagueList()
			: base(typeof(League))
		{
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0001CE06 File Offset: 0x0001B006
		public LeagueList(DbFile fifaDbFile)
			: base(typeof(League))
		{
			this.Load(fifaDbFile);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0001CE20 File Offset: 0x0001B020
		public void Load(DbFile fifaDbFile)
		{
			Table table = FifaEnvironment.FifaDb.Table[TI.leagues];
			int num = 1;
			int num2 = 2028;
			Table table2 = FifaEnvironment.FifaDb.Table[TI.leagues];
			this.Load(table2, num, num2);
			table2 = fifaDbFile.Table[TI.career_boardoutcomes];
			this.FillFromBoardOutcomes(table2);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0001CE74 File Offset: 0x0001B074
		public void Load(Table t, int minId, int maxId)
		{
			base.MinId = minId;
			base.MaxId = maxId;
			this.Clear();
			for (int i = 0; i < t.NRecords; i++)
			{
				League league = new League(t.Records[i]);
				this.Add(league);
			}
			base.SortId();
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0001CEC4 File Offset: 0x0001B0C4
		public void FillFromBoardOutcomes(Table t)
		{
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.career_boardoutcomes_leagueid];
				League league = (League)base.SearchId(num);
				if (league != null)
				{
					league.FillFromBoardOutcomes(record);
				}
			}
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0001CF10 File Offset: 0x0001B110
		public League AddNewLeague()
		{
			int num = Trophy.AutoAsset();
			if (num < 0)
			{
				return null;
			}
			return (League)base.CreateNewId(num);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0001CF37 File Offset: 0x0001B137
		public void DeleteLeague(League league)
		{
			base.RemoveId(league);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0001CF44 File Offset: 0x0001B144
		public void FillFromLeagueTeamLinks(DbFile fifaDbFile)
		{
			if (FifaEnvironment.Teams == null)
			{
				return;
			}
			Table table = fifaDbFile.Table[TI.leagueteamlinks];
			this.FillFromLeagueTeamLinks(table);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0001CF70 File Offset: 0x0001B170
		public void FillFromLeagueTeamLinks(Table leagueteamlinksTable)
		{
			if (FifaEnvironment.Teams == null)
			{
				return;
			}
			for (int i = 0; i < leagueteamlinksTable.NRecords; i++)
			{
				Record record = leagueteamlinksTable.Records[i];
				int num = record.IntField[FI.leagueteamlinks_teamid];
				int num2 = record.IntField[FI.leagueteamlinks_leagueid];
				Team team = (Team)FifaEnvironment.Teams.SearchId(num);
				if (team == null)
				{
					FifaEnvironment.UserMessages.ShowMessage(5022, num);
				}
				else
				{
					League league = (League)base.SearchId(num2);
					if (league == null)
					{
						FifaEnvironment.UserMessages.ShowMessage(5023, num2);
					}
					else
					{
						league.LinkTeam(team);
						team.League = league;
					}
				}
			}
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0001D024 File Offset: 0x0001B224
		public League SearchLeague(int leagueid)
		{
			return (League)base.SearchId(leagueid);
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0001D034 File Offset: 0x0001B234
		public void Save(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.leagues];
			Table table2 = fifaDbFile.Table[TI.leagueteamlinks];
			Table table3 = fifaDbFile.Table[TI.career_boardoutcomes];
			table.ResizeRecords(this.Count);
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			foreach (object obj in this)
			{
				League league = (League)obj;
				Record record = table.Records[num2];
				num2++;
				league.SaveLeague(record);
				num += league.PlayingTeams.Count;
				if (league.boardoutcomes[0] != 0)
				{
					num3++;
				}
			}
			table2.ResizeRecords(num);
			table3.ResizeRecords(num3);
			int num4 = 0;
			num2 = 0;
			int num5 = 0;
			foreach (object obj2 in this)
			{
				League league2 = (League)obj2;
				foreach (object obj3 in league2.PlayingTeams)
				{
					Team team = (Team)obj3;
					Record record2 = table2.Records[num2];
					league2.SaveTeamLink(record2, team, num4);
					num4++;
					num2++;
				}
				if (league2.boardoutcomes[0] != 0)
				{
					Record record3 = table3.Records[num5];
					league2.SaveBoardOutcomes(record3);
					num5++;
				}
			}
			foreach (object obj4 in this)
			{
				League league3 = (League)obj4;
				int id = league3.Id;
				if (FifaEnvironment.Language != null)
				{
					FifaEnvironment.Language.SetLeagueString(id, Language.ELeagueStringType.Abbr15, league3.ShortName);
					FifaEnvironment.Language.SetLeagueString(id, Language.ELeagueStringType.Full, league3.LongName);
				}
			}
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0001D274 File Offset: 0x0001B474
		public League FitLeague(string name, int id)
		{
			foreach (object obj in this)
			{
				League league = (League)obj;
				if (league.leaguename == name || league.ShortName == name || league.LongName == name)
				{
					return league;
				}
			}
			return null;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0001D2F4 File Offset: 0x0001B4F4
		public override IdArrayList Filter(IdObject filter)
		{
			if (filter == null)
			{
				return this;
			}
			LeagueList leagueList = new LeagueList();
			if (filter.GetType().Name == "Country")
			{
				Country country = (Country)filter;
				for (int i = 0; i < this.Count; i++)
				{
					League league = (League)this[i];
					if (league.Country == country)
					{
						leagueList.Add(league);
					}
				}
				return leagueList;
			}
			return this;
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0001D35C File Offset: 0x0001B55C
		public void LinkCountry(CountryList countryList)
		{
			foreach (object obj in this)
			{
				League league = (League)obj;
				league.LinkCountry(countryList);
			}
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0001D3B0 File Offset: 0x0001B5B0
		public void LinkBall(BallList ballList)
		{
			if (ballList == null)
			{
				return;
			}
			foreach (object obj in this)
			{
				Team team = (Team)obj;
				team.LinkBall(ballList);
			}
		}
	}
}
