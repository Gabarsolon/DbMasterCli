using System;
using System.Collections;

namespace FifaLibrary
{
	// Token: 0x02000028 RID: 40
	public class PlayerList : IdArrayList
	{
		// Token: 0x0600044E RID: 1102 RVA: 0x0001A122 File Offset: 0x00018322
		public PlayerList(Type type)
			: base(type)
		{
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0001A12B File Offset: 0x0001832B
		public PlayerList(DbFile fifaDbFile)
			: base(typeof(Player))
		{
			this.Load(fifaDbFile);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0001A144 File Offset: 0x00018344
		public PlayerList()
			: base(typeof(Player))
		{
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0001A158 File Offset: 0x00018358
		public void Load(DbFile fifaDbFile)
		{
			Table table = FifaEnvironment.FifaDb.Table[TI.players];
			int num = 50000;
			int num2 = table.TableDescriptor.MaxValues[FI.players_playerid];
			this.Load(table, num, num2);
			table = fifaDbFile.Table[TI.playerloans];
			this.FillFromPlayerloans(table);
			table = fifaDbFile.Table[TI.previousteam];
			this.FillFromPreviousTeam(table);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0001A1C0 File Offset: 0x000183C0
		public void FillFromPreviousTeam(Table t)
		{
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.previousteam_playerid];
				Player player = (Player)base.SearchId(num);
				if (player != null)
				{
					player.FillFromPreviousTeam(record);
				}
			}
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0001A20C File Offset: 0x0001840C
		public void FillFromPlayerloans(Table t)
		{
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.playerloans_playerid];
				Player player = (Player)base.SearchId(num);
				if (player != null)
				{
					player.FillFromPlayerloans(record);
				}
			}
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0001A258 File Offset: 0x00018458
		public void FillFromEditedPlayerNames(Table t)
		{
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.editedplayernames_playerid];
				Player player = (Player)base.SearchId(num);
				if (player != null)
				{
					player.FillFromEditedPlayerNames(record);
				}
			}
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0001A2A4 File Offset: 0x000184A4
		public void Load(Table table, int minId, int maxId)
		{
			base.MinId = minId;
			base.MaxId = maxId;
			Player[] array = new Player[table.NRecords];
			this.Clear();
			for (int i = 0; i < table.NRecords; i++)
			{
				array[i] = new Player(table.Records[i]);
			}
			this.AddRange(array);
			base.SortId();
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0001A300 File Offset: 0x00018500
		public Player FitPlayer(Player player)
		{
			foreach (object obj in this)
			{
				Player player2 = (Player)obj;
				if (player2.lastname == player.lastname)
				{
					if (player.firstname != null && player.firstname != "")
					{
						if (player2.firstname == player.firstname)
						{
							return player2;
						}
					}
					else if (player2.Id == player.Id)
					{
						return player2;
					}
				}
			}
			return null;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0001A3A8 File Offset: 0x000185A8
		public Player FitPlayer(string name, int id)
		{
			foreach (object obj in this)
			{
				Player player = (Player)obj;
				if (player.ToString() == name)
				{
					return player;
				}
			}
			return null;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0001A40C File Offset: 0x0001860C
		public PlayerList GetFreeAgent()
		{
			PlayerList playerList = new PlayerList();
			foreach (object obj in this)
			{
				Player player = (Player)obj;
				if (player.m_PlayingForTeams == null || player.m_PlayingForTeams.Count == 0)
				{
					playerList.Add(player);
				}
			}
			return playerList;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0001A480 File Offset: 0x00018680
		public void Save(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.players];
			table.ResizeRecords(this.Count);
			Table table2 = fifaDbFile.Table[TI.playerloans];
			Table table3 = fifaDbFile.Table[TI.previousteam];
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			foreach (object obj in this)
			{
				Player player = (Player)obj;
				Record record = table.Records[num];
				if (player.m_assetid != 0)
				{
					num++;
					player.SavePlayer(record);
					if (player.IsLoaned)
					{
						num2++;
					}
					if (player.PreviousTeam != null)
					{
						num3++;
					}
				}
			}
			table2.ResizeRecords(num2);
			table3.ResizeRecords(num3);
			num = 0;
			int num4 = 0;
			foreach (object obj2 in this)
			{
				Player player2 = (Player)obj2;
				if (player2.IsLoaned)
				{
					Record record2 = table2.Records[num];
					num++;
					player2.SavePlayerloans(record2);
				}
				if (player2.PreviousTeam != null)
				{
					Record record3 = table3.Records[num4];
					num4++;
					player2.SavePreviousTeam(record3);
				}
			}
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0001A5F0 File Offset: 0x000187F0
		public ArrayList FindMissedFiles()
		{
			ArrayList arrayList = new ArrayList();
			foreach (object obj in this)
			{
				Player player = (Player)obj;
				if (player.HasSpecificHeadModel)
				{
					if (!FifaEnvironment.FifaFat.IsArchivedFilePresent(player.SpecificFaceTextureFileName()))
					{
						arrayList.Add(string.Concat(new string[]
						{
							"Face #",
							player.Id.ToString(),
							" used by player ",
							player.ToString(),
							"\r\n"
						}));
					}
					if (!FifaEnvironment.FifaFat.IsArchivedFilePresent(player.SpecificHairTexturesFileName()))
					{
						arrayList.Add(string.Concat(new string[]
						{
							"Hair Textures #",
							player.Id.ToString(),
							" used by player ",
							player.ToString(),
							"\r\n"
						}));
					}
				}
			}
			return arrayList;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0001A714 File Offset: 0x00018914
		public override IdArrayList Filter(IdObject filter)
		{
			if (filter == null)
			{
				return this;
			}
			PlayerList playerList = new PlayerList();
			if (filter.GetType().Name == "FreeAgent")
			{
				for (int i = 0; i < this.Count; i++)
				{
					Player player = (Player)this[i];
					if (player.IsFreeAgent())
					{
						playerList.Add(player);
					}
				}
				return playerList;
			}
			if (filter.GetType().Name == "Team" || filter.GetType().Name == "CareerTeam")
			{
				Team team = (Team)filter;
				if (team != null)
				{
					for (int j = 0; j < this.Count; j++)
					{
						Player player2 = (Player)this[j];
						if (player2.IsPlayingFor(team))
						{
							playerList.Add(player2);
						}
					}
				}
				return playerList;
			}
			if (filter.GetType().Name == "MultiClub")
			{
				for (int k = 0; k < this.Count; k++)
				{
					Player player3 = (Player)this[k];
					if (player3.IsMultiClub())
					{
						playerList.Add(player3);
					}
				}
				return playerList;
			}
			if (filter.GetType().Name == "Country")
			{
				Country country = (Country)filter;
				for (int l = 0; l < this.Count; l++)
				{
					Player player4 = (Player)this[l];
					if (player4.Country == country)
					{
						playerList.Add(player4);
					}
				}
				return playerList;
			}
			if (filter.GetType().Name == "Role")
			{
				Role role = (Role)filter;
				for (int m = 0; m < this.Count; m++)
				{
					Player player5 = (Player)this[m];
					if (player5.preferredposition1 == role.Id)
					{
						playerList.Add(player5);
					}
				}
				return playerList;
			}
			if (filter.GetType().Name == "IdString")
			{
				bool flag = filter.ToString() == "Specific";
				for (int n = 0; n < this.Count; n++)
				{
					Player player6 = (Player)this[n];
					if (player6.HasSpecificHeadModel == flag)
					{
						playerList.Add(player6);
					}
				}
				return playerList;
			}
			return this;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0001A950 File Offset: 0x00018B50
		public override IdArrayList Filter(IdObject filter, bool excludeYoung)
		{
			PlayerList playerList = (PlayerList)this.Filter(filter);
			PlayerList playerList2 = new PlayerList();
			foreach (object obj in playerList)
			{
				Player player = (Player)obj;
				if (player.Id < 400000 || !excludeYoung)
				{
					playerList2.Add(player);
				}
			}
			return playerList2;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0001A9CC File Offset: 0x00018BCC
		public bool DeletePlayer(Player player)
		{
			return base.RemoveId(player);
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0001A9D8 File Offset: 0x00018BD8
		public void LinkCountry(CountryList countryList)
		{
			foreach (object obj in this)
			{
				Player player = (Player)obj;
				player.LinkCountry(countryList);
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0001AA2C File Offset: 0x00018C2C
		public void LinkTeam(TeamList teamList)
		{
			foreach (object obj in this)
			{
				Player player = (Player)obj;
				player.LinkTeam(teamList);
			}
		}
	}
}
