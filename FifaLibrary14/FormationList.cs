using System;

namespace FifaLibrary
{
	// Token: 0x020000A6 RID: 166
	public class FormationList : IdArrayList
	{
		// Token: 0x06000C4E RID: 3150 RVA: 0x0005016E File Offset: 0x0004E36E
		public FormationList()
			: base(typeof(Formation))
		{
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x00050180 File Offset: 0x0004E380
		public FormationList(Type type)
			: base(type)
		{
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x00050189 File Offset: 0x0004E389
		public FormationList(DbFile fifaDbFile)
			: base(typeof(Formation))
		{
			this.Load(fifaDbFile);
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x000501A2 File Offset: 0x0004E3A2
		public FormationList(Table formationsTable, int minId, int maxId)
			: base(typeof(Formation))
		{
			this.Load(formationsTable, minId, maxId);
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x000501C0 File Offset: 0x0004E3C0
		public void Load(DbFile fifaDbFile)
		{
			Table table = FifaEnvironment.FifaDb.Table[TI.formations];
			int num = 1;
			int num2 = 899;
			this.Load(table, num, num2);
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x000501F0 File Offset: 0x0004E3F0
		private void Load(Table formationsTable, int minId, int maxId)
		{
			base.MinId = minId;
			base.MaxId = maxId;
			this.Clear();
			for (int i = 0; i < formationsTable.NRecords; i++)
			{
				Record record = formationsTable.Records[i];
				Formation formation = new Formation(record);
				this.Add(formation);
			}
			base.SortId();
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x00050240 File Offset: 0x0004E440
		public void Save(DbFile fifaDbFile)
		{
			Table table = FifaEnvironment.FifaDb.Table[TI.formations];
			this.Save(table);
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x00050268 File Offset: 0x0004E468
		public void Save(Table formationsTable)
		{
			formationsTable.ResizeRecords(this.Count);
			int num = 0;
			foreach (object obj in this)
			{
				Formation formation = (Formation)obj;
				Record record = formationsTable.Records[num];
				num++;
				formation.Save(record);
			}
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x000502DC File Offset: 0x0004E4DC
		public void LinkTeam(TeamList teamList)
		{
			foreach (object obj in this)
			{
				Formation formation = (Formation)obj;
				formation.LinkTeam(teamList);
			}
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x00050330 File Offset: 0x0004E530
		public Formation GetNearestFormation(Formation formation)
		{
			int num = 384;
			Formation formation2 = null;
			foreach (object obj in this)
			{
				Formation formation3 = (Formation)obj;
				if (formation3 != formation)
				{
					int num2 = formation.ComputeDistance(formation3);
					if (num2 < num)
					{
						num = num2;
						formation2 = formation3;
					}
				}
			}
			return formation2;
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x000503A4 File Offset: 0x0004E5A4
		public Formation GetClosestFormation(Formation formation)
		{
			int num = 384;
			Formation formation2 = null;
			foreach (object obj in this)
			{
				Formation formation3 = (Formation)obj;
				if (formation3 != formation)
				{
					int num2 = formation.ComputeSimilarity(formation3);
					if (num2 < num)
					{
						num = num2;
						formation2 = formation3;
					}
				}
			}
			return formation2;
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x00050418 File Offset: 0x0004E618
		public Formation GetExactFormation(Formation formation)
		{
			int num = 384;
			Formation formation2 = null;
			foreach (object obj in this)
			{
				Formation formation3 = (Formation)obj;
				if (formation3 != formation)
				{
					int num2 = formation.ComputeDistance(formation3);
					if (num2 < num)
					{
						num = num2;
						formation2 = formation3;
					}
				}
			}
			if (num != 0)
			{
				return null;
			}
			return formation2;
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x00050490 File Offset: 0x0004E690
		public Formation FitFormation(string name, int id)
		{
			foreach (object obj in this)
			{
				Formation formation = (Formation)obj;
				if (formation.ToString() == name)
				{
					return formation;
				}
				if (formation.Team != null)
				{
					string text = formation.Team.DatabaseName + " ";
					if (name.StartsWith(text))
					{
						bool flag = true;
						for (int i = text.Length; i < name.Length; i++)
						{
							if (name[i] != '-' && name[i] != '(' && name[i] != ')' && name[i] != 'S' && name[i] != 'W' && (name[i] < '0' || name[i] > '9'))
							{
								flag = false;
								break;
							}
						}
						if (flag)
						{
							return formation;
						}
					}
				}
			}
			return null;
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x000505A0 File Offset: 0x0004E7A0
		public void LinkRoles(RoleList roleList)
		{
			foreach (object obj in this)
			{
				Formation formation = (Formation)obj;
				formation.LinkRoles(roleList);
			}
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x000505F4 File Offset: 0x0004E7F4
		public Formation CreateNewFormation(int newId)
		{
			if (base.SearchId(newId) != null)
			{
				return null;
			}
			Formation formation = (Formation)base.CreateNewId(newId);
			base.InsertId(formation);
			return formation;
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x00050624 File Offset: 0x0004E824
		public Formation CreateNewFormation()
		{
			int newId = this.GetNewId();
			return (Formation)base.CreateNewId(newId);
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00050644 File Offset: 0x0004E844
		public override IdArrayList Filter(IdObject filter)
		{
			if (filter == null)
			{
				return this;
			}
			FormationList formationList = new FormationList();
			if (filter.GetType().Name == "League")
			{
				League league = (League)filter;
				for (int i = 0; i < this.Count; i++)
				{
					Formation formation = (Formation)this[i];
					if (formation.Team != null && formation.Team.League == league)
					{
						formationList.Add(formation);
					}
				}
				return formationList;
			}
			if (filter.GetType().Name == "Country")
			{
				Country country = (Country)filter;
				for (int j = 0; j < this.Count; j++)
				{
					Formation formation2 = (Formation)this[j];
					if (formation2.Team != null && formation2.Team.Country == country)
					{
						formationList.Add(formation2);
					}
				}
				return formationList;
			}
			if (filter.GetType().Name == "Team" || filter.GetType().Name == "CareerTeam")
			{
				Team team = (Team)filter;
				for (int k = 0; k < this.Count; k++)
				{
					Formation formation3 = (Formation)this[k];
					if (formation3.Team != null && formation3.Team == team)
					{
						formationList.Add(formation3);
					}
				}
				return formationList;
			}
			return this;
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00050799 File Offset: 0x0004E999
		public bool DeleteFormation(Formation formation)
		{
			return base.RemoveId(formation);
		}
	}
}
