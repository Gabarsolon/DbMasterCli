using System;

namespace FifaLibrary
{
	// Token: 0x0200003C RID: 60
	public class KitList : IdArrayList
	{
		// Token: 0x060005B8 RID: 1464 RVA: 0x0002011D File Offset: 0x0001E31D
		public KitList()
			: base(typeof(Kit))
		{
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0002012F File Offset: 0x0001E32F
		public KitList(Type type)
			: base(type)
		{
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00020138 File Offset: 0x0001E338
		public KitList(DbFile fifaDbFile)
			: base(typeof(Kit))
		{
			this.Load(fifaDbFile);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00020154 File Offset: 0x0001E354
		public void Load(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.teamkits];
			int num = table.TableDescriptor.MinValues[FI.teamkits_teamkitid];
			int num2 = table.TableDescriptor.MaxValues[FI.teamkits_teamkitid];
			this.Load(table, num, num2);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0002019C File Offset: 0x0001E39C
		public void Load(Table t, int minId, int maxId)
		{
			base.MinId = minId;
			base.MaxId = maxId;
			this.Clear();
			for (int i = 0; i < t.NRecords; i++)
			{
				Kit kit = new Kit(t.Records[i]);
				bool flag = false;
				while (base.SearchId(kit) != null)
				{
					kit.Id--;
					flag = true;
				}
				this.Add(kit);
				if (flag)
				{
					base.SortId();
				}
			}
			base.SortId();
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00020210 File Offset: 0x0001E410
		public void Save(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.teamkits];
			table.ResizeRecords(this.Count);
			int num = 0;
			int num2 = 0;
			foreach (object obj in this)
			{
				Kit kit = (Kit)obj;
				Record record = table.Records[num];
				kit.SaveKit(record, num2);
				num++;
				num2++;
			}
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x000202A0 File Offset: 0x0001E4A0
		public void LinkTeam(TeamList teamList)
		{
			foreach (object obj in this)
			{
				Kit kit = (Kit)obj;
				kit.LinkTeam(teamList);
			}
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x000202F4 File Offset: 0x0001E4F4
		public bool IsJerseyFontUsed(int jerseyFontId)
		{
			foreach (object obj in this)
			{
				Kit kit = (Kit)obj;
				if (kit.jerseyNumberFont == jerseyFontId)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00020354 File Offset: 0x0001E554
		public Kit GetKit(int teamId, int kitType)
		{
			foreach (object obj in this)
			{
				Kit kit = (Kit)obj;
				if (kit.teamid == teamId && kit.kittype == kitType)
				{
					return kit;
				}
			}
			return null;
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x000203BC File Offset: 0x0001E5BC
		public override IdArrayList Filter(IdObject filter)
		{
			if (filter == null)
			{
				return this;
			}
			KitList kitList = new KitList();
			if (filter.GetType().Name == "Team")
			{
				Team team = (Team)filter;
				if (team != null)
				{
					for (int i = 0; i < this.Count; i++)
					{
						Kit kit = (Kit)this[i];
						if (kit.Team == team)
						{
							kitList.Add(kit);
						}
					}
				}
				return kitList;
			}
			if (filter.GetType().Name == "Country")
			{
				Country country = (Country)filter;
				for (int j = 0; j < this.Count; j++)
				{
					Kit kit2 = (Kit)this[j];
					if (kit2.Team != null && kit2.Team.Country == country)
					{
						kitList.Add(kit2);
					}
				}
				return kitList;
			}
			if (filter.GetType().Name == "League")
			{
				League league = (League)filter;
				for (int k = 0; k < this.Count; k++)
				{
					Kit kit3 = (Kit)this[k];
					if (kit3.Team != null && kit3.Team.League == league)
					{
						kitList.Add(kit3);
					}
				}
				return kitList;
			}
			return this;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x000204F8 File Offset: 0x0001E6F8
		public bool Exists(int teamid, int kittype)
		{
			foreach (object obj in this)
			{
				Kit kit = (Kit)obj;
				if (kit.teamid == teamid && kit.kittype == kittype)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00020560 File Offset: 0x0001E760
		public void DeleteKit(Kit kit)
		{
			base.RemoveId(kit);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0002056C File Offset: 0x0001E76C
		public Kit FitKit(string name, int id)
		{
			foreach (object obj in this)
			{
				Kit kit = (Kit)obj;
				if (kit.ToString() == name)
				{
					return kit;
				}
			}
			return null;
		}
	}
}
