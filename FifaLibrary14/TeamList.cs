using System;

namespace FifaLibrary
{
	// Token: 0x020000AA RID: 170
	public class TeamList : IdArrayList
	{
		// Token: 0x06000DB1 RID: 3505 RVA: 0x00053908 File Offset: 0x00051B08
		public TeamList(Type teamType)
			: base(teamType)
		{
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00053911 File Offset: 0x00051B11
		public TeamList()
			: base(typeof(Team))
		{
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00053923 File Offset: 0x00051B23
		public TeamList(DbFile fifaDbFile)
			: base(typeof(Team))
		{
			this.Load(fifaDbFile);
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x0005393C File Offset: 0x00051B3C
		public void Load(DbFile fifaDbFile)
		{
			int num = 130010;
			int num2 = 200000;
			Table table = fifaDbFile.Table[TI.teams];
			this.Load(table, num, num2);
			table = fifaDbFile.Table[TI.nations];
			this.FillFromNations(table);
			table = fifaDbFile.Table[TI.stadiumassignments];
			this.FillFromStadiumAssignments(table);
			table = fifaDbFile.Table[TI.manager];
			this.FillFromManager(table);
			table = fifaDbFile.Table[TI.teamstadiumlinks];
			this.FillFromTeamStadiumLinks(table);
			table = fifaDbFile.Table[TI.teamkits];
			this.FillFromTeamkits(table);
			table = fifaDbFile.Table[TI.teamformationteamstylelinks];
			this.FillFromTeamFormationLinks(table);
			table = fifaDbFile.Table[TI.formations];
			this.FillFromFormations(table);
			table = fifaDbFile.Table[TI.leagueteamlinks];
			this.FillFromLeagueTeamLinks(table);
			table = fifaDbFile.Table[TI.rowteamnationlinks];
			this.FillFromRowTeamNationLinks(table);
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00053A20 File Offset: 0x00051C20
		private void Load(Table t, int minId, int maxId)
		{
			base.MinId = minId;
			base.MaxId = maxId;
			Team[] array = new Team[t.NRecords];
			this.Clear();
			for (int i = 0; i < t.NRecords; i++)
			{
				array[i] = new Team(t.Records[i]);
			}
			this.AddRange(array);
			base.SortId();
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x00053A7C File Offset: 0x00051C7C
		public void FillFromStadiumAssignments(Table t)
		{
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.stadiumassignments_teamid];
				Team team = (Team)base.SearchId(num);
				if (team != null)
				{
					team.FillFromStadiumAssignments(record);
				}
			}
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00053AC8 File Offset: 0x00051CC8
		public void FillFromManager(Table t)
		{
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.manager_teamid];
				Team team = (Team)base.SearchId(num);
				if (team != null)
				{
					team.FillFromManager(record);
				}
			}
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x00053B14 File Offset: 0x00051D14
		public void FillFromTeamStadiumLinks(Table t)
		{
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.teamstadiumlinks_teamid];
				Team team = (Team)base.SearchId(num);
				if (team != null)
				{
					team.FillFromTeamStadiumLinks(record);
				}
			}
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00053B60 File Offset: 0x00051D60
		public void FillFromTeamkits(Table t)
		{
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.teamkits_teamtechid];
				Team team = (Team)base.SearchId(num);
				if (team != null)
				{
					team.FillFromTeamkits(record);
				}
			}
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x00053BAC File Offset: 0x00051DAC
		public void FillFromFormations(Table t)
		{
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.formations_teamid];
				Team team = (Team)base.SearchId(num);
				if (team != null)
				{
					team.FillFromFormations(record);
				}
			}
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00053BF8 File Offset: 0x00051DF8
		public void FillFromTeamFormationLinks(Table t)
		{
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.teamformationteamstylelinks_teamid];
				Team team = (Team)base.SearchId(num);
				if (team != null)
				{
					team.FillFromTeamFormationLinks(record);
				}
			}
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00053C44 File Offset: 0x00051E44
		public void FillFromNations(Table t)
		{
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.nations_teamid];
				Team team = (Team)base.SearchId(num);
				if (team != null)
				{
					team.FillFromNations(record);
				}
			}
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00053C90 File Offset: 0x00051E90
		public void FillFromLeagueTeamLinks(Table t)
		{
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.leagueteamlinks_teamid];
				Team team = (Team)base.SearchId(num);
				if (team != null)
				{
					team.FillFromLeagueTeamLinks(record);
				}
			}
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00053CDC File Offset: 0x00051EDC
		public void FillFromRivals(Table t)
		{
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.rivals_teamid1];
				Team team = (Team)base.SearchId(num);
				int num2 = record.IntField[FI.rivals_teamid2];
				Team team2 = (Team)base.SearchId(num2);
				if (team != null)
				{
				}
			}
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00053D40 File Offset: 0x00051F40
		public void FillFromRowTeamNationLinks(Table t)
		{
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.rowteamnationlinks_teamid];
				Team team = (Team)base.SearchId(num);
				if (team != null)
				{
					team.FillFromRowTeamNationLinks(record);
				}
			}
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00053D8C File Offset: 0x00051F8C
		public void FillFromTeamPlayerLinks(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.teamplayerlinks];
			this.FillFromTeamPlayerLinks(table);
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00053DB0 File Offset: 0x00051FB0
		public void FillFromTeamPlayerLinks(Table t)
		{
			if (FifaEnvironment.Players == null)
			{
				return;
			}
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.teamplayerlinks_teamid];
				Team team = (Team)base.SearchId(num);
				if (team == null)
				{
					FifaEnvironment.UserMessages.ShowMessage(5016, num);
				}
				else
				{
					int num2 = record.IntField[FI.teamplayerlinks_playerid];
					Player player = (Player)FifaEnvironment.Players.SearchId(num2);
					if (player == null)
					{
						FifaEnvironment.UserMessages.ShowMessage(5017, num2);
					}
					else
					{
						player.PlayFor(team);
						TeamPlayer teamPlayer = new TeamPlayer(record, player, team);
						team.Roster.Add(teamPlayer);
					}
				}
			}
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x00053E70 File Offset: 0x00052070
		public void LinkKits(KitList kitList)
		{
			if (kitList == null)
			{
				return;
			}
			foreach (object obj in this)
			{
				Team team = (Team)obj;
				team.LinkKits(kitList);
			}
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00053EC8 File Offset: 0x000520C8
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

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00053F20 File Offset: 0x00052120
		public void LinkStadiums(StadiumList stadiumList)
		{
			foreach (object obj in this)
			{
				Team team = (Team)obj;
				team.LinkStadium(stadiumList);
			}
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00053F74 File Offset: 0x00052174
		public void LinkLeague(LeagueList leagueList)
		{
			foreach (object obj in this)
			{
				Team team = (Team)obj;
				team.LinkLeague(leagueList);
			}
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x00053FC8 File Offset: 0x000521C8
		public void LinkOpponent(TeamList teamList)
		{
			foreach (object obj in this)
			{
				Team team = (Team)obj;
				team.LinkTeam(teamList);
			}
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x0005401C File Offset: 0x0005221C
		public void LinkCountry(CountryList countryList)
		{
			foreach (object obj in this)
			{
				Team team = (Team)obj;
				team.LinkCountry(countryList);
			}
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00054070 File Offset: 0x00052270
		public void LinkFormation(FormationList formationList)
		{
			foreach (object obj in this)
			{
				Team team = (Team)obj;
				team.LinkFormation(formationList);
			}
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x000540C4 File Offset: 0x000522C4
		public void LinkPlayer(PlayerList playerList)
		{
			foreach (object obj in this)
			{
				Team team = (Team)obj;
				team.LinkPlayer(playerList);
			}
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x00054118 File Offset: 0x00052318
		public void Save(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.teams];
			Table table2 = fifaDbFile.Table[TI.teamstadiumlinks];
			Table table3 = fifaDbFile.Table[TI.stadiumassignments];
			Table table4 = fifaDbFile.Table[TI.manager];
			Table table5 = fifaDbFile.Table[TI.rowteamnationlinks];
			Table table6 = fifaDbFile.Table[TI.teamplayerlinks];
			Table table7 = fifaDbFile.Table[TI.teamformationteamstylelinks];
			table.ResizeRecords(this.Count);
			table2.ResizeRecords(this.Count);
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			foreach (object obj in this)
			{
				Team team = (Team)obj;
				Record record = table.Records[num6];
				Record record2 = table2.Records[num6];
				num6++;
				team.SaveTeam(record);
				team.SaveTeamStadiumLinks(record2);
				team.SaveLangTable();
				num += team.Roster.Count;
				if (team.stadiumcustomname != null)
				{
					num2++;
				}
				if (team.ManagerSurname != null)
				{
					num5++;
				}
				if (team.Formation != null && team.Formation.IsGeneric())
				{
					num4++;
				}
				if (team.League != null && team.League.Id == League.GetDefaultLeagueId())
				{
					num3++;
				}
			}
			table6.ResizeRecords(num);
			table3.ResizeRecords(num2);
			table5.ResizeRecords(num3);
			table7.ResizeRecords(num4);
			table4.ResizeRecords(num5);
			int num7 = 0;
			int num8 = 0;
			int num9 = 0;
			int num10 = 0;
			int num11 = 0;
			int num12 = 0;
			foreach (object obj2 in this)
			{
				Team team2 = (Team)obj2;
				foreach (object obj3 in team2.Roster)
				{
					TeamPlayer teamPlayer = (TeamPlayer)obj3;
					Record record3 = table6.Records[num7];
					num7++;
					teamPlayer.Save(record3, num12);
					num12++;
				}
				if (team2.stadiumcustomname != null)
				{
					Record record4 = table3.Records[num8];
					num8++;
					team2.SaveStadiumAssignment(record4);
				}
				if (team2.League == League.GetDefaultLeague())
				{
					Record record5 = table5.Records[num9];
					num9++;
					team2.SaveRowTeamNationLinks(record5);
				}
				if (team2.Formation != null && team2.Formation.IsGeneric())
				{
					Record record6 = table7.Records[num10];
					num10++;
					team2.SaveTeamFormationLinks(record6);
				}
				if (team2.ManagerSurname != null)
				{
					Record record7 = table4.Records[num11];
					num11++;
					team2.SaveManager(record7);
				}
			}
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x00054460 File Offset: 0x00052660
		public override IdArrayList Filter(IdObject filter)
		{
			TeamList teamList = new TeamList();
			if (filter == null)
			{
				return this;
			}
			if (filter.GetType().Name == "League")
			{
				League league = (League)filter;
				for (int i = 0; i < this.Count; i++)
				{
					Team team = (Team)this[i];
					if (team.League == league)
					{
						teamList.Add(team);
					}
				}
				return teamList;
			}
			if (filter.GetType().Name == "Country")
			{
				Country country = (Country)filter;
				for (int j = 0; j < this.Count; j++)
				{
					Team team2 = (Team)this[j];
					if (team2.Country == country)
					{
						teamList.Add(team2);
					}
				}
				return teamList;
			}
			return this;
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x00054521 File Offset: 0x00052721
		public void DeleteTeam(Team team)
		{
			base.RemoveId(team);
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x0005452C File Offset: 0x0005272C
		public Team FitTeam(string name, int id)
		{
			foreach (object obj in this)
			{
				Team team = (Team)obj;
				if (team.DatabaseName == name)
				{
					return team;
				}
			}
			return null;
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x00054590 File Offset: 0x00052790
		public Team IsInTopLeague()
		{
			foreach (object obj in this)
			{
				Team team = (Team)obj;
				if (team.IsInTopLeague())
				{
					return team;
				}
			}
			return null;
		}
	}
}
